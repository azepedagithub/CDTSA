using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlBancario
{
	public partial class frmConciliacionBancaria : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		List<clsEstadoConciliacion> lstEstados = new List<clsEstadoConciliacion>();
		DataTable dtConciliacion = new DataTable();
		DataTable dtMovLibros = new DataTable();
		DataTable dtMovBanco = new DataTable();

		int IDMovBancoSelected = -1;
		int IDMovimientoSelected = -1;
		
		int IDConciliacion = -1;
		BaseEdit editLibros = null;
		BaseEdit editBancos = null;

		String Accion = "";
		Decimal SaldoInicialLibro = 0;
		DataRow currentRow;
		bool LoadEdit = false;
		String sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";

		private void CargarEstados() {
			lstEstados.Clear();
			lstEstados.Add(new clsEstadoConciliacion() { CodEstado = 1, Descr = "Des-asociados" });
			lstEstados.Add(new clsEstadoConciliacion() { CodEstado = 2, Descr = "Asociados" });
			lstEstados.Add(new clsEstadoConciliacion() { CodEstado = -1, Descr = "Todos" });
			
			Util.Util.ConfigLookupEdit(this.slkupTypeView, lstEstados, "Descr", "CodEstado");
			Util.Util.ConfigLookupEditSetViewColumns(this.slkupTypeView, "[{'ColumnCaption':'Descr','ColumnField':'Descr','width':100}]");
			
			this.slkupTypeView.EditValue = -1;
		}

		public frmConciliacionBancaria( String Accion, int IDConciliacion = -1)
		{
			InitializeComponent();
			this.Load += frmConciliacionBancaria_Load;
			this.Accion = Accion;
			this.IDConciliacion = IDConciliacion;
			this.LoadEdit = (this.Accion=="Edit") ?  true: false;

		}

		void frmConciliacionBancaria_Load(object sender, EventArgs e)
		{
			try
			{
				CargarEstados();

				this.gridViewMovBanco.FocusedRowChanged += gridViewMovBanco_FocusedRowChanged;
				this.gridViewMovLibros.FocusedRowChanged += gridViewMovLibros_FocusedRowChanged;

				this.dtpFechaInicial.EditValue = DAC.ConciliacionDAC.GetLasFechaConciliacion();
				this.dtpFechaFinal.EditValue = Convert.ToDateTime(this.dtpFechaInicial.EditValue).AddMonths(1);

				Util.Util.ConfigLookupEdit(this.slkupCuentaBancaria, DAC.CuentaBancariaDAC.GetData(-1, -1).Tables["Data"], "Descr", "IDCuentaBanco");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCuentaBancaria, "[{'ColumnCaption':'Codigo','ColumnField':'Codigo','width':30},{'ColumnCaption':'Descr','ColumnField':'Descr','width':70}]");

				LoadData();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Han ocurrido los siguientes errores" + ex.Message);
			}

		}

		void gridViewMovLibros_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			int index = (int)this.gridViewMovLibros.FocusedRowHandle;
			if (index > -1)
			{
				DataRow ele = this.gridViewMovLibros.GetDataRow(Convert.ToInt32(index));
				if (ele["MatchNumber"] != "" && Convert.ToBoolean(ele["Selected"]) == true)
				{
					IDMovimientoSelected = Convert.ToInt32(ele["IDMovimiento"]);
					IDMovBancoSelected = -1;
				}
			}
		}

		void gridViewMovBanco_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			int index = (int)this.gridViewMovBanco.FocusedRowHandle;
			if (index > -1)
			{
				DataRow ele = this.gridViewMovBanco.GetDataRow(Convert.ToInt32(index));
				if (ele["MatchNumber"].ToString() != "" && Convert.ToBoolean(ele["Selected"]) == true)
				{
					IDMovimientoSelected = -1;
					IDMovBancoSelected = Convert.ToInt32(ele["IDMovBanco"]);
				}
			}
		}

		private void LoadData() {
			if (Accion == "View" || Accion=="Edit")
			{
				dtConciliacion = DAC.ConciliacionDAC.GetData(IDConciliacion, -1).Tables[0];
				currentRow = dtConciliacion.Rows[0];
				this.dtpFechaInicial.EditValue = currentRow["FechaInicio"];
				this.dtpFechaFinal.EditValue = currentRow["FechaFin"];
				this.dtpFechaSaldo.EditValue = this.dtpFechaInicial.EditValue;
				this.slkupCuentaBancaria.EditValue = currentRow["IDCuentaBanco"];
				this.txtSaldoBanco.EditValue = currentRow["SaldoInicialBanco"];
				this.txtSaldoLibro.EditValue = currentRow["SaldoInicialLibro"];
				CargarMovimientosLibros();
				CargarMovimientoBancos();
				if (Accion == "View")
				{
					this.btnAsociar.Enabled = false;
					this.btnConciliar.Enabled = false;
					this.btnDesAsociar.Enabled = false;
					this.btnEliminar.Enabled = false;
					this.btnGuardar.Enabled = false;
					this.btnImportar.Enabled = false;

					//Deshabilitar los controles 
					this.dtpFechaInicial.ReadOnly = true;
					this.dtpFechaFinal.ReadOnly = true;
					this.dtpFechaSaldo.ReadOnly = true;
					this.slkupCuentaBancaria.ReadOnly = true;
					this.gridViewMovBanco.OptionsBehavior.ReadOnly = true;
					this.gridViewMovLibros.OptionsBehavior.ReadOnly = true;
				}
				else if (Accion =="Edit") {
					this.btnAsociar.Enabled = true;
					this.btnConciliar.Enabled = true;
					this.btnDesAsociar.Enabled = true;
					this.btnEliminar.Enabled = true;
					this.btnGuardar.Enabled = true;
					this.btnImportar.Enabled = true;
					
				}

				//TODO Calcular los totales marcados.
			} if (Accion == "New") { 
				//Validar que no exista ciliaciones en proceso
				String sCanAddConciliacion =DAC.ConciliacionDAC.CanAddConciliacionBancaria(); 
				if (sCanAddConciliacion !="Ok") 
				{
					if (sCanAddConciliacion == "EnProceso") {
						MessageBox.Show("Existen conciliaciones en proceso no puede generar una nueva conciliación");
						this.BeginInvoke(new MethodInvoker(this.Close));
					}	
				}

			}
		}

		private void slkupCuentaBancaria_EditValueChanged(object sender, EventArgs e)
		{
			DataRowView drCuenta = (DataRowView)this.slkupCuentaBancaria.GetSelectedDataRow();
			if (drCuenta != null)
			{
				this.txtCuentaContable.Text = drCuenta["IDCuenta"].ToString() + " - " + drCuenta["DescrCuentaContable"].ToString();
				this.txtBanco.Text = drCuenta["IDBanco"].ToString() + " - " + drCuenta["DescrBanco"].ToString();
				this.txtMoneda.Text = drCuenta["IDMoneda"].ToString() + " - " + drCuenta["DescrMoneda"].ToString();
				this.SaldoInicialLibro = DAC.ConciliacionDAC.GetSaldoInicialLibroByCuentaBancaria(Convert.ToInt32(this.slkupCuentaBancaria.EditValue));
				if (this.dtpFechaSaldo.EditValue != null || this.dtpFechaSaldo.EditValue.ToString() != "")
				{
					CargarMovimientosLibros();

				}
				if (LoadEdit)
				{
					this.btnGuardar.ItemAppearance.Normal.BackColor = Color.Transparent;
					this.btnRefrescar.Enabled = true;
					LoadEdit = false;
				}
				else
					this.btnGuardar.ItemAppearance.Normal.BackColor = Color.LawnGreen;
			}
			else
			{
				this.btnImportar.Enabled = false;
			}


		}

		private bool ValidarDatosConciliacion() {
			bool result = true;	  
			String sMensaje = "";
			if (this.slkupCuentaBancaria.EditValue == null || this.slkupCuentaBancaria.EditValue.ToString() == "")
				sMensaje = sMensaje + "\n\r	• Seleccione la cuenta bancaria";
			if (this.dtpFechaInicial.EditValue == null || this.dtpFechaInicial.EditValue.ToString() == "")
				sMensaje = sMensaje + "\n\r	• Seleccione la Fecha Inicial";
			if (this.dtpFechaFinal.EditValue == null || this.dtpFechaFinal.EditValue.ToString() == "")
				sMensaje = sMensaje + "\n\r	• Seleccione la Fecha Final";

			if (sMensaje != "") {
				MessageBox.Show("Por favor verifique los siguientes campos : \n\r " + sMensaje);
				result = false;
			}
			return result;
		}

		private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (ValidarDatosConciliacion())
			{
				if (this.Accion == "New")
				{
					dtConciliacion = DAC.ConciliacionDAC.GetData(-7, -7).Tables[0];
					currentRow = dtConciliacion.NewRow();
					currentRow["IDConciliacion"] = -1;
					currentRow["IDCuentaBanco"] = this.slkupCuentaBancaria.EditValue;
					currentRow["FechaInicio"] = Convert.ToDateTime(this.dtpFechaInicial.EditValue);
					currentRow["FechaFin"] = Convert.ToDateTime(this.dtpFechaFinal.EditValue);
					currentRow["Usuario"] = sUsuario;

					dtConciliacion.Rows.Add(currentRow);
					try
					{
						DAC.ConciliacionDAC.oAdaptador.Update(dtConciliacion);
						this.IDConciliacion = Convert.ToInt32(DAC.ConciliacionDAC.oAdaptador.InsertCommand.Parameters["@IDConciliacion"].Value);
						dtConciliacion.AcceptChanges();
						lblStatus.Caption = "Se ha ingresado un nuevo registro";
						Application.DoEvents();
						this.Accion = "Edit";
						this.btnImportar.Enabled = true;
						
					}
					catch (System.Data.SqlClient.SqlException ex)
					{
						dtConciliacion.RejectChanges();
						currentRow = null;
						MessageBox.Show(ex.Message);
					}
				}
				else if (Accion == "Edit")
				{
					if (currentRow != null)
					{
						//lblStatus.Caption = "Actualizando : " + currentRow["Descr"].ToString();

						Application.DoEvents();
						currentRow.BeginEdit();

						currentRow["IDConciliacion"] = IDConciliacion;
						currentRow["IDCuentaBanco"] = this.slkupCuentaBancaria.EditValue;
						currentRow["FechaInicio"] = Convert.ToDateTime(this.dtpFechaInicial.EditValue);
						currentRow["FechaFin"] = Convert.ToDateTime(this.dtpFechaFinal.EditValue);
						currentRow["Usuario"] = sUsuario;

						currentRow.EndEdit();

						DataTable dtChanges = dtConciliacion.GetChanges(DataRowState.Modified);

						if (dtChanges == null) return;

						//Si no hay errores
						try
						{

							DAC.ConciliacionDAC.oAdaptador.Update(dtChanges);
							//lblStatus.Caption = "Actualizado " + currentRow["Descr"].ToString();
							Application.DoEvents();
							//Accion = "View";
							dtConciliacion.AcceptChanges();
							//PopulateGrid();
							//SetCurrentRow();
							//HabilitarControles(false);
							//AplicarPrivilegios();
						}
						catch (System.Data.SqlClient.SqlException ex)
						{
							dtConciliacion.RejectChanges();
							currentRow = null;
							MessageBox.Show(ex.Message);
						}
					}
				}

				this.btnGuardar.ItemAppearance.Normal.BackColor = Color.Transparent;
				this.btnEliminar.Enabled = true;
				this.btnRefrescar.Enabled = true;
			}
		}

		private void dtpFechaInicial_EditValueChanged(object sender, EventArgs e)
		{
			this.dtpFechaSaldo.EditValue = this.dtpFechaInicial.EditValue;
		}

		private void CargarMovimientosLibros()
		{
			dtMovLibros = DAC.ConciliacionDAC.GetMovimientoLibrosContables(Convert.ToInt32(this.slkupCuentaBancaria.EditValue), Convert.ToDateTime(this.dtpFechaSaldo.EditValue), Convert.ToDateTime(this.dtpFechaFinal.EditValue));
			this.gridMobLibros.DataSource = null;
			this.gridMobLibros.DataSource = dtMovLibros;
		}

		private void CargarMovimientoBancos() {
			this.gridMovBanco.DataSource = null;
			dtMovBanco = DAC.ConcMovBancosDAC.GetData(this.IDConciliacion, -1).Tables[0];
			this.gridMovBanco.DataSource = dtMovBanco;
		}

		private void dtpFechaSaldo_EditValueChanged(object sender, EventArgs e)
		{
			//Cargar Movi
			if (this.slkupCuentaBancaria.EditValue != null )
			{
				CargarMovimientosLibros();
				HabilitarBtnAsociacion();
				CargarSaldoLibros();
			}
		}

		private void CargarSaldoLibros() {
			Decimal Saldo = DAC.CuentaBancariaDAC.GetSaldoCuentaLibro(Convert.ToInt32(this.slkupCuentaBancaria.EditValue), Convert.ToDateTime(this.dtpFechaSaldo.EditValue), 2);
			this.txtSaldoLibro.EditValue = Saldo;
		}

		private void CargarSaldoBancos()
		{
			Decimal Saldo = DAC.CuentaBancariaDAC.GetSaldoCuentaBanco(Convert.ToInt32(this.slkupCuentaBancaria.EditValue), Convert.ToDateTime(this.dtpFechaSaldo.EditValue));
			this.txtSaldoBanco.EditValue = Saldo;
		}

		private void btnImportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (this.slkupCuentaBancaria.EditValue != null && this.IDConciliacion != -1)
			{
				frmImportMovBancos ofrmMovBancos = new frmImportMovBancos(Convert.ToInt32(this.slkupCuentaBancaria.EditValue),this.IDConciliacion);
				ofrmMovBancos.FormClosed += ofrmMovBancos_FormClosed;
				ofrmMovBancos.ShowDialog();
			}
		}

		private void HabilitarBtnAsociacion() {

			if (this.dtMovLibros.Rows.Count > 0)
			{
				this.btnAsociar.Enabled = true;
				this.btnDesAsociar.Enabled = true;
			}
			else
			{
				this.btnAsociar.Enabled = false;
				this.btnDesAsociar.Enabled = false;
			}
		}

		void ofrmMovBancos_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmImportMovBancos ofrmImport = (frmImportMovBancos) sender;
			if (ofrmImport.DialogResult == System.Windows.Forms.DialogResult.OK) {
				//dtMovBanco = ofrmImport.dtMovBancos;
				CargarMovimientoBancos();
				HabilitarBtnAsociacion();
				this.btnRefrescar.Enabled = true;
				this.btnFormato.Enabled = true;
				
			}
		}


		private void AsociarReferencias() {
			this.gridViewMovBanco.PostEditor();
			gridViewMovBanco.UpdateCurrentRow();


			this.gridViewMovLibros.PostEditor();
			gridViewMovLibros.UpdateCurrentRow();



			String lstMovBancoSelected = "";
			String lstMovLibroSelected = "";
			Decimal TotalBancos = 0;
			Decimal TotalLibros = 0;

			//Recorrer la grilla de mov libros
			//DataView dvSelectMovLibros = new DataView(((DataTable)this.gridMobLibros.DataSource));			
			DataTable dtSelectMovLibros = (DataTable)this.gridMobLibros.DataSource;
			DataTable dtSelectMovBancos = (DataTable)this.gridMovBanco.DataSource;

			DataRow[] dtLibros = dtSelectMovLibros.Select("Selected = 1 and MatchNumber is null");
			DataRow[] dtBancos = dtSelectMovBancos.Select("Selected = 1 and MatchNumber is null");

			if (dtLibros.Count() == 0 || dtBancos.Count() == 0)
			{
				MessageBox.Show("Por favor seleccione los documentos en ambas listas");
				return;
			}

			foreach (DataRow fila in dtLibros)
			{
				lstMovLibroSelected = lstMovLibroSelected + fila["IDMovimiento"].ToString() + "|";
				TotalLibros += Convert.ToDecimal(fila["monto"]);
			}
			if (dtLibros.Count() > 0)
				lstMovLibroSelected = lstMovLibroSelected.Substring(0, lstMovLibroSelected.Length - 1);

			foreach (DataRow fila in dtBancos)
			{
				lstMovBancoSelected = lstMovBancoSelected + fila["IDMovBanco"].ToString() + "|";
				TotalBancos += Convert.ToDecimal(fila["monto"]);
			}

			if (TotalBancos != TotalLibros)
			{
				MessageBox.Show("Los Montos a asociar deben de ser iguales");
				return;
			}

			if (dtBancos.Count() > 0)
				lstMovBancoSelected = lstMovBancoSelected.Substring(0, lstMovBancoSelected.Length - 1);

			Security.ConnectionManager.BeginTran();
			DAC.ConciliacionDAC.MatchElements(this.IDConciliacion, Convert.ToInt32(this.slkupCuentaBancaria.EditValue), lstMovBancoSelected, lstMovLibroSelected, Security.ConnectionManager.Tran);
			Security.ConnectionManager.CommitTran();

			CargarMovimientosLibros();
			CargarMovimientoBancos();
			CalcularTotalesMovBanco();
			CalcularTotalesMovLibros();
			CalcularTotalesSelectMovBanco();
			CalcularTotalesSelectMovLibros();
			ValidarElementosToAsociar();
		}
	
		private void btnAsociar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			AsociarReferencias();
					  
		}

		private void btnDesAsociar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			//encontrar el elemento seleccionado
			

			//int? fila =this.gridViewMovLibros.GetSelectedRows().First();
			//if (fila != null) {
			//	DataRow ele =  this.gridViewMovLibros.GetDataRow(Convert.ToInt32(fila));
			//	if (ele["MatchNumber"] != "" || Convert.ToBoolean(ele["Selected"]) == true) { 
			//		IDMovimientoSelected = Convert.ToInt32( ele["IDMovimiento"]);
			//	}
			//}
			//fila = null;
			//fila =this.gridViewMovBanco.GetSelectedRows().First();
			//if (fila != null) {
			//	DataRow ele =  this.gridViewMovBanco.GetDataRow(Convert.ToInt32(fila));
			//	if (ele["MatchNumber"] != "" || Convert.ToBoolean(ele["Selected"]) == true) { 
			//		IDMovBancoSelected = Convert.ToInt32( ele["IDMovBanco"]);
			//	}
			//}

			if (IDMovBancoSelected != -1 || IDMovimientoSelected != -1)
			{
				Security.ConnectionManager.BeginTran();
				DAC.ConciliacionDAC.UnMatchElements(this.IDConciliacion, Convert.ToInt32(this.slkupCuentaBancaria.EditValue), IDMovBancoSelected, IDMovimientoSelected, Security.ConnectionManager.Tran);
				Security.ConnectionManager.CommitTran();
			}
			CargarMovimientosLibros();
			CargarMovimientoBancos();

			CalcularTotalesMovBanco();
			CalcularTotalesMovLibros();
			CalcularTotalesSelectMovBanco();
			CalcularTotalesSelectMovLibros();
			ValidarElementosToAsociar();
		}


		private void ValidarElementosToAsociar() {
			if (Convert.ToDecimal(this.txtSelectedBancos.EditValue) == Convert.ToDecimal(this.txtSelectedLibros.EditValue))
			{
				if (Convert.ToDecimal(this.txtSelectedLibros.EditValue) != 0)
				{
					this.txtSelectedBancos.BackColor = Color.LightGreen;
					this.txtSelectedLibros.BackColor = Color.LightGreen;
				}
				else
				{
					this.txtSelectedBancos.BackColor = Color.White;
					this.txtSelectedLibros.BackColor = Color.White;
				}
			}
			else
			{
				this.txtSelectedBancos.BackColor = Color.LightCoral;
				this.txtSelectedLibros.BackColor = Color.LightCoral;
			}
		}
		
		private void gridViewMovLibros_ShowingEditor(object sender, CancelEventArgs e)
		{
			DataRow ele =  this.gridViewMovLibros.GetDataRow(Convert.ToInt32(gridViewMovLibros.FocusedRowHandle));
			e.Cancel = gridViewMovLibros.FocusedColumn.FieldName == "Selected" && Convert.ToBoolean(ele["Selected"]) == true && ele["MatchNumber"].ToString() != "";
			 
		}

		private void gridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView view = sender as GridView;
			if (e.RowHandle != -1)
			{

				bool _mark = (bool)view.GetRowCellValue(e.RowHandle, "Selected");
				Color color = _mark ? Color.FromArgb(175, 252, 191) : Color.FromArgb(254, 224, 224);
				e.Appearance.BackColor = color;
				view.Appearance.SelectedRow.BackColor = color;

				//if (view.FocusedRowHandle == e.RowHandle)
				view.Appearance.FocusedRow.BackColor = color;
				view.Appearance.SelectedRow.BackColor = color;
				view.Appearance.HideSelectionRow.BackColor = color;
				view.Appearance.FocusedCell.BackColor = color;

			}
		}


		private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{
			GridView view = sender as GridView;
			if (e.RowHandle != -1)
			{
				if (e.CellValue != null)
				{
					bool _mark = (bool)view.GetRowCellValue(e.RowHandle, "Selected");
					Color color = _mark ? Color.FromArgb(175, 252, 191) : Color.FromArgb(254, 224, 224);
					e.Appearance.BackColor = color;
				}
			}


		}

		private void gridViewMovLibros_ShownEditor(object sender, EventArgs e)
		{
			GridView view = sender as GridView;
			editLibros = view.ActiveEditor;
			editLibros.EditValueChanged += edit_EditValueChanged; 
		}

		void edit_EditValueChanged(object sender, EventArgs e)
		{
			gridViewMovLibros.PostEditor();
			CalcularTotalesMovLibros();
			CalcularTotalesSelectMovLibros();
			ValidarElementosToAsociar();
		}

		private void CalcularTotalesSelectMovLibros()
		{
			decimal dTotal = 0;
			foreach (DataRow e in dtMovLibros.Rows)
			{
				if (Convert.ToBoolean(e["Selected"]) == true && e["MatchNumber"].ToString() == "")
				{
					dTotal = dTotal + Convert.ToDecimal(e["Monto"]);
				}
			}
			this.txtSelectedLibros.EditValue = dTotal.ToString("N2");
		}

		
		private void CalcularTotalesMovLibros() {
			decimal dTotal = 0;
			foreach (DataRow e in dtMovLibros.Rows) { 
				if (Convert.ToBoolean(e["Selected"]) == true && e["MatchNumber"].ToString() != "") {
					dTotal = dTotal + Convert.ToDecimal(e["Monto"]);
				} 
			}
			this.txtMarcadosLibros.EditValue = dTotal.ToString("N2");
			this.txtDiferencia.EditValue = (Convert.ToDecimal(this.txtMarcadosLibros.EditValue) - Convert.ToDecimal(this.txtTotalMarcadoBanco.EditValue)).ToString("N2");
		}

		private void CalcularTotalesMovBanco()
		{
			decimal dTotal = 0;
			foreach (DataRow e in this.dtMovBanco.Rows)
			{
				if (Convert.ToBoolean(e["Selected"]) == true && e["MatchNumber"].ToString() != "")
				{
					dTotal = dTotal + Convert.ToDecimal(e["Monto"]);
				}
			}
			this.txtTotalMarcadoBanco.EditValue = dTotal.ToString("N2");
			this.txtDiferencia.EditValue = (Convert.ToDecimal(this.txtMarcadosLibros.EditValue) - Convert.ToDecimal(this.txtTotalMarcadoBanco.EditValue)).ToString("N2");
		}

		private void CalcularTotalesSelectMovBanco()
		{
			decimal dTotal = 0;
			foreach (DataRow e in this.dtMovBanco.Rows)
			{
				if (Convert.ToBoolean(e["Selected"]) == true && e["MatchNumber"].ToString() == "")
				{
					dTotal = dTotal + Convert.ToDecimal(e["Monto"]);
				}
			}
			this.txtSelectedBancos.EditValue = dTotal.ToString("N2");
			
		}

		private void gridViewMovLibros_HiddenEditor(object sender, EventArgs e)
		{
			editLibros.EditValueChanged -= edit_EditValueChanged;
			editLibros = null;
		}

		private void gridViewMovBanco_ShownEditor(object sender, EventArgs e)
		{
			GridView view = sender as GridView;
			editBancos = view.ActiveEditor;
			editBancos.EditValueChanged += edit_EditBancosValueChanged;
		}

		void edit_EditBancosValueChanged(object sender, EventArgs e)
		{
			gridViewMovBanco.PostEditor();
			CalcularTotalesMovBanco();
			CalcularTotalesSelectMovBanco();
			ValidarElementosToAsociar();
		}

		private void gridViewMovBancos_HiddenEditor(object sender, EventArgs e)
		{
			editBancos.EditValueChanged -= edit_EditBancosValueChanged;
			editBancos = null;
		}

		private void gridViewMovBanco_ShowingEditor(object sender, CancelEventArgs e)
		{
			DataRow ele = this.gridViewMovBanco.GetDataRow(Convert.ToInt32(this.gridViewMovBanco.FocusedRowHandle));
			e.Cancel = gridViewMovBanco.FocusedColumn.FieldName == "Selected" && Convert.ToBoolean(ele["Selected"]) == true && ele["MatchNumber"].ToString() != "";
		}

		private void btnAsociarSimilares_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			bool hasFound = false;
			bool hasMatch = false;
			foreach (DataRow filaBanco in this.dtMovBanco.Rows)
			{
				if (Convert.ToBoolean(filaBanco["Selected"]) == false ) {
					foreach (DataRow filaLibro in this.dtMovLibros.Rows) {
						if (Convert.ToBoolean(filaLibro["Selected"]) == false ) { 
							if (filaBanco["Referencia"].ToString() == filaLibro["Referencia"].ToString() &&  Convert.ToDecimal(filaBanco["Monto"]) == Convert.ToDecimal(filaLibro["Monto"])) {
								filaLibro["Selected"] = true;
								hasFound = true;
							}
						} 
					}
					if (hasFound) {
						filaBanco["Selected"] = true;
						if (hasMatch == false)
							hasMatch = true;
						hasFound = false;
					}
				}
			}
			if (hasMatch)
				AsociarReferencias();
			else {
				MessageBox.Show("No se encontraron registros que concuerden");
			}
		}

		private void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LoadData();
		}

		
		
	}

	public class clsEstadoConciliacion							
	{
		public int CodEstado { get; set; }
		public String Descr { get; set; }
	}
}

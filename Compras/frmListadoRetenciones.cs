using CG;
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

namespace CO
{
	public partial class frmListadoRetenciones : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		private DataTable _dtCentro;
		private DataTable _dtCuenta;

		private DataTable _dtRetenciones;

        private DataTable _dtSecurity;

        DataRow currentRow;
        string _sUsuario = (UsuarioDAC._DS.Tables.Count>0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
        const String _tituloVentana = "Listado de Retenciones";
		private String _sAccion = "View";

		int IDRetencion, IDCentro;
		string Descr;
		bool AplicaTotalFactura, AplicaSubTotal, AplicaSubTotalMenosDesc, Activo;
		decimal Porcentaje, MontoMinimo;
		long IDCuenta;

		public frmListadoRetenciones()
		{
			InitializeComponent();
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void CargarPrivilegios()
		{
			DataSet DS = new DataSet();
			DS = UsuarioDAC.GetAccionModuloFromRole(0, _sUsuario);
			_dtSecurity = DS.Tables[0];

			AplicarPrivilegios();
		}

		private void AplicarPrivilegios()
		{
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.AgregarCentroCosto, _dtSecurity))
				this.btnAgregar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.EditarCentroCosto, _dtSecurity))
				this.btnEditar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.EliminarCentroCosto, _dtSecurity))
				this.btnEliminar.Enabled = false;
		}

		private void EnlazarEventos()
		{
			this.btnAgregar.ItemClick += btnAgregar_ItemClick;
			this.btnEditar.ItemClick += btnEditar_ItemClick;
			this.btnEliminar.ItemClick += btnEliminar_ItemClick;
			this.btnGuardar.ItemClick += btnGuardar_ItemClick;
			this.btnCancelar.ItemClick += btnCancelar_ItemClick;
			this.btnExportar.ItemClick += BtnExportar_ItemClick;
			this.btnRefrescar.ItemClick += btnRefrescar_ItemClick;
			this.gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
		}

		void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			PopulateGrid();
		}

		private void BtnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			string tempPath = System.IO.Path.GetTempPath();
			String FileName = System.IO.Path.Combine(tempPath, "lstRetenciones.xlsx");
			DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions()
			{
				SheetName = "Listado de Retenciones"
			};


			this.gridView1.ExportToXlsx(FileName, options);
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo.FileName = FileName;
			process.StartInfo.Verb = "Open";
			process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
			process.Start();
		}



		private void PopulateGrid()
		{
			_dtRetenciones = DAC.clsRetencionesDAC.Get(-1, "*").Tables[0];

			this.dtgRetenciones.DataSource = null;
			this.dtgRetenciones.DataSource = _dtRetenciones;

		}

		private void ClearControls()
		{
			this.txtDescr.Text = "";
			this.txtMontoMinimo.Text = "";
			this.txtPorcentaje.Text = "";
			this.rdgComportamiento.EditValue = null;
			this.slkupCentroRetencion.EditValue = "";
			this.slkupCuentaRetencion.EditValue = "";
			this.chkActivo.EditValue = true;
			
		}

		private void HabilitarControles(bool Activo)
		{
			//this.txtNivel1.ReadOnly = Activo;
			//this.txtNivel2.ReadOnly = Activo;
			//this.txtNivel3.ReadOnly = Activo;
			this.txtDescr.ReadOnly = !Activo;
			this.chkActivo.ReadOnly = !Activo;
			this.txtPorcentaje.ReadOnly = !Activo;
			this.txtPorcentaje.ReadOnly = !Activo;
			this.rdgComportamiento.ReadOnly = !Activo;
			this.slkupCentroRetencion.ReadOnly = !Activo;
			this.slkupCuentaRetencion.ReadOnly = !Activo;

			this.dtgRetenciones.Enabled = !Activo;

			this.btnAgregar.Enabled = !Activo;
			this.btnEditar.Enabled = !Activo;
			this.btnGuardar.Enabled = Activo;
			this.btnCancelar.Enabled = Activo;
			this.btnEliminar.Enabled = !Activo;
			this.btnExportar.Enabled = !Activo;
			this.btnRefrescar.Enabled = !Activo;

		}


		private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void frmListadoRetenciones_Load(object sender, EventArgs e)
		{
			try
			{
				HabilitarControles(false);

				Util.Util.SetDefaultBehaviorControls(this.gridView1, false, this.dtgRetenciones, _tituloVentana, this);

				EnlazarEventos();
				
				_dtCentro = CentroCostoDAC.GetData(-1, "*", "*", "*", "*", "*", 1).Tables["Data"];
				_dtCuenta = CuentaContableDAC.GetData(-1, -1, -1, "*", "*", "*", "*", "*", "*", "*", -1, 0, 1, 1, -1, -1).Tables["Data"];

				Util.Util.ConfigLookupEdit(this.slkupCentroRetencion, _dtCentro, "Descr", "IDCentro");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCentroRetencion, "[{'ColumnCaption':'Centro','ColumnField':'Centro','width':50},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");


				Util.Util.ConfigLookupEdit(this.slkupCuentaRetencion, _dtCuenta, "Descr", "IDCuenta");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCuentaRetencion, "[{'ColumnCaption':'Cuenta','ColumnField':'Cuenta','width':50},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");


				PopulateGrid();

				CargarPrivilegios();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void SetCurrentRow()
		{
			int index = (int)this.gridView1.FocusedRowHandle;
			if (index > -1)
			{
				currentRow = gridView1.GetDataRow(index);
				UpdateControlsFromCurrentRow(currentRow);
			}
		}

		private void UpdateControlsFromCurrentRow(DataRow Row)
		{
			this.txtDescr.Text = Row["Descr"].ToString();
			this.txtMontoMinimo.Text = Row["MontoMinimo"].ToString();
			this.txtPorcentaje.Text = Row["Porcentaje"].ToString();
			this.slkupCentroRetencion.EditValue = Row["IDCentroRet"];
			this.slkupCuentaRetencion.EditValue = Row["IDCuentaRet"];
			this.chkActivo.EditValue = Row["Activo"].ToString();
			bool AplicaTotalFactura = Convert.ToBoolean(Row["AplicaTotalFactura"]);
			bool AplicaSubTotal = Convert.ToBoolean(Row["AplicaSubTotal"]);
			bool AplicaSubTotalMenosDesc = Convert.ToBoolean(Row["AplicaSubTotalMenosDesc"]);
			if (AplicaSubTotal) 
				this.rdgComportamiento.EditValue= 2;
			else if (AplicaTotalFactura) 
				this.rdgComportamiento.EditValue=1;
			else if (AplicaSubTotalMenosDesc)
				this.rdgComportamiento.EditValue= 3;
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			SetCurrentRow();
		}




		private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			_sAccion = "New";
			HabilitarControles(true);
			ClearControls();
			currentRow = null;

			//Agregar  los consecutivos
			this.IDRetencion = -1;
			this.txtDescr.Focus();
		}

		private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (currentRow == null)
			{
				lblStatus.Caption = "Por favor seleccione un elemento de la Lista";
				return;
			}
			else
				lblStatus.Caption = "";

			_sAccion = "Edit";
			HabilitarControles(true);
			
			lblStatus.Caption = "Editando el registro : " + currentRow["Descr"].ToString();
			this.txtDescr.Focus();
		}

		private bool ValidarDatos()
		{
			bool result = true;
			String sMensaje = "";
			//Este solo vale para el primer elemento
			if (this.txtDescr.Text == "")
				sMensaje = sMensaje + "     • Descripción de la Retención \n\r";
			if (this.txtMontoMinimo.Text == "")
				sMensaje = sMensaje + "     • Monto mínimo para poder aplicar la retencion. \n\r";
			if (this.txtPorcentaje.Text == "")
				sMensaje = sMensaje + "     • Porcentaje de la retencion. \n\r";
			if (this.slkupCentroRetencion.EditValue == null)
				sMensaje = sMensaje + "     • Centro de Costo de la retencion. \n\r";
			if (this.slkupCuentaRetencion.EditValue == null)
				sMensaje = sMensaje + "     • Cuenta Contable de la retencion. \n\r";
			if (this.rdgComportamiento.EditValue == null)
				sMensaje = sMensaje + "     • Comportamiento de la retencion. \n\r";
			//if (Convert.ToBoolean(this.chkAcumulador.EditValue) == true)
			//    if (this.slkupCentroAcumulador.EditValue == null)
			//        sMensaje = sMensaje + "     • Centro Acumulador. \n\r";
			if (sMensaje != "")
			{
				result = false;
				MessageBox.Show("Por favor revise los siguientes campos, puede que sean obligatorios: \n\r\n\r" + sMensaje);
			}
			return result;
		}

		private void ObtenerDatos()
		{
			Descr = this.txtDescr.Text.Trim();
			Porcentaje = Convert.ToDecimal(this.txtPorcentaje.Text.Trim());
			MontoMinimo = Convert.ToDecimal(this.txtMontoMinimo.Text.Trim());
			Activo = Convert.ToBoolean(this.chkActivo.Checked);
			IDCentro = Convert.ToInt32(this.slkupCentroRetencion.EditValue);
			IDCuenta = Convert.ToInt64(this.slkupCuentaRetencion.EditValue);
			int iComportamiento = Convert.ToInt32(this.rdgComportamiento.EditValue);
			switch (iComportamiento) { 
				case 1:
					AplicaTotalFactura = true;
					AplicaSubTotal = false;
					AplicaSubTotalMenosDesc = false;
					break;
				case 2:
					AplicaTotalFactura = false;
					AplicaSubTotal = true;
					AplicaSubTotalMenosDesc = false;
					break;
				case 3:
					AplicaTotalFactura = false;
					AplicaSubTotal = false;
					AplicaSubTotalMenosDesc = true;
					break;
			}
			
		}

		private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (!ValidarDatos())
					return;

				ObtenerDatos();
				String Operacion = "";

				if (_sAccion == "New")
					Operacion = "I";
				else
					Operacion = "U";
				ConnectionManager.BeginTran();
				DAC.clsRetencionesDAC.InsertUpdate(Operacion, ref IDRetencion, Descr,Porcentaje,AplicaTotalFactura,AplicaSubTotal,AplicaSubTotalMenosDesc,IDCentro,IDCuenta,MontoMinimo, Activo, ConnectionManager.Tran);
				ConnectionManager.CommitTran();

				PopulateGrid();
				ClearControls();
				HabilitarControles(false);
				_sAccion = "View";
				this.lblStatus.Caption = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Han ocurrido los siguientes errores: \n\r" + ex.Message);
			}
		}


		private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			_sAccion = "View";
			HabilitarControles(false);
			AplicarPrivilegios();
			SetCurrentRow();
			lblStatus.Caption = "";
		}

		private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (this.currentRow != null && this.IDRetencion != -1)
				{
					ObtenerDatos();
					ConnectionManager.BeginTran();
					DAC.clsRetencionesDAC.InsertUpdate("D", ref IDRetencion, Descr, Porcentaje, AplicaTotalFactura, AplicaSubTotal, AplicaSubTotalMenosDesc, IDCentro, IDCuenta, MontoMinimo, Activo, ConnectionManager.Tran);
					ConnectionManager.CommitTran();
					PopulateGrid();
					ClearControls();
					HabilitarControles(false);
					_sAccion = "View";
					this.lblStatus.Caption = "";
				}
			}
			catch (Exception ex)
			{
				ConnectionManager.RollBackTran();
				MessageBox.Show("Ha ocurrido un error trantado de eliminar la Retencion \n\r" + ex.Message);
			}
		}



	}


}

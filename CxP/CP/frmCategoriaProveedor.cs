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

namespace CP
{
	public partial class frmCategoriaProveedor : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		private DataTable _dtCategoriaProveedor;
		private DataTable _dtCentroCosto;
		private DataTable _dtCuentaContable;
		private DataTable _dtSecurity;
		DataRow currentRow;

		string _sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
		const String _tituloVentana = "Listado de Categoria de Proveedor";
		private String _sAccion = "View";
		private int IDCategoria = -1;
		String Descr;
	

		long? IDCtaCXP, IDCtaLetraP, IDCtaProntoPago, IDCtaComision, IDCtaAnticipo, IDCtaCierreDebito, IDCtaImpuesto;
		int? IDCtrCXP, IDCtrLetraP, IDCtrProntoPago, IDCtrComision, IDCtrAnticipo, IDCtrCierreDebito, IDCtrImpuesto;
		int Dias;
		bool Activo;

		public frmCategoriaProveedor()
		{
			InitializeComponent();
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void frmCategoriaProveedor_Load(object sender, EventArgs e)
		{
			try
			{
				HabilitarControles(false);
				
				Util.Util.SetDefaultBehaviorControls(this.gridView, false, this.dtgCategoriaProveedor, _tituloVentana, this);

				//configurar los searchlokup
				_dtCuentaContable = CG.CuentaContableDAC.GetData(-1, -1, -1, "*", "*", "*", "*", "*", "*", "*", -1, -1, 1, 1, -1, -1).Tables["Data"];
				_dtCentroCosto = CG.CentroCostoDAC.GetData(-1,"*","*","*","*","*",0).Tables["Data"];
				
				Util.Util.ConfigLookupEdit(this.slkupCtaCxP, _dtCuentaContable, "Descr", "IDCuenta");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtaCxP, "[{'ColumnCaption':'Cuenta','ColumnField':'Cuenta','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");
				Util.Util.ConfigLookupEdit(this.slkupCtrCxP, _dtCentroCosto, "Descr", "IDCentro");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtrCxP, "[{'ColumnCaption':'Centro Costo','ColumnField':'Centro','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");

				Util.Util.ConfigLookupEdit(this.slkupCtaLetraXP, _dtCuentaContable, "Descr", "IDCuenta");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtaLetraXP, "[{'ColumnCaption':'Cuenta','ColumnField':'Cuenta','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");
				Util.Util.ConfigLookupEdit(this.slkupCtrLetraXP, _dtCentroCosto, "Descr", "IDCentro");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtrLetraXP, "[{'ColumnCaption':'Centro Costo','ColumnField':'Centro','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");

				Util.Util.ConfigLookupEdit(this.slkupCtaProntoPago, _dtCuentaContable, "Descr", "IDCuenta");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtaProntoPago, "[{'ColumnCaption':'Cuenta','ColumnField':'Cuenta','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");
				Util.Util.ConfigLookupEdit(this.slkupCtrProntoPago, _dtCentroCosto, "Descr", "IDCentro");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtrProntoPago, "[{'ColumnCaption':'Centro Costo','ColumnField':'Centro','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");


				Util.Util.ConfigLookupEdit(this.slkupCtaComision, _dtCuentaContable, "Descr", "IDCuenta");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtaComision, "[{'ColumnCaption':'Cuenta','ColumnField':'Cuenta','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");
				Util.Util.ConfigLookupEdit(this.slkupCtrComision, _dtCentroCosto, "Descr", "IDCentro");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtrComision, "[{'ColumnCaption':'Centro Costo','ColumnField':'Centro','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");

				Util.Util.ConfigLookupEdit(this.slkupCtaAnticipos, _dtCuentaContable, "Descr", "IDCuenta");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtaAnticipos, "[{'ColumnCaption':'Cuenta','ColumnField':'Cuenta','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");
				Util.Util.ConfigLookupEdit(this.slkupCtrAnticipo, _dtCentroCosto, "Descr", "IDCentro");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtrAnticipo, "[{'ColumnCaption':'Centro Costo','ColumnField':'Centro','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");

				Util.Util.ConfigLookupEdit(this.slkupCtaCierreDebitos, _dtCuentaContable, "Descr", "IDCuenta");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtaCierreDebitos, "[{'ColumnCaption':'Cuenta','ColumnField':'Cuenta','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");
				Util.Util.ConfigLookupEdit(this.slkupCtrCierreDebito, _dtCentroCosto, "Descr", "IDCentro");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtrCierreDebito, "[{'ColumnCaption':'Centro Costo','ColumnField':'Centro','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");

				Util.Util.ConfigLookupEdit(this.slkupCtaImpuesto, _dtCuentaContable, "Descr", "IDCuenta");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtaImpuesto, "[{'ColumnCaption':'Cuenta','ColumnField':'Cuenta','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");
				Util.Util.ConfigLookupEdit(this.slkupCtrImpuestos, _dtCentroCosto, "Descr", "IDCentro");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCtrImpuestos, "[{'ColumnCaption':'Centro Costo','ColumnField':'Centro','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");


				EnlazarEventos();

				PopulateGrid();

				CargarPrivilegios();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
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
			this.gridView.FocusedRowChanged += gridView1_FocusedRowChanged;
		}

		void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			PopulateGrid();
		}

		private void BtnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			string tempPath = System.IO.Path.GetTempPath();
			String FileName = System.IO.Path.Combine(tempPath, "lstCategoriaProveedor.xlsx");
			DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions()
			{
				SheetName = "Listado Categoria de Proveedor"
			};


			this.gridView.ExportToXlsx(FileName, options);
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo.FileName = FileName;
			process.StartInfo.Verb = "Open";
			process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
			process.Start();
		}



		private void PopulateGrid()
		{
			_dtCategoriaProveedor = DAC.clsCategoriaProveedorDAC.Get(-1,"*").Tables[0];
			this.dtgCategoriaProveedor.DataSource = null;
			this.dtgCategoriaProveedor.DataSource = _dtCategoriaProveedor;
		}

		private void ClearControls()
		{
			this.txtDescr.Text = "";
			this.slkupCtaCxP.EditValue = null;
			this.slkupCtrCxP.EditValue = null;
			this.slkupCtaAnticipos.EditValue = null;
			this.slkupCtrAnticipo.EditValue = null;
			this.slkupCtaLetraXP.EditValue = null;
			this.slkupCtrLetraXP.EditValue = null;
			this.slkupCtrComision.EditValue = null;
			this.slkupCtaComision.EditValue = null;
			this.slkupCtaCierreDebitos.EditValue = null;
			this.slkupCtrCierreDebito.EditValue = null;
			this.slkupCtaProntoPago.EditValue = null;
			this.slkupCtrProntoPago.EditValue = null;
			this.slkupCtaImpuesto.EditValue = null;
			this.slkupCtrImpuestos.EditValue = null;
			this.chkActivo.Checked = true;
		}

		private void HabilitarControles(bool Activo)
		{
			this.chkActivo.ReadOnly = !Activo;
			this.txtDescr.ReadOnly = !Activo;
			this.slkupCtaCxP.ReadOnly = !Activo;
			this.slkupCtrCxP.ReadOnly = !Activo;
			this.slkupCtaAnticipos.ReadOnly = !Activo;
			this.slkupCtrAnticipo.ReadOnly = !Activo;
			this.slkupCtaLetraXP.ReadOnly = !Activo;
			this.slkupCtrLetraXP.ReadOnly = !Activo;
			this.slkupCtrComision.ReadOnly = !Activo;
			this.slkupCtaComision.ReadOnly = !Activo;
			this.slkupCtaCierreDebitos.ReadOnly = !Activo;
			this.slkupCtrCierreDebito.ReadOnly = !Activo;
			this.slkupCtaProntoPago.ReadOnly = !Activo;
			this.slkupCtrProntoPago.ReadOnly = !Activo;
			this.slkupCtaImpuesto.ReadOnly = !Activo;
			this.slkupCtrImpuestos.ReadOnly = !Activo;
			this.dtgCategoriaProveedor.Enabled = !Activo;

			this.btnAgregar.Enabled = !Activo;
			this.btnEditar.Enabled = !Activo;
			this.btnGuardar.Enabled = Activo;
			this.btnCancelar.Enabled = Activo;
			this.btnEliminar.Enabled = !Activo;
			this.btnExportar.Enabled = !Activo;
			this.btnRefrescar.Enabled = !Activo;

		}

		private void SetCurrentRow()
		{
			int index = (int)this.gridView.FocusedRowHandle;
			if (index > -1)
			{
				currentRow = gridView.GetDataRow(index);
				UpdateControlsFromCurrentRow(currentRow);
			}
		}

		private void UpdateControlsFromCurrentRow(DataRow Row)
		{
			this.IDCategoria = Convert.ToInt32(Row["IDCategoria"]);
			this.txtDescr.Text = Row["Descr"].ToString();
			this.slkupCtaCxP.EditValue = Row["Cta_CXP"] == DBNull.Value ? 0 : Convert.ToInt64(Row["Cta_CXP"]);
			this.slkupCtrCxP.EditValue = Row["Ctr_CXP"] == DBNull.Value ? 0 :  Convert.ToInt32(Row["Ctr_CXP"]);
			this.slkupCtaAnticipos.EditValue = Row["Cta_Anticipos_CXP"] == DBNull.Value ? 0 : Convert.ToInt64(Row["Cta_Anticipos_CXP"]);
			this.slkupCtrAnticipo.EditValue = Row["Ctr_Anticipos_CXP"] == DBNull.Value ? 0 :  Convert.ToInt32(Row["Ctr_Anticipos_CXP"]);
			this.slkupCtaLetraXP.EditValue = Row["Cta_Letra_CXP"] == DBNull.Value ? 0 : Convert.ToInt64(Row["Cta_Letra_CXP"]);
			this.slkupCtrLetraXP.EditValue = Row["Ctr_Letra_CXP"] == DBNull.Value ? 0 : Convert.ToInt32(Row["Ctr_Letra_CXP"]);
			this.slkupCtrComision.EditValue = Row["Ctr_Comision_CXP"] == DBNull.Value ? 0 : Convert.ToInt32(Row["Ctr_Comision_CXP"]);
			this.slkupCtaComision.EditValue = Row["Cta_Comision_CXP"] == DBNull.Value ? 0 : Convert.ToInt64(Row["Cta_Comision_CXP"]);
			this.slkupCtaCierreDebitos.EditValue = Row["Cta_CierreDebitos_CXP"] == DBNull.Value ? 0:  Convert.ToInt64(Row["Cta_CierreDebitos_CXP"]);
			this.slkupCtrCierreDebito.EditValue = Row["Ctr_CierreDebitos_CXP"] == DBNull.Value ? 0: Convert.ToInt32(Row["Ctr_CierreDebitos_CXP"]);
			this.slkupCtaProntoPago.EditValue = Row["Cta_ProntoPago_CXP"] == DBNull.Value ?0 : Convert.ToInt64(Row["Cta_ProntoPago_CXP"]);
			this.slkupCtrProntoPago.EditValue = Row["Ctr_ProntoPago_CXP"] == DBNull.Value ? 0 :  Convert.ToInt32(Row["Ctr_ProntoPago_CXP"]);
			this.slkupCtaImpuesto.EditValue = Row["Cta_Impuestos_CXP"] == DBNull.Value ? 0 :  Convert.ToInt64(Row["Cta_Impuestos_CXP"]);
			this.slkupCtrImpuestos.EditValue = Row["Ctr_Impuestos_CXP"] == DBNull.Value ? 0: Convert.ToInt32(Row["Ctr_Impuestos_CXP"]);
			this.chkActivo.EditValue = Convert.ToBoolean(Row["Activo"]);

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
				sMensaje = sMensaje + "     • Descripción de la Categoría del Proveedor \n\r";
			
			if (sMensaje != "")
			{
				result = false;
				MessageBox.Show("Por favor revise los siguientes campos: \n\r\n\r" + sMensaje);
			}
			return result;
		}


		private void ObtenerDatos()
		{
			Descr = this.txtDescr.Text.Trim();
			IDCtaCXP = this.slkupCtaCxP.EditValue != null && this.slkupCtaCxP.Text != "" ? (long?)Convert.ToInt64(this.slkupCtaCxP.EditValue) :null;
			IDCtrCXP = this.slkupCtrCxP.EditValue != null && this.slkupCtrCxP.Text != "" ? (int?)Convert.ToInt32(this.slkupCtrCxP.EditValue) : null;
			IDCtaLetraP = this.slkupCtaLetraXP.EditValue != null && this.slkupCtaLetraXP.Text != "" ? (long?)Convert.ToInt64(this.slkupCtaLetraXP.EditValue) : null;
			IDCtrLetraP = this.slkupCtrLetraXP.EditValue != null && this.slkupCtrLetraXP.Text != "" ? (int?)Convert.ToInt32(this.slkupCtrLetraXP.EditValue) : null;
			IDCtaProntoPago = this.slkupCtaProntoPago.EditValue != null && this.slkupCtaProntoPago.Text != "" ? (long?)Convert.ToInt64(this.slkupCtaProntoPago.EditValue) : null;
			IDCtrProntoPago = this.slkupCtrProntoPago.EditValue != null && this.slkupCtrProntoPago.Text != "" ? (int?)Convert.ToInt32(this.slkupCtrProntoPago.EditValue) : null;
			IDCtaComision = this.slkupCtaComision.EditValue != null && this.slkupCtaComision.Text != "" ? (long?)Convert.ToInt64(this.slkupCtaComision.EditValue) : null;
			IDCtrComision = this.slkupCtrComision.EditValue != null && this.slkupCtrComision.Text != "" ? (int?)Convert.ToInt32(this.slkupCtrComision.EditValue) : null;
			IDCtaAnticipo = this.slkupCtaAnticipos.EditValue != null && this.slkupCtaAnticipos.Text != "" ? (long?)Convert.ToInt64(this.slkupCtaAnticipos.EditValue) : null;
			IDCtrAnticipo = this.slkupCtrAnticipo.EditValue != null && this.slkupCtrAnticipo.Text != "" ? (int?)Convert.ToInt32(this.slkupCtrAnticipo.EditValue) : null;
			IDCtaCierreDebito = this.slkupCtaCierreDebitos.EditValue != null && this.slkupCtaCierreDebitos.Text != "" ? (long?)Convert.ToInt64(this.slkupCtaCierreDebitos.EditValue) : null;
			IDCtrCierreDebito = this.slkupCtrCierreDebito.EditValue != null && this.slkupCtrCierreDebito.Text != "" ? (int?)Convert.ToInt32(this.slkupCtrCierreDebito.EditValue) : null;
			IDCtaImpuesto = this.slkupCtaImpuesto.EditValue != null && this.slkupCtaImpuesto.Text != "" ? (long?)Convert.ToInt64(this.slkupCtaImpuesto.EditValue) : null;
			IDCtrImpuesto = this.slkupCtrImpuestos.EditValue != null && this.slkupCtrImpuestos.Text != "" ? (int?)Convert.ToInt32(this.slkupCtrImpuestos.EditValue) : null;			
			
			Activo = Convert.ToBoolean(this.chkActivo.Checked);
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
				DAC.clsCategoriaProveedorDAC.InsertUpdate(Operacion, ref IDCategoria,Descr,IDCtrCXP,IDCtaCXP,IDCtrLetraP,IDCtaLetraP,IDCtrProntoPago,IDCtaProntoPago,IDCtrComision,IDCtaComision,IDCtrAnticipo,IDCtaAnticipo,IDCtrCierreDebito,IDCtaCierreDebito,IDCtrImpuesto,IDCtaImpuesto, Activo, ConnectionManager.Tran);
				ConnectionManager.CommitTran();
				PopulateGrid();
				this._sAccion = "View";
				ClearControls();
				HabilitarControles(false);
				if (_dtCategoriaProveedor != null && _dtCategoriaProveedor.Rows.Count == 1) {
					this.gridView.SelectRow(0);
					SetCurrentRow();
				}

			}
			catch (Exception ex)
			{
				ConnectionManager.RollBackTran();
				MessageBox.Show("Ha ocurrido un error al momento de guardar la Categoria del Proveedor \n\r" + ex.Message);
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
				if (this.currentRow != null && this.IDCategoria != -1)
				{
					ObtenerDatos();
					ConnectionManager.BeginTran();
					DAC.clsCategoriaProveedorDAC.InsertUpdate("D", ref IDCategoria, Descr, IDCtrCXP, IDCtaCXP, IDCtrLetraP, IDCtaLetraP, IDCtrProntoPago, IDCtaProntoPago, IDCtrComision, IDCtaComision, IDCtrAnticipo, IDCtaAnticipo, IDCtrCierreDebito, IDCtaCierreDebito, IDCtrImpuesto, IDCtaImpuesto, Activo, ConnectionManager.Tran);
					ConnectionManager.CommitTran();
					PopulateGrid();
					this._sAccion = "View";
					ClearControls();
					if (_dtCategoriaProveedor != null && _dtCategoriaProveedor.Rows.Count == 1)
					{
						this.gridView.SelectRow(0);
						SetCurrentRow();
					}
				}
			}
			catch (Exception ex)
			{
				ConnectionManager.RollBackTran();
				MessageBox.Show("Ha ocurrido un error trantado de eliminar la Categoría del Proveedor. \n\r" + ex.Message);
			}
		}

	}
}

using CO.DAC;
using ControlBancario.DAC;
using CI.DAC;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
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
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;

namespace CO
{
    public partial class frmOrdenCompra : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        long IDOrdenCompra;
        DateTime FechaOrden, FechaRequerida, FechaRequeridaEmbarque, FechaCotizacion, FechaEmision;
        int IDEstado, IDProveedor, IDBodega, IDCondicionPago, IDMoneda,IDBodegaDefault;
        Decimal Descuento, Flete, Seguro, Anticipos, Impuesto;
		private DataTable _dtSecurity;
        String  OrdenCompra;
        String sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
        DataTable dtDetalleOrden = new DataTable();
        DataTable dtProductos = new DataTable();
        DataTable dtOrdenCompra = new DataTable();
        DataTable dtPresentacion = new DataTable();
        private string Accion = "Add";
        bool bEditPorcDesc, bEditMontoDesc;
        

        DataTable _dtImportacionDetallada = new DataTable();
        DataTable _dtImportacionConsolidada = new DataTable();


        public frmOrdenCompra(string pAccion)
        {
            InitializeComponent();
            this.Accion = "Add";

            InicializarNuevoElement();
        }

        public frmOrdenCompra(int IDOrdenCompra, String Accion)
        {
            InitializeComponent();

            this.IDOrdenCompra = IDOrdenCompra;
            this.Accion = Accion;
        }


		private void CargarPrivilegios()
		{
			DataSet DS = new DataSet();
			DS = UsuarioDAC.GetAccionModuloFromRole(400, sUsuario);
			_dtSecurity = DS.Tables[0];

			AplicarPrivilegios();
		}

		//TODO: Validar que los botones no sean cambiados en otra area
		private void AplicarPrivilegios()
		{
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.AgregarOrdendeCompra, _dtSecurity))
				this.btnAgregar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.EditarOrdendeCompra, _dtSecurity))
				this.btnEditar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.EliminarOrdendeCompra, _dtSecurity))
				this.btnEliminar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.ConfirmarOrdendeCompra, _dtSecurity))
				this.btnConfirmar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.DesConfirmarOrdendecompra, _dtSecurity))
				this.btnDesconfirmar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.AnularOrdendeCompra, _dtSecurity))
				this.btnAnular.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.EmbarcarOrdendeCompra, _dtSecurity))
				this.btnEmbarque.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.ImprimirOrdendeCompra, _dtSecurity))
				this.btnImprimir.Enabled = false;

		}



        private void InicializarNuevoElement()
        {
			DataTable dtBodegaDefault = clsUtilDAC.GetParametroCompra("IDBodegaDefault").Tables[0];
			IDBodegaDefault = (dtBodegaDefault.Rows[0][0] != DBNull.Value || dtBodegaDefault.Rows[0][0].ToString() != "" ) ? Convert.ToInt32(dtBodegaDefault.Rows[0][0]) : -1;

            this.txtOrdenCompra.Text = "--";
            this.dtpFechaOrden.EditValue = DateTime.Now;
            this.txtEstado.Text = "Inicial";
            this.txtEstado.Tag = 0;

            this.dtpFechaRequerida.EditValue = DateTime.Now;
            this.dtpFechaRequeridaEmbarque.EditValue = DateTime.Now;
            this.dtpFechaCotizacion.EditValue = DateTime.Now;
            this.dtpFechaEmision.EditValue = DateTime.Now;
            this.dtpFechaFactura.EditValue = DateTime.Now;

            this.slkupCondicionPago.EditValue = null;
            this.slkupCondicionPagoFactura.EditValue = null;
            this.slkupMoneda.EditValue = null;
            this.slkupMonedaFactura.EditValue = null;
            this.slkupProveedor.EditValue = null;
            this.slkupSubTipo.EditValue = null;
			if (this.IDBodegaDefault == -1)
				this.slkupBodega.EditValue =  null;
			else 
				this.slkupBodega.EditValue =  this.IDBodegaDefault;


            this.txtNotas.Text = "";
            this.txtMontoFactura.Text = "";
            this.txtPorcDescuento.Text = "";
            this.txtSeguro.Text = "";
            
            this.txtAnticipos.Text = "";

            this.txtTotalMercaderia.Text = "";
            
            this.txtSaldo.Text = "";
            this.txtDescuentoTotal.Text = "";
            this.txtImpuestoVenta.Text = "";
            this.txtFleteTotal.Text = "";
            this.txtAnticipoTotal.Text = "";


            DataTable dtDetalleSolicitud = new DataTable();
        }

        private void HabilitarBotoneriaPrincipal()
        {

            if (Accion == "Add" || Accion == "Edit")
            {
                this.btnAgregar.Enabled = false;
                this.btnEditar.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnEliminar.Enabled = false;
                this.btnImprimir.Enabled = false;

                this.btnConfirmar.Enabled = false;
                this.btnDesconfirmar.Enabled = false;
                this.btnAnular.Enabled = false;
                this.btnEmbarque.Enabled = false;

            }
            else if (Accion == "View")
            {
                this.btnAgregar.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = true;
                this.btnAnular.Enabled = true;
                this.btnEmbarque.Enabled = false;
                this.btnImprimir.Enabled = true;
            }
            else if (Accion == "ReadOnly")
            {
                this.btnAgregar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnCancelar.Enabled = false;

                this.btnConfirmar.Enabled = false;
                this.btnDesconfirmar.Enabled = false;
                this.btnAnular.Enabled = false;
                this.btnAnular.Enabled = false;
                this.btnImprimir.Enabled = true;
            }
        }

        private void HabilitarControles()
        {
            this.txtOrdenCompra.ReadOnly = true;
            this.txtEstado.ReadOnly = true;

            if (Accion == "Add" || Accion == "Edit")
            {
                this.dtpFechaOrden.ReadOnly = false;
                this.slkupProveedor.ReadOnly = false;
                this.slkupMoneda.ReadOnly = false;
                this.dtpFechaRequerida.ReadOnly = false;
                this.dtpFechaEmision.ReadOnly = false;
                this.slkupBodega.ReadOnly = false;
                this.slkupCondicionPago.ReadOnly = false;
                this.dtpFechaRequeridaEmbarque.ReadOnly = false;
                this.dtpFechaCotizacion.ReadOnly = false;
                this.txtPorcDescuento.ReadOnly = false;
                this.txtFlete.ReadOnly = false;
                this.txtSeguro.ReadOnly = false;
                this.txtAnticipos.ReadOnly = false;
                this.txtFactura.ReadOnly = false;
                this.slkupSubTipo.ReadOnly = false;
                this.dtpFechaFactura.ReadOnly = false;
                this.slkupMonedaFactura.ReadOnly = false;
                this.slkupCondicionPagoFactura.ReadOnly = false;
                this.txtImpuestoVentaFactura.ReadOnly = false;
                this.txtImpuestoConsumoFactura.ReadOnly = false;
                this.txtMontoFactura.ReadOnly = false;
                this.txtNotas.ReadOnly = false;


                this.gridView1.OptionsBehavior.ReadOnly = false;
                this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            }
            else
            {
                this.dtpFechaOrden.ReadOnly = true;
                this.slkupProveedor.ReadOnly = true;
                this.slkupMoneda.ReadOnly = true;
                this.dtpFechaRequerida.ReadOnly = true;
                this.dtpFechaEmision.ReadOnly = true;
                this.slkupBodega.ReadOnly = true;
                this.slkupCondicionPago.ReadOnly = true;
                this.dtpFechaRequeridaEmbarque.ReadOnly = true;
                this.dtpFechaCotizacion.ReadOnly = true;
                this.txtPorcDescuento.ReadOnly = true;
                this.txtFlete.ReadOnly = true;
                this.txtSeguro.ReadOnly = true;
                this.txtAnticipos.ReadOnly = true;
                this.txtFactura.ReadOnly = true;
                this.slkupSubTipo.ReadOnly = true;
                this.dtpFechaFactura.ReadOnly = true;
                this.slkupMonedaFactura.ReadOnly = true;
                this.slkupCondicionPagoFactura.ReadOnly = true;
                this.txtImpuestoVentaFactura.ReadOnly = true;
                this.txtImpuestoConsumoFactura.ReadOnly = true;
                this.txtMontoFactura.ReadOnly = true;
                this.txtNotas.ReadOnly = true;

                this.gridView1.OptionsBehavior.ReadOnly = true;
                this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            }


        }


        private void HabilitarBotones(DataTable dt)
        {
            DataRow cabecera = dt.Rows[0];
					  int IDEstado = Convert.ToInt32(cabecera["IDEstado"]);
            //Estado Inicial
            if  (IDEstado == 0)
            {
                this.btnConfirmar.Enabled = true;
                this.btnDesconfirmar.Enabled = false;
                this.btnAnular.Enabled = false;
                this.btnEmbarque.Enabled = false;
            }
            //Estado Confirmada
            if (IDEstado == 1)
            {
                this.btnConfirmar.Enabled = false;
                this.btnDesconfirmar.Enabled = true;
                this.btnAnular.Enabled = true;
                this.btnEmbarque.Enabled = true;
            }
			//Estado Cancelada
				if (IDEstado == 2)
				{
					this.btnConfirmar.Enabled = false;
					this.btnDesconfirmar.Enabled = false;
					this.btnAnular.Enabled = false;
					this.btnEmbarque.Enabled = false;
					this.btnEditar.Enabled = false;
					this.btnGuardar.Enabled = false;
					this.btnAgregar.Enabled = false;
					this.btnEliminar.Enabled = false;
				}
				if (IDEstado == 3)
				{
					this.btnConfirmar.Enabled = false;
					this.btnDesconfirmar.Enabled = false;
					this.btnAnular.Enabled = false;
					this.btnEmbarque.Enabled = true;
				}

       

        }

        private void UpdateControlsFromData(DataTable dt)
        {
            DataRow cabecera = dt.Rows[0];
            IDOrdenCompra = Convert.ToInt32(cabecera["IDOrdenCompra"]);
            this.txtOrdenCompra.EditValue = cabecera["OrdenCompra"].ToString();
            OrdenCompra = cabecera["OrdenCompra"].ToString();
            this.dtpFechaOrden.EditValue = Convert.ToDateTime(cabecera["Fecha"]);
            this.slkupProveedor.EditValue = Convert.ToInt32(cabecera["IDProveedor"]);
            this.slkupMoneda.EditValue = Convert.ToInt32(cabecera["IDMoneda"]);
            this.dtpFechaRequerida.EditValue = Convert.ToDateTime(cabecera["FechaRequerida"]);
            this.dtpFechaEmision.EditValue = Convert.ToDateTime(cabecera["FechaEmision"]);
            this.slkupBodega.EditValue = Convert.ToInt32(cabecera["IDBodega"]);
            this.slkupCondicionPago.EditValue = Convert.ToInt32(cabecera["IDCondicionPago"]);
            this.dtpFechaRequeridaEmbarque.EditValue = Convert.ToDateTime(cabecera["FechaRequeridaEmbarque"]);
            this.dtpFechaCotizacion.EditValue = Convert.ToDateTime(cabecera["FechaCotizacion"]);
            this.txtPorcDescuento.EditValue = Convert.ToDecimal((cabecera["Descuento"] == System.DBNull.Value) ? 0 : cabecera["Descuento"]);
            this.txtFlete.EditValue = Convert.ToDecimal((cabecera["Flete"] == System.DBNull.Value) ? 0 : cabecera["Flete"]);
            this.txtSeguro.EditValue = Convert.ToDecimal((cabecera["Seguro"] == System.DBNull.Value) ? 0 : cabecera["Seguro"]);
            this.txtAnticipos.EditValue = Convert.ToDecimal((cabecera["Anticipos"] == System.DBNull.Value) ? 0 : cabecera["Anticipos"]);
            this.txtEstado.EditValue = cabecera["DescrEstado"].ToString();
            this.txtEstado.Tag = Convert.ToInt32(cabecera["IDEstado"]);
			this.IDEstado = Convert.ToInt32(cabecera["IDEstado"]);

            HabilitarBotones(dt);

      

        }

        private void CargarOrdenCompra(long IDOrdenCompra)
        {
            dtOrdenCompra = DAC.clsOrdenCompraDAC.GetByID(IDOrdenCompra).Tables[0];
            this.dtDetalleOrden = DAC.clsOrdenCompraDetalleDAC.Get(IDOrdenCompra).Tables[0];
            UpdateControlsFromData(dtOrdenCompra);
            this.dtgDetalle.DataSource = dtDetalleOrden;
            

            CalcularMontosOrden();
            
        }

        private void HabilitarComandosAccion()
        {
            IDEstado = Convert.ToInt32(this.txtEstado.Tag);
					//Inicial
            if (IDEstado == 0)
            {
							this.btnConfirmar.Enabled = true;
							this.btnDesconfirmar.Enabled = false;

                //this.btnAprobar.Enabled = true;
                //this.btnRechazar.Enabled = true;
                //this.btnRevertir.Enabled =false;
                //this.btnEliminarSolicitud.Enabled = (Accion == "View" && IDEstado == 0) ? true : false;
                //this.btnEditarSolicitud.Enabled = (Accion == "View" && IDEstado == 0) ? true : false;
            }
							//Confirmada
            else if (IDEstado == 1 )
            {
							this.btnConfirmar.Enabled = false;
							this.btnDesconfirmar.Enabled = true;
                //this.btnAprobar.Enabled = false;
                //this.btnRechazar.Enabled = false;
                //this.btnRevertir.Enabled = true;
                //this.btnEliminarSolicitud.Enabled = false;
                //this.btnEditarSolicitud.Enabled = false;
            }
							//Recibida - Rechazada
            else if( IDEstado == 2 || IDEstado ==3)
            {
							this.btnConfirmar.Enabled = false;
							this.btnDesconfirmar.Enabled = false;
                //this.btnRevertir.Enabled = false;
                //this.btnEliminarSolicitud.Enabled = false;
                //this.btnEditarSolicitud.Enabled = false;
            }

        }

        private void LoadData()
        {
            try
            {
                HabilitarControles();
                HabilitarBotoneriaPrincipal();
                if (Accion == "Add")
                {
                    this.dtpFechaOrden.Focus();
                    dtDetalleOrden = DAC.clsOrdenCompraDetalleDAC.Get(-1).Tables[0];
                    this.dtgDetalle.DataSource = dtDetalleOrden;
                }
                else
                {
                    CargarOrdenCompra(this.IDOrdenCompra);
                }

                HabilitarComandosAccion();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmOrdenCompra_Load(object sender, EventArgs e)
        {
            try
            {
                //Validar que el consecutivo de Solicitud de Compra este asociado 
                String Consec = clsUtilDAC.GetParametroCompra("IDConsecOrdenCompra").Tables[0].Rows[0][0].ToString();
                if (Consec == null || Consec.Trim() == "")
                {
                    MessageBox.Show("Por favor establezca el consecutivo a utilizar en la Orden de Compra");
                    this.Close();
                }

				

                this.dtpFechaCotizacion.EditValue = DateTime.Now;
                this.dtpFechaOrden.EditValue = DateTime.Now;
                this.dtpFechaEmision.EditValue = DateTime.Now;


                this.gridView1.EditFormPrepared += gridView1_EditFormPrepared;
                this.gridView1.NewItemRowText = Util.Util.constNewItemTextGrid;
                this.gridView1.ValidateRow += gridView1_ValidateRow;
                this.gridView1.InvalidRowException += gridView1_InvalidRowException;
                this.gridView1.RowUpdated += gridView1_RowUpdated;
                

                this.gridView1.InitNewRow += gridView1_InitNewRow;
                Util.Util.SetDefaultBehaviorControls(this.gridView1, true, null, "Orden de Compra", this);
                dtProductos = CI.DAC.clsProductoDAC.GetData(-1, "*", "*", -1, -1, -1, -1, -1, -1, "*", 0, -1, -1).Tables[0];
                dtPresentacion = CI.DAC.clsUnidadMedidaDAC.GetData(-1,"*").Tables[0];

                this.slkupIDProducto.DataSource = dtProductos;
                this.slkupIDProducto.DisplayMember = "IDProducto";
                this.slkupIDProducto.ValueMember = "IDProducto";
                this.slkupIDProducto.NullText = " --- ---";
                this.slkupIDProducto.EditValueChanged += slkup_EditValueChanged;
				this.slkupIDProducto.View.OptionsView.ShowAutoFilterRow = true;
                this.slkupIDProducto.Popup += slkup_Popup;
                this.slkupIDProducto.PopulateViewColumns();

                this.slkupDescrProducto.DataSource = dtProductos;
                this.slkupDescrProducto.DisplayMember = "Descr";
                this.slkupDescrProducto.ValueMember = "IDProducto";
                this.slkupDescrProducto.NullText = " --- ---";
				this.slkupDescrProducto.View.OptionsView.ShowAutoFilterRow = true;
                this.slkupDescrProducto.EditValueChanged += slkup_EditValueChanged;
                this.slkupDescrProducto.Popup += slkup_Popup;

                this.slkupPresentacion.DataSource = dtPresentacion;
                this.slkupPresentacion.DisplayMember = "Descr";
                this.slkupPresentacion.ValueMember = "IDUnidad";
                this.slkupPresentacion.NullText = " --- ---";
				this.slkupPresentacion.View.OptionsView.ShowAutoFilterRow = true;
                //this.slkupPresentacion.EditValueChanged += slkup_EditValueChanged;
                this.slkupPresentacion.Popup += slkup_Popup;

                Util.Util.ConfigLookupEdit(this.slkupProveedor, clsProveedorDAC.Get(-1,"*",-1).Tables[0], "Nombre", "IDProveedor");
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupProveedor, "[{'ColumnCaption':'ID','ColumnField':'IDProveedor','width':30},{'ColumnCaption':'Nombre','ColumnField':'Nombre','width':70}]");


                Util.Util.ConfigLookupEdit(this.slkupMoneda, MonedaDAC.GetMoneda(-1).Tables[0], "Moneda", "IDMoneda");
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupMoneda, "[{'ColumnCaption':'ID','ColumnField':'IDMoneda','width':30},{'ColumnCaption':'Moneda','ColumnField':'Moneda','width':70}]");

                Util.Util.ConfigLookupEdit(this.slkupBodega, clsBodegaDAC.GetData(-1, "*", -1,0).Tables[0], "Descr", "IDBodega");
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupBodega, "[{'ColumnCaption':'IDBodega','ColumnField':'IDBodega','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");

                Util.Util.ConfigLookupEdit(this.slkupCondicionPago, clsCondicionPagoDAC.Get(-1,"*").Tables[0], "Descr", "IDCondicionPago");
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupCondicionPago, "[{'ColumnCaption':'ID Condición','ColumnField':'IDCondicionPago','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");


                LoadData();
				CargarPrivilegios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Han ocurrido los siguientes errores: " + ex.Message);
            }

        }

        private void slkup_Popup(object sender, EventArgs e)
        {
            DevExpress.Utils.Win.IPopupControl popupControl = sender as DevExpress.Utils.Win.IPopupControl;
            DevExpress.XtraLayout.LayoutControl layoutControl = popupControl.PopupWindow.Controls[2].Controls[0] as LayoutControl;

            SimpleButton clearButton = ((DevExpress.XtraLayout.LayoutControlItem)layoutControl.Items.FindByName("lciClear")).Control as SimpleButton;
            SimpleButton findButton = ((DevExpress.XtraLayout.LayoutControlItem)layoutControl.Items.FindByName("lciButtonFind")).Control as SimpleButton;

            clearButton.Text = "Limpiar";
            findButton.Text = "Buscar";
        }

        private void slkup_EditValueChanged(object sender, EventArgs e)
        {
            SearchLookUpEdit editor = sender as SearchLookUpEdit;
            DataRowView dr = (DataRowView)editor.GetSelectedDataRow();
            if (dr != null)
            {
                this.gridView1.PostEditor();
                int IDUnidad = Convert.ToInt32(dr["IDUnidad"]);
                this.gridView1.SetFocusedRowCellValue("IDUnidad", IDUnidad);

								Decimal Precio = DAC.clsOrdenCompraDetalleDAC.GetLasPriceProduct(Convert.ToInt64(dr["IDProducto"]));
								this.gridView1.SetFocusedRowCellValue("PrecioUnitario", Precio);

            }

            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
        }

        void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (this.gridView1.FocusedRowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                return;

            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            DataView dataView = view.DataSource as DataView;
            System.Collections.IEnumerator en = dataView.GetEnumerator();

            en.Reset();

            string currentCode = e.Value.ToString();


            while (en.MoveNext())
            {
                DataRowView row = en.Current as DataRowView;
                object colValue = row["IDCentro"] + " " + row["IDCuenta"];
                if (colValue.ToString() == currentCode)
                {
                    e.ErrorText = "El elemento ya existe.";
                    e.Valid = false;
                    break;
                }
            }
        }

        void dtgDetalleSolicitud_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar el elemento seleccionado?", "Asiento de Diario", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    view.DeleteSelectedRows();
                    e.Handled = true;
                }
                else
                    e.Handled = false;
            }
        }

        void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            //try
            //{
            //    if (view == null) return;
            //    DataRow fila = view.GetDataRow(e.RowHandle);
                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }


        private void CalcularMontosOrden()
        {
            //Actualizar los totales


            decimal MontoDesc = Convert.ToDecimal((dtDetalleOrden.Compute("Sum(MontoDesc)", "[MontoDesc] IS NOT NULL") != DBNull.Value) ? dtDetalleOrden.Compute("Sum(MontoDesc)", "[MontoDesc] IS NOT NULL") : 0);

            decimal? dTotalMercaderia = dtDetalleOrden.AsEnumerable().Sum(
                r => r.Field<decimal?>("Cantidad") * (r.Field<decimal?>("PrecioUnitario") == null ? (decimal?)0 : r.Field<decimal?>("PrecioUnitario")) - MontoDesc);
            decimal? dDescuento = (this.txtPorcDescuento.EditValue == null || this.txtPorcDescuento.EditValue.ToString() == "") ? 0 : (Convert.ToDecimal(this.txtPorcDescuento.EditValue)/100) * dTotalMercaderia;
            decimal dFlete = (this.txtFlete.EditValue == null || this.txtFlete.EditValue.ToString() == "") ? 0 : Convert.ToDecimal(this.txtFlete.EditValue);
            decimal dSeguro = (this.txtSeguro.EditValue == null || this.txtSeguro.EditValue.ToString() == "") ? 0 : Convert.ToDecimal(this.txtSeguro.EditValue);
            decimal dAnticipos = (this.txtAnticipos.EditValue == null || this.txtAnticipos.EditValue.ToString() == "") ? 0 : Convert.ToDecimal(this.txtAnticipos.EditValue);
            decimal dImpuestoConsumo = 0;
            decimal dImpuestoVenta = Convert.ToDecimal(dtDetalleOrden.AsEnumerable().Sum(r => (r.Field<decimal?>("Impuesto")/100) * (r.Field<decimal?>("Cantidad") * (r.Field<decimal?>("PrecioUnitario") == null ? (decimal?)0 : r.Field<decimal?>("PrecioUnitario")) - MontoDesc)));
            decimal? dSubTotal = (dTotalMercaderia - dDescuento + dImpuestoVenta + dImpuestoConsumo + dFlete + dSeguro );
            decimal? dSaldo = dSubTotal - dAnticipos;

            this.txtTotalMercaderia.EditValue = Convert.ToDecimal(dTotalMercaderia).ToString("N" + Util.Util.DecimalLenght);
            this.txtDescuentoTotal.EditValue = Convert.ToDecimal(dDescuento).ToString("N" + Util.Util.DecimalLenght);
            this.txtFleteTotal.EditValue = dFlete.ToString("N" + Util.Util.DecimalLenght);
            this.txtSeguroTotal.EditValue = dSeguro.ToString("N" + Util.Util.DecimalLenght);
            this.txtAnticipoTotal.EditValue = dAnticipos.ToString("N" + Util.Util.DecimalLenght);
            this.txtImpuestoVenta.EditValue = dImpuestoVenta.ToString("N" + Util.Util.DecimalLenght);
            this.txtSubtotal.EditValue = Convert.ToDecimal(dSubTotal).ToString("N" + Util.Util.DecimalLenght);
            this.txtSaldo.EditValue = Convert.ToDecimal(dSaldo).ToString("N" + Util.Util.DecimalLenght);

        }

        void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                CalcularMontosOrden();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                GridColumn IDProducto = view.Columns["IDProducto"];
                GridColumn Cantidad = view.Columns["Cantidad"];
                GridColumn PrecioUnitario = view.Columns["PrecioUnitario"];
                GridColumn PorcDesc = view.Columns["PorcDesc"];
                GridColumn MontoDesc = view.Columns["MontoDesc"];
                GridColumn Monto = view.Columns["Monto"];
                
                object vIDProducto = (object)(view.GetRowCellValue(e.RowHandle, IDProducto));
                object vCantidad = (object)(view.GetRowCellValue(e.RowHandle, Cantidad));
                object vPrecioUnitario = (object)(view.GetRowCellValue(e.RowHandle, PrecioUnitario));
                object vPorcDesc = (object)(view.GetRowCellValue(e.RowHandle, PorcDesc));
                object vMontoDesc = (object)(view.GetRowCellValue(e.RowHandle, MontoDesc));
                object vMonto = (object)(view.GetRowCellValue(e.RowHandle, Monto));

                if (Convert.IsDBNull(vIDProducto))
                {
                    view.SetColumnError(IDProducto, "El campo no deberia ser vacio");
                    e.Valid = false;
                    return;
                }

                if (Convert.IsDBNull(vCantidad))
                {
                    view.SetColumnError(Cantidad, "El campo no deberia ser vacio");
                    e.Valid = false;

                    return;
                }

                if (Convert.IsDBNull(vPrecioUnitario))
                {
                    if (Convert.IsDBNull(vPrecioUnitario))
                    {
                        e.Valid = false;
                        view.SetColumnError(PrecioUnitario, "El campo no deberia ser vacio");
                        return;
                    }

                }

                if (!Convert.IsDBNull(vPorcDesc))
                {
                    decimal Porc = Convert.ToDecimal(vPorcDesc);

                    if (Porc > 100)
                    {
                        view.SetColumnError(PorcDesc, "El porcentaje no puede ser mayor a 100%");
                        e.Valid = false;
                        return;
                    }

                }


                if (!Convert.IsDBNull(vMontoDesc))
                {
                    decimal montoDesc = Convert.ToDecimal(vMontoDesc);
                    decimal cant = Convert.ToDecimal(vCantidad);
                    decimal precio = Convert.ToDecimal(vPrecioUnitario);

                    if ((cant * precio) < montoDesc)
                    {
                        view.SetColumnError(PorcDesc, "El monto no puede ser mayor a 100% del producto");
                        e.Valid = false;
                        return;
                    }

                }




                // Validacion de Productos Unicos en la lista

                if (e.Row == null) return;
                //Get the value of the first column
                int iIDProducto = (view.GetRowCellValue(e.RowHandle, IDProducto) != null) ? Convert.ToInt32(view.GetRowCellValue(e.RowHandle, IDProducto)) : -1;
                //Validity criterion

                DataView Dv = new DataView();
                Dv.Table = ((DataView)view.DataSource).ToTable();
                Dv.RowFilter = string.Format("IdProducto={0}", iIDProducto);

                if (Dv.ToTable().Rows.Count > 1)
                {
                    e.Valid = false;
                    //Set errors with specific descriptions for the columns
                    view.SetColumnError(IDProducto, "El producto debe ser unico en la lista");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void gridView1_EditFormPrepared(object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e)
        {
            Control ctrl = Util.Util.FindControl(e.Panel, "Update");
            if (ctrl != null)
                ctrl.Text = "Actualizar";
            ctrl = Util.Util.FindControl(e.Panel, "Cancel");

            if (ctrl != null)
                ctrl.Text = "Cancelar";
        }

        private void btnAddSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Accion = "Add";
            InicializarNuevoElement();
            LoadData();
        }

        private void btnEditarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.IDEstado == 1) {
                return;
            }
            this.Accion = "Edit";
            HabilitarControles();
            HabilitarBotoneriaPrincipal();
        }

        private bool ValidarDatos()
        {
            String sMensaje = "";
            bool Resultado = true;
            if (this.dtpFechaOrden.EditValue.ToString() == "" || this.dtpFechaOrden.EditValue == null)
                sMensaje = "   • Fecha Orden \r\n";
            if (this.slkupProveedor.EditValue == null || this.slkupProveedor.EditValue.ToString() == "")
                sMensaje = "   • Proveedor \r\n";
            if (this.slkupMoneda.EditValue == null || this.slkupMoneda.EditValue.ToString() == "")
                sMensaje = "   • Moneda \r\n";
            if (this.dtpFechaRequerida.Text == "" || this.dtpFechaRequerida.EditValue == null)
                sMensaje = sMensaje + "    • Fecha Requerida \n\r";
            if (this.dtpFechaEmision.Text == "" || this.dtpFechaEmision.EditValue == null)
                sMensaje = sMensaje + "    • Fecha Emisión \n\r";
            if (this.slkupBodega.EditValue == null || this.slkupBodega.EditValue.ToString() == "")
                sMensaje = sMensaje + "   • Bodega \r\n";
            if (this.slkupCondicionPago.EditValue == null || this.slkupCondicionPago.EditValue.ToString() == "")
                sMensaje = sMensaje + "   • Condicion de Pago \r\n";
            if ( this.dtpFechaRequeridaEmbarque.EditValue == null || this.dtpFechaRequeridaEmbarque.EditValue.ToString() == "")
                sMensaje = sMensaje + "   • Fecha Requerida de Embarque \r\n";
            if (this.dtpFechaCotizacion.EditValue == null || this.dtpFechaCotizacion.EditValue.ToString() == "" )
                sMensaje = sMensaje + "   • Fecha de Cotizacion \r\n";
			//if (Convert.ToDateTime(this.dtpFechaCotizacion.EditValue) > Convert.ToDateTime(this.dtpFechaRequerida.EditValue)) 
			//	sMensaje = sMensaje + "   • Fecha de Cotizacion debe de ser menor a la fecha Requerida \r\n";
			//if (Convert.ToDateTime(this.dtpFechaCotizacion.EditValue) > Convert.ToDateTime(this.dtpFechaRequeridaEmbarque.EditValue))
			//	sMensaje = sMensaje + "   • Fecha de Cotizacion debe de ser menor a la fecha Requerida de Embarque \r\n";
			//if (Convert.ToDateTime(this.dtpFechaEmision.EditValue) > Convert.ToDateTime(this.dtpFechaRequerida.EditValue))
			//	sMensaje = sMensaje + "   • Fecha de Emision debe de ser menor a la fecha Requerida \r\n";

			//if (Convert.ToDateTime(this.dtpFechaEmision.EditValue) > Convert.ToDateTime(this.dtpFechaRequeridaEmbarque.EditValue))
			//	sMensaje = "   • Fecha de Emision debe de ser menor a la fecha Requerida de Embarque \r\n";

            
            if (((DataTable)this.dtgDetalle.DataSource).Rows.Count == 0)
                sMensaje = sMensaje = "   • Por favor agrege al menos un elemento al detalle de la solicitud \r\n";
            foreach (DataRow fila in ((DataTable)this.dtgDetalle.DataSource).Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    if (fila["PrecioUnitario"] == DBNull.Value || Convert.ToDecimal(fila["PrecioUnitario"]) == 0)
                        sMensaje = "  • El producto " + fila["DescrProducto"].ToString() + " debe de tener un precio unitario \r\n";
                    if (fila["Cantidad"] == DBNull.Value || Convert.ToDecimal(fila["Cantidad"]) == 0)
                        sMensaje = "  • El producto " + fila["DescrProducto"].ToString() + " debe de tener una cantidad a ordenar \r\n";
                }
            }
            if (sMensaje != "")
            {
                MessageBox.Show("Han ocurrido los siguientes errores por favor verifique los campos: \n\r " + sMensaje);
                Resultado = false;
            }
            return Resultado;
        }

        private void btnGuardarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                
                if (ValidarDatos())
                {
                    FechaOrden = Convert.ToDateTime(this.dtpFechaOrden.EditValue);
                    IDProveedor = Convert.ToInt32(this.slkupProveedor.EditValue);
                    IDMoneda = Convert.ToInt32(this.slkupMoneda.EditValue);
                    FechaRequerida = Convert.ToDateTime(this.dtpFechaRequerida.EditValue);
                    FechaEmision = Convert.ToDateTime(this.dtpFechaEmision.EditValue);
                    IDBodega = Convert.ToInt32(this.slkupBodega.EditValue);
                    IDCondicionPago = Convert.ToInt32(this.slkupCondicionPago.EditValue);
                    FechaRequeridaEmbarque = Convert.ToDateTime(this.dtpFechaRequeridaEmbarque.EditValue);
                    FechaCotizacion = Convert.ToDateTime(this.dtpFechaCotizacion.EditValue);
                    Descuento = (this.txtPorcDescuento.EditValue != null && this.txtPorcDescuento.EditValue.ToString() != "") ? Convert.ToDecimal(this.txtPorcDescuento.EditValue) : 0;
                    Flete = (this.txtFlete.EditValue != null && this.txtFlete.EditValue.ToString() != "") ? Convert.ToDecimal(this.txtFlete.EditValue) : 0;
                    Seguro = (this.txtSeguro.EditValue != null && this.txtSeguro.EditValue.ToString() != "") ? Convert.ToDecimal(this.txtSeguro.EditValue) : 0;
                    Anticipos = (this.txtAnticipos.EditValue != null && this.txtAnticipos.EditValue.ToString() != "") ? Convert.ToDecimal(this.txtAnticipos.EditValue) : 0;
                    //IDTipoProrrateo = Convert.ToInt32(this.cmbTipoProrrateo.SelectedIndex);
                    IDEstado = Convert.ToInt32(this.txtEstado.Tag);

                     //TODO Asociar el IDSolicitud a las importadas

                    DataTable dt = (DataTable)this.dtgDetalle.DataSource;

                    ConnectionManager.BeginTran();


                    if (Accion == "Add")
                    {
                        OrdenCompra = "--";

                        //Ingresar la cabecera de la solicitud
                        IDOrdenCompra = DAC.clsOrdenCompraDAC.InsertUpdate("I", IDOrdenCompra, ref OrdenCompra, FechaOrden, FechaRequerida, FechaEmision,
                                                                        FechaRequeridaEmbarque, FechaCotizacion, IDEstado, IDBodega,
                                                                        IDProveedor, IDMoneda, IDCondicionPago, Descuento, Flete, Seguro,
                                                                        Anticipos, -1, -1, 33, sUsuario, "", Convert.ToDateTime("1981/08/21"), "", Convert.ToDateTime("1981/08/21"), DateTime.Now, sUsuario, DateTime.Now, sUsuario, ConnectionManager.Tran);
                        this.txtOrdenCompra.Text = OrdenCompra;
                        dtOrdenCompra = DAC.clsOrdenCompraDAC.GetByID(IDOrdenCompra).Tables[0];
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row.RowState != DataRowState.Deleted)
                            {
                                DAC.clsOrdenCompraDetalleDAC.InsertUpdate("I", IDOrdenCompra, (long)row["IDProducto"], (decimal)row["Cantidad"], 0, 0,
                                    (decimal)row["PrecioUnitario"], (row["Impuesto"].ToString() == "") ? 0 : (decimal)row["Impuesto"], (row["PorcDesc"].ToString() == "") ? 0 : (decimal)row["PorcDesc"],
                                    (row["MontoDesc"].ToString() == "") ? 0 : (decimal)row["MontoDesc"], 0, row["Comentario"].ToString(), ConnectionManager.Tran);
                            }
                        }

                        
                    }

                    if (Accion == "Edit")
                    {
                        DAC.clsOrdenCompraDAC.InsertUpdate("U", IDOrdenCompra, ref OrdenCompra, FechaOrden, FechaRequerida, FechaEmision,
                                                                        FechaRequeridaEmbarque, FechaCotizacion, IDEstado, IDBodega,
                                                                        IDProveedor, IDMoneda, IDCondicionPago, Descuento, Flete, Seguro,
                                                                        Anticipos, -1, -1, 33, sUsuario, "", Convert.ToDateTime("1981/08/21"), "", Convert.ToDateTime("1981/08/21"), DateTime.Now, sUsuario, DateTime.Now, sUsuario, ConnectionManager.Tran);
                        //Eliminamos el detalle y lo volvemos a insertar
                        DAC.clsOrdenCompraDetalleDAC.InsertUpdate("D", IDOrdenCompra, -1, 0, 0, 0, 0, 0, 0,
                                                        0, 0, "", ConnectionManager.Tran);
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row.RowState != DataRowState.Deleted)
                            {
                                DAC.clsOrdenCompraDetalleDAC.InsertUpdate("I", IDOrdenCompra, (long)row["IDProducto"], (decimal)row["Cantidad"], 0, 0,
                                    (decimal)row["PrecioUnitario"], (row["Impuesto"].ToString() == "") ? 0 : (decimal)row["Impuesto"], (row["PorcDesc"].ToString() == "") ? 0 : (decimal)row["PorcDesc"],
                                    (row["MontoDesc"].ToString() == "") ? 0 : (decimal)row["MontoDesc"], 0, row["Comentario"].ToString(), ConnectionManager.Tran);
                            }
                        }

                    }

                    ConnectionManager.CommitTran();
                    this.Accion = "View";
                    HabilitarControles();
                    HabilitarBotones(this.dtOrdenCompra);
                    HabilitarBotoneriaPrincipal();
                    
                    MessageBox.Show("La Orden de Compra se ha guardado correctamente");

                }
            }
            catch (Exception ex)
            {
                ConnectionManager.RollBackTran();
                MessageBox.Show("Han ocurrido los siguiente errores: " + ex.Message);
            }

        }

        private void btnCancelarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Accion == "Add")
                this.Close();
            else
                this.Accion = "View";
            LoadData();
        }

        private void btnEliminarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                if (Convert.ToInt32(dtOrdenCompra.Rows[0]["IDEstado"]) >= 1) {
                    MessageBox.Show("Solo puede eliminar ordenes cuyo estdo sea el inicial");
                    return;
                }
                if (MessageBox.Show("Esta seguro que desea eliminar la Orden de Compra seleccionada ? ", "Listado de Ordenes de Compra", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (IDOrdenCompra > -1)
                    {
                        ConnectionManager.BeginTran();
                        clsOrdenCompraDetalleDAC.InsertUpdate("D", IDOrdenCompra, -1, 0, 0, 0, 0, 0, 0,
                                                        0, 0, "", ConnectionManager.Tran);
                        clsOrdenCompraDAC.InsertUpdate("D", IDOrdenCompra, ref OrdenCompra, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, -1, -1, -1, -1, -1, 0, 0, 0, 0, -1, -1, 0, "", "", DateTime.Now, "", DateTime.Now, DateTime.Now, "", DateTime.Now, "", ConnectionManager.Tran);
                        ConnectionManager.CommitTran();
                        MessageBox.Show("La orden de compra se ha eliminado correctamente");
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Han ocurrido los siguientes errores: \n\r" + ex.Message);
                ConnectionManager.RollBackTran();
            }
        }




        private void btnAprobar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Validar si se puede aprobar
            try
            {
                //if (Convert.ToInt32(this.txtEstado.Tag) == 0)
                //{
                //    if (MessageBox.Show("Esta  seguro que desea aprobar la Solicitud de Compra ?", "Solicitud de Compra", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                //    {
                //        int Estado = 1;
                //        FechaRequerida = Convert.ToDateTime(this.dtpFechaRequerida.EditValue);
                //        Fecha = Convert.ToDateTime(this.dtpFechaSolicitud.EditValue);
                //        Comentarios = this.txtComentarios.Text.Trim();
                //        ConnectionManager.BeginTran();
                //        DAC.clsSolicitudCompraDAC.InsertUpdate("U", IDSolicitud, Fecha, FechaRequerida, Estado, Comentarios, sUsuario, sUsuario, DateTime.Now, sUsuario, DateTime.Now, sUsuario, ConnectionManager.Tran);
                //        ConnectionManager.CommitTran();
                //        this.txtEstado.Text = "APROBADO";
                //        this.txtEstado.Tag = 1;
                //        this.txtEstado.ForeColor = Color.Green;
                //        this.Accion = "View";
                //        HabilitarControles();
                //        HabilitarBotoneriaPrincipal();
                //        HabilitarComandosAccion();
                //        MessageBox.Show("La solicitud se ha aprobado correctamente");
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("El estado actual de la solicitud no permite aprobarla");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Han ocurrido los siguientes errores: " + ex.Message);
            }
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraReports.UI.XtraReport report = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reportes/rptSolicitudCompra.repx", true);


            SqlDataSource sqlDataSource = report.DataSource as SqlDataSource;

            SqlDataSource ds = report.DataSource as SqlDataSource;
            ds.ConnectionName = "DataSource";
            String sNameConexion = (Security.Esquema.Compania == "CEDETSA") ? "StringConCedetsa" : "StringConDasa";
            System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder(System.Configuration.ConfigurationManager.ConnectionStrings[sNameConexion].ConnectionString);
            ds.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(builder.DataSource, builder.InitialCatalog, builder.UserID, builder.Password, MsSqlAuthorizationType.SqlServer);

            // Obtain a parameter, and set its value.
            report.Parameters["IDOrdenCompra"].Value = this.IDOrdenCompra;

            // Show the report's print preview.
            DevExpress.XtraReports.UI.ReportPrintTool tool = new DevExpress.XtraReports.UI.ReportPrintTool(report);

            tool.ShowPreview();
        }

        private void btnRechazar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //if (Convert.ToInt32(this.txtEstado.Tag) == 0)
                //{
                //    if (MessageBox.Show("Esta  seguro que desea Rechazar la Solicitud de Compra ?", "Solicitud de Compra", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                //    {
                //        int Estado = 2;
                //        FechaRequerida = Convert.ToDateTime(this.dtpFechaRequerida.EditValue);
                //        Fecha = Convert.ToDateTime(this.dtpFechaSolicitud.EditValue);
                //        Comentarios = this.txtComentarios.Text.Trim();
                //        ConnectionManager.BeginTran();
                //        DAC.clsSolicitudCompraDAC.InsertUpdate("U", IDSolicitud, Fecha, FechaRequerida, Estado, Comentarios, sUsuario, sUsuario, DateTime.Now, sUsuario, DateTime.Now, sUsuario, ConnectionManager.Tran);
                //        ConnectionManager.CommitTran();
                //        this.txtEstado.Text = "RECHAZADA";
                //        this.txtEstado.Tag = 2;
                //        this.txtEstado.ForeColor = Color.Red;
                //        this.Accion = "View";
                //        HabilitarControles();
                //        HabilitarBotoneriaPrincipal();
                //        HabilitarComandosAccion();
                //        MessageBox.Show("La solicitud se ha rechazado correctamente");
                //    }
                //}
                //else                           
                //{
                //    MessageBox.Show("El estado actual de la solicitud no permite aprobarla");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Han ocurrido los siguientes errores : \n\r" + ex.Message);
            }
        }



        private void txtPorcDescuento_Validated(object sender, EventArgs e)
        {
            CalcularMontosOrden();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            if (view == null) return;
            if (this.slkupProveedor.EditValue == null)
            {
                MessageBox.Show("Antes de asociar productos por favor, seleccione el proveedor de la orden");
                view.CancelUpdateCurrentRow();
                return;
            }
            if (e.Column.FieldName == "IDProducto")
            {
                long IDProducto = Convert.ToInt64(view.GetRowCellValue(e.RowHandle, view.Columns[0]));
                int IDProveedor = Convert.ToInt32(this.slkupProveedor.EditValue);

								this.slkupProveedor.Enabled = false;
                //validar si el producto 
            }

            if (e.Column.FieldName == "Cantidad")
            {
                //3 => PrecioUnitario
                //6 => Porc Desc
                //5 => Descuento


                //Piloto
                decimal cellValue = (e.Value.ToString() == "") ? 0 : Convert.ToDecimal(e.Value); //Cantidad
                decimal Precio = (view.GetRowCellValue(e.RowHandle, view.Columns[4]).ToString() =="" ) ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[4]));
                decimal Impuesto = (view.GetRowCellValue(e.RowHandle, view.Columns[5]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[5]));
                decimal MontoDesc = (view.GetRowCellValue(e.RowHandle, view.Columns[6]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[6]));
                decimal PorcDesc = (view.GetRowCellValue(e.RowHandle, view.Columns[7]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[7]));
                if (MontoDesc == 0)
                    if (PorcDesc != 0)
                    {
                        MontoDesc = (cellValue * Precio) * (PorcDesc / 100);
                        view.SetRowCellValue(e.RowHandle, "MontoDesc", MontoDesc);
                    }
                decimal Monto = (Impuesto /100) *((Precio * cellValue) - MontoDesc) + ((Precio * cellValue) - MontoDesc);
                view.SetRowCellValue(e.RowHandle, "Monto", Monto);


                
            }
            
            if (e.Column.FieldName == "PrecioUnitario")
            {
                //2 => Cantidad
                //6 => Porc Desc
                //5 => Descuento

                decimal cellValue = (e.Value.ToString() == "") ? 0 : Convert.ToDecimal(e.Value); //Precio
                decimal Cantidad = (view.GetRowCellValue(e.RowHandle, view.Columns[3]).ToString() =="" ) ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[3]));
                decimal Impuesto = (view.GetRowCellValue(e.RowHandle, view.Columns[5]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[5]));
                decimal MontoDesc = (view.GetRowCellValue(e.RowHandle, view.Columns[6]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[6]));
                decimal PorcDesc = (view.GetRowCellValue(e.RowHandle, view.Columns[7]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[7]));
                if (MontoDesc == 0)
                    if (PorcDesc != 0)
                    {
                        MontoDesc = (Cantidad * cellValue) * (PorcDesc / 100);
                        view.SetRowCellValue(e.RowHandle, "MontoDesc", MontoDesc);
                    }
                decimal Monto = (Impuesto / 100) * ((Cantidad * cellValue) - MontoDesc) + ((Cantidad * cellValue) - MontoDesc);
                view.SetRowCellValue(e.RowHandle, "Monto", Monto);



         
            }


            if (e.Column.FieldName == "Impuesto")
            {
                //2 => Cantidad
                //6 => Porc Desc
                //5 => Descuento

                decimal cellValue = (e.Value.ToString() == "") ? 0 : Convert.ToDecimal(e.Value); //Impuesto
                decimal Cantidad = (view.GetRowCellValue(e.RowHandle, view.Columns[3]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[3]));
                decimal Precio = (view.GetRowCellValue(e.RowHandle, view.Columns[4]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[4]));
                decimal MontoDesc = (view.GetRowCellValue(e.RowHandle, view.Columns[6]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[6]));
                decimal PorcDesc = (view.GetRowCellValue(e.RowHandle, view.Columns[7]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[7]));
                if (MontoDesc == 0)
                    if (PorcDesc != 0)
                    {
                        MontoDesc = (Cantidad * cellValue) * (PorcDesc / 100);
                        view.SetRowCellValue(e.RowHandle, "MontoDesc", MontoDesc);
                    }
                decimal Monto = (cellValue / 100) * ((Cantidad * Precio) - MontoDesc) + ((Cantidad * Precio) - MontoDesc);
                view.SetRowCellValue(e.RowHandle, "Monto", Monto);

             
            }


            if (e.Column.FieldName == "PorcDesc" && bEditPorcDesc ) //|| view.GetRowCellValue(e.RowHandle, view.Columns[5]).ToString() == "")
            {
                //3 => PrecioUnitario
                //2 => Cantidad

                decimal cellValue = (e.Value.ToString() == "") ? 0 : Convert.ToDecimal(e.Value); //PorcDesc
                decimal Cantidad = (view.GetRowCellValue(e.RowHandle, view.Columns[3]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[3]));
                decimal Precio = (view.GetRowCellValue(e.RowHandle, view.Columns[4]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[4]));
                decimal MontoDesc = 0;
                decimal Impuesto = (view.GetRowCellValue(e.RowHandle, view.Columns[5]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[5]));
           
                MontoDesc = (Cantidad * Precio) * (cellValue / 100);
                view.SetRowCellValue(e.RowHandle, "MontoDesc", MontoDesc);

                decimal Monto = (Impuesto / 100) * ((Cantidad * Precio) - MontoDesc) + ((Cantidad * Precio) - MontoDesc);
                view.SetRowCellValue(e.RowHandle, "Monto", Monto);


            }
            if (e.Column.FieldName == "MontoDesc" && bEditMontoDesc) // || view.GetRowCellValue(e.RowHandle, view.Columns[6]).ToString() == "")
            {

                decimal cellValue = (e.Value.ToString() == "") ? 0 : Convert.ToDecimal(e.Value); //MontoDesc
                decimal Cantidad = (view.GetRowCellValue(e.RowHandle, view.Columns[3]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[3]));
                decimal Precio = (view.GetRowCellValue(e.RowHandle, view.Columns[4]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[4]));
                decimal Impuesto = (view.GetRowCellValue(e.RowHandle, view.Columns[5]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[5]));
                decimal PorcDesc = (view.GetRowCellValue(e.RowHandle, view.Columns[7]).ToString() == "") ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, view.Columns[7]));

                PorcDesc = (cellValue / (Precio * Cantidad)) * 100;
                view.SetRowCellValue(e.RowHandle, "PorcDesc", PorcDesc);

                decimal Monto = (Impuesto / 100) * ((Cantidad * Precio) - cellValue) + ((Cantidad * Precio) - cellValue);
                view.SetRowCellValue(e.RowHandle, "Monto", Monto);

                

            }

        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "PorcDesc")
            {
                bEditMontoDesc = false;
                bEditPorcDesc = true;
            }
            else if (e.Column.FieldName == "MontoDesc")
            {
                bEditMontoDesc = true;
                bEditPorcDesc = false;
            }
            else
            {
                bEditMontoDesc = false;
                bEditPorcDesc = false;
            }


        }

        

        private void btnEliminarLinea_Click(object sender, EventArgs e)
        {


        }

        private void dtgDetalle_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete && Accion != "View" && Accion != "ReadOnly")
            {
                if (MessageBox.Show("Esta seguro que desea eliminar el elemento seleccionado?", "Asiento de Diario", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataRow dr = view.GetDataRow(view.GetSelectedRows().First());
                    
                    view.DeleteSelectedRows();
                    //dtDetalleOrden.AcceptChanges();
                    e.Handled = true;
                }
                else
                    e.Handled = false;
            }
        }

        private void btnConfirmar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			try
			{
				ConnectionManager.BeginTran();
				clsOrdenCompraDAC.ConfirmarOrdenCompra(this.IDOrdenCompra, ConnectionManager.Tran);
				dtOrdenCompra.Rows[0]["IDEstado"] = 1;
				dtOrdenCompra.Rows[0]["DescrEstado"] = "CONFIRMADA";
				this.txtEstado.Text = "CONFIRMADA";
				ConnectionManager.CommitTran();
				this.IDEstado = 1;
				HabilitarBotones(this.dtOrdenCompra);
				MessageBox.Show("La Orden ha sido Confirmada correctamente");
			}
			catch (Exception ex) {
				if (ConnectionManager.Tran != null)
					ConnectionManager.RollBackTran();
				MessageBox.Show("Ha ocurrido un error, " + ex.Message);
			}
        }

        private void btnDesconfirmar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Validar
            DataTable dt = clsEmbarqueDAC.GetByID(-7, this.IDOrdenCompra).Tables[0];
            if (dt.Rows.Count > 0) {
                MessageBox.Show("No se puede desconfirmar, posee embarques asociados");
                return;
            }
            ConnectionManager.BeginTran();
            clsOrdenCompraDAC.DesConfirmarOrdenCompra(this.IDOrdenCompra, ConnectionManager.Tran);
            dtOrdenCompra.Rows[0]["IDEstado"] = 0;
            dtOrdenCompra.Rows[0]["DescrEstado"] = "INICIAl";
            ConnectionManager.CommitTran();
            this.IDEstado = 0;
            HabilitarBotones(this.dtOrdenCompra);
            MessageBox.Show("La Orden ha sido Des-Confirmada correctamente");
        }

        private void btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Validar
            DataTable dt = clsEmbarqueDAC.GetByID(-7, this.IDOrdenCompra).Tables[0];
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("No se puede Anular, posee embarques asociados");
                return;
            }
            ConnectionManager.BeginTran();
            clsOrdenCompraDAC.CancelarOrdenCompra(this.IDOrdenCompra, ConnectionManager.Tran);
            dtOrdenCompra.Rows[0]["IDEstado"] = 2;
            dtOrdenCompra.Rows[0]["DescrEstado"] = "CANCELADA";
            ConnectionManager.CommitTran();
            this.IDEstado = 2;
            HabilitarBotones(this.dtOrdenCompra);
            MessageBox.Show("La Orden ha sido Confirmada correctamente");
        }

        private void btnEmbarque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtOrdenCompra.Rows[0]["IDEmbarque"].ToString() != "-1")
            {
                long IDEmbarque = Convert.ToInt64(dtOrdenCompra.Rows[0]["IDEmbarque"]);
                frmEmbarque ofrmEmbarque = new frmEmbarque(IDOrdenCompra, IDEmbarque, "View");
                ofrmEmbarque.FormClosed += ofrmEmbarque_FormClosed;
                ofrmEmbarque.ShowDialog();
            }
            else
            {
                frmEmbarque ofrmEmarque = new frmEmbarque(IDOrdenCompra);
                ofrmEmarque.FormClosed += ofrmEmbarque_FormClosed;
                ofrmEmarque.ShowDialog();
            }
        }

        void ofrmEmbarque_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEmbarque ofrm = (frmEmbarque)sender;
			if (ofrm.IDEmbarque != -1)
			{
				dtOrdenCompra.Rows[0]["IDEmbarque"] = ofrm.IDEmbarque;
			}
			else
			{
				dtOrdenCompra.Rows[0]["IDEmbarque"] = -1;
			}
        }

      
        private void btnImportFromExcel_Click(object sender, EventArgs e)
        {
            if (this.slkupProveedor.EditValue != null)
            {
                frmImportFromExcel ofrmImport = new frmImportFromExcel(Convert.ToInt32(this.slkupProveedor.EditValue));
                ofrmImport.FormClosed += ofrmImport_FormClosed;
                ofrmImport.Show();
            }
            else {
                MessageBox.Show("Por favor seleccione el proveedor para poder importar desde Excel");
            }
        }

        void ofrmImport_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmImportFromExcel ofrm = (frmImportFromExcel)sender;
            if (ofrm.IsResult == true) {
                foreach (DataRow fila in ofrm.dtDetalleOrden.Rows)
                {
                    DataRow nuevaFila = this.dtDetalleOrden.NewRow();
                    nuevaFila["IDProducto"] = fila["IDProducto"];
                    nuevaFila["DescrProducto"] = fila["DescrProducto"];
                    nuevaFila["Cantidad"] = fila["Cantidad"];
                    nuevaFila["PrecioUnitario"] = fila["PrecioUnitario"];
                    nuevaFila["MontoDesc"] = fila["MontoDesc"];
                    if (Convert.ToDecimal(fila["PorcDesc"]) > 0) {
                        decimal Cantidad = Convert.ToDecimal(fila["Cantidad"]);
                        decimal Precio = Convert.ToDecimal(fila["PrecioUnitario"]);
                        decimal Porc = Convert.ToDecimal(fila["PorcDesc"]);
                        nuevaFila["MontoDesc"] = (Cantidad * Precio) * (Porc / 100);
                    }
                    if (Convert.ToDecimal(fila["MontoDesc"]) > 0 && Convert.ToDecimal(fila["PorcDesc"]) == 0) {
                        decimal Cantidad = Convert.ToDecimal(fila["Cantidad"]);
                        decimal Precio = Convert.ToDecimal(fila["PrecioUnitario"]);
                        decimal MontoDesc = Convert.ToDecimal(fila["MontoDesc"]);
                        nuevaFila["PorcDesc"] = ((Cantidad * Precio) / MontoDesc) * 100;
                    }
                    nuevaFila["PorcDesc"] = fila["PorcDesc"];
                    nuevaFila["Comentario"] = fila["Comentario"];
                    nuevaFila["Impuesto"] = fila["Impuesto"];
                    nuevaFila["Monto"] = fila["Monto"];
                    this.dtDetalleOrden.Rows.InsertAt(nuevaFila, 0);
                    
                }

                CalcularMontosOrden();
            }
        }

        private void btnOpenTemplate_Click(object sender, EventArgs e)
        {
            String Ruta = Path.Combine(Directory.GetCurrentDirectory(), "FilesTemplate/import_Orden.xlsx"); 
            System.Diagnostics.Process.Start(@Ruta);
        }

        private void slkupProveedor_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView drProveedor = this.slkupProveedor.GetSelectedDataRow() as DataRowView;
            if (drProveedor != null && drProveedor.Row != null)
            {
                this.slkupMoneda.EditValue = Convert.ToInt32(drProveedor["IDMoneda"]);
                this.slkupMoneda.Enabled = (Convert.ToBoolean(drProveedor["MultiMoneda"]) == true) ? true : false;

							  //dtProductos = CI.DAC.clsProductoDAC.GetData(-1, "*", "*", -1, -1, -1, -1, -1, -1, "*", -1, -1, -1).Tables[0];
								dtProductos = CI.DAC.clsProductoDAC.GetProductoByProveedor(Convert.ToInt32(drProveedor["IDProveedor"])).Tables[0];
								this.slkupIDProducto.DataSource = dtProductos;
								this.slkupDescrProducto.DataSource = dtProductos;
								
            }
        }

        private void btnImprimir_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.IDOrdenCompra != null && this.IDOrdenCompra != -1)
            {
                DevExpress.XtraReports.UI.XtraReport report = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reportes/Plantillas/rptOrdenCompra.repx", true);


                SqlDataSource sqlDataSource = report.DataSource as SqlDataSource;

                SqlDataSource ds = report.DataSource as SqlDataSource;
                ds.ConnectionName = "sqlDataSource1";
                String sNameConexion = (Security.Esquema.Compania == "CEDETSA") ? "StringConCedetsa" : "StringConDasa";
                System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder(System.Configuration.ConfigurationManager.ConnectionStrings[sNameConexion].ConnectionString);
                ds.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(builder.DataSource, builder.InitialCatalog, builder.UserID, builder.Password, MsSqlAuthorizationType.SqlServer);

                // Obtain a parameter, and set its value.
                report.Parameters["IDOrdenCompra"].Value = this.IDOrdenCompra;
                report.Parameters["UserImpresion"].Value = this.sUsuario;

                // Show the report's print preview.
                DevExpress.XtraReports.UI.ReportPrintTool tool = new DevExpress.XtraReports.UI.ReportPrintTool(report);

                tool.ShowPreview();


            }
        }

		private void btnCargarPedido_Click(object sender, EventArgs e)
		{
			DataTable dtPedidoSugerido = clsOrdenCompraDetalleDAC.ObtenerPedidoSugerido(-1, DateTime.Now).Tables[0];

			foreach (DataRow fila in dtPedidoSugerido.Rows)
			{
				DataRow nuevaFila = this.dtDetalleOrden.NewRow();
				nuevaFila["IDProducto"] = fila["IDProducto"];
				nuevaFila["DescrProducto"] = fila["DescrProducto"];
				nuevaFila["Cantidad"] = fila["Cantidad"];
				nuevaFila["PrecioUnitario"] = fila["PrecioUnitario"];
				nuevaFila["MontoDesc"] = 0;
				//if (Convert.ToDecimal(fila["PorcDesc"]) > 0)
				//{
				//	decimal Cantidad = Convert.ToDecimal(fila["Cantidad"]);
				//	decimal Precio = Convert.ToDecimal(fila["PrecioUnitario"]);
				//	decimal Porc = Convert.ToDecimal(fila["PorcDesc"]);
				//	nuevaFila["MontoDesc"] = (Cantidad * Precio) * (Porc / 100);
				//}
				//if (Convert.ToDecimal(fila["MontoDesc"]) > 0 && Convert.ToDecimal(fila["PorcDesc"]) == 0)
				//{
				//	decimal Cantidad = Convert.ToDecimal(fila["Cantidad"]);
				//	decimal Precio = Convert.ToDecimal(fila["PrecioUnitario"]);
				//	decimal MontoDesc = Convert.ToDecimal(fila["MontoDesc"]);
				//	nuevaFila["PorcDesc"] = ((Cantidad * Precio) / MontoDesc) * 100;
				//}
				nuevaFila["PorcDesc"] = 0;
				nuevaFila["Comentario"] = "";
				nuevaFila["Impuesto"] = 0;
				nuevaFila["Monto"] = fila["Monto"];
				this.dtDetalleOrden.Rows.InsertAt(nuevaFila, 0);

			}

			CalcularMontosOrden();
		}                                       


    }

  
}
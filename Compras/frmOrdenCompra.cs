﻿using CO.DAC;
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

namespace CO
{
    public partial class frmOrdenCompra : DevExpress.XtraBars.Ribbon.RibbonForm
    {
   
        long IDOrdenCompra;
        DateTime FechaOrden, FechaRequerida,FechaRequeridaEmbarque,FechaCotizacion,FechaEmision,FechaFactura;
        int IDEstado,IDProveedor,IDBodega,IDCondicionPago, IDMoneda,IDTipoProrrateo;
        Decimal Descuento, Flete, Seguro, Documentacion, Anticipos,ImpuestoVenta,ImpuestoConsumo,MontoFactura;
        String NumFactura,Notas, OrdenCompra;
        String sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
        DataTable dtDetalleOrden = new DataTable();
        DataTable dtProductos = new DataTable();
        private string Accion = "Add";

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

        private void InicializarNuevoElement()
        {
            this.txtOrdenCompra.Text = "--";
            this.dtpFechaOrden.EditValue = DateTime.Now;
            this.txtEstado.Text = "Inicial";
            this.txtEstado.Tag = 0;

            this.dtpFechaRequerida.EditValue = null;
            this.dtpFechaRequeridaEmbarque.EditValue = null;
            this.dtpFechaCotizacion.EditValue = null;
            this.dtpFechaEmision.EditValue = null;
            this.dtpFechaFactura.EditValue = null;

            this.slkupCondicionPago.EditValue = null;
            this.slkupCondicionPagoFactura.EditValue = null;
            this.slkupMoneda.EditValue = null;
            this.slkupMonedaFactura.EditValue = null;
            this.slkupProveedor.EditValue = null;
            this.slkupSubTipo.EditValue = null;
            this.slkupBodega.EditValue = null;

            this.txtNotas.Text = "";
            this.txtMontoFactura.Text = "";
            this.txtPorcDescuento.Text = "";
            this.txtSeguro.Text = "";
            this.txtDocumentacion.Text = "";
            this.txtAnticipos.Text = "";

            this.txtTotalMercaderia.Text = "";
            this.txtTotalDocumentacion.Text = "";
            this.txtSaldo.Text = "";
            this.txtDescuentoTotal.Text = "";
            this.txtImpuestoVenta.Text = "";
            this.txtImpuestoConsumo.Text = "";
            this.txtFleteTotal.Text = "";
            this.txtAnticipoTotal.Text = "";
            

            DataTable dtDetalleSolicitud = new DataTable();
        }

        private void HabilitarBotoneriaPrincipal() { 
            
            if (Accion=="Add" || Accion=="Edit"){
                this.btnAgregar.Enabled = false;
                this.btnEditar.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnEliminar.Enabled = false;
               
            }
            else if (Accion == "View") {
                this.btnAgregar.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = true;
            }
            else if (Accion == "ReadOnly")
            {
                this.btnAgregar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }

        private void HabilitarControles() {
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
                this.txtDocumentacion.ReadOnly = false;
                this.txtAnticipos.ReadOnly = false;
                this.cmbTipoProrrateo.ReadOnly = false;
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
                this.gridView1.OptionsBehavior.AllowDeleteRows =  DevExpress.Utils.DefaultBoolean.True;
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
                this.txtDocumentacion.ReadOnly = true;
                this.txtAnticipos.ReadOnly = true;
                this.cmbTipoProrrateo.ReadOnly = true;
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

        private void UpdateControlsFromData(DataTable dt) { 
            DataRow cabecera =  dt.Rows[0];
            IDOrdenCompra = Convert.ToInt32(cabecera["IDOrdenCompra"]);
            this.txtOrdenCompra.EditValue = cabecera["OrdenCompra"].ToString();
            this.dtpFechaOrden.EditValue = Convert.ToDateTime(cabecera["Fecha"]);
            this.slkupProveedor.EditValue = Convert.ToInt32(cabecera["IDProveedor"]);
            this.slkupMoneda.EditValue = Convert.ToInt32(cabecera["IDMoneda"]);
            this.dtpFechaRequerida.EditValue = Convert.ToDateTime(cabecera["FechaRequerida"]);
            this.dtpFechaEmision.EditValue = Convert.ToDateTime(cabecera["FechaEmision"]);
            this.slkupBodega.EditValue = Convert.ToInt32(cabecera["IDBodega"]);
            this.slkupCondicionPago.EditValue = Convert.ToInt32(cabecera["IDCondicionPago"]);
            this.dtpFechaRequeridaEmbarque.EditValue = Convert.ToDateTime(cabecera["FechaRequeridaEmbarque"]);
            this.dtpFechaCotizacion.EditValue = Convert.ToDateTime(cabecera["FechaCotizacion"]);
            this.txtPorcDescuento.EditValue = Convert.ToDecimal(cabecera["Descuento"]);
            this.txtFlete.EditValue = Convert.ToDecimal(cabecera["Flete"]);
            this.txtSeguro.EditValue = Convert.ToDecimal(cabecera["Seguro"]);
            this.txtDocumentacion.EditValue = Convert.ToDecimal(cabecera["Documentacion"]);
            this.txtAnticipos.EditValue = Convert.ToDecimal(cabecera["Anticipos"]);
            this.cmbTipoProrrateo.EditValue = Convert.ToInt32(cabecera["IDTipoProrrateo"]);
            this.txtEstado.EditValue = cabecera["DescrEstado"].ToString();
            this.txtEstado.Tag = Convert.ToInt32(cabecera["IDEstado"]);
            
            
            // Datos de Credito
            //this.txtFactura.ReadOnly = true;
            //this.slkupSubTipo.ReadOnly = true;
            //this.dtpFechaFactura.ReadOnly = true;
            //this.slkupMonedaFactura.ReadOnly = true;
            //this.slkupCondicionPagoFactura.ReadOnly = true;
            //this.txtImpuestoVentaFactura.ReadOnly = true;
            //this.txtImpuestoConsumoFactura.ReadOnly = true;
            //this.txtMontoFactura.ReadOnly = true;
            //this.txtNotas.ReadOnly = true;
            
        }

        private void CargarOrdenCompra(long IDOrdenCompra) {
            DataTable dtOrdenCompra = DAC.clsOrdenCompraDAC.GetByID(IDOrdenCompra).Tables[0];
            DataTable dtDetalle = DAC.clsOrdenCompraDetalleDAC.Get(IDOrdenCompra).Tables[0];
            UpdateControlsFromData(dtOrdenCompra);
            this.dtgDetalle.DataSource = dtDetalle;
            //this.btnAprobar.Enabled = (Convert.ToInt32(this.txtEstado.Tag) == 0) ? true : false;
            
        }

        private void HabilitarComandosAccion() {
            IDEstado = Convert.ToInt32(this.txtEstado.Tag);
            if ( IDEstado == 0) {
                //this.btnAprobar.Enabled = true;
                //this.btnRechazar.Enabled = true;
                //this.btnRevertir.Enabled =false;
                //this.btnEliminarSolicitud.Enabled = (Accion == "View" && IDEstado == 0) ? true : false;
                //this.btnEditarSolicitud.Enabled = (Accion == "View" && IDEstado == 0) ? true : false;
            }
            else if (IDEstado == 1 || IDEstado==2)
            {
                //this.btnAprobar.Enabled = false;
                //this.btnRechazar.Enabled = false;
                //this.btnRevertir.Enabled = true;
                //this.btnEliminarSolicitud.Enabled = false;
                //this.btnEditarSolicitud.Enabled = false;
            }
            else {
                //this.btnAprobar.Enabled = false;
                //this.btnRechazar.Enabled = false;
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
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmOrdenCompra_Load(object sender, EventArgs e)
        {
            try
            {
                this.gridView1.EditFormPrepared += gridView1_EditFormPrepared;
                this.gridView1.NewItemRowText = Util.Util.constNewItemTextGrid;
                //this.gridView1.ValidatingEditor += GridView1_ValidatingEditor;
                this.gridView1.ValidateRow += gridView1_ValidateRow;
                this.gridView1.InvalidRowException += gridView1_InvalidRowException;
                this.gridView1.RowUpdated += gridView1_RowUpdated;
                //this.gridView1.ShownEditor += gridView1_ShownEditor;
                this.dtgDetalle.ProcessGridKey += dtgDetalleSolicitud_ProcessGridKey;
                //this.gridView1.ValidatingEditor += gridView1_ValidatingEditor;



                this.gridView1.InitNewRow += gridView1_InitNewRow;
                //this.gridView1.CustomColumnDisplayText += gridView1_CustomColumnDisplayText;

                Util.Util.SetDefaultBehaviorControls(this.gridView1, true, null, "Orden de Compra", this);
                //slkupIDProducto

                dtProductos = CI.DAC.clsProductoDAC.GetData(-1, "*", "*", -1, -1, -1, -1, -1, -1, "*", -1, -1, -1).Tables[0];

                this.slkupIDProducto.DataSource = dtProductos;
                this.slkupIDProducto.DisplayMember = "IDProducto";
                this.slkupIDProducto.ValueMember = "IDProducto";
                this.slkupIDProducto.NullText = " --- ---";
                this.slkupIDProducto.EditValueChanged += slkup_EditValueChanged;
                this.slkupIDProducto.Popup += slkup_Popup;
                this.slkupIDProducto.PopulateViewColumns();




                //Util.Util.ConfigLookupEdit(this.slkupIDProducto, clsGlobalTipoTransaccionDAC.Get(-1, "*", "*", _dtPaquete.Rows[0]["Transaccion"].ToString()).Tables[0], "Descr", "IDTipoTran");
                //Util.Util.ConfigRepositoryLookupEditSetViewColumns(this.slkupIDProducto, "[{'ColumnCaption':'IDProducto','ColumnField':'IDProducto','width':30},{'ColumnCaption':'Descripcion','ColumnField':'Descr','width':70}]");

                this.slkupDescrProducto.DataSource = dtProductos;
                this.slkupDescrProducto.DisplayMember = "Descr";
                this.slkupDescrProducto.ValueMember = "IDProducto";
                this.slkupDescrProducto.NullText = " --- ---";
                this.slkupDescrProducto.EditValueChanged += slkup_EditValueChanged;
                this.slkupDescrProducto.Popup += slkup_Popup;

                Util.Util.ConfigLookupEdit(this.slkupProveedor, clsProveedorDAC.Get(-1).Tables[0], "Nombre", "IDProveedor");
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupProveedor, "[{'ColumnCaption':'ID','ColumnField':'IDProveedor','width':30},{'ColumnCaption':'Nombre','ColumnField':'Nombre','width':70}]");


                Util.Util.ConfigLookupEdit(this.slkupMoneda, MonedaDAC.GetMoneda(-1).Tables[0], "Moneda", "IDMoneda");
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupMoneda, "[{'ColumnCaption':'ID','ColumnField':'IDMoneda','width':30},{'ColumnCaption':'Moneda','ColumnField':'Moneda','width':70}]");

                Util.Util.ConfigLookupEdit(this.slkupBodega, clsBodegaDAC.GetData(-1, "*", -1).Tables[0], "Descr", "IDBodega");
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupBodega, "[{'ColumnCaption':'IDBodega','ColumnField':'IDBodega','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");

                Util.Util.ConfigLookupEdit(this.slkupCondicionPago, clsCondicionPagoDAC.Get().Tables[0], "Descr", "IDCondicionPago");
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupCondicionPago, "[{'ColumnCaption':'ID Condición','ColumnField':'IDCondicionPago','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");






                LoadData();
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
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            //try
            //{
            //    if (view == null) return;
            //    //int count = (dtDetalleSolicitud.Rows.Count > 0) ? dtDetalleSolicitud.AsEnumerable().Max(a => a.Field<int>("Linea")) + 1 : 1;

            //    view.SetRowCellValue(e.RowHandle, view.Columns["IDOrdenCompra"], IDSolicitud);
            //    //view.SetRowCellValue(e.RowHandle, view.Columns["Linea"], count);



            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }


        private void CalcularMontosOrden()
        {
            //Actualizar los totales
           

            
            decimal dTotalMercaderia = dtDetalleOrden.AsEnumerable().Sum(r => r.Field<decimal>("Cantidad") * r.Field<decimal>("PrecioUnitario")) -  dtDetalleOrden.AsEnumerable().Sum(r => r.Field<decimal>("MontoDesc"));
            decimal dDescuento = (this.txtPorcDescuento.EditValue ==null || this.txtPorcDescuento.EditValue.ToString() =="") ? 0 : Convert.ToDecimal(this.txtPorcDescuento.EditValue) * dTotalMercaderia;
            decimal dFlete = (this.txtFlete.EditValue == null ||  this.txtFlete.EditValue.ToString() =="") ? 0 : Convert.ToDecimal(this.txtFlete.EditValue);
            decimal dSeguro = (this.txtSeguro.EditValue==null || this.txtSeguro.EditValue.ToString() =="") ? 0 : Convert.ToDecimal(this.txtSeguro.EditValue);
            decimal dDocumentacion = (this.txtDocumentacion.EditValue ==null || this.txtDocumentacion.EditValue .ToString() =="" ) ? 0: Convert.ToDecimal(this.txtDocumentacion.EditValue);
            decimal dAnticipos = (this.txtAnticipos.EditValue == null || this.txtAnticipos.EditValue.ToString()=="" ) ? 0: Convert.ToDecimal(this.txtAnticipos.EditValue);          
            decimal dImpuestoConsumo = 0;
            decimal dImpuestoVenta = 0;
            decimal dSubTotal = (dTotalMercaderia - dDescuento + dImpuestoVenta + dImpuestoConsumo + dFlete + dSeguro + dDocumentacion);
            decimal dSaldo = dSubTotal - dAnticipos;

            this.txtTotalMercaderia.EditValue = dTotalMercaderia.ToString("N" + Util.Util.DecimalLenght);
            this.txtDescuentoTotal.EditValue = dDescuento.ToString("N" + Util.Util.DecimalLenght);
            this.txtFleteTotal.EditValue = dFlete.ToString("N" + Util.Util.DecimalLenght);
            this.txtTotalDocumentacion.EditValue = dFlete.ToString("N" + Util.Util.DecimalLenght);
            this.txtSeguroTotal.EditValue = dSeguro.ToString("N" + Util.Util.DecimalLenght);
            this.txtAnticipoTotal.EditValue = dAnticipos.ToString("N" + Util.Util.DecimalLenght);
            this.txtImpuestoConsumo.EditValue = dImpuestoConsumo.ToString("N" + Util.Util.DecimalLenght);
            this.txtImpuestoVenta.EditValue = dImpuestoVenta.ToString("N" +Util.Util.DecimalLenght);
            this.txtSubtotal.EditValue = dSubTotal.ToString("N" + Util.Util.DecimalLenght);
            this.txtSaldo.EditValue = dSaldo.ToString("N" + Util.Util.DecimalLenght);
            

            
        }

       
      
        void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                CalcularMontosOrden();
            }
            catch (Exception ex) {
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
                
                object vIDProducto = (object)(view.GetRowCellValue(e.RowHandle, IDProducto));
                object vCantidad = (object)(view.GetRowCellValue(e.RowHandle, Cantidad));
                
            
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
            this.Accion = "Edit";
            HabilitarControles();
            HabilitarBotoneriaPrincipal();
        }

         

        private bool ValidarDatos() { 
            String sMensaje = "";
            bool Resultado = true;
            if (this.dtpFechaOrden.EditValue.ToString() == "" || this.dtpFechaOrden.EditValue == null)
                sMensaje = "   • Fecha Orden \r\n";
            if ( this.slkupProveedor.EditValue == null|| this.slkupProveedor.EditValue.ToString() == "" )
                sMensaje = "   • Proveedor \r\n";
            if (this.slkupMoneda.EditValue == null || this.slkupMoneda.EditValue.ToString() == "")
                sMensaje = "   • Moneda \r\n";
            if (this.dtpFechaRequerida.Text == "" || this.dtpFechaRequerida.EditValue == null)
                sMensaje = sMensaje +  "    • Fecha Requerida \n\r";
            if (this.dtpFechaEmision.Text == "" || this.dtpFechaEmision.EditValue == null)
                sMensaje = sMensaje +  "    • Fecha Emisión \n\r";
            if (this.slkupBodega.EditValue == null || this.slkupBodega.EditValue.ToString() == "")
                sMensaje = "   • Bodega \r\n";
            if (this.slkupCondicionPago.EditValue == null || this.slkupCondicionPago.EditValue.ToString() == "")
                sMensaje = "   • Condicion de Pago \r\n";
            if (this.dtpFechaRequeridaEmbarque.EditValue.ToString() == "" || this.dtpFechaRequeridaEmbarque.EditValue == null)
                sMensaje = "   • Fecha Requerida de Embarque \r\n";
            if (this.dtpFechaCotizacion.EditValue.ToString() == "" || this.dtpFechaCotizacion.EditValue == null)
                sMensaje = "   • Fecha de Cotizacion \r\n";
            if (this.cmbTipoProrrateo.EditValue == null || this.cmbTipoProrrateo.EditValue.ToString() == "")
                sMensaje = "   • Tipo Prorrateo \r\n";
            

            if (((DataTable)this.dtgDetalle.DataSource).Rows.Count == 0)
                sMensaje = sMensaje = "   • Por favor agrege al menos un elemento al detalle de la solicitud";

            if (sMensaje != "") {
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
                    Descuento = Convert.ToDecimal(this.txtPorcDescuento.EditValue);
                    Flete = Convert.ToDecimal(this.txtFlete.EditValue);
                    Seguro = Convert.ToDecimal(this.txtSeguro.EditValue);
                    Documentacion = Convert.ToDecimal(this.txtDocumentacion.EditValue);
                    Anticipos = Convert.ToDecimal(this.txtAnticipos.EditValue);
                    IDTipoProrrateo = Convert.ToInt32(this.cmbTipoProrrateo.SelectedIndex);
                    IDEstado = Convert.ToInt32(this.txtEstado.Tag);

                    DataTable dt = (DataTable)this.dtgDetalle.DataSource;

                    ConnectionManager.BeginTran();
                    

                    if (Accion == "Add")
                    {
                        //Ingresar la cabecera de la solicitud
                        IDOrdenCompra = DAC.clsOrdenCompraDAC.InsertUpdate("I", IDOrdenCompra,ref OrdenCompra,FechaOrden, FechaRequerida,FechaEmision,
                                                                        FechaRequeridaEmbarque,FechaCotizacion,IDEstado,IDBodega,
                                                                        IDProveedor,IDMoneda,IDCondicionPago,Descuento,Flete,
                                                                        Documentacion,Anticipos,IDTipoProrrateo,-1,-1,33,sUsuario,"",DateTime.MinValue,"",DateTime.MinValue,DateTime.Now,sUsuario, DateTime.Now, sUsuario, ConnectionManager.Tran);
                        this.txtOrdenCompra.Text = OrdenCompra;
                        foreach (DataRow row in dt.Rows)
                        {
                            DAC.clsOrdenCompraDetalleDAC.InsertUpdate("I", IDOrdenCompra,(long)row["IDProducto"], (decimal)row["Cantidad"],0,0,
                                                        (decimal)row["PrecioUnitario"],(decimal) row["Impuesto"],(decimal) row["PorcDescruento"],
                                                        (decimal) row["MontoDescuento"],0, row["Comentario"].ToString(), ConnectionManager.Tran);
                        }
                    }

                    if (Accion == "Edit")
                    {
                        DAC.clsOrdenCompraDAC.InsertUpdate("U", IDOrdenCompra, ref OrdenCompra, FechaOrden, FechaRequerida, FechaEmision,
                                                                        FechaRequeridaEmbarque, FechaCotizacion, IDEstado, IDBodega,
                                                                        IDProveedor, IDMoneda, IDCondicionPago, Descuento, Flete,
                                                                        Documentacion, Anticipos, IDTipoProrrateo, -1, -1, 33, sUsuario, "", DateTime.MinValue, "", DateTime.MinValue, DateTime.Now, sUsuario, DateTime.Now, sUsuario, ConnectionManager.Tran);
                        //Eliminamos el detalle y lo volvemos a insertar
                        DAC.clsOrdenCompraDetalleDAC.InsertUpdate("D", IDOrdenCompra, -1, 0, 0, 0,0, 0, 0,
                                                        0, 0, "", ConnectionManager.Tran);
                        foreach (DataRow row in dt.Rows)
                        {
                            DAC.clsOrdenCompraDetalleDAC.InsertUpdate("I", IDOrdenCompra, (long)row["IDProducto"], (decimal)row["Cantidad"], 0, 0,
                                                         (decimal)row["PrecioUnitario"], (decimal)row["Impuesto"], (decimal)row["PorcDescruento"],
                                                         (decimal)row["MontoDescuento"], 0, row["Comentario"].ToString(), ConnectionManager.Tran);
                        }
                    }

                    ConnectionManager.CommitTran();
                    this.Accion = "Edit";
                    HabilitarControles();
                    HabilitarBotoneriaPrincipal();
                    MessageBox.Show("La Orden de Compra se ha guardado correctamente");
                    
                }
            } catch (Exception ex)
            {
                ConnectionManager.RollBackTran();
                 MessageBox.Show("Han ocurrido los siguiente errores: " + ex.Message);
            }

        }

        private void btnCancelarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Accion == "Add")
                this.Accion = "Add";
            else
                this.Accion = "View";
            LoadData();
        }

        private void btnEliminarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta seguro que desea eliminar la Orden de Compra seleccionada ? ", "Listado de Ordenes de Compra", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (IDOrdenCompra >-1)
                    {
                        ConnectionManager.BeginTran();
                        clsOrdenCompraDAC.InsertUpdate("D", IDOrdenCompra,ref OrdenCompra,DateTime.Now,DateTime.Now,DateTime.Now,DateTime.Now,DateTime.Now,-1,-1,-1,-1,-1,0,0,0,0,-1,-1,-1,0,"","",DateTime.Now,"",DateTime.Now,DateTime.Now,"",DateTime.Now,"", ConnectionManager.Tran);
                        clsOrdenCompraDetalleDAC.InsertUpdate("D", IDOrdenCompra, -1, 0, 0, 0, 0, 0, 0,
                                                        0, 0, "", ConnectionManager.Tran);
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
            catch (Exception ex) {
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
            catch (Exception ex) {
                MessageBox.Show("Han ocurrido los siguientes errores : \n\r" + ex.Message);
            }
        }

        private void btnRevertir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ////Validar si la solicitud tiene ordenes asociadas
            //DataTable dt = DAC.clsSolicitudCompraDAC.GetSolicitudCompra_OrdenCompra(IDSolicitud, -1, -1).Tables[0];
            //if (dt.Rows.Count == 0)
            //{
            //    int Estado = 0;
            //    FechaRequerida = Convert.ToDateTime(this.dtpFechaRequerida.EditValue);
            //    Fecha = Convert.ToDateTime(this.dtpFechaSolicitud.EditValue);
            //    Comentarios = this.txtComentarios.Text.Trim();
            //    DAC.clsSolicitudCompraDAC.InsertUpdate("U", IDSolicitud, Fecha, FechaRequerida, Estado, Comentarios, sUsuario, sUsuario, DateTime.Now, sUsuario, DateTime.Now, sUsuario, ConnectionManager.Tran);
            //    this.txtEstado.Text = "INICIALIZADA";
            //    this.txtEstado.Tag = 0;
            //    this.txtEstado.ForeColor = Color.Black;
            //    this.Accion = "Edit";
            //    HabilitarControles();
            //    HabilitarBotoneriaPrincipal();
            //    HabilitarComandosAccion();
            //    MessageBox.Show("La solicitud se ha revertido correctamente");
            //}
            //else {
            //    MessageBox.Show("La solicitud no puede ser revertida, posee ordenes de compra asociadas");
            //}

        }

        private void txtPorcDescuento_Validated(object sender, EventArgs e)
        {
            CalcularMontosOrden();
        }



       

 

        
    }
}
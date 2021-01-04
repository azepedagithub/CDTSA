using CO.DAC;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
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
using ControlBancario;

namespace CO
{
    public partial class frmEmbarque : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public long IDOrdenCompra,IDEmbarque;
        DateTime  FechaEmbarque, Fecha;
        int IDProveedor,IDBodega;
        String OrdenCompra,Embarque;
        String sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
        bool Confirmada = false;
        DataTable dtDetalleOrden = new DataTable();
        DataTable dtDetalleEmbarque = new DataTable();
        DataTable dtEmbarque = new DataTable();
        DataTable dtProductos = new DataTable();
        DataTable dtOrdenCompra = new DataTable();
        DataTable dtPresentacion = new DataTable();
		private DataTable _dtSecurity;
       

        //Datos de la Factura
        int IDObligacionProveedor =-1;
        DateTime FechaVence, FechaPoliza, FechaFactura;
        String Factura, Poliza, GuiaBL,AsientoFactura;
        double TipoCambioPoliza, ValorMercaderia, MontoFlete, MontoSeguro, MontoTotal;
        DataTable dtObligacionProveedor = new DataTable();
        
        //Datos de OtrosGastos
        DataTable dtObligacionDetalle = new DataTable();
        DataTable dtMoneda = new DataTable();
        DataTable dtProveedor = new DataTable();
        DataTable dtGastos = new DataTable();
        String AccionOtrosPagos = "View";
        int IDObligacionDetalle = -1;

        DataRow currentRowOtrosPagos;

       

        double TipoCambio;

        private string Accion = "Add";
		string _sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";

        public frmEmbarque(long IDOrdenCompra)
        {
            InitializeComponent();
            this.Accion = "Add";
            this.IDOrdenCompra = IDOrdenCompra;            
            InicializarNuevoElement();
        }


        public frmEmbarque(long IDOrdenCompra,long IDEmbarque, String Accion)
        {
            InitializeComponent();
            
            this.IDOrdenCompra = IDOrdenCompra;
            this.IDEmbarque = IDEmbarque;
            this.Accion = Accion;
        }                                


        public long ID_Embarque {
            get { return this.IDEmbarque; }
            set { this.IDEmbarque = value; }
        }


		private void CargarPrivilegios()
		{
			DataSet DS = new DataSet();
			DS = UsuarioDAC.GetAccionModuloFromRole(400, _sUsuario);
			_dtSecurity = DS.Tables[0];

			AplicarPrivilegios();
		}

		//TODO: validar que los privilegios no se cambien en otras opciones
		private void AplicarPrivilegios()
		{
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.EditarEmbarque, _dtSecurity))
				this.btnEditar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.EliminarEmbarque, _dtSecurity))
				this.btnEliminar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.LiquidarEmbarque, _dtSecurity))
				this.btnAplicar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.ConfirmarEmbarque, _dtSecurity))
				this.btnConfirmar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.RecepcionarMercaderia, _dtSecurity))
				this.btnRecepcionMercaderia.Enabled = false;
		}


        
        private void InicializarNuevoElement()
        {
            
            this.txtOrdenCompra.Text = "--";
            this.txtEmbarque.Text = "--";
            this.dtpFecha.EditValue = DateTime.Now;
            this.dtpFechaEmbarque.EditValue = DateTime.Now;
            this.txtProveedor.Text = "";
            this.dtDetalleEmbarque = new DataTable();
            this.dtDetalleOrden = new DataTable();
        }

        private void HabilitarBotoneriaPrincipal() {

			this.btnRecepcionMercaderia.Enabled = (this.ID_Embarque != -1) ? true : false;
			this.btnConfirmar.Enabled = (this.ID_Embarque != -1) ? true : false;

			if (Accion=="Add" || Accion=="Edit"){
                this.btnEditar.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnEliminar.Enabled = false;
                this.tabFactura.PageVisible = false;
				
               
            }
            else if (Accion == "View") {
                if (this.Confirmada)
                {
                    this.btnEditar.Enabled = false;
                    this.btnGuardar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnConfirmar.Enabled = false;
                    this.btnAplicar.Enabled = true;
                    this.tabFactura.PageVisible = true;
                }
                else
                {
                    this.btnEditar.Enabled = true;
                    this.btnGuardar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.tabFactura.PageVisible = false;
                    this.btnAplicar.Enabled = false;
                    this.btnEliminar.Enabled = true;
                }
                
            }
            else if (Accion == "ReadOnly")
            {
                this.btnEditar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnAplicar.Enabled = false;
				this.btnRecepcionMercaderia.Enabled = false;
				this.btnConfirmar.Enabled =false;
                if (this.Confirmada)
                {
                    this.tabFactura.PageVisible = true;
                }
               
            }
        }

        private void HabilitarControles() {
            this.txtOrdenCompra.ReadOnly = true;
            this.txtEmbarque.ReadOnly = true;
            this.txtProveedor.ReadOnly = true;
            this.txtBodega.ReadOnly = true;
            

            if (Accion == "Add" || Accion == "Edit")
            {
                
                this.dtpFecha.ReadOnly = false;
                this.dtpFechaEmbarque.ReadOnly = false;
                
                
                this.gridViewEmbarque.OptionsBehavior.ReadOnly = false;
                this.gridViewEmbarque.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                this.gridViewEmbarque.OptionsBehavior.AllowDeleteRows =  DevExpress.Utils.DefaultBoolean.True;

                
                this.gridViewDetalleEmbarque.OptionsBehavior.ReadOnly = false;
                this.gridViewDetalleEmbarque.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                this.gridViewDetalleEmbarque.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            }
            else
            {
                this.dtpFecha.ReadOnly = true;
                this.dtpFechaEmbarque.ReadOnly = true;
                

                this.gridViewEmbarque.OptionsBehavior.ReadOnly = true;
                this.gridViewEmbarque.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                this.gridViewEmbarque.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;

                this.gridView2.OptionsBehavior.ReadOnly = true;
                this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;

                this.gridViewDetalleEmbarque.OptionsBehavior.ReadOnly = true;
                this.gridViewDetalleEmbarque.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                this.gridViewDetalleEmbarque.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            }

            
        }

        private void UpdateControlsFromData(DataTable dt) { 
            DataRow cabecera =  dt.Rows[0];
            this.IDOrdenCompra = Convert.ToInt32(cabecera["IDOrdenCompra"]);
            this.txtOrdenCompra.EditValue = cabecera["OrdenCompra"].ToString();
            this.txtOrdenCompra.Tag = this.IDOrdenCompra;
            OrdenCompra = cabecera["OrdenCompra"].ToString();
            this.txtEmbarque.EditValue = cabecera["Embarque"].ToString();
            Embarque = cabecera["Embarque"].ToString();
            this.txtEmbarque.Tag = cabecera["IDEmbarque"].ToString();
            this.dtpFecha.EditValue = Convert.ToDateTime(cabecera["Fecha"]);
            this.dtpFechaEmbarque.EditValue = Convert.ToDateTime(cabecera["FechaEmbarque"]);
            this.linkAsiento.Text = cabecera["AsientoInv"].ToString();
            this.txtBodega.Text = cabecera["DescrBodega"].ToString();
            this.txtBodega.Tag = cabecera["IDBodega"].ToString();
            this.txtProveedor.Text = cabecera["NombreProveedor"].ToString();
            this.txtProveedor.Tag = cabecera["IDProveedor"].ToString();
            this.Confirmada = Convert.ToBoolean(cabecera["Confirmado"]);
            if (this.linkAsiento.Text != "")
            {
                this.btnAplicar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnEditar.Enabled = false;
                this.btnRellenar.Enabled = false;
            }
            else
            {
                this.btnAplicar.Enabled = true;
                this.btnEliminar.Enabled = (this.Confirmada) ? false : true;
                this.btnRellenar.Enabled = (this.Confirmada) ? false : true;
            }

			
        }

        private void CargarEmbarque(long IDOrdenCompra,long IDEmbarque) {
            dtDetalleOrden = DAC.clsOrdenCompraDetalleDAC.Get(IDOrdenCompra).Tables[0];                                                              
            this.dtDetalleEmbarque = DAC.clsEmbarqueDetalleDAC.Get(IDEmbarque).Tables[0];
            this.dtEmbarque = DAC.clsEmbarqueDAC.GetByID(IDEmbarque, IDOrdenCompra).Tables[0];
    
            UpdateControlsFromData(dtEmbarque);

            if (IDEmbarque == -1 || this.dtDetalleEmbarque.Rows.Count == 0)
            {
                this.dtDetalleEmbarque.Clear();
                foreach (DataRow row in dtDetalleOrden.Rows)
                {
                    DataRow fila = this.dtDetalleEmbarque.NewRow();
                    fila["IDEmbarque"] = 0;
                    fila["IDProducto"] = row["IDProducto"];
                    fila["DescrProducto"] = row["DescrProducto"];
                    fila["PrecioUnitario"] = row["PrecioUnitario"];
                    fila["Impuesto"] = row["Impuesto"];
                    fila["PorcDesc"] = row["PorcDesc"];
                    fila["MontoDesc"] = row["MontoDesc"];
                    fila["CantidadOrdenada"] = row["Cantidad"];
                    fila["CantidadAceptada"] = 0;

                    this.dtDetalleEmbarque.Rows.Add(fila);

                }
                dtDetalleEmbarque.AcceptChanges();
                this.dtgDetalleEmbarque.DataSource = dtDetalleEmbarque;
            }
            else
                this.dtgDetalleEmbarque.DataSource = dtDetalleEmbarque;
                                                               
            this.dtgLineasOrden.DataSource = dtDetalleOrden;
        }
                                                                                
        private void LoadData()
        {
            try
            {

                TipoCambio = CG.TipoCambioDetalleDAC.GetLastTipoCambioFecha(DateTime.Now);
            
                if (Accion == "Add")
                {
                    
                    this.dtpFecha.Focus();
                    IDEmbarque = -1;
                    CargarEmbarque(IDOrdenCompra, IDEmbarque);

                    this.dtgLineasOrden.DataSource = dtDetalleOrden;
                    //this.dtgLineasEmbarque.DataSource =dtDetalleEmbarque;
                    this.dtgDetalleEmbarque.DataSource = dtDetalleEmbarque;
                }
                else
                {
                    CargarEmbarque(this.IDOrdenCompra,this.IDEmbarque);
                }
                HabilitarControles();
                HabilitarBotoneriaPrincipal();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        private void CalcularTotalesEmbarque()
        {
            DataTable dtOrdenCompra = clsOrdenCompraDAC.GetByID(this.IDOrdenCompra).Tables[0];
            double MontoMercaderia = 0;
            foreach (DataRow row in dtDetalleEmbarque.Rows)
            {
                double SubTotal =    Convert.ToDouble(((decimal)row["CantidadAceptada"] * (decimal)row["PrecioUnitario"]) - (decimal)row["MontoDesc"]);
                double Impuesto =   Convert.ToDouble((decimal)row["Impuesto"])/100;
                MontoMercaderia = MontoMercaderia + (SubTotal + (SubTotal * Impuesto));
            }

            DataRow rowOrden = dtOrdenCompra.Rows.Count>0 ? dtOrdenCompra.Rows[0]: null;
              Double MontoFlete,MontoSeguro;
            if (rowOrden != null) {
                MontoFlete = Convert.ToDouble((rowOrden["Flete"] == DBNull.Value || rowOrden["Flete"].ToString() == "") ? 0 : rowOrden["Flete"]);
                MontoSeguro = Convert.ToDouble((rowOrden["Seguro"] == DBNull.Value || rowOrden["Seguro"].ToString() == "") ? 0 : rowOrden["Seguro"]);
                this.txtMontoFlete.EditValue = MontoFlete;
                this.txtMontoSeguro.EditValue = MontoSeguro;
            }  else {
                MontoFlete=0;
                MontoSeguro=0;
            }
            
            DataView dv = dtMoneda.AsDataView();
            dv.RowFilter = "IDMoneda=" + dtOrdenCompra.Rows[0]["IDMoneda"].ToString();

            this.lblMoneda.Text = dv.ToTable().Rows[0]["Descr"].ToString();
            this.txtTotalMercaderia.EditValue = MontoMercaderia;
            this.txtTotal.EditValue = MontoMercaderia + MontoFlete + MontoSeguro;
        }

        private void AlertaFacturaSinGuardar() {
            if (this.IDObligacionProveedor > 0)
            {
                this.tabFactura.Text = "Factura Mercadería";
                this.tabFactura.Appearance.Header.BackColor = Color.Transparent;
                this.tabFactura.ImageIndex = -1; 
            }
            else
            {
                this.tabFactura.Text = "Factura Mercadería **PENDIENTE!!**";
                this.tabFactura.Appearance.Header.BackColor = Color.Red;
                this.tabFactura.ImageIndex = 0; 
            }
        }

        private void LoadObligacionProveedor()
        {
            if (dtEmbarque != null && dtEmbarque.Rows.Count > 0)
            {
                dtObligacionProveedor = clsObligacionProveedorDAC.Get(Convert.ToInt32(dtEmbarque.Rows[0]["IDEmbarque"]), -1).Tables[0];

                if (dtObligacionProveedor.Rows.Count > 0)
                {
                    DataRow drObl = dtObligacionProveedor.Rows[0];
                    this.IDObligacionProveedor = Convert.ToInt32(drObl["IDObligacion"]);
                    this.txtFactura.Text = drObl["NumFactura"].ToString();
                    this.txtPoliza.Text = drObl["NumPoliza"].ToString();
                    this.txtGuiaBL.Text = drObl["Guia_BL"].ToString();
                    this.dtpFechaFactura.EditValue = Convert.ToDateTime(drObl["Fecha"]);
                    this.dtpFechaPoliza.EditValue = Convert.ToDateTime(drObl["FechaPoliza"]);
                    this.dtpFechaVence.EditValue = Convert.ToDateTime(drObl["FechaVence"]);
                    this.txtTipoCambio.EditValue = Convert.ToDecimal(drObl["TipoCambio"]);
                    this.txtMontoFlete.EditValue = Convert.ToDecimal(drObl["MontoFlete"]);
                    this.txtMontoSeguro.EditValue = Convert.ToDecimal(drObl["MontoSeguro"]);
                    this.linkAsientoMercaderia.Text = drObl["Asiento"].ToString();                    
                    //Validar si tiene documento CP asociado
                    //string sDocCP = clsObligacionProveedorDAC.getDocumentoCP((int)this.ID_Embarque);
                     if (drObl["Asiento"] != null && drObl["Asiento"].ToString()!="")
                    //if (sDocCP != "ND")
                    {
                        this.btnGenerarDocCPFactura.Enabled = false;
                        this.btnGuardarFactura.Enabled = false;
                        InactivarControles(true);
                    }
                     else
                     {
                         this.btnGenerarDocCPFactura.Enabled = true;
                         this.btnGuardarFactura.Enabled = true;
                         InactivarControles(false);

                     }

                }
                else
                {
                    this.btnGenerarDocCPFactura.Enabled = true;
                    this.linkAsientoMercaderia.Text = "";
                    InactivarControles(false);
                    
                }
                AlertaFacturaSinGuardar();

                CalcularTotalesEmbarque();

            }
            else
            {
                this.btnGenerarDocCPFactura.Enabled = false;
            }
        }


        private void InactivarControles(bool flag)
        {
            this.txtFactura.ReadOnly = flag;
            this.txtPoliza.ReadOnly = flag;
            this.txtGuiaBL.ReadOnly = flag;
            this.dtpFechaFactura.ReadOnly = flag;
            this.dtpFechaPoliza.ReadOnly = flag;
            this.dtpFechaVence.ReadOnly = flag;
            this.txtTipoCambio.ReadOnly = flag;
            
        }

        private void frmEmbarque_Load(object sender, EventArgs e)
        {
            try
            {
                //Validar que el consecutivo de Solicitud de Compra este asociado 
                String Consec = clsUtilDAC.GetParametroCompra("IDConsecEmbarque").Tables[0].Rows[0][0].ToString();
                if (Consec == null || Consec.Trim() == "")
                {
                    MessageBox.Show("Por favor establezca el consecutivo a utilizar en la Orden de Compra");
                    this.Close();
                }

                dtProductos = CI.DAC.clsProductoDAC.GetData(-1, "*", "*", -1, -1, -1, -1, -1, -1, "*", 0, -1, -1).Tables[0];
                
                
                dtMoneda = ControlBancario.DAC.MonedaDAC.GetMoneda(-1).Tables[0];
                dtProveedor = DAC.clsProveedorDAC.Get(-1, "*", -1).Tables[0];
                dtGastos = DAC.clsGastosCompraDAC.Get(-1, "*").Tables[0];
                dtPresentacion = CI.DAC.clsUnidadMedidaDAC.GetData(-1, "*").Tables[0];

                Util.Util.ConfigLookupEdit(this.slkupMonedaOtrosPagos, dtMoneda, "Descr", "IDMoneda");
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupMonedaOtrosPagos, "[{'ColumnCaption':'ID','ColumnField':'IDMoneda','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':70}]");
               
                Util.Util.ConfigLookupEdit(this.slkupProveedorOtrosPagos, dtProveedor, "Nombre", "IDProveedor",400,300);
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupProveedorOtrosPagos, "[{'ColumnCaption':'ID','ColumnField':'IDProveedor','width':30},{'ColumnCaption':'Nombre','ColumnField':'Nombre','width':70}]");
				this.slkupProveedorOtrosPagos.Properties.View.OptionsView.ShowAutoFilterRow = true;

                Util.Util.ConfigLookupEdit(this.slkupGastosOtrosPagos, dtGastos, "Descripcion", "IDGasto");
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupGastosOtrosPagos, "[{'ColumnCaption':'ID','ColumnField':'IDGasto','width':30},{'ColumnCaption':'Descripción','ColumnField':'Descripcion','width':70}]");

                this.slkupPresentacion.DataSource = dtPresentacion;
                this.slkupPresentacion.DisplayMember = "Descr";
                this.slkupPresentacion.ValueMember = "IDUnidad";
                this.slkupPresentacion.NullText = " --- ---";
               // this.slkupPresentacion.EditValueChanged += slkup_EditValueChanged;
                this.slkupPresentacion.Popup += slkup_Popup;

                this.slkupIDProducto.DataSource = dtProductos;
                this.slkupIDProducto.DisplayMember = "IDProducto";
                this.slkupIDProducto.ValueMember = "IDProducto";
                this.slkupIDProducto.NullText = " --- ---";
				this.slkupIDProducto.View.OptionsView.ShowAutoFilterRow = true;
                this.slkupIDProducto.EditValueChanged += slkup_EditValueProductoChanged;
                this.slkupIDProducto.Popup += slkup_Popup;
                //this.slkupIDProducto.PopulateViewColumns();
    
                this.slkupDescrProducto.DataSource = dtProductos;
                this.slkupDescrProducto.DisplayMember = "Descr";
                this.slkupDescrProducto.ValueMember = "IDProducto";
                this.slkupDescrProducto.NullText = " --- ---";
				this.slkupDescrProducto.View.OptionsView.ShowAutoFilterRow = true;
                this.slkupDescrProducto.EditValueChanged += slkup_EditValueProductoChanged;
                this.slkupDescrProducto.Popup += slkup_Popup;

                //this.gridViewOtrosPagos.FocusedRowChanged += gridViewOtrosPagos_FocusedRowChanged;
                this.gridViewObligaciones.FocusedRowChanged += gridViewOtrosPagos_FocusedRowChanged;

                LoadData();

                LoadObligacionProveedor();

                LoadOtrosGastos();
                HabilitarBotonesOtrosPagos();
                HabilitarControlesOtrosPagos(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Han ocurrido los siguientes errores: " + ex.Message);
            }

        }

        void gridViewOtrosPagos_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            SetCurrentRowOtrosPagos();
        }

        void LoadOtrosGastos()
        {
            if (IDObligacionProveedor != -1)
            {
                dtObligacionDetalle = DAC.clsObligacionDetalleDAC.Get(-1, IDObligacionProveedor).Tables[0];
                this.dtgObligaciones.DataSource = dtObligacionDetalle;
                this.tabOtros.PageVisible = true;
				
            }
            else
            {
                this.tabOtros.PageVisible = false;
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

        private void slkup_EditValueProductoChanged(object sender, EventArgs e)
        {
            SearchLookUpEdit editor = sender as SearchLookUpEdit;
            DataRowView dr = (DataRowView)editor.GetSelectedDataRow();
            if (dr != null)
            {
                this.gridView1.PostEditor();
                int IDUnidad = Convert.ToInt32(dr["IDUnidad"]);
                this.gridView1.SetFocusedRowCellValue("IDUnidad", IDUnidad);
            }
            SendKeys.Send("{TAB}");
        }


    

       
        void dtgDetalleSolicitud_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar el elemento seleccionado?", "Embarque", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
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
            try
            {
                if (view == null) return;
                DataRow fila = view.GetDataRow(e.RowHandle);

                
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
                
                object vIDProducto = (object)(view.GetRowCellValue(e.RowHandle, IDProducto));
                
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



      


        private void dtgDetalle_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete && Accion != "View" && Accion != "ReadOnly")
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
            if (this.dtpFecha.EditValue.ToString() == "" || this.dtpFecha.EditValue == null)
                sMensaje = "   • Fecha \r\n";
            if (this.dtpFechaEmbarque.EditValue == null || this.dtpFechaEmbarque.EditValue.ToString() == "")
                sMensaje = "   • Fecha Embarque \r\n";

            if (((DataTable)this.dtgDetalleEmbarque.DataSource).Rows.Count == 0)
                sMensaje = sMensaje = "   • Por favor agrege al menos un elemento al detalle del embarque \r\n";
            foreach (DataRow fila in ((DataTable)this.dtgDetalleEmbarque.DataSource).Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    if (fila["CantidadAceptada"] == DBNull.Value || Convert.ToDecimal(fila["CantidadAceptada"]) == 0)
                        sMensaje = "  • El producto " + fila["DescrProducto"].ToString() + " debe de tener la cantidad recibida\r\n";
                    
                }
            }

            DataTable dtDetalle = ((DataTable)this.dtgDetalleEmbarque.DataSource);

            
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
                //Aceptar los cambios de la grid
                
                this.gridViewDetalleEmbarque.PostEditor();
                
                if (ValidarDatos())
                {
                    Fecha = Convert.ToDateTime(this.dtpFecha.EditValue);
                    FechaEmbarque = Convert.ToDateTime(this.dtpFechaEmbarque.EditValue);
                    IDProveedor = Convert.ToInt32(this.txtProveedor.Tag);
                    Embarque = this.txtEmbarque.EditValue.ToString().Trim();
                    IDBodega = Convert.ToInt32(this.txtBodega.Tag);

                    DataTable dt = (DataTable)this.dtgDetalleEmbarque.DataSource;

                    ConnectionManager.BeginTran();
                    

                    if (Accion == "Add")
                    {
                        OrdenCompra = "--";
                        
                        //Ingresar la cabecera de la solicitud
                        IDEmbarque = DAC.clsEmbarqueDAC.InsertUpdate("I", IDEmbarque,ref Embarque,Fecha,FechaEmbarque,IDBodega,IDProveedor,IDOrdenCompra,-1,Convert.ToDecimal(TipoCambio), sUsuario, DateTime.Now,sUsuario,DateTime.Now,sUsuario, ConnectionManager.Tran);
                        this.txtEmbarque.Tag = IDEmbarque;
                        this.txtEmbarque.Text = Embarque;
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row.RowState != DataRowState.Deleted)
                            {
                                decimal CantidadRechazada = (decimal)row["CantidadOrdenada"] - (decimal)row["CantidadAceptada"];
                                DAC.clsEmbarqueDetalleDAC.InsertUpdate("I", IDEmbarque, (long)row["IDProducto"], (decimal)row["PrecioUnitario"], (decimal)row["Impuesto"], (decimal)row["PorcDesc"], (decimal)row["MontoDesc"], (decimal)row["CantidadOrdenada"], (decimal)row["CantidadAceptada"], CantidadRechazada, "", ConnectionManager.Tran);
                                DAC.clsOrdenCompraDetalleDAC.UpdateCantidadRecibida(IDOrdenCompra, (long)row["IDProducto"], (decimal)row["CantidadAceptada"],ConnectionManager.Tran);
                            }
                        }

                    }

                     if (Accion == "Edit")
                    {
                        IDEmbarque = DAC.clsEmbarqueDAC.InsertUpdate("U", IDEmbarque,ref Embarque, Fecha, FechaEmbarque, IDBodega, IDProveedor, IDOrdenCompra, -1, 0, sUsuario, DateTime.Now, sUsuario, DateTime.Now, sUsuario, ConnectionManager.Tran);
                        
                         //Eliminamos el detalle y lo volvemos a insertar
                        DAC.clsEmbarqueDetalleDAC.InsertUpdate("D", IDEmbarque,-1,0,0,0,0,0,0,0,"", ConnectionManager.Tran);
                        DAC.clsOrdenCompraDetalleDAC.UpdateCantidadRecibida(IDOrdenCompra, -1,0, ConnectionManager.Tran);
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row.RowState != DataRowState.Deleted)
                            {
                                decimal CantidadRechazada = (decimal)row["CantidadOrdenada"] - (decimal)row["CantidadAceptada"];
                                CantidadRechazada = (CantidadRechazada > 0) ? CantidadRechazada : 0;
                                DAC.clsEmbarqueDetalleDAC.InsertUpdate("I", IDEmbarque, (long)row["IDProducto"], (decimal)row["PrecioUnitario"], (decimal)row["Impuesto"], (decimal)row["PorcDesc"], (decimal)row["MontoDesc"], (decimal)row["CantidadOrdenada"], (decimal)row["CantidadAceptada"], CantidadRechazada, "", ConnectionManager.Tran);
                                DAC.clsOrdenCompraDetalleDAC.UpdateCantidadRecibida(IDOrdenCompra, (long)row["IDProducto"], (decimal)row["CantidadAceptada"], ConnectionManager.Tran);
                            }
                        }

                        
                    }

                    ConnectionManager.CommitTran();
                    this.Accion = "View";
                    HabilitarControles();
                    HabilitarBotoneriaPrincipal();
                    MessageBox.Show("El embarque se ha guardado correctamente");
                    
                }
            } catch (Exception ex)
            {
                ConnectionManager.RollBackTran();
                 MessageBox.Show("Han ocurrido los siguiente errores: " + ex.Message);
            }

        }

        private void btnCancelarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
           // LoadData();
        }

        private void btnEliminarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Confirmada) {
                    MessageBox.Show("No se puede eliminar un embarque se encuentra en estado confirmada");
                    return;
                }
                if (MessageBox.Show("Esta seguro que desea eliminar la Orden de Compra seleccionada ? ", "Listado de Ordenes de Compra", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (IDOrdenCompra >-1)
                    {
                        ConnectionManager.BeginTran();

						DAC.clsEmbarqueDetalleDAC.InsertUpdate("D", IDEmbarque, -1, 0, 9, 0, 0, 0, 0, 0, "", ConnectionManager.Tran);
						DAC.clsEmbarqueDAC.InsertUpdate("D", IDEmbarque, ref Embarque ,DateTime.Now, DateTime.Now,-1,-1,-1,-1,0,"",DateTime.Now,"",DateTime.Now,"", ConnectionManager.Tran);                            
                        ConnectionManager.CommitTran();
                        MessageBox.Show("El embarque ha sido eliminado correctamente");
                    }
					this.IDEmbarque = -1;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Han ocurrido los siguientes errores: \n\r" + ex.Message);
                ConnectionManager.RollBackTran();
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

        private void btnAplicar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            String sMensaje = "";
            if (!this.Confirmada) 
                sMensaje =  sMensaje + " • La orden debe de estar confirmada \n\r";                            
            if (this.IDObligacionProveedor == -1)            
                sMensaje =  sMensaje + " • Debe definir la obligación del proveedor \n\r";   
            DataView dv = this.dtDetalleEmbarque.AsDataView();
            dv.RowFilter = "CantidadAceptada>0";  
            if (dv.ToTable().Rows.Count==0){
                sMensaje = sMensaje + " • Se ingresar las cantidades que se aceptaran del embarque\n\r";
            }

            if (sMensaje !="") {
                MessageBox.Show("No puede liquidar el embarque, por favor revise : \n\r" + sMensaje) ;
                return ;
            }

            frmLiquidacion ofrmLiquidacion = new frmLiquidacion(-1, this.IDEmbarque, this.IDOrdenCompra, this.OrdenCompra, this.Embarque);
            ofrmLiquidacion.ShowDialog();
            
           
        }

        private void linkAsiento_Click(object sender, EventArgs e)
        {
            if (this.linkAsiento.Text != "")
            {
                CG.frmAsiento ofrmAsiento = new CG.frmAsiento(this.linkAsiento.Text);
                ofrmAsiento.ShowDialog();
            }
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            dtDetalleEmbarque.Clear();
            foreach (DataRow row in dtDetalleOrden.Rows)
            {
                DataRow fila = this.dtDetalleEmbarque.NewRow();
                fila["IDProducto"] = row["IDProducto"];
                fila["DescrProducto"] = row["DescrProducto"];
                fila["PrecioUnitario"] = row["PrecioUnitario"];
                fila["Impuesto"] = row["Impuesto"];
                fila["PorcDesc"] = row["PorcDesc"];
                fila["MontoDesc"] = row["MontoDesc"];
                fila["CantidadOrdenada"] = row["Cantidad"];
                fila["CantidadAceptada"] = row["Cantidad"];
                this.dtDetalleEmbarque.Rows.Add(fila);
            }
            this.dtgDetalleEmbarque.DataSource = null;
            this.dtgDetalleEmbarque.DataSource = dtDetalleEmbarque;
        }

        private void btnConfirmar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataView dv = this.dtDetalleEmbarque.AsDataView();
            dv.RowFilter = "CantidadAceptada>0";
            if (dv.ToTable().Rows.Count == 0)
            {
                MessageBox.Show("Por favor verifique lo siguiente: \n\r   • Se ingresar las cantidades que se aceptaran del embarque\n\r");
                return;
            } 
            bool result = clsEmbarqueDAC.ConfirmarEmbarque((int)this.ID_Embarque, true, null);
            if (result) { 
                MessageBox.Show("El Embarque ha sido confirmado");
                this.btnConfirmar.Enabled =false;
                this.btnAplicar.Enabled = true;
                this.Confirmada = true;
                this.tabFactura.PageVisible = true;
                this.xtraTabControl1.SelectedTabPage = this.tabFactura;
                CalcularTotalesEmbarque();
            }
        }


        private void ObtenerDatosFactura() {
            this.Factura = this.txtFactura.Text.Trim();
            this.GuiaBL = this.txtGuiaBL.Text.Trim();
            this.Poliza = this.txtPoliza.Text.Trim();
            this.FechaFactura = Convert.ToDateTime(this.dtpFechaFactura.EditValue);
            this.FechaVence = Convert.ToDateTime(this.dtpFechaVence.EditValue);
            this.FechaPoliza = Convert.ToDateTime(this.dtpFechaPoliza.EditValue);
            this.TipoCambioPoliza = Convert.ToDouble(this.txtTipoCambio.EditValue);
            this.ValorMercaderia = Convert.ToDouble(this.txtTotalMercaderia.EditValue);
            this.MontoSeguro = Convert.ToDouble(this.txtMontoSeguro.EditValue);
            this.MontoFlete = Convert.ToDouble(this.txtMontoFlete.EditValue);
            this.MontoTotal = Convert.ToDouble(this.txtTotal.EditValue);
        }

        private bool ValidarDatosFactura()
        {
            String sMensaje = "";
            if (this.txtFactura.Text.Trim() == "")
                sMensaje = sMensaje + " • Factura. \n\r";
            if (this.txtPoliza.Text.Trim() == "")
                sMensaje = sMensaje + " • Poliza \n\r";
            if (this.txtTipoCambio.Text.Trim() == "")
                sMensaje = sMensaje + " • Tipo de Cambio \n\r";
            if (Convert.ToDateTime(this.dtpFechaVence.EditValue) < Convert.ToDateTime(this.dtpFechaFactura.EditValue))
                sMensaje = sMensaje + " • La fecha de vencimiento no puede ser menor a la fecha de factura";
            if (sMensaje != "")
            {
                MessageBox.Show("Por favor verifique los siguientes campos: \n\r" + sMensaje);
                return false;
            }
            
            else
            {
                return true;
            }
        }

        private void GuardarDatosFactura()
        {

            try
            {
                String AccionDatosFactura = "";
                if (IDObligacionProveedor == -1)
                    AccionDatosFactura = "I";
                else
                    AccionDatosFactura = "U";
                ConnectionManager.BeginTran();
                clsObligacionProveedorDAC.InsertUpdate(AccionDatosFactura, ref IDObligacionProveedor, (int)IDEmbarque, false, FechaFactura, FechaVence, FechaPoliza, Poliza, Factura, GuiaBL, (decimal)TipoCambio, (decimal)ValorMercaderia, (decimal)MontoFlete, (decimal)MontoSeguro, (decimal)MontoTotal, ConnectionManager.Tran);
                this.tabOtros.PageVisible = true;
                ConnectionManager.CommitTran();
                MessageBox.Show("Los datos de Factura se han guardado correctamente");
            }
            catch (Exception ex)
            {
                ConnectionManager.RollBackTran();
                MessageBox.Show("Ha ocurrido un error tratando de actualizar los datos de compra");
            }
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            if (ValidarDatosFactura()) {
                ObtenerDatosFactura();
                GuardarDatosFactura();
                AlertaFacturaSinGuardar();
            }
        }

        private void dtpFechaFactura_EditValueChanged(object sender, EventArgs e)
        {
            String sTipoCambio = CG.ParametrosContabilidadDAC.GetTipoCambioModulo();
            DataSet DS = CG.TipoCambioDetalleDAC.GetData(sTipoCambio, Convert.ToDateTime(this.dtpFechaFactura.EditValue));
            this.TipoCambioPoliza = Convert.ToDouble((DS.Tables[0].Rows.Count == 0) ? 0 : DS.Tables[0].Rows[0]["Monto"]);
            this.txtTipoCambio.EditValue = this.TipoCambioPoliza;

			if (this.dtpFechaFactura.EditValue != null && this.dtpFechaFactura.EditValue.ToString() != "")
			{
				this.dtpFechaVence.EditValue = DAC.clsOrdenCompraDAC.CalculaFechaVencimiento(Convert.ToInt32(this.IDOrdenCompra), Convert.ToDateTime(dtpFechaFactura.EditValue));
			}

			//Calcular la fecha de vencimiento

        }

        private void btnGenerarDocCPFactura_Click(object sender, EventArgs e)
        {
            try
            {
                //GenerarDocumento CP
                bool bOkGeneraAsiento =false;
                ConnectionManager.BeginTran();
                bOkGeneraAsiento = clsObligacionProveedorDAC.GeneraAsientoContable((int)this.ID_Embarque, this.sUsuario, ref this.AsientoFactura, ConnectionManager.Tran);
                ConnectionManager.CommitTran();
                if (bOkGeneraAsiento) {
                    CG.frmAsiento ofrmAsiento = new CG.frmAsiento(this.AsientoFactura);
                    ofrmAsiento.ShowDialog();
                }
                InactivarControles(true);
            }catch ( Exception ex) {
                ConnectionManager.RollBackTran();
                MessageBox.Show("Han ocurrido los siguientes errores: " + ex.Message);
            }
        }
        private void HabilitarControlesOtrosPagos(bool Flag)
        {
            this.dtpFechaOtrosPagos.ReadOnly = !Flag;
            this.txtDocumentoOtrosPagos.ReadOnly = !Flag;
            this.slkupProveedorOtrosPagos.ReadOnly = !Flag;
            this.slkupMonedaOtrosPagos.ReadOnly = !Flag;
            this.slkupMonedaOtrosPagos.ReadOnly = !Flag;
            this.txtMontoOtrosPagos.ReadOnly = !Flag;
            this.txtImpuesto.ReadOnly = !Flag;
            this.slkupGastosOtrosPagos.ReadOnly = !Flag;
            this.dtgObligaciones.Enabled = !Flag;
        }
        private void HabilitarBotonesOtrosPagos()
        {
			if (DAC.clsEmbarqueDAC.GetEstadoLiquidacion((int)this.IDEmbarque) == 2)
			{
				this.btnAgregarOtrosPagos.Enabled = false;
				this.btnEditarOtrosPagos.Enabled = false;
				this.btnEliminarOtrosGastos.Enabled = false;
				this.btnGuardarOtrosPagos.Enabled = false;
				this.btnCancelarOtrosPagos.Enabled = false;

			}
			else
			{
				if (AccionOtrosPagos == "New" || AccionOtrosPagos == "Edit")
				{
					this.btnAgregarOtrosPagos.Enabled = false;
					this.btnEditarOtrosPagos.Enabled = false;
					this.btnCancelarOtrosPagos.Enabled = true;
					this.btnGuardarOtrosPagos.Enabled = true;
					this.btnEliminarOtrosGastos.Enabled = false;
				}
				else
				{
					this.btnAgregarOtrosPagos.Enabled = true;
					this.btnEditarOtrosPagos.Enabled = true;
					this.btnCancelarOtrosPagos.Enabled = false;
					this.btnGuardarOtrosPagos.Enabled = false;
					this.btnEliminarOtrosGastos.Enabled = true;
				}
			}

        }

        private void btnAgregarOtrosPagos_Click(object sender, EventArgs e)
        {
            AccionOtrosPagos = "New";
            HabilitarControlesOtrosPagos(true);
            HabilitarBotonesOtrosPagos();
            LimpiarControles();
            this.dtpFechaOtrosPagos.Focus();
           // this.dtgOtrosPagos.Enabled = false;
        }


        private void UpdateControlsFromCurrentRow(DataRow Row)
        {
            this.dtpFechaOtrosPagos.EditValue = Convert.ToDateTime(Row["FechaDocumento"]);
            this.txtDocumentoOtrosPagos.EditValue = Row["Documento"].ToString();
            this.txtMontoOtrosPagos.EditValue = Convert.ToDecimal(Row["SubTotal"]);
            this.slkupGastosOtrosPagos.EditValue = Convert.ToInt32(Row["IDGasto"]);
            this.slkupProveedorOtrosPagos.EditValue = Convert.ToInt32(Row["IDProveedor"]);
            this.slkupMonedaOtrosPagos.EditValue = Convert.ToInt32(Row["IDMoneda"]);
            this.txtImpuesto.EditValue = Convert.ToDecimal(Row["PorcImpuesto"]);
            IDObligacionDetalle = Convert.ToInt32(Row["IDObligacionDetalle"]);
        }


        private void LimpiarControles()
        {
            this.dtpFechaOtrosPagos.EditValue=  null;
            this.txtDocumentoOtrosPagos.EditValue = null;
            this.txtMontoOtrosPagos.EditValue = null;
            this.slkupGastosOtrosPagos.EditValue = null;
            this.slkupProveedorOtrosPagos.EditValue = null;
            this.slkupMonedaOtrosPagos.EditValue = null;
            this.txtImpuesto.EditValue = null;
           
        }

        private void SetCurrentRowOtrosPagos()
        {
            if (this.gridViewObligaciones.DataSource != null)
            {
                int index = (int)this.gridViewObligaciones.FocusedRowHandle;
                if (index > -1)
                {
                    currentRowOtrosPagos = gridViewObligaciones.GetDataRow(index);
                    UpdateControlsFromCurrentRow(currentRowOtrosPagos);
                }
            }
        }

        private void btnEditarOtrosPagos_Click(object sender, EventArgs e)
        {
            if (this.currentRowOtrosPagos != null)
            {
                AccionOtrosPagos = "Edit";
                HabilitarControlesOtrosPagos(true);
                HabilitarBotonesOtrosPagos();
                this.dtpFechaOtrosPagos.Focus();
                //this.dtgOtrosPagos.Enabled = false;
            }
        }

        private void btnCancelarOtrosPagos_Click(object sender, EventArgs e)
        {
            AccionOtrosPagos = "View";
            LimpiarControles();
            HabilitarControlesOtrosPagos(true);
            HabilitarBotonesOtrosPagos();
            this.dtgObligaciones.Enabled = true;
            if (this.dtObligacionDetalle.Rows.Count == 1) {
                UpdateControlsFromCurrentRow(currentRowOtrosPagos);
            }
                
        }

        private bool ValidarDatosOtrosPagos()
        {
            String sMsg = "";
            if (this.dtpFechaOtrosPagos.EditValue == null)
                sMsg = sMsg + " • Seleccion la fecha del documento \n\r";
            if (this.txtDocumentoOtrosPagos.EditValue == null) 
                sMsg = sMsg + " • Digite el numero del documento \n\r";
            if (this.txtMontoOtrosPagos.EditValue == null)
                sMsg = sMsg + " • Digite el Monto del documento \n\r";
            if (this.slkupGastosOtrosPagos.EditValue == null)
                sMsg = sMsg + " • Seleccione el gasto al que pertenece el documento \n\r";
            if (this.slkupProveedorOtrosPagos.EditValue == null)
                sMsg = sMsg + " • Seleccione el proveedor al que pertenece el documento \n\r";
            if (sMsg != "")
            {
                MessageBox.Show("Por favor revise los datos \n\r" + sMsg);
                return false;
            }
            else
                return true;
        }

        private void btnGuardarOtrosPagos_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatosOtrosPagos())
                {
                    String sAccion = "";
                    if (AccionOtrosPagos == "New")
                        sAccion = "I";
                    else
                        sAccion = "U";

                    ConnectionManager.BeginTran();
                    decimal subtotal= Convert.ToDecimal(this.txtMontoOtrosPagos.EditValue);
                    decimal PorcImpuesto = Convert.ToDecimal(this.txtImpuesto.EditValue);
                    decimal MontoImpuesto = subtotal * (PorcImpuesto / 100);
                    decimal MontoTotal = subtotal + MontoImpuesto;
                    DAC.clsObligacionDetalleDAC.InsertUpdate(sAccion,ref IDObligacionDetalle, IDObligacionProveedor, Convert.ToInt32(this.slkupProveedorOtrosPagos.EditValue), this.txtDocumentoOtrosPagos.Text.Trim(), false, Convert.ToDateTime(this.dtpFechaOtrosPagos.EditValue),subtotal,PorcImpuesto,MontoImpuesto,MontoTotal,  Convert.ToInt32(this.slkupMonedaOtrosPagos.EditValue),Convert.ToInt32(this.slkupGastosOtrosPagos.EditValue), ConnectionManager.Tran);
                    ConnectionManager.CommitTran();

                    //dtObligacionDetalle = DAC.clsObligacionDetalleDAC.Get(-1, this.IDObligacionProveedor).Tables[0];
                    //this.dtgOtrosPagos.DataSource = dtObligacionDetalle;
                    LimpiarControles();
                    this.AccionOtrosPagos = "View";
                    HabilitarBotonesOtrosPagos();
                    HabilitarControlesOtrosPagos(false);
                    this.dtgObligaciones.Enabled = true;
                    this.LoadOtrosGastos();


                }
            }
            catch (Exception ex)
            {
                ConnectionManager.RollBackTran();
                MessageBox.Show("Ha ocurrido errores, al momento de guardar el documento");
            }
        }

        private void btnEliminarOtrosGastos_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.currentRowOtrosPagos != null)
                {
                    ConnectionManager.BeginTran();
                    this.IDObligacionDetalle =Convert.ToInt32(this.currentRowOtrosPagos["IDObligacionDetalle"]);
                    DAC.clsObligacionDetalleDAC.InsertUpdate("D", ref IDObligacionDetalle, -1, -1, "", false, DateTime.Now, 0, -1,0,0,0,-1, ConnectionManager.Tran);
                    ConnectionManager.CommitTran();
                    LimpiarControles();
                    LoadOtrosGastos();
                }
            }
            catch (Exception ex) {
                ConnectionManager.RollBackTran();
                MessageBox.Show("Ha ocurrido errores al momento de eliminar el documento");
            }
        }

        private void btnRecepcionMercaderia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAC.clsEmbarqueDAC.GetEstadoLiquidacion((int)this.IDEmbarque) == 2)
            {
                frmRecepcionMercaderia oRecepcion = new frmRecepcionMercaderia(this.ID_Embarque,this.IDOrdenCompra);
                oRecepcion.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tiene que liquidar el embarque para poder dar ingreso al inventario");
                return;
            }
        }

				private void linkAsientoMercaderia_Click(object sender, EventArgs e)
				{
					if (this.linkAsientoMercaderia.Text != "" || this.linkAsientoMercaderia.Text != " --- --- ")
					{
						CG.frmAsiento ofrmAsiento = new CG.frmAsiento(this.linkAsientoMercaderia.Text);
						ofrmAsiento.ShowDialog();
					}
				}

        

       

    }
}
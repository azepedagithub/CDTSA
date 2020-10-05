using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CO.DAC;
using Security;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraLayout;
using DevExpress.XtraGrid;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports.UI;

namespace CO
{
    public partial class frmLiquidacion : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _IDLiquidacion;
        private long _IDOrdenCompra;
        private long _IDEmbarque;
        private String _Liquidacion="";
        private bool _GroupedGastos = false;
        private bool _isMonedaNacional = false;

        private String OrdenCompra, Embarque;

        private DateTime Fecha;
        private double MontoFlete, MontoSeguro, Total, TipoCambio;
        private DataTable dtGastos = new DataTable();

        String sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
        private DataTable dtLiquidacion = new DataTable();
        private DataTable dtLiquidacionGasto = new DataTable();
        private DataTable dtLiquidacionGastoDetalle = new DataTable();
        private DataTable dtObligacionDetalle = new DataTable();
        private DataTable dtObligacionProveedor = new DataTable();
        private DataTable dtMoneda = new DataTable();
        
        private String _Accion;
        
 
        public frmLiquidacion(int IDLiquidacion)
        {
            InitializeComponent();
            this._IDLiquidacion = IDLiquidacion;
            this._IDOrdenCompra = -1;
            this._IDEmbarque = -1;
        }

        public frmLiquidacion(long IDLiquidacion,long IDEmbarque, long IDOrdenCompra, String OrdenCompra,String Embarque, String Accion)
        {
            InitializeComponent();
            this._IDLiquidacion = Convert.ToInt32(IDLiquidacion);
            this._IDEmbarque = IDEmbarque;
            this._IDOrdenCompra = IDOrdenCompra;
            this.OrdenCompra = OrdenCompra;
            this.Embarque = Embarque;
            this._Accion = Accion;
        }

        
        private void CargarLiquidacion(long IDLiquidacion, long IDOrdenCompra, long IDEmbarque)
        {
            this.dtLiquidacion = clsLiquidacionCompraDAC.Get(_IDLiquidacion, _IDEmbarque, _IDOrdenCompra).Tables[0];
            if (this.dtLiquidacion.Rows.Count > 0)
            {
                this._IDLiquidacion = Convert.ToInt32(this.dtLiquidacion.Rows[0]["IDLiquidacion"]);
                this._IDEmbarque = Convert.ToInt32(this.dtLiquidacion.Rows[0]["IDEmbarque"]);
                this._IDOrdenCompra = Convert.ToInt32(this.dtLiquidacion.Rows[0]["IDOrdenCompra"]);
               
            }
            
            this.dtLiquidacionGasto = clsGastosLiquidacionCompraDAC.Get(_IDLiquidacion, -1).Tables[0];
            this.dtLiquidacionGastoDetalle = clsGastosLiquidacionDetalladoDAC.Get(_IDLiquidacion, -1, -1, null).Tables[0];
            
            this.dtObligacionProveedor = clsObligacionProveedorDAC.Get((int)this._IDEmbarque, -1).Tables[0];

            //Cargar los gastos generados en embarque
            dtObligacionDetalle = DAC.clsObligacionDetalleDAC.GetConsolidadoObligacionDetalle((int)this._IDEmbarque).Tables[0];
           
            this.dtMoneda = ControlBancario.DAC.MonedaDAC.GetMoneda(-1).Tables[0];
            DataTable dtOrdenCompra = clsOrdenCompraDAC.GetByID(_IDOrdenCompra).Tables[0];

            DataView dv = dtMoneda.AsDataView();
            dv.RowFilter = "IDMoneda=" + dtOrdenCompra.Rows[0]["IDMoneda"].ToString();
            DataRow dtMonedaDoc = dv.ToTable().Rows[0];
            this.lblMoneda.Text = dtMonedaDoc["Descr"].ToString();

            if (Convert.ToBoolean(dtMonedaDoc["Nacional"]) == true)
                this._isMonedaNacional = true;
            else 
                this._isMonedaNacional = false;


            UpdateControlsFromData(this.dtLiquidacion, this.dtObligacionProveedor);
            
            if (dtLiquidacionGasto.Rows.Count > 0)
                this.dtgGastosInternacion.DataSource = dtLiquidacionGasto;
            else
            {
                foreach(DataRow fila in dtObligacionDetalle.Rows){
                    DataRow newRow = dtLiquidacionGasto.NewRow();
                    newRow["IDLiquidacion"] = this._IDLiquidacion;
                    newRow["IDGasto"] = fila["IDGasto"];
                    newRow["Monto"] = fila["SubTotal"];
                    dtLiquidacionGasto.Rows.Add(newRow);
                }

                this.dtgGastosInternacion.DataSource = dtLiquidacionGasto;
            }

            this.dgProrrateo.DataSource = dtLiquidacionGastoDetalle;

        }


        private void InicializarNuevoElement()
        {
            this.lblLiquidacion.Text = "";
            this.hypEmbarque.Text = "--";
            this.hypOrdenCompra.Text = "--";
            this.txtMontoFlete.Text = "0.0";
            this.txtMontoDolar.Text = "0.0";
            this.txtMontoLocal.Text = "0.0";
            this.txtMontoSeguro.Text = "0.0";
            this.txtTipoCambio.Text = "0.0";
            this.dtLiquidacionGasto = new DataTable();
            this.dtLiquidacionGastoDetalle = new DataTable();

        }

        private void HabilitarBotoneriaPrincipal()
        {

            if (_Accion == "Add" || _Accion == "Edit")
            {
                this.btnEditar.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnEliminar.Enabled = false;

            }
            else if (_Accion == "View")
            {
                this.btnEditar.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;

                this.btnEliminar.Enabled = true;
            }
            else if (_Accion == "ReadOnly")
            {
                this.btnEditar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
        }


        private void HabilitarControles()
        {

            this.txtMontoLocal.ReadOnly = true;
            this.txtMontoDolar.ReadOnly = true;
                
            if (_Accion == "Add" || _Accion == "Edit")
            {

                this.txtMontoFlete.ReadOnly = false;
                this.txtMontoSeguro.ReadOnly = false;

                this.gridViewGastosInternacion.OptionsBehavior.ReadOnly = false;
                this.gridViewGastosInternacion.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                this.gridViewGastosInternacion.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;

                this.gridViewProrrateo.OptionsBehavior.ReadOnly = false;
                this.gridViewProrrateo.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                this.gridViewProrrateo.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            }
            else
            {

                this.txtMontoFlete.ReadOnly = true;
                this.txtMontoSeguro.ReadOnly = true;

                this.gridViewGastosInternacion.OptionsBehavior.ReadOnly = true;
                this.gridViewGastosInternacion.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                this.gridViewGastosInternacion.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;

                this.gridViewProrrateo.OptionsBehavior.ReadOnly = true;
                this.gridViewProrrateo.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                this.gridViewProrrateo.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            }


        }

        private void UpdateControlsFromData(DataTable dt, DataTable dtObligacion)
        {
            if (dt.Rows.Count > 0)
            {
                DataRow cabecera = dt.Rows[0];
                this.lblLiquidacion.Text = cabecera["Liquidacion"].ToString();
                this.hypEmbarque.Text = cabecera["Embarque"].ToString();
                this.hypEmbarque.Tag = cabecera["IDEmbarque"].ToString();
                this.hypOrdenCompra.Tag = cabecera["IDOrdenCompra"].ToString();
                this.hypOrdenCompra.Text = cabecera["OrdenCompra"].ToString();

                this.txtMontoFlete.EditValue = cabecera["MontoFlete"].ToString();
                this.txtMontoSeguro.EditValue = cabecera["MontoSeguro"].ToString();
                this.txtTipoCambio.EditValue = cabecera["TipoCambio"].ToString();
                this.txtValorMercaderia.EditValue = cabecera["ValorMercaderia"].ToString();

                if (_isMonedaNacional)
                {
                    this.txtMontoLocal.EditValue = cabecera["MontoTotal"].ToString();
                    this.txtMontoDolar.EditValue = (Convert.ToDouble(cabecera["MontoTotal"]) / TipoCambio).ToString();
                }
                else
                {
                    this.txtMontoDolar.EditValue = cabecera["MontoTotal"].ToString();
                    this.txtMontoLocal.EditValue = (Convert.ToDouble(cabecera["MontoTotal"]) * TipoCambio).ToString();
                }
                    

            }   else {
                this.txtValorMercaderia.EditValue = dtObligacion.Rows[0]["ValorMercaderia"].ToString();
                this.txtMontoFlete.EditValue = dtObligacion.Rows[0]["MontoFlete"].ToString();
                this.txtMontoSeguro.EditValue = dtObligacion.Rows[0]["MontoSeguro"].ToString();

                if (_isMonedaNacional)
                {
                    this.txtMontoLocal.EditValue = dtObligacion.Rows[0]["MontoTotal"].ToString();
                    this.txtMontoDolar.EditValue = (Convert.ToDouble(dtObligacion.Rows[0]["MontoTotal"]) / TipoCambio).ToString();
                }
                else
                {
                    this.txtMontoDolar.EditValue = dtObligacion.Rows[0]["MontoTotal"].ToString();
                    this.txtMontoLocal.EditValue = (Convert.ToDouble(dtObligacion.Rows[0]["MontoTotal"]) * TipoCambio).ToString();
                }
                  
            }
            
        }


        private void LoadData()
        {
            try
            {

                //TipoCambio = CG.TipoCambioDetalleDAC.GetLastTipoCambioFecha(DateTime.Now);
                this.dtpFechaLiquidacion.EditValue = DateTime.Now;
                HabilitarControles();
                HabilitarBotoneriaPrincipal();
                if (_Accion == "Add")
                {
                    this._IDLiquidacion = -1;
                    this.hypEmbarque.Text = this.Embarque;
                    this.hypEmbarque.Tag = this._IDEmbarque;
                    this.hypOrdenCompra.Text = this.OrdenCompra;
                    this.hypOrdenCompra.Tag = this._IDOrdenCompra;

                }
                CargarLiquidacion(this._IDLiquidacion, _IDOrdenCompra, _IDEmbarque);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        

        private void frmLiquidacion_Load(object sender, EventArgs e)
        {
            try
            {

                dtGastos = CO.DAC.clsGastosCompraDAC.Get(-1,"*").Tables[0];
                
                LoadData();

                this.slkupIDGasto.DataSource = dtGastos;
                this.slkupIDGasto.DisplayMember = "IDGasto";
                this.slkupIDGasto.ValueMember = "IDGasto";
                this.slkupIDGasto.NullText = " --- ---";
                this.slkupIDGasto.EditValueChanged += slkupIDGasto_EditValueChanged;
                this.slkupIDGasto.Popup += slkupIDGasto_Popup;
                //this.slkupIDProducto.PopulateViewColumns();


                this.slkupDescGasto.DataSource = dtGastos;
                this.slkupDescGasto.DisplayMember = "Descripcion";
                this.slkupDescGasto.ValueMember = "IDGasto";
                this.slkupDescGasto.NullText = " --- ---";
                this.slkupDescGasto.EditValueChanged += slkupDescGasto_EditValueChanged;
                this.slkupDescGasto.Popup += slkupIDGasto_Popup;

                this.gridViewGastosInternacion.ValidateRow += gridViewGastosInternacion_ValidateRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Han ocurrido los siguientes errores: " + ex.Message);
            }
        }

        void gridViewGastosInternacion_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                GridColumn IDGasto = view.Columns["IDGasto"];
                GridColumn Monto = view.Columns["Monto"];

                object vIDGasto = (object)(view.GetRowCellValue(e.RowHandle, IDGasto));
                object vMonto = (object)(view.GetRowCellValue(e.RowHandle, Monto));

                // Validacion de Productos Unicos en la lista

                if (e.Row == null) return;
                //Get the value of the first column
                int iIDGastos = (view.GetRowCellValue(e.RowHandle, IDGasto) != null) ? Convert.ToInt32(view.GetRowCellValue(e.RowHandle, IDGasto)) : -1;
                decimal dMonto = vMonto.GetType().ToString() !="System.DBNull" ? Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, Monto)) : -1;
                //Validity criterion

                DataView Dv = new DataView();
                Dv.Table = ((DataView)view.DataSource).ToTable();
                Dv.RowFilter = string.Format("IdGasto={0}", iIDGastos);

                if (Dv.ToTable().Rows.Count > 1)
                {
                    e.Valid = false;
                    //Set errors with specific descriptions for the columns
                    view.SetColumnError(IDGasto, "El Gasto debe ser unico en la lista");
                }

                if (vMonto.GetType().ToString() == "System.DBNull")
                {
                    e.Valid = false;
                    //Set errors with specific descriptions for the columns
                    view.SetColumnError(Monto, "El monto del gasto debe de tener un valor numerico.");
                }
                else if (dMonto <= 0)
                {
                    e.Valid = false;
                    //Set errors with specific descriptions for the columns
                    view.SetColumnError(Monto, "El monto del gasto debe se mayor a 0.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        void slkupDescGasto_EditValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        void slkupIDGasto_Popup(object sender, EventArgs e)
        {
            DevExpress.Utils.Win.IPopupControl popupControl = sender as DevExpress.Utils.Win.IPopupControl;
            DevExpress.XtraLayout.LayoutControl layoutControl = popupControl.PopupWindow.Controls[2].Controls[0] as LayoutControl;

            SimpleButton clearButton = ((DevExpress.XtraLayout.LayoutControlItem)layoutControl.Items.FindByName("lciClear")).Control as SimpleButton;
            SimpleButton findButton = ((DevExpress.XtraLayout.LayoutControlItem)layoutControl.Items.FindByName("lciButtonFind")).Control as SimpleButton;

            clearButton.Text = "Limpiar";
            findButton.Text = "Buscar";
        }

        void slkupIDGasto_EditValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void dtpFechaLiquidacion_EditValueChanged(object sender, EventArgs e)
        {
            if (this.dtpFechaLiquidacion.EditValue != null)
            {
                TipoCambio = Convert.ToDouble(CG.TipoCambioDetalleDAC.GetLastTipoCambioFecha(Convert.ToDateTime(this.dtpFechaLiquidacion.EditValue)));
                this.txtTipoCambio.EditValue = TipoCambio;
            }
        }


        private bool ValidarDatos()
        {
            String sMensaje = "";
            if (this.dtpFechaLiquidacion.EditValue == null)
                sMensaje = sMensaje + "Por favor seleccione la fecha de liquidación";
            if (this.txtTipoCambio.EditValue == null)
                sMensaje = sMensaje + "Por favor ingrese el tipo de cambio";
            if (sMensaje != "")
            {
                MessageBox.Show("Por favor verifique: \n\r" + sMensaje);
                return false;
            }
            else
                return true;
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try {
            if (ValidarDatos())
            {
                String sAccion = "";
                Decimal MontoAnterior = 0;
                if (this._IDLiquidacion == -1)
                    sAccion = "I";
                else
                {
                    sAccion = "U";
                    Decimal? value = (Decimal?)DAC.clsLiquidacionCompraDAC.Get(this._IDLiquidacion, -1, -1).Tables[0].Rows[0]["MontoTotal"];
                    MontoAnterior = Convert.ToDecimal(value == null ? 0 : value);
                }
                ConnectionManager.BeginTran();          
                DAC.clsLiquidacionCompraDAC.InsertUpdate(sAccion, ref _Liquidacion, ref _IDLiquidacion, (int)this._IDEmbarque, (int)this._IDOrdenCompra, Convert.ToDateTime(this.dtpFechaLiquidacion.EditValue), Convert.ToDecimal(this.txtTipoCambio.EditValue), Convert.ToDecimal(txtValorMercaderia.EditValue), Convert.ToDecimal(txtMontoFlete.EditValue), Convert.ToDecimal(this.txtMontoSeguro.EditValue), _isMonedaNacional ? Convert.ToDecimal(this.txtMontoLocal.EditValue) : Convert.ToDecimal(this.txtMontoDolar.EditValue), ConnectionManager.Tran);
                this.lblLiquidacion.Text = _Liquidacion;
                DAC.clsGastosLiquidacionCompraDAC.InsertUpdate("D",this._IDLiquidacion,-1,0,ConnectionManager.Tran);
                foreach(DataRow row in dtLiquidacionGasto.Rows) {
                    DAC.clsGastosLiquidacionCompraDAC.InsertUpdate("I", this._IDLiquidacion,Convert.ToInt32(row["IDGasto"]),Convert.ToDecimal(row["Monto"]),ConnectionManager.Tran);
                }
                
                Decimal MontoActual = _isMonedaNacional ? Convert.ToDecimal(this.txtMontoLocal.EditValue) : Convert.ToDecimal(this.txtMontoDolar.EditValue);

                if (MontoAnterior != MontoActual)
                {
                    this.dtLiquidacionGastoDetalle.Clear();
                    this.tbProrrateo.Text = "Prorrateo **PENDIENTE!!**";
                    this.tbProrrateo.Appearance.Header.BackColor = Color.Red;

                } else {
                    this.tbProrrateo.Text = "Prorrateo";
                    this.tbProrrateo.Appearance.Header.BackColor = Color.Transparent;
                    DAC.clsGastosLiquidacionDetalladoDAC.InsertUpdate("D", this._IDLiquidacion, -1, -1, 0, ConnectionManager.Tran);
                    foreach(DataRow row in dtLiquidacionGastoDetalle.Rows) {
                        DAC.clsGastosLiquidacionDetalladoDAC.InsertUpdate("I", this._IDLiquidacion,Convert.ToInt32(row["IDGasto"]),Convert.ToInt64(row["IDProducto"]),Convert.ToDecimal(row["Monto"]),ConnectionManager.Tran);
                    }       
                }
                
                ConnectionManager.CommitTran();
                MessageBox.Show("Los datos se han guardado correctamente");
            }
            }catch(Exception ex) {
                ConnectionManager.RollBackTran();
                MessageBox.Show("Ha ocurrido un error tratando de guardar la liquidación.");
            }
        }

        private void btnCalculaProrratoGastos_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbProrrateo.Text = "Prorrateo";
                this.tbProrrateo.Appearance.Header.BackColor = Color.Transparent;
                dtLiquidacionGastoDetalle = clsGastosLiquidacionDetalladoDAC.GetProrrateoGastosCompra(this._IDLiquidacion).Tables[0];
                this.dgProrrateo.DataSource = dtLiquidacionGastoDetalle;
            }
            catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un error trantando de prorratear la liquidación");
            }
        }

        private void btnAgrupar_Click(object sender, EventArgs e)
        {
            
            GridColumn colGasto = gridViewProrrateo.Columns["DescrGasto"];
            GridColumn colProd = gridViewProrrateo.Columns["DescrProducto"];
            gridViewProrrateo.BeginSort();
            try
            {
                gridViewProrrateo.ClearGrouping();
                if (!_GroupedGastos)
                {
                    colGasto.GroupIndex = 1;
                    colProd.GroupIndex = 0;
                    
                    _GroupedGastos= true;
                } else
                    _GroupedGastos = false;

            }
            finally
            {
                gridViewProrrateo.EndSort();
            }      
        }

        private void CalcularTotales()
        {
            Double ValorTotal = Convert.ToDouble(this.txtMontoFlete.EditValue) + Convert.ToDouble(this.txtMontoSeguro.EditValue) + Convert.ToDouble(this.txtValorMercaderia.EditValue);
            if (_isMonedaNacional)
            {
                this.txtMontoLocal.EditValue = ValorTotal;
                this.txtMontoDolar.EditValue = ValorTotal / TipoCambio;
            }
            else
            {
                this.txtMontoDolar.EditValue = ValorTotal;
                this.txtMontoLocal.EditValue = ValorTotal * TipoCambio;
            }
        }

        private void txtMontoFlete_EditValueChanged(object sender, EventArgs e)
        {
            CalcularTotales();    
        }

        private void txtMontoSeguro_EditValueChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void btnImpresion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this._IDLiquidacion != -1)
            {
                DevExpress.XtraReports.UI.XtraReport report = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reportes/Plantillas/rptLiquidacionCompra.repx", true);


                SqlDataSource sqlDataSource = report.DataSource as SqlDataSource;

                SqlDataSource ds = report.DataSource as SqlDataSource;
                ds.ConnectionName = "oDataSource";
                String sNameConexion = (Security.Esquema.Compania == "CEDETSA") ? "StringConCedetsa" : "StringConDasa";
                System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder(System.Configuration.ConfigurationManager.ConnectionStrings[sNameConexion].ConnectionString);
                ds.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(builder.DataSource, builder.InitialCatalog, builder.UserID, builder.Password, MsSqlAuthorizationType.SqlServer);

                //SqlDataSource ds1 = report.DataSource as SqlDataSource;

                //ds1.ConnectionName = "sqlDataSource1";
                //ds1.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(builder.DataSource, builder.InitialCatalog, builder.UserID, builder.Password, MsSqlAuthorizationType.SqlServer);
                XRSubreport subReporte = report.AllControls<XRSubreport>().First();
                XtraReport subReportSource = subReporte.ReportSource as XtraReport;
                SqlDataSource ds2 = subReportSource.DataSource as SqlDataSource;
                ds2.ConnectionName = "sqlDataSource1";
                ds2.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(builder.DataSource, builder.InitialCatalog, builder.UserID, builder.Password, MsSqlAuthorizationType.SqlServer);
                // Obtain a parameter, and set its value.
                report.Parameters["IDLiquidacion"].Value = this._IDLiquidacion;

                // Show the report's print preview.
                DevExpress.XtraReports.UI.ReportPrintTool tool = new DevExpress.XtraReports.UI.ReportPrintTool(report);

                tool.ShowPreview();


            }
        }

     
    }
}

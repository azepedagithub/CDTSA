using CO.DAC;
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

namespace CO
{
    public partial class frmListadoOrdenCompra : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        
        private DataSet _dsOrdenCompra;
        private DataTable _dtSecurity, _dtCompras,DTProveedores,DTEstados;
        private DateTime FechaInicial, FechaFinal, FechaRequeridaInicial, FechaRequeridaFinal;
        private String sProveedor, sEstado;
        private int IDOrdenCompra;

        DataRow currentRow;
        string _sUsuario = (UsuarioDAC._DS.Tables.Count>0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
        const String _tituloVentana = "Listado de Ordenes de Compra";

        List<object> valuesProveedor = new List<object>();
        List<object> valuesEstados = new List<object>();


        public frmListadoOrdenCompra()
        {
            InitializeComponent();
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.StartPosition = FormStartPosition.CenterScreen;
        }





        void frmListadoOrdenCompra_Load(object sender, EventArgs e)
        {
            try
            {
                FechaInicial = DateTime.Now.AddMonths(-1);
                FechaFinal = DateTime.Now;

                FechaRequeridaInicial = FechaInicial;
                FechaRequeridaFinal = FechaFinal;

                this.dtpFechaInicial.EditValue = FechaInicial;
                this.dtpFechaFinal.EditValue = FechaFinal.AddMonths(2);
                this.dtpFechaRequeridaInicial.EditValue= FechaRequeridaInicial;
                this.dtpFechaRequeridaFinal.EditValue = FechaRequeridaFinal.AddMonths(2);


                DTProveedores = clsProveedorDAC.Get(-1,"*",-1).Tables[0];
                Util.Util.ConfigLookupEdit(this.slkupProveedor, DTProveedores, "Nombre", "IDProveedor", 350);
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupProveedor, "[{'ColumnCaption':'IDProveedor','ColumnField':'IDProveedor','width':20},{'ColumnCaption':'Nombre','ColumnField':'Nombre','width':90}]");
                this.slkupProveedor.Properties.View.OptionsSelection.MultiSelect = true;
                this.slkupProveedor.Properties.View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                this.slkupProveedor.Popup += slkupProveedor_Popup;


                DTEstados = clsEstadoOrdenCompra.Get().Tables[0];
                Util.Util.ConfigLookupEdit(this.slkupEstado, DTEstados, "Descr", "IDEstadoOrden", 350);
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupEstado, "[{'ColumnCaption':'IDEstado','ColumnField':'IDEstadoOrden','width':20},{'ColumnCaption':'Descripción','ColumnField':'Descr','width':90}]");
                this.slkupEstado.Properties.View.OptionsSelection.MultiSelect = true;
                this.slkupEstado.Properties.View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                this.slkupEstado.Popup += slkupEstado_Popup;


                HabilitarControles(false);

                Util.Util.SetDefaultBehaviorControls(this.gridView1, false, this.gridControl1, _tituloVentana, this);

                EnlazarEventos();

                PopulateGrid();

                CargarPrivilegios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void slkupEstado_Popup(object sender, EventArgs e)
        {
            var edit = (SearchLookUpEdit)sender;
            //edit.Properties.View.SelectRow(0);
            setItemSelected(sEstado, edit);
        }

        private void SetSelection(string[] values, string fieldName, GridView view)
        {
            foreach (string val in values)
            {
                for (int i = 0; i < view.RowCount; i++)
                {

                    if (view.GetRowCellValue(i, fieldName).ToString() == val)
                        view.SelectRow(i);
                }
            }

        }


        private String GetFieldFind(string Nombre)
        {
            if (Nombre == "slkupProveedor")
                return "IDProveedor";
            else if (Nombre == "slkupEstado")
                return "IDEstadoOrden";
            else
                return "";

        }

        private void setItemSelected(string sLst, SearchLookUpEdit crt)
        {
            if (sLst != "*")
            {
                String[] valores = sLst.Split('|');
                GridView view = crt.Properties.View;
                SetSelection(valores, GetFieldFind(crt.Name), view);
            }
        }


        void slkupProveedor_Popup(object sender, EventArgs e)
        {
            var edit = (SearchLookUpEdit)sender;
            //edit.Properties.View.SelectRow(0);
            setItemSelected(sProveedor, edit);
        }

        
        private void CargarPrivilegios()
        {
            DataSet DS = new DataSet();
            DS = UsuarioDAC.GetAccionModuloFromRole(400,_sUsuario );
            _dtSecurity = DS.Tables[0];

            AplicarPrivilegios();
        }

        private void AplicarPrivilegios()
        {
            if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.AgregarOrdendeCompra, _dtSecurity))
                this.btnAgregar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.EditarOrdendeCompra, _dtSecurity))
                this.btnEditar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.EliminarOrdendeCompra, _dtSecurity))
                this.btnEliminar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosComprasType.ExportarOrdendeCompra, _dtSecurity))
                this.btnExportar.Enabled = false;
        }


        private void EnlazarEventos()
        {
            this.btnAgregar.ItemClick += btnAgregar_ItemClick;
            this.btnEditar.ItemClick += btnEditar_ItemClick;
            this.btnEliminar.ItemClick += btnEliminar_ItemClick;
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
            String FileName = System.IO.Path.Combine(tempPath, "Listado de Ordenes de Compras.xlsx");
            DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions()
            {
                SheetName = "Ordenes de Compras "
            };


            this.gridView1.ExportToXlsx(FileName, options);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = FileName;
            process.StartInfo.Verb = "Open";
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            process.Start();
        }

 

        
        private void  PopulateGrid()
        {

            try
            {
                FechaInicial = (this.dtpFechaInicial.EditValue == null) ? Convert.ToDateTime("1981/10/21") : Convert.ToDateTime(this.dtpFechaInicial.EditValue);
                FechaFinal = (this.dtpFechaInicial.EditValue == null) ? DateTime.Now.AddYears(10): Convert.ToDateTime(this.dtpFechaFinal.EditValue);
                FechaRequeridaInicial = this.dtpFechaRequeridaInicial.EditValue == null ? Convert.ToDateTime("1981/10/21") : Convert.ToDateTime(this.dtpFechaRequeridaInicial.EditValue);
                FechaRequeridaFinal = this.dtpFechaRequeridaFinal.EditValue == null ? DateTime.Now.AddYears(10) : Convert.ToDateTime(this.dtpFechaRequeridaFinal.EditValue);

                IDOrdenCompra = this.txtIDOrdenCompra.Text == "" ? -1 : Convert.ToInt32(this.txtIDOrdenCompra.Text);

                sProveedor = getLstFiltro("IDProveedor");
                sEstado = getLstFiltro("IDEstadoOrden");

                _dsOrdenCompra = clsOrdenCompraDAC.Get(IDOrdenCompra, FechaInicial, FechaFinal,sProveedor,sEstado,FechaRequeridaInicial,FechaRequeridaFinal);

                _dtCompras = _dsOrdenCompra.Tables[0];
                this.gridControl1.DataSource = null;
                this.gridControl1.DataSource = _dtCompras;

            }
            catch (Exception ex) {
                MessageBox.Show("Han ocurrido los siguientes errores: \n\r" + ex.Message);
            }
        }

        private void ClearControls()
        {
            this.txtIDOrdenCompra.Text = "";
            FechaInicial = DateTime.Now.AddMonths(-1);
            FechaFinal = DateTime.Now;

            FechaRequeridaInicial = DateTime.Now.AddMonths(-1);
            FechaRequeridaFinal = DateTime.Now;

            this.dtpFechaInicial.EditValue = FechaInicial;
            this.dtpFechaFinal.EditValue = FechaFinal;

            this.dtpFechaRequeridaInicial.EditValue = FechaRequeridaInicial;
            this.dtpFechaRequeridaFinal.EditValue = FechaRequeridaFinal;

            this.slkupEstado.EditValue = null;
            this.slkupProveedor.EditValue = null;
        }

        private void HabilitarControles(bool Activo)
        {
            this.btnAgregar.Enabled = !Activo;
            this.btnEditar.Enabled = !Activo;
            this.btnCancelar.Enabled = Activo;
            this.btnEliminar.Enabled = !Activo;
            this.btnExportar.Enabled = !Activo;
            this.btnRefrescar.Enabled = !Activo;

        }

        private void SetCurrentRow()
        {
            int index = (int)this.gridView1.FocusedRowHandle;
            if (index > -1)
            {
                currentRow = gridView1.GetDataRow(index);
               
            }
        }


        public String getLstFiltro(string sCampo)
        {
            String Result = "";
            switch (sCampo)
            {
                case "IDProveedor":
                    Result = String.Join("|", valuesProveedor);
                    if (Result == "")
                        Result = "*";
                    break;
                case "IDEstadoOrden":
                    Result = String.Join("|", valuesEstados);
                    if (Result == "")
                        Result = "*";
                    break;

            }

            return Result;
        }



        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetCurrentRow();
        }

        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOrdenCompra ofrmOrden = new frmOrdenCompra("Add");
            ofrmOrden.FormClosed += ofrmSolicitud_FormClosed;
            ofrmOrden.ShowDialog();
        }

        void ofrmSolicitud_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateGrid();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadSolicitud();
        }

        private void LoadSolicitud() {
            if (currentRow != null)
            {
                //String Accion = (Convert.ToInt32(currentRow["IDEstadoOrden"]) == 0) ? "Edit" : "View";
                String Accion = "View";
                frmOrdenCompra ofrmOrden = new frmOrdenCompra(Convert.ToInt32(currentRow["IDOrdenCompra"]), Accion);
                ofrmOrden.FormClosed += ofrmSolicitud_FormClosed;
                ofrmOrden.ShowDialog();
            }
        }


        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(currentRow["IDEstado"]) > 2)
                {
                    MessageBox.Show("Solo puede eliminar ordenes cuyo estdo sea el inicial");
                    return;
                }
                if (MessageBox.Show("Esta seguro que desea eliminar la Orden de Compra seleccionada ? " ,"Listado de Ordenes de Compra", MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes) {
                    if (currentRow != null)
                    {
                        String OrdenCompra = "";
                        int IDOrdenCompra = Convert.ToInt32(currentRow["IDOrdenCompra"]);
                        ConnectionManager.BeginTran();
                        
                        clsOrdenCompraDetalleDAC.InsertUpdate("D", IDOrdenCompra, -1, 0, 0, 0, 0, 0, 0,
                                                        0, 0, "", ConnectionManager.Tran);
                        clsOrdenCompraDAC.InsertUpdate("D", IDOrdenCompra, ref OrdenCompra, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, -1, -1, -1, -1, -1, 0, 0, 0, 0, -1, -1, 0, "", "", DateTime.Now, "", DateTime.Now, DateTime.Now, "", DateTime.Now, "", ConnectionManager.Tran);
                        
                        ConnectionManager.CommitTran();
                        MessageBox.Show("La orden de compra se ha eliminado correctamente");
                    }
                    PopulateGrid();
                }
            }
            catch (Exception ex) {
                ConnectionManager.RollBackTran();
                MessageBox.Show("Han ocurrido los siguientes errores: \n\r"+ ex.Message);
            }


        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            LoadSolicitud();
        }

        private void searchLookUpEdit1View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //Proveedor
            GridView view = sender as GridView;
            object Valor;
            Valor = view.GetRowCellValue(e.ControllerRow, "IDProveedor");
            if (e.Action == CollectionChangeAction.Add)
                valuesProveedor.Add(Valor);
            else if (e.Action == CollectionChangeAction.Remove)
                valuesProveedor.Remove(Valor);
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            GridView view = sender as GridView;
            object Valor;
            Valor = view.GetRowCellValue(e.ControllerRow, "IDEstadoOrden");
            if (e.Action == CollectionChangeAction.Add)
                valuesEstados.Add(Valor);
            else if (e.Action == CollectionChangeAction.Remove)
                valuesEstados.Remove(Valor);
        }
    
    }
}

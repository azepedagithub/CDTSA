using CG.DAC;
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

namespace CG.Consultas
{
    public partial class frmConsultasDetalleMayor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DateTime _FechaInicial;
        DateTime _FechaFinal;
        String _TipoAsiento;
        String _Asiento;
        int _Anulado;
        String _ModuloFuente;
        private String sCuentasSelected = "*";
        private String sCentrosSelected = "*";

        private DataSet _dsAsiento;
        private DataTable _dtAsiento;


        DataRow _currentRow = null;
        const String _tituloVentana = "Consulta de Asientos de Mayor";
        String sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";


        public frmConsultasDetalleMayor()
        {
            InitializeComponent();
            this.Load += frmConsultasAsientosMayor_Load;
        }

        void frmConsultasAsientosMayor_Load(object sender, EventArgs e)
        {
            try
            {
                //HabilitarControles(false);
                _FechaInicial = DateTime.Now.AddDays(-15);
                _FechaFinal = DateTime.Now;
                _TipoAsiento = "CG";
                _ModuloFuente = "CG";
                _Anulado = 0;
                this.gridView.FocusedRowChanged += GridView_FocusedRowChanged;
                this.gridView.DoubleClick += grid_DoubleClick;
                Util.Util.SetDefaultBehaviorControls(this.gridView, false, this.dtgDetalle, _tituloVentana, this);

                EnlazarEventos();
                PopulateGrid();
                CargarPrivilegios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = (int)this.gridView.FocusedRowHandle;
            if (index > -1)
            {
                _currentRow = gridView.GetDataRow(index);
                //UpdateControlsFromCurrentRow(_currentRow);
            }
            else _currentRow = null;
        }


        private void CargarPrivilegios()
        {
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
            DS = UsuarioDAC.GetAccionModuloFromRole(0, sUsuario);
            DT = DS.Tables[0];
            if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.AgregarAsientodeDiario, DT))
                this.btnExportar.Enabled = false;

        }


        private void btnFiltro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmParametrosFiltroAsiento ofrmFiltro = new frmParametrosFiltroAsiento(true, _FechaInicial, _FechaFinal, _ModuloFuente, _TipoAsiento, true, (_Anulado == 1) ? true : false, false);
            ofrmFiltro.FormClosed += OfrmFiltro_FormClosed;
            ofrmFiltro.ShowDialog();
        }

        private void OfrmFiltro_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmParametrosFiltroAsiento ofrmFiltro = (frmParametrosFiltroAsiento)sender;
            //Obtener las variables de filtro
            _FechaInicial = ofrmFiltro.FechaInicial;
            _FechaFinal = ofrmFiltro.FechaFinal;
            _Anulado = (Convert.ToInt32(ofrmFiltro.Anulado) == 0) ? -1 : Convert.ToInt32(ofrmFiltro.Anulado);
            _TipoAsiento = ofrmFiltro.TipoAsiento;
            _ModuloFuente = ofrmFiltro.ModuloFuente;
            ofrmFiltro.FormClosed -= OfrmFiltro_FormClosed;

            PopulateGrid();
        }

        private void EnlazarEventos()
        {
            this.btnCancelar.ItemClick += btnCancelar_ItemClick;
            this.btnExportar.ItemClick += BtnExportar_ItemClick;
            this.btnRefrescar.ItemClick += btnRefrescar_ItemClick;
        }

        void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PopulateGrid();
        }

        private void BtnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tempPath = System.IO.Path.GetTempPath();
            String FileName = System.IO.Path.Combine(tempPath, "consultaAsientosMayor.xlsx");
            DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions()
            {
                SheetName = "AsientosMayor"
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
            _dsAsiento = AsientoDAC.GetConsultaDetalleAsientoMayor(_Asiento, _TipoAsiento,sCuentasSelected,sCentrosSelected, _ModuloFuente, _FechaInicial, _FechaFinal, sUsuario);
            _dtAsiento = _dsAsiento.Tables[0];
            this.dtgDetalle.DataSource = null;
            this.dtgDetalle.DataSource = _dtAsiento;


        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            CargarAsiento();
        }


        private void CargarAsiento()
        {
            if (_currentRow != null)
            {
                frmAsiento ofrmAsiento = new frmAsiento(_currentRow["Asiento"].ToString());
                ofrmAsiento.ShowDialog();

            }
        }

       

      
      

        void ofrmCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPopPupCuentaContable Cuenta = (frmPopPupCuentaContable)sender;
            if (Cuenta.IsAllSelected)
            {
                sCuentasSelected = "*";
            }
            else
                sCuentasSelected = Cuenta.sCuentasSelected;
            //MessageBox.Show(sCuentasSelected);
        }



        void ofrmCentro_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPopPupCentroCosto Centro = (frmPopPupCentroCosto)sender;
            if (Centro.IsAllSelected)
                sCentrosSelected = "*";
            else
                sCentrosSelected = Centro.sCostosSelected;
            // MessageBox.Show(sCentrosSelected);
        }



        private void btnCuentasContables_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPopPupCuentaContable ofrmPopupCuenta = new frmPopPupCuentaContable();
            ofrmPopupCuenta.FormClosed += ofrmCuenta_FormClosed;
            ofrmPopupCuenta.sCuentasSelected = this.sCuentasSelected;
            ofrmPopupCuenta.Show();
        }

        private void btnCentrosCosto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPopPupCentroCosto ofrmCentro = new frmPopPupCentroCosto();
            ofrmCentro.FormClosed += ofrmCentro_FormClosed;
            ofrmCentro.sCostosSelected = this.sCentrosSelected;
            ofrmCentro.Show();
        }
    }
}

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

namespace CG
{
	public partial class frmListadoAsientoMayor : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		DateTime _FechaInicial;
        DateTime _FechaFinal;
        String _TipoAsiento;
        int _Mayorizado;
        int _Anulado;
        int _CuadreTemporal;
        string _sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
        String _ModuloFuente;

        private DataSet _dsAsiento;
        private DataTable _dtAsiento;


        DataRow _currentRow = null;
        const String _tituloVentana = "Listado de Asientos";
        String sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";

		public frmListadoAsientoMayor()
		{
			InitializeComponent();
		}

		private void frmlListadoCuentaContable_Load(object sender, EventArgs e)
		{
			 try
            {

                //HabilitarControles(false);
                _FechaInicial = DateTime.Now.AddDays(-15);
                _FechaFinal = DateTime.Now;

                _TipoAsiento = "CG";
                _ModuloFuente = "CG";
                _Mayorizado = 1;
                _Anulado = 0;
                _CuadreTemporal = 0;

                this.gridView.FocusedRowChanged += GridView_FocusedRowChanged;
                this.gridView.DoubleClick += GridView_DoubleClick;
                Util.Util.SetDefaultBehaviorControls(this.gridView, false, this.grid, _tituloVentana, this);

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
            DataTable DT = new DataTable();
            DS = UsuarioDAC.GetAccionModuloFromRole(0, _sUsuario);
            DT = DS.Tables[0];
          
            if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.EliminarAsientodeDiario, DT))
                this.btnEliminar.Enabled = false;

        }


    
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            if (_currentRow != null && this.gridView.SelectedRowsCount == 1)
            {
                frmAsiento ofrmAsiento = new frmAsiento(_currentRow["Asiento"].ToString());
                ofrmAsiento.ShowDialog();

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



        private void EnlazarEventos()
        {
            this.btnFiltro.ItemClick += BtnFiltro_ItemClick;
            this.btnExportar.ItemClick += BtnExportar_ItemClick;
            this.btnRefrescar.ItemClick += btnRefrescar_ItemClick;
        }

        void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PopulateGrid();
        }

        private void BtnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tempPath = System.IO.Path.GetTempPath();
            String FileName = System.IO.Path.Combine(tempPath, "lstAsientos.xlsx");
            DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions()
            {
                SheetName = "Listado Asientos"
            };


            this.gridView.ExportToXlsx(FileName, options);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = FileName;
            process.StartInfo.Verb = "Open";
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            process.Start();
        }

        private void BtnFiltro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmParametrosFiltroAsiento ofrmFiltro = new frmParametrosFiltroAsiento(false,_FechaInicial, _FechaFinal, _ModuloFuente, _TipoAsiento, (_Mayorizado == 1) ? true : false, (_Anulado == 1) ? true : false, (_CuadreTemporal == 1) ? true : false);
			ofrmFiltro.isFromMayor = true;
            ofrmFiltro.FormClosed += OfrmFiltro_FormClosed;
            ofrmFiltro.ShowDialog();
        }

        private void OfrmFiltro_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmParametrosFiltroAsiento ofrmFiltro = (frmParametrosFiltroAsiento)sender;
            //Obtener las variables de filtro
            _FechaInicial = ofrmFiltro.FechaInicial;
            _FechaFinal = ofrmFiltro.FechaFinal;
            _Mayorizado =( Convert.ToInt32(ofrmFiltro.Mayorizado)==0) ? -1:Convert.ToInt32(ofrmFiltro.Mayorizado);
            _Anulado = (Convert.ToInt32(ofrmFiltro.Anulado)==0 )? -1:Convert.ToInt32(ofrmFiltro.Anulado);
            _CuadreTemporal = Convert.ToInt32(ofrmFiltro.CuadreTemporal);
            _TipoAsiento = ofrmFiltro.TipoAsiento;
            _ModuloFuente = ofrmFiltro.ModuloFuente;
           

            PopulateGrid();
        }

      
        
       



        private void PopulateGrid()
        {
            _dsAsiento = AsientoDAC.GetDataByCriterio(_FechaInicial, _FechaFinal, _TipoAsiento, _Mayorizado, _Anulado, _ModuloFuente, _CuadreTemporal, _sUsuario);
            _dtAsiento = _dsAsiento.Tables[0];
            this.grid.DataSource = null;
            this.grid.DataSource = _dtAsiento;


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



    }
	
}

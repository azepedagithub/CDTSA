using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Security;
using Util;
using System.Collections;
using ControlBancario.DAC;
using DevExpress.XtraGrid.Views.Grid;
using System.Transactions;

namespace ControlBancario
{
    public partial class frmListadoDocumentosBancarios : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DateTime _FechaInicial;
        DateTime _FechaFinal;

        String NombreRuc="";
        String AliasRuc="";
        int IdTipo=-1;
        int IdSubTipo=-1;
        int IdRuc=-1;
        String PagaderoA="";
        int Anulado=-1;
        String Numero="";
        String ConceptoContable="";

        public frmListadoDocumentosBancarios()
        {
            InitializeComponent();
        }
        private DataSet _dsDocumentos;
        private DataTable _dtDocumentos;


        DataRow _currentRow = null;
        const String _tituloVentana = "Listado de Documentos Bancarios";
        String _sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";

        private void CargarPrivilegios()
        {
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
            DS = UsuarioDAC.GetAccionModuloFromRole(0, _sUsuario);
            DT = DS.Tables[0];
            if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.AgregarAsientodeDiario, DT))
                this.btnAgregar.Enabled = false;
            if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.EditarAsientodeDiario, DT))
                this.btnAnular.Enabled = false;
            if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.EliminarAsientodeDiario, DT))
                this.btnAnular.Enabled = false;

        }

        private void frmListadoDocumentosBancarios_Load(object sender, EventArgs e)
        {
            try
            {


                //HabilitarControles(false);
                _FechaInicial = DateTime.Now.AddDays(-15);
                _FechaFinal = DateTime.Now;

              
                this.gridView1.FocusedRowChanged += GridView_FocusedRowChanged;
                this.gridView1.DoubleClick += GridView_DoubleClick;
                Util.Util.SetDefaultBehaviorControls(this.gridView1, false, this.gridDocumentos, _tituloVentana, this);

                EnlazarEventos();
                PopulateGrid();
                CargarPrivilegios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarElementoSeleccionado() {
            frmDocumento ofrmDocumento = new frmDocumento(Convert.ToInt32(_currentRow["IDCuentaBanco"]),
                                                         Convert.ToInt32(_currentRow["IDTipo"]),
                                                         Convert.ToInt32(_currentRow["IDSubTipo"]),
                                                         Convert.ToInt32(_currentRow["IDRuc"]),
                                                         _currentRow["Numero"].ToString()
                                                         );
            ofrmDocumento.FormClosed += ofrmCheque_FormClosed;
            ofrmDocumento.ShowDialog();
        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            if (_currentRow != null && this.gridView1.SelectedRowsCount == 1)
            {
                MostrarElementoSeleccionado();
            }
        }

        void ofrmCheque_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateGrid();
        }




        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = (int)this.gridView1.FocusedRowHandle;
            if (index > -1)
            {
                _currentRow = gridView1.GetDataRow(index);
                
            }
            else _currentRow = null;
        }


        private void EnlazarEventos()
        {
            this.btnAgregar.ItemClick += BtnAgregar_ItemClick;
			this.btnAnular.ItemClick += btnAnular_ItemClick;
            this.btnExportar.ItemClick += BtnExportar_ItemClick;
            this.btnRefrescar.ItemClick += btnRefrescar_ItemClick;
        }


		private void btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			//Preguntar por restricciones de anulacion
			try
			{
				if (_currentRow["Asiento"].ToString() != "")
				{
					using (var scope = new TransactionScope())
					{
						MovimientosDAC.RevierteAsientoContable(_currentRow["Numero"].ToString(), Convert.ToInt32(_currentRow["IDCuentaBanco"]), Convert.ToInt32(_currentRow["IDTipo"]), Convert.ToInt32(_currentRow["IDSubTipo"]), _sUsuario);
						MessageBox.Show("El cheque y su transaccion contable se ha anulado");
						PopulateGrid();
						scope.Complete();

					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ha ocurrido un error tratando de anular el documento.");
				Security.ConnectionManager.RollBackTran();
			}

		}

        void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PopulateGrid();
        }

        private void BtnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tempPath = System.IO.Path.GetTempPath();
            String FileName = System.IO.Path.Combine(tempPath, "lstDocumentosBancarios.xlsx");
            DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions()
            {
                SheetName = "Listado Documentos Bancarios"
            };


            this.gridView1.ExportToXlsx(FileName, options);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = FileName;
            process.StartInfo.Verb = "Open";
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            process.Start();
        }

        private void BtnFiltro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmParametrosFiltroDocumentoBancario ofrmFiltro = new frmParametrosFiltroDocumentoBancario(_FechaInicial, _FechaFinal,Anulado,IdTipo,IdSubTipo,IdRuc,NombreRuc,AliasRuc,PagaderoA,Numero,ConceptoContable);
            ofrmFiltro.FormClosed += OfrmFiltro_FormClosed;
            ofrmFiltro.ShowDialog();
        }

        private void OfrmFiltro_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmParametrosFiltroDocumentoBancario ofrmFiltro = (frmParametrosFiltroDocumentoBancario)sender;
            //Obtener las variables de filtro
            _FechaInicial = ofrmFiltro.FechaInicial;
            _FechaFinal = ofrmFiltro.FechaFinal;
            Anulado = ofrmFiltro.Anulado;
            IdTipo = ofrmFiltro.IdTipo;
            IdSubTipo = ofrmFiltro.IdSubTipo;
            IdRuc = ofrmFiltro.IdRuc;
            NombreRuc = ofrmFiltro.NombreRuc;
            AliasRuc = ofrmFiltro.AliasRuc;
            PagaderoA = ofrmFiltro.PagaderaA;
            Numero = ofrmFiltro.Numero;
            ConceptoContable = ofrmFiltro.ConceptoContable;
            
            ofrmFiltro.FormClosed -= OfrmFiltro_FormClosed;

            PopulateGrid();
        }

        private void BtnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_currentRow != null)
            {
				if (MessageBox.Show("Esta seguro que desea eliminar el movimiento de Banco? ", "Movimientos de Bancos", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{

					_currentRow.Delete();

					try
					{

						MovimientosDAC.oAdaptador.Update(_dsDocumentos, "Data");
						_dsDocumentos.AcceptChanges();
						PopulateGrid();
						
						Application.DoEvents();
					}
					catch (System.Data.SqlClient.SqlException ex)
					{
						_dsDocumentos.RejectChanges();
						lblStatus.Caption = "";
						MessageBox.Show(ex.Message);
					}
				}
            }
        }


        private void BtnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_currentRow != null)
            {
                MostrarElementoSeleccionado();
            }
        }

 

        private void BtnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDocumento ofrmCheque  = new frmDocumento();
            ofrmCheque.FormClosed+=ofrmCheque_FormClosed;

            if (!ofrmCheque.IsDisposed)
                ofrmCheque.ShowDialog();

        }




        private void PopulateGrid()
        {
            _dsDocumentos = DAC.MovimientosDAC.GetDatosByCriterio(_FechaInicial, _FechaFinal, IdRuc, NombreRuc, AliasRuc, IdTipo, IdSubTipo, PagaderoA, Anulado, Numero, ConceptoContable);

            _dtDocumentos = _dsDocumentos.Tables[0];
            this.gridDocumentos.DataSource = null;
            this.gridDocumentos.DataSource = _dtDocumentos;


        }

      

		private void btnAprobar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (_currentRow == null)
				return;
			if (_currentRow["Asiento"].ToString() == "" || _currentRow["Asiento"] == null)
			{
				try
				{
					//Security.ConnectionManager.BeginTran();
					String Asiento = MovimientosDAC.GenerarAsientoContable(_currentRow["Numero"].ToString(), Convert.ToInt32(_currentRow["IDCuentaBanco"]), Convert.ToInt32(_currentRow["IDTipo"]), Convert.ToInt32(_currentRow["IDSubTipo"]), _sUsuario);
					if (Asiento == "")
					{
						MessageBox.Show("Ha ocurrido un error tratando de generar el asiento contable del cheque");
						return;
					}
					CG.frmAsiento ofrmAsiento = new CG.frmAsiento(Asiento, "PndtGuardar", true);
					ofrmAsiento.FormClosed += ofrmAsiento_FormClosed;
					ofrmAsiento.ShowDialog();
					//Security.ConnectionManager.CommitTran();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Han ocurrido los siguientes errores, tratando de generar el asiento contable \n\r\n\r\n\r\n\r\n\r\n\r\n\r" + ex.Message);
					// Security.ConnectionManager.RollBackTran();
				}
			}
			else if (_currentRow["Asiento"].ToString() != "") {
				MessageBox.Show("El documento ya ha sido aprobado!", "Documentos Bancarios");
			}
		}

		void ofrmAsiento_FormClosed(object sender, FormClosedEventArgs e)
		{
			PopulateGrid();
		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView view = sender as GridView;
			if (e.RowHandle > -1)
			{

				int _estado = (int)view.GetRowCellValue(e.RowHandle, "IDEstado");
				Color color = _estado==0 ?  Color.FromArgb(254, 224, 224) : Color.Transparent;
				e.Appearance.BackColor = color;
				view.Appearance.SelectedRow.BackColor = color;

				//if (view.FocusedRowHandle == e.RowHandle)
				view.Appearance.FocusedRow.BackColor = color;
				view.Appearance.SelectedRow.BackColor = color;
				view.Appearance.HideSelectionRow.BackColor = color;
				view.Appearance.FocusedCell.BackColor = color;

			}
		}

		
        
     
    }
}

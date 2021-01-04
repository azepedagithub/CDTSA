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

namespace ControlBancario
{
	public partial class frmListadoConciliacionesBancarias : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		private DataTable _dtConciliacion;

		private DataSet _dsConciliacion;
		private DataTable _dtSecurity;

		DataRow currentRow;
		string _sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
		const String _tituloVentana = "Listado de Conciliaciones";
		private bool isEdition = false;

		public frmListadoConciliacionesBancarias()
		{
			InitializeComponent();
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void CargarPrivilegios()
		{
			DataSet DS = new DataSet();
			DS = UsuarioDAC.GetAccionModuloFromRole(200, _sUsuario);
			_dtSecurity = DS.Tables[0];

			AplicarPrivilegios();
		}

		private void AplicarPrivilegios()
		{
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosControlBancarioType.AgregarConciliación, _dtSecurity))
				this.btnAgregar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosControlBancarioType.EditarConciliación, _dtSecurity))
				this.btnEditar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosControlBancarioType.EliminarConciliación, _dtSecurity))
				this.btnEliminar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosControlBancarioType.ExportarConciliación, _dtSecurity))
				this.btnExportar.Enabled = false;
		}

		private void EnlazarEventos()
		{
			this.btnAgregar.ItemClick += btnAgregar_ItemClick;
			this.btnEditar.ItemClick += btnEditar_ItemClick;
			this.btnEliminar.ItemClick += btnEliminar_ItemClick;
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
			String FileName = System.IO.Path.Combine(tempPath, "lstConciliacion.xlsx");
			DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions()
			{
				SheetName = "Listado de Conciliaciones"
			};


			this.gridView1.ExportToXlsx(FileName, options);
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo.FileName = FileName;
			process.StartInfo.Verb = "Open";
			process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
			process.Start();
		}

		private void frmListadoConciliacionesBancarias_Load(object sender, EventArgs e)
		{
			try
			{

				Util.Util.SetDefaultBehaviorControls(this.gridView1, false, this.dtgConciliaciones, _tituloVentana, this);

				this.dtpFechaInicial.EditValue = DateTime.Now.AddMonths(-1);
				this.dtpFechaFinal.EditValue = DateTime.Now;
				EnlazarEventos();

				PopulateGrid();

				CargarPrivilegios();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void PopulateGrid()
		{
			_dsConciliacion = DAC.ConciliacionDAC.GetConciliacionByQuery(-1, Convert.ToDateTime(this.dtpFechaInicial.EditValue), Convert.ToDateTime(this.dtpFechaFinal.EditValue));

			_dtConciliacion = _dsConciliacion.Tables[0];
			this.dtgConciliaciones.DataSource = null;
			this.dtgConciliaciones.DataSource = _dtConciliacion;



		}


	

		private void SetCurrentRow()
		{
			int index = (int)this.gridView1.FocusedRowHandle;
			if (index > -1)
			{
				currentRow = gridView1.GetDataRow(index);
			}
		}

		
		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			SetCurrentRow();
		}


		private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmConciliacionBancaria ofrmConciliacion = new frmConciliacionBancaria("New");
			ofrmConciliacion.FormClosed += ofrmConciliacion_FormClosed;
			ofrmConciliacion.ShowDialog();

		}

		void ofrmConciliacion_FormClosed(object sender, FormClosedEventArgs e)
		{
			PopulateGrid();
		}

		private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (currentRow != null)
			{
				
				frmConciliacionBancaria ofrmConciliacion =  new frmConciliacionBancaria("Edit", Convert.ToInt32(currentRow["IDConciliacion"]) );
				ofrmConciliacion.FormClosed += ofrmConciliacion_FormClosed;
				ofrmConciliacion.ShowDialog();

			}
			
		}

		
		private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (currentRow != null)
			{
				
				if (MessageBox.Show("Esta seguro que desea eliminar el elemento: " + currentRow["IDConciliacion"].ToString(), _tituloVentana, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					currentRow.Delete();

					try
					{

						DAC.ConciliacionDAC.oAdaptador.Update(this._dsConciliacion, "Data");
						_dsConciliacion.AcceptChanges();

						PopulateGrid();
						Application.DoEvents();
					}
					catch (System.Data.SqlClient.SqlException ex)
					{
						_dsConciliacion.RejectChanges();
						lblStatus.Caption = "";
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			if (currentRow != null)
			{

				frmConciliacionBancaria ofrmConciliacion = new frmConciliacionBancaria("Edit", Convert.ToInt32(currentRow["IDConciliacion"]));
				ofrmConciliacion.FormClosed += ofrmConciliacion_FormClosed;
				ofrmConciliacion.ShowDialog();

			}
		}

    
   
      
       

	}
}

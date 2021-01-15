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
	public partial class frmRetencionProveedor : Form
	{
		int IDProveedor;
		DataRow currentRow;

		public frmRetencionProveedor(int IDProveedor)
		{
			InitializeComponent();
			this.IDProveedor = IDProveedor;
		}

		private void CargarDatos() {
			DataTable dtRetencionProveedor = new DataTable();
			dtRetencionProveedor = DAC.clsProveedorRetencionDAC.Get(IDProveedor, -1).Tables[0];
			this.dtgRetenciones.DataSource = dtRetencionProveedor;
		}

		private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmAsociarRetencionProveedor ofrmAsociar = new frmAsociarRetencionProveedor(this.IDProveedor);
			ofrmAsociar.FormClosed += ofrmAsociar_FormClosed;
			ofrmAsociar.ShowDialog();
		}

		private void SetCurrentRow()
		{
			int index = (int)this.gridViewRetencion.FocusedRowHandle;
			if (index > -1)
			{
				currentRow = gridViewRetencion.GetDataRow(index);
				
			}
		}

		void ofrmAsociar_FormClosed(object sender, FormClosedEventArgs e)
		{
			CargarDatos();
		}

		private void frmRetencionProveedor_Load(object sender, EventArgs e)
		{
			CargarDatos();
		}

		private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (this.currentRow != null)
				{
					if (MessageBox.Show("Esta seguro de eliminar el elemento seleccionado ? ", "Retención de Proveedores", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
					{
						Security.ConnectionManager.BeginTran();
						DAC.clsProveedorRetencionDAC.InsertUpdate("D", IDProveedor, Convert.ToInt32(currentRow["IDRetencion"]), Security.ConnectionManager.Tran);
						Security.ConnectionManager.CommitTran();
						CargarDatos();
					}

				}
			}
			catch (Exception ex) {
				if (Security.ConnectionManager.Tran != null) {
					Security.ConnectionManager.RollBackTran();
					MessageBox.Show("Han ocurrido los siguientes errores : \n\r" + ex.Message);
				}
			}
		}

		private void gridViewRetencion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			SetCurrentRow();
		}
	}
}

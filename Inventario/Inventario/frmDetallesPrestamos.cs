using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CI
{
	public partial class frmDetallesPrestamos : Form
	{
		long IDTransaccion;
		public frmDetallesPrestamos(long pIDTransaccion)
		{
			InitializeComponent();
			this.IDTransaccion = pIDTransaccion;
		}

		private void frmDetallesPrestamos_Load(object sender, EventArgs e)
		{
			this.dtgDetallePrestamos.DataSource =  DAC.clsTransaccionPrestamoDAC.GetDetallePrestamos(this.IDTransaccion,null);
			this.colLinkDocumento.Click += colLinkDocumento_Click;
			this.colLinkAsiento.Click += colLinkAsiento_Click;
		}

		void colLinkAsiento_Click(object sender, EventArgs e)
		{
			if (this.gridView1.FocusedRowHandle != -1)
			{
				DataRow dr = this.gridView1.GetDataRow(this.gridView1.FocusedRowHandle);
				CG.frmAsiento ofrmAsiento = new CG.frmAsiento(dr["Asiento"].ToString());
				ofrmAsiento.ShowDialog();
			}
		}

		void colLinkDocumento_Click(object sender, EventArgs e)
		{

			if (this.gridView1.FocusedRowHandle != -1)
			{
				DataRow dr = this.gridView1.GetDataRow(this.gridView1.FocusedRowHandle);
				frmDocumentoInv ofrmDoc = new frmDocumentoInv(Convert.ToInt32(dr["IDTransaccion"]), "View");
				ofrmDoc.ShowDialog();
			}
			
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void gridView1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hola");
		}

	

		


	}
}

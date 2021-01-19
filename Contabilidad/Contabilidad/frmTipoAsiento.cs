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
	public partial class frmTipoAsiento : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		DataTable dsTiposAsiento = new DataTable();
		DataRow currentRow ;

		public frmTipoAsiento()
		{
			InitializeComponent();
		}

		private void frmTipoAsiento_Load(object sender, EventArgs e)
		{
			dsTiposAsiento = TipoAsientoDAC.GetData().Tables[0];
			this.dtgListado.DataSource = dsTiposAsiento;
		}

		private void SetCurrentRow()
		{
			int index = (int)this.gridView1.FocusedRowHandle;
			if (index > -1)
			{
				currentRow = gridView1.GetDataRow(index);
			}
		}

		private void btnAsociarUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (this.gridView1.GetSelectedRows().Count() > 0) {
				MessageBox.Show(this.gridView1.GetSelectedRows()[0].ToString());
			}
		}
	}
}

using CO.DAC;
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
	public partial class frmPedidoSugerido : Form
	{
		DataTable dtPedidoSugerido = new DataTable();
		int IDProveedor;

		public DataTable GetDTPedidoSugerido() {
			return dtPedidoSugerido;
		}

		public frmPedidoSugerido(int IDProveedor)
		{
			InitializeComponent();
			this.IDProveedor = IDProveedor;
		}

		private void frmPedidoSugerido_Load(object sender, EventArgs e)
		{
			//Valoeres por defecto
			this.dtpFecha.EditValue = DateTime.Now;
			this.txtUmbralExistencia.EditValue = 1;
		}

		private void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			DateTime dtFecha = Convert.ToDateTime(this.dtpFecha.EditValue);
			int CantUmbral = Convert.ToInt32(this.txtUmbralExistencia.EditValue);

			DataTable dtPedidoSugerido = clsOrdenCompraDetalleDAC.ObtenerPedidoSugerido(IDProveedor, dtFecha, CantUmbral).Tables[0];

			this.dtgPedidoSugerido.DataSource = dtgPedidoSugerido;

			
		}

		private void btnImportarPedido_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}
	}
}

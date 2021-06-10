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

			dtPedidoSugerido = clsOrdenCompraDetalleDAC.ObtenerPedidoSugerido(IDProveedor, dtFecha, CantUmbral).Tables[0];

			this.dtgPedidoSugerido.DataSource = dtPedidoSugerido;

			
		}

		private void btnImportarPedido_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		private void btnQuitarMensaje_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			DataRow[] rows;
			rows = dtPedidoSugerido.Select("Mensaje <>''");  //'UserName' is ColumnName
			foreach (DataRow row in rows)
				dtPedidoSugerido.Rows.Remove(row);
		}

		private void btnEliminarLinea_Click(object sender, EventArgs e)
		{
			if (this.gridViewPedido.GetSelectedRows().Count() > 0) {
				DataRow fila = ((DataRowView) this.gridViewPedido.GetRow(this.gridViewPedido.GetSelectedRows()[0])).Row;
				dtPedidoSugerido.Rows.Remove(fila);
			}
		}
	}
}

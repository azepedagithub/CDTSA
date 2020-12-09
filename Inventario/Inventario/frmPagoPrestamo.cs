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
using CI.DAC;

namespace CI
{
	public partial class frmPagoPrestamo : Form
	{
		private DataSet _dsDocumento;
		private DataSet _dsDetalle;
		String sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
		int IDTransaccion;

		public frmPagoPrestamo(int IdTransaccion)
		{
			InitializeComponent();
			this.IDTransaccion = IdTransaccion;
		}

		private void frmPagoPrestamo_Load(object sender, EventArgs e)
		{
			_dsDetalle = clsTransaccionPrestamoDAC.GetPrestamosByTransaccion(this.IDTransaccion);
			this.dtgDetallePrestamos.DataSource = _dsDetalle.Tables["Prestamos"];
			_dsDocumento = clsDocumentoInvCabecera.GetData(this.IDTransaccion);
			EnlazarControles(_dsDocumento.Tables[0].Rows[0]);

		}

		private void EnlazarControles(DataRow Fila) {
			this.txtAsiento.Text = Fila["Asiento"].ToString();
			this.txtDocumento.Text = Fila["Documento"].ToString();
			this.txtReferencia.Text = Fila["Referencia"].ToString();
			this.dtpFecha.EditValue = Convert.ToDateTime(Fila["Fecha"]);
		}
	}
}

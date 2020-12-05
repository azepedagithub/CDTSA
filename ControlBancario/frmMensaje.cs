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
	public partial class frmMensaje : Form
	{
		int IDMovimiento = -1;
		public frmMensaje(int IDMovimiento)
		{
			InitializeComponent();
			this.IDMovimiento = IDMovimiento;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmMensaje_Load(object sender, EventArgs e)
		{

			try
			{
				String sMensaje = DAC.MovimientosDAC.GetNotaFromMovimiento(this.IDMovimiento);
				this.txtMensaje.Text = sMensaje;
			}
			catch (Exception ex) {
				MessageBox.Show(" Han ocurrido los siguientes errores , " + ex.Message);
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				DAC.MovimientosDAC.SetNotaMovimiento(this.IDMovimiento, this.txtMensaje.Text.Trim());
				this.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(" Han ocurrido los siguientes errores , " +  ex.Message);
			}
		}
	}
}

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
	public partial class frmTipoAsientoUsuarios : Form
	{
		DataTable dtTipoAsientoUsuario;
		String TipoAsiento;

		public frmTipoAsientoUsuarios(String pTipoAsiento)
		{
			InitializeComponent();
			this.TipoAsiento = pTipoAsiento;
		}

		private void CargarUsuarios() {
			dtTipoAsientoUsuario = TipoAsientoDAC.GetTipoAsientoByUsuario(TipoAsiento).Tables[0];
			this.dtgTipoAsientoUsuario.DataSource = dtTipoAsientoUsuario;
		}

		private void frmTipoAsientoUsuarios_Load(object sender, EventArgs e)
		{
			try
			{
				CargarUsuarios();
			}
			catch (Exception ex) {
				MessageBox.Show("Han Ocurrido los siguinetes errores \n\r" + ex.Message); 
			}
		}

		private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmAsociarUsuarioToTipoAsiento ofrmAsociar = new frmAsociarUsuarioToTipoAsiento();
			ofrmAsociar.FormClosed += ofrmAsociar_FormClosed;
			ofrmAsociar.ShowDialog();
		}

		void ofrmAsociar_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmAsociarUsuarioToTipoAsiento ofrm = (frmAsociarUsuarioToTipoAsiento)sender;
			if (ofrm.DialogResult == System.Windows.Forms.DialogResult.OK) {
				CargarUsuarios();
			}
		}

		private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
		 //  if (this.dtgTipoAsientoUsuari
		}
	}
}

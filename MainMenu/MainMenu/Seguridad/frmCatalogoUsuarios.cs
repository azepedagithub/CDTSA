using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad
{
	public partial class frmCatalogoUsuarios : Form
	{
		DataTable dtUsuario = new DataTable();
		int IDRole = -1;
		public DataRow drElemento { get; set; }

		public frmCatalogoUsuarios(int IDRole)
		{
			InitializeComponent();
			this.IDRole = IDRole;
		}

		private void CargarDatos() {
			this.dtUsuario = Security.RoleDAC.GetUsuarioNotInRole(IDRole,null).Tables[0];
			this.dtgUsuarios.DataSource = this.dtUsuario;
		}

		private void frmCatalogoUsuarios_Load(object sender, EventArgs e)
		{
			CargarDatos();
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (this.gridView1.GetSelectedRows().Count() == 0)
			{
				MessageBox.Show("Debe seleccionar un elemento");
				return;
			}
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			drElemento =this.gridView1.GetDataRow((int)this.gridView1.GetSelectedRows()[0]);
			this.Close();
		}
	}
}

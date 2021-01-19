using Security;
using System;
using System.Collections;
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
	public partial class frmAsociarUsuarioToTipoAsiento : Form
	{
		DataTable dtUsuario;
		String TipoAsiento;

		public frmAsociarUsuarioToTipoAsiento()
		{
			InitializeComponent();
		}

		private void frmAsociarUsuarioToTipoAsiento_Load(object sender, EventArgs e)
		{
			dtUsuario = TipoAsientoDAC.GetUsuariosNotAsociadosTipoAsiento(TipoAsiento).Tables[0];
			this.gridControl.DataSource = dtUsuario;

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{   //Recorrer los elemento y agregarlos
			ArrayList rows = new ArrayList();
			for (int i = 0; i < this.gridView1.SelectedRowsCount; i++)
			{
				if (gridView1.GetSelectedRows()[i] >= 0)
					rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
			}


			for (int i = 0; i < rows.Count; i++)
			{
				DataRow row = rows[i] as DataRow;
				// Change the field value.
				try
				{
					ConnectionManager.BeginTran();
					TipoAsientoDAC.AsociarUsuario(this.TipoAsiento, row["Usuario"].ToString(), ConnectionManager.Tran);
					ConnectionManager.CommitTran();

				}
				catch (System.Data.SqlClient.SqlException ex)
				{
					ConnectionManager.RollBackTran();
					MessageBox.Show(ex.Message);
				}

				this.DialogResult =  System.Windows.Forms.DialogResult.OK;
				//PopulateGrid();
				this.Close();
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}
	}
}

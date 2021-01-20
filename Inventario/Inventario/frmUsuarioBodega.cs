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

namespace CI
{
	public partial class frmUsuarioBodega : Form
	{
		private int IDBodega;
		private String DescrBodega;

		private DataTable dtUsuarios;
		private DataTable dtUsuariosSeleccionados;

		public frmUsuarioBodega(int IDBodega, String DescrBodega)
		{
			InitializeComponent();
			this.IDBodega = IDBodega;
			this.DescrBodega = DescrBodega;
		}

		private void frmUsuarioBodega_Load(object sender, EventArgs e)
		{

			this.txtCodBodega.EditValue = IDBodega.ToString();
			this.txtDescrBodega.EditValue = DescrBodega;
			CargarGrillas();
		}


		private void CargarGrillas()
		{
			try
			{
				this.dtUsuarios = Security.RoleDAC.GetUsuario("*", null).Tables[0];
				this.dtUsuariosSeleccionados = DAC.clsBodegaDAC.GetUsuarioByBodega(IDBodega).Tables[0];

				DataTable lst = dtUsuarios.Clone();
				foreach (DataRow dr in dtUsuarios.Rows)
				{
					String sUsuario = dr["Usuario"].ToString();
					//DataTable dtTemp = dtUsuariosSeleccionados.Clone();
					var query =   dtUsuariosSeleccionados.Select("Usuario ='" + sUsuario + "'");
					DataRow rowSelected = query.Count()> 0 ? query.First() : null;
					if (rowSelected == null)
					{
						lst.ImportRow(dr);
					}
				}


				this.dtgUsuarios.DataSource = lst;
				this.dtgUsuariosSeleccionados.DataSource = this.dtUsuariosSeleccionados;

			}
			catch (Exception ex)
			{

				MessageBox.Show("Han ocurrido los siguientes errores: \n\r" + ex.Message);
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
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
					DAC.clsBodegaDAC.InsertUpdateUsuarioBodega("I",IDBodega,row["USUARIO"].ToString(),ConnectionManager.Tran);
					ConnectionManager.CommitTran();
					//DataRow  dr =  this.dtUsuariosSeleccionados.NewRow();
					//dr["Usuario"] = row["USUARIO"];
					//dr["Descr"] = row["DESCR"];
					//dr["IDBodega"] = IDBodega;
					//this.dtUsuariosSeleccionados.Rows.Add(dr);
					
				}
				catch (System.Data.SqlClient.SqlException ex)
				{
					ConnectionManager.RollBackTran();
					MessageBox.Show(ex.Message);
					return;
				}
			}

			CargarGrillas();
			//this.dtUsuariosSeleccionados.AcceptChanges();

			//int CantElementos =  dtUsuarios.Rows.Count;

			//for (int i = 0; i < CantElementos; i++)
			//{
			//	DataRow row = dtUsuarios.Rows[i] as DataRow;
			//	var query = dtUsuariosSeleccionados.Select("Usuario ='" + row["Usuario"].ToString() + "'");
			//	DataRow rowSelected = query.Count() > 0 ? query.First() : null;
			//	if (rowSelected == null)
			//	{
			//		row.Delete();
					
			//	}
			//}

			//dtUsuarios.AcceptChanges();

			//this.dtgUsuarios.DataSource = dtUsuarios;
			//this.dtgUsuariosSeleccionados.DataSource = dtUsuariosSeleccionados;
			
		}

		private void btnQuitar_Click(object sender, EventArgs e)
		{
			ArrayList rows = new ArrayList();
			for (int i = 0; i < this.gridView2.SelectedRowsCount; i++)
			{
				if (gridView2.GetSelectedRows()[i] >= 0)
					rows.Add(gridView2.GetDataRow(gridView2.GetSelectedRows()[i]));
			}


			for (int i = 0; i < rows.Count; i++)
			{
				DataRow row = rows[i] as DataRow;
				// Change the field value.
				try
				{
					ConnectionManager.BeginTran();
					DAC.clsBodegaDAC.InsertUpdateUsuarioBodega("D", IDBodega, row["USUARIO"].ToString(), ConnectionManager.Tran);
					ConnectionManager.CommitTran();
					//DataRow dr = this.dtUsuarios.NewRow();
					//dr["USUARIO"] = row["Usuario"];
					//dr["DESCR"] = row["Descr"];
					//this.dtUsuarios.Rows.Add(dr);
					//this.dtUsuarios.AcceptChanges();
				}
				catch (System.Data.SqlClient.SqlException ex)
				{
					ConnectionManager.RollBackTran();
					MessageBox.Show(ex.Message);
					return;
				}
			}

			CargarGrillas();

			//for (int i = 0; i < this.dtUsuariosSeleccionados.Rows.Count; i++)
			//{
			//	DataRow row = dtUsuariosSeleccionados.Rows[i] as DataRow;
			//	var query = this.dtUsuarios.Select("Usuario ='" + row["Usuario"].ToString() + "'");
			//	DataRow rowSelected = query.Count() > 0 ? query.First() : null;
			//	if (rowSelected == null)
			//	{
			//		row.Delete();
			//		dtUsuariosSeleccionados.AcceptChanges();
			//	}
			//}

			//this.dtgUsuarios.DataSource = dtUsuarios;
			//this.dtgUsuariosSeleccionados.DataSource = dtUsuariosSeleccionados;
		}
	}
}

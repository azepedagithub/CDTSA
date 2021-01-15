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
using System.Security;

namespace CO
{
	public partial class frmAsociarRetencionProveedor : Form
	{
		private DataTable dtRetencion;
		private DataSet dtProveedorRetencion;
		private int IDProveedor;

		public frmAsociarRetencionProveedor(int IDProveedor)
		{
			InitializeComponent();
			this.IDProveedor = IDProveedor; 
		}

		private void frmAsociarRetencionProveedor_Load(object sender, EventArgs e)
		{
				  try
			{

				

				Util.Util.SetDefaultBehaviorControls(this.gridView1, false, this.dtgRetenciones, "", this);

				PopulateGrid();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void PopulateGrid()
		{
			dtRetencion = DAC.clsProveedorRetencionDAC.GetRetencionesNoAsociadas(IDProveedor ).Tables[0];
			this.dtgRetenciones.DataSource = dtRetencion;


		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			//Recorrer los elemento y agregarlos
			ArrayList rows = new ArrayList();
			for (int i = 0; i < this.gridView1.SelectedRowsCount; i++)
			{
				if (gridView1.GetSelectedRows()[i] >= 0)
					rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
			}
			try
			{

				for (int i = 0; i < rows.Count; i++)
				{
					
					try
					{
						Security.ConnectionManager.BeginTran();
						DAC.clsProveedorRetencionDAC.InsertUpdate("I", IDProveedor, Convert.ToInt32(((DataRow)rows[i])["IDRetencion"]), Security.ConnectionManager.Tran);
						Security.ConnectionManager.CommitTran();
						Application.DoEvents();

					}
					catch (System.Data.SqlClient.SqlException ex)
					{
						Security.ConnectionManager.RollBackTran();
						MessageBox.Show("Han ocurrido los siguientes errores: \n\r" + ex.Message);
					}

					this.Close();
				}
			}
			finally
			{

			}
		}
	}
}

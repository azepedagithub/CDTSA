using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CG.DAC;
using Security;

namespace CG
{
	public partial class frmGenerarDocumentosCierrePeriodoFiscal : Form
	{
		int IDEjercicio = -1;
		string _sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";

		public frmGenerarDocumentosCierrePeriodoFiscal()
		{
			InitializeComponent();
		}

		private void frmGenerarDocumentosCierrePeriodoFiscal_Load(object sender, EventArgs e)
		{
			if (EjercicioDAC.EsPeriodoTrece() == true)
			{
				this.btnGenerarDocumento.Enabled = true;
			}
			else
			{
				this.btnGenerarDocumento.Enabled = false;
			}

			DataSet ds = EjercicioDAC.GetEjercicioActivo();
			this.txtPeriodo.Text = ds.Tables[0].Rows[0]["Periodo"].ToString();
			this.IDEjercicio = Convert.ToInt32(ds.Tables[0].Rows[0]["IDEjercicio"]);

		}

		private void labelControl2_Click(object sender, EventArgs e)
		{
			try
			{
				EjercicioDAC.ProcesoGeneracionCierreFiscal(this.IDEjercicio, _sUsuario);
				MessageBox.Show("El proceso ha conclido correctamente, puede verificar el asiento generado en el diario", "Generación de Documento");
			}
			catch (Exception ex) {
				MessageBox.Show("Han ocurrido los siguientes errores : \n\r " + ex.Message);
			}
		}
	}
}

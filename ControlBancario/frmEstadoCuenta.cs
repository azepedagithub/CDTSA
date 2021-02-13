using ControlBancario.DAC;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlBancario
{
	public partial class frmEstadoCuenta : Form
	{
		DateTime FechaInicial, FechaFinal;
		int IDCuentaBancaria;

		public frmEstadoCuenta()
		{
			InitializeComponent();
		}

		private void btnGenerarReporte_Click(object sender, EventArgs e)
		{
			ShowReporte();
		}

		private bool ValidarDatos()
		{
			String sMensaje = "";
			bool bResult = true;	
			if (this.slkupCuentaBancaria.EditValue == null || this.slkupCuentaBancaria.EditValue.ToString() == "")
				sMensaje = sMensaje + "	• Cuenta Bancaria \n\r";
			if (this.dtpFechaInicial.EditValue == null || this.dtpFechaInicial.EditValue.ToString() == "")
				sMensaje = sMensaje + " • Fecha Inicial \n\r";
			if (this.dtpFechaFinal.EditValue == null || this.dtpFechaFinal.EditValue.ToString() == "")
				sMensaje = sMensaje + " • Fecha Final \n\r";
			if (sMensaje != "")
			{
				MessageBox.Show("Han ocurrido los siguientes errores> \n\r" + sMensaje);
				bResult = false;
			} 
			return bResult;
		}

		private void ObtenerDatos()
		{
			IDCuentaBancaria = Convert.ToInt32(this.slkupCuentaBancaria.EditValue);
			FechaInicial = Convert.ToDateTime(this.dtpFechaInicial.EditValue);
			FechaFinal = Convert.ToDateTime(this.dtpFechaFinal.EditValue);
		}

		private void ShowReporte()
		{

			if (ValidarDatos())
			{
				ObtenerDatos();
				DevExpress.XtraReports.UI.XtraReport report = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reportes/rptMovimientoCuentaBanco.repx", true);


				SqlDataSource sqlDataSource = report.DataSource as SqlDataSource;

				SqlDataSource ds = report.DataSource as SqlDataSource;
				ds.ConnectionName = "sqlDataSource1";
				String sNameConexion = (Security.Esquema.Compania == "CEDETSA") ? "StringConCedetsa" : "StringConDasa";
				System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder(System.Configuration.ConfigurationManager.ConnectionStrings[sNameConexion].ConnectionString);
				ds.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(builder.DataSource, builder.InitialCatalog, builder.UserID, builder.Password, MsSqlAuthorizationType.SqlServer);

				// Obtain a parameter, and set its value.
				report.Parameters["FechaInicial"].Value = FechaInicial;
				report.Parameters["FechaFinal"].Value = FechaFinal;
				report.Parameters["IDCuentaBanco"].Value = IDCuentaBancaria;

				// Show the report's print preview.
				DevExpress.XtraReports.UI.ReportPrintTool tool = new DevExpress.XtraReports.UI.ReportPrintTool(report);

				tool.ShowPreview();
			}

		}

		private void frmEstadoCuenta_Load(object sender, EventArgs e)
		{
			Util.Util.ConfigLookupEdit(this.slkupCuentaBancaria, CuentaBancariaDAC.GetData(-1, -1).Tables["Data"], "Descr", "IDCuentaBanco");
			Util.Util.ConfigLookupEditSetViewColumns(this.slkupCuentaBancaria, "[{'ColumnCaption':'Codigo','ColumnField':'Codigo','width':30},{'ColumnCaption':'Descripcion','ColumnField':'Descr','width':70}]");

		}
	}
}

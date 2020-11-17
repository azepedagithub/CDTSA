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
	public partial class frmConciliacionBancaria : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		List<clsEstadoConciliacion> lstEstados = new List<clsEstadoConciliacion>();
		DataTable dtCuentaBancaria = new DataTable();

		private void CargarEstados() {
			lstEstados.Clear();
			lstEstados.Add(new clsEstadoConciliacion() { CodEstado = 1, Descr = "Des-asociados" });
			lstEstados.Add(new clsEstadoConciliacion() { CodEstado = 2, Descr = "Asociados" });
			lstEstados.Add(new clsEstadoConciliacion() { CodEstado = -1, Descr = "Todos" });
			
			Util.Util.ConfigLookupEdit(this.slkupTypeView, lstEstados, "Descr", "CodEstado");
			Util.Util.ConfigLookupEditSetViewColumns(this.slkupTypeView, "[{'ColumnCaption':'Descr','ColumnField':'Descr','width':100}]");
		}
		public frmConciliacionBancaria()
		{
			InitializeComponent();
			this.Load += frmConciliacionBancaria_Load;
		}

		void frmConciliacionBancaria_Load(object sender, EventArgs e)
		{
			CargarEstados();

			Util.Util.ConfigLookupEdit(this.slkupCuentaBancaria, DAC.CuentaBancariaDAC.GetData(-1,-1).Tables["Data"], "Descr", "Codigo");
			Util.Util.ConfigLookupEditSetViewColumns(this.slkupCuentaBancaria, "[{'ColumnCaption':'Codigo','ColumnField':'Codigo','width':30},{'ColumnCaption':'Descr','ColumnField':'Descr','width':70}]");

			
		}

		private void slkupCuentaBancaria_EditValueChanged(object sender, EventArgs e)
		{
			DataRowView drCuenta = (DataRowView)this.slkupCuentaBancaria.GetSelectedDataRow();
			if (drCuenta != null) {
				this.txtCuentaContable.Text = drCuenta["IDCuenta"].ToString() + " - " + drCuenta["DescrCuentaContable"].ToString();
				this.txtBanco.Text = drCuenta["IDBanco"].ToString() + " - " + drCuenta["DescrBanco"].ToString();
				this.txtMoneda.Text = drCuenta["IDMoneda"].ToString() + " - " + drCuenta["DescrMoneda"].ToString();
			}

		}
	}

	public class clsEstadoConciliacion
	{
		public int CodEstado { get; set; }
		public String Descr { get; set; }
	}
}

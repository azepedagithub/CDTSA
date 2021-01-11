using CG.DAC;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG.Consultas
{
	public partial class frmConsultaCuentaCentroHijas : Form
	{
		private DataRow drCentroCosto;
		private DataRow drCuenta;
		DateTime FechaInicial, FechaFinal;
		Decimal TC = 0;
		String sTipoMoneda = "L";
		DataTable dtDetallado = new DataTable();
		DataTable dtTotalizado = new DataTable();
		int TipoView = -1;	

		public frmConsultaCuentaCentroHijas(DataRow drCentro, DataRow drCuenta,  DateTime FechaInicial, DateTime FechaFinal, Decimal pTC, int TipoView)
		{
			InitializeComponent();
			this.FechaInicial = FechaInicial;
			this.FechaFinal = FechaFinal;
			this.TC = pTC;
			this.drCentroCosto = drCentro;
			this.drCuenta = drCuenta;
			this.TipoView = TipoView;
		}

		private void ShowData()
		{
			try
			{
				if (this.drCentroCosto != null)
				{
					this.txtCentroCosto.Text = drCentroCosto["Centro"].ToString();
					this.txtDescrCentro.Text = drCentroCosto["Descr"].ToString();
				}
				else
				{
					this.txtCentroCosto.Text = "";
					this.txtDescrCentro.Text = "";
				}
				if (this.drCuenta != null)
				{
					this.txtCuentaContable.Text = drCuenta["Cuenta"].ToString();
					this.txtDescrCuenta.Text = drCuenta["Descr"].ToString();
				}
				else
				{
					this.txtCuentaContable.Text = "";
					this.txtDescrCuenta.Text = "";
				}

				Util.Util.SetFormatTextEdit(this.txtSaldoInicial, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");
				Util.Util.SetFormatTextEdit(this.txtCreditos, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");
				Util.Util.SetFormatTextEdit(this.txtDebitos, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");
				Util.Util.SetFormatTextEdit(this.txtSaldoFinal, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");

				
				Util.Util.SetFormatTextEditGrid(this.txtGridCredito, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");
				Util.Util.SetFormatTextEditGrid(this.txtGridDebito, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");
				Util.Util.SetFormatTextEditGrid(this.txtGridSaldo, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");
				//Util.Util.SetFormatTextEdit(this.txtTotalCredito, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");
				this.gridView1.Columns[2].FieldName = (sTipoMoneda == "L") ? "DebitoLocal" : "DebitoDolar";
				this.gridView1.Columns[3].FieldName = (sTipoMoneda == "L") ? "CreditoLocal" : "CreditoDolar";
				this.gridView1.Columns[4].FieldName = (sTipoMoneda == "L") ? "SaldoLocal" : "SaldoDolar";
				if (TipoView == 1)
				{
					this.gridView1.Columns[0].FieldName = "Cuenta";
					this.gridView1.Columns[1].FieldName = "Descr";
					
				}
				else
				{
					this.gridView1.Columns[0].FieldName = "Centro";
					this.gridView1.Columns[1].FieldName = "Descr";
				}
				this.txtTipoCambio.Text = "$" + this.TC.ToString("N2");

				this.txtFechaInicial.Text = this.FechaInicial.ToShortDateString();
				this.txtFinal.Text = this.FechaFinal.ToShortDateString();


				int idCentro = Convert.ToInt32(drCentroCosto == null ? "-1" : drCentroCosto["IDCentro"]);
				int idCuenta = Convert.ToInt32(drCuenta == null ? "-1" : drCuenta["IDcuenta"]);
				if (TipoView == 1) { 
					idCentro = -1;
				}

				DataSet DS = new DataSet();


				DS = ConsultasDAC.GetSaldoCuentasHijas(idCuenta, idCentro, FechaInicial, FechaFinal, TipoView);
				dtTotalizado = DS.Tables[0];

				DataRow drFila = dtTotalizado.Rows[0];
				this.txtSaldoInicial.Text = drFila[(sTipoMoneda == "L") ? "SaldoAnteriorLocal" : "SaldoAnteriorDolar"].ToString();
				this.txtCreditos.Text = drFila[(sTipoMoneda == "L") ? "CreditoLocal" : "CreditoDolar"].ToString();
				this.txtDebitos.Text = drFila[(sTipoMoneda == "L") ? "DebitoLocal" : "DebitoDolar"].ToString();
				this.txtSaldoFinal.Text = drFila[(sTipoMoneda == "L") ? "SaldoLocal" : "SaldoDolar"].ToString();


				dtDetallado = DS.Tables[1];

				this.dtgDetalle.DataSource = dtDetallado;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}



		private void frmConsultaCuentaCentroHijas_Load(object sender, EventArgs e)
		{
			ShowData();
		}

		private void CargarDatosSegunMoneda()
		{

			Util.Util.SetFormatTextEdit(this.txtSaldoInicial, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");
			Util.Util.SetFormatTextEdit(this.txtCreditos, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");
			Util.Util.SetFormatTextEdit(this.txtDebitos, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");
			Util.Util.SetFormatTextEdit(this.txtSaldoFinal, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");

			Util.Util.SetFormatTextEditGrid(this.txtGridCredito, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");
			Util.Util.SetFormatTextEditGrid(this.txtGridDebito, (sTipoMoneda == "L") ? Util.Util.FormatType.MonedaLocal : Util.Util.FormatType.MonedaExtrangera, "");
			this.gridView1.Columns[2].FieldName = (sTipoMoneda == "L") ? "DebitoLocal" : "DebitoDolar";
			this.gridView1.Columns[3].FieldName = (sTipoMoneda == "L") ? "CreditoLocal" : "CreditoDolar";
			this.gridView1.Columns[4].FieldName = (sTipoMoneda == "L") ? "SaldoLocal" : "SaldoDolar";
			//this.gridView1.RefreshData();
			DataRow drFila = dtTotalizado.Rows[0];

			this.txtSaldoInicial.Text = drFila[(sTipoMoneda == "L") ? "SaldoAnteriorLocal" : "SaldoAnteriorDolar"].ToString();
			this.txtCreditos.Text = drFila[(sTipoMoneda == "L") ? "CreditoLocal" : "CreditoDolar"].ToString();
			this.txtDebitos.Text = drFila[(sTipoMoneda == "L") ? "DebitoLocal" : "DebitoDolar"].ToString();
			this.txtSaldoFinal.Text = drFila[(sTipoMoneda == "L") ? "SaldoLocal" : "SaldoDolar"].ToString();

		}

		private void btnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			string tempPath = System.IO.Path.GetTempPath();
			String FileName = System.IO.Path.Combine(tempPath, "lstDetalleMovimientoCentroCuenta.xlsx");
			DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions()
			{
				SheetName = "Detalle Movimiento"
			};


			this.gridView1.ExportToXlsx(FileName, options);
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo.FileName = FileName;
			process.StartInfo.Verb = "Open";
			process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
			process.Start();
		}

		private void btnMonedaLocal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			sTipoMoneda = "L";
			CargarDatosSegunMoneda();
		}

		private void btnMonedaDolar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			sTipoMoneda = "D";
			CargarDatosSegunMoneda();
		}

		private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}


		private void dtgDetalle_DoubleClick(object sender, EventArgs e)
		{
			if (this.gridView1.SelectedRowsCount > 0)
			{
				DataRow dr = this.gridView1.GetDataRow(this.gridView1.GetSelectedRows()[0]);
				bool EsMayor = false;
				if (TipoView == 1)
				{
					drCuenta = dr;
					EsMayor = Convert.ToBoolean(drCuenta["EsMayor"]);
				}
				else
				{
					drCentroCosto = dr;
					EsMayor = Convert.ToBoolean(drCentroCosto["Acumulador"]);
				}
				if (EsMayor)
				{
					Consultas.frmConsultaCuentaCentroHijas ofrmConsulta = new Consultas.frmConsultaCuentaCentroHijas(drCentroCosto, drCuenta, Convert.ToDateTime(FechaInicial), Convert.ToDateTime(FechaFinal), Convert.ToDecimal(TC), TipoView);
					ofrmConsulta.ShowDialog();
				}
				else
				{
					frmConsultaAsiento frmConsultaAsiento = new frmConsultaAsiento(drCentroCosto, drCuenta, Convert.ToDateTime(FechaInicial), Convert.ToDateTime(FechaFinal), Convert.ToDecimal(TC));
					frmConsultaAsiento.ShowDialog();
				}
			}
		}

	}
}

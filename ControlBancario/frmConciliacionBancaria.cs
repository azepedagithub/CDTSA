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
		DataTable dtConciliacion = new DataTable();
		DataTable movLibros = new DataTable();
		DataTable movBanco = new DataTable();
		
		int IDConciliacion = -1;

		String Accion = "";
		Decimal SaldoInicialLibro = 0;
		DataRow currentRow;

		private void CargarEstados() {
			lstEstados.Clear();
			lstEstados.Add(new clsEstadoConciliacion() { CodEstado = 1, Descr = "Des-asociados" });
			lstEstados.Add(new clsEstadoConciliacion() { CodEstado = 2, Descr = "Asociados" });
			lstEstados.Add(new clsEstadoConciliacion() { CodEstado = -1, Descr = "Todos" });
			
			Util.Util.ConfigLookupEdit(this.slkupTypeView, lstEstados, "Descr", "CodEstado");
			Util.Util.ConfigLookupEditSetViewColumns(this.slkupTypeView, "[{'ColumnCaption':'Descr','ColumnField':'Descr','width':100}]");
			
			this.slkupTypeView.EditValue = -1;
		}

		public frmConciliacionBancaria( String Accion, int IDConciliacion = -1)
		{
			InitializeComponent();
			this.Load += frmConciliacionBancaria_Load;
			this.Accion = Accion;
			this.IDConciliacion = IDConciliacion;

		}

		void frmConciliacionBancaria_Load(object sender, EventArgs e)
		{
			try
			{
				CargarEstados();

				this.dtpFechaInicial.EditValue = DAC.ConciliacionDAC.GetLasFechaConciliacion();
				this.dtpFechaFinal.EditValue = Convert.ToDateTime(this.dtpFechaInicial.EditValue).AddMonths(1);

				Util.Util.ConfigLookupEdit(this.slkupCuentaBancaria, DAC.CuentaBancariaDAC.GetData(-1, -1).Tables["Data"], "Descr", "IDCuentaBanco");
				Util.Util.ConfigLookupEditSetViewColumns(this.slkupCuentaBancaria, "[{'ColumnCaption':'Codigo','ColumnField':'Codigo','width':30},{'ColumnCaption':'Descr','ColumnField':'Descr','width':70}]");

				LoadData();
			}
			catch (Exception ex) {
				MessageBox.Show("Han ocurrido los siguientes errores" + ex.Message);
			}
		
		}

		private void LoadData() {
			if (Accion == "View")
			{
				currentRow = DAC.ConciliacionDAC.GetData(IDConciliacion, -1).Tables[0].Rows[0];
				this.dtpFechaInicial.EditValue = currentRow["FechaInicio"];
				this.dtpFechaFinal.EditValue = currentRow["FechaFin"];
				this.slkupCuentaBancaria.EditValue = currentRow["IDCuentaBanco"];
				this.txtSaldoBanco.EditValue = currentRow["SaldoInicialBanco"];
				this.txtSaldoLibro.EditValue = currentRow["SaldoInicialLibro"];
				//TODO Calcular los totales marcados.
			}
		}

		private void slkupCuentaBancaria_EditValueChanged(object sender, EventArgs e)
		{
			DataRowView drCuenta = (DataRowView)this.slkupCuentaBancaria.GetSelectedDataRow();
			if (drCuenta != null) {
				this.txtCuentaContable.Text = drCuenta["IDCuenta"].ToString() + " - " + drCuenta["DescrCuentaContable"].ToString();
				this.txtBanco.Text = drCuenta["IDBanco"].ToString() + " - " + drCuenta["DescrBanco"].ToString();
				this.txtMoneda.Text = drCuenta["IDMoneda"].ToString() + " - " + drCuenta["DescrMoneda"].ToString();
				this.SaldoInicialLibro = DAC.ConciliacionDAC.GetSaldoInicialLibroByCuentaBancaria(Convert.ToInt32(this.slkupCuentaBancaria.EditValue));
				if (this.dtpFechaSaldo.EditValue != null || this.dtpFechaSaldo.EditValue.ToString() != "")
				{
					CargarMovimientosLibros();
				}
			}

		}

		private bool ValidarDatosConciliacion() {
			bool result = true;	  
			String sMensaje = "";
			if (this.slkupCuentaBancaria.EditValue == null || this.slkupCuentaBancaria.EditValue.ToString() == "")
				sMensaje = sMensaje + "\n\r	• Seleccione la cuenta bancaria";
			if (this.dtpFechaInicial.EditValue == null || this.dtpFechaInicial.EditValue.ToString() == "")
				sMensaje = sMensaje + "\n\r	• Seleccione la Fecha Inicial";
			if (this.dtpFechaFinal.EditValue == null || this.dtpFechaFinal.EditValue.ToString() == "")
				sMensaje = sMensaje + "\n\r	• Seleccione la Fecha Final";

			if (sMensaje != "") {
				MessageBox.Show("Por favor verifique los siguientes campos : \n\r " + sMensaje);
				result = false;
			}
			return result;
		}

		private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (ValidarDatosConciliacion())
			{
				if (this.Accion == "New")
				{
					dtConciliacion = DAC.ConciliacionDAC.GetData(-7, -7).Tables[0];
					currentRow = dtConciliacion.NewRow();
					currentRow["IDConciliacion"] = -1;
					currentRow["IDCuentaBanco"] = this.slkupCuentaBancaria.EditValue;
					currentRow["FechaInicio"] = Convert.ToDateTime(this.dtpFechaInicial.EditValue);
					currentRow["FechaFin"] = Convert.ToDateTime(this.dtpFechaFinal.EditValue);
					currentRow["Usuario"] = "Azepeda";

					dtConciliacion.Rows.Add(currentRow);
					try
					{
						DAC.ConciliacionDAC.oAdaptador.Update(dtConciliacion);
						this.IDConciliacion = Convert.ToInt32(DAC.ConciliacionDAC.oAdaptador.InsertCommand.Parameters["@IDConciliacion"].Value);
						dtConciliacion.AcceptChanges();
						//isEdition = false;
						lblStatus.Caption = "Se ha ingresado un nuevo registro";
						Application.DoEvents();
						this.Accion = "Edit";
						//PopulateGrid();
						//SetCurrentRow();
						//HabilitarControles(false);
						//AplicarPrivilegios();
						//ColumnView view = this.gridView1;
						//view.MoveLast();
					}
					catch (System.Data.SqlClient.SqlException ex)
					{
						dtConciliacion.RejectChanges();
						currentRow = null;
						MessageBox.Show(ex.Message);
					}
				}
				else if (Accion == "Edit")
				{
					if (currentRow != null)
					{
						//lblStatus.Caption = "Actualizando : " + currentRow["Descr"].ToString();

						Application.DoEvents();
						currentRow.BeginEdit();

						currentRow["IDConciliacion"] = IDConciliacion;
						currentRow["IDCuentaBanco"] = this.slkupCuentaBancaria.EditValue;
						currentRow["FechaInicio"] = Convert.ToDateTime(this.dtpFechaInicial.EditValue);
						currentRow["FechaFin"] = Convert.ToDateTime(this.dtpFechaFinal.EditValue);
						currentRow["Usuario"] = "Azepeda";

						currentRow.EndEdit();

						DataTable dtChanges = dtConciliacion.GetChanges(DataRowState.Modified);

						//Si no hay errores
						try
						{

							DAC.ConciliacionDAC.oAdaptador.Update(dtChanges);
							//lblStatus.Caption = "Actualizado " + currentRow["Descr"].ToString();
							Application.DoEvents();
							//Accion = "View";
							dtConciliacion.AcceptChanges();
							//PopulateGrid();
							//SetCurrentRow();
							//HabilitarControles(false);
							//AplicarPrivilegios();
						}
						catch (System.Data.SqlClient.SqlException ex)
						{
							dtConciliacion.RejectChanges();
							currentRow = null;
							MessageBox.Show(ex.Message);
						}
					}
				}
			}
		}

		private void dtpFechaInicial_EditValueChanged(object sender, EventArgs e)
		{
			this.dtpFechaSaldo.EditValue = this.dtpFechaInicial.EditValue;
		}

		private void CargarMovimientosLibros()
		{
			movLibros = DAC.ConciliacionDAC.GetMovimientoLibrosContables(Convert.ToInt32(this.slkupCuentaBancaria.EditValue), Convert.ToDateTime(this.dtpFechaSaldo.EditValue), Convert.ToDateTime(this.dtpFechaFinal.EditValue));
			this.gridMobLibros.DataSource = null;
			this.gridMobLibros.DataSource = movLibros;
		}

		private void dtpFechaSaldo_EditValueChanged(object sender, EventArgs e)
		{
			//Cargar Movi
			if (this.slkupCuentaBancaria.EditValue != null )
			{
				CargarMovimientosLibros();
			}
		}

		private void btnImportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (this.slkupCuentaBancaria.EditValue != null && this.IDConciliacion != -1)
			{
				frmImportMovBancos ofrmMovBancos = new frmImportMovBancos(Convert.ToInt32(this.slkupCuentaBancaria.EditValue),this.IDConciliacion);
				ofrmMovBancos.FormClosed += ofrmMovBancos_FormClosed;
				ofrmMovBancos.ShowDialog();
			}
		}

		void ofrmMovBancos_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmImportMovBancos ofrmImport = (frmImportMovBancos) sender;
			if (ofrmImport.DialogResult == System.Windows.Forms.DialogResult.OK) {
				movBanco = ofrmImport.dtMovBancos;
				this.gridMovBanco.DataSource = null;
				this.gridMovBanco.DataSource = movBanco;
			}
		}
	}

	public class clsEstadoConciliacion
	{
		public int CodEstado { get; set; }
		public String Descr { get; set; }
	}
}

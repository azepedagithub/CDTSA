using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using DevExpress.XtraGrid.Views.Grid;
using Security;
using System.Transactions;

namespace ControlBancario
{
	public partial class frmImportMovBancos : Form
	{
	
		public DataTable dtMovBancos = new DataTable();
		List<clsMovBancos> oLstMov = new List<clsMovBancos>();

		public bool IsResult = false;
		int IDCuentaBanco, IDConciliacion;
		String sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
	
		public frmImportMovBancos(int IDCuentaBanco, int IDConciliacion)
		{
			InitializeComponent();
			this.IDCuentaBanco = IDCuentaBanco;
			this.IDConciliacion = IDConciliacion;
		}

		private void frmImportMovBancos_Load(object sender, EventArgs e)
		{
			//Inicializar el dataTable
			DAC.ConcMovBancosDAC.SetTransactionToAdaptador(true);
			dtMovBancos = DAC.ConcMovBancosDAC.GetData(-7, -7).Tables[0];

		}

		private void btnLoadDoc_Click(object sender, EventArgs e)
		{
			var fileContent = string.Empty;
			var filePath = string.Empty;

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "xls files (*.xls)|*.xlsx|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					//Get the path of specified file
					filePath = openFileDialog.FileName;
					this.txtName.Text = filePath;

					//Read the contents of the file into a stream
					LoadData(filePath);
					
				}
			}

		}



		private void LoadData(String Ruta)
		{

			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(@Ruta);

			Excel._Worksheet xlWorkSheet = xlWorkBook.Sheets[1];
			Excel.Range xlRange = xlWorkSheet.UsedRange;
			int Rows, Cols = 0;
			Rows = xlRange.Rows.Count;
			Cols = xlRange.Columns.Count;

		
			
			try
			{

				//Validar que el documento cumple los requirimientos de importacion:
				String sMensaje = "";
				if (Cols > 4)
					sMensaje = sMensaje + "El archivo de importacion unicamente debe de contener cuatro columnas \n\r";

				for (int i = 1; i <= 4; i++)
				{
					
					Object valorCabecera = xlRange.Cells[1, i].Value2;
					if (i == 1 && valorCabecera.ToString().ToLower() != "fecha")
						sMensaje = sMensaje + "	• La primer columna debe de ser Fecha \n\r";
					if (i == 2 && valorCabecera.ToString().ToLower() != "referencia")
						sMensaje = sMensaje + " • La segunda columna debe de ser Referencia \n\r";
					if (i == 3 && valorCabecera.ToString().ToLower() != "concepto")
						sMensaje = sMensaje + "	• La tercer columna debe de ser Concepto \n\r";
					if (i == 4 && valorCabecera.ToString().ToLower() != "monto")
						sMensaje = sMensaje + "	• La cuarta columna debe de ser Monto \n\r";
				}

				if (sMensaje != "")
				{
					MessageBox.Show("Por favor verifique lo siguiente: \n\r" + sMensaje);
					return;
				}

				for (int i = 2; i <= Rows; i++)
				{
					clsMovBancos oDetalle = new clsMovBancos();
					for (int j = 1; j <= Cols; j++)
					{
						Object valor = xlRange.Cells[i, j].Value2;
						if (valor == null)
							break;
						if (i >= 2)
						{
							//Validar Los datos
							if (j == 1) //Codigo de Producto
							{
								if (valor.GetType() != typeof(double))
								{
									MessageBox.Show("La columna A debe de ser un valor de fecha");
									return;
								}
								double dFecha = Convert.ToDouble(valor);
								oDetalle.Fecha = DateTime.FromOADate(dFecha);
							}

							if (j == 4)
							{
								if (valor.GetType() != typeof(double))
								{
									MessageBox.Show("El monto de la transaccion debe de ser numérico");
									return;
								}
								oDetalle.Monto = Convert.ToDecimal(valor);
							}

							

							if (j == 2)
							{
								oDetalle.Referencia = Convert.ToString((valor == null) ? "" : valor.ToString());
							}
							if (j == 3)
							{
								oDetalle.Concepto = Convert.ToString((valor == null) ? "" : valor.ToString());
							}
						}


					}
					if (i > 1)  {
						oDetalle.IDCuentaBanco = this.IDCuentaBanco;
						oDetalle.IDConciliacion = this.IDConciliacion;
						// Realizar el cambio de Factor
						oDetalle.Factor = (oDetalle.Monto > 0) ? -1 : 1; 
						oDetalle.Usuario = sUsuario;
						oDetalle.Estado = "P";
						oLstMov.Add(oDetalle);
						
					};
				}


				

				this.dtgImport.DataSource = oLstMov;
			

			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrieron los siguientes erorres por favor verifique", ex.Message);
			}
			finally
			{
				Marshal.ReleaseComObject(xlRange);
				Marshal.ReleaseComObject(xlWorkSheet);

				xlWorkBook.Close();
				Marshal.ReleaseComObject(xlWorkBook);

				//quit and release
				xlApp.Quit();
				Marshal.ReleaseComObject(xlApp);
			}
		}


		

		private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				//string status = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Status"]);
				//if (status == "1")
				//{
				//    e.Appearance.BackColor = Color.IndianRed;
				//}
				//else
				//{
				//    e.Appearance.BackColor = Color.White;
				//}

				var fld = e.Column.FieldName;
				if (fld == ("Status"))
				{
					Brush circleBrush = null;
					Rectangle r = e.Bounds;
					r.Width = 16;
					r.Height = 16;

					int cell_state = (int)View.GetRowCellValue(e.RowHandle, View.Columns[fld]);
					if (cell_state == 0)
						circleBrush = new SolidBrush(Color.Green);
					else if (cell_state == 1)
						circleBrush = new SolidBrush(Color.Red);
					e.Graphics.FillEllipse(circleBrush, r);
					e.Appearance.DrawString(e.Cache, "", r);
					e.Handled = true;
				}
			}
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			//Procesar
			this.dtMovBancos.Clear();


			try
			{
				

				using (var scope = new TransactionScope())
				{
					//Eliminar lo que existe para la conciliacion
					DataTable dtDelete = DAC.ConcMovBancosDAC.GetData(this.IDConciliacion, -1).Tables[0];

					foreach (DataRow row in dtDelete.Rows)
					{
						row.Delete();
					}
					DAC.ConcMovBancosDAC.oAdaptador.Update(dtDelete);
					dtDelete.AcceptChanges();

					foreach (clsMovBancos fila in oLstMov)
					{
						DataRow nuevaFila = this.dtMovBancos.NewRow();
						nuevaFila["Fecha"] = fila.Fecha;
						nuevaFila["IDMovBanco"] = -1;
						nuevaFila["IDCuentaBanco"] = fila.IDCuentaBanco;
						nuevaFila["IDConciliacion"] = fila.IDConciliacion;
						nuevaFila["Referencia"] = fila.Referencia;
						nuevaFila["Monto"] = Math.Abs( fila.Monto);
						nuevaFila["Factor"] = fila.Factor;
						nuevaFila["Usuario"] = fila.Usuario;
						nuevaFila["Estado"] = fila.Estado;

						this.dtMovBancos.Rows.Add(nuevaFila);


						try
						{
							DAC.ConcMovBancosDAC.oAdaptador.Update(this.dtMovBancos);
							//nuevaFila["IDMovBanco"] = Convert.ToInt32(DAC.ConcMovBancosDAC.oAdaptador.InsertCommand.Parameters["@IDMovBanco"].Value);
							dtMovBancos.AcceptChanges();
							Application.DoEvents();

						}
						catch (System.Data.SqlClient.SqlException ex)
						{
							dtMovBancos.RejectChanges();
							nuevaFila = null;
							throw new Exception(ex.Message);
							break;
						}
					}
					scope.Complete();
				}
			}
			catch (Exception ex) {
				MessageBox.Show("Ha ocurrido un error", ex.Message);
			}
			
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}
		
	}

	public class clsMovBancos
	{
		public int IDCuentaBanco { get; set; }
		public int IDConciliacion { get; set; }
		public DateTime Fecha { get; set; }
		public String Referencia { get; set; }
		public String Concepto { get; set; }
		public decimal Monto { get; set; }
		public int Factor { get; set; }
		public int MatchNumber { get; set; }
		public String Usuario { get; set; }
		public String Estado { get; set; }
	}
}
					
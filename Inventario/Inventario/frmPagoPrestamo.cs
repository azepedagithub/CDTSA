using Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CI.DAC;

namespace CI
{
	public partial class frmPagoPrestamo : Form
	{
		private DataSet _dsDocumento;
		private DataSet _dsDetalle;

		private DataTable _dtDocumentoInv;
		
		DataRow _currentRow = null;
        DataRow _currentRowDetalle =null;
		
		String sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
		long IDTransaccionPrestamo;

		public frmPagoPrestamo(long IdTransaccionPrestamo)
		{
			InitializeComponent();
			this.IDTransaccionPrestamo = IdTransaccionPrestamo;
		}

		private void frmPagoPrestamo_Load(object sender, EventArgs e)
		{
			_dsDetalle = clsTransaccionPrestamoDAC.GetPrestamosByTransaccion(Convert.ToInt32(this.IDTransaccionPrestamo));
			this.dtgDetallePrestamos.DataSource = _dsDetalle.Tables["Prestamos"];
			_dsDocumento = clsDocumentoInvCabecera.GetData(this.IDTransaccionPrestamo);
			EnlazarControles(_dsDocumento.Tables[0].Rows[0]);

		}

		private void EnlazarControles(DataRow Fila) {
			this.txtAsiento.Text = Fila["Asiento"].ToString();
			this.txtDocumento.Text = Fila["Documento"].ToString();
			this.txtReferencia.Text = Fila["Referencia"].ToString();
			this.dtpFecha.EditValue = Convert.ToDateTime(Fila["Fecha"]);
		}

		//private bool ValidarCantidadesPagadas() {
		//	bool Resultado = false;
		//	foreach (DataRow fila in _dsDetalle.Tables["Prestamos"]) { 
		//		if (fila["
		//	}
		//	return Resultado;
		//}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			long IDTransaccion = -1;
			String Documento;
			Double TipoCambio = CG.TipoCambioDetalleDAC.GetLastTipoCambioFecha(DateTime.Now);
			this.dtgViewPrestados.PostEditor();

			if (MessageBox.Show("La acción que va realizar aplicará el documento al inventario \n\r Desea proseguir? ", "Aplicación del Documento", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
				return;
			//Validar si hay problemas a nivel de cuentas contables de productos.
			string sMensaje = "";
			for (int i = 0; i < _dsDetalle.Tables[0].Rows.Count; i++)
			{
				String tmpMsg = "";
				if (!clsProductoDAC.ValidaCuentasInventario(Convert.ToInt64(_dsDetalle.Tables[0].Rows[0]["IDProducto"]), ref tmpMsg))
				{
					sMensaje = sMensaje + tmpMsg + "\n\r";
				}
				decimal CantPagada = Convert.ToDecimal(_dsDetalle.Tables[0].Rows[0]["CantPagada"]);
				decimal CantPendiente = Convert.ToDecimal(_dsDetalle.Tables[0].Rows[0]["Pendiente"]);
				decimal Cantidad = Convert.ToDecimal(_dsDetalle.Tables[0].Rows[0]["Cantidad"]);

				if ((Cantidad - (CantPagada + CantPendiente)) < 0)
				{
					sMensaje = sMensaje + "La cantidad a pagar no puede ser mayor que el prestamo inicial" + "\n\r";
				}

			}

			if (sMensaje != "")
			{
				MessageBox.Show("Por favor verifique la cuenta contable de inventario: \n\r" + sMensaje);
				return;
			}


			//Validar  los datos de Cabecera

			//Proceder a guardar los datos de cabecera.
			_dsDocumento = clsDocumentoInvCabecera.GetData(IDTransaccion);
			_dtDocumentoInv = _dsDocumento.Tables[0];
			_currentRow = _dtDocumentoInv.NewRow();


			_currentRow["IDTransaccion"] = -1;
			_currentRow["ModuloOrigen"] = "CI";
			_currentRow["IDPaquete"] = 7;
			_currentRow["Fecha"] = DateTime.Now;
			_currentRow["Usuario"] = sUsuario;

			_currentRow["Referencia"] = "Pago de Prestamo";
			_currentRow["Documento"] = "-- --";
			_currentRow["Aplicado"] = true;
			_currentRow["UniqueValue"] = Guid.NewGuid();
			_currentRow["EsTraslado"] = false; //Cambiar
			_currentRow["IDTraslado"] = "-1"; //Cambiar

			_currentRow["CreateDate"] = DateTime.Now;

			ConnectionManager.BeginTran();
			clsDocumentoInvCabecera.SetTransactionToAdaptador(true);
			clsDocumentoInvDetalle.SetTransactionToAdaptador(true);

			if (_dsDocumento.Tables[0].Rows.Count > 0)
				_dsDocumento.Tables[0].Rows.Clear();
			_dsDocumento.Tables[0].Rows.Add(_currentRow);



			DataSet dsTemp = clsDocumentoInvDetalle.GetData(-1);
			try
			{
				clsDocumentoInvCabecera.oAdaptador.Update(_dsDocumento, "Data");
				_dsDocumento.AcceptChanges();

				IDTransaccion = Convert.ToInt32(_dsDocumento.Tables[0].Rows[0]["IDTransaccion"]);
				Documento = _dsDocumento.Tables[0].Rows[0]["Documento"].ToString();
				DataTable dtTemp = dsTemp.Tables[0];


				DAC.clsDocumentoInvCabecera.UpdateDatosPrestamos(IDTransaccion, false, true, ConnectionManager.Tran);


				//Actualizar los datos
				for (int i = 0; i < _dsDetalle.Tables[0].Rows.Count; i++)
				{
					_currentRowDetalle = dtTemp.NewRow();

					//Poner los datos correctos

					_currentRowDetalle["IDTransaccion"] = _dsDocumento.Tables[0].Rows[0]["IDTransaccion"];
					_currentRowDetalle["IDProducto"] = _dsDetalle.Tables[0].Rows[i]["IDProducto"];
					_currentRowDetalle["IDLote"] = _dsDetalle.Tables[0].Rows[i]["IDLote"];
					_currentRowDetalle["IDTipoTran"] = (_dsDetalle.Tables[0].Rows[i]["IDTipoTran"].ToString() == "11") ? 12 : 11;
					_currentRowDetalle["IDBodegaOrigen"] = _dsDetalle.Tables[0].Rows[i]["IDBodega"];
					_currentRowDetalle["IDTraslado"] = -1;
					_currentRowDetalle["Factor"] = (_dsDetalle.Tables[0].Rows[i]["IDTipoTran"].ToString() == "11") ? -1 : 1; 
					_currentRowDetalle["Cantidad"] = _dsDetalle.Tables[0].Rows[i]["Pendiente"];
					_currentRowDetalle["CostoUntDolar"] = _dsDetalle.Tables[0].Rows[i]["CostoUntDolar"];
					_currentRowDetalle["CostoUntLocal"] = Convert.ToDouble(_dsDetalle.Tables[0].Rows[i]["CostoUntDolar"]) * TipoCambio;
					_currentRowDetalle["PrecioUntLocal"] = Convert.ToDouble(_dsDetalle.Tables[0].Rows[i]["PrecioUntDolar"]) * TipoCambio;
					_currentRowDetalle["PrecioUntDolar"] = _dsDetalle.Tables[0].Rows[i]["PrecioUntDolar"];
					_currentRowDetalle["Transaccion"] = _dsDetalle.Tables[0].Rows[i]["Transaccion"];
					_currentRowDetalle["Naturaleza"] = (_dsDetalle.Tables[0].Rows[i]["IDTipoTran"].ToString() == "11") ? "S" : "E";
					_currentRowDetalle["TipoCambio"] = TipoCambio;


					dsTemp.Tables[0].Rows.Add(_currentRowDetalle);

				}

				clsDocumentoInvDetalle.oAdaptador.Update(dsTemp, "Data");
				dsTemp.AcceptChanges();

				Application.DoEvents();



				
					//Crear el asiento contable y aplicar el documento en inventario
				    IDTransaccion = (long)_dsDocumento.Tables[0].Rows[0]["IDTransaccion"];
					bool result = clsDocumentoInvCabecera.AplicaInventario(IDTransaccion, ConnectionManager.Tran);
					String Asiento = clsDocumentoInvCabecera.GeneraAsientoTransaccion(IDTransaccion, sUsuario, ConnectionManager.Tran);

					//Actualizar el detalle de prestamos
					//UpdatePrestamoByTransaccion
					DAC.clsTransaccionPrestamoDAC.UpdatePrestamoByTransaccion("I", this.IDTransaccionPrestamo, IDTransaccion, this.txtReferencia.Text, ConnectionManager.Tran);
					
					if (result && Asiento != null)
						ConnectionManager.CommitTran();
					else
						throw new Exception("Ha ocurrido un error");
				
				

				MessageBox.Show("El documento se ha guardado correctamente");

			}

			catch (Exception ex)
			{
				_dsDocumento.RejectChanges();
				//_dsDetalle.RejectChanges();
				dsTemp.RejectChanges();
				ConnectionManager.RollBackTran();
				//_currentRow = null;
				MessageBox.Show(ex.Message);
			}

		}
		
	}
}

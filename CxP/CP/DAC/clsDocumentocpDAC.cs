using Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.DAC
{
    public static class clsDocumentocpDAC
    {
		public static int UpdateCredito(String Operacion, ref int IDCredito, int IDProveedor, String TipoDocumento,String IDClase, int IDSubTipo, 
			String Documento,DateTime Fecha,int Plazo,decimal MontoOriginal,String ConceptoSistema, String ConceptoUsuario,
			String Usuario,decimal TipoCambio,bool fglOrigenExterno,bool flgAprobado,int IDMoneda,bool Anulado,decimal SubTotal,
			decimal Descuento,decimal SubTotalDescuento,Decimal ImpuestoIVA,decimal ImpuestoConsumo,decimal Flete, decimal Total,
			string strIDRetenciones,  int? IDObligacionProv = null)
		{
			long result = -1;
			String strSQL = "dbo.[cppUpdatecppCreditos]";
			
			SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

			oCmd.Parameters.Add(new SqlParameter("@Operation", Operacion));

			oCmd.Parameters.Add(new SqlParameter("@IDCredito", IDCredito));
			oCmd.Parameters["@IDCredito"].Direction = ParameterDirection.InputOutput;
			oCmd.Parameters.Add(new SqlParameter("@IDProveedor", IDProveedor));
			oCmd.Parameters.Add(new SqlParameter("@TipoDocumento", TipoDocumento));
			oCmd.Parameters.Add(new SqlParameter("@IDClase", IDClase));
			oCmd.Parameters.Add(new SqlParameter("@IDSubTipo", IDSubTipo));
			oCmd.Parameters.Add(new SqlParameter("@Documento", Documento));
			oCmd.Parameters.Add(new SqlParameter("@Fecha", Fecha));
			oCmd.Parameters.Add(new SqlParameter("@Plazo", Plazo));
			oCmd.Parameters.Add(new SqlParameter("@MontoOriginal", MontoOriginal));
			oCmd.Parameters.Add(new SqlParameter("@ConceptoSistema", ConceptoSistema));
			oCmd.Parameters.Add(new SqlParameter("@ConceptoUsuario", ConceptoUsuario));
			oCmd.Parameters.Add(new SqlParameter("@Usuario", Usuario));
			oCmd.Parameters.Add(new SqlParameter("@TipoCambio", TipoCambio));
			oCmd.Parameters.Add(new SqlParameter("@flgOrigenExterno", fglOrigenExterno));
			oCmd.Parameters.Add(new SqlParameter("@flgAprobado", flgAprobado));
			oCmd.Parameters.Add(new SqlParameter("@IDMoneda", IDMoneda));
			oCmd.Parameters.Add(new SqlParameter("@Anulado", Anulado));
			oCmd.Parameters.Add(new SqlParameter("@SubTotal", SubTotal));
			oCmd.Parameters.Add(new SqlParameter("@Descuento", Descuento));
			oCmd.Parameters.Add(new SqlParameter("@SubTotalDescuento", SubTotalDescuento));
			oCmd.Parameters.Add(new SqlParameter("@ImpuestoIVA", ImpuestoIVA));
			oCmd.Parameters.Add(new SqlParameter("@ImpuestoConsumo", ImpuestoConsumo));
			oCmd.Parameters.Add(new SqlParameter("@Flete", Flete));
			oCmd.Parameters.Add(new SqlParameter("@Total", Total));
			oCmd.Parameters.Add(new SqlParameter("@strIDRetenciones", strIDRetenciones));
			oCmd.Parameters.Add(new SqlParameter("@IDObligacionProv", IDObligacionProv));
			
			


			oCmd.CommandType = CommandType.StoredProcedure;

			if (oCmd.Connection.State == ConnectionState.Closed)
				oCmd.Connection.Open();
			result = oCmd.ExecuteNonQuery();
			IDCredito = Convert.ToInt32(oCmd.Parameters["@IDCredito"].Value);



			return IDCredito;
		}

    }
}

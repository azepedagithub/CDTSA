using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.DAC
{
	public static class clsTransaccionPrestamoDAC
	{
		public static DataSet GetPrestamosByTransaccion(int IDTransaccion)
		{
			String strSQL = "dbo.invGetDetallePrestamos";

			SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

			oCmd.Parameters.Add(new SqlParameter("@IDTransaccion", IDTransaccion));
			
			oCmd.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
			DataSet DS = new DataSet();
			oAdap.Fill(DS);
			DS.Tables[0].TableName = "Prestamos";	
			return DS;
		}


		public static int UpdatePrestamoByTransaccion(String Operacion,long IDTransaccionPrestamo, long IDTransaccion, String Nota, SqlTransaction oTran) {
			String strSql = "dbo.invUpdateTransaccionPrestamo";
			SqlCommand oCmd = new SqlCommand(strSql, Security.ConnectionManager.GetConnection());
			oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
			oCmd.Parameters.Add(new SqlParameter("@IDTransaccionPrestamo", IDTransaccionPrestamo));
			oCmd.Parameters.Add(new SqlParameter("@IDTransaccion", IDTransaccion));
			oCmd.Parameters.Add(new SqlParameter("@Nota", Nota));

			oCmd.CommandType = CommandType.StoredProcedure;
			oCmd.Transaction = oTran;
			return oCmd.ExecuteNonQuery();

		}

		public static DataTable GetDetallePrestamos(long IDTransaccionPrestamo, SqlTransaction oTran) {
			String strSql = "dbo.invGetTransaccionPrestamo";
			SqlCommand oCmd = new SqlCommand(strSql, Security.ConnectionManager.GetConnection());
			oCmd.Parameters.Add(new SqlParameter("IDTransaccionPrestamo", IDTransaccionPrestamo));
			oCmd.CommandType = CommandType.StoredProcedure;
			oCmd.Transaction =oTran;
			SqlDataAdapter oAdaptador  = new SqlDataAdapter(oCmd);
			DataSet ds =  new DataSet();
			oAdaptador.Fill(ds);
			return ds.Tables[0];
		}


	}
}

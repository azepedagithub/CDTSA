using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Security;

namespace CO.DAC
{
	public static class clsRetencionesDAC
	{
		public static long InsertUpdate(string Operacion, ref int IDRetencion, String Descr, Decimal Porcentaje, bool AplicaTotalFactura,
						bool AplicaSubTotal,bool AplicaSubTotalMenosDesc,int IDCentroRet,long IDCuentaRet,Decimal MontoMinimo,
						bool Activo, SqlTransaction tran)
		{
			long result = -1;
			String strSQL = "dbo.cppUpdateRetencion";

			SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

			oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
			oCmd.Parameters.Add(new SqlParameter("@IDRetencion", IDRetencion));
			oCmd.Parameters["@IDRetencion"].Direction = ParameterDirection.InputOutput;
			oCmd.Parameters["@IDRetencion"].SqlDbType = SqlDbType.Int;
			oCmd.Parameters.Add(new SqlParameter("@Descr", Descr));
			oCmd.Parameters.Add(new SqlParameter("@Porcentaje", Porcentaje));
			oCmd.Parameters.Add(new SqlParameter("@AplicaTotalFactura", AplicaTotalFactura));
			oCmd.Parameters.Add(new SqlParameter("@AplicaSubTotal", AplicaSubTotal));
			oCmd.Parameters.Add(new SqlParameter("@AplicaSubTotalMenosDesc", AplicaSubTotalMenosDesc));
			oCmd.Parameters.Add(new SqlParameter("@IDCentroRet", IDCentroRet));
			oCmd.Parameters.Add(new SqlParameter("@IDCuentaRet", IDCuentaRet));
			oCmd.Parameters.Add(new SqlParameter("@MontoMinimo", MontoMinimo));
			oCmd.Parameters.Add(new SqlParameter("@Activo", Activo));

			oCmd.CommandType = CommandType.StoredProcedure;
			oCmd.Transaction = tran;
			result = oCmd.ExecuteNonQuery();
			if (@Operacion == "I")
				IDRetencion = Convert.ToInt32(oCmd.Parameters["@IDRetencion"].Value);

			return result;

		}


		public static DataSet Get(int IDRetencion, String Descr)
		{
			String strSQL = "dbo.cppGetRetencion";

			SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

			oCmd.CommandType = CommandType.StoredProcedure;
			oCmd.Parameters.Add(new SqlParameter("@IDRetencion", IDRetencion));
			oCmd.Parameters.Add(new SqlParameter("@Descr", Descr));

			SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
			DataSet DS = new DataSet();

			oAdap.Fill(DS, "Data");
			return DS;
		}
	}
}

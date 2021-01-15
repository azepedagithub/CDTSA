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
	class clsProveedorRetencionDAC
	{
		public static long InsertUpdate(string Operacion, int IDProveedor, int IDRetencion, SqlTransaction tran)
		{
			long result = -1;
			String strSQL = "dbo.cppUpdateProveedorRetencion";

			SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

			oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
			oCmd.Parameters.Add(new SqlParameter("@IDProveedor", IDProveedor));
			oCmd.Parameters.Add(new SqlParameter("@IDRetencion", IDRetencion));
			
			oCmd.CommandType = CommandType.StoredProcedure;
			oCmd.Transaction = tran;
			result = oCmd.ExecuteNonQuery();
			
			return result;

		}


		public static DataSet Get(int IDProveedor, int IDRetencion)
		{
			String strSQL = "dbo.cppGetProveedorRetencion";

			SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

			oCmd.CommandType = CommandType.StoredProcedure;
			oCmd.Parameters.Add(new SqlParameter("@IDProveedor", IDProveedor));
			oCmd.Parameters.Add(new SqlParameter("@IDRetencion", IDRetencion));
			 

			SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
			DataSet DS = new DataSet();

			oAdap.Fill(DS, "Data");
			return DS;
		}

		public static DataSet GetRetencionesNoAsociadas(int IDProveedor)
		{
			String strSQL = "dbo.cppGetRetencionesNoAsociadas";

			SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

			oCmd.CommandType = CommandType.StoredProcedure;
			oCmd.Parameters.Add(new SqlParameter("@IDProveedor", IDProveedor));

			SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
			DataSet DS = new DataSet();

			oAdap.Fill(DS, "Data");
			return DS;
		}
	}
}

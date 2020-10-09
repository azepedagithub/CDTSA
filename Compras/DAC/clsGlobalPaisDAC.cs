using Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO.DAC
{
    public static class clsGlobalPaisDAC
    {
		
			public static long InsertUpdate(string Operacion, ref int IDPais, String Descr, bool Activo, SqlTransaction tran)
			{
				long result = -1;
				String strSQL = "dbo.globalUpdatePais";

				SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

				oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
				oCmd.Parameters.Add(new SqlParameter("@IDPais", IDPais));
				oCmd.Parameters.Add(new SqlParameter("@Descr", Descr));
				oCmd.Parameters.Add(new SqlParameter("@Activo", Activo));

				oCmd.CommandType = CommandType.StoredProcedure;
				oCmd.Transaction = tran;
				result = oCmd.ExecuteNonQuery();
				if (@Operacion == "I")
					IDPais = Convert.ToInt32(oCmd.Parameters["@IDPais"]);

				return result;

			}
  
			public static DataSet Get(long IDPais)
        {
            String strSQL = "dbo.invGetGlobalPais";
            SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());
            oCmd.Parameters.Add(new SqlParameter("@IDPais", IDPais));
            oCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();
            oAdap.Fill(DS,"Data");
            return DS;
        }

    }
}

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

	}
}

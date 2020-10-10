using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Security;

namespace CO.DAC
{
    public static class clsGastosCompraDAC
    {
			public static int InsertUpdate(string Operacion, ref int IDGasto, String Descripcion, bool Activo, SqlTransaction tran)
        {
            int result = -1;
            String strSQL = "dbo.coUpdateGastosCompra";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
            oCmd.Parameters.Add(new SqlParameter("@IDGasto", IDGasto));
            oCmd.Parameters["@IDGasto"].Direction = ParameterDirection.InputOutput;
            oCmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
            oCmd.Parameters.Add(new SqlParameter("@Activo", Activo));


            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();
            if (Operacion == "I")
            {
                result = (int)oCmd.Parameters["@IDGasto"].Value;
            }


            return result;

        }


        
        public static DataSet Get(int IdGasto, String Descripcion)
        {
            String strSQL = "dbo.coGetGastosCompra";

            SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDGasto", IdGasto));
            oCmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));

            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }


        
    }
}

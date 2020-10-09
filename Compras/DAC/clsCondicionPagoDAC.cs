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
    public static class clsCondicionPagoDAC
    {

        public static long InsertUpdate(string Operacion,ref int IDCondicionPago, String Descr, int Dias, decimal  DescContado,bool Activo, SqlTransaction tran)
        {
            long result = -1;
						String strSQL = "dbo.cppUpdateCondicionPago";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
						oCmd.Parameters.Add(new SqlParameter("@IDCondicionPago", IDCondicionPago));
						oCmd.Parameters["@IDCondicionPago"].Direction = ParameterDirection.InputOutput;
						oCmd.Parameters["@IDCondicionPago"].SqlDbType = SqlDbType.Int;
            oCmd.Parameters.Add(new SqlParameter("@Descr", Descr));
            oCmd.Parameters.Add(new SqlParameter("@Dias", Dias));
            oCmd.Parameters.Add(new SqlParameter("@DescuentoContado", DescContado));
            oCmd.Parameters.Add(new SqlParameter("@Activo", Activo));

            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();
            if (@Operacion == "I")
                IDCondicionPago = Convert.ToInt32(oCmd.Parameters["@IDCondicionPago"].Value);

            return result;

        }
        public static DataSet Get(int IDCondicionPago, String Descr)
        {
            String strSQL = "dbo.cppGetCondicionPago";

            SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Parameters.Add(new SqlParameter("@IDCondicionPago", IDCondicionPago));
            oCmd.Parameters.Add(new SqlParameter("@Descr", Descr));

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }
    }
}

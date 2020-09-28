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
    public static class clsGastosLiquidacionDetalladoDAC
    {
        public static long InsertUpdate(string Operacion,  long IDLiquidacion, int IDGasto,long IDProducto, decimal Monto, SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coUpdateGastoLiquidacionDetallado";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
            oCmd.Parameters.Add(new SqlParameter("@IDLiquidacion", IDLiquidacion));
            oCmd.Parameters.Add(new SqlParameter("@IDGasto", IDGasto));
            oCmd.Parameters.Add(new SqlParameter("@IDProducto", IDProducto));
            oCmd.Parameters.Add(new SqlParameter("@Monto", Monto));

            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();


            return result;

        }


        public static DataSet Get(long IDLiquidacion, int IDGasto, long IDProducto)
        {
            String strSQL = "dbo.coGetGastoLiquidacionDetallado";

            SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDLiquidacion", IDLiquidacion));
            oCmd.Parameters.Add(new SqlParameter("@IDGasto", IDGasto));
            oCmd.Parameters.Add(new SqlParameter("@IDProducto", IDProducto));

            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }

        public static DataSet GetProrrateoGastosCompra(int IDLiquidacion)
        {

            String strSQL = "dbo.coCalculaProrrateoGastosCompra";

            SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDLiquidacion", IDLiquidacion));
            
            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }
    }
}

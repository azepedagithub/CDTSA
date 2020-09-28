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
    public static class clsLiquidacionCompraDAC
    {
        public static int InsertUpdate(string Operacion,ref int IDLiquidacion, int IDEmbarque, int IDOrdenCompra,
                                        DateTime Fecha, decimal TipoCambio, decimal ValorMercaderia, decimal MontoFlete, decimal MontoSeguro,
                                        decimal Otros, decimal Total,SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coUpdateLiquidacionCompra";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
            oCmd.Parameters.Add(new SqlParameter("@IDLiquidacion", IDLiquidacion));
            oCmd.Parameters["@IDLiquidacion"].Direction = ParameterDirection.InputOutput;
            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.Parameters.Add(new SqlParameter("@IDOrdenCompra", IDOrdenCompra));
            oCmd.Parameters.Add(new SqlParameter("@Fecha", Fecha));
            oCmd.Parameters.Add(new SqlParameter("@TipoCambio", TipoCambio));
            oCmd.Parameters.Add(new SqlParameter("@ValorMercaderia", ValorMercaderia));
            oCmd.Parameters.Add(new SqlParameter("@MontoFlete", MontoFlete));
            oCmd.Parameters.Add(new SqlParameter("@MontoSeguro", MontoSeguro));
            oCmd.Parameters.Add(new SqlParameter("@Otros", Otros));
            oCmd.Parameters.Add(new SqlParameter("@MontoTotal", Total));


            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();
            if (Operacion == "I")
            {
                IDLiquidacion = Convert.ToInt32(oCmd.Parameters["@IDLiquidacion"].Value);
            }


            return IDLiquidacion;

        }


        public static DataSet Get(long IDLiquidacion,long IDEmbarque,long IDOrdenCompra)
        {
            String strSQL = "dbo.coGetLiquidacionCompra";

            SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDLiquidacion", IDLiquidacion));
            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.Parameters.Add(new SqlParameter("@IDOrdenCompra", IDOrdenCompra));

            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }

    }
}

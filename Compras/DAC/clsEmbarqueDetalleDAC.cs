using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO.DAC
{
    public static class clsEmbarqueDetalleDAC
    {
        public static long InsertUpdate(string Operacion, long IDEmbarque, long IDProducto,decimal Precio,decimal Cantidad,
            decimal CantidadAceptada,decimal CantidadRechazada,String Comentario,SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coUpdateEmbarqueDetalle";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.Parameters.Add(new SqlParameter("@IDProducto", IDProducto));
            oCmd.Parameters.Add(new SqlParameter("@PrecioUnitario", Precio));
            oCmd.Parameters.Add(new SqlParameter("@CantidadOrdenada", Cantidad));
            oCmd.Parameters.Add(new SqlParameter("@CantidadAceptada", CantidadAceptada));
            oCmd.Parameters.Add(new SqlParameter("@CantidadRechazada", CantidadRechazada));
            oCmd.Parameters.Add(new SqlParameter("@Comentario", Comentario));
            

            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();
            


            return result;

        }

        public static DataSet Get(long IDEmbarque)
        {
            String strSQL = "dbo.coGetEmbarqueDetalle";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            
            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS,"Data");
            return DS;
        }
    }
}

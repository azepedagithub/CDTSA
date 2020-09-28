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
    public static  class clsRecepcionMercaderiaDAC
    {
        public static long InsertUpdate(string Operacion, int IDEmbarque, long IDProducto, int IDLote, decimal Cantidad, SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coUpdateRecepcionMercaderia";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.Parameters.Add(new SqlParameter("@IDProducto", IDProducto));
            oCmd.Parameters.Add(new SqlParameter("@IDLote", IDLote));
            oCmd.Parameters.Add(new SqlParameter("@Cantidad", Cantidad));


            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();
            
            return result;

        }



        public static DataSet Get(int IDEmbarque)
        {
            String strSQL = "dbo.coGetRecepcionMercaderia";

            SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));

            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }

        public static DataSet ObtenerDatosGenerales(int IDEmbarque)
        {
            String strSQL = "dbo.GetDatosGeneralesRecepcionMercaderia";

            SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));

            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CO.DAC
{
    public static class clsObligacionProveedorDAC
    {
        public static long InsertUpdate(string Operacion, ref int IDObligacion, int IDEmbarque, bool flgDocCPGenerado, DateTime Fecha, DateTime FechaVence, DateTime FechaPoliza, String NumPoliza, String NumFactura,String Guia_BL, decimal TipoCambio, decimal ValorMercancia, decimal MontoFlete, decimal MontoSeguro, decimal MontoTotal, SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coUpdateObligacionProveedor";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@Operacion",Operacion));
            oCmd.Parameters.Add(new SqlParameter("@IDObligacion",IDObligacion));
            oCmd.Parameters["@IDObligacion"].Direction = ParameterDirection.InputOutput;
            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.Parameters.Add(new SqlParameter("@flgDocCPGenerado", flgDocCPGenerado));
            oCmd.Parameters.Add(new SqlParameter("@Fecha", Fecha));
            oCmd.Parameters.Add(new SqlParameter("@FechaPoliza", FechaPoliza));
            oCmd.Parameters.Add(new SqlParameter("@FechaVence", FechaVence));
            oCmd.Parameters.Add(new SqlParameter("@NumPoliza", NumPoliza));
            oCmd.Parameters.Add(new SqlParameter("@NumFactura", NumFactura));
            oCmd.Parameters.Add(new SqlParameter("@Guia_BL", Guia_BL));
            oCmd.Parameters.Add(new SqlParameter("@TipoCambio", TipoCambio));
            oCmd.Parameters.Add(new SqlParameter("@ValorMercaderia", ValorMercancia));
            oCmd.Parameters.Add(new SqlParameter("@MontoFlete", MontoFlete));
            oCmd.Parameters.Add(new SqlParameter("@MontoSeguro", MontoSeguro));
            oCmd.Parameters.Add(new SqlParameter("@MontoTotal", MontoTotal));
            
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();
            if (Operacion == "I")
            {
                result = Convert.ToInt64(oCmd.Parameters["@IDObligacion"].Value);
            }

            return result;

        }



        public static DataSet Get(int IDEmbarque,int IDObligacion)
        {
            String strSQL = "dbo.coGetObligacionProveedor";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.Parameters.Add(new SqlParameter("@IDObligacion", IDObligacion));
          
            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }


        public static String getDocumentoCP(int IDEmbarque)
        {
            String strSql = "dbo.coGetDocumentoCPObligacionProveedor";
            String sAsiento = "ND";

            SqlCommand oCmd = new SqlCommand(strSql, Security.ConnectionManager.GetConnection());
            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdapt = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();
            oAdapt.Fill(DS, "Data");

            if (DS.Tables[0].Rows.Count > 0)
            {
                sAsiento = DS.Tables[0].Rows[0]["Asiento"].ToString();
            }

            return sAsiento;

        }

    }
}

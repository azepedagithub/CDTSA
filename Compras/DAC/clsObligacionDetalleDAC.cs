using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CO.DAC
{
    public static class clsObligacionDetalleDAC
    {
        public static long InsertUpdate(string Operacion, ref int IDObligacionDetalle, int IDObligacion, int IDProveedor, String Documento, bool flgDocCPGenerado, DateTime FechaDocumento, decimal SubTotal,decimal PorcImpuesto,decimal Impuesto, decimal MontoTotal, int IDMoneda, int IDGasto, SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coUpdateObligacionDetalle";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
            oCmd.Parameters.Add(new SqlParameter("@IDObligacionDetalle", IDObligacionDetalle));
            oCmd.Parameters["@IDObligacionDetalle"].Direction = ParameterDirection.InputOutput;
            oCmd.Parameters.Add(new SqlParameter("@IDObligacion", IDObligacion));
            oCmd.Parameters.Add(new SqlParameter("@IDProveedor", IDProveedor));
            oCmd.Parameters.Add(new SqlParameter("@Documento", Documento));
            oCmd.Parameters.Add(new SqlParameter("@flgDocCPGenerado", flgDocCPGenerado));
            oCmd.Parameters.Add(new SqlParameter("@FechaDocumento", FechaDocumento));
            oCmd.Parameters.Add(new SqlParameter("@SubTotal", SubTotal));
            oCmd.Parameters.Add(new SqlParameter("@PorcImpuesto", PorcImpuesto));
            oCmd.Parameters.Add(new SqlParameter("@Impuesto", Impuesto));
            oCmd.Parameters.Add(new SqlParameter("@MontoTotal", MontoTotal));
            oCmd.Parameters.Add(new SqlParameter("@IDMoneda", IDMoneda));
            oCmd.Parameters.Add(new SqlParameter("@IDGasto", IDGasto));
            
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();
            if (Operacion == "I")
            {
                result = Convert.ToInt64(oCmd.Parameters["@IDObligacionDetalle"].Value);
            }

            return result;

        }



        public static DataSet Get(int IDObligacionDetalle, int IDObligacion)
        {
            String strSQL = "dbo.coGetObligacionDetalle";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDObligacionDetalle", IDObligacionDetalle));
            oCmd.Parameters.Add(new SqlParameter("@IDObligacion", IDObligacion));

            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }

        public static DataSet GetConsolidadoObligacionDetalle(int IDEmbarque)
        {
            String strSQL = "dbo.GetConsolidadoObligacionDetalle";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));

            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }


        
    }
}

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
    public static class clsEmbarqueDAC
    {
        public static long InsertUpdate(string Operacion, long IDEmbarque, ref String Embarque, DateTime Fecha, DateTime FechaEmbarque, 
            int IDBodega, int IDProveedor, long IDOrdenCompra, int IDDocumentoCP, decimal TipoCambio, String Usuario,
              DateTime CreateDate, String CreatedBy, DateTime RecordDate, String UpdateBy, SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coUpdateEmbaque";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.Parameters["@IDEmbarque"].Direction = ParameterDirection.InputOutput;
            oCmd.Parameters["@IDEmbarque"].Size = 20;
            oCmd.Parameters.Add(new SqlParameter("@Embarque", Embarque));
            oCmd.Parameters["@Embarque"].Direction = ParameterDirection.InputOutput;
            oCmd.Parameters["@Embarque"].Size = 20;
            oCmd.Parameters.Add(new SqlParameter("@Fecha", Fecha));
            oCmd.Parameters.Add(new SqlParameter("@FechaEmbarque", FechaEmbarque));
            oCmd.Parameters.Add(new SqlParameter("@IDBodega", IDBodega));
            oCmd.Parameters.Add(new SqlParameter("@IDProveedor", IDProveedor));
            oCmd.Parameters.Add(new SqlParameter("@IDOrdenCompra", IDOrdenCompra));
            oCmd.Parameters.Add(new SqlParameter("@IDDocumentoCP", IDDocumentoCP));
            oCmd.Parameters.Add(new SqlParameter("@TipoCambio", TipoCambio));
            oCmd.Parameters.Add(new SqlParameter("@Usuario", Usuario));
            oCmd.Parameters.Add(new SqlParameter("@CreateDate", CreateDate));
            oCmd.Parameters.Add(new SqlParameter("@CreatedBy", CreatedBy));
            oCmd.Parameters.Add(new SqlParameter("@RecordDate", RecordDate));
            oCmd.Parameters.Add(new SqlParameter("@UpdateBy", UpdateBy));


            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();
            if (Operacion == "I")
            {
                result = (long)oCmd.Parameters["@IDEmbarque"].Value;
                Embarque = oCmd.Parameters["@Embarque"].Value.ToString();
            }


            return result;

        }


        public static long CrearPaqueteInventario(string Modulo, long IDDocumento, String Usuario,ref long IDTransaccion , SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coCreaPaqueteEmbarque";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@Modulo", Modulo));
            oCmd.Parameters.Add(new SqlParameter("@IDDocumento", IDDocumento));
            oCmd.Parameters.Add(new SqlParameter("@IDTransaccion", IDTransaccion));
            oCmd.Parameters.Add(new SqlParameter("@Usuario", Usuario));
            oCmd.Parameters["@IDTransaccion"].Direction = ParameterDirection.InputOutput;
            oCmd.Parameters["@IDTransaccion"].Size = 20;
            
            

            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();

            IDTransaccion = (long)oCmd.Parameters["@IDTransaccion"].Value;

            return result;

        }


        public static long GeneraAsientoContable(string Modulo, long IDDocumento, String Usuario, ref string Asiento, SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coGeneraAsientoContableEmbarque";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@Modulo", Modulo));
            oCmd.Parameters.Add(new SqlParameter("@IDDocumento", IDDocumento));
            oCmd.Parameters.Add(new SqlParameter("@Asiento", Asiento));
            oCmd.Parameters.Add(new SqlParameter("@Usuario", Usuario));
            oCmd.Parameters["@Asiento"].Direction = ParameterDirection.InputOutput;
            oCmd.Parameters["@Asiento"].Size = 20;
            


            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();

            Asiento = oCmd.Parameters["@Asiento"].Value.ToString();

            return result;

        }


        public static bool ConfirmarEmbarque(int IDEmbarque, bool Confirmado, SqlTransaction tran)
        {
            bool bresult = false;
            long result;
            String strSQL = "dbo.coConfirmarEmbarque";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.Parameters.Add(new SqlParameter("@Confirmado", Confirmado));
            
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            if (oCmd.Connection.State != ConnectionState.Open)
                oCmd.Connection.Open();
            result = oCmd.ExecuteNonQuery();
              bresult = (result!=0) ? true : false;
            return bresult;

        }



        public static DataSet Get(int IDEmbarque, DateTime FechaInicial, DateTime FechaFinal, int IDProveedor,
                                int IDSolicitud, string OrdenCompra,string Embarque ,int IDDocumentoCP)
        {
            String strSQL = "dbo.coGetEmbarque";

            SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.Parameters.Add(new SqlParameter("@FechaInicial", FechaInicial));
            oCmd.Parameters.Add(new SqlParameter("@FechaFinal", FechaFinal));
            oCmd.Parameters.Add(new SqlParameter("@IDProveedor", IDProveedor));
            oCmd.Parameters.Add(new SqlParameter("@OrdenCompra", OrdenCompra));
            oCmd.Parameters.Add(new SqlParameter("@IDDocumentoCP", IDDocumentoCP));
            oCmd.Parameters.Add(new SqlParameter("@Embarque", Embarque));
            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }


        public static DataSet GetByID(long IDEmbarque, long IDOrdenCompra)
        {
            String strSQL = "dbo.coGetEmbarqueByID";

            SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.Parameters.Add(new SqlParameter("@IDOrdenCompra", IDOrdenCompra));
            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }


        public static DataSet GetProductosFromEmbarque(long IDEmbarque)
        {
            String strSQL = "dbo.coGetProductosFromEmbarque";

            SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }
        


        public static long SetEmbarqueToTransito(int IDEmbarque, SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coSetEmbarqueToTransito";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();

            return result;

        }


        public static long UnSetEmbarqueToTransito(int IDEmbarque, SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coUnSetEmbarqueToTransito";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();

            return result;

        }

        public static long CreaTransaccionInventario(int IDEmbarque, DateTime FechaDocumento,ref int IDTransaccion, String Usuario, SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coCreaPaqueteInventarioEmbarque";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.Parameters.Add(new SqlParameter("@FechaDocumento", FechaDocumento));
            oCmd.Parameters.Add(new SqlParameter("@IDTransaccion", IDTransaccion));
            oCmd.Parameters["@IDTransaccion"].Direction = ParameterDirection.InputOutput;
            oCmd.Parameters.Add(new SqlParameter("@Usuario", Usuario));
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();

            IDTransaccion = Convert.ToInt32(oCmd.Parameters["@IDTransaccion"].Value);

            return result;

        }

        public static long CreaAsientoTransaccionInventario(int IDEmbarque, ref String Asiento,String Usuario, SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.coGeneraAsientoContableEmbarque";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDEmbarque", IDEmbarque));
            oCmd.Parameters.Add(new SqlParameter("@Asiento", Asiento));
            oCmd.Parameters["@Asiento"].Direction = ParameterDirection.InputOutput;
            oCmd.Parameters["@Asiento"].DbType = DbType.String;
            oCmd.Parameters["@Asiento"].Size = 20;
            oCmd.Parameters.Add(new SqlParameter("@Usuario", Usuario));
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();
            Asiento = oCmd.Parameters["@Asiento"].Value.ToString();
            return result;

        }
    }
}

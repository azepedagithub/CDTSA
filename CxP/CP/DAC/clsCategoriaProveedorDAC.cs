using Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.DAC
{
	public static class clsCategoriaProveedorDAC
	{
		       public static long InsertUpdate(string Operacion,ref int IDCategoria, String Descr, int? Ctr_CXP, long? Cta_CXP,
                            int? Ctr_LetraCambio, long? Cta_Letra_CXP, int? Ctr_ProntoPago_CXP, long? Cta_ProntoPago_CXP,
                            int? Ctr_Comision_CXP, long? Cta_Comision_CxP, int? Ctr_Anticipos_CXP, long? Cta_Anticipos_CXP ,
                            int? Ctr_CierreDebitos_CXP, long? Cta_CierreDebitos_CXP, int? Ctr_Impuestos_CXP, long? Cta_Impuestos_CXP,bool Activo,
                            SqlTransaction tran)
        {
            long result = -1;
            String strSQL = "dbo.cppUpdateCategoriaPoveedor";

            SqlCommand oCmd = new SqlCommand(strSQL, Security.ConnectionManager.GetConnection());


            oCmd.Parameters.Add(new SqlParameter("@Operacion", Operacion));
            oCmd.Parameters.Add(new SqlParameter("@IDCategoria", IDCategoria));
						oCmd.Parameters["@IDCategoria"].Direction = ParameterDirection.InputOutput;
						oCmd.Parameters["@IDCategoria"].SqlDbType = SqlDbType.Int;
            oCmd.Parameters.Add(new SqlParameter("@Descr", Descr));
            oCmd.Parameters.Add(new SqlParameter("@Ctr_CXP", Ctr_CXP.HasValue ? Ctr_CXP.Value : System.Data.SqlTypes.SqlInt32.Null));
            oCmd.Parameters.Add(new SqlParameter("@Cta_CXP", Cta_CXP.HasValue ? Cta_CXP.Value : System.Data.SqlTypes.SqlInt64.Null));
						oCmd.Parameters.Add(new SqlParameter("@Ctr_Letra_CXP", Ctr_LetraCambio.HasValue ? Ctr_LetraCambio.Value : System.Data.SqlTypes.SqlInt32.Null));
            oCmd.Parameters.Add(new SqlParameter("@Cta_Letra_CXP", Cta_Letra_CXP.HasValue ? Cta_Letra_CXP.Value :  System.Data.SqlTypes.SqlInt64.Null));
						oCmd.Parameters.Add(new SqlParameter("@Ctr_ProntoPago_CXP", Ctr_ProntoPago_CXP.HasValue ? Ctr_ProntoPago_CXP.Value: System.Data.SqlTypes.SqlInt32.Null));
						oCmd.Parameters.Add(new SqlParameter("@Cta_ProntoPago_CXP", Cta_ProntoPago_CXP.HasValue ? Cta_ProntoPago_CXP.Value: System.Data.SqlTypes.SqlInt64.Null));
            oCmd.Parameters.Add(new SqlParameter("@Ctr_Comision_CXP", Ctr_Comision_CXP.HasValue ? Ctr_Comision_CXP.Value: System.Data.SqlTypes.SqlInt32.Null));
            oCmd.Parameters.Add(new SqlParameter("@Cta_Comision_CxP", Cta_Comision_CxP.HasValue ? Cta_Comision_CxP.Value: System.Data.SqlTypes.SqlInt64.Null));
            oCmd.Parameters.Add(new SqlParameter("@Ctr_Anticipos_CXP", Ctr_Anticipos_CXP.HasValue ? Ctr_Anticipos_CXP.Value: System.Data.SqlTypes.SqlInt32.Null));
            oCmd.Parameters.Add(new SqlParameter("@Cta_Anticipos_CXP", Cta_Anticipos_CXP.HasValue ? Cta_Anticipos_CXP.Value: System.Data.SqlTypes.SqlInt64.Null));
            oCmd.Parameters.Add(new SqlParameter("@Ctr_CierreDebitos_CXP",  Ctr_CierreDebitos_CXP.HasValue ? Ctr_CierreDebitos_CXP.Value: System.Data.SqlTypes.SqlInt32.Null));
            oCmd.Parameters.Add(new SqlParameter("@Cta_CierreDebitos_CXP", Cta_CierreDebitos_CXP.HasValue ? Cta_CierreDebitos_CXP.Value: System.Data.SqlTypes.SqlInt64.Null));
            oCmd.Parameters.Add(new SqlParameter("@Ctr_Impuestos_CXP", Ctr_Impuestos_CXP.HasValue ? Ctr_Impuestos_CXP.Value: System.Data.SqlTypes.SqlInt32.Null));
            oCmd.Parameters.Add(new SqlParameter("@Cta_Impuestos_CXP", Cta_Impuestos_CXP.HasValue ? Cta_Impuestos_CXP.Value: System.Data.SqlTypes.SqlInt64.Null));
						oCmd.Parameters.Add(new SqlParameter("@Activo", Activo));
            

            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Transaction = tran;
            result = oCmd.ExecuteNonQuery();
						if (Operacion == "I")
							IDCategoria = Convert.ToInt32(oCmd.Parameters["@IDCategoria"].Value);

            return result;

        }


        public static DataSet Get(int IDCategoria, String Descripcion)
        {
            String strSQL = "dbo.cppGetCategoriaProveedor";

            SqlCommand oCmd = new SqlCommand(strSQL, ConnectionManager.GetConnection());

            oCmd.Parameters.Add(new SqlParameter("@IDCategoria", IDCategoria));
            oCmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));

            oCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter oAdap = new SqlDataAdapter(oCmd);
            DataSet DS = new DataSet();

            oAdap.Fill(DS, "Data");
            return DS;
        }
    
	}
}

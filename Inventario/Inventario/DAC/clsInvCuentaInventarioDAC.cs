using Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.DAC
{
    public static class clsInvCuentaInventarioDAC
    {
    
       public static SqlDataAdapter oAdaptador = InicializarAdaptador();

        private static SqlDataAdapter InicializarAdaptador()
        {
            String getSQL = "dbo.invGetCuentaContableInv";
            String InsertSQL = "[dbo].[invUpdateCuentaContableInv]";
            String UpdateSQL = "[dbo].[invUpdateCuentaContableInv]";
            String DeleteSQL = "[dbo].[invUpdateCuentaContableInv]";

            try
            {
                SqlDataAdapter oAdaptador = new SqlDataAdapter()
                {
                    SelectCommand = new SqlCommand(getSQL, ConnectionManager.GetConnection()),
                    InsertCommand = new SqlCommand(InsertSQL, ConnectionManager.GetConnection()),
                    UpdateCommand = new SqlCommand(UpdateSQL, ConnectionManager.GetConnection()),
                    DeleteCommand = new SqlCommand(DeleteSQL, ConnectionManager.GetConnection())
                };

                //Paremetros Select 
                oAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                oAdaptador.SelectCommand.Parameters.Add("@IDCuentaContable", SqlDbType.BigInt).SourceColumn = "IDCuenta";
                oAdaptador.SelectCommand.Parameters.Add("@Descr", SqlDbType.NVarChar).SourceColumn = "Descr";


                //Paremetros Insert
                oAdaptador.InsertCommand.CommandType = CommandType.StoredProcedure;
                oAdaptador.InsertCommand.Parameters.Add("@Operacion", SqlDbType.NChar).Value = "I";
                oAdaptador.InsertCommand.Parameters.Add("@IDCuenta", SqlDbType.Int).SourceColumn = "IDCuenta";
                oAdaptador.InsertCommand.Parameters["@IDCuenta"].Direction = ParameterDirection.InputOutput;
                oAdaptador.InsertCommand.Parameters.Add("@Descr", SqlDbType.NVarChar).SourceColumn = "Descr";
                oAdaptador.InsertCommand.Parameters.Add("@CtrInventario", SqlDbType.Int).SourceColumn = "CtrInventario";
                oAdaptador.InsertCommand.Parameters.Add("@CtaInventario", SqlDbType.BigInt).SourceColumn = "CtaInventario";
                oAdaptador.InsertCommand.Parameters.Add("@CtrVenta", SqlDbType.Int).SourceColumn = "CtrVenta";
                oAdaptador.InsertCommand.Parameters.Add("@CtaVenta", SqlDbType.BigInt).SourceColumn = "CtaVenta";
                oAdaptador.InsertCommand.Parameters.Add("@CtrCompra", SqlDbType.Int).SourceColumn = "CtrCompra";
                oAdaptador.InsertCommand.Parameters.Add("@CtaCompra", SqlDbType.BigInt).SourceColumn = "CtaCompra";
                oAdaptador.InsertCommand.Parameters.Add("@CtrDescVenta", SqlDbType.Int).SourceColumn = "CtrDescVenta";
                oAdaptador.InsertCommand.Parameters.Add("@CtaDescVenta", SqlDbType.BigInt).SourceColumn = "CtaDescVenta";
                oAdaptador.InsertCommand.Parameters.Add("@CtrCostoVenta", SqlDbType.Int).SourceColumn = "CtrCostoVenta";
                oAdaptador.InsertCommand.Parameters.Add("@CtaCostoVenta", SqlDbType.BigInt).SourceColumn = "CtaCostoVenta";
                oAdaptador.InsertCommand.Parameters.Add("@CtaVariacionCosto", SqlDbType.BigInt).SourceColumn = "CtaVariacionCosto";
                oAdaptador.InsertCommand.Parameters.Add("@CtrVariacionCosto", SqlDbType.BigInt).SourceColumn = "CtrVariacionCosto";                
                oAdaptador.InsertCommand.Parameters.Add("@CtrSobranteInvFisico", SqlDbType.Int).SourceColumn = "CtrSobranteInvFisico";
                oAdaptador.InsertCommand.Parameters.Add("@CtaSobranteInvFisico", SqlDbType.BigInt).SourceColumn = "CtaSobranteInvFisico";
                oAdaptador.InsertCommand.Parameters.Add("@CtrFaltanteInvFisico", SqlDbType.Int).SourceColumn = "CtrFaltanteInvFisico";
                oAdaptador.InsertCommand.Parameters.Add("@CtaFaltanteInvFisico", SqlDbType.BigInt).SourceColumn = "CtaFaltanteInvFisico";
                oAdaptador.InsertCommand.Parameters.Add("@CtrDescBonificacion", SqlDbType.Int).SourceColumn = "CtrDescBonificacion";
                oAdaptador.InsertCommand.Parameters.Add("@CtaDescBonificacion", SqlDbType.BigInt).SourceColumn = "CtaDescBonificacion";
                oAdaptador.InsertCommand.Parameters.Add("@CtrDevVentas", SqlDbType.Int).SourceColumn = "CtrDevVentas";
                oAdaptador.InsertCommand.Parameters.Add("@CtaDevVentas", SqlDbType.BigInt).SourceColumn = "CtaDevVentas";
                oAdaptador.InsertCommand.Parameters.Add("@CtrConsumo", SqlDbType.Int).SourceColumn = "CtrConsumo";
                oAdaptador.InsertCommand.Parameters.Add("@CtaConsumo", SqlDbType.BigInt).SourceColumn = "CtaConsumo";
				oAdaptador.InsertCommand.Parameters.Add("@CtrPrestamo", SqlDbType.Int).SourceColumn = "CtrPrestamo";
				oAdaptador.InsertCommand.Parameters.Add("@CtaPrestamo", SqlDbType.BigInt).SourceColumn = "CtaPrestamo";

                

                //Paremetros Update 
                oAdaptador.UpdateCommand.CommandType = CommandType.StoredProcedure;
                oAdaptador.UpdateCommand.Parameters.Add("@Operacion", SqlDbType.NChar).Value = "U";
                oAdaptador.UpdateCommand.Parameters.Add("@IDCuenta", SqlDbType.Int).SourceColumn = "IDCuenta";
                oAdaptador.UpdateCommand.Parameters.Add("@Descr", SqlDbType.NVarChar).SourceColumn = "Descr";
                oAdaptador.UpdateCommand.Parameters.Add("@CtrInventario", SqlDbType.Int).SourceColumn = "CtrInventario";
                oAdaptador.UpdateCommand.Parameters.Add("@CtaInventario", SqlDbType.BigInt).SourceColumn = "CtaInventario";
                oAdaptador.UpdateCommand.Parameters.Add("@CtrVenta", SqlDbType.Int).SourceColumn = "CtrVenta";
                oAdaptador.UpdateCommand.Parameters.Add("@CtaVenta", SqlDbType.BigInt).SourceColumn = "CtaVenta";
                oAdaptador.UpdateCommand.Parameters.Add("@CtrCompra", SqlDbType.Int).SourceColumn = "CtrCompra";
                oAdaptador.UpdateCommand.Parameters.Add("@CtaCompra", SqlDbType.BigInt).SourceColumn = "CtaCompra";
                oAdaptador.UpdateCommand.Parameters.Add("@CtrDescVenta", SqlDbType.Int).SourceColumn = "CtrDescVenta";
                oAdaptador.UpdateCommand.Parameters.Add("@CtaDescVenta", SqlDbType.BigInt).SourceColumn = "CtaDescVenta";
                oAdaptador.UpdateCommand.Parameters.Add("@CtrCostoVenta", SqlDbType.Int).SourceColumn = "CtrCostoVenta";
                oAdaptador.UpdateCommand.Parameters.Add("@CtaCostoVenta", SqlDbType.BigInt).SourceColumn = "CtaCostoVenta";
                oAdaptador.UpdateCommand.Parameters.Add("@CtaVariacionCosto", SqlDbType.BigInt).SourceColumn = "CtaVariacionCosto";
                oAdaptador.UpdateCommand.Parameters.Add("@CtrVariacionCosto", SqlDbType.Int).SourceColumn = "CtrVariacionCosto";                
                oAdaptador.UpdateCommand.Parameters.Add("@CtrSobranteInvFisico", SqlDbType.Int).SourceColumn = "CtrSobranteInvFisico";
                oAdaptador.UpdateCommand.Parameters.Add("@CtaSobranteInvFisico", SqlDbType.BigInt).SourceColumn = "CtaSobranteInvFisico";
                oAdaptador.UpdateCommand.Parameters.Add("@CtrFaltanteInvFisico", SqlDbType.Int).SourceColumn = "CtrFaltanteInvFisico";
                oAdaptador.UpdateCommand.Parameters.Add("@CtaFaltanteInvFisico", SqlDbType.BigInt).SourceColumn = "CtaFaltanteInvFisico";
                oAdaptador.UpdateCommand.Parameters.Add("@CtrDescBonificacion", SqlDbType.Int).SourceColumn = "CtrDescBonificacion";
                oAdaptador.UpdateCommand.Parameters.Add("@CtaDescBonificacion", SqlDbType.BigInt).SourceColumn = "CtaDescBonificacion";
                oAdaptador.UpdateCommand.Parameters.Add("@CtrDevVentas", SqlDbType.Int).SourceColumn = "CtrDevVentas";
                oAdaptador.UpdateCommand.Parameters.Add("@CtaDevVentas", SqlDbType.BigInt).SourceColumn = "CtaDevVentas";
                oAdaptador.UpdateCommand.Parameters.Add("@CtrConsumo", SqlDbType.Int).SourceColumn = "CtrConsumo";
                oAdaptador.UpdateCommand.Parameters.Add("@CtaConsumo", SqlDbType.BigInt).SourceColumn = "CtaConsumo";
				oAdaptador.UpdateCommand.Parameters.Add("@CtrPrestamo", SqlDbType.Int).SourceColumn = "CtrPrestamo";
				oAdaptador.UpdateCommand.Parameters.Add("@CtaPrestamo", SqlDbType.BigInt).SourceColumn = "CtaPrestamo";



                //Paremetros Delete 
                oAdaptador.DeleteCommand.CommandType = CommandType.StoredProcedure;
                oAdaptador.DeleteCommand.Parameters.Add("@Operacion", SqlDbType.NChar).Value = "D";
                oAdaptador.DeleteCommand.Parameters.Add("@IDCuenta", SqlDbType.Int).SourceColumn = "IDCuenta";
                oAdaptador.DeleteCommand.Parameters.Add("@Descr", SqlDbType.NVarChar).SourceColumn = "Descr";
                oAdaptador.DeleteCommand.Parameters.Add("@CtrInventario", SqlDbType.Int).SourceColumn = "CtrInventario";
                oAdaptador.DeleteCommand.Parameters.Add("@CtaInventario", SqlDbType.BigInt).SourceColumn = "CtaInventario";
                oAdaptador.DeleteCommand.Parameters.Add("@CtrVenta", SqlDbType.Int).SourceColumn = "CtrVenta";
                oAdaptador.DeleteCommand.Parameters.Add("@CtaVenta", SqlDbType.BigInt).SourceColumn = "CtaVenta";
                oAdaptador.DeleteCommand.Parameters.Add("@CtrCompra", SqlDbType.Int).SourceColumn = "CtrCompra";
                oAdaptador.DeleteCommand.Parameters.Add("@CtaCompra", SqlDbType.BigInt).SourceColumn = "CtaCompra";
                oAdaptador.DeleteCommand.Parameters.Add("@CtrDescVenta", SqlDbType.Int).SourceColumn = "CtrDescVenta";
                oAdaptador.DeleteCommand.Parameters.Add("@CtaDescVenta", SqlDbType.BigInt).SourceColumn = "CtaDescVenta";
                oAdaptador.DeleteCommand.Parameters.Add("@CtrCostoVenta", SqlDbType.Int).SourceColumn = "CtrCostoVenta";
                oAdaptador.DeleteCommand.Parameters.Add("@CtaCostoVenta", SqlDbType.BigInt).SourceColumn = "CtaCostoVenta";
                oAdaptador.DeleteCommand.Parameters.Add("@CtaVariacionCosto", SqlDbType.BigInt).SourceColumn = "CtaVariacionCosto";
                oAdaptador.DeleteCommand.Parameters.Add("@CtrVariacionCosto", SqlDbType.Int).SourceColumn = "CtrVariacionCosto";                
                oAdaptador.DeleteCommand.Parameters.Add("@CtrSobranteInvFisico", SqlDbType.Int).SourceColumn = "CtrSobranteInvFisico";
                oAdaptador.DeleteCommand.Parameters.Add("@CtaSobranteInvFisico", SqlDbType.BigInt).SourceColumn = "CtaSobranteInvFisico";
                oAdaptador.DeleteCommand.Parameters.Add("@CtrFaltanteInvFisico", SqlDbType.Int).SourceColumn = "CtrFaltanteInvFisico";
                oAdaptador.DeleteCommand.Parameters.Add("@CtaFaltanteInvFisico", SqlDbType.BigInt).SourceColumn = "CtaFaltanteInvFisico";
                oAdaptador.DeleteCommand.Parameters.Add("@CtrDescBonificacion", SqlDbType.Int).SourceColumn = "CtrDescBonificacion";
                oAdaptador.DeleteCommand.Parameters.Add("@CtaDescBonificacion", SqlDbType.BigInt).SourceColumn = "CtaDescBonificacion";
                oAdaptador.DeleteCommand.Parameters.Add("@CtrDevVentas", SqlDbType.Int).SourceColumn = "CtrDevVentas";
                oAdaptador.DeleteCommand.Parameters.Add("@CtaDevVentas", SqlDbType.BigInt).SourceColumn = "CtaDevVentas";
                oAdaptador.DeleteCommand.Parameters.Add("@CtrConsumo", SqlDbType.Int).SourceColumn = "CtrConsumo";
                oAdaptador.DeleteCommand.Parameters.Add("@CtaConsumo", SqlDbType.BigInt).SourceColumn = "CtaConsumo";
				oAdaptador.DeleteCommand.Parameters.Add("@CtrPrestamo", SqlDbType.Int).SourceColumn = "CtrPrestamo";
				oAdaptador.DeleteCommand.Parameters.Add("@CtaPrestamo", SqlDbType.BigInt).SourceColumn = "CtaPrestamo";
                return oAdaptador;
            }
            catch (Exception)
            {
                throw;
            }
        }



        public static void SetTransactionToAdaptador(bool Activo)
        {
            oAdaptador.UpdateCommand.Transaction = (Activo) ? ConnectionManager.Tran : null;
            oAdaptador.DeleteCommand.Transaction = (Activo) ? ConnectionManager.Tran : null;
            oAdaptador.InsertCommand.Transaction = (Activo) ? ConnectionManager.Tran : null;
        }

        private static DataSet CreateDataSet()
        {
            DataSet DS = new DataSet();
            DataTable tipoTable = DS.Tables.Add("Data");
            return DS;
        }

        public static DataSet GetData(int IDCuenta, String Descr)
        {
            DataSet DS = CreateDataSet();
            oAdaptador.SelectCommand.Parameters["@IDCuentaContable"].Value = IDCuenta;
            oAdaptador.SelectCommand.Parameters["@Descr"].Value = Descr;
            

            oAdaptador.Fill(DS.Tables["Data"]);
            return DS;
        }


    }   
}

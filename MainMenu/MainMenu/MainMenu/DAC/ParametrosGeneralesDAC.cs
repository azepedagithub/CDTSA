﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Util;

namespace CDTSA.DAC
{
    public static class ParametrosGeneralesDAC
    {
        public static SqlDataAdapter oAdaptador = InicializarAdaptador();

        private static SqlDataAdapter InicializarAdaptador()
        {
            String getSQL = "SELECT *  FROM dbo.globalCompania";
            String UpdateSQL = "UPDATE dbo.globalCompania SET Nombre =@Nombre,Direccion=@Direccion,Telefono=@Telefono,Logo=@Logo,UsaCentroCosto=@UsaCentroCosto,SimboloMonedaFuncional=@SimboloMonedaFuncional,SimboloMonedaExtrangera=@SimboloMonedaExtrangera,CantDigitosDecimales=@CantDigitosDecimales,TipoCambio=@TipoCambio WHERE Compania='CDTSA'";
            

            try
            {
                SqlDataAdapter oAdaptador = new SqlDataAdapter()
                {
                    SelectCommand = new SqlCommand(getSQL, ConnectionManager.GetConnection()),
                    UpdateCommand = new SqlCommand(UpdateSQL, ConnectionManager.GetConnection()),

                };


                //Paremetros Update 
                //oAdaptador.UpdateCommand.CommandType = CommandType.StoredProcedure;
                oAdaptador.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar).SourceColumn = "Nombre";
                oAdaptador.UpdateCommand.Parameters.Add("@Direccion", SqlDbType.NVarChar).SourceColumn = "Direccion";
                oAdaptador.UpdateCommand.Parameters.Add("@Telefono", SqlDbType.NVarChar).SourceColumn = "Telefono";
                oAdaptador.UpdateCommand.Parameters.Add("@Logo", SqlDbType.Image).SourceColumn = "Logo";
                oAdaptador.UpdateCommand.Parameters.Add("@UsaCentroCosto", SqlDbType.Bit).SourceColumn = "UsaCentroCosto";
                oAdaptador.UpdateCommand.Parameters.Add("@SimboloMonedaFuncional", SqlDbType.NVarChar).SourceColumn = "SimboloMonedaFuncional";
                oAdaptador.UpdateCommand.Parameters.Add("@simboloMonedaExtrangera",SqlDbType.NVarChar).SourceColumn="SimboloMonedaExtrangera";
                oAdaptador.UpdateCommand.Parameters.Add("@CantDigitosDecimales", SqlDbType.Int).SourceColumn = "CantDigitosDecimales";
                oAdaptador.UpdateCommand.Parameters.Add("@TipoCambio", SqlDbType.NVarChar).SourceColumn = "TipoCambio";

          
                return oAdaptador;
            }catch (Exception)
            {
                throw;
            }
        }



        public static void SetTransactionToAdaptador(bool Activo)
        {
            oAdaptador.UpdateCommand.Transaction = (Activo) ? ConnectionManager.Tran : null;
        }

        private static DataSet CreateDataSet()
        {
            DataSet DS = new DataSet();
            DataTable tipoTable = DS.Tables.Add("Data");
            return DS;
        }

        public static DataSet GetData()
        {
            DataSet DS = CreateDataSet();
            oAdaptador.Fill(DS.Tables["Data"]);
            return DS;
        }

         
        public static DataSet GetDatosGeneralesCompania()
        {
            DataSet ds = CreateDataSet();
            String GetDatosGeneralesSQL = "SELECT  Nombre Compania " +
                                    "FROM dbo.globalCompania A where 1=3 ";

            SqlCommand ocmd = new SqlCommand(GetDatosGeneralesSQL, ConnectionManager.GetConnection());
            SqlDataAdapter oAdap = new SqlDataAdapter(ocmd);
            oAdap.Fill(ds,"Data");
            return ds;
            
        }

        public static DataSet GetTipoCambio(String TipoCambio,DateTime Fecha){
            String strSQL = string.Format("SELECT A.IDTipoCambio,Fecha,MAX(Monto) Monto  FROM dbo.globalTipoCambio A INNER JOIN dbo.globalTipoCambioDetalle B ON	A.IDTipoCambio = B.IDTipoCambio WHERE A.IDTipoCambio='{0}' AND Fecha='{1}' GROUP BY A.IDTipoCambio,Fecha", TipoCambio, Fecha.ToString("yyyyMMdd"));
            DataSet ds = CreateDataSet();
            SqlCommand ocmd =  new SqlCommand(strSQL,ConnectionManager.GetConnection());
            SqlDataAdapter oAdap= new SqlDataAdapter(ocmd);
            oAdap.Fill(ds,"Data");
            return ds;
        }

    
    }
}

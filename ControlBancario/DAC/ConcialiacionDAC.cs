using Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlBancario.DAC
{
	public static class ConciliacionDAC
	{
		public static SqlDataAdapter oAdaptador = InicializarAdaptador();

		private static SqlDataAdapter InicializarAdaptador()
		{
			String getSQL = "[dbo].[cbGetConciliacion]";
			String InsertSQL = "[dbo].[cbUpdateConciliacion]";
			String UpdateSQL = "[dbo].[cbUpdateConciliacion]";
			String DeleteSQL = "[dbo].[cbUpdateConciliacion]";

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
				oAdaptador.SelectCommand.Parameters.Add("@IDConciliacion", SqlDbType.Int).SourceColumn = "IDConciliacion";
				oAdaptador.SelectCommand.Parameters.Add("@IDCuenta", SqlDbType.Int).SourceColumn = "IDCuenta";
				



				//Paremetros Insert
				oAdaptador.InsertCommand.CommandType = CommandType.StoredProcedure;
				oAdaptador.InsertCommand.Parameters.Add("@Operacion", SqlDbType.NChar).Value = "I";
				oAdaptador.InsertCommand.Parameters.Add("@IDConciliacion", SqlDbType.Int).SourceColumn = "IDConciliacion";
				oAdaptador.InsertCommand.Parameters["@IDConciliacion"].Direction = ParameterDirection.InputOutput;
				oAdaptador.InsertCommand.Parameters.Add("@IDCuentaBanco", SqlDbType.Int).SourceColumn = "IDCuentaBanco";
				oAdaptador.InsertCommand.Parameters.Add("@FechaInicio", SqlDbType.Date).SourceColumn = "FechaInicio";
				oAdaptador.InsertCommand.Parameters.Add("@FechaFin", SqlDbType.Date).SourceColumn = "FechaFin";
				oAdaptador.InsertCommand.Parameters.Add("@Usuario", SqlDbType.NVarChar).SourceColumn = "Usuario";

				//Paremetros Insert
				oAdaptador.UpdateCommand.CommandType = CommandType.StoredProcedure;
				oAdaptador.UpdateCommand.Parameters.Add("@Operacion", SqlDbType.NChar).Value = "U";
				oAdaptador.UpdateCommand.Parameters.Add("@IDConciliacion", SqlDbType.Int).SourceColumn = "IDConciliacion";
				oAdaptador.UpdateCommand.Parameters.Add("@IDCuentaBanco", SqlDbType.Int).SourceColumn = "IDCuentaBanco";
				oAdaptador.UpdateCommand.Parameters.Add("@FechaInicio", SqlDbType.Date).SourceColumn = "FechaInicio";
				oAdaptador.UpdateCommand.Parameters.Add("@FechaFin", SqlDbType.Date).SourceColumn = "FechaFin";
				oAdaptador.UpdateCommand.Parameters.Add("@Usuario", SqlDbType.NVarChar).SourceColumn = "Usuario";
				



				//Paremetros Delete 
				oAdaptador.DeleteCommand.CommandType = CommandType.StoredProcedure;
				oAdaptador.DeleteCommand.Parameters.Add("@Operacion", SqlDbType.NChar).Value = "D";
				oAdaptador.DeleteCommand.Parameters.Add("@IDConciliacion", SqlDbType.Int).SourceColumn = "IDConciliacion";
				oAdaptador.DeleteCommand.Parameters.Add("@IDCuentaBanco", SqlDbType.Int).SourceColumn = "IDCuentaBanco";
				oAdaptador.DeleteCommand.Parameters.Add("@FechaInicio", SqlDbType.Date).SourceColumn = "FechaInicio";
				oAdaptador.DeleteCommand.Parameters.Add("@FechaFin", SqlDbType.Date).SourceColumn = "FechaFin";
				oAdaptador.DeleteCommand.Parameters.Add("@Usuario", SqlDbType.NVarChar).SourceColumn = "Usuario";

				
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

		public static DataSet GetData(int IDConciliacion, int IDCuenta)
		{
			DataSet DS = CreateDataSet();
			oAdaptador.SelectCommand.Parameters["@IDCuenta"].Value = IDCuenta;
			oAdaptador.SelectCommand.Parameters["@IDConciliacion"].Value = IDConciliacion;

			oAdaptador.Fill(DS.Tables["Data"]);
			return DS;
		}

		public static DateTime GetLasFechaConciliacion()
		{
			DataSet DS = CreateDataSet();

			SqlCommand oCmd =  new SqlCommand("dbo.cbGetLastFechaConciliacion", ConnectionManager.GetConnection());
			SqlDataAdapter oTempAdaptador = new SqlDataAdapter(oCmd);
			oTempAdaptador.Fill(DS, "data");
			return Convert.ToDateTime(DS.Tables[0].Rows[0]["Fecha"]);

		}

		public static Decimal GetSaldoInicialLibroByCuentaBancaria(int IDCuentaBancaria)
		{
			DataSet DS = CreateDataSet();
			SqlCommand ocmd = new SqlCommand("dbo.cbGetSaldoInicialLibro", ConnectionManager.GetConnection());
			ocmd.Parameters.Add(new SqlParameter("@IDCuentaBanco", IDCuentaBancaria));
			ocmd.CommandType = CommandType.StoredProcedure;
			SqlDataAdapter oTempAdaptador = new SqlDataAdapter(ocmd);
			oTempAdaptador.Fill(DS, "data");
			return Convert.ToDecimal(DS.Tables[0].Rows[0]["SaldoInicialLibro"]);
		}


		public static DataTable GetMovimientoLibrosContables(int IDCuentaBancaria, DateTime FechaInicial,DateTime FechaFinal)
		{
			DataSet DS = CreateDataSet();
			SqlCommand ocmd = new SqlCommand("dbo.cbGetMovLibrosContable", ConnectionManager.GetConnection());
			ocmd.Parameters.Add(new SqlParameter("@IDCuentaBancaria", IDCuentaBancaria));
			ocmd.Parameters.Add(new SqlParameter("@FechaInicial", FechaInicial));
			ocmd.Parameters.Add(new SqlParameter("@FechaFinal", FechaFinal));
			ocmd.CommandType = CommandType.StoredProcedure;
			SqlDataAdapter oTempAdaptador = new SqlDataAdapter(ocmd);
			oTempAdaptador.Fill(DS, "data");
			return DS.Tables[0];
		}

	}
}

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
	public static class ConcMovBancosDAC
	{
		public static SqlDataAdapter oAdaptador = InicializarAdaptador();

		private static SqlDataAdapter InicializarAdaptador()
		{
			String getSQL = "[dbo].[cbGetConcMovBanco]";
			String InsertSQL = "[dbo].[cbUpdateConcMovBanco]";
			String UpdateSQL = "[dbo].[cbUpdateConcMovBanco]";
			String DeleteSQL = "[dbo].[cbUpdateConcMovBanco]";

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
				oAdaptador.SelectCommand.Parameters.Add("@IDCuentaBanco", SqlDbType.Int).SourceColumn = "IDCuentaBanco";




				//Paremetros Insert
				oAdaptador.InsertCommand.CommandType = CommandType.StoredProcedure;
				oAdaptador.InsertCommand.Parameters.Add("@Operacion", SqlDbType.NChar).Value = "I";
				oAdaptador.InsertCommand.Parameters.Add("@IDMovBanco", SqlDbType.Int).SourceColumn = "IDMovBanco";
				oAdaptador.InsertCommand.Parameters.Add("@IDCuentaBanco", SqlDbType.Int).SourceColumn = "IDCuentaBanco";
				oAdaptador.InsertCommand.Parameters.Add("@Fecha", SqlDbType.Date).SourceColumn = "Fecha";
				oAdaptador.InsertCommand.Parameters.Add("@IDConciliacion", SqlDbType.Int).SourceColumn = "IDConciliacion";
				oAdaptador.InsertCommand.Parameters.Add("@Referencia", SqlDbType.NVarChar).SourceColumn = "Referencia";
				oAdaptador.InsertCommand.Parameters.Add("@Monto", SqlDbType.Decimal).SourceColumn = "Monto";
				oAdaptador.InsertCommand.Parameters.Add("@Factor", SqlDbType.Int).SourceColumn = "Factor";
				oAdaptador.InsertCommand.Parameters.Add("@Usuario", SqlDbType.NVarChar).SourceColumn = "Usuario";
				oAdaptador.InsertCommand.Parameters.Add("@Estado", SqlDbType.NVarChar).SourceColumn = "Estado";
				


				//Paremetros Update 
				oAdaptador.UpdateCommand.CommandType = CommandType.StoredProcedure;
				oAdaptador.UpdateCommand.Parameters.Add("@Operacion", SqlDbType.NChar).Value = "I";
				oAdaptador.UpdateCommand.Parameters.Add("@IDMovBanco", SqlDbType.Int).SourceColumn = "IDMovBanco";
				oAdaptador.UpdateCommand.Parameters.Add("@IDCuentaBanco", SqlDbType.Int).SourceColumn = "IDCuentaBanco";
				oAdaptador.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.Date).SourceColumn = "Fecha";
				oAdaptador.UpdateCommand.Parameters.Add("@IDConciliacion", SqlDbType.Int).SourceColumn = "IDConciliacion";
				oAdaptador.UpdateCommand.Parameters.Add("@Referencia", SqlDbType.NVarChar).SourceColumn = "Referencia";
				oAdaptador.UpdateCommand.Parameters.Add("@Monto", SqlDbType.Decimal).SourceColumn = "Monto";
				oAdaptador.UpdateCommand.Parameters.Add("@Factor", SqlDbType.Int).SourceColumn = "Factor";
				oAdaptador.UpdateCommand.Parameters.Add("@Usuario", SqlDbType.NVarChar).SourceColumn = "Usuario";
				oAdaptador.UpdateCommand.Parameters.Add("@Estado", SqlDbType.NVarChar).SourceColumn = "Estado";



				//Paremetros Delete 
				oAdaptador.DeleteCommand.CommandType = CommandType.StoredProcedure;
				oAdaptador.DeleteCommand.Parameters.Add("@Operacion", SqlDbType.NChar).Value = "I";
				oAdaptador.DeleteCommand.Parameters.Add("@IDMovBanco", SqlDbType.Int).SourceColumn = "IDMovBanco";
				oAdaptador.DeleteCommand.Parameters.Add("@IDCuentaBanco", SqlDbType.Int).SourceColumn = "IDCuentaBanco";
				oAdaptador.DeleteCommand.Parameters.Add("@Fecha", SqlDbType.Date).SourceColumn = "Fecha";
				oAdaptador.DeleteCommand.Parameters.Add("@IDConciliacion", SqlDbType.Int).SourceColumn = "IDConciliacion";
				oAdaptador.DeleteCommand.Parameters.Add("@Referencia", SqlDbType.NVarChar).SourceColumn = "Referencia";
				oAdaptador.DeleteCommand.Parameters.Add("@Monto", SqlDbType.Decimal).SourceColumn = "Monto";
				oAdaptador.DeleteCommand.Parameters.Add("@Factor", SqlDbType.Int).SourceColumn = "Factor";
				oAdaptador.DeleteCommand.Parameters.Add("@Usuario", SqlDbType.NVarChar).SourceColumn = "Usuario";
				oAdaptador.DeleteCommand.Parameters.Add("@Estado", SqlDbType.NVarChar).SourceColumn = "Estado";

				return oAdaptador;
			}
			catch (Exception)
			{
				throw;
			}
		}



		public static void SetTransactionToAdaptador(bool Activo)
		{
			oAdaptador.SelectCommand.Transaction = (Activo) ? ConnectionManager.Tran : null;
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

		public static DataSet GetData(int IDConciliacion, int IDCuentaBanco)
		{
			DataSet DS = CreateDataSet();
			oAdaptador.SelectCommand.Parameters["@IDConciliacion"].Value = IDConciliacion;
			oAdaptador.SelectCommand.Parameters["@IDCuentaBanco"].Value = IDCuentaBanco;

			oAdaptador.Fill(DS.Tables["Data"]);
			return DS;
		}
	}
}

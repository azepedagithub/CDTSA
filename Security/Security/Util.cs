using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public static class Esquema
    {
        public static String Compania { get; set; }
    }

	public static class Util
	{
		public static string EncodePassword(string originalPassword)
		{
			SHA1 sha1 = new SHA1CryptoServiceProvider();

			byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
			byte[] hash = sha1.ComputeHash(inputBytes);

			return Convert.ToBase64String(hash);
		}
	}

    public static class Acciones
    {
        public enum PrivilegiosGeneralesType
        {
            AccesoAlSistema = 1,
            ModificacionReportes =2,
            AdministracionSistema = 3,
            Contabilidad = 100,
            

            //Parametros que salen del modulo principal
            ParametrosGenerales = 4,
        }


        public enum PrivilegiosContableType
        {
            CatalogoCuentaContable = 101,
            AgregarCuentaContable = 102,
            EditarCuentaContable = 103,
            EliminarCuentaContable = 104,
            CatalogoCentroCosto = 105,
            AgregarCentroCosto = 106,
            EditarCentroCosto = 107,
            EliminarCentroCosto = 108,
            AsientodeDiario = 109,
            AgregarAsientodeDiario = 110,
            EditarAsientodeDiario = 111,
            EliminarAsientodeDiario = 112,
            MayorizarAsientodeDiario = 113,
            RegistrarTipoCambio=114,
            AnularAsientoMayorizado = 115,
            ParemtrosModuloContable = 116,
            PeriodosContables = 117,
            CerrarPeridoContable = 118,
            EstablecerPeridoTrabajo = 119,
            CrearEjerciciosContables = 120,
            GrupoEstadosFinancieros =121,
            AgregarGrupoEstadosFinancieros =122,
            EditarGrupoEstadosFinancieros=123,
            EliminarGrupoEstadosFinancieros =124,
            CuentaGrupoEstadosFinancieros =125 ,
			
        }


		public enum PrivilegiosControlBancarioType
		{
			//Modulo de Control Bancario
			AccesoalModulo = 200,
			ListadoConciliaciónBancaria = 201,
			AgregarConciliación = 202,
			EditarConciliación = 203,
			EliminarConciliación = 204,
			ExportarConciliación = 205,
			Conciliar = 206,
			ListadodeDocumentosBancarios = 207,
			AgregarDocumentoBancario = 208,
			EditarDocumentoBancario = 209,
			EliminarDocumentoBancario = 210,
			ImprimirDocumentoBancario = 211,
			AnularDocumentoBancario = 212,
			AprobarDocumentoBancario = 213,
			AgregarBancos = 214,
			EditarBancos = 215,
			EliminarBancos = 216,
			ExportarBancos = 217,
			AgregarCuentasBancarias = 218,
			EditarCuentasBancarias = 219,
			EliminarCuentasBancarias = 220,
			ExportarCuentasBancarias = 221,
			FormatodeImpresion = 222,
			AgregarSubTipoDocumento = 223,
			EditarSubTipoDocumento = 224,
			EliminarSubTipoDocumento = 225,
			ExportarSubTipoDocumento = 226,
			AgregarNIT = 227,
			EditarNIT = 228,
			EliminarNIT = 229,
			ExportarNIT = 230,
			AgregarTiposdeCuenta = 231,
			EditarTipodeCuenta = 232,
			EliminarTiposdeCuenta = 233,
			ExportarTiposdeCuenta = 234,
			AgregarTiposdeDocumento = 235,
			EditarTiposdeDocumento = 236,
			EliminartiposdeDocumento = 237,
			ExportarTiposdeDocumentos = 238,
		}


		

        
    }
}

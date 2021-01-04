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


		public enum PrivilegiosInventarioType
		{
			AccesoalModulo = 300,
			AgregarBodegas = 301,
			EditarBodegas = 302,
			EliminarBodegas = 303,
			ExportarBodegas = 304,
			AgregarClasificaciones = 305,
			EditarClasificaciones = 306,
			EliminarClasificaciones = 307,
			ExportarClasificaciones = 308,
			MostrarGrupodeClasificaciones = 309,
			AgregarConsecutivos = 310,
			EditarConsecutivos = 311,
			EliminarConsecutivos = 312,
			AgregarCuentasContablesdeInventario = 313,
			EditarCuentasContablesdeInventario = 314,
			EliminarCuentasContablesdeInventario = 315,
			ExportarCuentasContablesdeInventario = 316,
			AgregarDocumentodeInventario = 317,
			AplicarDocumentodeInventario = 318,
			AplicarCancelaciondePrestamos = 319,
			PagodePrestamos = 320,
			DetalledePrestamos = 321,
			ExportarDocumentodeInventario = 322,
			AgregarProductos = 323,
			EditarProductos = 324,
			EliminarProductos = 325,
			ExportarProductos = 326,
			AgregarLotes = 327,
			EditarLotes = 328,
			EliminarLotes = 329,
			ExportarLotes = 330,
			AgregarPaquete = 331,
			EditarPaquete = 332,
			EliminarPaquete = 333,
			ExportarPaquetes = 334,
			AgregarPresentacionesdeProducto = 335,
			EditarPresentacionesdeProducto = 336,
			EliminarPresentacionesdeProducto = 337,
			ExportarPresentecionesdeProducto = 338
		}

		public enum PrivilegiosComprasType
		{
			AccesoalModulo = 400,
			AgregarCondicionesdePagos = 401,
			EditarCondicionesdePagos = 402,
			ExportarCondicionesdePagos = 403,
			AgregarEmbarque = 404,
			EliminarEmbarque = 405,
			LiquidarEmbarque = 406,
			ConfirmarEmbarque = 407,
			RecepcionarMercaderia = 408,
			AgregarCatalogodeGastosdeLiquidación = 409,
			EditarCatalogodeGastosdeLiquidacion = 410,
			EliminarCatalogodeGastosdeLiquidacion = 411,
			ExportarCatalogodeGastosdeLiquidacion = 412,
			ImportarEmbarquedesdeExcel = 413,
			EditarLiquidacion = 414,
			ImprimirLiquidacion = 415,
			EliminarLiquidacion = 416,
			ProcesodeLiquidarEmbarque = 417,
			AgregarOrdendeCompra = 418,
			EditarOrdendeCompra = 419,
			EliminarOrdendeCompra = 420,
			ExportarOrdendeCompra = 421,
			ImprimirOrdendeCompra = 422,
			ConfirmarOrdendeCompra = 423,
			DesConfirmarOrdendecompra = 424,
			AnularOrdendeCompra = 425,
			EmbarcarOrdendeCompra = 426,
			CargarPedidoSugeridodeCompra = 427,
			AgregarPaises = 428,
			EditarPaises = 429,
			EliminarPaises = 430,
			ExportarPaises = 431,
			AccesoaParametrosdeCompras = 432,
			AgregarProveedores = 433,
			EditarProveedores = 434,
			EliminarProveedores = 435,
			GuardarResepciondeMercaderia = 436	,
			EliminarCondiciondePago = 437,
			EditarEmbarque=438,
			ExportarEmbarque= 439,
			ExportarProveedores = 440
		}
		

        
    }
}

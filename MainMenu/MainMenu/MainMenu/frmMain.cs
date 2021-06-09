using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using CG;
using Security;
using CDTSA.Properties;
using ControlBancario;
using CI;
using CO;
using Facturacion;
using System.Globalization;



namespace MainMenu
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private String CodTipoCambio;
		private String StatusError ="None";

		#region INICIALIZACION

		public frmMain()
        {
            InitializeComponent();
            this.SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint |
            ControlStyles.DoubleBuffer,
            true);
            CreateNodes(treeListInventario);
			CreateNodes(treeListTeleventa);
            CreateNodes(treeListFactura);
            CreateNodes(treeListContabilidad);
            CreateNodes(treeListAdministracion);
            CreateNodes(treeListControlBancario);
			CreateNodes(treeListCuentasXCobrar);
            CreateNodes(treelstCompras);
            CreateNodes(treelstCuentasPorPagar);
            this.Load += frmMain_Load;
            ShowPagesRibbonMan(false);
        }

		void frmMain_Load(object sender, EventArgs e)
		{
			CargarImagenFondo();
			InicializarControles();
			enlazarEventos();
			CargarPrivilegios();
			CargarParametrosSistema();
			CargarConfiguracionRegional();
		}

        private void enlazarEventos()
        {
            this.treeListContabilidad.DoubleClick -= treeListContabilidad_DoubleClick;
            this.treeListContabilidad.DoubleClick += treeListContabilidad_DoubleClick;

            this.treeListAdministracion.DoubleClick -= treeListAdministracion_DoubleClick;
            this.treeListAdministracion.DoubleClick += treeListAdministracion_DoubleClick;

            this.treeListControlBancario.DoubleClick -= treeListControlBancario_DoubleClick;
            this.treeListControlBancario.DoubleClick += treeListControlBancario_DoubleClick;

            this.treeListFactura.DoubleClick -= treeListFactura_DoubleClick;
            this.treeListFactura.DoubleClick += treeListFactura_DoubleClick;

			this.treeListTeleventa.DoubleClick -= treeListTeleVenta_DoubleClick;
			this.treeListTeleventa.DoubleClick += treeListTeleVenta_DoubleClick;

			this.treeListCuentasXCobrar.DoubleClick -= treeListCuentasXCobrar_DoubleClick;
			this.treeListCuentasXCobrar.DoubleClick += treeListCuentasXCobrar_DoubleClick;

			this.treelstCuentasPorPagar.DoubleClick-=treelstCuentasPorPagar_DoubleClick;
			this.treelstCuentasPorPagar.DoubleClick += treelstCuentasPorPagar_DoubleClick;
            
        }

		private void InicializarControles()
		{
			this.lblFecha.Caption = "Fecha: --";
			this.lblTipoCambio.Caption = "TC: --";
			this.lblCompania.Caption = "Compañia: ";
		}

		private void ObtenerTipoCambio(String TipoCambio)
		{
			DataSet DS = CDTSA.DAC.ParametrosGeneralesDAC.GetTipoCambio(TipoCambio, DateTime.Now);
			if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
			{
				this.lblFecha.Caption = "Fecha: " + Convert.ToDateTime(DS.Tables[0].Rows[0]["Fecha"]).ToShortDateString();
				this.lblTipoCambio.Caption = "TC: " + Convert.ToDecimal(DS.Tables[0].Rows[0]["Monto"]).ToString("N4");
				StatusError = "None";
				enlazarEventos();
			}
			else
			{
				this.lblFecha.Caption = "Fecha: --";
				this.lblTipoCambio.Caption = "TC: --";
				//validar si tiene privilegios para modificar el tipo de cambio.
				DataSet DSS = new DataSet();
				DataTable DT = new DataTable();
				DSS = UsuarioDAC.GetAccionModuloFromRole(0, UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString());
				DT = DSS.Tables[0];
				if (UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.RegistrarTipoCambio, DT))
				{
					MessageBox.Show("El tipo de cambio para el día no esta registrado, por favor ingrese el detalle del tipo de cambios \n\r ");
					StatusError = "On";
					foreach (Form frm in Application.OpenForms)
					{
						if (frm.GetType() == typeof(CG.frmTipoCambioDetalle))
						{
							return;
						}
					}
					CG.frmTipoCambioDetalle ofrmTipoCambio = new frmTipoCambioDetalle(CodTipoCambio, "");
					ofrmTipoCambio.FormClosing += ofrmTipoCambio_FormClosing;
					ofrmTipoCambio.MdiParent = this;
					ofrmTipoCambio.StartPosition = FormStartPosition.CenterScreen;
					ofrmTipoCambio.Show();
				}
				else
					MessageBox.Show("El tipo de cambio para el día no esta registrado, por favor contacte el administrador del sistema. \n\r ");
				this.treeListContabilidad.DoubleClick -= treeListContabilidad_DoubleClick;
			}
		}

		#endregion

		#region PARAMETROS SISTEMA
		private void CargarParametrosSistema()
		{

			try
			{
				DataSet DS = CDTSA.DAC.ParametrosGeneralesDAC.GetData();
				if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
				{
					String sMensaje = "";
					//Validar los datos de configuracion
					if (DS.Tables[0].Rows[0]["Nombre"].ToString() == "")
					{
						sMensaje = sMensaje + " • El nombre de la compañía no se ha establecido \n\r";
						this.lblCompania.Caption = "Compañia: ";
					}
					if (DS.Tables[0].Rows[0]["CantDigitosDecimales"].ToString() == "")
					{
						sMensaje = sMensaje + " • La cantidad de Dígitos de decimales que se visualizan en sistema \n\r";
					}
					if (DS.Tables[0].Rows[0]["SimboloMonedaFuncional"].ToString() == "")
						sMensaje = sMensaje + " • El símbolo de la moneda funcional no se ha establecido \n\r";
					if (DS.Tables[0].Rows[0]["SimboloMonedaExtrangera"].ToString() == "")
						sMensaje = sMensaje + " • El símbolo de la moneda extrangera no se ha establecido \n\r";
					if (DS.Tables[0].Rows[0]["TipoCambio"].ToString() == "")
						sMensaje = sMensaje + " • El tipo de Cambio con el trabajara el sistema no se ha establecido \n\r";

					if (sMensaje != "")
					{
						InicializarControles();
						MessageBox.Show("Por favor notifique a su administrador del sistema la validación de los siguientes campos: \n\r " + sMensaje);
						this.treeListContabilidad.DoubleClick -= treeListContabilidad_DoubleClick;
					}
					else
					{
						String sTipoCambio = "";
						Util.Util.DecimalLenght = Convert.ToInt32(DS.Tables[0].Rows[0]["CantDigitosDecimales"]);
						Util.Util.LocalSimbolCurrency = DS.Tables[0].Rows[0]["SimboloMonedaFuncional"].ToString();
						Util.Util.ForeingSimbolCurrency = DS.Tables[0].Rows[0]["SimboloMonedaExtrangera"].ToString();
						sTipoCambio = DS.Tables[0].Rows[0]["TipoCambio"].ToString();
						CodTipoCambio = sTipoCambio;
						ObtenerTipoCambio(sTipoCambio);
						this.lblCompania.Caption = "Compañia: " + DS.Tables[0].Rows[0]["Nombre"].ToString();

					}
				}
				else
				{
					MessageBox.Show("Los parámetros generales de la aplicacion estan incompletos, por favor contacte al administrador del sistema");

					//Quitar  todas las acciones a los menus.
					this.treeListContabilidad.DoubleClick -= treeListContabilidad_DoubleClick;
				}
				this.lblUsuario.Caption = "Usuario: " + ((UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void CargarConfiguracionRegional()
		{
			CultureInfo newCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
			newCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
			newCulture.DateTimeFormat.DateSeparator = "/";
			System.Threading.Thread.CurrentThread.CurrentCulture = newCulture; // new System.Globalization.CultureInfo("en-US");

		}


		private void SetUsuarioIntegracionModulos(String sUsuario)
		{
			Unit.gsUsuario = sUsuario;
			CP.Unitbk.gsUsuario = sUsuario;
			Unit.gsSucursal = "1";
		}

		private void CargarPrivilegios()
		{
			DataSet DS = new DataSet();
			DataTable DT = new DataTable();
			String sUsuario = UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString();
			SetUsuarioIntegracionModulos(sUsuario);
			DS = UsuarioDAC.GetAccionModuloFromRole(0, sUsuario);
			DT = DS.Tables[0];
			//Modulos principales
			if (UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosGeneralesType.Contabilidad, DT))
			{
				navGroupContabilidad.Visible = true;
				//activar las opciones de la contabilidad
				if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.CatalogoCuentaContable, DT))
					SetNodeDisable("frmListadoCuentaContable", treeListContabilidad);
				if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.CatalogoCentroCosto, DT))
					SetNodeDisable("frmListadoCentroCosto", treeListContabilidad);
				if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.AsientodeDiario, DT))
					SetNodeDisable("frmListadoAsientoDiario", treeListContabilidad);
				if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.ParemtrosModuloContable, DT))
					SetNodeDisable("frmParametrosContables", treeListContabilidad);
				if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.PeriodosContables, DT))
					SetNodeDisable("frmListadoPeriodos", treeListContabilidad);
				if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.CrearEjerciciosContables, DT))
					SetNodeDisable("frmCreaEjercicio", treeListContabilidad);
				if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.GrupoEstadosFinancieros, DT))
					SetNodeDisable("frmGrupoEstadosFinancieros", treeListContabilidad);
				if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.CuentaGrupoEstadosFinancieros, DT))
					SetNodeDisable("frmRelacionCuentaGrupoEstadosFinancieros", treeListContabilidad);
			}
			else
				navGroupContabilidad.Visible = false;

			//Validar el Resto de modulos
			if (UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosGeneralesType.AdministracionSistema, DT))
			{
				this.navGroupAdministracion.Visible = true;
				if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.RegistrarTipoCambio, DT))
					SetNodeDisable("frmListadoTipoCambio", treeListAdministracion);
				if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosGeneralesType.ParametrosGenerales, DT))
					SetNodeDisable("frmParametrosGenerales", treeListAdministracion);
				if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosGeneralesType.ModificacionReportes, DT))
					SetNodeDisable("frmDesigner", treeListAdministracion);
			}
			else
				this.navGroupAdministracion.Visible = false;

			//Desactivar Factura
			//this.navGroupFacturación.Visible = false;
		}


		private void CargarImagenFondo()
		{
			this.BackgroundImage = (Security.Esquema.Compania == "CEDETSA") ? Resources.CEDETSA : Resources.DASA;
			this.BackgroundImageLayout = ImageLayout.Center;
		}

		


		#endregion

		#region MENU

		private void CreateNodes(TreeList tl)
		{
			tl.BeginUnboundLoad();
			// Create a child node for the node1
			switch (tl.Name)
			{
				case "treeListInventario":
					addNodeToTree(tl, "Artículo", "frmProducto", -1);
					addNodeToTree(tl, "Lotes", "frmLote", -1);
					TreeListNode nodeTransacciones = addNodeToTree(tl, "Transacciones", "", -1);
					addNodeToTree(tl, "Documentos", "frmDocumentoInv", nodeTransacciones.Id);
					TreeListNode nodeConsultas = addNodeToTree(tl, "Consultas", "", -1);
					addNodeToTree(tl, "Artículos", "frmConsultaArticulo", nodeConsultas.Id);
					addNodeToTree(tl, "Bodega", "frmConsultaExistenciaBodega", nodeConsultas.Id);
					addNodeToTree(tl, "Transacciones", "frmConsultaTransacciones", nodeConsultas.Id);
					addNodeToTree(tl, "Saldos", "frmSaldosInventario", nodeConsultas.Id);
					TreeListNode nodeReportes = addNodeToTree(tl, "Reportes", "", -1);
					TreeListNode nodeProcesos = addNodeToTree(tl, "Processos", "", -1);
					addNodeToTree(tl, "Boleta Inventario", "frmBoleta", nodeProcesos.Id);
					TreeListNode nodeAdministracion = addNodeToTree(tl, "Administración", "", -1);
					addNodeToTree(tl, "Consecutivos", "frmConsecutivos", nodeAdministracion.Id);
					addNodeToTree(tl, "Clasificaciones", "frmCatalogoClasificaciones", nodeAdministracion.Id);
					addNodeToTree(tl, "Unidades de Medida", "frmUnidadMedida", nodeAdministracion.Id);
					addNodeToTree(tl, "Paquetes", "frmPaquetes", nodeAdministracion.Id);
					addNodeToTree(tl, "Cuentas Contables", "frmInvCuentaContable", nodeAdministracion.Id);
					addNodeToTree(tl, "Bodegas", "frmBodegas", nodeAdministracion.Id);
					addNodeToTree(tl, "Remision", "frmRemision", nodeAdministracion.Id);
					break;
				case "treeListAdministracion":
					TreeListNode nodeTipos = addNodeToTree(tl, "Catálogos", "", -1);
					addNodeToTree(tl, "Tipos de Cambio", "frmListadoTipoCambio", nodeTipos.Id);
					addNodeToTree(tl, "Subir Tipos de Cambio", "frmSubirTipoCambio", nodeTipos.Id);
					addNodeToTree(tl, "Parametros Generales", "frmParametrosGenerales", -1);
					addNodeToTree(tl, "Paises", "frmPaises", -1);
					addNodeToTree(tl, "Diseñador de Reportes", "frmDesigner", -1);
					TreeListNode nodeSeguridad = addNodeToTree(tl, "Seguridad", "", -1);
					addNodeToTree(tl, "Roles", "frmRoles", nodeSeguridad.Id);
					addNodeToTree(tl, "Usuarios", "frmListadoUsuario", nodeSeguridad.Id);
					break;
				case "treeListControlBancario":
					TreeListNode nodeCatalogoBanco = addNodeToTree(tl, "Catálogos", "", -1);
					addNodeToTree(tl, "Tipo Cuenta", "frmTipoCuenta", nodeCatalogoBanco.Id);
					addNodeToTree(tl, "Tipo Documento", "frmTipoDocumento", nodeCatalogoBanco.Id);
					addNodeToTree(tl, "Bancos", "frmListadoBanco", nodeCatalogoBanco.Id);
					addNodeToTree(tl, "Sub Tipo Documento", "frmListadoSubTipoDocumento", nodeCatalogoBanco.Id);
					addNodeToTree(tl, "Cuentas Bancarias", "frmListadoCuentaBancaria", nodeCatalogoBanco.Id);
					TreeListNode nodeDocumentos = addNodeToTree(tl, "Documentos", "", -1);
					addNodeToTree(tl, "Listado de Documentos", "frmListadoDocumentosBancarios", nodeDocumentos.Id);
					addNodeToTree(tl, "Estado de Cuenta", "frmEstadoCuenta", nodeDocumentos.Id);
					addNodeToTree(tl, "Nit", "frmNIT", nodeDocumentos.Id);
					TreeListNode nodeProcesosBanco = addNodeToTree(tl, "Procesos", "", -1);
					addNodeToTree(tl, "Conciliación Bancaria", "frmListadoConciliacionesBancarias", nodeProcesosBanco.Id);

					break;
				case "treelstCompras":
					addNodeToTree(tl, "Proveedores", "frmListadoProveedores", -1);
					TreeListNode nodeTransaccionesCompra = addNodeToTree(tl, "Transacciones", "", -1);
					addNodeToTree(tl, "Ordenes de Compra", "frmListadoOrdenesCompra", nodeTransaccionesCompra.Id);
					addNodeToTree(tl, "Embarques", "frmListadoEmbarque", nodeTransaccionesCompra.Id);
					TreeListNode nodeParametrosCO = addNodeToTree(tl, "Parámetros", "", -1);
					addNodeToTree(tl, "Parametros Compra", "frmParametrosCompra", nodeParametrosCO.Id);
					addNodeToTree(tl, "Gastos de Compra", "frmGastosCompra", nodeParametrosCO.Id);

					break;

				case "treelstCuentasPorPagar":
					addNodeToTree(tl, "Transacciones", "frmCPConsultaDocs", -1);
					addNodeToTree(tl, "Proveedores", "frmListadoProveedores", -1);

					TreeListNode nodeReportesCP = addNodeToTree(tl, "Reportes", "", -1);
					addNodeToTree(tl, "Movimentos del Proveedor", "frmCPMovimientosProveedor", nodeReportesCP.Id);
					addNodeToTree(tl, "Desglose de Pago", "frmCPReportesDesglosePago", nodeReportesCP.Id);
					addNodeToTree(tl, "Documentos por Pagar", "frmCPReportesDocXPagar", nodeReportesCP.Id);
					addNodeToTree(tl, "Análisis de Vencimiento", "frmCPReportesAnalisisVencimientoProv", nodeReportesCP.Id);

					TreeListNode nodeCatalogosCP = addNodeToTree(tl, "Catálogos", "", -1);
					addNodeToTree(tl, "Condición de Pago", "frmCondicionPago", nodeCatalogosCP.Id);
					addNodeToTree(tl, "Categoria Proveedor", "frmCategoriaProveedor", nodeCatalogosCP.Id);
					addNodeToTree(tl, "Catálogo de Retenciones", "frmListadoRetenciones", nodeCatalogosCP.Id);
					addNodeToTree(tl, "Parámetros", "frmParametrosCP", -1);

					break;
				case "treeListTeleventa":
					TreeListNode nodePedidos = addNodeToTree(tl, "Televentas", "", -1);
					addNodeToTree(tl, "Crear Pedido", "optCrearPedidoTeleventa", nodePedidos.Id);
					addNodeToTree(tl, "Autorizar Pedido", "optCrearAutorizarPedidoTeleventa", nodePedidos.Id);
					TreeListNode nodeCatalogoTeleventas = addNodeToTree(tl, "Catalogos", "", -1);
					addNodeToTree(tl, "Estado Pedido", "optEstadoPedidoTeleventa", nodeCatalogoTeleventas.Id);
					addNodeToTree(tl, "Tipo Entrega", "optTipoEntregaTeleventa", nodeCatalogoTeleventas.Id);

					break;
				case "treeListCuentasXCobrar":
					addNodeToTree(tl, "Registrar Cliente", "optRegistrarCliente", -1);
					TreeListNode nodeTransaccionesCliente = addNodeToTree(tl, "Transacciones", "", -1);
					addNodeToTree(tl, "Transacciones", "optRegistrarTranCliente", nodeTransaccionesCliente.Id);
					addNodeToTree(tl, "Recibos de Caja", "optRecibosCaja", nodeTransaccionesCliente.Id);
					addNodeToTree(tl, "Cheques PostFechados", "optRegistrarChequePostFechado", nodeTransaccionesCliente.Id);
					TreeListNode nodeProcesosCliente = addNodeToTree(tl, "Procesos", "", -1);
					addNodeToTree(tl, "Autorizaciones", "optAutorizacionesCliente", nodeProcesosCliente.Id);
					addNodeToTree(tl, "Grabar Doc Anulado", "optGuardarDocAnulado", nodeProcesosCliente.Id);
					TreeListNode nodeReportesCliente = addNodeToTree(tl, "Reportes", "", -1);
					addNodeToTree(tl, "Movimientos del Cliente", "optMovimientosCliente", nodeReportesCliente.Id);
					addNodeToTree(tl, "Desglose de Pagos", "optDesglosePagoCliente", nodeReportesCliente.Id);
					addNodeToTree(tl, "Documentos por cobrar", "optDxCCliente", nodeReportesCliente.Id);
					addNodeToTree(tl, "Análisis de Vencimiento", "optAnalisisVencCliente", nodeReportesCliente.Id);
					addNodeToTree(tl, "Análisis de Vencimiento por Sucursal", "optAnalisisVencSucCliente", nodeReportesCliente.Id);
					TreeListNode nodeCatalogos = addNodeToTree(tl, "Catálogos", "", -1);
					addNodeToTree(tl, "Categoria de Clientes", "optCategoriaCliente", nodeCatalogos.Id);
					addNodeToTree(tl, "Tipo Clientes", "optTipoCliente", nodeCatalogos.Id);
					addNodeToTree(tl, "Evaluaciones de Clientes", "optEvaluacionesCliente", nodeCatalogos.Id);
					addNodeToTree(tl, "Departamento", "optDepartamentoCliente", nodeCatalogos.Id);
					addNodeToTree(tl, "Municipios", "optMunicipiosCliente", nodeCatalogos.Id);
					addNodeToTree(tl, "Zonas", "optZonasCliente", nodeCatalogos.Id);
					addNodeToTree(tl, "Sub Zonas", "optSubZonaCliente", nodeCatalogos.Id);
					addNodeToTree(tl, "Plazos de Credito", "optPlasosCreditoCliente", nodeCatalogos.Id);
					addNodeToTree(tl, "Paremetros", "optParametrosCliente", nodeCatalogos.Id);

					break;

				case "treeListFactura":
					TreeListNode nodeFactura = addNodeToTree(tl, "Facturación", "", -1);
					TreeListNode nodeConsultasFactura = addNodeToTree(tl, "Crear Factura", "optCrearFactura", nodeFactura.Id);
					addNodeToTree(tl, "Consultas", "", nodeFactura.Id);
					addNodeToTree(tl, "Facturación", "optConsultaFacturacion", nodeConsultasFactura.Id);
					addNodeToTree(tl, "Devoluciones", "optConsultaDevoluciones", nodeConsultasFactura.Id);
					TreeListNode nodeCatalogosFactura = addNodeToTree(tl, "Catalogos", "", nodeFactura.Id);
					addNodeToTree(tl, "Tipo Factura", "optCatalogoTipoFactura", nodeCatalogosFactura.Id);
					addNodeToTree(tl, "Tipo Vendedor", "optCatalogoTipoFactura", nodeCatalogosFactura.Id);
					addNodeToTree(tl, "Grupo Vendedor", "optCatalogoGrupoVendedor", nodeCatalogosFactura.Id);
					addNodeToTree(tl, "Vendedores", "optCatalogoVendedores", nodeCatalogosFactura.Id);
					TreeListNode nodePrecios = addNodeToTree(tl, "Precios", "", -1);
					addNodeToTree(tl, "Niveles de Precios", "optNivelesPrecio", nodePrecios.Id);
					addNodeToTree(tl, "Lista de Precios", "optListaPrecios", nodePrecios.Id);
					TreeListNode nodePromociones = addNodeToTree(tl, "Promociones", "", -1);
					addNodeToTree(tl, "Crear Promoción", "optCrearPromocion", nodePromociones.Id);
					addNodeToTree(tl, "Promocion Dirigida a Clientes", "optTablaPromClientes", nodePromociones.Id);
					addNodeToTree(tl, "Crear Bonificaciones", "optCrearBonificacion", nodePromociones.Id);
					addNodeToTree(tl, "Tabla de Descuentos con Bonificación", "optTablaDesc", nodePromociones.Id);
					TreeListNode nodeParametrosFactura = addNodeToTree(tl, "Parámetros", "", -1);
					addNodeToTree(tl, "Parámetros Facturación", "optParametrosFA", nodeParametrosFactura.Id);
					addNodeToTree(tl, "Consecutivos", "optConsecutivosMask", nodeParametrosFactura.Id);

					break;

				case "treeListContabilidad":
					addNodeToTree(tl, "Cuentas Contables", "frmListadoCuentaContable", -1);
					addNodeToTree(tl, "Centro de Costos", "frmListadoCentroCosto", -1);
					TreeListNode nodeTransaccionesContabilidad = addNodeToTree(tl, "Transacciones", "", -1);
					addNodeToTree(tl, "Diario", "frmListadoAsientoDiario", nodeTransaccionesContabilidad.Id);
					addNodeToTree(tl, "Mayor", "frmListadoAsientoMayor", nodeTransaccionesContabilidad.Id);
					TreeListNode nodeConsultasContabilidad = addNodeToTree(tl, "Consultas", "", -1);
					addNodeToTree(tl, "De Cuentas Contables", "frmConsultaSaldoCuenta", nodeConsultasContabilidad.Id);
					addNodeToTree(tl, "De Centros de Costos", "frmConsultaSaldoCentro", nodeConsultasContabilidad.Id);
					addNodeToTree(tl, "Libro Mayor", "frmConsultaLibroMayor", nodeConsultasContabilidad.Id);
					TreeListNode nodeConsultasContabilidadMayor = addNodeToTree(tl, "del Mayor", "", nodeConsultasContabilidad.Id);
					addNodeToTree(tl, "Asientos", "frmConsultaAsientoMayor", nodeConsultasContabilidadMayor.Id);
					addNodeToTree(tl, "Detalle", "frmConsultaDetalleMayor", nodeConsultasContabilidadMayor.Id);
					TreeListNode nodeConsultasContabilidaDiario = addNodeToTree(tl, "del Diario", "", nodeConsultasContabilidad.Id);
					addNodeToTree(tl, "Asientos", "frmConsultaAsientoDiario", nodeConsultasContabilidaDiario.Id);
					addNodeToTree(tl, "Detalle", "frmConsultaDetalleDiario", nodeConsultasContabilidaDiario.Id);
					TreeListNode nodeProcesosContab = addNodeToTree(tl, "Proceso", "", nodeConsultasContabilidad.Id);
					addNodeToTree(tl, "Generación de Asientos de Cierre Fiscal", "frmGenerarDocumentosCierrePeriodoFiscal", nodeProcesosContab.Id);
					TreeListNode nodeReportesContabilidad = addNodeToTree(tl, "Reportes", "", -1);
					addNodeToTree(tl, "Balance General", "frmBalanceGeneral", nodeReportesContabilidad.Id);
					addNodeToTree(tl, "Balance Comprobación", "frmBalanceComprobacion", nodeReportesContabilidad.Id);
					addNodeToTree(tl, "Estado de Resultado", "frmEstadoResultado", nodeReportesContabilidad.Id);
					TreeListNode nodeAdministracionContabilidad = addNodeToTree(tl, "Administración", "", -1);
					addNodeToTree(tl, "Parámetros del Módulo", "frmParametrosContables", nodeAdministracionContabilidad.Id);
					addNodeToTree(tl, "Periodos Contables", "frmListadoPeriodos", nodeAdministracionContabilidad.Id);
					addNodeToTree(tl, "Grupos Estados Financieros", "frmGrupoEstadosFinancieros", nodeAdministracionContabilidad.Id);
					addNodeToTree(tl, "Asociar Cuenta Grupos Estados Financieros", "frmRelacionCuentaGrupoEstadosFinancieros", nodeAdministracionContabilidad.Id);
					addNodeToTree(tl, "Crear Ejercicios", "frmCreaEjercicio", nodeAdministracionContabilidad.Id);
					addNodeToTree(tl, "Cerrar Periodo", "frmCerrarPeriodo", nodeAdministracionContabilidad.Id);
					addNodeToTree(tl, "Tipo Asiento", "frmTipoAsiento", nodeAdministracionContabilidad.Id);
					break;
			}

			tl.EndUnboundLoad();
		}

		#endregion

		#region TREELIST DOUBLECLICK
		void treeListCuentasXCobrar_DoubleClick(object sender, EventArgs e)
		{
			DevExpress.XtraTreeList.Nodes.TreeListNode node = default(DevExpress.XtraTreeList.Nodes.TreeListNode);
            node = ((TreeList)sender).FocusedNode;
            if (node.Tag == null)
                return;
			CP.frmMainCP ofrmOpcionCP = new CP.frmMainCP();
			frmtmpMain ofrmOpcionFA = new frmtmpMain();
			switch (node.Tag.ToString())
			{
				case "optRegistrarCliente":
					ofrmOpcionFA.MenuClientes();
					break;
				case "optRegistrarTranCliente":
					frmCCFConsultaDocs ofrmDocs = new frmCCFConsultaDocs();
					ofrmDocs.ShowDialog();
					break;
				case "optRecibosCaja":
					frmCCFConsultaRC ofrmRecibos = new frmCCFConsultaRC();
					ofrmRecibos.ShowDialog();
					break;
				case "optRegistrarChequePostFechado":
					frmCCFConsultaChequesPos ofrmChequesPos = new frmCCFConsultaChequesPos();
					ofrmChequesPos.ShowDialog();
					break;
				case "optAutorizacionesCliente":
					frmCCFConsultaAutorizacion ofrmAutorizaciones = new frmCCFConsultaAutorizacion();
					ofrmAutorizaciones.ShowDialog();
					break;
				case "optGuardarDocAnulado":
					frmCCFCreaDocAnulado ofrmCrearDocAnulado = new frmCCFCreaDocAnulado();
					ofrmCrearDocAnulado.ShowDialog();
					break;
				case "optMovimientosCliente":
					frmCCFFiltroReportes ofrmRep = new frmCCFFiltroReportes();
					ofrmRep.iReporte = Unit.CrptMovimientos;
					ofrmRep.gsNombreReporte = "Reporte de Movimientos del Cliente";
					ofrmRep.ShowDialog();
					break;
				case "optDesglosePagoCliente":
					frmCCFFiltroReportes ofrmRep2 = new frmCCFFiltroReportes();
					ofrmRep2.iReporte = Unit.CrptDesglosePagos;
					ofrmRep2.gsNombreReporte = "Reporte Desglose de Pagos";
					ofrmRep2.ShowDialog();
					break;
				case "optDxCCliente":
					frmCCFFiltroReportes ofrmRep3 = new frmCCFFiltroReportes();
					ofrmRep3.iReporte = Unit.CrptDocumentosPorCobrar;
					ofrmRep3.gsNombreReporte = "Reporte Documentos por Cobrar";
					ofrmRep3.ShowDialog();
					break;
				case "optAnalisisVencCliente":
					frmCCFFiltroReportes ofrmRep4 = new frmCCFFiltroReportes();
					ofrmRep4.iReporte = Unit.CrptDocumentosPorCobrar;
					ofrmRep4.gsNombreReporte = "Reporte Análisis de Vencimientos";
					ofrmRep4.ShowDialog();
					break;
				case "optAnalisisVencSucCliente":
					frmCCFFiltroReportes ofrmRep5 = new frmCCFFiltroReportes();
					ofrmRep5.iReporte = Unit.CrptAnalisisVencimientoSucursal;
					ofrmRep5.gsNombreReporte = "Reporte Análisis de Vencimientos";
					ofrmRep5.ShowDialog();
					break;
				case "optCategoriaCliente":
					ofrmOpcionFA.MenuCatCliente();
					break;
				case "optTipoCliente":
					ofrmOpcionFA.MenuTipoCliente();
					break;
				case "optEvaluacionesCliente":
					ofrmOpcionFA.MenuEvalCliente();
					break;
				case "optDepartamentoCliente":
					ofrmOpcionFA.MenuDepartamento();
					break;
				case "optMunicipiosCliente":
					ofrmOpcionFA.MenuMunicipio();
					break;
				case "optZonasCliente":
					ofrmOpcionFA.MenuZona();
					break;
				case "optSubZonaCliente":
					ofrmOpcionFA.MenuSubZona();
					break;
				case "optPlasosCreditoCliente":
					ofrmOpcionFA.MenuPlazos();
					break;
				case "optParametrosCliente":
					break;


			}
		}

		void treeListControlBancario_DoubleClick(object sender, EventArgs e)
		{
			DevExpress.XtraTreeList.Nodes.TreeListNode node = default(DevExpress.XtraTreeList.Nodes.TreeListNode);
			node = ((TreeList)sender).FocusedNode;
			if (node.Tag == null)
				return;
			if (Application.OpenForms[node.Tag.ToString()] != null)
			{
				Application.OpenForms[node.Tag.ToString()].Activate();
				return;
			}
			switch (node.Tag.ToString())
			{
				case "frmListadoBanco":

					ControlBancario.frmListadoBanco ofrmListadoBanco = new ControlBancario.frmListadoBanco();
					ofrmListadoBanco.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmListadoBanco.Show();
					break;
				case "frmTipoCuenta":
					ControlBancario.frmTipoCuenta ofrmListadoTipoCuenta = new frmTipoCuenta();
					ofrmListadoTipoCuenta.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmListadoTipoCuenta.Show();
					break;
				case "frmTipoDocumento":
					ControlBancario.frmTipoDocumento ofrmTipoDocu = new frmTipoDocumento();
					ofrmTipoDocu.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmTipoDocu.Show();
					break;
				case "frmListadoCuentaBancaria":
					ControlBancario.frmListadoCuentaBancaria ofrmListadoCuentaBancaria = new frmListadoCuentaBancaria();
					ofrmListadoCuentaBancaria.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmListadoCuentaBancaria.Show();
					break;
				case "frmListadoSubTipoDocumento":
					ControlBancario.frmListadoSubTipoDocumento ofrmListadoSubTipoDocumento = new frmListadoSubTipoDocumento();
					ofrmListadoSubTipoDocumento.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmListadoSubTipoDocumento.Show();
					break;
				case "frmListadoDocumentosBancarios":
					ControlBancario.frmListadoDocumentosBancarios ofrmCheque = new frmListadoDocumentosBancarios();
					ofrmCheque.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmCheque.Show();
					break;
				case "frmEstadoCuenta":
					ControlBancario.frmEstadoCuenta ofrmEstadoCuenta = new frmEstadoCuenta();
					ofrmEstadoCuenta.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmEstadoCuenta.Show();
					//ControlBancario.frmCheque ofrmCheque = new frmCheque();
					//ofrmCheque.MdiParent = this;
					//ShowPagesRibbonMan(false);
					//ofrmCheque.Show();
					break;
				case "frmNIT":
					ControlBancario.frmRUC ofrmRUC = new ControlBancario.frmRUC();
					ofrmRUC.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmRUC.Show();
					break;
				case "frmListadoConciliacionesBancarias":
					ControlBancario.frmListadoConciliacionesBancarias ofrmConciliacion = new ControlBancario.frmListadoConciliacionesBancarias();
					ofrmConciliacion.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmConciliacion.Show();
					break;
			}
		}


		void treeListTeleVenta_DoubleClick(object sender, EventArgs e)
		{
			DevExpress.XtraTreeList.Nodes.TreeListNode node = default(DevExpress.XtraTreeList.Nodes.TreeListNode);
			node = ((TreeList)sender).FocusedNode;
			if (node.Tag == null)
				return;
			if (Application.OpenForms[node.Tag.ToString()] != null)
			{
				Application.OpenForms[node.Tag.ToString()].Activate();
				return;
			}
			Facturacion.frmtmpMain ofrmMain = new Facturacion.frmtmpMain();
			switch (node.Tag.ToString())
			{
				case "optCrearPedidoTeleventa":
					ofrmMain.MenuCrearPedido();
					break;
				case "optCrearAutorizarPedidoTeleventa":
					ofrmMain.MenuAutorizarPedido();
					break;
				case "optEstadoPedidoTeleventa":
					ofrmMain.MenuEstadoPedido();
					break;

				case "optTipoEntregaTeleventa":
					ofrmMain.MenuTipoEntrega();
					break;
			}
		}

		void treeListFactura_DoubleClick(object sender, EventArgs e)
		{
			DevExpress.XtraTreeList.Nodes.TreeListNode node = default(DevExpress.XtraTreeList.Nodes.TreeListNode);
			node = ((TreeList)sender).FocusedNode;
			if (node.Tag == null)
				return;
			if (Application.OpenForms[node.Tag.ToString()] != null)
			{
				Application.OpenForms[node.Tag.ToString()].Activate();
				return;
			}
			Facturacion.frmtmpMain ofrmMain = new Facturacion.frmtmpMain();
			switch (node.Tag.ToString())
			{

				case "optCrearFactura":
					ofrmMain.MenuFactura();
					break;
				case "optCrearDevolucion":
					ofrmMain.MenuDevolucion();
					break;
				case "optConsultaFacturacion":
					ofrmMain.MenuConsultaFactura();
					break;
				case "optConsultaDevoluciones":
					ofrmMain.MenuConsultaDev();
					break;

				case "optCatalogoTipoFactura":
					ofrmMain.MenuTipoFactura();
					break;
				case "optCatalogoTipoVendedor":
					ofrmMain.MenuTipoVendedor();
					break;
				case "optCatalogoGrupoVendedor":
					ofrmMain.MenuGrupoVendedor();
					break;
				case "optCatalogoVendedores":
					ofrmMain.MenuVendedores();
					break;
				case "optNivelesPrecio":
					ofrmMain.menuNivelPrecio();
					break;
				case "optListaPrecios":
					ofrmMain.MenuListaPrecios();
					break;
				case "optCrearPromocion":
					ofrmMain.MenuPromociones();
					break;
				case "optTablaPromClientes":
					frmPromocionesClientes frm = new frmPromocionesClientes();
					frm.Show();
					break;
				case "optCrearBonificacion":
					ofrmMain.MenuBonificaciones();
					break;
				case "optTablaDesc":
					ofrmMain.MenuTablaDesc();
					break;
				case "optParametrosFA":
					ofrmMain.MenuParametrosFactura();
					break;
				case "optConsecutivosMask":
					ofrmMain.MenuConsecutivMask();
					break;


			}
		}

		void treeListAdministracion_DoubleClick(object sender, EventArgs e)
		{
			DevExpress.XtraTreeList.Nodes.TreeListNode node = default(DevExpress.XtraTreeList.Nodes.TreeListNode);
			node = ((TreeList)sender).FocusedNode;
			if (node.Tag == null)
				return;
			if (Application.OpenForms[node.Tag.ToString()] != null)
			{
				Application.OpenForms[node.Tag.ToString()].Activate();
				return;
			}
			switch (node.Tag.ToString())
			{
				case "frmParametrosGenerales":

					CDTSA.frmParametrosGenerales ofrmParametrosGenerales = new CDTSA.frmParametrosGenerales();
					ofrmParametrosGenerales.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmParametrosGenerales.FormClosed += ofrmParametrosGenerales_FormClosed;
					ofrmParametrosGenerales.Show();
					break;

				case "frmListadoTipoCambio":

					CG.frmListadoTipoCambio ofrmlstTipoCambio = new frmListadoTipoCambio();
					ofrmlstTipoCambio.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmlstTipoCambio.Show();
					break;
				case "frmSubirTipoCambio":
					frmSubirTipoCambio ofrmSubirTipoCambio = new frmSubirTipoCambio();
					ofrmSubirTipoCambio.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmSubirTipoCambio.Show();
					break;

				case "frmPaises":
					frmPaises ofrmPaises = new frmPaises();
					ofrmPaises.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmPaises.Show();
					break;

				case "frmDesigner":

					CDTSA.frmDesigner ofrmReportDesigner = new CDTSA.frmDesigner();
					ShowPagesRibbonMan(false);
					ofrmReportDesigner.Show();
					break;
				case "frmRoles":

					Seguridad.frmRoles ofrmRoles = new Seguridad.frmRoles();
					ShowPagesRibbonMan(false);
					ofrmRoles.Show();
					break;
				case "frmListadoUsuario":
					Seguridad.frmListadoUsuario ofrmListado = new Seguridad.frmListadoUsuario();
					ShowPagesRibbonMan(false);
					ofrmListado.Show();
					break;


			}
		}


		void treeListContabilidad_DoubleClick(object sender, EventArgs e)
		{
			DevExpress.XtraTreeList.Nodes.TreeListNode node = default(DevExpress.XtraTreeList.Nodes.TreeListNode);
			node = ((TreeList)sender).FocusedNode;
			if (node.Tag == null)
				return;
			if (Application.OpenForms[node.Tag.ToString()] != null)
			{
				Application.OpenForms[node.Tag.ToString()].Activate();
				return;
			}
			switch (node.Tag.ToString())
			{
				case "frmListadoCuentaContable":
					frmListadoCuentaContable ofrmCuenta = new frmListadoCuentaContable();
					ofrmCuenta.MdiParent = this;
					ofrmCuenta.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmCuenta.Show();
					break;
				case "frmListadoCentroCosto":
					frmListadoCentroCosto ofrmCentro = new frmListadoCentroCosto();
					ofrmCentro.MdiParent = this;
					ofrmCentro.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmCentro.Show();
					break;
				case "frmListadoAsientoDiario":
					frmListadoAsientoDiario ofrmListadoAsientoDiario = new frmListadoAsientoDiario();
					ofrmListadoAsientoDiario.MdiParent = this;
					ofrmListadoAsientoDiario.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmListadoAsientoDiario.Show();
					break;
				case "frmListadoAsientoMayor":
					frmListadoAsientoMayor ofrmListadoAsientoMayor = new frmListadoAsientoMayor();
					ofrmListadoAsientoMayor.MdiParent = this;
					ofrmListadoAsientoMayor.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmListadoAsientoMayor.Show();
					break;
				case "frmConsultaSaldoCuenta":
					frmConsultaSaldoCuenta ofrmConsultaSaldoCuenta = new frmConsultaSaldoCuenta();
					ofrmConsultaSaldoCuenta.MdiParent = this;
					ofrmConsultaSaldoCuenta.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmConsultaSaldoCuenta.Show();
					break;
				case "frmConsultaSaldoCentro":
					frmConsultaSaldoCentro ofrmConsultaSaldoCentro = new frmConsultaSaldoCentro();
					ofrmConsultaSaldoCentro.MdiParent = this;
					ofrmConsultaSaldoCentro.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmConsultaSaldoCentro.Show();
					break;
				case "frmConsultaLibroMayor":
					frmConsultaLibroMayor ofrmLibroMayor = new frmConsultaLibroMayor();
					ofrmLibroMayor.MdiParent = this;
					ofrmLibroMayor.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmLibroMayor.Show();
					break;
				case "frmConsultaAsientoMayor":
					CG.Consultas.frmConsultasAsientosMayor ofrmConsultasAsientoMayor = new CG.Consultas.frmConsultasAsientosMayor();
					ofrmConsultasAsientoMayor.MdiParent = this;
					ofrmConsultasAsientoMayor.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmConsultasAsientoMayor.Show();
					break;
				case "frmConsultaAsientoDiario":
					CG.Consultas.frmConsultaAsientoDiario ofrmConsultasAsientoDiario = new CG.Consultas.frmConsultaAsientoDiario();
					ofrmConsultasAsientoDiario.MdiParent = this;
					ofrmConsultasAsientoDiario.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmConsultasAsientoDiario.Show();
					break;
				case "frmConsultaDetalleMayor":
					CG.Consultas.frmConsultasDetalleMayor ofrmConsultaDetalleMayor = new CG.Consultas.frmConsultasDetalleMayor();
					ofrmConsultaDetalleMayor.MdiParent = this;
					ofrmConsultaDetalleMayor.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmConsultaDetalleMayor.Show();
					break;
				case "frmConsultaDetalleDiario":
					CG.Consultas.frmConsultaDetalleDiario ofrmConsultaDetalleDiario = new CG.Consultas.frmConsultaDetalleDiario();
					ofrmConsultaDetalleDiario.MdiParent = this;
					ofrmConsultaDetalleDiario.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmConsultaDetalleDiario.Show();
					break;
				case "frmParametrosContables":
					frmParametrosContables ofrmParametrosContabilidad = new frmParametrosContables();
					ofrmParametrosContabilidad.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmParametrosContabilidad.Show();
					break;
				case "frmListadoPeriodos":
					frmListadoPeriodos ofrmListadoPeriodos = new frmListadoPeriodos();
					ofrmListadoPeriodos.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmListadoPeriodos.Show();
					break;
				case "frmGrupoEstadosFinancieros":
					frmGrupoEstadosFinancieros ofrmGrupoEstadosFinancieros = new frmGrupoEstadosFinancieros();
					ofrmGrupoEstadosFinancieros.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmGrupoEstadosFinancieros.Show();
					break;

				case "frmRelacionCuentaGrupoEstadosFinancieros":
					frmRelacionCuentaGrupoEstadosFinancieros ofrmRelacionGrupoEstadosF = new frmRelacionCuentaGrupoEstadosFinancieros();
					ofrmRelacionGrupoEstadosF.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmRelacionGrupoEstadosF.Show();
					break;
				case "frmCreaEjercicio":
					CG.frmCreaEjercicio ofrmCrearEjercicio = new CG.frmCreaEjercicio();
					ofrmCrearEjercicio.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmCrearEjercicio.Show();
					break;

				case "optConsultasDeCentrosDeCostos":
					break;
				case "frmBalanceGeneral":
					frmBalanceGeneral ofrmBalance = new frmBalanceGeneral();
					ofrmBalance.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmBalance.Show();
					break;
				case "frmBalanceComprobacion":
					frmBalanceComprobacion ofrmBalanceComprobacion = new frmBalanceComprobacion();
					ofrmBalanceComprobacion.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmBalanceComprobacion.Show();
					break;
				case "frmEstadoResultado":
					frmEstadoResultado ofrmEstado = new frmEstadoResultado();
					ofrmEstado.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmEstado.Show();
					break;
				case "frmCerrarPeriodo":
					frmCerrarPeriodo ofrmCierre = new frmCerrarPeriodo();
					ofrmCierre.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmCierre.Show();
					break;
				case "frmGenerarDocumentosCierrePeriodoFiscal":
					frmGenerarDocumentosCierrePeriodoFiscal ofrmGenDocCierreFiscal = new frmGenerarDocumentosCierrePeriodoFiscal();
					ofrmGenDocCierreFiscal.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmGenDocCierreFiscal.Show();
					break;
				case "frmTipoAsiento":
					frmTipoAsiento ofrmTipoAsiento = new frmTipoAsiento();
					ofrmTipoAsiento.MdiParent = this;
					ShowPagesRibbonMan(false);
					ofrmTipoAsiento.WindowState = FormWindowState.Maximized;
					ofrmTipoAsiento.Show();
					break;
			}


		}


		private void treeListInventario_DoubleClick(object sender, EventArgs e)
		{

			DevExpress.XtraTreeList.Nodes.TreeListNode node = default(DevExpress.XtraTreeList.Nodes.TreeListNode);
			node = ((TreeList)sender).FocusedNode;
			if (node.Tag == null)
				return;
			switch (node.Tag.ToString())
			{
				case "frmProducto":
					frmListadoProducto ofrmListado = new frmListadoProducto();
					ofrmListado.MdiParent = this;
					ofrmListado.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmListado.Show();
					break;
				case "optArticulo":
					break;
				//Dim ofrm As New UI.Inventario.Form1()
				//ofrm.MdiParent = Me
				//ofrm.WindowState = FormWindowState.Maximized
				//ofrm.Show()
				//ribbonControl.SelectedPage = ofrm.Ribbon.Pages(0) ' ofrm.DefaultPage
				//ShowPagesRibbonMan(False)
				//AddHandler ofrm.FormClosed, AddressOf FomulariosClosed

				//ribbonControl.SelectedPage = ribbonControl.Pages(1)
				case "frmLote":
					frmLote ofrm = new frmLote();
					ofrm.FormClosed += ofrm_FormClosed;
					ofrm.MdiParent = this;
					ofrm.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrm.Show();
					break;
				case "frmDocumentoInv":
					frmListadoDocumentos ofrmListadoDocumento = frmListadoDocumentos.GetForm;
					ofrmListadoDocumento.MdiParent = this;
					ofrmListadoDocumento.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmListadoDocumento.Show();
					break;
				case "frmConsultaArticulo":
					CI.Consultas.frmConsultaArticulo ofrmConsultaArticulo = new CI.Consultas.frmConsultaArticulo();
					ofrmConsultaArticulo.MdiParent = this;
					ofrmConsultaArticulo.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmConsultaArticulo.Show();

					break;
				case "frmConsultaExistenciaBodega":
					frmConsultaExistenciaBodega ofrmConsulta = new frmConsultaExistenciaBodega();
					ofrmConsulta.MdiParent = this;
					ofrmConsulta.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmConsulta.Show();
					break;
				case "frmConsultaTransacciones":
					frmConsultaTransacciones ofrmConTran = new frmConsultaTransacciones();
					ofrmConTran.MdiParent = this;
					ofrmConTran.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmConTran.Show();
					break;
				case "frmConsecutivos":
					frmConsecutivos ofrmConsecutivos = new frmConsecutivos();
					ofrmConsecutivos.MdiParent = this;
					ofrmConsecutivos.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmConsecutivos.Show();
					break;
				case "frmPaquetes":
					frmPaquetes ofrmPaquete = new frmPaquetes();
					ofrmPaquete.MdiParent = this;
					ofrmPaquete.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmPaquete.Show();

					break;
				case "frmInvCuentaContable":
					frmInvCuentaContable ofrmCuentas = new frmInvCuentaContable();
					ofrmCuentas.MdiParent = this;
					ofrmCuentas.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmCuentas.Show();
					break;
				case "frmCatalogoClasificaciones":
					frmCatalogoClasificaciones ofrmClasificaciones = new frmCatalogoClasificaciones();
					ofrmClasificaciones.MdiParent = this;
					ofrmClasificaciones.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmClasificaciones.Show();
					break;
				case "frmBodegas":
					frmBodegas ofrmBodega = new frmBodegas();
					ofrmBodega.MdiParent = this;
					ofrmBodega.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmBodega.Show();
					break;
				case "frmBoleta":
					CI.Fisico.frmBoleta ofrmBoleta = new CI.Fisico.frmBoleta();
					ofrmBoleta.MdiParent = this;
					ofrmBoleta.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmBoleta.Show();
					break;
				case "frmSaldosInventario":
					CI.Consultas.frmSaldosInventario ofrmSaldos = new CI.Consultas.frmSaldosInventario();
					ofrmSaldos.MdiParent = this;
					ofrmSaldos.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmSaldos.Show();
					break;

				case "frmUnidadMedida":
					CI.frmUnidadMedida ofrmUnidad = new CI.frmUnidadMedida();
					ofrmUnidad.MdiParent = this;
					ofrmUnidad.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmUnidad.Show();
					break;
				case "frmRemision":
					Facturacion.frmRemisionBodega ofrmRemision = new frmRemisionBodega();
					ofrmRemision.MdiParent = this;
					ofrmRemision.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmRemision.Show();
					break;
			}

		}


		private void treelstCompras_DoubleClick(object sender, EventArgs e)
		{

			DevExpress.XtraTreeList.Nodes.TreeListNode node = default(DevExpress.XtraTreeList.Nodes.TreeListNode);
			node = ((TreeList)sender).FocusedNode;
			if (node.Tag == null)
				return;
			switch (node.Tag.ToString())
			{
				case "frmSolicitudCompra":
					frmListdoSolicitudCompra ofrmLisatoSolicitud = new frmListdoSolicitudCompra();
					ofrmLisatoSolicitud.MdiParent = this;
					ofrmLisatoSolicitud.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmLisatoSolicitud.Show();
					break;

				case "frmListadoOrdenesCompra":
					frmListadoOrdenCompra ofrmListadoOrdenCompra = new frmListadoOrdenCompra();
					ofrmListadoOrdenCompra.MdiParent = this;
					ofrmListadoOrdenCompra.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmListadoOrdenCompra.Show();
					break;

				case "frmListadoEmbarque":
					frmListadoEmbarque ofrmEmbarque = new frmListadoEmbarque();   //(1,-1,"Add");
					ofrmEmbarque.MdiParent = this;
					ofrmEmbarque.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmEmbarque.Show();
					break;
				case "frmListadoProveedores":
					frmListadoProveedores ofrmListadoProveedor = new frmListadoProveedores();
					ofrmListadoProveedor.MdiParent = this;
					ofrmListadoProveedor.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmListadoProveedor.Show();
					break;
				case "frmParametrosCompra":
					frmParametros ofrmParametros = new frmParametros();
					ofrmParametros.MdiParent = this;
					ofrmParametros.WindowState = FormWindowState.Normal;
					ShowPagesRibbonMan(false);
					ofrmParametros.Show();
					break;
				case "frmGastosCompra":
					frmGastosCompra ofrmGastosCompra = new frmGastosCompra();
					ofrmGastosCompra.MdiParent = this;
					ofrmGastosCompra.WindowState = FormWindowState.Normal;
					ShowPagesRibbonMan(false);
					ofrmGastosCompra.Show();
					break;
			}

		}

		private void treelstCuentasPorPagar_DoubleClick(object sender, EventArgs e)
		{
			DevExpress.XtraTreeList.Nodes.TreeListNode node = default(DevExpress.XtraTreeList.Nodes.TreeListNode);
			node = ((TreeList)sender).FocusedNode;
			if (node.Tag == null)
				return;
			switch (node.Tag.ToString())
			{
				case "frmCPConsultaDocs":
					CP.frmCPConsultaDocs ofrmDoc = new CP.frmCPConsultaDocs();
					ofrmDoc.MdiParent = this;
					ofrmDoc.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmDoc.Show();
					break;
				case "frmListadoProveedores":
					CO.frmListadoProveedores ofrmLstProveedores = new frmListadoProveedores();
					ofrmLstProveedores.MdiParent = this;
					ofrmLstProveedores.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmLstProveedores.Show();
					break;
				case "frmCPMovimientosProveedor":
					CP.frmCPFiltroReportes ofrmReporteMovimientos = new CP.frmCPFiltroReportes();
					ofrmReporteMovimientos.iReporte = Unit.CrptMovimientos;
					ofrmReporteMovimientos.gsNombreReporte = "Reporte de Movimientos del Proveedor";
					ofrmReporteMovimientos.ShowDialog();
					break;
				case "frmCPReportesDesglosePago":
					CP.frmCPFiltroReportes ofrmReporteDesglosePago = new CP.frmCPFiltroReportes();
					ofrmReporteDesglosePago.iReporte = Unit.CrptDesglosePagos;
					ofrmReporteDesglosePago.gsNombreReporte = "Reporte de Desglose de Pagos";
					ofrmReporteDesglosePago.ShowDialog();
					break;
				case "frmCPReportesDocXPagar":
					CP.frmCPFiltroReportes ofrmReporteDocxPagar = new CP.frmCPFiltroReportes();
					ofrmReporteDocxPagar.iReporte = Unit.CrptDesglosePagos;
					ofrmReporteDocxPagar.gsNombreReporte = "Reporte de Documento por Pagar";
					ofrmReporteDocxPagar.ShowDialog();
					break;
				case "frmCPFiltroReportesAnalisisVencimientoProv":
					CP.frmCPFiltroReportes ofrmFiltroRep4 = new CP.frmCPFiltroReportes();
					ofrmFiltroRep4.MdiParent = this;
					ofrmFiltroRep4.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmFiltroRep4.iReporte = CP.Unitbk.CrptAnalisisVencimiento;
					ofrmFiltroRep4.gsNombreReporte = "Reporte Analisis de Vencimientos por Proveedor";
					ofrmFiltroRep4.Show();
					break;
				case "frmCategoriaProveedor":
					CP.frmCategoriaProveedor ofrmCategoriaProveedor = new CP.frmCategoriaProveedor();
					ofrmCategoriaProveedor.MdiParent = this;
					ofrmCategoriaProveedor.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmCategoriaProveedor.Show();
					break;

				case "frmCondicionPago":
					CO.frmCondicionesDePago ofrmCondicionPago = new CO.frmCondicionesDePago();
					ofrmCondicionPago.MdiParent = this;
					ofrmCondicionPago.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmCondicionPago.Show();

					break;
				case "frmListadoRetenciones":
					CO.frmListadoRetenciones ofrmRetenciones = new CO.frmListadoRetenciones();
					ofrmRetenciones.MdiParent = this;
					ofrmRetenciones.WindowState = FormWindowState.Maximized;
					ShowPagesRibbonMan(false);
					ofrmRetenciones.Show();
					break;



			}

		}

		#endregion


		void ofrmTipoCambio_FormClosing(object sender, FormClosingEventArgs e)
		{
			CargarParametrosSistema();
			if (StatusError == "On")
				e.Cancel = true;
			else
				e.Cancel = false;

		}

        void ofrmTipoCambio_FormClosed(object sender, FormClosedEventArgs e)
        {
			((frmTipoCambioDetalle)sender).FormClosed -= ofrmTipoCambio_FormClosed;
            CargarParametrosSistema();
			
        }

        private void SetNodeDisable(String Tag, DevExpress.XtraTreeList.TreeList tree)
        {
            try
            {
                foreach (TreeListNode node in tree.Nodes)
                    if (node.Tag != null && node.Tag.ToString() == Tag)
                        node.Visible = false;
                //                node.TreeList.ForeColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ofrmParametrosGenerales_FormClosed(object sender, FormClosedEventArgs e)
        {
			CDTSA.frmParametrosGenerales ofrmParametros = (CDTSA.frmParametrosGenerales)sender;
			ofrmParametros.FormClosed -= ofrmParametrosGenerales_FormClosed; 
            //Recargar los parametros del sistema
            CargarParametrosSistema();
        }

		private TreeListNode addNodeToTree(TreeList treeList,String Descripcion, String Tag, int ParentNode) {
			bool isFolder = (Tag == "" );
			TreeListNode nodeTree = !(isFolder ) ? treeList.AppendNode(new object[] { Descripcion }, ParentNode, 11, 11, 11) : treeList.AppendNode(new object[] { Descripcion }, ParentNode, 9, 10, 9);
			nodeTree.Tag = Tag;
			return nodeTree;
		}

        private void ShowPagesRibbonMan(bool valor)
        {
            this.ribbonHelp.Visible = valor;
        }
  
        void ofrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPagesRibbonMan(true);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

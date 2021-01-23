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

        

        private void CargarImagenFondo()
        {
            this.BackgroundImage = (Security.Esquema.Compania == "CEDETSA") ? Resources.CEDETSA : Resources.DASA;
            this.BackgroundImageLayout = ImageLayout.Center;
        }

		private void InicializarControles() 
		{
			this.lblFecha.Caption = "Fecha: --";
			this.lblTipoCambio.Caption = "TC: --";
			this.lblCompania.Caption = "Compañia: ";
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

        private void CargarConfiguracionRegional()
        {
			CultureInfo newCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
			newCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
			newCulture.DateTimeFormat.DateSeparator = "/";
            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture; // new System.Globalization.CultureInfo("en-US");

        }

        private void ObtenerTipoCambio(String TipoCambio)
        {
            DataSet DS = CDTSA.DAC.ParametrosGeneralesDAC.GetTipoCambio(TipoCambio, DateTime.Now);
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                this.lblFecha.Caption = "Fecha: " + Convert.ToDateTime(DS.Tables[0].Rows[0]["Fecha"]).ToShortDateString();
                this.lblTipoCambio.Caption = "TC: " + Convert.ToDecimal(DS.Tables[0].Rows[0]["Monto"]).ToString("N4");

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
                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm.GetType() == typeof(CG.frmTipoCambioDetalle))
                        {
                            // MessageBox.Show("El formulario 2 esta abierto");
                            break;
                        }
                    }
                    CG.frmTipoCambioDetalle ofrmTipoCambio = new frmTipoCambioDetalle(CodTipoCambio, "");
                    ofrmTipoCambio.FormClosed += ofrmTipoCambio_FormClosed;
                    ofrmTipoCambio.MdiParent = this;
                    ofrmTipoCambio.StartPosition = FormStartPosition.CenterScreen;
                    ofrmTipoCambio.Show();
                }
                else
                    MessageBox.Show("El tipo de cambio para el día no esta registrado, por favor contacte el administrador del sistema. \n\r ");
                this.treeListContabilidad.DoubleClick -= treeListContabilidad_DoubleClick;
            }
        }

        void ofrmTipoCambio_FormClosed(object sender, FormClosedEventArgs e)
        {

            CargarParametrosSistema();
        }

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
					//ofrmDetalles.gsFormDetalleName = "CLIENTE";
					//ofrmDetalles.gsCaptionFrm = "Clientes";
					//ofrmDetalles.gsTableName = "ccfClientes";
					//ofrmDetalles.gsCodeName = "IDCliente";
					//ofrmDetalles.gbCodeNumeric = true;
					//ofrmDetalles.gsDescrName = "Nombre";
					//ofrmDetalles.gsFieldsRest = "Activo";
					//ofrmDetalles.gsOrder = "IDCliente";
					//ofrmDetalles.MdiParent = this;
					//ShowPagesRibbonMan(false);
					//ofrmDetalles.Show();
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

		private void SetUsuarioIntegracionModulos(String sUsuario){
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
            DS = UsuarioDAC.GetAccionModuloFromRole(0,sUsuario);
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

        void ofrmParametrosGenerales_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Recargar los parametros del sistema
            CargarParametrosSistema();
        }


// SeccionMenu
        private void CreateNodes(TreeList tl)
        {
            tl.BeginUnboundLoad();
            // Create a child node for the node1
            switch (tl.Name)
            {
                case "treeListInventario":
                    TreeListNode nodeArticulo = tl.AppendNode(new object[] { "Artículo" }, -1, 11, 11, 11);
                    nodeArticulo.Tag = "frmProducto";

                    TreeListNode nodeLotes = tl.AppendNode(new object[] { "Lotes" }, -1, 11, 11, 11);
                    nodeLotes.Tag = "frmLote";
                    TreeListNode nodeTransacciones = tl.AppendNode(new object[] { "Transacciones" }, -1, 9, 10, 9);
                    TreeListNode nodeEjemplo = tl.AppendNode(new object[] { "Documentos" }, nodeTransacciones.Id, 11, 11, 11);
                    nodeEjemplo.Tag = "frmDocumentoInv";
                    TreeListNode nodeConsultas = tl.AppendNode(new object[] { "Consultas" }, -1, 9, 10, 9);
                    TreeListNode nodeConsultaArticulos = tl.AppendNode(new object[] { "Artículos" }, nodeConsultas.Id, 11, 11, 11);
                    nodeConsultaArticulos.Tag = "frmConsultaArticulo";
                    TreeListNode nodeConsultaExistenciasBodega = tl.AppendNode(new object[] { "Bodega" }, nodeConsultas.Id, 11, 11, 11);
                    nodeConsultaExistenciasBodega.Tag = "frmConsultaExistenciaBodega";
                    TreeListNode nodeConsultaTransacciones = tl.AppendNode(new object[] { "Transacciones" }, nodeConsultas.Id, 11, 11, 11);
                    nodeConsultaTransacciones.Tag = "frmConsultaTransacciones";
                    TreeListNode nodeSaldosInventario = tl.AppendNode(new object[] { "Saldos" }, nodeConsultas.Id, 11, 11, 11);
                    nodeSaldosInventario.Tag = "frmSaldosInventario";
                    
                    TreeListNode nodeReportes = tl.AppendNode(new object[] { "Reportes" }, -1, 9, 10, 9);
                    
                    TreeListNode nodeProcesos = tl.AppendNode(new object[] { "Processos" }, -1, 9, 10, 9);
                    TreeListNode nodeBoletaInventario = tl.AppendNode(new object[] { "Boleta Inventario" }, nodeProcesos.Id, 11, 11, 11);
                    nodeBoletaInventario.Tag = "frmBoleta";

                    TreeListNode nodeAdministracion = tl.AppendNode(new object[] { "Administración" }, -1, 9, 10, 9);
                    TreeListNode nodeConsecutivos = tl.AppendNode(new object[] { "Consecutivos" }, nodeAdministracion.Id, 11, 11, 11);
                    nodeConsecutivos.Tag = "frmConsecutivos";
                    TreeListNode nodeClasificaciones = tl.AppendNode(new object[] { "Clasificaciones" }, nodeAdministracion.Id, 11, 11, 11);
                    nodeClasificaciones.Tag = "frmCatalogoClasificaciones";
                    TreeListNode nodeUnidadesMedida = tl.AppendNode(new object[] { "Unidades de Medida" }, nodeAdministracion.Id, 11, 11, 11);
                    nodeUnidadesMedida.Tag = "frmUnidadMedida";
                    TreeListNode nodePaquetes = tl.AppendNode(new object[] { "Paquetes" }, nodeAdministracion.Id, 11, 11, 11);
                    nodePaquetes.Tag = "frmPaquetes";
                    TreeListNode nodeCuentasContables = tl.AppendNode(new object[] { "Cuentas Contables" }, nodeAdministracion.Id, 11, 11, 11);
                    nodeCuentasContables.Tag = "frmInvCuentaContable";
                    TreeListNode nodeBodegas = tl.AppendNode(new object[] { "Bodegas" }, nodeAdministracion.Id, 11, 11, 11);
                    nodeBodegas.Tag = "frmBodegas";
                    break;
                case "treeListAdministracion":
                    TreeListNode nodeTipos = tl.AppendNode(new object[] { "Catálogos" }, -1, 9, 10, 9);
                    TreeListNode nodeTiposCambio = tl.AppendNode(new object[] { "Tipos de Cambio" }, nodeTipos.Id, 11, 11, 11);
                    nodeTiposCambio.Tag = "frmListadoTipoCambio";
                    TreeListNode nodeSubirTiposCambio = tl.AppendNode(new object[] { "Subir Tipos de Cambio" }, nodeTipos.Id, 11, 11, 11);
                    nodeSubirTiposCambio.Tag = "frmSubirTipoCambio";
                    TreeListNode nodeParametros = tl.AppendNode(new object[] { "Parametros Generales" }, -1, 11, 11, 11);
                    nodeParametros.Tag = "frmParametrosGenerales";
										TreeListNode nodePaises = tl.AppendNode(new object[] { "Paises" }, -1, 11, 11, 11);
										nodePaises.Tag = "frmPaises";
                    TreeListNode nodeReportDesigner = tl.AppendNode(new object[] { "Diseñador de Reportes" }, -1, 11, 11, 11);
                    nodeReportDesigner.Tag = "frmDesigner";

					TreeListNode nodeSeguridad = tl.AppendNode(new object[] { "Seguridad" }, -1, 9, 10, 9);
					TreeListNode nodeRolesUsuario = tl.AppendNode(new object[] { "Roles" }, nodeSeguridad.Id, 11, 11, 11);
					nodeRolesUsuario.Tag = "frmRoles";

					TreeListNode nodeListadoUsuario = tl.AppendNode(new object[] { "Usuarios" }, nodeSeguridad.Id, 11, 11, 11);
					nodeListadoUsuario.Tag = "frmListadoUsuario";

                    break;
                case "treeListControlBancario":
                    TreeListNode nodeCatalogoBanco = tl.AppendNode(new object[] { "Catálogos" }, -1, 9, 10, 9);
                    TreeListNode nodeTipoCuenta = tl.AppendNode(new object[] { "Tipo Cuenta" }, nodeCatalogoBanco.Id, 11, 11, 11);
                    nodeTipoCuenta.Tag = "frmTipoCuenta";
                    TreeListNode nodeTipoDocumento = tl.AppendNode(new object[] { "Tipo Documento" }, nodeCatalogoBanco.Id, 11, 11, 11);
                    nodeTipoDocumento.Tag = "frmTipoDocumento";
                    TreeListNode nodeListadoBanco= tl.AppendNode(new object[] { "Bancos" }, nodeCatalogoBanco.Id, 11, 11, 11);
                    nodeListadoBanco.Tag = "frmListadoBanco";
                    TreeListNode nodeListadoSubTipoDocumento = tl.AppendNode(new object[] { "Sub Tipo Documento" }, nodeCatalogoBanco.Id, 11, 11, 11);
                    nodeListadoSubTipoDocumento.Tag = "frmListadoSubTipoDocumento";
                    TreeListNode nodeListadoCuentaBancaria = tl.AppendNode(new object[] { "Cuentas Bancarias" }, nodeCatalogoBanco.Id, 11, 11, 11);
                    nodeListadoCuentaBancaria.Tag = "frmListadoCuentaBancaria";
                    TreeListNode nodeDocumentos = tl.AppendNode(new object[] { "Documentos" }, -1, 9, 10, 9);
                    TreeListNode nodeCheques = tl.AppendNode(new object[] { "Listado de Documentos" }, nodeDocumentos.Id, 11, 11, 11);
                    nodeCheques.Tag = "frmListadoDocumentosBancarios";
                    TreeListNode nodeNit = tl.AppendNode(new object[] { "Nit" }, nodeDocumentos.Id, 11, 11, 11);
                    nodeNit.Tag = "frmNIT";
					TreeListNode nodeProcesosBanco = tl.AppendNode(new object[] { "Procesos" }, -1, 9, 10, 9);
					TreeListNode nodeConciliacion = tl.AppendNode(new object[] { "Conciliación Bancaria" }, nodeProcesosBanco.Id, 11, 11, 11);
					nodeConciliacion.Tag = "frmListadoConciliacionesBancarias";

                    

                    break;
                case "treelstCompras":
                    //TreeListNode nodeSolicitudCompra = tl.AppendNode(new object[] { "Solicitudes de Compra" }, -1, 11, 11, 11);
                    //nodeSolicitudCompra.Tag = "frmSolicitudCompra";
                    
                    TreeListNode nodeProveedores = tl.AppendNode(new object[] { "Proveedores" }, -1, 11, 11, 11);
                    nodeProveedores.Tag = "frmListadoProveedores";
                    TreeListNode nodeTransaccionesCompra = tl.AppendNode(new object[] { "Transacciones" }, -1, 9, 10, 9);
                    TreeListNode nodeListdoOrdenCompra = tl.AppendNode(new object[] { "Ordenes de Compra" }, nodeTransaccionesCompra.Id, 11, 11, 11);
                    nodeListdoOrdenCompra.Tag = "frmListadoOrdenesCompra";
                    TreeListNode nodeEmbarques = tl.AppendNode(new object[] { "Embarques" }, nodeTransaccionesCompra.Id, 11, 11, 11);
                    nodeEmbarques.Tag = "frmListadoEmbarque";
                    TreeListNode nodeParametrosCO= tl.AppendNode(new object[] { "Parámetros" }, -1, 9, 10, 9);
                    TreeListNode nodeParametrosCompra = tl.AppendNode(new object[] { "Parametros Compra" }, nodeParametrosCO.Id, 11, 11, 11);
                    nodeParametrosCompra.Tag = "frmParametrosCompra";
					TreeListNode nodeGastosCompra = tl.AppendNode(new object[] { "Gastos de Compra" }, nodeParametrosCO.Id, 11, 11, 11);
					nodeGastosCompra.Tag = "frmGastosCompra";
					                                              
                    break;

                case "treelstCuentasPorPagar":

                    TreeListNode nodeDocumentosCP = tl.AppendNode(new object[] { "Transacciones" }, -1, 11, 11, 11);
					nodeDocumentosCP.Tag = "frmCPConsultaDocs";

					TreeListNode nodeProveedoresCP = tl.AppendNode(new object[] { "Proveedores" }, -1, 11, 11, 11);
					nodeProveedoresCP.Tag = "frmListadoProveedores";
                    

					//Carpeta
					TreeListNode nodeReportesCP = tl.AppendNode(new object[] { "Reportes" }, -1, 9, 10, 9);
					TreeListNode nodeMoviProveedor = tl.AppendNode(new object[] { "Movimentos del Proveedor" }, nodeReportesCP.Id, 11, 11, 11);
					nodeMoviProveedor.Tag = "frmCPMovimientosProveedor";

					TreeListNode nodeDesglosePago = tl.AppendNode(new object[] { "Desglose de Pago" }, nodeReportesCP.Id, 11, 11, 11);
					nodeDesglosePago.Tag = "frmCPReportesDesglosePago";

					TreeListNode nodeDocxPagar = tl.AppendNode(new object[] { "Documentos por Pagar" }, nodeReportesCP.Id, 11, 11, 11);
					nodeDocxPagar.Tag = "frmCPReportesDocXPagar";

					TreeListNode nodeAnalisisVencPro = tl.AppendNode(new object[] { "Análisis de Vencimiento" }, nodeReportesCP.Id, 11, 11, 11);
					nodeAnalisisVencPro.Tag = "frmCPReportesAnalisisVencimientoProv";


					TreeListNode nodeCatalogosCP = tl.AppendNode(new object[] { "Catálogos" }, -1, 9, 10, 9);
					TreeListNode nodeCondicionPago = tl.AppendNode(new object[] { "Condición de Pago" }, nodeCatalogosCP.Id, 11, 11, 11);
					nodeCondicionPago.Tag = "frmCondicionPago";


					TreeListNode nodeCategoriaProveedor = tl.AppendNode(new object[] { "Categoria Proveedor" }, nodeCatalogosCP.Id, 11, 11, 11);
					nodeCategoriaProveedor.Tag = "frmCategoriaProveedor";

					TreeListNode nodeRetenciones = tl.AppendNode(new object[] { "Catálogo de Retenciones" }, nodeCatalogosCP.Id, 11, 11, 11);
					nodeRetenciones.Tag = "frmListadoRetenciones";

					
					TreeListNode nodeParametrosCP = tl.AppendNode(new object[] { "Parámetros" }, -1, 11, 11, 11);
					nodeParametrosCP.Tag = "frmParametrosCP";
                   
                    break;
				case "treeListTeleventa":
					TreeListNode nodePedidos = tl.AppendNode(new object[] { "Televentas" }, -1, 9, 10, 9);
					TreeListNode nodeCrearPedido = tl.AppendNode(new object[] { "Crear Pedido" }, nodePedidos.Id, 11, 11, 11);
					nodeCrearPedido.Tag = "optCrearPedidoTeleventa";

					TreeListNode nodeAutorizaPedido = tl.AppendNode(new object[] { "Autorizar Pedido" }, nodePedidos.Id, 11, 11, 11);
					nodeAutorizaPedido.Tag = "optCrearAutorizarPedidoTeleventa";

					TreeListNode nodeCatalogoTeleventas = tl.AppendNode(new object[] { "Catalogos" },-1, 9, 10, 9);
					TreeListNode nodeEstadoPedidoTeleventa = tl.AppendNode(new object[] { "Estado Pedido" }, nodeCatalogoTeleventas.Id, 11, 11, 11);
					nodeEstadoPedidoTeleventa.Tag = "optEstadoPedidoTeleventa";

					TreeListNode nodeTipoEntregaTeleventa = tl.AppendNode(new object[] { "Tipo Entrega" }, nodeCatalogoTeleventas.Id, 11, 11, 11);
					nodeTipoEntregaTeleventa.Tag = "optTipoEntregaTeleventa";

					break;
				case "treeListCuentasXCobrar":				

					TreeListNode nodeRegistrarCliente = tl.AppendNode(new object[] { "Registrar Cliente" }, -1, 11, 11, 11);
					nodeRegistrarCliente.Tag = "optRegistrarCliente";

					TreeListNode nodeTransaccionesCliente = tl.AppendNode(new object[] { "Transacciones" }, -1, 9, 10, 9);
					TreeListNode nodeRegistrarTranCliente = tl.AppendNode(new object[] { "Transacciones" }, nodeTransaccionesCliente.Id, 11, 11, 11);
					nodeRegistrarTranCliente.Tag = "optRegistrarTranCliente";

					TreeListNode nodeRecibosCaja= tl.AppendNode(new object[] { "Recibos de Caja" }, nodeTransaccionesCliente.Id, 11, 11, 11);
					nodeRecibosCaja.Tag = "optRecibosCaja";

					TreeListNode nodeRegistrarChequePostFechado = tl.AppendNode(new object[] { "Cheques PostFechados" }, nodeTransaccionesCliente.Id, 11, 11, 11);
					nodeRegistrarChequePostFechado.Tag = "optRegistrarChequePostFechado";

					TreeListNode nodeProcesosCliente = tl.AppendNode(new object[] { "Procesos" }, -1, 9, 10, 9);
					TreeListNode nodeAutorizacionesCliente = tl.AppendNode(new object[] { "Autorizaciones" }, nodeProcesosCliente.Id, 11, 11, 11);
					nodeAutorizacionesCliente.Tag = "optAutorizacionesCliente";


					TreeListNode nodeGuardarDocAnulado = tl.AppendNode(new object[] { "Grabar Doc Anulado" }, nodeProcesosCliente.Id, 11, 11, 11);
					nodeGuardarDocAnulado.Tag = "optGuardarDocAnulado";


					TreeListNode nodeReportesCliente = tl.AppendNode(new object[] { "Reportes" }, -1, 9, 10, 9);
					TreeListNode nodeMoviCliente = tl.AppendNode(new object[] { "Movimientos del Cliente" }, nodeReportesCliente.Id, 11, 11, 11);
					nodeMoviCliente.Tag = "optMovimientosCliente";

					TreeListNode nodeDesglosePagoCliente = tl.AppendNode(new object[] { "Desglose de Pagos" }, nodeReportesCliente.Id, 11, 11, 11);
					nodeDesglosePagoCliente.Tag = "optDesglosePagoCliente";

					TreeListNode nodeDocXCobrCliente = tl.AppendNode(new object[] { "Documentos por cobrar" }, nodeReportesCliente.Id, 11, 11, 11);
					nodeDocXCobrCliente.Tag = "optDxCCliente";

					TreeListNode nodeAnalisisVencimientoCliente = tl.AppendNode(new object[] { "Análisis de Vencimiento" }, nodeReportesCliente.Id, 11, 11, 11);
					nodeAnalisisVencimientoCliente.Tag = "optAnalisisVencCliente";

					TreeListNode nodeAnalisisVencSucCliente = tl.AppendNode(new object[] { "Análisis de Vencimiento por Sucursal" }, nodeReportesCliente.Id, 11, 11, 11);
					nodeAnalisisVencSucCliente.Tag = "optAnalisisVencSucCliente";



					

					TreeListNode nodeCatalogos = tl.AppendNode(new object[] { "Catálogos" }, -1, 9, 10, 9);
					TreeListNode nodeCategoriaCliente = tl.AppendNode(new object[] { "Categoria de Clientes" }, nodeCatalogos.Id, 11, 11, 11);
					nodeCategoriaCliente.Tag = "optCategoriaCliente";

					TreeListNode nodeTipoCliente = tl.AppendNode(new object[] { "Tipo Clientes" }, nodeCatalogos.Id, 11, 11, 11);
					nodeTipoCliente.Tag = "optTipoCliente";

					TreeListNode nodeEvaluacionesCliente = tl.AppendNode(new object[] { "Evaluaciones de Clientes" }, nodeCatalogos.Id, 11, 11, 11);
					nodeEvaluacionesCliente.Tag = "optEvaluacionesCliente";

					TreeListNode nodeDepartamentoCliente = tl.AppendNode(new object[] { "Departamento" }, nodeCatalogos.Id, 11, 11, 11);
					nodeDepartamentoCliente.Tag = "optDepartamentoCliente";

					TreeListNode nodeMunicipiosCliente = tl.AppendNode(new object[] { "Municipios" }, nodeCatalogos.Id, 11, 11, 11);
					nodeMunicipiosCliente.Tag = "optMunicipiosCliente";
					TreeListNode nodeZonasCliente = tl.AppendNode(new object[] { "Zonas" }, nodeCatalogos.Id, 11, 11, 11);
					nodeZonasCliente.Tag = "optZonasCliente";
					TreeListNode nodeSubZonaCliente = tl.AppendNode(new object[] { "Sub Zonas" }, nodeCatalogos.Id, 11, 11, 11);
					nodeSubZonaCliente.Tag = "optSubZonaCliente";

					TreeListNode nodePlazosCreditoCliente = tl.AppendNode(new object[] { "Plazos de Credito" }, nodeCatalogos.Id, 11, 11, 11);
					nodePlazosCreditoCliente.Tag = "optPlasosCreditoCliente";

					TreeListNode nodeParametrosCliente = tl.AppendNode(new object[] { "Paremetros" }, -1, 11, 11, 11);
					nodeParametrosCliente.Tag = "optParametrosCliente";

					
					
					break;

                case "treeListFactura":
					

					TreeListNode nodeFactura = tl.AppendNode(new object[] { "Facturación" }, -1, 9, 10, 9);
					TreeListNode nodeCrearFactura= tl.AppendNode(new object[] { "Crear Factura" }, nodeFactura.Id, 11, 11, 11);
					nodeCrearFactura.Tag = "optCrearFactura";

					TreeListNode nodeConsultasFactura = tl.AppendNode(new object[] { "Consultas" }, nodeFactura.Id, 9, 10, 9);
					TreeListNode nodeConsultaFacturacion = tl.AppendNode(new object[] { "Facturación" }, nodeConsultasFactura.Id, 11, 11, 11);
					nodeConsultaFacturacion.Tag = "optConsultaFacturacion";

					TreeListNode nodeConsultaDevolucion = tl.AppendNode(new object[] { "Devoluciones" }, nodeConsultasFactura.Id, 11, 11, 11);
					nodeConsultaDevolucion.Tag = "optConsultaDevoluciones";

					TreeListNode nodeCatalogosFactura = tl.AppendNode(new object[] { "Catalogos" }, nodeFactura.Id, 9, 10, 9);
					TreeListNode nodeCatalogoTipoFactura = tl.AppendNode(new object[] { "Tipo Factura" }, nodeCatalogosFactura.Id, 11, 11, 11);
					nodeCatalogoTipoFactura.Tag = "optCatalogoTipoFactura";

					TreeListNode nodeCatalogoTipoVendor = tl.AppendNode(new object[] { "Tipo Vendedor" }, nodeCatalogosFactura.Id, 11, 11, 11);
					nodeCatalogoTipoVendor.Tag = "optCatalogoTipoVendedor";

					TreeListNode nodeCatalogoGrupoVendor = tl.AppendNode(new object[] { "Grupo Vendedor" }, nodeCatalogosFactura.Id, 11, 11, 11);
					nodeCatalogoGrupoVendor.Tag = "optCatalogoGrupoVendedor";

					TreeListNode nodeCatalogoVendedores = tl.AppendNode(new object[] { "Vendedores" }, nodeCatalogosFactura.Id, 11, 11, 11);
					nodeCatalogoVendedores.Tag = "optCatalogoVendedores";
					

					TreeListNode nodePrecios = tl.AppendNode(new object[] { "Precios" }, -1, 9, 10, 9);

					TreeListNode nodeNivelPrecio = tl.AppendNode(new object[] { "Niveles de Precios" }, nodePrecios.Id, 11, 11, 11);
					nodeNivelPrecio.Tag = "optNivelesPrecio";

					TreeListNode nodeListaPrecio = tl.AppendNode(new object[] { "Lista de Precios" }, nodePrecios.Id, 11, 11, 11);
					nodeListaPrecio.Tag = "optListaPrecios";


					TreeListNode nodePromociones = tl.AppendNode(new object[] { "Promociones" }, -1, 9, 10, 9);

					TreeListNode nodeCreaPromocion = tl.AppendNode(new object[] { "Crear Promoción" }, nodePromociones.Id, 11, 11, 11);
					nodeCreaPromocion.Tag = "optCrearPromocion";

					TreeListNode nodeCrearBonificaciones = tl.AppendNode(new object[] { "Crear Bonificaciones" }, nodePromociones.Id, 11, 11, 11);
					nodeCrearBonificaciones.Tag = "optCrearBonificacion";

					TreeListNode nodeTablaDesc = tl.AppendNode(new object[] { "Tabla de Descuentos" }, nodePromociones.Id, 11, 11, 11);
					nodeTablaDesc.Tag = "optTablaDesc";


					TreeListNode nodeParametrosFactura = tl.AppendNode(new object[] { "Parámetros" }, -1, 9, 10, 9);

					TreeListNode nodeParametrosFA = tl.AppendNode(new object[] { "Parámetros Facturación" }, nodeParametrosFactura.Id, 11, 11, 11);
					nodeParametrosFA.Tag = "optParametrosFA";

					TreeListNode nodeConsecutivosMask = tl.AppendNode(new object[] { "Consecutivos" }, nodeParametrosFactura.Id, 11, 11, 11);
					nodeConsecutivosMask.Tag = "optConsecutivosMask";

					

					


					//TreeListNode nodeDepartamento = tl.AppendNode(new object[] { "Departamento" }, -1, 11, 11, 11);
					//nodeDepartamento.Tag = "optDepartamento";
					//TreeListNode nodeMunicipio = tl.AppendNode(new object[] { "Municipio" }, -1, 11, 11, 11);
					//nodeMunicipio.Tag = "optMunicipio";
					//TreeListNode nodeZona = tl.AppendNode(new object[] { "Zona" }, -1, 11, 11, 11);
					//nodeZona.Tag = "optZona";
					//TreeListNode nodeSubZona = tl.AppendNode(new object[] { "Sub Zona" }, -1, 11, 11, 11);
					//nodeSubZona.Tag = "optSubZona";
					//TreeListNode nodeConsecutivosMarscaras = tl.AppendNode(new object[] { "Consecutivos de Mascaras" }, -1, 11, 11, 11);
					//nodeConsecutivosMarscaras.Tag = "optConsecutivosMascaras";
					//TreeListNode nodePlazos = tl.AppendNode(new object[] { "Plazos" }, -1, 11, 11, 11);
					//nodePlazos.Tag = "optPlazos";
					//TreeListNode nodeTipoEntrega = tl.AppendNode(new object[] { "Tipo Entrega" }, -1, 11, 11, 11);
					//nodeTipoEntrega.Tag = "optTipoEntrega";
					//TreeListNode nodeTipoCliente = tl.AppendNode(new object[] { "Tipo Cliente" }, -1, 11, 11, 11);
					//nodeTipoCliente.Tag = "optTipoCliente";
					//TreeListNode nodeCategoriaCliente = tl.AppendNode(new object[] { "Categoria Cliente" }, -1, 11, 11, 11);
					//nodeCategoriaCliente.Tag = "optCategoriaCliente";
					//TreeListNode nodeVendedores = tl.AppendNode(new object[] { "Vendedores" }, -1, 11, 11, 11);
					//nodeVendedores.Tag = "optVendedores";
					//TreeListNode nodeCliente = tl.AppendNode(new object[] { "Clientes" }, -1, 11, 11, 11);
					//nodeCliente.Tag = "frmDetalles";
                    break;

                case "treeListContabilidad":
                    TreeListNode nodeCuentas = tl.AppendNode(new object[] { "Cuentas Contables" }, -1, 11, 11, 11);
                    nodeCuentas.Tag = "frmListadoCuentaContable";
                    TreeListNode nodeCentroCosto = tl.AppendNode(new object[] { "Centro de Costos" }, -1, 11, 11, 11);
                    nodeCentroCosto.Tag = "frmListadoCentroCosto";
                    //Carpeta
                    TreeListNode nodeTransaccionesContabilidad = tl.AppendNode(new object[] { "Transacciones" }, -1, 9, 10, 9);
                    //Items
                    TreeListNode nodeTransaccionesDiario = tl.AppendNode(new object[] { "Diario" }, nodeTransaccionesContabilidad.Id, 11, 11, 11);
                    nodeTransaccionesDiario.Tag = "frmListadoAsientoDiario";
					TreeListNode nodeTransaccionesMayor = tl.AppendNode(new object[] { "Mayor" }, nodeTransaccionesContabilidad.Id, 11, 11, 11);
					nodeTransaccionesMayor.Tag = "frmListadoAsientoMayor";

					
                    //TreeListNode nodeTransaccionesRecurrente = tl.AppendNode(new object[] { "Recurrente" }, nodeTransaccionesContabilidad.Id, 11, 11, 11);
                    //nodeTransaccionesRecurrente.Tag = "optTransaccionesRecurrente";
                    //TreeListNode nodeTransaccionesAnulacion = tl.AppendNode(new object[] { "Anulación" }, nodeTransaccionesContabilidad.Id, 11, 11, 11);
                    //nodeTransaccionesAnulacion.Tag = "optTransaccionesAnulacion";
                    //TreeListNode nodeTransaccionesReversion = tl.AppendNode(new object[] { "Reversión" }, nodeTransaccionesContabilidad.Id, 11, 11, 11);
                    //nodeTransaccionesReversion.Tag = "optTransaccionesReversion";
                    //TreeListNode nodeTransaccionesDistribuidas = tl.AppendNode(new object[] { "Distribuidas" }, nodeTransaccionesContabilidad.Id, 11, 11, 11);
                    //nodeTransaccionesDistribuidas.Tag = "optTransaccionesDistribuidas";
                    //TreeListNode nodeTransaccionesReferido = tl.AppendNode(new object[] { "Referido" }, nodeTransaccionesContabilidad.Id, 11, 11, 11);
                    //nodeTransaccionesReferido.Tag = "optTransaccionesReferido";
                    //Carpeta
                    TreeListNode nodeConsultasContabilidad = tl.AppendNode(new object[] { "Consultas" }, -1, 9, 10, 9);
                    //Items
                    TreeListNode nodeConsultasDeCuentasContables = tl.AppendNode(new object[] { "De Cuentas Contables" }, nodeConsultasContabilidad.Id, 11, 11, 11);
                    nodeConsultasDeCuentasContables.Tag = "frmConsultaSaldoCuenta";
                    TreeListNode nodeConsultasDeCentrosDeCostos = tl.AppendNode(new object[] { "De Centros de Costos" }, nodeConsultasContabilidad.Id, 11, 11, 11);
                    nodeConsultasDeCentrosDeCostos.Tag = "frmConsultaSaldoCentro";
                    //TreeListNode nodeConsultasPorPeriodoContable = tl.AppendNode(new object[] { "Por Periodo Contable" }, nodeConsultasContabilidad.Id, 11, 11, 11);
                    //nodeConsultasPorPeriodoContable.Tag = "optConsultasPorPeriodoContable";
                    TreeListNode nodeConsultasLibroMayor = tl.AppendNode(new object[] { "Libro Mayor" }, nodeConsultasContabilidad.Id, 11, 11, 11);
                    nodeConsultasLibroMayor.Tag = "frmConsultaLibroMayor";

                    TreeListNode nodeConsultasContabilidadMayor = tl.AppendNode(new object[] { "del Mayor" }, nodeConsultasContabilidad.Id, 9, 10, 9);
                    TreeListNode nodeConsultasAsientosMayor = tl.AppendNode(new object[] { "Asientos" }, nodeConsultasContabilidadMayor.Id, 11, 11, 11);
                    nodeConsultasAsientosMayor.Tag = "frmConsultaAsientoMayor";
                    TreeListNode nodeConsultasDetalleMayor = tl.AppendNode(new object[] { "Detalle" }, nodeConsultasContabilidadMayor.Id, 11, 11, 11);
                    nodeConsultasDetalleMayor.Tag = "frmConsultaDetalleMayor";


                    TreeListNode nodeConsultasContabilidaDiario = tl.AppendNode(new object[] { "del Diario" }, nodeConsultasContabilidad.Id, 9, 10, 9);
                    TreeListNode nodeConsultasAsientosDiario = tl.AppendNode(new object[] { "Asientos" }, nodeConsultasContabilidaDiario.Id, 11, 11, 11);
                    nodeConsultasAsientosDiario.Tag = "frmConsultaAsientoDiario";
                    TreeListNode nodeConsultasDetalleDiario = tl.AppendNode(new object[] { "Detalle" }, nodeConsultasContabilidaDiario.Id, 11, 11, 11);
                    nodeConsultasDetalleDiario.Tag = "frmConsultaDetalleDiario";
                    //Carpeta
                    //TreeListNode nodeConsultasDelMayor = tl.AppendNode(new object[] { "Del Mayor" }, nodeConsultasContabilidad.Id, 9, 10, 9);
                    ////Items
                    //TreeListNode nodeConsultasDelMayorAsientos = tl.AppendNode(new object[] { "Asientos" }, nodeConsultasDelMayor.Id, 11, 11, 11);
                    //nodeConsultasDelMayorAsientos.Tag = "optConsultasDelMayorAsientos";
                    //TreeListNode nodeConsultasDelMayorTransacciones = tl.AppendNode(new object[] { "Transacciones" }, nodeConsultasDelMayor.Id, 11, 11, 11);
                    //nodeConsultasDelMayorTransacciones.Tag = "optConsultasDelMayorTransacciones";
                    ////Carpeta
                    //TreeListNode nodeConsultasDelDiario = tl.AppendNode(new object[] { "Del Diario" }, nodeConsultasContabilidad.Id, 9, 10, 9);
                    ////Items
                    //TreeListNode nodeConsultasDelDiarioAsientos = tl.AppendNode(new object[] { "Asientos" }, nodeConsultasDelDiario.Id, 11, 11, 11);
                    //nodeConsultasDelDiarioAsientos.Tag = "optConsultasDelDiarioAsientos";
                    //TreeListNode nodeConsultasDelDiarioTransacciones = tl.AppendNode(new object[] { "Transacciones" }, nodeConsultasDelDiario.Id, 11, 11, 11);
                    //nodeConsultasDelDiarioTransacciones.Tag = "optConsultasDelDiarioTransacciones";

					//Carpeta
					TreeListNode nodeProcesosContab = tl.AppendNode(new object[] { "Proceso" }, -1, 9, 10, 9);
					TreeListNode nodeProcesosCierreFiscal = tl.AppendNode(new object[] { "Generación de Asientos de Cierre Fiscal" }, nodeProcesosContab.Id, 11, 11, 11);
					nodeProcesosCierreFiscal.Tag = "frmGenerarDocumentosCierrePeriodoFiscal";
                    //Carpeta
                    TreeListNode nodeReportesContabilidad = tl.AppendNode(new object[] { "Reportes" }, -1, 9, 10, 9);
                    //Carpeta
                    //TreeListNode nodeReportesBalanceDeComprobacion = tl.AppendNode(new object[] { "Balance de Comprobación" }, nodeReportesContabilidad.Id, 9, 10, 9);
                    ////Items
                    //TreeListNode nodeReportesBalanceDeComprobacionPorCuentaContable = tl.AppendNode(new object[] { "Por Cuenta Contable" }, nodeReportesBalanceDeComprobacion.Id, 11, 11, 11);
                    //nodeReportesBalanceDeComprobacionPorCuentaContable.Tag = "optReportesBalanceDeComprobacionPorCuentaContable";
                    //TreeListNode nodeReportesBalanceDeComprobacionPorCentroCosto = tl.AppendNode(new object[] { "Por Centro de Costo" }, nodeReportesBalanceDeComprobacion.Id, 11, 11, 11);
                    //nodeReportesBalanceDeComprobacionPorCentroCosto.Tag = "optReportesBalanceDeComprobacionPorCentroCosto";
                    TreeListNode nodeReportesBalanceGeneral = tl.AppendNode(new object[] { "Balance General" }, nodeReportesContabilidad.Id, 11, 11, 11);
                    nodeReportesBalanceGeneral.Tag = "frmBalanceGeneral";
                    TreeListNode nodeReportesBalanceComprobacion = tl.AppendNode(new object[] { "Balance Comprobación" }, nodeReportesContabilidad.Id, 11, 11, 11);
                    nodeReportesBalanceComprobacion.Tag = "frmBalanceComprobacion";
                    TreeListNode nodeReportesEstadodeResultado = tl.AppendNode(new object[] { "Estado de Resultado" }, nodeReportesContabilidad.Id, 11, 11, 11);
                    nodeReportesEstadodeResultado.Tag = "frmEstadoResultado";
                    //TreeListNode nodeReportesReporteDeAsiento = tl.AppendNode(new object[] { "Reporte de Asiento" }, nodeReportesContabilidad.Id, 11, 11, 11);
                    //nodeReportesReporteDeAsiento.Tag = "optReportesReporteDeAsiento";
                    //TreeListNode nodeReportesReporteDeMayor = tl.AppendNode(new object[] { "Reporte de Mayor" }, nodeReportesContabilidad.Id, 11, 11, 11);
                    //nodeReportesReporteDeMayor.Tag = "optReportesReporteDeMayor";
                    //TreeListNode nodeReportesReporteDeDiferencias = tl.AppendNode(new object[] { "Reporte de Diferencias" }, nodeReportesContabilidad.Id, 11, 11, 11);
                    //nodeReportesReporteDeDiferencias.Tag = "optReportesDeDiferencias";

                    //Carpeta
                    TreeListNode nodeAdministracionContabilidad = tl.AppendNode(new object[] { "Administración" }, -1, 9, 10, 9);
                    TreeListNode nodeParametrosModulo = tl.AppendNode(new object[] { "Parámetros del Módulo" }, nodeAdministracionContabilidad.Id, 11, 11, 11);
                    nodeParametrosModulo.Tag = "frmParametrosContables";
                    TreeListNode nodeAbrirPeriodoCerrado = tl.AppendNode(new object[] { "Periodos Contables" }, nodeAdministracionContabilidad.Id, 11, 11, 11);
                    nodeAbrirPeriodoCerrado.Tag = "frmListadoPeriodos";
                    TreeListNode nodeGruposEstadosFinancieros = tl.AppendNode(new object[] { "Grupos Estados Financieros" }, nodeAdministracionContabilidad.Id, 11, 11, 11);
                    nodeGruposEstadosFinancieros.Tag = "frmGrupoEstadosFinancieros";

                    TreeListNode nodeCuentaGruposEstadosFinancieros = tl.AppendNode(new object[] { "Asociar Cuenta Grupos Estados Financieros" }, nodeAdministracionContabilidad.Id, 11, 11, 11);
                    nodeCuentaGruposEstadosFinancieros.Tag = "frmRelacionCuentaGrupoEstadosFinancieros";

                    TreeListNode nodeCrearEjercicio = tl.AppendNode(new object[] { "Crear Ejercicios" }, nodeAdministracionContabilidad.Id, 11, 11, 11);
                    nodeCrearEjercicio.Tag = "frmCreaEjercicio";

                    TreeListNode nodeCierreMes = tl.AppendNode(new object[] { "Cerrar Periodo" }, nodeAdministracionContabilidad.Id, 11, 11, 11);
                    nodeCierreMes.Tag = "frmCerrarPeriodo";

					TreeListNode nodeTipoAsiento = tl.AppendNode(new object[] { "Tipo Asiento" }, nodeAdministracionContabilidad.Id, 11, 11, 11);
					nodeTipoAsiento.Tag = "frmTipoAsiento";
                    break;
            }

            tl.EndUnboundLoad();
        }                                                          


        private void ShowPagesRibbonMan(bool valor)
        {
            this.ribbonHelp.Visible = valor;
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
                    frmListadoProducto ofrmListado  = new frmListadoProducto();
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
            }

        }

        void ofrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPagesRibbonMan(true);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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


    }
}

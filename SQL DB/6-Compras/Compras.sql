
ALTER TABLE dbo.cppProveedor ADD  Alias nvarchar(250) DEFAULT ''
GO
ALTER TABLE dbo.cppProveedor ADD Contacto NVARCHAR(250) DEFAULT ''
GO
ALTER TABLE dbo.cppProveedor ADD Telefono NVARCHAR(250) DEFAULT ''
GO 
ALTER TABLE  dbo.cppProveedor ADD RUC NVARCHAR(50)
GO
ALTER TABLE dbo.cppProveedor ADD IDImpuesto INT
GO
ALTER TABLE dbo.cppProveedor ADD IDCategoria INT 
GO
ALTER TABLE dbo.cppProveedor ADD IDPais INT 
GO
ALTER TABLE dbo.cppProveedor ADD IDMoneda INT
GO
ALTER TABLE  dbo.cppProveedor ADD IDCondicionPago INT 
GO
ALTER TABLE  dbo.cppProveedor ADD FechaIngreso DATETIME
GO
ALTER TABLE dbo.cppProveedor ADD PorcDesc DECIMAL(28,4)
GO
ALTER TABLE  dbo.cppProveedor ADD PorcInteresMora DECIMAL(28,4)
GO	
ALTER TABLE dbo.cppProveedor ADD 	Email NVARCHAR(50)
go
ALTER TABLE dbo.cppProveedor ADD 	Direccion NVARCHAR(255)
GO
ALTER TABLE dbo.cppProveedor ADD 	MultiMoneda BIT DEFAULT 0
go
ALTER TABLE dbo.cppProveedor ADD PagosCongelados BIT DEFAULT 0
go	
ALTER TABLE dbo.cppProveedor ADD 	IsLocal BIT DEFAULT 0
go	
ALTER TABLE dbo.cppProveedor ADD 	Bonifica BIT DEFAULT 0

CREATE TABLE dbo.cppCategoriaProveedor(
	IDCategoria INT NOT NULL,
	Descr NVARCHAR(250),
	Ctr_CXP int,
	Cta_CXP bigint,
	Ctr_Letra_CXP int,
	Cta_Letra_CXP bigint,
	Ctr_ProntoPago_CXP int,
	Cta_ProntoPago_CXP bigint,
	Ctr_Comision_CXP int,
	Cta_Comision_CXP bigint,
	Ctr_Anticipos_CXP int,
	Cta_Anticipos_CXP bigint,
	Ctr_CierreDebitos_CXP int,
	Cta_CierreDebitos_CXP bigint,
	Ctr_Impuestos_CXP int,
	Cta_Impuestos_CxP bigint,
	Activo BIT DEFAULT 1
CONSTRAINT [pkcppCategoriaProveedor] PRIMARY KEY CLUSTERED 
(
	IDCategoria ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[cppProveedor]  WITH CHECK ADD  CONSTRAINT [fkcppProveedor_Categoria] FOREIGN KEY([IDCategoria])
REFERENCES [dbo].cppCategoriaProveedor (IDCategoria)

go	

CREATE TABLE dbo.coEstadoOrdenCompra(
	IDEstadoOrden INT NOT NULL,
	Descr NVARCHAR(250),
	Activo BIT DEFAULT 1
CONSTRAINT [pkcoEstadoOrdenCompra] PRIMARY KEY CLUSTERED 
(
	IDEstadoOrden ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE dbo.cppCondicionPago(
	IDCondicionPago INT NOT NULL,
	Descr NVARCHAR(250),
	Dias INT NOT NULL,
	DescuentoContado DECIMAL(28,4),
	PagosParciales BIT DEFAULT 0,
	Activo BIT DEFAULT 1
CONSTRAINT [pkccpCondicionPago] PRIMARY KEY CLUSTERED 
(
	IDCondicionPago ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE dbo.coTipoProrrateoRubrosCompra(
	IDTipoProrrateo INT NOT NULL,
	Descr NVARCHAR(250),
	Activo BIT DEFAULT 1
CONSTRAINT pkcoTipoProrrateoRubrosCompra PRIMARY KEY CLUSTERED 
(
	IDTipoProrrateo ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE dbo.coEstadoSolicitud(
	IDEstado int NOT NULL,
	Descr nvarchar(250),
	Activo bit DEFAULT 1,
CONSTRAINT pkcoEstadoSolicitud PRIMARY KEY CLUSTERED 
(
	IDEstado ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE TABLE dbo.coSolicitudCompra(
	IDSolicitud int NOT NULL,
	Consecutivo NVARCHAR(20),
	Fecha date,
	FechaRequerida date,
	IDEstado int,
	Comentario nvarCHAR(250),
	UsuarioSolicitud nvarchar(50),
	CreateDate datetime,
	CreatedBy nvarchar(50),
	RecordDate datetime,
	UpdateBy nvarchar(50)
	CONSTRAINT pkcoSolicitudCompra PRIMARY KEY CLUSTERED 
(
	IDSolicitud ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[coSolicitudCompra]  WITH CHECK ADD  CONSTRAINT [fkcoSolicitudCompra_EstadoSolicitud] FOREIGN KEY([IDEstado])
REFERENCES [dbo].coEstadoSolicitud (IDEstado)

GO


CREATE TABLE dbo.coSolicitudCompraDetalle (
	IDSolicitud INT NOT NULL,
	IDProducto BIGINT NOT NULL,
	Cantidad DECIMAL(28,4) DEFAULT  0,
	CantidadOrdenada DECIMAL(28,4) DEFAULT  0,
	Comentario NVARCHAR(20) ,
CONSTRAINT [pkcoSolicitudCompraDetalle] PRIMARY KEY CLUSTERED 
(
	IDSolicitud ASC,
	[IDProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[coSolicitudCompraDetalle]  WITH CHECK ADD  CONSTRAINT [fkcoSolicitudCompraDetalle_Producto] FOREIGN KEY([IDProducto])
REFERENCES [dbo].invProducto (IDProducto)

GO

ALTER TABLE [dbo].[coSolicitudCompraDetalle]  WITH CHECK ADD  CONSTRAINT [fkcoSolicitudCompraDetalle_solicitudCompra] FOREIGN KEY(IDSolicitud)
REFERENCES [dbo].coSolicitudCompra (IDSolicitud)


GO


CREATE TABLE [dbo].[coOrdenCompra](
	[IDOrdenCompra] [int] NOT NULL,
	[OrdenCompra] [nvarchar](20) NOT NULL,
	Fecha [datetime] ,
	FechaRequerida DATE,
	FechaEmision DATE,
	FechaRequeridaEmbarque DATE,
	FechaCotizacion DATE,
	[IDSolicitud] INT,
	[IDEstado] INT,
	[IDBodega] INT,
	[IDProveedor] INT,
	[IDMoneda] INT,
	[IDCondicionPago] INT,
	Descuento DECIMAL(28,4),
	Flete DECIMAL(28,4),
	Seguro DECIMAL(28,4),
	Documentacion DECIMAL(28,4),
	Anticipos decimal(28,4),
	IDTipoProrrateo INt,
	IDEmbarque INT,
	IDDocumentoCP INT,
	TipoCambio DECIMAL(28,4),
	Usuario NVARCHAR(50) NOT NULL,
	UsuarioCreaEmbarque NVARCHAR(50) NOT	NULL,
	FechaCreaEmbarque datetime,
	UsuarioAprobacion NVARCHAR(50) NOT NULL,
	FechaAprobacion datetime,
	CreateDate datetime,
	CreatedBy nvarchar(50),
	RecordDate datetime,
	UpdateBy nvarchar(50)
 CONSTRAINT [pkcoOrdenCompra] PRIMARY KEY CLUSTERED 
(
	[IDOrdenCompra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



ALTER TABLE [dbo].[coOrdenCompra]  WITH CHECK ADD  CONSTRAINT [fkcoOrdenCompra_Proveedor] FOREIGN KEY([IDProveedor])
REFERENCES [dbo].[cppProveedor] ([IDProveedor])
GO

ALTER TABLE [dbo].[coOrdenCompra]  WITH CHECK ADD  CONSTRAINT [fkcoOrdenCompra_solicitud] FOREIGN KEY(IDSolicitud)
REFERENCES [dbo].coSolicitudCompra (IDSolicitud)
GO


ALTER TABLE [dbo].[coOrdenCompra]  WITH CHECK ADD  CONSTRAINT [fkcoOrdenCompra_GlobalMoneda] FOREIGN KEY([IDMoneda])
REFERENCES [dbo].globalMoneda (IDMoneda)
GO


ALTER TABLE [dbo].[coOrdenCompra]  WITH CHECK ADD  CONSTRAINT [fkcoOrdenCompra_Bodega] FOREIGN KEY([IDBodega])
REFERENCES [dbo].invBodega (IDBodega)
GO


ALTER TABLE [dbo].[coOrdenCompra]  WITH CHECK ADD  CONSTRAINT [fkcoOrdenCompra_CondicionPago] FOREIGN KEY([IDCondicionPago])
REFERENCES [dbo].cppCondicionPago (IDCondicionPago)
GO


ALTER TABLE [dbo].[coOrdenCompra]  WITH CHECK ADD  CONSTRAINT [fkcoOrdenCompra_TipoProrrateo] FOREIGN KEY([IDTipoProrrateo])
REFERENCES [dbo].coTipoProrrateoRubrosCompra (IDTipoProrrateo)

GO


ALTER TABLE [dbo].[coOrdenCompra]  WITH CHECK ADD  CONSTRAINT [fkcoOrdenCompra_Estado] FOREIGN KEY(IDEstado)
REFERENCES [dbo].coEstadoOrdenCompra (IDEstadoOrden)


GO


CREATE TABLE dbo.coOrdenCompraDetalle (
	IDOrdenCompra INT NOT NULL,
	IDProducto BIGINT NOT NULL,
	Cantidad DECIMAL(28,4) DEFAULT  0,
	CantidadAceptada DECIMAL(28,4) DEFAULT 0,
	CantidadRechazada  DECIMAL(28,4) DEFAULT 0,
	PrecioUnitario DECIMAL(28,4)  DEFAULT 0,
	Impuesto DECIMAL(28,4) DEFAULT 0,
	PorcDesc  DECIMAL(28,4) DEFAULT 0,
	MontoDesc DECIMAL(28,4)  DEFAULT 0,
	Estado INT ,
	Comentario NVARCHAR(20) ,
CONSTRAINT [pkcoOrdenCompraDetalle] PRIMARY KEY CLUSTERED 
(
	[IDOrdenCompra] ASC,
	[IDProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].coOrdenCompraDetalle  WITH CHECK ADD  CONSTRAINT [fkcoOrdenCompraDetalle_Prodcuto] FOREIGN KEY([IDProducto])
REFERENCES [dbo].invProducto (IDProducto)


GO

ALTER TABLE [dbo].coOrdenCompraDetalle  WITH CHECK ADD  CONSTRAINT [fkcoOrdenCompraDetalle_OrdenCompra] FOREIGN KEY(IDOrdenCompra)
REFERENCES [dbo].coOrdenCompra (IDOrdenCompra)



GO
CREATE TABLE [dbo].[coEmbarque](
	[IDEmbarque] [int] NOT NULL,
	[Embarque] nvarchar(20) NOT NULL,
	Fecha [datetime] ,
	FechaEmbarque DATE,
	Asiento nvarchar(20),
	DocumentoInv NVARCHAR(20),
	[IDBodega] INT,
	[IDProveedor] INT,
	[IDOrdenCompra] int,
	IDDocumentoCP INT,
	TipoCambio DECIMAL(28,4),
	Confirmado bit DEFAULT 0,
	Usuario NVARCHAR(50) NOT NULL,
	CreateDate datetime,
	CreatedBy nvarchar(50),
	RecordDate datetime,
	UpdateBy nvarchar(50)
 CONSTRAINT [pkcoEmbarque] PRIMARY KEY CLUSTERED 
(
	[IDEmbarque] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[coEmbarque]  WITH CHECK ADD  CONSTRAINT [fkcoEmbarque_Bodega] FOREIGN KEY(IDBodega)
REFERENCES [dbo].invBodega (IDBodega)
GO



ALTER TABLE [dbo].[coEmbarque]  WITH CHECK ADD  CONSTRAINT [fkcoEmbarque_OrdenCompra] FOREIGN KEY(IDOrdenCompra)
REFERENCES [dbo].coOrdenCompra (IDOrdenCompra)
GO


--// TODO Pendiente crear tabla de Cuentas por pagar
--ALTER TABLE [dbo].[coEmbarque]  WITH CHECK ADD  CONSTRAINT [fkcoEmbarque_DocumentoCP] FOREIGN KEY(IDDocumentoCP)
--REFERENCES [dbo].ccpDocumentoCP (IDDocumentoCP)
--GO



CREATE TABLE dbo.coEmbarqueDetalle (
	IDEmbarque INT NOT NULL,
	IDProducto BIGINT NOT NULL,
	PrecioUnitario DECIMAL(28,8) DEFAULT 0,
	Impuesto DECIMAL(28,8) DEFAULT 0,
	PorcDesc DECIMAL(28,8) DEFAULT 0,
	MontoDesc DECIMAL(28,8) DEFAULT 0,
	CantidadOrdenada DECIMAL(28,4) DEFAULT  0,
	CantidadAceptada DECIMAL(28,4) DEFAULT 0,
	CantidadRechazada  DECIMAL(28,4) DEFAULT 0,
	Comentario NVARCHAR(20) ,
CONSTRAINT [pkcoEmbarqueDetalle] PRIMARY KEY CLUSTERED 
(
	[IDEmbarque] ASC,
	[IDProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].coEmbarqueDetalle  WITH CHECK ADD  CONSTRAINT [fkicoEmbarque_EmbarqueDetalle] FOREIGN KEY(IDEmbarque)
REFERENCES [dbo].coEmbarque (IDEmbarque)

GO

ALTER TABLE [dbo].coEmbarqueDetalle  WITH CHECK ADD  CONSTRAINT [fkicoEmbarqueDetalle_Producto] FOREIGN KEY([IDProducto])
REFERENCES [dbo].invProducto (IDProducto)

GO


CREATE   TABLE dbo.coObligacionProveedor (
	IDObligacion INT NOT NULL,
	IDEmbarque INT NOT NULL,
	flgDocCPGenerado BIT DEFAULT 0,
	Fecha DATETIME NOT NULL,
	FechaVence DATE,
	FechaPoliza DATE,
	NumPoliza NVARCHAR(250),
	NumFactura NVARCHAR(250),
	Guia_BL NVARCHAR(250),
	TipoCambio DECIMAL(28,8) DEFAULT 0, 
	ValorMercaderia DECIMAL(28,8) DEFAULT 0,
	MontoFlete DECIMAL(28,8) DEFAULT 0,
	MontoSeguro DECIMAL(28,8) DEFAULT 0,
	MontoTotal DECIMAL(28,8) DEFAULT 0,
CONSTRAINT [pkcoObligacionProveedor] PRIMARY KEY CLUSTERED 
(
	IDObligacion ASC
 )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO

ALTER TABLE [dbo].coObligacionProveedor  WITH CHECK ADD  CONSTRAINT [fkcoObligacionProveedor_embarque] FOREIGN KEY(IDEmbarque)
REFERENCES [dbo].coEmbarque (IDEmbarque)

GO


CREATE TABLE  dbo.coObligacionDetalle (
	IDObligacionDetalle INT NOT NULL,
	IDObligacion INT NOT NULL,
	IDProveedor INT NOT NULL,
	Documento NVARCHAR(100) NOT NULL,
	flgDocCPGenerado BIT DEFAULT 0,
	FechaDocumento DATE,
	SubTotal DECIMAL(28,8) DEFAULT 0,
	PorcImpuesto DECIMAL(28,8) DEFAULT 0,
	Impuesto DECIMAL(28,8) DEFAULT 0,
	MontoTotal DECIMAL(28,8) DEFAULT 0,
	IDMoneda INT,
	IDGasto INT
CONSTRAINT [pkcoObligacionDetalle] PRIMARY KEY CLUSTERED 
(
	IDObligacionDetalle ASC
 )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO

ALTER TABLE [dbo].coObligacionDetalle  WITH CHECK ADD  CONSTRAINT [fkcoOblicacionDetalle_ObligacionProveedor] FOREIGN KEY(IDObligacion)
REFERENCES [dbo].coObligacionProveedor (IDObligacion)

GO

ALTER TABLE [dbo].coObligacionDetalle  WITH CHECK ADD  CONSTRAINT [fkcoOblicacionDetalle_Proveedor] FOREIGN KEY(IDProveedor)
REFERENCES [dbo].cppProveedor (IDProveedor)

GO

ALTER TABLE [dbo].coObligacionDetalle  WITH CHECK ADD  CONSTRAINT [fkcoOblicacionDetalle_Moneda] FOREIGN KEY(IDMoneda)
REFERENCES [dbo].globalMoneda (IDMoneda)

GO 

ALTER TABLE [dbo].coObligacionDetalle  WITH CHECK ADD  CONSTRAINT [fkcoOblicacionDetalle_GastoCompra] FOREIGN KEY(IDGasto)
REFERENCES [dbo].coGastosCompra (IDGasto)

GO

CREATE TABLE dbo.coRecepcionMercaderia(
	IDEmbarque INT NOT NULL,
	IDProducto BIGINT NOT NULL,
	IDLote INT NOT NULL,
	Cantidad DECIMAL(28,4) DEFAULT 0,
CONSTRAINT [pkcoRecepcionMercaderia] PRIMARY KEY CLUSTERED 
(
	[IDEmbarque] ASC,
	[IDProducto] ASC,
	[IDLote] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].coRecepcionMercaderia  WITH CHECK ADD  CONSTRAINT [fkcoRecepcionMercaderia_Lote] FOREIGN KEY(IDLote,IDProducto)
REFERENCES [dbo].invLote (IDLote,IDProducto)

GO

ALTER TABLE [dbo].coRecepcionMercaderia  WITH CHECK ADD  CONSTRAINT [fkinvReceipcionMecaderia_Producto] FOREIGN KEY([IDProducto])
REFERENCES [dbo].invProducto (IDProducto)



GO


CREATE TABLE	dbo.globalPais(
		IDPais int	NOT NULL,
		Descr  nvarchar(50),
		Activo  bit
CONSTRAINT [pkglobalPais] PRIMARY KEY CLUSTERED 
(
	IDPais ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO




CREATE TABLE dbo.coParametrosCompra(
	IDParametro int,
	IDConsecSolicitud int	,
	IDConsecOrdenCompra int,
	IDConsecEmbarque int,
	IDConsecDevolucion int,
	IDConsecLiquidacion int,
	CantLineasOrdenCompra int,
	IDBodegaDefault int,
	IDTipoCambio NVARCHAR(20),
	CantDecimalesPrecio int	,
	CantDecimalesCantidad int	,
	IDTipoAsientoContable NVARCHAR(2),
	IDPaquete int,
	CtaTransitoLocal bigInt,
	CtrTransitoLocal int,
	CtaTransitoExterior bigint,
	CtrTransitoExterior int,
	AplicaAutomaticamenteAsiento bit DEFAULT 0,
	CanEditAsiento bit DEFAULT 1,
	CanViewAsiento bit DEFAULT 1,
	CONSTRAINT [pkcoParametrosCompra] PRIMARY KEY CLUSTERED 
(
	IDParametro ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE TABLE  dbo.coGastosCompra (
	IDGasto INT NOT NULL IDENTITY(1,1),
	Descripcion nvarchar(250) NOT NULL,
	flgReadOnly BIT DEFAULT 0,
	flgIsFactura BIT DEFAULT 0,
	Activo BIT	 ,
CONSTRAINT [pkcoGastoCompra] PRIMARY KEY CLUSTERED 
(
	IDGasto ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



CREATE TABLE dbo.coLiquidacionCompra (
	IDLiquidacion INT NOT NULL IDENTITY(1,1),
	Liquidacion NVARCHAR(20) NOT NULL,
	IDEmbarque INT NOT NULL,
	IDOrdenCompra INT NOT NULL,
	Fecha DATETIME NOT NULL,
	TipoCambio DECIMAL(28,8) DEFAULT 0, 
	ValorMercaderia DECIMAL(28,8) DEFAULT 0,
	MontoFlete DECIMAL(28,8) DEFAULT 0,
	MontoSeguro DECIMAL(28,8) DEFAULT 0,
	Otros DECIMAL(28,8) DEFAULT 0, 
	MontoTotal DECIMAL(28,8) DEFAULT 0,
CONSTRAINT [pkcoLiquidacionCompra] PRIMARY KEY CLUSTERED 
(
	IDLiquidacion ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



CREATE TABLE dbo.coGastoLiquidacion (
	IDLiquidacion INT NOT NULL,	
	IDGasto INT NOT NULL ,
	Monto decimal(28,8) DEFAULT 0,
CONSTRAINT [pkcoGastoLiquidacion] PRIMARY KEY CLUSTERED 
(
	IDLiquidacion ASC	,
	IDGasto ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].coGastoLiquidacion  WITH CHECK ADD  CONSTRAINT [fkcoGastoLiquidacion_GastoCompra] FOREIGN KEY(IDGasto)
REFERENCES [dbo].coGastosCompra (IDGasto)

GO


ALTER TABLE [dbo].coGastoLiquidacion  WITH CHECK ADD  CONSTRAINT [fkcoGastoLiquidacion_Liquidacion] FOREIGN KEY(IDLiquidacion)
REFERENCES [dbo].coLiquidacionCompra (IDLiquidacion)

GO



CREATE  TABLE dbo.coGastoLiquidacionDetallado (
	IDLiquidacion INT NOT NULL,	
	IDGasto INT NOT NULL ,
	IDProducto BIGINT NOT NULL,
	Monto decimal(28,8) DEFAULT 0,
CONSTRAINT [pkcoGastoLiquidacionDetallado] PRIMARY KEY CLUSTERED 
(
	IDLiquidacion ASC	,
	IDProducto ASC,
	IDGasto ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].coGastoLiquidacionDetallado  WITH CHECK ADD  CONSTRAINT [fkcoGastoLiquidacionDetallado_GastoCompra] FOREIGN KEY(IDGasto)
REFERENCES [dbo].coGastosCompra (IDGasto)

GO


ALTER TABLE [dbo].coGastoLiquidacionDetallado  WITH CHECK ADD  CONSTRAINT [fkcoGastoLiquidacionDetallado_Liquidacion] FOREIGN KEY(IDLiquidacion)
REFERENCES [dbo].coLiquidacionCompra (IDLiquidacion)

GO

ALTER TABLE [dbo].coGastoLiquidacionDetallado  WITH CHECK ADD  CONSTRAINT [fkcoGastoLiquidacionDetallado_Articulo] FOREIGN KEY(IDProducto)
REFERENCES [dbo].invProducto (IDProducto)


GO

--INICIALIZACION DE TABLAS

INSERT INTO dbo.coParametrosCompra( IDParametro ,IDConsecSolicitud ,IDConsecOrdenCompra ,IDConsecEmbarque ,IDConsecDevolucion,IDConsecLiquidacion ,CantLineasOrdenCompra ,IDBodegaDefault ,
          IDTipoCambio ,CantDecimalesPrecio ,CantDecimalesCantidad ,IDTipoAsientoContable ,IDPaquete ,CtaTransitoLocal ,CtrTransitoLocal ,CtaTransitoExterior ,CtrTransitoExterior ,AplicaAutomaticamenteAsiento ,CanEditAsiento ,CanViewAsiento)
VALUES (1,NULL,NULL,NULL,NULL,7,20,NULL,NULL,4,4,NULL,NULL,NULL,NULL,NULL,NULL,0,1,1)

GO


INSERT INTO dbo.coEstadoSolicitud( IDEstado, Descr, Activo ) VALUES(0,'INICIAL',1)
GO
INSERT INTO dbo.coEstadoSolicitud( IDEstado, Descr, Activo ) VALUES(1,'APROBADA',1)
GO
INSERT INTO dbo.coEstadoSolicitud( IDEstado, Descr, Activo ) VALUES(2,'RECHAZADA',1)
GO	
INSERT INTO dbo.coEstadoSolicitud( IDEstado, Descr, Activo ) VALUES(3,'ASIGNADA',1)


GO 

INSERT INTO dbo.coEstadoOrdenCompra( IDEstadoOrden, Descr, Activo )
VALUES  (0,'INICIAL',1)

GO 


INSERT INTO dbo.coEstadoOrdenCompra( IDEstadoOrden, Descr, Activo )
VALUES  (1,'APROBADO',1)

go 

INSERT INTO dbo.coEstadoOrdenCompra( IDEstadoOrden, Descr, Activo )
VALUES  (2,'CONFIRMADA',1)

GO 


INSERT INTO dbo.coEstadoOrdenCompra( IDEstadoOrden, Descr, Activo )
VALUES  (3,'BACKORDER',1)

go

INSERT INTO dbo.coEstadoOrdenCompra( IDEstadoOrden, Descr, Activo )
VALUES  (4,'CANCELADA',1)

go

INSERT INTO dbo.coEstadoOrdenCompra( IDEstadoOrden, Descr, Activo )
VALUES  (5,'RECIBIDA',1)


GO

INSERT INTO dbo.coGastosCompra( Descripcion,flgReadOnly,flgIsFactura, Activo )
VALUES  ('FACTURA',1,1,1)




--// CREACION DE PROCEDIMIENTOS ALMACENADOS

CREATE   PROCEDURE dbo.coUpdateSolicitudCompra(@Operacion NVARCHAR(1), @IDSolicitud AS INT OUTPUT,@Consecutivo NVARCHAR(20) OUTPUT, @Fecha date, @FechaRequerida  AS date, @IDEstado AS int ,@Comentario nvarchar(20)
, @UsuarioSolicitud nvarchar(50),@Usuario nvarchar(50),@CreatedDate datetime,@CreatedBy nvarchar(50),@RecordDate datetime,@UpdateBy nvarchar(50))
AS 
IF (@Operacion='I')  
BEGIN
	DECLARE @IDConsecutivo  AS INT
	DECLARE @CodigoConsecutivo AS NVARCHAR(4)
	DECLARE @Documento AS NVARCHAR(20)
	
	SET @IDConsecutivo = (SELECT IDConsecSolicitud  FROM dbo.coParametrosCompra WHERE IDParametro=1)
	
	EXEC [dbo].[invGetNextGlobalConsecutivo] @IDConsecutivo,@Documento OUTPUT
	SET @Consecutivo = @Documento
	
	SET @IDSolicitud = (SELECT ISNULL(MAX(IDSolicitud),0)  FROM dbo.coSolicitudCompra) + 1
	INSERT INTO dbo.coSolicitudCompra(IdSolicitud,Consecutivo,Fecha,FechaRequerida,IDEstado,Comentario,UsuarioSolicitud,CreateDate,CreatedBy,RecordDate,UpdateBy)
	VALUES (@IDSolicitud,@Documento,@Fecha,@FechaRequerida,@IDEstado,@Comentario,@UsuarioSolicitud,@CreatedDate,@CreatedBy,@RecordDate,@UpdateBy)
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.coSolicitudCompra  SET FechaRequerida=@FechaRequerida,IDEstado =@IDEstado,
															RecordDate=@RecordDate,UpdateBy = @UpdateBy
	WHERE IdSolicitud=@IDSolicitud
END
IF (@Operacion ='D')
BEGIN
	DELETE dbo.coSolicitudCompra WHERE IdSolicitud=@IDSolicitud
END

GO

CREATE PROCEDURE [dbo].[coGetSolicitudCompraByID] (@IDSolicitud AS INT)
AS 
SELECT  A.IDSolicitud,A.Consecutivo ,A.Fecha ,A.FechaRequerida ,A.IDEstado , E.Descr DescrEstado,Comentario ,UsuarioSolicitud ,
				A.CreateDate ,A.CreatedBy ,A.RecordDate ,A.UpdateBy  
FROM dbo.coSolicitudCompra A
INNER JOIN dbo.coEstadoSolicitud E ON A.IDEstado=E.IDEstado
WHERE A.IDSolicitud =@IDSolicitud 

GO

CREATE  PROCEDURE dbo.coGetSolicitudCompra (@IDSolicitud AS INT, @FechaInicial AS DATETIME,@FechaFinal AS DATE,@IDEstado AS INT)
AS 

set @FechaInicial = CONVERT(VARCHAR(25),@FechaInicial,101) 
set @FechaFinal = CAST(SUBSTRING(CAST(@FechaFinal AS CHAR),1,11) + ' 23:59:59.998' AS DATETIME)

SELECT  A.IDSolicitud, Consecutivo ,A.Fecha ,A.FechaRequerida ,A.IDEstado , E.Descr DescrEstado,Comentario  ,UsuarioSolicitud ,
				A.CreateDate ,A.CreatedBy ,A.RecordDate ,A.UpdateBy  
FROM dbo.coSolicitudCompra A
INNER JOIN dbo.coEstadoSolicitud E ON A.IDEstado=E.IDEstado
WHERE (A.IDSolicitud =@IDSolicitud OR @IDSolicitud=-1) AND A.Fecha BETWEEN @FechaInicial AND @FechaFinal  
			AND (A.IDEstado =@IDEstado OR @IDEstado=-1) 
GO


CREATE PROCEDURE dbo.coUpdateDetalleSolicitud(@Operacion NVARCHAR(1),@IDSolicitud INT,@IDProducto INT, @Cantidad INT, @Comentario NVARCHAR(20))
AS 
IF (@Operacion ='I') 
BEGIN
	INSERT INTO dbo.coSolicitudCompraDetalle(IdSolicitud,IDproducto,Cantidad,Comentario)
	VALUES (@IDSolicitud,@IDProducto,@Cantidad,@Comentario)
END
IF (@Operacion='U')
	UPDATE dbo.coSolicitudCompraDetalle SET CANTIDAD =@Cantidad,COMENTARIO=@Comentario WHERE IdSolicitud=@IDSolicitud

IF (@Operacion ='D')
	DELETE FROM dbo.coSolicitudCompraDetalle WHERE  IdSolicitud=@IDSolicitud
	
GO 

CREATE PROCEDURE dbo.coGetSolicitudCompraDetalle (@IDSolicitud AS INT)
AS 
SELECT IDSolicitud,A.IDProducto,P.Descr DescrProducto,A.Cantidad,A.Comentario
FROM dbo.coSolicitudCompraDetalle A
INNER JOIN dbo.invProducto P ON A.IDProducto = P.IDProducto
WHERE (IDSolicitud =@IDSolicitud OR (@IDSolicitud=-1 AND 1=3))
go 

CREATE   PROCEDURE dbo.coGetOrdenCompra(  @IDOrdenCompra AS INT, @FechaInicial AS DATETIME,@FechaFinal AS DATETIME, @Proveedor AS NVARCHAR(1000),@Estado AS NVARCHAR(1000),@FechaRequeridaInicial AS DATETIME ,
																			@FechaRequeridaFinal AS DATETIME)
AS 
DECLARE @Separador AS NVARCHAR(1)
SET @Separador = '|'
IF (@FechaInicial IS NULL) SET @FechaInicial = '19810821'
IF (@FechaFinal IS NULL) SET @FechaFinal = DATEADD(YEAR,50,GETDATE())

IF (@FechaRequeridaInicial IS NULL) SET @FechaRequeridaInicial = '19810821'
IF (@FechaRequeridaFinal IS NULL) SET @FechaRequeridaFinal = DATEADD(YEAR,50,GETDATE())

set @FechaRequeridaInicial = CONVERT(VARCHAR(25),@FechaRequeridaInicial,101) 
set @FechaRequeridaFinal = CAST(SUBSTRING(CAST(@FechaRequeridaFinal AS CHAR),1,11) + ' 23:59:59.998' AS DATETIME)

set @FechaInicial = CONVERT(VARCHAR(25),@FechaInicial,101) 
set @FechaFinal = CAST(SUBSTRING(CAST(@FechaFinal AS CHAR),1,11) + ' 23:59:59.998' AS DATETIME)

SELECT  A.IDOrdenCompra ,OrdenCompra ,A.Fecha ,FechaRequerida ,FechaEmision ,FechaRequeridaEmbarque ,FechaCotizacion ,IDEstado, B.Descr DescrEstado,A.IDBodega, C.Descr DescrBodega, 
		A.IDProveedor ,C.Descr DescrProveedor,A.IDMoneda, E.Descr DescrMoneda,A.IDCondicionPago , F.Descr DescrCondicionPago,F.Dias DiasCondicionPago,
        Descuento ,Seguro	,Flete ,Documentacion ,Anticipos ,A.IDEmbarque, H.Embarque ,A.IDDocumentoCP ,A.TipoCambio ,A.Usuario ,UsuarioCreaEmbarque ,FechaCreaEmbarque ,UsuarioAprobacion ,
        FechaAprobacion ,A.CreateDate ,A.CreatedBy ,A.RecordDate ,A.UpdateBy  
FROM dbo.coOrdenCompra A INNER JOIN dbo.coEstadoOrdenCompra B ON A.IDEstado = B.IDEstadoOrden
INNER JOIN dbo.invBodega C ON A.IDBodega= C.IDBodega 
INNER JOIN dbo.cppProveedor D ON A.IDProveedor = D.IDProveedor
INNER JOIN dbo.globalMoneda E ON A.IDMoneda = E.IDMoneda
INNER JOIN dbo.cppCondicionPago F ON A.IDCondicionPago = F.IDCondicionPago
LEFT  JOIN dbo.coTipoProrrateoRubrosCompra G ON A.IDTipoProrrateo = G.IDTipoProrrateo
LEFT JOIN dbo.coEmbarque H ON A.IDEmbarque = H.IDEmbarque
WHERE (A.IDOrdenCompra = @IDOrdenCompra OR @IDOrdenCompra = -1) AND A.Fecha  BETWEEN @FechaInicial  AND @FechaFinal  AND FechaRequerida  BETWEEN @FechaRequeridaInicial AND @FechaRequeridaFinal
AND (a.IDProveedor IN (SELECT Value FROM [dbo].[ConvertListToTable](@Proveedor,@Separador)) OR @Proveedor = '*')  AND (A.IDEstado IN (SELECT Value FROM [dbo].[ConvertListToTable](@Estado,@Separador) ) OR @Estado ='*' )


go 


CREATE   PROCEDURE dbo.coGetOrdenCompraByID( @IDOrdenCompra AS INT)
AS 
SELECT  A.IDOrdenCompra ,OrdenCompra ,A.Fecha ,FechaRequerida ,FechaEmision ,FechaRequeridaEmbarque ,FechaCotizacion ,IDEstado, B.Descr DescrEstado,A.IDBodega, C.Descr DescrBodega, 
		A.IDProveedor ,C.Descr DescrProveedor,A.IDMoneda, E.Descr DescrMoneda,A.IDCondicionPago , F.Descr DescrCondicionPago,F.Dias DiasCondicionPago,
        Descuento ,Flete,Seguro ,Documentacion ,Anticipos ,A.IDEmbarque, H.Embarque ,A.IDDocumentoCP ,A.TipoCambio ,A.Usuario ,UsuarioCreaEmbarque ,FechaCreaEmbarque ,UsuarioAprobacion ,
        FechaAprobacion ,A.CreateDate ,A.CreatedBy ,A.RecordDate ,A.UpdateBy  
FROM dbo.coOrdenCompra A INNER JOIN dbo.coEstadoOrdenCompra B ON A.IDEstado = B.IDEstadoOrden
INNER JOIN dbo.invBodega C ON A.IDBodega= C.IDBodega 
INNER JOIN dbo.cppProveedor D ON A.IDProveedor = D.IDProveedor
INNER JOIN dbo.globalMoneda E ON A.IDMoneda = E.IDMoneda
INNER JOIN dbo.cppCondicionPago F ON A.IDCondicionPago = F.IDCondicionPago
LEFT  JOIN dbo.coTipoProrrateoRubrosCompra G ON A.IDTipoProrrateo = G.IDTipoProrrateo
LEFT JOIN dbo.coEmbarque H ON A.IDEmbarque = H.IDEmbarque
WHERE (A.IDOrdenCompra = @IDOrdenCompra )


GO

CREATE   PROCEDURE dbo.coUpdateOrdenCompra (@Operacion nvarchar(1),@IDOrdenCompra INT OUTPUT,@OrdenCompra NVARCHAR(20) OUTPUT,@Fecha DATETIME, 
										@FechaRequerida DATE, @FechaEmision DATE,@FechaRequeridaEmbarque DATE,@FechaCotizacion DATE,
										@IDEstado AS INT, @IDBodega AS INT, @IDProveedor AS INT, @IDMoneda AS INT, @IDCondicionPago AS INT, 
										@Descuento AS DECIMAL(28,4), @Flete AS DECIMAL(28,4),@Seguro AS DECIMAL(28,4),@Documentacion AS DECIMAL(28,4),@Anticipos AS DECIMAL(28,4),
									    @IDEmbarque AS INT,  @IDDocumentoCP AS INT, @TipoCambio AS DECIMAL(28,4),
										 @Usuario AS NVARCHAR(50),@UsuarioEmbarque AS NVARCHAR(50),@FechaCreaEmbarque AS DATETIME, 
										 @UsuarioAprobacion AS NVARCHAR(50),@FechaAprobacion AS DATETIME, @CreateDate AS DATETIME, 
										 @CreatedBy AS NVARCHAR(50), @RecordDate AS DATETIME, @UpdatedBy AS NVARCHAR(50))
AS 
IF (@Operacion ='I')
BEGIN
	SET @IDOrdenCompra = (SELECT ISNULL(MAX(IDOrdenCompra),0)  FROM dbo.coOrdenCompra ) + 1
	
	DECLARE @IDConsecutivo  AS INT
	DECLARE @CodigoConsecutivo AS NVARCHAR(4)
	DECLARE @Documento AS NVARCHAR(20)
	
	SET @IDConsecutivo = (SELECT IDConsecOrdenCompra  FROM dbo.coParametrosCompra WHERE IDParametro=1)
	
	EXEC [dbo].[invGetNextGlobalConsecutivo] @IDConsecutivo,@Documento OUTPUT
	SET @OrdenCompra = @Documento
	
	INSERT INTO dbo.coOrdenCompra(IDOrdenCompra,OrdenCompra,Fecha,FechaRequerida,FechaEmision,FechaRequeridaEmbarque,FechaCotizacion,IdEstado, IDBodega,IDProveedor,IDMoneda,IDCondicionPago,Descuento,Flete,Seguro,Documentacion,Anticipos,IDEmbarque,IdDocumentoCP,TipoCambio,Usuario,UsuarioCreaEmbarque,FechaCreaEmbarque,UsuarioAprobacion,FechaAprobacion,CreateDate,Createdby,RecordDate,UpdateBy)
	VALUES (@IDOrdenCompra, @OrdenCompra, @Fecha,@FechaRequerida,@FechaEmision,@FechaRequeridaEmbarque,@FechaCotizacion,@IDEstado,@IDBodega,@IDProveedor,@IDMoneda,@IDCondicionPago,@Descuento,@Flete,@Seguro,@Documentacion,@Anticipos,@IDEmbarque,@IDDocumentoCP,@TipoCambio,@Usuario,@UsuarioEmbarque,@FechaCreaEmbarque,@UsuarioAprobacion,@FechaAprobacion, @CreateDate,@CreatedBy,@RecordDate,@UpdatedBy)
END										 
IF (@Operacion='U')
BEGIN
	UPDATE dbo.coOrdenCompra SET FechaRequerida= @FechaRequerida ,FechaRequeridaEmbarque = @FechaRequeridaEmbarque, FechaCotizacion = @FechaCotizacion,IDEstado = @IDEstado,IDBodega=@IDBodega, IDCondicionPago = @IDCondicionPago, Descuento= @Descuento ,Flete=@Flete,Seguro=@Seguro,Documentacion = @Documentacion,Anticipos= @Anticipos,IDEmbarque = @IDEmbarque,IDDocumentoCP = @IDDocumentoCP, 
																																																																																																																						TipoCambio = @TipoCambio,UsuarioCreaEmbarque = @UsuarioEmbarque,UsuarioAprobacion =@UsuarioAprobacion, FechaAprobacion=@FechaAprobacion,RecordDate=@RecordDate,UpdateBy=@UpdatedBy
END
IF (@Operacion='D')
BEGIN
	DELETE FROM dbo.coOrdenCompra WHERE IDOrdenCompra=@IDOrdenCompra
END

GO
--TODO: Revisar is load from Solicitud
CREATE PROCEDURE dbo.coGetOrdenCompraDetalle(@IDOrdenCompra AS int	)
AS 
SELECT A.IDOrdenCompra,A.IDProducto,P.Descr DescrProducto,p.IDUnidad,A.Estado,E.Descr DescrEstado,A.Cantidad,A.CantidadAceptada,A.CantidadRechazada,
A.Impuesto,A.MontoDesc,A.PorcDesc,A.PrecioUnitario,((A.Cantidad*A.PrecioUnitario)-MontoDesc) * (A.Impuesto/100) + ((A.Cantidad*A.PrecioUnitario)-MontoDesc)  Monto,A.Comentario
  FROM dbo.coOrdenCompraDetalle A
INNER JOIN dbo.invProducto P ON		A.IDProducto = P.IDProducto
INNER JOIN dbo.coEstadoOrdenCompra E ON A.Estado=E.IDEstadoOrden
WHERE A.IDOrdenCompra=@IDOrdenCompra

GO

--TODO: Revisar is load from Solicitud
CREATE PROCEDURE dbo.coGetOrdenCompraDetalleEmptyExcel
AS 
SELECT A.IDOrdenCompra,A.IDProducto,P.Descr DescrProducto,A.Estado,E.Descr DescrEstado,A.Cantidad,A.CantidadAceptada,A.CantidadRechazada,A.Impuesto,
A.MontoDesc,A.PorcDesc,A.PrecioUnitario,((A.Cantidad*A.PrecioUnitario)-MontoDesc) * (A.Impuesto/100) + ((A.Cantidad*A.PrecioUnitario)-MontoDesc) Monto,A.Comentario
,A.Estado Status,P.Descr DescrStatus
  FROM dbo.coOrdenCompraDetalle A
INNER JOIN dbo.invProducto P ON		A.IDProducto = P.IDProducto
INNER JOIN dbo.coEstadoOrdenCompra E ON A.Estado=E.IDEstadoOrden

WHERE 1=2


GO 

CREATE  PROCEDURE dbo.coUpdateOrdenCompraDetalle(@Operacion AS NVARCHAR(1),@IDOrdenCompra AS INT,@IDProducto AS BIGINT,@Cantidad AS DECIMAL(28,4),@CantidadAceptada AS DECIMAL(28,4),
									@CantidadRechazada AS DECIMAL(28,4),@PrecioUnitario AS DECIMAL(28,4), @Impuesto AS DECIMAL(28,4),@PorcDesc AS DECIMAL(28,4),
									@MontoDesc AS DECIMAL(28,4) ,@Estado AS INT, @Comentario AS NVARCHAR(20))
AS 

			
IF (@Operacion='I')
BEGIN
	INSERT INTO dbo.coOrdenCompraDetalle( IDOrdenCompra ,IDProducto ,Cantidad ,CantidadAceptada ,CantidadRechazada ,PrecioUnitario ,Impuesto ,PorcDesc ,MontoDesc ,Estado ,Comentario)
	VALUES (@IDOrdenCompra,@IDProducto,@Cantidad,@CantidadAceptada,@CantidadRechazada,@PrecioUnitario,@Impuesto,@PorcDesc,@MontoDesc,@Estado,@Comentario)
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.coOrdenCompraDetalle SET  Cantidad =@Cantidad,CantidadAceptada=@CantidadAceptada,CantidadRechazada=@CantidadRechazada,
							PrecioUnitario =@PrecioUnitario,Impuesto = @Impuesto,PorcDesc=@PorcDesc,MontoDesc= @MontoDesc,Estado =@Estado,Comentario =@Comentario
	 WHERE IDOrdenCompra=@IDOrdenCompra AND IDProducto=@IDProducto
END
IF (@Operacion='D')
BEGIN
	DELETE FROM dbo.coOrdenCompraDetalle WHERE IDOrdenCompra=@IDOrdenCompra AND (IDProducto=@IDProducto OR @IDProducto=-1)
END

GO


CREATE   PROCEDURE dbo.coUpdateEmbaque(@Operacion AS NVARCHAR(1),@IDEmbarque AS INT OUTPUT, @Embarque AS NVARCHAR(20) OUTPUT,@Fecha AS DATE, 
						@FechaEmbarque AS DATE,@Asiento AS NVARCHAR(20),@IDBodega AS INT, @IDProveedor AS INT, @IDOrdenCompra AS INT, 
						@IDDocumentoCP AS INT, @TipoCambio AS DECIMAL(28,4), @Usuario AS NVARCHAR(50),@CreateDate AS DATETIME, 
						@CreatedBy AS NVARCHAR(50),@RecordDate AS DATETIME,@UpdateBy AS NVARCHAR(50))
AS 
IF (@Operacion ='I')
BEGIN
	SET @IDEmbarque = 	(SELECT ISNULL(MAX(IDEmbarque),0) +1  FROM dbo.coEmbarque )
	
	DECLARE @IDConsecutivo  AS INT
	DECLARE @CodigoConsecutivo AS NVARCHAR(4)
	
	SET @IDConsecutivo = (SELECT IDConsecEmbarque  FROM dbo.coParametrosCompra WHERE IDParametro=1)
	EXEC [dbo].[invGetNextGlobalConsecutivo] @IDConsecutivo,@Embarque OUTPUT
	
	 INSERT INTO dbo.coEmbarque( IDEmbarque ,Embarque ,Fecha ,FechaEmbarque ,Asiento ,IDBodega ,IDProveedor ,IDOrdenCompra  ,IDDocumentoCP ,TipoCambio ,Usuario ,CreateDate ,CreatedBy ,RecordDate ,UpdateBy)
	 VALUES (@IDEmbarque,@Embarque,@Fecha,@FechaEmbarque,@Asiento,@IDBodega,@IDProveedor,@IDOrdenCompra,@IDDocumentoCP,@TipoCambio,@Usuario,@CreateDate,@CreatedBy,@RecordDate,@UpdateBy)
	 
	 UPDATE dbo.coOrdenCompra SET IDEmbarque=@IDEmbarque WHERE IDOrdenCompra =@IDOrdenCompra
	 
	 UPDATE dbo.globalConsecMask SET  Consecutivo=@Embarque WHERE Codigo='EMB'
	 
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.coEmbarque SET  FechaEmbarque=@FechaEmbarque, Asiento= @Asiento,IDBodega=@IDBodega,IDProveedor=@IDProveedor,
			IDOrdenCompra=@IDOrdenCompra,IDDocumentoCP=@IDDocumentoCP,RecordDate= @RecordDate,UpdateBy= @UpdateBy
	  WHERE IDEmbarque=@IDEmbarque
END
IF (@Operacion ='D')
BEGIN
	UPDATE dbo.coOrdenCompra SET  IDEmbarque = -1 WHERE IDEmbarque=@IDEmbarque
	DELETE FROM dbo.coEmbarque WHERE IDEmbarque=@IDEmbarque
END


GO

CREATE  PROCEDURE dbo.coGetEmbarque(@IDEmbarque AS INT,@FechaInicial AS DATE,@FechaFinal AS DATE,
																	@IDProveedor AS INT,@OrdenCompra AS NVARCHAR(20),@Embarque nvarchar(20),@IDDocumentoCP AS INT)
AS
set @FechaInicial = CONVERT(VARCHAR(25),@FechaInicial,101) 
set @FechaFinal = CAST(SUBSTRING(CAST(@FechaFinal AS CHAR),1,11) + ' 23:59:59.998' AS DATETIME)

SELECT A.IDEmbarque,A.Embarque,A.Fecha,A.FechaEmbarque,A.Asiento,A.IDBodega,B.Descr DescrBodega,A.IDProveedor,P.Nombre NombreProveedor,A.IDOrdenCompra,
			O.OrdenCompra,A.IDDocumentoCP,A.TipoCambio,A.Usuario,A.CreateDate,A.CreatedBy,A.RecordDate,A.UpdateBy
  FROM dbo.coEmbarque A
LEFT JOIN dbo.coOrdenCompra O ON A.IDOrdenCompra=O.IDOrdenCompra
INNER JOIN dbo.cppProveedor P ON A.IDProveedor=P.IDProveedor
INNER JOIN dbo.invBodega B ON A.IDBodega=B.IDBodega
WHERE (A.IDEmbarque =@IDEmbarque OR @IDEmbarque=-1) AND A.Fecha BETWEEN @FechaInicial AND @FechaFinal AND (A.IDProveedor =@IDProveedor OR @IDProveedor=-1)
 AND (O.OrdenCompra =@OrdenCompra OR o.OrdenCompra LIKE '%'+ @OrdenCompra +'%') AND (A.IDDocumentoCP = @IDDocumentoCP OR @IDDocumentoCP=-1)
AND (A.Embarque LIKE '%' + @Embarque + '%')

GO 

CREATE PROCEDURE dbo.coUpdateEmbarqueDetalle(@Operacion AS NVARCHAR(1),@IDEmbarque AS INT,@IDProducto AS bigint, @PrecioUnitario AS DECIMAL(28,8),@Impuesto DECIMAL(28,8),@PorcDesc DECIMAL(28,8),@MontoDesc DECIMAL(28,8), @CantidadOrdenada AS decimal(28,4), @CantidadAceptada AS decimal(28,4),@CantidadRechazada AS decimal(28,4),@Comentario AS nvarchar(20))
AS 
IF (@Operacion='I')
BEGIN
	INSERT INTO dbo.coEmbarqueDetalle( IDEmbarque ,IDProducto  ,PrecioUnitario,Impuesto,PorcDesc,MontoDesc,CantidadOrdenada ,CantidadAceptada ,CantidadRechazada ,Comentario)
	VALUES (@IDEmbarque,@IDProducto,@PrecioUnitario,@Impuesto,@PorcDesc,@MontoDesc,@CantidadOrdenada,@CantidadAceptada,@CantidadRechazada,@Comentario)
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.coEmbarqueDetalle SET  CantidadOrdenada=@CantidadOrdenada,CantidadAceptada=@CantidadAceptada,CantidadRechazada=@CantidadRechazada,
																Comentario=@Comentario
	 WHERE IDEmbarque=@IDEmbarque AND IDProducto=@IDProducto 
END
IF (@Operacion='D')
BEGIN
	DELETE FROM dbo.coEmbarqueDetalle WHERE IDEmbarque=@IDEmbarque AND( IDProducto=@IDProducto OR @IDProducto=-1) 
END

GO

CREATE PROCEDURE dbo.coGetEmbarqueDetalle(@IDEmbarque AS INT)
AS 
SELECT A.IDEmbarque,A.IDProducto,P.Descr DescrProducto,A.PrecioUnitario,A.Impuesto,A.PorcDesc,A.MontoDesc,A.CantidadOrdenada,A.CantidadAceptada,A.CantidadRechazada 
 FROM dbo.coEmbarqueDetalle A
INNER JOIN dbo.invProducto P ON A.IDProducto = P.IDProducto
WHERE (A.IDEmbarque =@IDEmbarque or @IDEmbarque =-1)

GO

CREATE PROCEDURE dbo.coUpdateRecepcionMercaderia(@Operacion NVARCHAR(1),@IDEmbarque INT, @IDProducto BIGINT,@IDLote AS INT,@Cantidad DECIMAL(28,8))
AS
IF (@Operacion='I')
BEGIN
	INSERT INTO dbo.coRecepcionMercaderia( IDEmbarque ,IDProducto ,IDLote ,Cantidad)
	VALUES (@IDEmbarque,@IDProducto,@IDLote,@Cantidad)
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.coRecepcionMercaderia SET  Cantidad=@Cantidad
	 WHERE IDEmbarque=@IDEmbarque AND IDProducto=@IDProducto  AND IDLote=@IDLote
END
IF (@Operacion='D')
BEGIN
	DELETE FROM dbo.coRecepcionMercaderia WHERE IDEmbarque=@IDEmbarque AND( IDProducto=@IDProducto OR @IDProducto=-1) AND ( IDLote=@IDLote OR @IDLote=-1) 
END


GO

CREATE  PROCEDURE dbo.coGetRecepcionMercaderia(@IDEmbarque AS INT)
AS 
SELECT A.IDEmbarque,A.IDProducto,A.IDLote,P.Descr DescrProducto,A.Cantidad
 FROM dbo.coRecepcionMercaderia A
INNER JOIN dbo.invProducto P ON A.IDProducto = P.IDProducto 
LEFT  JOIN dbo.invLote L ON A.IDProducto=L.IDProducto AND A.IDLote=L.IDLote
WHERE (A.IDEmbarque =@IDEmbarque or @IDEmbarque =-1)


GO


CREATE PROCEDURE dbo.invGetGlobalPais(@IDPais AS INT)
AS 
SELECT IDPais,Descr,Activo  FROM dbo.globalPais
WHERE (IDPais = @IDPais OR @IDPais = -1) AND Activo=1

GO


CREATE   PROCEDURE dbo.coGetProveedor(@IDProveedor AS INT,@Nombre NVARCHAR(250))
AS	
SELECT  IDProveedor ,
        Nombre ,
        RUC ,
        Activo,Bonifica  FROM dbo.cppProveedor WHERE (IDProveedor = @IDProveedor OR @IDProveedor=-1) AND (Nombre LIKE '%' + @Nombre + '%' OR @Nombre ='*')
        
GO


CREATE   PROCEDURE dbo.coGetSolicitudesByProveedor (@IDProveedor AS int	, @IDSolicitudDesde AS INT,@IDSolicitudHasta AS INT, @FechaSolicitudDesde AS DATETIME, @FechaSolicitudHasta AS DATETIME, 
				@FechaRequeridaDesde AS DATETIME, @FechaRequeridaHasta AS DATETIME,@IDClasif1 AS INT,@IDClasif2 AS INT,@IDClasif3 AS INT,
				@IDClasif4 AS INT,@IDClasif5 AS INT,@IDClasif6 AS INT,@IDProducto AS BIGINT)
AS

IF (@IDSolicitudDesde =-1)
	SET @IDSolicitudDesde =  (SELECT isnull(MIN(IDSolicitud),0) FROM dbo.coSolicitudCompra)

IF (@IDSolicitudHasta =-1)
	SET @IDSolicitudHasta =  (SELECT isnull(Max(IDSolicitud),0) FROM dbo.coSolicitudCompra)

SELECT A.IDSolicitud,A.Fecha,A.FechaRequerida,B.IDProducto,P.Descr DescrProducto,ISNULL(SUM(B.Cantidad),0) - isnull(SUM(B.CantidadOrdenada),0) Cantidad,
  0 CantOrdenada,B.Comentario
 FROM dbo.coSolicitudCompra A
INNER JOIN dbo.coSolicitudCompraDetalle B ON A.IDSolicitud = B.IDSolicitud
INNER JOIN dbo.invProducto P ON B.IDProducto = P.IDProducto
WHERE (A.IDSolicitud BETWEEN @IDSolicitudDesde AND @IDSolicitudHasta) AND (FechaRequerida  BETWEEN @FechaRequeridaDesde AND @FechaRequeridaHasta)
AND (P.Clasif1 = @IDClasif1 OR @IDClasif1=-1) AND  (P.Clasif2 = @IDClasif2 OR @IDClasif2=-1) AND  (P.Clasif3 = @IDClasif3 OR @IDClasif3=-1) 
AND  (P.Clasif4 = @IDClasif4 OR @IDClasif4=-1) AND  (P.Clasif5 = @IDClasif5 OR @IDClasif5=-1) AND  (P.Clasif6 = @IDClasif6 OR @IDClasif6=-1) AND (B.IDProducto = @IDProducto OR @IDProducto=-1)
AND P.IDProveedor = @IDProveedor  AND A.IDEstado  IN (1) 
GROUP BY A.IDSolicitud,A.Fecha,A.FechaRequerida,B.IDProducto,P.Descr,B.Comentario
HAVING  ISNULL(SUM(B.Cantidad),0) - isnull(SUM(B.CantidadOrdenada),0) >0


GO

CREATE   PROCEDURE dbo.coConfirmarOrdenCompra @IDOrdenCompra  AS INT
AS

UPDATE dbo.coOrdenCompra SET IDEstado=2
WHERE IDOrdenCompra = @IDOrdenCompra

GO 

CREATE PROCEDURE dbo.coSetEmbarqueToTransito @IDEmbarque AS int	
AS 

SELECT B.IDProducto,A.IDBodega,B.CantidadAceptada Cantidad INTO #tmpProducto   FROM dbo.coEmbarque A
INNER JOIN dbo.coEmbarqueDetalle B ON A.IdEmbarque = B.IdEmbarque
WHERE A.IDEmbarque = @IDEmbarque 

INSERT INTO dbo.invExistenciaBodega( IDBodega ,IDProducto ,IDLote ,Existencia ,Reservada ,Transito)
SELECT A.IDBodega,A.IDProducto,0,0,0,0  FROM #tmpProducto A
LEFT JOIN dbo.invExistenciaBodega B ON A.IDBodega = B.IDBodega AND A.IDProducto = B.IDProducto
WHERE B.IDProducto IS NULL

UPDATE  B SET B.Transito = B.Transito + A.Cantidad  FROM #tmpProducto A
INNER JOIN dbo.invExistenciaBodega B ON A.IDBodega = B.IDBodega AND A.IDProducto = B.IDProducto

DROP TABLE #tmpProducto


GO


CREATE PROCEDURE dbo.coUnSetEmbarqueToTransito(@IDEmbarque AS INT)
AS 
SELECT B.IDProducto,A.IDBodega,B.CantidadAceptada Cantidad INTO #tmpProducto   FROM dbo.coEmbarque A
INNER JOIN dbo.coEmbarqueDetalle B ON A.IdEmbarque = B.IdEmbarque
WHERE A.IDEmbarque = @IDEmbarque 

UPDATE  B SET B.Transito = B.Transito - A.Cantidad  FROM #tmpProducto A
INNER JOIN dbo.invExistenciaBodega B ON A.IDBodega = B.IDBodega AND A.IDProducto = B.IDProducto

DROP TABLE #tmpProducto


GO

CREATE PROCEDURE dbo.coDesConfirmarOrdenCompra @IDOrdenCompra  AS INT
AS

UPDATE dbo.coOrdenCompra SET IDEstado=1
WHERE IDOrdenCompra = @IDOrdenCompra


GO


CREATE PROCEDURE dbo.coCancelarOrdenCompra @IDOrdenCompra  AS INT
AS

UPDATE dbo.coOrdenCompra SET IDEstado=4
WHERE IDOrdenCompra = @IDOrdenCompra


GO


--CREATE PROCEDURE dbo.invCreateEmbarqueFromOrdenCompra( @IDOrdenCompra AS INT,@Usuario AS NVARCHAR(50))
--AS 

--DECLARE @IDEmbarque AS INT

--SET @IDEmbarque = (SELECT ISNULL(MAX(IDEmbarque),0) FROM dbo.coEmbarque)

--INSERT INTO dbo.coEmbarque( IDEmbarque ,Embarque ,Fecha ,FechaEmbarque ,Asiento ,IDBodega ,IDProveedor ,IDOrdenCompra ,IDDocumentoCP ,TipoCambio ,Usuario ,CreateDate ,CreatedBy ,RecordDate ,UpdateBy)
--SELECT  @IDEmbarque,'--',GETDATE(),GETDATE() ,null,IDBodega ,IDProveedor ,IDOrdenCompra,-1 ,0 TC, ,Usuario ,UsuarioCreaEmbarque ,FechaCreaEmbarque , Usuario,GETDATE(),Usuario,GETDATE(),Usuario 
--FROM dbo.coOrdenCompra
--WHERE IDOrdenCompra=@IDOrdenCompra

--INSERT INTO dbo.coEmbarqueDetalle( IDEmbarque ,IDProducto ,IDLote ,Cantidad ,CantidadAceptada ,CantidadRechazada ,Comentario)

--SELECT  @IDEmbarque ,IDProducto ,Cantidad ,CantidadAceptada ,CantidadRechazada ,PrecioUnitario ,Impuesto ,PorcDesc ,MontoDesc ,Estado ,Comentario  
--FROM dbo.coOrdenCompraDetalle WHERE IDOrdenCompra=@IDOrdenCompra

CREATE PROCEDURE dbo.coGetEmbarqueByID(@IDEmbarque AS INT,@IDOrdenCompra AS INT)
AS 
IF (@IDEmbarque =-1)
BEGIN
SELECT  -1 IDEmbarque ,'--' Embarque ,GETDATE() Fecha ,B.FechaRequerida FechaEmbarque ,NULL Asiento ,B.IDBodega ,D.Descr DescrBodega,B.IDProveedor ,C.Nombre NombreProveedor,B.IDOrdenCompra,B.OrdenCompra ,-1 IDDocumentoCP ,
			0 TipoCambio, 0 Confirmado
	FROM dbo.coEmbarque A
	RIGHT  JOIN dbo.coOrdenCompra B ON A.IDOrdenCompra = B.IDOrdenCompra
	LEFT  JOIN dbo.cppProveedor C ON B.IDProveedor=C.IDProveedor
	LEFT  JOIN dbo.invBodega D ON B.IDBodega=D.IDBodega
	WHERE B.IDOrdenCompra = @IDOrdenCompra
	
END 
ELSE	
BEGIN	
	SELECT  A.IDEmbarque ,A.Embarque ,A.Fecha ,A.FechaEmbarque ,A.Asiento ,A.IDBodega ,D.Descr DescrBodega,B.IDProveedor ,C.Nombre NombreProveedor,A.IDOrdenCompra,B.OrdenCompra ,A.IDDocumentoCP ,
			A.TipoCambio ,A.Usuario , A.Confirmado ,A.CreateDate ,A.CreatedBy ,A.RecordDate ,A.UpdateBy  
	FROM dbo.coEmbarque A
	LEFT  JOIN dbo.coOrdenCompra B ON A.IDOrdenCompra = B.IDOrdenCompra
	LEFT  JOIN dbo.cppProveedor C ON B.IDProveedor=C.IDProveedor
	LEFT  JOIN dbo.invBodega D ON A.IDBodega=D.IDBodega
	WHERE (A.IDEmbarque =@IDEmbarque OR @IDEmbarque=-7) AND (a.IDOrdenCompra=@IDOrdenCompra or @IDOrdenCompra=-7)
END

GO

CREATE   PROCEDURE dbo.coUpdateProveedor(@Operacion AS  nvarchar(1), @IDProveedor AS int	 OUTPUT,@Nombre AS nvarchar(250),@RUC AS NVARCHAR(50)	,
@Activo AS bit	,@Alias nvarchar(50), @IDPais AS int,@IDMoneda AS int,@FechaIngreso AS datetime,@Contacto AS nvarchar(50), @Telefono nvarchar(50), 
@IDCategoria AS int	,@IDCondicionPago AS int	,@PorcDescuento AS decimal(28,4), @PorcInteresMora AS decimal(28,4),
@Email AS nvarchar(50),@Direccion AS nvarchar(500),@MultiMoneda bit ,@PagosCongelados bit ,@IsLocal BIT,@Bonifica BIT )
AS 
IF (@Operacion ='I') 
BEGIN
	SET @IDProveedor = (SELECT  ISNULL(MAX(IDProveedor),0) + 1 FROM dbo.cppProveedor )
	INSERT INTO dbo.cppProveedor( Nombre ,RUC ,Activo ,Alias ,IDPais ,IDMoneda ,FechaIngreso ,Contacto ,Telefono  ,IDCategoria ,IDCondicionPago ,
	          PorcDesc ,PorcInteresMora ,email ,Direccion,MultiMoneda,PagosCongelados,IsLocal,Bonifica)
	VALUES  ( @Nombre ,@RUC,@Activo,@Alias,@IDPais,@IDMoneda,@FechaIngreso,@Contacto,@Telefono,@IDCategoria,@IDCondicionPago,@PorcDescuento,@PorcInteresMora,@Email, @Direccion,@MultiMoneda,@PagosCongelados,@IsLocal,@Bonifica)
	SET @IDProveedor = @@IDENTITY
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.cppProveedor SET Nombre = @Nombre ,Alias = @Alias, IDPais = @IDPais, IDMoneda= @IDMoneda,FechaIngreso=@FechaIngreso,
				Contacto =@Contacto,Telefono = @Telefono, IDCategoria = @IDCategoria,IDCondicionPago =@IDCondicionPago,RUC=@RUC,
				PorcDesc = @PorcDescuento, PorcInteresMora = @PorcInteresMora, email = @Email, Direccion = @Direccion, MultiMoneda = @MultiMoneda, 
				PagosCongelados = @PagosCongelados, IsLocal = @IsLocal,Bonifica=@Bonifica
	WHERE IDProveedor = @IDProveedor
END
IF (@Operacion='D') 
BEGIN
	DELETE FROM dbo.cppProveedor WHERE IDProveedor =@IDProveedor
END

GO

CREATE   PROCEDURE dbo.cppGetProveedor(@IDProveedor AS INT,@Nombre AS NVARCHAR(20), @IDCategoria AS INT)
AS 
SELECT    IDProveedor ,A.Nombre ,A.Alias ,Contacto ,A.RUC,Telefono ,a.IDCategoria ,D.Descr DescrCategoria,A.IDPais ,E.Descr Pais,a.IDMoneda ,F.Descr Moneda,A.IDCondicionPago ,G.Descr DescrCondicionPago,
        FechaIngreso ,PorcDesc ,PorcInteresMora ,Email ,Direccion ,A.Activo ,MultiMoneda ,PagosCongelados ,IsLocal,Bonifica
FROM dbo.cppProveedor A
LEFT JOIN dbo.cppCategoriaProveedor D ON A.IDCategoria = D.IDCategoria
LEFT JOIN dbo.globalPais E ON A.IDPais = E.IDPais
LEFT JOIN dbo.globalMoneda F ON F.IDMoneda = A.IDMoneda
LEFT JOIN dbo.cppCondicionPago G ON A.IDCondicionPago=G.IDCondicionPago
WHERE (IDProveedor = @IDProveedor OR @IDProveedor = -1) AND (A.Nombre LIKE '%'+@Nombre+'%' OR @Nombre='*') AND (a.IDCategoria = @IDCategoria OR @IDCategoria=-1)


GO

CREATE PROCEDURE  dbo.cppUpdateCategoriaPoveedor  @Operacion AS NVARCHAR(1), @IDCategoria AS INT OUTPUT, @Descr AS NVARCHAR(255), @Ctr_CXP AS INT, @Cta_CXP BIGINT,
	@Ctr_Letra_CXP INT, @Cta_Letra_CXP BIGINT,@Ctr_ProntoPago_CXP INT, @Cta_ProntoPago_CXP BIGINT,@Ctr_Comision_CXP INT, @Cta_Comision_CxP BIGINT,
	@Ctr_Anticipos_CXP INT, @Cta_Anticipos_CXP BIGINT, @Ctr_CierreDebitos_CXP INT, @Cta_CierreDebitos_CXP BIGINT, @Ctr_Impuestos_CXP INT, @Cta_Impuestos_CXP BIGINT,
	@Activo AS INT
AS
IF (@Operacion='I')
BEGIN	
	SET @IDCategoria = (SELECT isnull(MAX(IDCategoria),0) + 1  FROM dbo.cppCategoriaProveedor)
	INSERT INTO dbo.cppCategoriaProveedor(IDCategoria,Descr,Ctr_CXP,Cta_CXP,Ctr_Letra_CXP,Cta_Letra_CXP,Ctr_ProntoPago_CXP,Cta_ProntoPago_CXP,
						Ctr_Comision_CXP,Cta_Comision_CXP,Ctr_Anticipos_CXP,Cta_Anticipos_CXP,Ctr_CierreDebitos_CXP,Cta_CierreDebitos_CXP,Ctr_Impuestos_CXP,
						Cta_Impuestos_CXP, Activo)
	VALUES (@IDCategoria,@Descr,@Ctr_CXP,@Cta_CXP,@Ctr_Letra_CXP,@Cta_Letra_CXP,@Ctr_ProntoPago_CXP,@Cta_ProntoPago_CXP,
						@Ctr_Comision_CXP,@Cta_Comision_CXP,@Ctr_Anticipos_CXP,@Cta_Anticipos_CXP,@Ctr_CierreDebitos_CXP,@Cta_CierreDebitos_CXP,@Ctr_Impuestos_CXP,
						@Cta_Impuestos_CXP, @Activo)
END	
IF (@Operacion='U') 
BEGIN
	UPDATE dbo.cppCategoriaProveedor SET Descr = @Descr,Ctr_CXP = @Ctr_CXP,Cta_CXP = @Cta_CXP,Ctr_Letra_CXP= @Ctr_Letra_CXP,Cta_Letra_CXP= @Cta_Letra_CXP,
						Ctr_ProntoPago_CXP = @Ctr_ProntoPago_CXP,Cta_ProntoPago_CXP = @Cta_ProntoPago_CXP,Ctr_Comision_CXP =	@Ctr_Comision_CXP, Cta_Comision_CXP = @Cta_Comision_CXP,
						Ctr_Anticipos_CXP = @Ctr_Anticipos_CXP,Cta_Anticipos_CXP = @Cta_Anticipos_CXP,Ctr_CierreDebitos_CXP = @Ctr_CierreDebitos_CXP, Cta_CierreDebitos_CXP =@Cta_CierreDebitos_CXP,
						Ctr_Impuestos_CXP =@Ctr_Impuestos_CXP,Cta_Impuestos_CXP=	@Cta_Impuestos_CXP, Activo =@Activo
	WHERE IDCategoria = @IDCategoria					
END	
IF (@Operacion='D')
BEGIN	
	DELETE FROM dbo.ccpCategoriaProveedor WHERE IDCategoria= @IDCategoria
END	

GO

CREATE   PROCEDURE dbo.cppGetCategoriaProveedor(@IDCategoria INT, @Descripcion AS NVARCHAR(250))
AS 
SELECT  IDCategoria ,Descr ,Ctr_CXP ,Cta_CXP ,  Ctr_Letra_CXP ,Cta_Letra_CXP ,Ctr_ProntoPago_CXP ,Cta_ProntoPago_CXP ,Ctr_Comision_CXP ,
        Cta_Comision_CXP ,Ctr_Anticipos_CXP ,Cta_Anticipos_CXP ,Ctr_CierreDebitos_CXP ,Cta_CierreDebitos_CXP ,Ctr_Impuestos_CXP ,Cta_Impuestos_CxP ,
        Activo  FROM dbo.cppCategoriaProveedor
WHERE ( IDCategoria=@IDCategoria OR @IDCategoria =-1) AND (Descr LIKE '%' + @Descripcion+ '%' OR @Descripcion ='*')

GO

CREATE PROCEDURE dbo.globalTipoImpuesto(@IDImpuesto AS int) 
AS 
SELECT  IDImpuesto ,
        Descr ,
        Porc ,
        Activo  FROM dbo.globalImpuesto
WHERE (IDImpuesto = @IDImpuesto OR @IDImpuesto=-1)

GO

CREATE PROCEDURE dbo.coGetParametrosCompra
AS 
SELECT  IDParametro ,
        IDConsecSolicitud ,
        IDConsecOrdenCompra ,
        IDConsecEmbarque ,
        IDConsecDevolucion ,
        IDConsecLiquidacion,
        CantLineasOrdenCompra ,
        IDBodegaDefault ,
        IDTipoCambio ,
        CantDecimalesPrecio ,
        CantDecimalesCantidad ,
        IDTipoAsientoContable ,
        IDPaquete ,
        CtaTransitoLocal ,
        CtrTransitoLocal ,
        CtaTransitoExterior ,
        CtrTransitoExterior ,
        AplicaAutomaticamenteAsiento ,
        CanEditAsiento ,
        CanViewAsiento  FROM dbo.coParametrosCompra
        
        
        GO
        
        
CREATE  PROCEDURE dbo.coUpdateParametrosCompra ( @IDConsecSolicitud INT, @IDConsecOrdeCompra INT, @IDConsecEmbarque INT, @IDConsecDevolucion INT, @IDConsecLiquidacion INT, @CantLineasOrdenCompra INT, @IDBodegaDefault int,
	@IDTipoCambio NVARCHAR(20), @CantDecimalesPrecio int, @CantDecimalesCantidad int, @IDTipoAsientoContable NVARCHAR(2), @IDPaquete INT, @CtaTransitoLocal bigint, @CtrTransitoLocal bigint, @CtaTransitoExterior bigint, @CtrTransitoExterior bigint,
	@AplicaAutomaticamenteAsiento bit, @CanEditAsiento bit, @CanViewAsiento bit )
AS 
UPDATE dbo.coParametrosCompra SET IDConsecSolicitud = @IDConsecSolicitud,IDConsecOrdenCompra=@IDConsecOrdeCompra , IDConsecEmbarque=@IDConsecEmbarque,IDConsecDevolucion= @IDConsecDevolucion,IDConsecLiquidacion=@IDConsecLiquidacion,CantLineasOrdenCompra = @CantLineasOrdenCompra, 
	IDBodegaDefault  = @IDBodegaDefault, IDTipoCambio= @IDTipoCambio, CantDecimalesPrecio= @CantDecimalesPrecio,CantDecimalesCantidad= @CantDecimalesCantidad, IDTipoAsientoContable = @IDTipoAsientoContable, IDPaquete = @IDPaquete,  CtaTransitoLocal = @CtaTransitoLocal,
	CtrTransitoLocal  = @CtrTransitoLocal, CtaTransitoExterior = @CtaTransitoExterior, AplicaAutomaticamenteAsiento =@AplicaAutomaticamenteAsiento, CanEditAsiento = @CanEditAsiento, CanViewAsiento=@CanViewAsiento
	WHERE IDParametro=1
	
GO


CREATE PROCEDURE dbo.globalGetConsecutivos(@IDConsecutivo INT, @Prefijo AS NVARCHAR(3))
AS 
SELECT  IDConsecutivo ,Descr ,Prefijo ,Consecutivo ,Documento ,Activo  
FROM dbo.globalconsecutivos
WHERE (IDConsecutivo = @IDConsecutivo OR @IDConsecutivo =-1) AND (Prefijo = @Prefijo OR @Prefijo = '*')

GO 


CREATE  PROCEDURE dbo.coGetParametroCompra(@Parametro AS NVARCHAR(200)) 
AS 
--SET @Paremetro='IDConsecSolicitud'
DECLARE @SQL AS NVARCHAR(1000) 
SET @SQL=  'SELECT '+ @Parametro +' FROM dbo.coParametrosCompra WHERE IDParametro=1'

EXEC (@SQL)


GO


CREATE  PROCEDURE dbo.coUpdateCantRecibidaOrdenCompra(@IDOrdenCompra INT,@IDProducto AS INT, @Cantidad AS  DECIMAL(28,4))
AS 
UPDATE dbo.coOrdenCompraDetalle SET CantidadAceptada = @Cantidad 
WHERE IDOrdenCompra =@IDOrdenCompra AND (IDProducto = @IDProducto OR @IDProducto=-1)

GO



CREATE  PROCEDURE dbo.coCreaPaqueteEmbarque(@Modulo AS NVARCHAR(4),@IDDocumento AS INT,@Usuario AS NVARCHAR(50),@IDTransaccion AS BIGINT OUTPUT )
AS 
/*SET @Modulo = 'COM'
SET @IDDocumento= 1
SET @Usuario= 'jespinoza'
*/
DECLARE @IDConsecutivo  AS INT
DECLARE @DocumentoInv AS NVARCHAR(20)
DECLARE @FechaDocumento DATE
DECLARE @Referencia AS NVARCHAR(250)
DECLARE @Documento AS NVARCHAR(20) --//Numero del documento Fisico
DECLARE @Transaccion AS NVARCHAR(2)
DECLARE @IDTipoTran AS INT
DECLARE @Factor AS INT
DECLARE @IDPaquete AS INT 
DECLARE @TipoCambioCont AS NVARCHAR(4)
DECLARE @TipoCambio AS DECIMAL(28,4)	
DECLARE @Naturaleza AS NVARCHAR(1)


IF (@Modulo = 'CO')
BEGIN
	--//Leer parametros de configuración
	SELECT TOP	1 @IDPaquete = IDPaquete, @TipoCambioCont= IDTipoCambio  FROM dbo.coParametrosCompra
	
	IF (@IDPaquete IS NULL)
	BEGIN
		RAISERROR ( 'GENERACIÓN DEL DOCUMENTO: Revise los parametros de Compra, si el paquete de inventario se encuentra establecido', 16, 1) ;
		return		
	END
	
	SELECT @FechaDocumento = A.Fecha, @Referencia = 'Emabarque: ' + A.Embarque  + ', Orden de Compra: ' + B.OrdenCompra, @Documento = a.Embarque
	 FROM dbo.coEmbarque A
	 INNER JOIN dbo.coOrdenCompra B ON  A.IDOrdenCompra = B.IDOrdenCompra
	  WHERE A.IDEmbarque =@IDDocumento 
	 
	--//Cargar el Tipo de Cambio Contabilidad
	SELECT @TipoCambio = dbo.globalGetTipoCambio(@FechaDocumento,@TipoCambioCont) 
	  
	--//Crear la cabecera del Documento  
	EXEC  dbo.invUpdateDocumentoInv  @Operacion = N'I', -- nvarchar(1)
	    @IDTransaccion = @IDTransaccion OUTPUT, -- int
	    @ModuloOrigen = N'CO', -- nvarchar(4)
	    @IDPaquete =@IDPaquete, -- int
	    @Fecha = @FechaDocumento, -- datetime
	    @Usuario =@Usuario, -- nvarchar(20)
	    @Referencia = @Referencia, -- nvarchar(250)
	    @Documento = @Documento OUTPUT, -- nvarchar(250)
	    @Aplicado = 1, -- bit
	    @EsTraslado = 0, -- bit
	    @IDTraslado = -1 -- int
	
	--//Obtener las transacciones asociadas al Paquete.
	SELECT @IDTipoTran =IDTipoTran, @Factor = Factor,@Naturaleza = Naturaleza, @Transaccion=Transaccion  
	FROM dbo.globalTipoTran WHERE  Transaccion = (SELECT Transaccion  FROM dbo.invPaquete WHERE IDPaquete=@IDPaquete) 

	--//Insertar el detalle del documento
	
	
	INSERT INTO dbo.invTransaccionLinea( IDTransaccion ,IDProducto ,IDLote ,IDTipoTran ,IDBodega ,IDTraslado , Naturaleza ,Factor ,Cantidad ,CostoUntLocal ,CostoUntDolar ,PrecioUntLocal ,PrecioUntDolar ,Transaccion ,TipoCambio ,Aplicado)
	SELECT @IDTransaccion, A.IDProducto,A.IDLote,@IDTipoTran,O.IDBodega,-1 IDTranslado,@Naturaleza,@Factor ,A.Cantidad, P.CostoPromLocal,CostoPromDolar,CASE WHEN O.IDMoneda=1 THEN OD.PrecioUnitario ELSE OD.PrecioUnitario * @TipoCambio END PrecioUnitarioLocal, CASE WHEN O.IDMoneda=1 THEN OD.PrecioUnitario / @TipoCambio ELSE Od.PrecioUnitario END PrecioUnitarioDolar,@Transaccion, @TipoCambio, 0 Aplicado
	FROM dbo.coRecepcionMercaderia A
	INNER JOIN dbo.invProducto P ON A.IDProducto=P.IDProducto
	INNER JOIN dbo.coOrdenCompra O ON A.IDEmbarque=O.IDEmbarque
	INNER JOIN dbo.coOrdenCompraDetalle OD ON O.IDOrdenCompra = OD.IDOrdenCompra AND OD.IDProducto=A.IDProducto
	WHERE A.IDEmbarque=@IDDocumento

	UPDATE dbo.coEmbarque SET DocumentoInv =  @Documento

END  

GO




CREATE  PROCEDURE dbo.coGeneraAsientoContableEmbarque @Modulo AS NVARCHAR(4), @IDDocumento AS INT,@Usuario AS NVARCHAR(50),@Asiento AS NVARCHAR(20) OUTPUT 
AS
--BEGIN TRAN
/*
SET @Modulo = 'FAC'
SET @IDDocumento= 2
SET @Usuario= 'jespinoza'
*/

DECLARE @Documento AS NVARCHAR(20)
DECLARE @FechaDocumento AS NVARCHAR(20)
DECLARE @TipoCambio AS DECIMAL(28,4)
DECLARE @TipoFactura AS INT
DECLARE @CodCliente AS INT
DECLARE @CtrTransitoExterior AS  BIGINT
DECLARE @CtaTransitoExterior AS BIGINT

SELECT @CtrTransitoExterior = CtrTransitoExterior, @CtaTransitoExterior = CtaTransitoExterior  
FROM dbo.coParametrosCompra WHERE IDParametro=1



--//Seleccionar el documento y Fechas
SELECT @Documento = Embarque,@FechaDocumento = Fecha,@TipoCambio = TipoCambio
FROM dbo.coEmbarque WHERE IDEmbarque=@IDDocumento


DECLARE @Rows AS INT
DECLARE @Fecha AS DATE

SET @Fecha =  DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,@FechaDocumento)+1,0))
DECLARE @IDEjercicio AS INT,@Periodo NVARCHAR(10), @Cerrado AS BIT,@Activo AS BIT

SELECT  @IDEjercicio =IDEjercicio ,
        @Periodo = Periodo ,
        @Cerrado =Cerrado,
        @Activo = Activo
  FROM dbo.cntPeriodoContable WHERE FechaFinal=@Fecha

IF (@Cerrado =1 OR @Activo=0) 
BEGIN
	RAISERROR ( 'GENERACIÓN DEL ASIENTO CONTABLE: La fecha del documento que desea generar esta fuera del periodo de trabajo', 16, 1) ;
	return		
END

IF ( @CtaTransitoExterior IS NULL )
BEGIN
	RAISERROR('VERIFIQUE LOS PARAMETROS DE FACTURA:  La cuenta de transito no es definida',16,1);
	RETURN
END

if (@CtrTransitoExterior IS NULL)
BEGIN	
	RAISERROR('VERIFIQUE LOS PARAMETROS DE FACTURA: El centro de costo de transito no es definida',16,1);
	RETURN
END

 EXEC [dbo].[globalGetNextConsecutivo] 'CO', @Asiento OUTPUT
	
INSERT INTO dbo.cntAsiento( IDEjercicio ,Periodo ,Asiento ,Tipo ,Fecha ,FechaHora ,Createdby ,CreateDate ,
						Mayorizadoby ,MayorizadoDate ,Anuladoby ,AnuladoDate ,Concepto ,Mayorizado ,Anulado ,TipoCambio ,ModuloFuente ,CuadreTemporal)
VALUES (	@IDEjercicio,@Periodo	,@Asiento,'CO',@FechaDocumento,GETDATE(),@Usuario,GETDATE(),NULL,NULL,NULL,NULL,'Embarque: ' + @Documento,0,0,@TipoCambio,'CO',0)		
						

SELECT B.IDProducto,A.IDBodega,SUM(B.Cantidad) Cantidad,CASE WHEN C.IDMoneda=1 THEN  D.PrecioUnitario ELSE D.PrecioUnitario * @TipoCambio END PrecioLocal, 
			CASE WHEN C.IDMoneda=1 THEN  D.PrecioUnitario / @TipoCambio ELSE d.PrecioUnitario END PrecioDolar ,P.CostoPromLocal,P.CostoPromDolar,CC.CtaInventario, CC.CtrInventario  INTO #tmpEmbarque
FROM dbo.coEmbarque A
INNER JOIN dbo.coEmbarqueDetalle B ON A.IDEmbarque = B.IDEmbarque
INNER JOIN dbo.coOrdenCompra C ON A.IDEmbarque = C.IDEmbarque
INNER JOIN dbo.coOrdenCompraDetalle D ON C.IDOrdenCompra = D.IDOrdenCompra AND B.IDProducto = D.IDProducto 
INNER JOIN dbo.invProducto P ON B.IDProducto = P.IDProducto
INNER JOIN dbo.invCuentaContable CC ON P.IDCuentaContable = CC.IDCuenta
WHERE A.IDEmbarque = @IDDocumento
GROUP BY B.IDProducto,A.IDBodega,C.IDMoneda,PrecioUnitario,CostoPromDolar,CostoPromLocal,CC.CtaInventario, CC.CtrInventario 

SET @Rows = @@ROWCOUNT



DECLARE @IDProducto AS INT,@IDBodega AS INT,@IDLote AS INT,@Cantidad AS DECIMAL(28,4),@PrecioLocal AS DECIMAL(28,4),@PrecioDolar AS DECIMAL(28,4),
@CostoPromDolar AS DECIMAL(28,4),@CostoPromLocal AS DECIMAL(28,4),@CtrInventario AS BIGINT, @CtaInventario AS BIGINT

ALTER TABLE #tmpEmbarque ADD	 ID INT IDENTITY(1,1)

DECLARE @i AS INT
DECLARE @Linea AS INT
SET @i=1
SET @Linea = 0

WHILE (@Rows>=@i)
BEGIN
	SELECT @IDProducto = IDProducto, @IDBodega = IDBodega, @Cantidad = Cantidad, @PrecioLocal = PrecioLocal, @PrecioDolar = PrecioDolar,
	@CostoPromDolar = CostoPromDolar,@CostoPromLocal = CostoPromLocal,
	@CtaInventario = CtaInventario,@CtrInventario = CtrInventario
	  FROM #tmpEmbarque WHERE ID =@Rows
	  
	 
	 --//cuenta de Transito
	SET @Linea = @Linea + 1 
	INSERT INTO dbo.cntAsientoDetalle( Asiento ,Linea ,IDCentro ,IDCuenta ,Referencia ,Debito ,Credito ,Documento ,daterecord)
	VALUES (@Asiento,@Linea,@CtrTransitoExterior,@CtaTransitoExterior,'Transito: Compra de ' + CAST(@IDProducto AS NVARCHAR(20)) + 'CI-' + @Documento, 0,@CostoPromLocal * @Cantidad,@Documento,GETDATE())
	
	 --//Inventario
	SET @Linea = @Linea + 1 
	INSERT INTO dbo.cntAsientoDetalle( Asiento ,Linea ,IDCentro ,IDCuenta ,Referencia ,Debito ,Credito ,Documento ,daterecord)
	VALUES (@Asiento,@Linea,@CtrInventario,@CtaInventario,'Inventario: compra de ' + CAST(@IDProducto AS NVARCHAR(20)) + 'CI-' + @Documento, @CostoPromLocal * @Cantidad,0,@Documento,GETDATE())

	
	SET @i = @i +1
END

UPDATE dbo.coEmbarque SET  Asiento = @Asiento WHERE IDEmbarque = @IDDocumento

DROP TABLE #tmpEmbarque

GO


CREATE PROCEDURE dbo.coUpdateGastosCompra(@Operacion NVARCHAR(1), @IDGasto AS INT OUTPUT,@Descripcion NVARCHAR(250) , @Activo BIT)
AS 
IF (@Operacion='I')  
BEGIN
	INSERT INTO dbo.coGastosCompra( Descripcion, Activo )
	VALUES (@Descripcion,@Activo)
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.coGastosCompra  SET Descripcion = @Descripcion, Activo = @Activo
	WHERE IDGasto=@IDGasto AND flgReadOnly=0
END
IF (@Operacion ='D')
BEGIN
	DELETE dbo.invGastoCompra WHERE IDGasto=@IDGasto AND flgReadOnly=0
END


GO


CREATE PROCEDURE dbo.coGetGastosCompra(@IDGasto INT, @Descripcion NVARCHAR(250))
AS 
SELECT   IDGasto ,Descripcion ,flgReadOnly,Activo
FROM dbo.coGastosCompra
WHERE (IDGasto = @IDGasto OR @IDGasto =-1) AND (Descripcion = @Descripcion OR @Descripcion = '*') AND Activo=1 AND flgReadOnly=0


GO

CREATE PROCEDURE dbo.coUpdateLiquidacionCompra(@Operacion NVARCHAR(1), @IDLiquidacion AS INT OUTPUT,@IDEmbarque AS INT , @IDOrdenCompra AS int,@Fecha DateTime,@TipoCambio decimal(28,8), @ValorMercaderia Decimal(28,8),@MontoFlete decimal(28,8), @MontoSeguro decimal(28,8), @Otros AS Decimal(28,8), @MontoTotal AS Decimal(28,8))
AS 
IF (@Operacion='I')  
BEGIN
	
	DECLARE @IDConsecutivo  AS INT
	DECLARE @Liquidacion AS NVARCHAR(20)
	
	SET @IDConsecutivo = (SELECT IDConsecLiquidacion  FROM dbo.coParametrosCompra WHERE IDParametro=1)
	EXEC [dbo].[invGetNextGlobalConsecutivo] @IDConsecutivo,@Liquidacion OUTPUT
	
	INSERT INTO dbo.coLiquidacionCompra( Liquidacion, IDEmbarque ,IDOrdenCompra ,Fecha,TipoCambio ,ValorMercaderia ,MontoFlete ,MontoSeguro ,Otros ,MontoTotal)
	VALUES (@Liquidacion,@IDEmbarque,@IDOrdenCompra,@Fecha,@TipoCambio,@ValorMercaderia,@MontoFlete, @MontoSeguro,@Otros,@MontoTotal)
	 
	UPDATE dbo.globalConsecMask SET  Consecutivo=@Liquidacion WHERE Codigo='LIQ'
	
	SET @IDLiquidacion = @@identity	
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.coLiquidacionCompra  SET Fecha=@Fecha,TipoCambio=@TipoCambio,ValorMercaderia=@ValorMercaderia,MontoFlete=@MontoFlete,MontoSeguro=@MontoSeguro,Otros=@Otros,MontoTotal=@MontoTotal
	WHERE IDLiquidacion=@IDLiquidacion
END
IF (@Operacion ='D')
BEGIN
	DELETE dbo.coLiquidacionCompra WHERE IDLiquidacion=@IDLiquidacion
END

GO

CREATE ALTER  PROCEDURE dbo.coGetLiquidacionCompra (@IDLiquidacion INT,@IDEmbarque INT, @IDOrdenCompra INT) 
AS 
SELECT  A.IDLiquidacion,A.Liquidacion ,A.IDEmbarque , EM.Embarque ,A.IDOrdenCompra , OC.OrdenCompra ,A.Fecha,A.TipoCambio ,a.ValorMercaderia ,A.MontoFlete ,A.MontoSeguro ,A.Otros ,A.MontoTotal  
FROM dbo.coLiquidacionCompra A
LEFT  JOIN dbo.coOrdenCompra OC ON A.IDOrdenCompra=OC.IDOrdenCompra
LEFT  JOIN dbo.coEmbarque EM ON A.IDEmbarque=EM.IDEmbarque AND EM.IDOrdenCompra=OC.IDEmbarque
WHERE (A.IDLiquidacion=@IDLiquidacion OR @IDLiquidacion=-1)  AND (A.IDEmbarque=@IDEmbarque OR @IDEmbarque=-1) AND (A.IDOrdenCompra=@IDOrdenCompra OR @IDOrdenCompra=-1)


GO


CREATE  PROCEDURE dbo.coUpdateGastoLiquidacionCompra(@Operacion NVARCHAR(1), @IDLiquidacion AS INT OUTPUT,@IDGasto AS INT ,@Monto DECIMAL(28,8))
AS 
IF (@Operacion='I')  
BEGIN
	INSERT INTO dbo.coGastoLiquidacion( IDLiquidacion, IDGasto, Monto )
	VALUES (@IDLiquidacion,@IDGasto,@Monto)
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.coGastoLiquidacion  SET Monto =@Monto
	WHERE IDLiquidacion=@IDLiquidacion AND IDGasto=@IDGasto
END
IF (@Operacion ='D')
BEGIN
	DELETE dbo.coGastoLiquidacion WHERE IDLiquidacion=@IDLiquidacion AND (IDGasto=@IDGasto OR @IDGasto=-1)
END


GO



CREATE  PROCEDURE dbo.coGetGastoLiquidacion(@IDLiquidacion AS INT, @IDGasto AS INT)
AS 
SELECT  IDLiquidacion ,A.IDGasto ,GC.Descripcion DescrGasto ,Monto  FROM dbo.coGastoLiquidacion A
INNER JOIN dbo.coGastosCompra GC ON A.IDGasto=GC.IDGasto
 WHERE IDLiquidacion=@IDLiquidacion OR (A.IDGasto = @IDGasto OR @IDGasto=-1)

SELECT *  FROM  dbo.coGastosCompra
GO

CREATE  PROCEDURE dbo.coUpdateGastoLiquidacionDetallado (@Operacion AS NVARCHAR(1), @IDLiquidacion AS INT,@IDGasto AS INT,@IDProducto AS BIGINT,@Monto AS DECIMAL(28,8))
AS 
IF @Operacion ='I'
BEGIN
	INSERT INTO dbo.coGastoLiquidacionDetallado( IDLiquidacion ,IDGasto ,IDProducto ,Monto)
	VALUES(@IDLiquidacion,@IDGasto,@IDProducto,@Monto)
END
IF @Operacion ='U'
BEGIN
	UPDATE dbo.coGastoLiquidacionDetallado SET Monto=@Monto WHERE IDLiquidacion=@IDLiquidacion  AND IDGasto=@IDGasto AND IDProducto=@IDProducto
END
IF @Operacion ='D'
BEGIN
	DELETE dbo.coGastoLiquidacionDetallado WHERE IDLiquidacion=IDLiquidacion AND (IDGasto=@IDGasto OR @IDGasto=-1) AND (IDProducto=@IDProducto OR @IDProducto=-1)
END


GO

CREATE  PROCEDURE dbo.coGetGastoLiquidacionDetallado(@IDLiquidacion AS INT,@IDGasto AS INT,@IDProducto AS BIGINT)
AS 
SELECT  A.IDLiquidacion ,A.IDGasto ,GC.Descripcion DescrGasto,A.IDProducto, P.Descr DescrProducto ,A.Monto 
 FROM dbo.coGastoLiquidacionDetallado A
INNER JOIN dbo.coGastosCompra GC ON A.IDGasto=GC.IDGasto
INNER JOIN dbo.invProducto P ON A.IDProducto= P.IDProducto
WHERE IDLiquidacion=@IDLiquidacion AND (A.IDGasto = @IDGasto OR @IDGasto=-1) AND (a.IDProducto=@IDProducto OR @IDProducto=-1)

GO


CREATE PROCEDURE dbo.coSolicitudTieneOrdenesAsociadas(@IDSolicitud AS INT) 
AS
SELECT IDSolicitud  FROM dbo.coOrdenCompra WHERE IDSolicitud = @IDSolicitud

GO


CREATE PROCEDURE dbo.coUpdateObligacionProveedor (@Operacion AS NVARCHAR(1), @IDObligacion AS INT OUTPUT ,@IDEmbarque AS INT,@flgDocCPGenerado AS bit,@Fecha DATETIME,
		@FechaVence date, @FechaPoliza Date, @NumPoliza nvarchar(250), @NumFactura nvarchar(250), @Guia_BL nvarchar(250), @TipoCambio decimal(28,8),@ValorMercaderia decimal(28,8),
		@MontoFlete decimal(28,8),@MontoSeguro decimal(28,8), @MontoTotal decimal(28,8))
AS 
IF @Operacion ='I'
BEGIN
	SELECT  @IDObligacion = ISNULL(MAX(IDObligacion),0)  FROM dbo.coObligacionProveedor
	SET @IDObligacion = @IDObligacion + 1
	INSERT INTO dbo.coObligacionProveedor(IDObligacion, IDEmbarque,flgDocCPGenerado,Fecha, FechaVence, FechaPoliza,NumPoliza,NumFactura,Guia_BL, TipoCambio,ValorMercaderia,MontoFlete,MontoSeguro,MontoTotal)
	VALUES(@IDObligacion, @IDEmbarque, @flgDocCPGenerado,@Fecha,@FechaVence,@FechaPoliza,@NumPoliza,@NumFactura,@Guia_BL, @TipoCambio,@ValorMercaderia,@MontoFlete,@MontoSeguro,@MontoTotal)
END
IF @Operacion ='U'
BEGIN
	UPDATE dbo.coObligacionProveedor SET Fecha=@Fecha, FechaVence = @FechaVence, FechaPoliza= @FechaPoliza, NumPoliza=@NumPoliza, NumFactura=@NumFactura,Guia_BL= @Guia_BL, TipoCambio=@TipoCambio, ValorMercaderia =@ValorMercaderia, MontoFlete = @MontoFlete, MontoSeguro = @MontoSeguro, Montototal= @MontoTotal  WHERE IdObligacion=@IDObligacion
END
IF @Operacion ='D'
BEGIN
	DELETE dbo.coObligacionProveedor WHERE IDObligacion= @IDObligacion
END


GO

CREATE PROCEDURE dbo.coGetObligacionProveedor(@IDEmbarque AS INT, @IDObligacion AS INT)
AS 
SELECT  IDObligacion ,IDEmbarque ,flgDocCPGenerado ,Fecha ,FechaVence ,FechaPoliza ,NumPoliza ,NumFactura ,Guia_BL ,TipoCambio ,ValorMercaderia ,MontoFlete ,MontoSeguro ,MontoTotal  FROM dbo.coObligacionProveedor
WHERE IDEmbarque = @IDEmbarque AND (IDObligacion=@IDObligacion OR @IDObligacion = -1)

GO


CREATE PROCEDURE dbo.coUpdateObligacionDetalle (@Operacion AS NVARCHAR(1), @IDObligacionDetalle AS INT OUTPUT, @IDObligacion AS INT ,@IDProveedor AS INT,@Documento AS NVARCHAR(100),@flgDocCPGenerado AS BIT,
		@FechaDocumento DATETIME,@SubTotal DECIMAL(28,8),@PorcImpuesto DECIMAL(28,8),@Impuesto DECIMAL(28,8),@MontoTotal DECIMAL(28,8), @IdMoneda INT, @IDGasto AS INT )
AS 
IF @Operacion ='I'
BEGIN
	SELECT @IDObligacionDetalle =  isnull(MAX(IDObligacionDetalle) ,0)FROM dbo.coObligacionDetalle 
	SET @IDObligacionDetalle = @IDObligacionDetalle +1 
	INSERT INTO dbo.coObligacionDetalle( IDObligacionDetalle ,IDObligacion ,IDProveedor ,Documento ,flgDocCPGenerado ,FechaDocumento ,SubTotal,PorcImpuesto,Impuesto,MontoTotal ,IDMoneda, IDGasto)
	VALUES(@IDObligacionDetalle,@IDObligacion, @IDProveedor, @Documento,@flgDocCPGenerado,@FechaDocumento,@SubTotal,@PorcImpuesto,@Impuesto,@MontoTotal,@IdMoneda, @IDGasto)
END
IF @Operacion ='U'
BEGIN
	UPDATE dbo.coObligacionDetalle SET IDProveedor=@IDProveedor, Documento = @Documento, FechaDocumento= @FechaDocumento,SubTotal=@SubTotal,PorcImpuesto =@PorcImpuesto,Impuesto =@Impuesto,MontoTotal=@MontoTotal,IDMoneda=@IdMoneda, IDGasto=@IDGasto WHERE IDObligacionDetalle=@IDObligacionDetalle
END
IF @Operacion ='D'
BEGIN
	DELETE dbo.coObligacionDetalle WHERE IDObligacionDetalle= @IDObligacionDetalle
END


GO, 


CREATE ALTER PROCEDURE dbo.coGetObligacionDetalle(@IDObligacionDetalle  AS INT, @IDObligacion AS INT)
AS 
SELECT   IDObligacionDetalle ,IDObligacion ,A.IDProveedor, P.Nombre ,Documento ,flgDocCPGenerado ,FechaDocumento ,SubTotal,PorcImpuesto,Impuesto,MontoTotal ,A.IDMoneda, M.Descr DescrMoneda,G.IDGasto,G.Descripcion DescrGasto
FROM dbo.coObligacionDetalle A
INNER JOIN dbo.cppProveedor P ON  A.IDProveedor = P.IDProveedor
INNER JOIN dbo.globalMoneda M ON a.IDMoneda=M.IDMoneda
INNER JOIN dbo.coGastosCompra G ON A.IDGasto =G.IDGasto
WHERE IDObligacion=@IDObligacion AND ( IDObligacionDetalle = @IDObligacionDetalle OR @IDObligacionDetalle = -1)


go 

CREATE PROCEDURE  dbo.coConfirmarEmbarque(@IDEmbarque AS INT, @Confirmado AS BIT)
AS 
UPDATE dbo.coEmbarque SET  Confirmado = @Confirmado WHERE IDEmbarque=@IDEmbarque


GO

--// TODO: Pendiente verificar el documento en la factura Real
CREATE  PROCEDURE dbo.coGetDocumentoCPObligacionProveedor  @IDEmbarque AS INT
AS 
--SET @IDEmbarque = 5  
DECLARE @Factura  AS NVARCHAR(250)
SELECT TOP 1 @Factura = NumFactura FROM dbo.coObligacionProveedor WHERE IDEmbarque=@IDEmbarque

--Buscar el documento en documentoCP
SELECT 'CP00001' Asiento


GO


CREATE PROCEDURE dbo.GetConsolidadoObligacionDetalle ( @IDEmbarque AS INT)
AS

DECLARE @IDObligacionProveedor AS INT

SELECT @IDObligacionProveedor= IDObligacion FROM dbo.coObligacionProveedor WHERE IDEmbarque=@IDEmbarque


SELECT A.IDGasto,G.Descripcion,A.SubTotal  FROM dbo.coObligacionDetalle A
INNER JOIN dbo.coGastosCompra G ON A.IDGasto = G.IDGasto
WHERE IDObligacion=@IDObligacionProveedor


GO


CREATE PROCEDURE dbo.coCalculaProrrateoGastosCompra @IDLiquidacion AS INT
AS 
--SET @IDLiquidacion =11


DECLARE @IDEmbarque AS INT,@MontoFlete AS DECIMAL(28,8), @MontoSeguro AS DECIMAL(28,8),@MontoTotalGasto AS DECIMAL(28,8),@IDGastoFactura AS int

SELECT @IDGastoFactura = IDGasto  FROM dbo.coGastosCompra WHERE flgIsFactura=1 AND flgReadOnly=1

SELECT @IDEmbarque = IDEmbarque, @MontoFlete = MontoFlete,@MontoSeguro=MontoSeguro  FROM dbo.coLiquidacionCompra WHERE IDLiquidacion=@IDLiquidacion
SET @MontoTotalGasto = @MontoFlete + @MontoSeguro

SELECT IDGasto,Monto INTO #Gastos FROM dbo.coGastoLiquidacion WHERE IDLiquidacion=@IdLiquidacion
SELECT IDProducto,((CantidadAceptada * PrecioUnitario) - MontoDesc) + (((CantidadAceptada * PrecioUnitario) - MontoDesc) * (Impuesto/100)) MontoMercaderia, 
0 Porc INTO #tmpProductos FROM dbo.coEmbarqueDetalle  WHERE IDEmbarque=@IDEmbarque

DECLARE @MontoTotalMercaderia AS DECIMAL(28,8)

SELECT @MontoTotalMercaderia = SUM(MontoMercaderia) FROM #tmpProductos

UPDATE #tmpProductos SET Porc = @MontoTotalMercaderia / MontoMercaderia

SELECT A.IDLiquidacion,A.IDProducto,P.Descr DescrProducto,A.IDGasto,G.Descripcion DescrGasto,A.Monto  FROM 
(
	SELECT @IDLiquidacion IDLiquidacion, IDProducto,IDGasto,B.Monto * Porc Monto,1 Prioridad
	FROM #tmpProductos A
	CROSS JOIN	#Gastos B 
	UNION ALL
	SELECT @IDLiquidacion IDLiquidacion,IDProducto,@IDGastoFactura IDGasto, MontoMercaderia + (@MontoTotalGasto * Porc)  Monto, 0 Prioridad
	FROM #tmpProductos
) A
INNER JOIN dbo.coGastosCompra G ON A.IDGasto=G.IDGasto
INNER JOIN dbo.invProducto P ON A.IDProducto=P.IDProducto
ORDER BY A.IDProducto,Prioridad,A.IDGasto

DROP TABLE #Gastos
DROP TABLE #tmpProductos


GO


CREATE PROCEDURE dbo.GetDatosGeneralesRecepcionMercaderia(@IDEmbarque AS int)
AS 
SELECT A.Embarque,Oc.OrdenCompra,A.IDProveedor,P.Nombre,OP.NumFactura  FROM dbo.coEmbarque A
LEFT JOIN dbo.cppProveedor P ON A.IDProveedor = P.IDProveedor
LEFT  JOIN dbo.coOrdenCompra OC ON A.IDOrdenCompra = OC.IDOrdenCompra
LEFT  JOIN dbo.coObligacionProveedor OP ON a.IDEmbarque= OP.IDEmbarque
WHERE A.IDEmbarque = @IDEmbarque

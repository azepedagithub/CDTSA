
CREATE TABLE dbo.cppProveedor(
	IDProveedor INT NOT NULL,
	Nombre NVARCHAR(250),
	Alias NVARCHAR(250),
	Contacto NVARCHAR(250),
	IDRuc INT,
	Telefonos NVARCHAR(50),
	IDImpuesto INT,
	IDCategoria INT,
	FechaIngreso DATETIME,
	Activo BIT DEFAULT 1,
	MultiMoneda BIT DEFAULT 0,
	PagosCongelador BIT DEFAULT 0,
	IsLocal BIT DEFAULT 0,
	TipoContribuyente INT
CONSTRAINT [pkcppProveedor] PRIMARY KEY CLUSTERED 
(
	IDProveedor ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE dbo.invEstadoOrdenCompra(
	IDEstadoOrden INT NOT NULL,
	Descr NVARCHAR(250),
	Activo BIT DEFAULT 1
CONSTRAINT [pkinvEstadoOrdenCompra] PRIMARY KEY CLUSTERED 
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

CREATE TABLE dbo.invTipoProrrateoRubrosCompra(
	IDTipoProrrateo INT NOT NULL,
	Descr NVARCHAR(250),
	Activo BIT DEFAULT 1
CONSTRAINT pkinvTipoProrrateoRubrosCompra PRIMARY KEY CLUSTERED 
(
	IDTipoProrrateo ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE dbo.invEstadoSolicitud(
	IDEstado int NOT NULL,
	Descr nvarchar(250),
	Activo bit DEFAULT 1,
CONSTRAINT pkinvEstadoSolicitud PRIMARY KEY CLUSTERED 
(
	IDEstado ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE dbo.invSolicitudCompra(
	IDSolicitud int NOT NULL,
	Fecha date,
	FechaRequerida date,
	IDEstado int,
	Comentario nvarCHAR(250),
	UsuarioSolicitud nvarchar(50),
	CreateDate datetime,
	CreatedBy nvarchar(50),
	RecordDate datetime,
	UpdateBy nvarchar(50)
	CONSTRAINT pkinvSolicitudCompra PRIMARY KEY CLUSTERED 
(
	IDSolicitud ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[invSolicitudCompra]  WITH CHECK ADD  CONSTRAINT [fkinvSolicitudCompra_EstadoSolicitud] FOREIGN KEY([IDEstado])
REFERENCES [dbo].invEstadoSolicitud (IDEstado)

GO

CREATE TABLE dbo.invSolicitudOrdenCompra (
	IDSolicitud INT NOT NULL,
	IDOrdenCompra INT NOT NULL,
	IDProducto BIGINT NOT NULL,
	Cantidad DECIMAL(28,4) DEFAULT  0,
	Usuario NVARCHAR(50) ,
	Fecha DATETIME
CONSTRAINT [pkinvSolicitudCompraOrdenCompra] PRIMARY KEY CLUSTERED 
(
	IDSolicitud ASC,
	IDOrdenCompra ASC,
	[IDProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].invSolicitudOrdenCompra  WITH CHECK ADD  CONSTRAINT [fkinvSolicitudOrdenCompra_Solicitud] FOREIGN KEY([IDSolicitud])
REFERENCES [dbo].invSolicitudCompra (IDSolicitud)


GO

CREATE TABLE dbo.invSolicitudCompraDetalle (
	IDSolicitud INT NOT NULL,
	IDProducto BIGINT NOT NULL,
	Cantidad DECIMAL(28,4) DEFAULT  0,
	Comentario NVARCHAR(20) ,
CONSTRAINT [pkinvSolicitudCompraDetalle] PRIMARY KEY CLUSTERED 
(
	IDSolicitud ASC,
	[IDProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[invSolicitudCompraDetalle]  WITH CHECK ADD  CONSTRAINT [fkinvSolicitudCompraDetalle_Producto] FOREIGN KEY([IDProducto])
REFERENCES [dbo].invProducto (IDProducto)


GO


CREATE TABLE [dbo].[invOrdenCompra](
	[IDOrdenCompra] [int] NOT NULL,
	[OrdenCompra] [nvarchar](20) NOT NULL,
	Fecha [datetime] ,
	FechaRequerida DATE,
	FechaEmision DATE,
	FechaRequeridaEmbarque DATE,
	FechaCotizacion DATE,
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
 CONSTRAINT [pkinvOrdenCompra] PRIMARY KEY CLUSTERED 
(
	[IDOrdenCompra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[invOrdenCompra]  WITH CHECK ADD  CONSTRAINT [fkinvOrdenCompra_Proveedor] FOREIGN KEY([IDProveedor])
REFERENCES [dbo].[cppProveedor] ([IDProveedor])
GO

ALTER TABLE [dbo].[invOrdenCompra]  WITH CHECK ADD  CONSTRAINT [fkinvOrdenCompra_GlobalMoneda] FOREIGN KEY([IDMoneda])
REFERENCES [dbo].globalMoneda (IDMoneda)
GO


ALTER TABLE [dbo].[invOrdenCompra]  WITH CHECK ADD  CONSTRAINT [fkinvOrdenCompra_Bodega] FOREIGN KEY([IDBodega])
REFERENCES [dbo].invBodega (IDBodega)
GO


ALTER TABLE [dbo].[invOrdenCompra]  WITH CHECK ADD  CONSTRAINT [fkinvOrdenCompra_CondicionPago] FOREIGN KEY([IDCondicionPago])
REFERENCES [dbo].cppCondicionPago (IDCondicionPago)
GO


ALTER TABLE [dbo].[invOrdenCompra]  WITH CHECK ADD  CONSTRAINT [fkinvOrdenCompra_TipoProrrateo] FOREIGN KEY([IDTipoProrrateo])
REFERENCES [dbo].invTipoProrrateoRubrosCompra (IDTipoProrrateo)

GO

ALTER TABLE [dbo].invSolicitudOrdenCompra  WITH CHECK ADD  CONSTRAINT [fkinvSolicitudOrdenCompra_OrdenCompra] FOREIGN KEY([IDOrdenCompra])
REFERENCES [dbo].invOrdenCompra (IDOrdenCompra)

GO


CREATE TABLE dbo.invOrdenCompraDetalle (
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
CONSTRAINT [pkinvOrdenCompraDetalle] PRIMARY KEY CLUSTERED 
(
	[IDOrdenCompra] ASC,
	[IDProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].invOrdenCompraDetalle  WITH CHECK ADD  CONSTRAINT [fkinvOrdenCompraDetalle_Prodcuto] FOREIGN KEY([IDProducto])
REFERENCES [dbo].invProducto (IDProducto)


GO
CREATE TABLE [dbo].[invEmbarque](
	[IDEmbarque] [int] NOT NULL,
	[Embarque] nvarchar(20) NOT NULL,
	Fecha [datetime] ,
	FechaEmbarque DATE,
	Asiento nvarchar(20),
	[IDBodega] INT,
	[IDProveedor] INT,
	[IDOrdenCompra] int,
	IDDocumentoCP INT,
	TipoCambio DECIMAL(28,4),
	Usuario NVARCHAR(50) NOT NULL,
	CreateDate datetime,
	CreatedBy nvarchar(50),
	RecordDate datetime,
	UpdateBy nvarchar(50)
 CONSTRAINT [pkinvEmbarque] PRIMARY KEY CLUSTERED 
(
	[IDEmbarque] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[invEmbarque]  WITH CHECK ADD  CONSTRAINT [fkinvEmbarque_Bodega] FOREIGN KEY(IDBodega)
REFERENCES [dbo].invBodega (IDBodega)
GO

ALTER TABLE [dbo].[invEmbarque]  WITH CHECK ADD  CONSTRAINT [fkinvEmbarque_OrdenCompra] FOREIGN KEY(IDOrdenCompra)
REFERENCES [dbo].invOrdenCompra (IDOrdenCompra)
GO


--// TODO Pendiente crear tabla de Cuentas por pagar
--ALTER TABLE [dbo].[invEmbarque]  WITH CHECK ADD  CONSTRAINT [fkinvEmbarque_DocumentoCP] FOREIGN KEY(IDDocumentoCP)
--REFERENCES [dbo].ccpDocumentoCP (IDDocumentoCP)
--GO


CREATE TABLE dbo.invEmbarqueDetalle (
	IDEmbarque INT NOT NULL,
	IDProducto BIGINT NOT NULL,
	IDLote int NOT NULL,
	Cantidad DECIMAL(28,4) DEFAULT  0,
	CantidadAceptada DECIMAL(28,4) DEFAULT 0,
	CantidadRechazada  DECIMAL(28,4) DEFAULT 0,
	Comentario NVARCHAR(20) ,
CONSTRAINT [pkinvEmbarqueDetalle] PRIMARY KEY CLUSTERED 
(
	[IDEmbarque] ASC,
	[IDProducto] ASC,
	IDLote ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].invEmbarqueDetalle  WITH CHECK ADD  CONSTRAINT [fkiinvEmbarqueDetalle_Producto] FOREIGN KEY([IDProducto])
REFERENCES [dbo].invProducto (IDProducto)

GO
ALTER TABLE [dbo].invEmbarqueDetalle  WITH CHECK ADD  CONSTRAINT [fkinvEmbarqueDetalle_Lote] FOREIGN KEY(IDLote,IDProducto)
REFERENCES [dbo].invLote (IDLote,IDProducto)


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


CREATE   TABLE dbo.invArticuloProveedor (
	IDProducto BIGINT NOT NULL,
	IDProveedor int NOT NULL,
	IDPaisManofactura int,
	LoteMinCompra decimal(28,4),
	PesoMinimoCompra decimal(28,4),
	Notas NVARCHAR(256),
	CreateDate datetime,
	CreatedBy nvarchar(50),
	UpdatedDate datetime,
	UpdatedBy nvarchar(50)
	CONSTRAINT [pkinvArticuloProveedor] PRIMARY KEY CLUSTERED 
(
	[IDProducto] ASC,
	IDProveedor ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].invArticuloProveedor  WITH CHECK ADD  CONSTRAINT [fkinvArticuloProveedor_Producto] FOREIGN KEY([IDProducto])
REFERENCES [dbo].invProducto (IDProducto)

GO
ALTER TABLE [dbo].invArticuloProveedor  WITH CHECK ADD  CONSTRAINT [fkinvArticuloProveedor_Proveedor] FOREIGN KEY(IDProveedor)
REFERENCES [dbo].cppProveedor (IDProveedor)

GO


ALTER TABLE [dbo].invArticuloProveedor  WITH CHECK ADD  CONSTRAINT [fkinvArticuloProveedor_Pais] FOREIGN KEY(IDPaisManofactura)
REFERENCES [dbo].globalPais (IDPais)

GO




CREATE TABLE dbo.invParametrosCompra(
	IDParametro int,
	IDConsecSolicitud int	,
	IDConsecOrdenCompra int,
	IDConsecEmbarque int,
	IDConsecDevolucion int,
	CantLineasOrdenCompra int,
	IDBodegaDefault int,
	IDTipoCambio int,
	CantDecimalesPrecio int	,
	CantDecimalesCantidad int	,
	IDTipoAsientoContable int,
	IDPaquete int,
	CtaTransitoLocal bigInt,
	CtrTransitoLocal int,
	CtaTransitoExterior bigint,
	CtrTransifoExterior int,
	AplicaAutomaticamenteAsiento bit DEFAULT 0,
	CanEditAsiento bit DEFAULT 1,
	CanViewAsiento bit DEFAULT 1,
	CONSTRAINT [pkinvParametrosCompra] PRIMARY KEY CLUSTERED 
(
	IDParametro ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO

CREATE   PROCEDURE dbo.invUpdateSolicitudCompra(@Operacion NVARCHAR(1), @IDSolicitud AS INT OUTPUT, @Fecha date, @FechaRequerida  AS date, @IDEstado AS int ,@Comentario nvarchar(20)
, @UsuarioSolicitud nvarchar(50),@Usuario nvarchar(50),@CreatedDate datetime,@CreatedBy nvarchar(50),@RecordDate datetime,@UpdateBy nvarchar(50))
AS 
IF (@Operacion='I')  
BEGIN
	SET @IDSolicitud = (SELECT ISNULL(MAX(IDSolicitud),0)  FROM dbo.invSolicitudCompra) + 1
	INSERT INTO dbo.invSolicitudCompra(IdSolicitud,Fecha,FechaRequerida,IDEstado,Comentario,UsuarioSolicitud,CreateDate,CreatedBy,RecordDate,UpdateBy)
	VALUES (@IDSolicitud,@Fecha,@FechaRequerida,@IDEstado,@Comentario,@UsuarioSolicitud,@CreatedDate,@CreatedBy,@RecordDate,@UpdateBy)
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.invSolicitudCompra  SET FechaRequerida=@FechaRequerida,IDEstado =@IDEstado,
															RecordDate=@RecordDate,UpdateBy = @UpdateBy
	WHERE IdSolicitud=@IDSolicitud
END
IF (@Operacion ='D')
BEGIN
	DELETE dbo.invSolicitudCompra WHERE IdSolicitud=@IDSolicitud
END

GO

CREATE PROCEDURE [dbo].[invGetSolicitudCompraByID] (@IDSolicitud AS INT)
AS 
SELECT  A.IDSolicitud ,A.Fecha ,A.FechaRequerida ,A.IDEstado , E.Descr DescrEstado,Comentario ,UsuarioSolicitud ,
				A.CreateDate ,A.CreatedBy ,A.RecordDate ,A.UpdateBy  
FROM dbo.invSolicitudCompra A
INNER JOIN dbo.invEstadoSolicitud E ON A.IDEstado=E.IDEstado
WHERE A.IDSolicitud =@IDSolicitud 

GO

CREATE PROCEDURE dbo.invGetSolicitudCompra (@IDSolicitud AS INT, @FechaInicial AS DATETIME,@FechaFinal AS DATE,@IDEstado AS INT)
AS 

set @FechaInicial = CONVERT(VARCHAR(25),@FechaInicial,101) 
set @FechaFinal = CAST(SUBSTRING(CAST(@FechaFinal AS CHAR),1,11) + ' 23:59:59.998' AS DATETIME)

SELECT  A.IDSolicitud ,A.Fecha ,A.FechaRequerida ,A.IDEstado , E.Descr DescrEstado,Comentario  ,UsuarioSolicitud ,
				A.CreateDate ,A.CreatedBy ,A.RecordDate ,A.UpdateBy  
FROM dbo.invSolicitudCompra A
INNER JOIN dbo.invEstadoSolicitud E ON A.IDEstado=E.IDEstado
WHERE (A.IDSolicitud =@IDSolicitud OR @IDSolicitud=-1) AND A.Fecha BETWEEN @FechaInicial AND @FechaFinal  
			AND (A.IDEstado =@IDEstado OR @IDEstado=-1) 
GO


CREATE PROCEDURE dbo.invUpdateDetalleSolicitud(@Operacion NVARCHAR(1),@IDSolicitud INT,@IDProducto INT, @Cantidad INT, @Comentario NVARCHAR(20))
AS 
IF (@Operacion ='I') 
BEGIN
	INSERT INTO dbo.invSolicitudCompraDetalle(IdSolicitud,IDproducto,Cantidad,Comentario)
	VALUES (@IDSolicitud,@IDProducto,@Cantidad,@Comentario)
END
IF (@Operacion='U')
	UPDATE dbo.invSolicitudCompraDetalle SET CANTIDAD =@Cantidad,COMENTARIO=@Comentario WHERE IdSolicitud=@IDSolicitud

IF (@Operacion ='D')
	DELETE FROM dbo.invSolicitudCompraDetalle WHERE  IdSolicitud=@IDSolicitud
	
GO 

CREATE PROCEDURE dbo.invGetSolicitudCompraDetalle (@IDSolicitud AS INT)
AS 
SELECT IDSolicitud,A.IDProducto,P.Descr DescrProducto,A.Cantidad,A.Comentario
FROM dbo.invSolicitudCompraDetalle A
INNER JOIN dbo.invProducto P ON A.IDProducto = P.IDProducto
WHERE (IDSolicitud =@IDSolicitud OR (@IDSolicitud=-1 AND 1=3))
go 

CREATE  PROCEDURE dbo.invGetOrdenCompra(  @IDOrdenCompra AS INT, @FechaInicial AS DATETIME,@FechaFinal AS DATETIME, @Proveedor AS NVARCHAR(1000),@Estado AS NVARCHAR(1000),@FechaRequeridaInicial AS DATETIME ,
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
        Descuento ,Seguro	,Flete ,Documentacion ,Anticipos ,A.IDTipoProrrateo, G.Descr DescrTipoProrrateo ,A.IDEmbarque, H.Embarque ,A.IDDocumentoCP ,A.TipoCambio ,A.Usuario ,UsuarioCreaEmbarque ,FechaCreaEmbarque ,UsuarioAprobacion ,
        FechaAprobacion ,A.CreateDate ,A.CreatedBy ,A.RecordDate ,A.UpdateBy  
FROM dbo.invOrdenCompra A INNER JOIN dbo.invEstadoOrdenCompra B ON A.IDEstado = B.IDEstadoOrden
INNER JOIN dbo.invBodega C ON A.IDBodega= C.IDBodega 
INNER JOIN dbo.cppProveedor D ON A.IDProveedor = D.IDProveedor
INNER JOIN dbo.globalMoneda E ON A.IDMoneda = E.IDMoneda
INNER JOIN dbo.cppCondicionPago F ON A.IDCondicionPago = F.IDCondicionPago
LEFT  JOIN dbo.invTipoProrrateoRubrosCompra G ON A.IDTipoProrrateo = G.IDTipoProrrateo
LEFT JOIN dbo.invEmbarque H ON A.IDEmbarque = H.IDEmbarque
WHERE (A.IDOrdenCompra = @IDOrdenCompra OR @IDOrdenCompra = -1) AND A.Fecha  BETWEEN @FechaInicial  AND @FechaFinal  AND FechaRequerida  BETWEEN @FechaRequeridaInicial AND @FechaRequeridaFinal
AND (a.IDProveedor = (SELECT Value FROM [dbo].[ConvertListToTable](@Proveedor,@Separador)) OR @Proveedor = '*')  AND (A.IDEstado = (SELECT Value FROM [dbo].[ConvertListToTable](@Estado,@Separador) ) OR @Estado ='*' )


go 


CREATE PROCEDURE dbo.invGetOrdenCompraByID( @IDOrdenCompra AS INT)
AS 
SELECT  A.IDOrdenCompra ,OrdenCompra ,A.Fecha ,FechaRequerida ,FechaEmision ,FechaRequeridaEmbarque ,FechaCotizacion ,IDEstado, B.Descr DescrEstado,A.IDBodega, C.Descr DescrBodega, 
		A.IDProveedor ,C.Descr DescrProveedor,A.IDMoneda, E.Descr DescrMoneda,A.IDCondicionPago , F.Descr DescrCondicionPago,F.Dias DiasCondicionPago,
        Descuento ,Flete,Seguro ,Documentacion ,Anticipos ,A.IDTipoProrrateo, G.Descr DescrTipoProrrateo ,A.IDEmbarque, H.Embarque ,A.IDDocumentoCP ,A.TipoCambio ,A.Usuario ,UsuarioCreaEmbarque ,FechaCreaEmbarque ,UsuarioAprobacion ,
        FechaAprobacion ,A.CreateDate ,A.CreatedBy ,A.RecordDate ,A.UpdateBy  
FROM dbo.invOrdenCompra A INNER JOIN dbo.invEstadoOrdenCompra B ON A.IDEstado = B.IDEstadoOrden
INNER JOIN dbo.invBodega C ON A.IDBodega= C.IDBodega 
INNER JOIN dbo.cppProveedor D ON A.IDProveedor = D.IDProveedor
INNER JOIN dbo.globalMoneda E ON A.IDMoneda = E.IDMoneda
INNER JOIN dbo.cppCondicionPago F ON A.IDCondicionPago = F.IDCondicionPago
LEFT  JOIN dbo.invTipoProrrateoRubrosCompra G ON A.IDTipoProrrateo = G.IDTipoProrrateo
LEFT JOIN dbo.invEmbarque H ON A.IDEmbarque = H.IDEmbarque
WHERE (A.IDOrdenCompra = @IDOrdenCompra )


GO

CREATE  PROCEDURE dbo.invUpdateOrdenCompra (@Operacion nvarchar(1),@IDOrdenCompra INT OUTPUT,@OrdenCompra NVARCHAR(20) OUTPUT,@Fecha DATETIME, 
										@FechaRequerida DATE, @FechaEmision DATE,@FechaRequeridaEmbarque DATE,@FechaCotizacion DATE,
										@IDEstado AS INT, @IDBodega AS INT, @IDProveedor AS INT, @IDMoneda AS INT, @IDCondicionPago AS INT, 
										@Descuento AS DECIMAL(28,4), @Flete AS DECIMAL(28,4),@Seguro AS DECIMAL(28,4),@Documentacion AS DECIMAL(28,4),@Anticipos AS DECIMAL(28,4),
										@IDTipoProrrateo AS INT, @IDEmbarque AS INT,  @IDDocumentoCP AS INT, @TipoCambio AS DECIMAL(28,4),
										 @Usuario AS NVARCHAR(50),@UsuarioEmbarque AS NVARCHAR(50),@FechaCreaEmbarque AS DATETIME, 
										 @UsuarioAprobacion AS NVARCHAR(50),@FechaAprobacion AS DATETIME, @CreateDate AS DATETIME, 
										 @CreatedBy AS NVARCHAR(50), @RecordDate AS DATETIME, @UpdatedBy AS NVARCHAR(50))
AS 
IF (@Operacion ='I')
BEGIN
	SET @IDOrdenCompra = (SELECT ISNULL(MAX(IDOrdenCompra),0)  FROM dbo.invOrdenCompra ) + 1
	
	INSERT INTO dbo.invOrdenCompra(IDOrdenCompra,OrdenCompra,Fecha,FechaRequerida,FechaEmision,FechaRequeridaEmbarque,FechaCotizacion,IdEstado, IDBodega,IDProveedor,IDMoneda,IDCondicionPago,Descuento,Flete,Seguro,Documentacion,Anticipos,IDTipoProrrateo,IDEmbarque,IdDocumentoCP,TipoCambio,Usuario,UsuarioCreaEmbarque,FechaCreaEmbarque,UsuarioAprobacion,FechaAprobacion,CreateDate,Createdby,RecordDate,UpdateBy)
	VALUES (@IDOrdenCompra, @OrdenCompra, @Fecha,@FechaRequerida,@FechaEmision,@FechaRequeridaEmbarque,@FechaCotizacion,@IDEstado,@IDBodega,@IDProveedor,@IDMoneda,@IDCondicionPago,@Descuento,@Flete,@Seguro,@Documentacion,@Anticipos,@IDTipoProrrateo,@IDEmbarque,@IDDocumentoCP,@TipoCambio,@Usuario,@UsuarioEmbarque,@FechaCreaEmbarque,@UsuarioAprobacion,@FechaAprobacion, @CreateDate,@CreatedBy,@RecordDate,@UpdatedBy)
END										 
IF (@Operacion='U')
BEGIN
	UPDATE dbo.invOrdenCompra SET FechaRequerida= @FechaRequerida ,FechaRequeridaEmbarque = @FechaRequeridaEmbarque, FechaCotizacion = @FechaCotizacion,IDEstado = @IDEstado,IDBodega=@IDBodega, IDCondicionPago = @IDCondicionPago, Descuento= @Descuento ,Flete=@Flete,Seguro=@Seguro,Documentacion = @Documentacion,Anticipos= @Anticipos,IDTipoProrrateo = @IDTipoProrrateo,IDEmbarque = @IDEmbarque,IDDocumentoCP = @IDDocumentoCP, 
																																																																																																																						TipoCambio = @TipoCambio,UsuarioCreaEmbarque = @UsuarioEmbarque,UsuarioAprobacion =@UsuarioAprobacion, FechaAprobacion=@FechaAprobacion,RecordDate=@RecordDate,UpdateBy=@UpdatedBy
END
IF (@Operacion='D')
BEGIN
	DELETE FROM dbo.invOrdenCompra WHERE IDOrdenCompra=@IDOrdenCompra
END

GO

CREATE  PROCEDURE dbo.invGetOrdenCompraDetalle(@IDOrdenCompra AS int	)
AS 
SELECT A.IDOrdenCompra,A.IDProducto,P.Descr DescrProducto,A.Estado,E.Descr DescrEstado,A.Cantidad,A.CantidadAceptada,A.CantidadRechazada,A.Impuesto,A.MontoDesc,A.PorcDesc,A.PrecioUnitario,A.Comentario
  FROM dbo.invOrdenCompraDetalle A
INNER JOIN dbo.invProducto P ON		A.IDProducto = P.IDProducto
INNER JOIN dbo.invEstadoOrdenCompra E ON A.Estado=E.IDEstadoOrden
WHERE IDOrdenCompra=@IDOrdenCompra

GO 

CREATE PROCEDURE dbo.invUpdateOrdenCompraDetalle(@Operacion AS NVARCHAR(1),@IDOrdenCompra AS INT,@IDProducto AS BIGINT,@Cantidad AS DECIMAL(28,4),@CantidadAceptada AS DECIMAL(28,4),
									@CantidadRechazada AS DECIMAL(28,4),@PrecioUnitario AS DECIMAL(28,4), @Impuesto AS DECIMAL(28,4),@PorcDesc AS DECIMAL(28,4),
									@MontoDesc AS DECIMAL(28,4) ,@Estado AS INT, @Comentario AS NVARCHAR(20))
AS 
IF (@Operacion='I')
BEGIN
	INSERT INTO dbo.invOrdenCompraDetalle( IDOrdenCompra ,IDProducto ,Cantidad ,CantidadAceptada ,CantidadRechazada ,PrecioUnitario ,Impuesto ,PorcDesc ,MontoDesc ,Estado ,Comentario)
	VALUES (@IDOrdenCompra,@IDProducto,@Cantidad,@CantidadAceptada,@CantidadRechazada,@PrecioUnitario,@Impuesto,@PorcDesc,@MontoDesc,@Estado,@Comentario)
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.invOrdenCompraDetalle SET  Cantidad =@Cantidad,CantidadAceptada=@CantidadAceptada,CantidadRechazada=@CantidadRechazada,
							PrecioUnitario =@PrecioUnitario,Impuesto = @Impuesto,PorcDesc=@PorcDesc,MontoDesc= @MontoDesc,Estado =@Estado,Comentario =@Comentario
	 WHERE IDOrdenCompra=@IDOrdenCompra AND IDProducto=@IDProducto
END
IF (@Operacion='D')
	DELETE FROM dbo.invOrdenCompraDetalle WHERE IDOrdenCompra=@IDOrdenCompra AND (IDProducto=@IDProducto OR @IDProducto=-1)


GO


CREATE  PROCEDURE dbo.invUpdateEmbaque(@Operacion AS NVARCHAR(1),@IDEmbarque AS INT, @Embarque AS NVARCHAR(20),@Fecha AS DATE, 
						@FechaEmbarque AS DATE,@Asiento AS NVARCHAR(20),@IDBodega AS INT, @IDProveedor AS INT, @IDOrdenCompra AS INT, 
						@IDDocumentoCP AS INT, @TipoCambio AS DECIMAL(28,4), @Usuario AS NVARCHAR(50),@CreateDate AS DATETIME, 
						@CreatedBy AS NVARCHAR(50),@RecordDate AS DATETIME,@UpdateBy AS NVARCHAR(50))
AS 
IF (@Operacion ='I')
BEGIN
	 INSERT INTO dbo.invEmbarque( IDEmbarque ,Embarque ,Fecha ,FechaEmbarque ,Asiento ,IDBodega ,IDProveedor ,IDOrdenCompra  ,IDDocumentoCP ,TipoCambio ,Usuario ,CreateDate ,CreatedBy ,RecordDate ,UpdateBy)
	 VALUES (@IDEmbarque,@Embarque,@Fecha,@FechaEmbarque,@Asiento,@IDBodega,@IDProveedor,@IDOrdenCompra,@IDDocumentoCP,@TipoCambio,@Usuario,@CreateDate,@CreatedBy,@RecordDate,@UpdateBy)
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.invEmbarque SET  FechaEmbarque=@FechaEmbarque, Asiento= @Asiento,IDBodega=@IDBodega,IDProveedor=@IDProveedor,
			IDOrdenCompra=@IDOrdenCompra,IDDocumentoCP=@IDDocumentoCP,RecordDate= @RecordDate,UpdateBy= @UpdateBy
	  WHERE IDEmbarque=@IDEmbarque
END
IF (@Operacion ='D')
	DELETE FROM dbo.invEmbarque WHERE IDEmbarque=@IDEmbarque

GO

CREATE  PROCEDURE dbo.invGetEmbarque(@IDEmbarque AS INT,@FechaInicial AS DATE,@FechaFinal AS DATE,
																	@IDProveedor AS INT,@OrdenCompra AS NVARCHAR(20),@IDDocumentoCP AS INT)
AS
set @FechaInicial = CONVERT(VARCHAR(25),@FechaInicial,101) 
set @FechaFinal = CAST(SUBSTRING(CAST(@FechaFinal AS CHAR),1,11) + ' 23:59:59.998' AS DATETIME)

SELECT A.IDEmbarque,A.Embarque,A.Fecha,A.FechaEmbarque,A.Asiento,A.IDBodega,B.Descr DescrBodega,A.IDProveedor,P.Nombre NombreProveedor,A.IDOrdenCompra,
			O.OrdenCompra,A.IDDocumentoCP,A.TipoCambio,A.Usuario,A.CreateDate,A.CreatedBy,A.RecordDate,A.UpdateBy
  FROM dbo.invEmbarque A
LEFT JOIN dbo.invOrdenCompra O ON A.IDOrdenCompra=O.OrdenCompra
INNER JOIN dbo.cppProveedor P ON A.IDProveedor=P.IDProveedor
INNER JOIN dbo.invBodega B ON A.IDBodega=B.IDBodega
WHERE (A.IDEmbarque =@IDEmbarque OR @IDEmbarque=-1) AND A.Fecha BETWEEN @FechaInicial AND @FechaFinal AND (A.IDProveedor =@IDProveedor OR @IDProveedor=-1)
 AND (O.OrdenCompra =@OrdenCompra OR o.OrdenCompra LIKE '%'+ @OrdenCompra +'%') AND (A.IDDocumentoCP = @IDDocumentoCP OR @IDDocumentoCP=-1)

GO 

CREATE PROCEDURE dbo.invUpdateEmbarqueDetalle(@Operacion AS NVARCHAR(1),@IDEmbarque AS INT,@IDProducto AS bigint, @IDLote AS int, @Cantidad AS decimal(28,4), @CantidadAceptada AS decimal(28,4),@CantidadRechazada AS decimal(28,4),@Comentario AS nvarchar(20))
AS 
IF (@Operacion='I')
BEGIN
	INSERT INTO dbo.invEmbarqueDetalle( IDEmbarque ,IDProducto ,IDLote ,Cantidad ,CantidadAceptada ,CantidadRechazada ,Comentario)
	VALUES (@IDEmbarque,@IDProducto,@IDLote,@Cantidad,@CantidadAceptada,@CantidadRechazada,@Comentario)
END
IF (@Operacion='U')
BEGIN
	UPDATE dbo.invEmbarqueDetalle SET  Cantidad=@Cantidad,CantidadAceptada=@CantidadAceptada,CantidadRechazada=@CantidadRechazada,
																Comentario=@Comentario
	 WHERE IDEmbarque=@IDEmbarque AND IDProducto=@IDProducto AND IDLote=@IDLote
END
IF (@Operacion='D')
BEGIN
	DELETE FROM dbo.invEmbarqueDetalle WHERE IDEmbarque=@IDEmbarque AND( IDProducto=@IDProducto OR @IDProducto=-1) AND (IDLote=@IDLote OR @IDLote=-1)
END

GO

CREATE PROCEDURE dbo.invGetEmbarqueDetalle(@IDEmbarque AS INT)
AS 
SELECT A.IDEmbarque,A.IDProducto,P.Descr DescrProducto,A.IDLote,L.LoteProveedor,L.FechaVencimiento,A.Cantidad,A.CantidadAceptada,A.CantidadRechazada 
 FROM dbo.invEmbarqueDetalle A
INNER JOIN dbo.invProducto P ON A.IDProducto = P.IDProducto
INNER JOIN dbo.invLote L ON a.IDProducto=L.IDProducto AND A.IDLote=L.IDLote
WHERE A.IDEmbarque =@IDEmbarque

GO

CREATE  PROCEDURE dbo.invGetArticuloProveedor(@IDProducto AS BIGINT,@IDProveedor AS INT)
AS	
SELECT  A.IDProducto ,P.Descr DescrProducto,
        A.IDProveedor ,PR.Nombre NombreProveedor,
        A.IDPaisManofactura ,C.Descr DescrPais,
        A.LoteMinCompra ,
        A.PesoMinimoCompra,
        A.Notas
         FROM dbo.invArticuloProveedor A
INNER JOIN dbo.invProducto P ON A.IDProducto = P.IDProducto
INNER JOIN dbo.cppProveedor PR ON A.IDProveedor=PR.IDProveedor
LEFT JOIN dbo.globalPais C ON A.IDPaisManofactura = C.IDPais
WHERE (A.IDProducto = @IDProducto OR @IDProducto =-1) AND (A.IDProveedor=@IDProveedor OR @IDProveedor=-1)


go

CREATE PROCEDURE dbo.invUpdateArticuloProveedor (@Operacion AS NVARCHAR(1),@IDProducto AS BIGINT,@IDProveedor AS INT, 
				@IDPaisManoFactura AS INT,@LoteMinCompra AS DECIMAL(28,4),@PesoMinimoCompra AS DECIMAL(28,4),@Notas NVARCHAR(256),@Usuario AS NVARCHAR(50), @Fecha AS DATETIME)
AS 
IF (@Operacion='I')
BEGIN
	INSERT INTO dbo.invArticuloProveedor( IDProducto ,IDProveedor ,IDPaisManofactura ,LoteMinCompra ,PesoMinimoCompra,Notas,CreateDate,CreatedBy)
	VALUES (@IDProducto,@IDProveedor,@IDPaisManoFactura,@LoteMinCompra,@PesoMinimoCompra,@Notas,@Fecha,@Usuario)
END			
IF (@Operacion='U')
BEGIN
	UPDATE dbo.invArticuloProveedor SET  IDPaisManofactura=@IDPaisManoFactura,
				LoteMinCompra=@LoteMinCompra, PesoMinimoCompra = @PesoMinimoCompra, Notas=@Notas,UpdatedBy = @Usuario, UpdatedDate= @Fecha
	WHERE IDProducto=@IDProducto AND IDProveedor= @IDProveedor
END
IF (@Operacion='D')
	DELETE FROM dbo.invArticuloProveedor WHERE IDProducto=@IDProducto AND IDProveedor=@IDProveedor

GO

CREATE  PROCEDURE dbo.invGetProductosSinAsociarProveedor(@IDProveedor AS INT,@IDClasificacion1 AS INT,@IDClasificacion2 AS INT,
		@IDClasificacion3 AS INT,@IDClasificacion4  AS INT,@IDClasificacion5  AS INT,@IDClasificacion6 AS INT)
AS
SELECT  IDProducto ,A.Descr ,Alias ,Clasif1 ,C.Descr DescrClasif1,Clasif2,D.Descr DescrClasif2 ,Clasif3 ,E.Descr DescrClasif3,
				Clasif4, F.Descr DescrClasif4 ,Clasif5,G.Descr DescrClasif5 ,Clasif6, H.Descr DescrClasif6
FROM dbo.invProducto A
LEFT  JOIN dbo.invClasificacion c ON A.Clasif1= C.IDClasificacion AND IDGrupo=1
LEFT  JOIN dbo.invClasificacion d ON A.Clasif2= d.IDClasificacion AND D.IDGrupo=2
LEFT  JOIN dbo.invClasificacion e ON A.Clasif3= e.IDClasificacion AND e.IDGrupo=3
LEFT  JOIN dbo.invClasificacion f ON A.Clasif4= f.IDClasificacion AND f.IDGrupo=4
LEFT  JOIN dbo.invClasificacion g ON A.Clasif5= g.IDClasificacion AND g.IDGrupo=5
LEFT  JOIN dbo.invClasificacion h ON A.Clasif6= h.IDClasificacion AND h.IDGrupo=6
WHERE IDProducto  NOT IN (SELECT IDProducto  FROM dbo.invArticuloProveedor WHERE IDProveedor=@IDProveedor) AND A.Activo=1
AND (A.Clasif1 = @IDClasificacion1 OR @IDClasificacion1=-1) AND (A.Clasif2 = @IDClasificacion2  OR @IDClasificacion2 = -1) AND 
(A.Clasif3=@IDClasificacion3 OR @IDClasificacion3=-1) AND (A.Clasif4 = @IDClasificacion4 OR @IDClasificacion4=-1) AND 
(A.Clasif5 = @IDClasificacion5 OR @IDClasificacion5=-1)  AND (A.Clasif6=@IDClasificacion6 OR @IDClasificacion6=-1)


GO

CREATE  PROCEDURE dbo.invGetSolicitudCompra_OrdenCompra(@IDSolicitud AS INT,@IDOrdenCompra AS INT,@IDProducto AS BIGINT)
AS 
SELECT  IDSolicitud ,IDOrdenCompra ,IDProducto ,Cantidad ,Usuario ,Fecha  FROM dbo.invSolicitudOrdenCompra 
WHERE IDSolicitud= @IDSolicitud AND (IDOrdenCompra = @IDOrdenCompra OR @IDOrdenCompra= -1) AND (IDProducto = @IDProducto OR  @IDProducto = -1) 

GO

CREATE PROCEDURE dbo.invGetGlobalPais(@IDPais AS INT)
AS 
SELECT IDPais,Descr,Activo  FROM dbo.globalPais
WHERE (IDPais = @IDPais OR @IDPais = -1) AND Activo=1

GO

INSERT INTO dbo.invEstadoSolicitud( IDEstado, Descr, Activo ) VALUES(0,'INICIAL',1)
GO
INSERT INTO dbo.invEstadoSolicitud( IDEstado, Descr, Activo ) VALUES(1,'APROBADA',1)
GO
INSERT INTO dbo.invEstadoSolicitud( IDEstado, Descr, Activo ) VALUES(2,'RECHAZADA',1)
GO	
INSERT INTO dbo.invEstadoSolicitud( IDEstado, Descr, Activo ) VALUES(3,'ASIGNADA',1)


GO 

INSERT INTO dbo.invEstadoOrdenCompra( IDEstadoOrden, Descr, Activo )
VALUES  (0,'INICIAL',1)

GO 


INSERT INTO dbo.invEstadoOrdenCompra( IDEstadoOrden, Descr, Activo )
VALUES  (1,'APROBADO',1)

go 

INSERT INTO dbo.invEstadoOrdenCompra( IDEstadoOrden, Descr, Activo )
VALUES  (2,'CONFIRMADA',1)

GO 


INSERT INTO dbo.invEstadoOrdenCompra( IDEstadoOrden, Descr, Activo )
VALUES  (3,'BACKORDER',1)

go

INSERT INTO dbo.invEstadoOrdenCompra( IDEstadoOrden, Descr, Activo )
VALUES  (4,'CANCELADA',1)

go

INSERT INTO dbo.invEstadoOrdenCompra( IDEstadoOrden, Descr, Activo )
VALUES  (5,'RECIBIDA',1)

GO

CREATE PROCEDURE dbo.invGetProveedor(@IDProveedor AS INT)
AS	
SELECT  IDProveedor ,
        Nombre ,
        IDRuc ,
        Activo  FROM dbo.cppProveedor WHERE (IDProveedor = @IDProveedor OR @IDProveedor=-1)
        
GO



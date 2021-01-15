

Create Table dbo.ccfClaseDocumento ( TipoDocumento nvarchar(1) not null, IDClase nvarchar(10) not null, Descr nvarchar(250), 
Orden int default 0, Activo bit default 1)
go

alter table dbo.ccfClaseDocumento add constraint  pkccfClaseDocumento primary key ( TipoDocumento,IDClase  )
go

alter table dbo.ccfClaseDocumento add constraint ukccfClaseDocumento UNIQUE (orden)
go


insert dbo.ccfClaseDocumento ( TipoDocumento,  IDClase , Descr, orden, activo)
values ('D', 'FAC', 'FACTURA', 1, 1)
GO

insert dbo.globalConsecMask (Codigo, Descr, Longitud, Mascara, Consecutivo, Activo, IDModulo)
values ('FACC', 'FACTURA CXC', 6, 'NNNNNN', '000000', 1, 600)
GO

insert dbo.ccfClaseDocumento ( TipoDocumento, IDClase , Descr, orden, activo )
values ('D', 'N/D', 'NOTAS DE DEBITO', 2, 1)
GO

insert dbo.globalConsecMask (Codigo, Descr, Longitud, Mascara, Consecutivo, Activo, IDModulo)
values ('NDC', 'NOTAS DEBITOS CXC', 6, 'NNNNNN', '000000', 1, 600)
GO

insert dbo.ccfClaseDocumento ( TipoDocumento,  IDClase , Descr, orden, activo)
values ('D', 'O/D', 'OTROS DEBITOS', 3, 1)
GO

insert dbo.globalConsecMask (Codigo, Descr, Longitud, Mascara, Consecutivo, Activo, IDModulo)
values ('ODC', 'OTROS DEBITOS CXC', 6, 'NNNNNN', '000000', 1, 600)
GO


insert dbo.ccfClaseDocumento ( TipoDocumento, IDClase , Descr, orden, activo )
values ('D', 'D/C', 'DIFERENCIAL CAMBIARIO / DESLIZAMIENTO', 4, 1)
GO

insert dbo.globalConsecMask (Codigo, Descr, Longitud, Mascara, Consecutivo, Activo, IDModulo)
values ('DCC', 'DIFERENCIAL CAMBIARIO CXC', 6, 'NNNNNN', '000000', 1, 600)
GO


insert dbo.ccfClaseDocumento (TipoDocumento, IDClase , Descr, orden, activo )
values ('D', 'INT', 'INTERES MORATORIO', 5, 1)
GO

insert dbo.globalConsecMask (Codigo, Descr, Longitud, Mascara, Consecutivo, Activo, IDModulo)
values ('INTC', 'INTERESES CXC', 6, 'NNNNNN', '000000', 1, 600)
GO

insert dbo.ccfClaseDocumento (TipoDocumento, IDClase , Descr, orden, activo )
values ('C', 'R/C', 'RECIBO DE CAJA', 6, 1)
GO

insert dbo.globalConsecMask (Codigo, Descr, Longitud, Mascara, Consecutivo, Activo, IDModulo)
values ('RCC', 'RECIBOS DE CAJA CXC', 6, 'NNNNNN', '000000', 1, 600)
GO

insert dbo.ccfClaseDocumento (TipoDocumento, IDClase , Descr, orden, activo)
values ('C','N/C', 'NOTAS DE CREDITO', 7, 1)
GO

insert dbo.globalConsecMask (Codigo, Descr, Longitud, Mascara, Consecutivo, Activo, IDModulo)
values ('NCC', 'NOTAS DE CREDITO CXC', 6, 'NNNNNN', '000000', 1, 600)
GO

insert dbo.ccfClaseDocumento (TipoDocumento, IDClase , Descr, orden, activo)
values ('C','O/C', 'OTROS CREDITO', 8, 1)
GO

insert dbo.globalConsecMask (Codigo, Descr, Longitud, Mascara, Consecutivo, Activo, IDModulo)
values ('OCC', 'OTROS CREDITOS CXC', 6, 'NNNNNN', '000000', 1, 600)
GO

insert dbo.globalConsecMask (Codigo, Descr, Longitud, Mascara, Consecutivo, Activo, IDModulo)
values ('D', 'DEVOLUCION', 6, 'NNNNNN', '000000', 1, 600)
GO

Create Table dbo.ccfSubTipoDocumento (IDSubTipo int identity(1,1) not null, TipoDocumento nvarchar(1) not null, 
IDClase nvarchar(10) not null,  CodigoConsecMask [nvarchar](20) not NULL,
Descr nvarchar(200), Descripcion nvarchar(200), Consecutivo int default 0, EsRecuperacion bit default 0, 
SubTipoGeneraAsiento bit default 0, NaturalezaCta nvarchar(1), CtaDebito varchar(25), CtaCredito varchar(25),
AplicaDocumentos bit default 0, ContraCtaEnSubTipo bit default 0, flgProtegidoSys bit default 0 )
-- ContraCtaEnSubTipo : 1 El Asiento tomara la cta contable de la contracuenta en el subTipoDocumento 0 : Toma la CxC de la sucursal
-- AplicaDocumentos QUIERE DECIR QUE EL SUBTIPO NO DISTRIBUYE AUTOMATICAMENTE NI MANUALMENTE, NO APLICA NINGUN DOCUMENTO, NO ES RECUPERACION
--, Orden int default 0, DistribAutom bit default 0, EsInteres bit default 0, EsDeslizamiento bit default 0 )
go

alter table dbo.ccfSubTipoDocumento add constraint pkccfSubTipoDocumento primary key (IDSubTipo )
go

create  index  _indccfSubTipoDocumento  on dbo.ccfSubTipoDocumento   (IDSubTipo )
go 

alter table dbo.ccfSubTipoDocumento add constraint ukccfSubTipoDocumento UNIQUE (TipoDocumento, IDClase, IDSubTipo, CodigoConsecMask)
go

alter table dbo.ccfSubTipoDocumento add constraint fkccfSubTipoDocumento foreign key (TipoDocumento, IDClase) references dbo.ccfClaseDocumento (TipoDocumento, IDClase)
go

ALTER TABLE [dbo].ccfSubTipoDocumento  WITH CHECK ADD  CONSTRAINT [fkSubTipoDocCCConsecDev] FOREIGN KEY(CodigoConsecMask)
REFERENCES [dbo].[globalConsecMask] ([Codigo])
GO

alter table dbo.ccfSubTipoDocumento add constraint ckEsRecuperacion 
CHECK((TipoDocumento='C' and (EsRecuperacion =1 OR EsRecuperacion = 0)) or (TipoDocumento='D' and EsRecuperacion =0))
go


alter table dbo.ccfSubTipoDocumento add constraint ckNaturaleza 
CHECK( ( not NaturalezaCta is null and ( NaturalezaCta ='D' or NaturalezaCta = 'C'))
)
go

Insert dbo.ccfSubTipoDocumento ( TipoDocumento,  IDClase, Descr, Descripcion, CodigoConsecMask,  Consecutivo, AplicaDocumentos, SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, flgProtegidoSys  )	
Values ('D',	 'FAC',	'FACTURAS',	'FACTURA', 'FACC',	1,0, 0, 'D', NULL,NULL, 1)
GO

Insert dbo.ccfSubTipoDocumento ( TipoDocumento,  IDClase, Descr, Descripcion, CodigoConsecMask, Consecutivo, AplicaDocumentos, SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, flgProtegidoSys )	
Values ('D',	 'INT',	'INTERESES',	'INTERES POR MORA', 'INTC',	1,0	, 0, 'D', NULL, NULL, 1	)
GO
Insert dbo.ccfSubTipoDocumento ( TipoDocumento,  IDClase, Descr, Descripcion,CodigoConsecMask, Consecutivo,  AplicaDocumentos, SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, flgProtegidoSys )	
Values ('D',	 'D/C'	, 'DIFERENCIAL CAMBIARIO',	'DIFERENCIAL CAMBIARIO', 'DCC',	1,0,0, 'D', NULL,NULL, 1	)
GO

Insert dbo.ccfSubTipoDocumento ( TipoDocumento,  IDClase, Descr, Descripcion, CodigoConsecMask, Consecutivo, AplicaDocumentos, SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, flgProtegidoSys  )	
Values ('D',	 'N/D'	, 'NOTA DE DEBITO',	'NOTA DE DEBITO', 'NDC'	,1,0,0, 'D', NULL,NULL,1	)
GO

Insert dbo.ccfSubTipoDocumento ( TipoDocumento,  IDClase, Descr, Descripcion, CodigoConsecMask, Consecutivo, AplicaDocumentos, SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, flgProtegidoSys  )	
Values ('D',	 'O/D'	, 'OTROS DEBITOS',	'OTROS DEBITOS', 'ODC',	1,0,0, 'D', NULL,NULL, 1	)
GO

Insert dbo.ccfSubTipoDocumento ( TipoDocumento,  IDClase, Descr, Descripcion, CodigoConsecMask, Consecutivo, AplicaDocumentos, SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, flgProtegidoSys  )	
Values ('C',	 'R/C',	'RECIBOS',	'RECIBO DE CAJA', 'RCC',	1,1,1, 'C', NULL, NULL, 1	)
GO
Insert dbo.ccfSubTipoDocumento ( TipoDocumento,  IDClase, Descr, Descripcion, CodigoConsecMask, Consecutivo, AplicaDocumentos, SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, flgProtegidoSys  )	
Values ('C',	 'N/C',	'NOTA DE CREDITO',	'NOTA DE CREDITO', 'NCC',	1,1,1, 'C', NULL, NULL, 1	)
GO
Insert dbo.ccfSubTipoDocumento ( TipoDocumento,  IDClase, Descr, Descripcion,CodigoConsecMask, Consecutivo, AplicaDocumentos, SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, flgProtegidoSys  )	
Values ('C',	 'O/C',	'OTRO CREDITO',	'NOTA DE CREDITO', 'OCC',	1,1,1, 'C',  NULL, NULL, 1	)
GO
Update dbo.ccfSubTipoDocumento  set SubtipoGeneraAsiento = 1 
GO


--drop table dbo.ccfParametros alter table dbo.ccfParametros add TipoDocNCDevolucion nvarchar(1), TipoDocFACRCDesglosado nvarchar(1) bit
Create table dbo.ccfParametros (IDParametro int identity (1,1) not null, UnaSolaMoneda bit default 0,IDMonedaUnica int ,
DocAprobadosDefault bit default 0, CambiarPlazo bit default 0, TipoAsientoDebito nvarchar(2), 
TipoAsientoCredito nvarchar(2), IntegracionContable bit default 0, EditaConsecutivos bit default 0,
UsaReciboDesglosado bit default 0, TipoDocRCDesglosado nvarchar(1), 
IDClaseRCDesglosado nvarchar(10), TipoDocFACRCDesglosado nvarchar(1),
 IDClaseFACRCDesglosado nvarchar(10), TipoDocNCDevolucion nvarchar(1), IDClaseNCDevolucion nvarchar(10), IDSubTipoNCDevolucion int  )
go
alter table dbo.ccfParametros add constraint pkParametros primary key (IDParametro)
go
alter table dbo.ccfParametros add constraint fkparametroMoneda foreign key (IDMonedaUnica) references dbo.globalMoneda (IDMoneda)
go
alter table dbo.ccfParametros add constraint fkparametroTipoAsientodeb foreign key (TipoAsientoDebito) references dbo.cntTipoAsiento (Tipo)
go
alter table dbo.ccfParametros add constraint fkparametroTipoAsientocred foreign key (TipoAsientoCredito) references dbo.cntTipoAsiento (Tipo)
go
alter table dbo.ccfParametros add constraint fkparametroClaseRCDesglosado foreign key ( TipoDocRCDesglosado, IDClaseRCDesglosado) references dbo.ccfClaseDocumento (TipoDocumento, IDClase)
go
alter table dbo.ccfParametros add constraint fkparametroClaseFACRCDesglosado foreign key (TipoDocFACRCDesglosado, IDClaseFACRCDesglosado) references dbo.ccfClaseDocumento (TipoDocumento,IDClase)
go
alter table dbo.ccfParametros add constraint fkparametroClaseNCDEV foreign key (TipoDocNCDevolucion, IDClaseNCDevolucion) references dbo.ccfClaseDocumento (TipoDocumento,IDClase)
go
alter table dbo.ccfParametros add constraint fkparametroSubTipoClaseNCDEV foreign key ( IDSubTipoNCDevolucion) references dbo.ccfSubTipoDocumento (IDSubTipo)
go

--  alter table dbo.ccfgetparametros add 
create Procedure dbo.ccfGetParametros (@IDParametro int)
as
set nocount on
Select IDParametro, UnaSolaMoneda, IDMonedaUnica, DocAprobadosDefault, CambiarPlazo, TipoAsientoDebito, 
TipoAsientoCredito, IntegracionContable, EditaConsecutivos, UsaReciboDesglosado, IDClaseRCDesglosado,
IDClaseFACRCDesglosado,TipoDocNCDevolucion, IDSubTipoNCDevolucion,  IDClaseNCDevolucion 
from dbo.ccfParametros 
where IDParametro = @IDParametro
go

create Procedure dbo.ccfUpdateParametros (@IDParametro int, 
@UnaSolaMoneda bit ,@IDMonedaUnica int ,
@DocAprobadosDefault bit , @CambiarPlazo bit , @TipoAsientoDebito nvarchar(2)
, @TipoAsientoCredito nvarchar(2) , @IntegracionContable  bit ,  @EditaConsecutivos  bit, 
@UsaReciboDesglosado bit, @IDClaseRCDesglosado nvarchar(10), @IDClaseFACRCDesglosado nvarchar(10),
 @TipoDocNCDevolucion nvarchar(1), @IDSubTipoNCDevolucion int,  @IDClaseNCDevolucion nvarchar(10)  )
as
set nocount on
if not exists (select * from dbo.ccfParametros )
Begin
	Insert dbo.ccfParametros (UnaSolaMoneda, IDMonedaUnica,DocAprobadosDefault, CambiarPlazo, TipoAsientoDebito, 
	TipoAsientoCredito, IntegracionContable, EditaConsecutivos, UsaReciboDesglosado, TipoDocRCDesglosado,  IDClaseRCDesglosado, TipoDocFACRCDesglosado, IDClaseFACRCDesglosado,
	TipoDocNCDevolucion, IDSubTipoNCDevolucion,  IDClaseNCDevolucion    )
	values (@UnaSolaMoneda, @IDMonedaUnica,@DocAprobadosDefault, @CambiarPlazo , @TipoAsientoDebito ,
	 @TipoAsientoCredito,  @IntegracionContable , @EditaConsecutivos, @UsaReciboDesglosado , 'C', @IDClaseRCDesglosado ,'D', @IDClaseFACRCDesglosado ,
	 @TipoDocNCDevolucion, @IDSubTipoNCDevolucion,  @IDClaseNCDevolucion    )
end
else
Begin
	Update dbo.ccfParametros Set UnaSolaMoneda =@UnaSolaMoneda, 
	IDMonedaUnica = @IDMonedaUnica,DocAprobadosDefault = @DocAprobadosDefault, 
	CambiarPlazo =@CambiarPlazo,  TipoAsientoDebito  = @TipoAsientoDebito ,  
	TipoAsientoCredito  = @TipoAsientoCredito, IntegracionContable = @IntegracionContable, EditaConsecutivos = @EditaConsecutivos
	, UsaReciboDesglosado = @UsaReciboDesglosado , IDClaseRCDesglosado = @IDClaseRCDesglosado , 
	IDClaseFACRCDesglosado = @IDClaseFACRCDesglosado,
	TipoDocNCDevolucion = @TipoDocNCDevolucion,IDSubTipoNCDevolucion = @IDSubTipoNCDevolucion,  
	IDClaseNCDevolucion = @IDClaseNCDevolucion 
	where IDParametro = @IDParametro
End
go


Create Table dbo.ccfDebitos ( 
	IDDebito int  identity(1,1) not null ,
	IDCliente int  not null,
	IDBodega int  not null,
	IDVendedor int , 
	TipoDocumento nvarchar(1) not null,
	IDClase nvarchar(10) not null,
	IDSubTipo	int not null, 
	Documento nvarchar(20) not null,
	Fecha datetime not null,
	Vencimiento datetime not null,
	Plazo decimal(8,2) default 0,
	MontoOriginal decimal(28,4) default 0,
	FechaUltCredito datetime default '19800101',
	SaldoActual  decimal(28,4) default 0,
	Cancelado bit default 0,
	PorcInteres decimal(8,2) default 0,
	Anulado bit default 0,
	ConceptoSistema nvarchar(500) default '',
	ConceptoUsuario nvarchar(500) default '',
	Asiento nvarchar(20),
	AsientoReversion nvarchar(20),
	Usuario nvarchar(20), CreateDate datetime, 
	TipoCambio decimal(28,4) default 1,
	Contabilizado bit default 0,
	AsientoDevolucion [nvarchar] (20)  NULL,
	flgOrigenExterno bit default 0,
	flgAprobado bit default 0,
	IDMoneda int not null
	
) 
go

alter table dbo.ccfDebitos add constraint pkccfDebitos primary key (IDDebito)
go
alter table dbo.ccfDebitos add constraint fkccfDebitosCliente foreign key (IDCliente ) references dbo.ccfclientes (IDCliente )
go

alter table dbo.ccfDebitos add constraint fkccfDebitosSucursal foreign key (IDBodega ) references dbo.invBodega   (IDBodega )
go

alter table dbo.ccfDebitos add constraint fkccfDebitosVendedor foreign key (IDVendedor ) references dbo.fafVendedor   (IDVendedor )
go

alter table dbo.ccfDebitos add constraint fkccfDebitosDocument foreign key  ( IDSubTipo ) references dbo.ccfSubTipoDocumento (  IDSubTipo)
go

alter table dbo.ccfDebitos add constraint ukccfDebitosCC UNIQUE ( IDBodega , IDClase, Documento)
go

alter table dbo.ccfDebitos add constraint fkccfDebitosMoneda foreign key (IDMoneda ) references dbo.globalMoneda   (IDMoneda )
go


Create nonclustered index indccfDebitosCC on dbo.ccfDebitos (IDBodega , IDCliente , TipoDocumento, IDClase, Fecha, Documento )
go

CREATE NONCLUSTERED INDEX [i_ccfDebitos] ON dbo.ccfDebitos ([IDCliente], [IDClase], [TipoDocumento])
go

Create Table dbo.ccfCreditos ( 
	IDCredito int  identity(1,1) not null ,
	IDCliente int  not null,
	IDBodega int  not null,
	IDVendedor int , 
	TipoDocumento nvarchar(1) not null,
	IDClase nvarchar(10) not null,
	IDSubTipo	int not null, 
	Documento nvarchar(20) not null,
	Fecha datetime not null,
	MontoOriginal decimal(28,4) default 0,
	FechaUltCredito datetime default '19800101',
	SaldoActual  decimal(28,4) default 0,
	Cancelado bit default 0,
	Anulado bit default 0,
	ConceptoSistema nvarchar(500) default '',
	ConceptoUsuario nvarchar(500) default '',
	RecibimosDe nvarchar(250),
	Asiento nvarchar(20),
	AsientoReversion nvarchar(20),
	Usuario nvarchar(20), CreateDate datetime, 
	TipoCambio decimal(28,4) default 1,
	Contabilizado bit default 0,
	flgOrigenExterno bit default 0,
	flgAprobado bit default 0,
	IDMoneda int not null,
	flgFlotante bit default 0,
	Efectivo decimal (28,4) default 0,
	Descuento decimal (28,4) default 0,
	RetencionMunicipal decimal (28,4) default 0,
	RetencionRenta decimal (28,4) default 0,
	IDChequePos int,
	MontoChequePos 	decimal (28,4) default 0	
) 
go


alter table dbo.ccfCreditos add constraint pkccfCredito primary key (IDCredito)
go
alter table dbo.ccfCreditos add constraint fkccfCreditosCliente foreign key (IDCliente ) references dbo.ccfclientes (IDCliente )
go

alter table dbo.ccfCreditos add constraint fkccfCreditosSucursal foreign key (IDBodega ) references dbo.invBodega   (IDBodega )
go

alter table dbo.ccfCreditos add constraint fkccfCreditosVendedor foreign key (IDVendedor ) references dbo.fafVendedor   (IDVendedor )
go
-- alter table dbo.ccfCreditos drop constraint fkccfCreditosChkPos
--alter table dbo.ccfCreditos add constraint fkccfCreditosChkPos foreign key (IDChequePos ) references dbo.ccfChequePosFechado   (IDChequePos )
--go


alter table dbo.ccfCreditos add constraint fkccfCreditosDocument foreign key  ( IDSubTipo ) references dbo.ccfSubTipoDocumento (  IDSubTipo)
go

alter table dbo.ccfCreditos add constraint ukccfCreditosCC UNIQUE ( IDBodega , IDClase, Documento)
go

alter table dbo.ccfCreditos add constraint fkccfCreditosMoneda foreign key (IDMoneda ) references dbo.globalMoneda   (IDMoneda )
go
Create nonclustered index indccfCreditos on dbo.ccfCreditos (IDBodega , IDCliente , TipoDocumento, IDClase, Fecha, Documento )
go

CREATE NONCLUSTERED INDEX [i_ccfCreditos] ON dbo.ccfCreditos ([IDCliente], [IDClase], [TipoDocumento])
go

alter table dbo.fafDevolucion add constraint pkfafDevoluionNotaCredito foreign key (IDNotaCredito) references dbo.ccfCreditos (IDCredito)
go


Create table dbo.ccfChequePosFechado (IDChequePos int not null identity (1, 1),
IDCredito int  null, FechaCobro date,
Numero nvarchar(20), Monto decimal (28,4) default 0, IDBanco int not null, SinFondo bit default 0, Cobrado bit default 0, Anulado bit default 0 )
go

alter table dbo.ccfChequePosfechado add constraint pkccfChquePosFechado primary key (IDChequePos)
go

alter table dbo.ccfChequePosfechado add constraint fkccfChquePosFechadoRec foreign key (IDCredito) 
references dbo.ccfCreditos (IDCredito)
go


--drop table dbo.ccfChequePosFechado


Create Table dbo.ccfAplicaciones ( IDAplicacion int identity(1,1) not null,
IDDebito int not null,
IDCredito int not null, 
DocDebito nvarchar(20) not null,
DocCredito nvarchar(20) not null,
Fecha datetime not null,
FechaCredito datetime not null default '19800101',
MontoCredito decimal(28,4) default 0,
CreateDate	datetime null,
Asiento nvarchar(20),
fechaUltCreditoAnt datetime,
flgFlotante bit default 0, 
Efectivo decimal (28,4) default 0,
Descuento decimal (28,4) default 0,
RetencionMunicipal decimal (28,4) default 0,
RetencionRenta decimal (28,4) default 0,
IDChequePos int,
MontoChequePos 	decimal (28,4) default 0
)
go


alter table dbo.ccfAplicaciones add constraint pkccfAplicaciones primary key (IDAplicacion)
go

alter table dbo.ccfAplicaciones add constraint fkccfAplicacionesDebito foreign key (IDDebito) references dbo.ccfDebitos (IDDebito)
go

alter table dbo.ccfAplicaciones add constraint fkccfAplicacionesCredito foreign key (IDCredito) references dbo.ccfCreditos (IDCredito)
go

alter table dbo.ccfAplicaciones add constraint fkccfAplicacionesChkPos foreign key (IDChequePos) references dbo.ccfChequePosfechado (IDChequePos)
go

--alter table dbo.ccfAplicaciones drop constraint ukccfAplicaciones
alter table dbo.ccfAplicaciones add constraint ukccfAplicaciones UNIQUE (IDDebito, DocCredito, DocDebito, Fecha, FechaCredito, IDCredito)
go

ALTER TABLE dbo.ccfAplicaciones ADD  DEFAULT (getdate()) FOR CreateDate
GO

Create nonclustered index  indccfAplicacionesIDDebito on dbo.ccfAplicaciones (IDDebito)
go

Create nonclustered index  indccfAplicacionesIDCredito on dbo.ccfAplicaciones (IDCredito)
go
-- 

create Procedure dbo.ccfUpdateccfCreditos @Operation nvarchar(1),  @IDCredito int Output, 
@IDCliente int  ,@IDBodega int  ,@TipoDocumento nvarchar(1) , @IDClase nvarchar(10), 
@IDSubTipo	int , @Documento nvarchar(20) , @Fecha datetime , @Plazo INT ,  @MontoOriginal decimal(28,4) ,
@ConceptoSistema nvarchar(500),@ConceptoUsuario nvarchar(500), @RecibimosDe nvarchar(250),
@Usuario nvarchar(20), @TipoCambio decimal(28,4), @IDVendedor int, 	@flgOrigenExterno bit ,
@flgAprobado bit,   @CodigoConsecutivoMask nvarchar(20) = null, @IDMoneda int = null, @Anulado bit = null, @flgFlotante bit = null,
@Efectivo decimal (28,4) = null,
@Descuento decimal (28,4) = null,
@RetencionMunicipal decimal (28,4) = null,
@RetencionRenta decimal (28,4) = null,
@MontoChequePos 	decimal (28,4) = null, @NumeroChkPos nvarchar(20) = null, @IDBancoChkPos int = null, @FechaCobroChkpos date = null
-- @Operation = I Nuevo, D Eliminar, F Modifica Fecha Credito
as
set nocount on
declare @Ok bit, @Vencimiento datetime ,@VencimientoVar datetime ,@FechaUltCredito datetime, @SaldoActual  decimal(28,4) 
,  @Cancelado bit, @IDChequePos int 
set @Ok = 0

if @Anulado is null 
	set @Anulado = 0
if @flgFlotante is null 
	set @flgFlotante = 0
if @Efectivo is null 
	set @Efectivo = 0
if @Descuento is null 
	set @Descuento = 0	
if @RetencionMunicipal is null 
	set @RetencionMunicipal = 0
if @RetencionRenta is null 
	set @RetencionRenta = 0	
	
if @MontoChequePos is null 
	set @MontoChequePos = 0	
if @NumeroChkPos is null 
	set @NumeroChkPos = ''
	
--begin transaction 
begin try
if upper(@Operation) = 'I'
begin
	SET @Vencimiento = DATEADD(day, @Plazo, @Fecha )

	SET @SaldoActual = @MontoOriginal

	set @Cancelado = 0

	if @flgFlotante = 1 
	begin
	
	insert dbo.ccfChequePosFechado (IDCredito, Numero, Monto, IDBanco, SinFondo, Cobrado, FechaCobro )
	Values (null,@NumeroChkPos,@MontoChequePos,  @IDBancoChkPos, 0, 0, @FechaCobroChkpos )
	
	set @IDChequePos = (SELECT SCOPE_IDENTITY())
	
	end
	 
	if @IDClase = 'R/C' 
	set @flgAprobado = 1
	else
	set @flgAprobado = 0
	insert dbo.ccfCreditos ( IDCliente , IDBodega , TipoDocumento, IDClase, IDSubTipo,Documento,Fecha,
	 MontoOriginal, FechaUltCredito, SaldoActual, 
	Cancelado, Anulado, ConceptoSistema, ConceptoUsuario, RecibimosDe,Usuario, TipoCambio, IDVendedor, flgOrigenExterno, flgAprobado, 
	IDMoneda, flgFlotante, Efectivo, Descuento, RetencionMunicipal, RetencionRenta,  MontoChequePos, IDChequePos  )

	values (
	@IDCliente ,@IDBodega ,@TipoDocumento, @IDClase, @IDSubTipo,@Documento,@Fecha,
	@MontoOriginal,	@FechaUltCredito, @MontoOriginal, @Cancelado,  @Anulado, @ConceptoSistema, @ConceptoUsuario,
	@RecibimosDe, @Usuario, @TipoCambio, @IDVendedor, @flgOrigenExterno, @flgAprobado, 
	@IDMoneda, @flgFlotante, @Efectivo, @Descuento, @RetencionMunicipal, @RetencionRenta ,  @MontoChequePos, @IDChequePos
	)
	Set @IDCredito  = (SELECT SCOPE_IDENTITY())
	
	Update dbo.ccfChequePosFechado set IDCredito = @IDCredito 
	Where IDChequePos = @IDChequePos 

	Update dbo.globalConsecMask set Consecutivo = @Documento where Codigo = @CodigoConsecutivoMask
end

if upper(@Operation) = 'U'
begin
	Update dbo.ccfCreditos set ConceptoUsuario = @ConceptoUsuario , Documento = @Documento,
	Fecha = @Fecha, MontoOriginal = @MontoOriginal 
	where IDCredito  =  @IDCredito  and flgAprobado = 0 and flgOrigenExterno = 0 and Anulado = 0
end

if upper(@Operation) = 'D'
begin
set @Ok = 1
	if exists( Select IDAplicacion from dbo.ccfAPLICACIONES (Nolock)  where IDCredito =  @IDCredito )
	begin
	RAISERROR ('Ud est· queriendo eliminar un documento que tiene Aplicaciones, primero elimÌnelas', 16, 10);
	set @Ok = 0
	end
	if  @Ok = 1
	Delete from dbo.ccfCreditos where IDCredito  =  @IDCredito and flgAprobado = 0 and flgOrigenExterno = 0 and Anulado = 0
end

--commit 
SELECT isnull(@IDCredito,0) IDCredito
Return isnull(@IDCredito,0)
end try
begin catch
    DECLARE @ErrorMessage NVARCHAR(4000);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;
	--rollback
SELECT 
        @ErrorMessage = ERROR_MESSAGE(),
        @ErrorSeverity = ERROR_SEVERITY(),
        @ErrorState = ERROR_STATE();

    RAISERROR (@ErrorMessage, -- Message text.
               16, --@ErrorSeverity, -- Severity.
               16--@ErrorState -- State.
               );
   --     IF @@TRANCOUNT > 0  
	--ROLLBACK TRANSACTION; 
end catch 
go
-- 
/*
declare @IDDebito int
exec dbo.ccfUpdateccfDebitos 'I', @IDDebito, 1, 1, 'D', 'FAC', 1, 'F-00001', '20191101', 30, 500, 30, 'CONCEPTO SISTEMA',
'CONCEPTO USUARIO', 'SA', 33.22, 1
*/
Create Procedure dbo.ccfUpdateccfDebitos @Operation nvarchar(1),  @IDDebito int Output, 
@IDCliente int  ,@IDBodega int  ,@TipoDocumento nvarchar(1) , @IDClase nvarchar(10), 
@IDSubTipo	int , @Documento nvarchar(20) , @Fecha datetime , @Plazo INT ,  @MontoOriginal decimal(28,4) ,
@PorcInteres decimal(8,2),@ConceptoSistema nvarchar(500),@ConceptoUsuario nvarchar(500),
@Usuario nvarchar(20), @TipoCambio decimal(28,4), @IDVendedor int, 	@flgOrigenExterno bit ,
@flgAprobado bit,   @CodigoConsecutivoMask nvarchar(20) = null, @IDMoneda int = null, @Anulado bit = null
-- @Operation = I Nuevo, D Eliminar, F Modifica Fecha Credito
as
set nocount on
declare @Ok bit, @Vencimiento datetime ,@VencimientoVar datetime ,@FechaUltCredito datetime, @SaldoActual  decimal(28,4) 
,  @Cancelado bit
set @Ok = 0
begin transaction 
begin try

if @Anulado is null
	set @Anulado = 0

if upper(@Operation) = 'I'
begin
	SET @Vencimiento = DATEADD(day, @Plazo, @Fecha )
	SET @VencimientoVar = @Vencimiento
	SET @SaldoActual = @MontoOriginal
	
	set @Cancelado = 0
	insert dbo.ccfDebitos ( IDCliente , IDBodega , TipoDocumento, IDClase, IDSubTipo,Documento,Fecha,
	Vencimiento, Plazo,  MontoOriginal, FechaUltCredito, SaldoActual, 
	Cancelado, PorcInteres, Anulado, ConceptoSistema, ConceptoUsuario, Usuario, TipoCambio, IDVendedor, flgOrigenExterno, flgAprobado, IDMoneda
	)
	values (
	@IDCliente ,@IDBodega ,@TipoDocumento, @IDClase, @IDSubTipo,@Documento,@Fecha,@Vencimiento,@Plazo,
	@MontoOriginal,	@FechaUltCredito, @SaldoActual, @Cancelado, @PorcInteres, @Anulado, @ConceptoSistema, @ConceptoUsuario,
	@Usuario, @TipoCambio, @IDVendedor , @flgOrigenExterno, @flgAprobado, @IDMoneda 
	)
	Set @IDDebito = (SELECT SCOPE_IDENTITY())
	
	Update dbo.globalConsecMask set Consecutivo = @Documento where Codigo = @CodigoConsecutivoMask
end
if upper(@Operation) = 'U'
begin
	Update dbo.ccfDebitos  set ConceptoUsuario = @ConceptoUsuario , Documento = @Documento,
	Fecha = @Fecha, MontoOriginal = @MontoOriginal 
	where IDDebito   =  @IDDebito   and flgAprobado = 0 and flgOrigenExterno = 0 and Anulado = 0
end

if upper(@Operation) = 'D'
begin
set @Ok = 1
	if exists( Select IDAplicacion from dbo.ccfAPLICACIONES (Nolock)  where IDDebito =  @IDDebito )
	begin
	RAISERROR ('Ud est· queriendo eliminar un documento que tiene Aplicaciones, primero elimÌnelas', 16, 10);
	set @Ok = 0
	end
	if  @Ok = 1
	Delete from dbo.ccfDebitos where IDDebito  =  @IDDebito and flgAprobado = 0 and flgOrigenExterno = 0 and Anulado = 0
end
commit
SELECT isnull(@IDDebito,0) IDDebito -- por programa devuelve una tabla de 1x1
return isnull(@IDDebito,0) -- sale como parametro por si se quiere referenciar en sql puro
end try
begin catch
    DECLARE @ErrorMessage NVARCHAR(4000);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;
	--rollback
SELECT 
        @ErrorMessage = ERROR_MESSAGE(),
        @ErrorSeverity = ERROR_SEVERITY(),
        @ErrorState = ERROR_STATE();

    RAISERROR (@ErrorMessage, -- Message text.
               16, --@ErrorSeverity, -- Severity.
               16--@ErrorState -- State.
               );
        IF @@TRANCOUNT > 0  
	ROLLBACK TRANSACTION; 
end catch 
go

--  select * from dbo.ccfGetSaldoDocumento ('C', '20200201',11,1)
CREATE FUNCTION dbo.ccfGetSaldoDocumento ( @TipoDocumento nvarChar(1), @Fecha datetime, @IDDocumento int, @IDCliente int  )
RETURNS @Resultado table (IDDocumento int, Fecha datetime, Vencimiento datetime,  IDMoneda int, Simbolo nvarchar(20), MontoOriginal decimal(28,4),
IDCliente int, IDClase nvarchar(10), IDSubtipo int, Documento nvarchar(20), 
TipoCambioDocumento decimal(28,4), Nacional bit, MontoOriginalLocal decimal(28,4),
MontoOriginalDolar decimal(28,4), FechaCorte datetime,TipoCambioCorte decimal (28,4), CreditoLocal decimal(28,4), 
CreditoDolar decimal(28,4), SaldoLocal decimal(28,4),SaldoDolar decimal(28,4))
as
begin
Declare @TipoCambio decimal(28,4), @sTipoCambio nvarchar(20)
set @sTipoCambio = ( SELECT TOP 1 TipoCambioFact  FROM DBO.fafParametros  )
set @TipoCambio = (select  dbo.globalGetLastTipoCambio( @Fecha, @sTipoCambio ))
if @IDCliente is null
	set @IDCliente = 0
if UPPER(@TipoDocumento) = 'D'
BEGIN
	insert @Resultado (IDDocumento, Fecha,Vencimiento, IDMoneda, Simbolo, MontoOriginal, IDCliente, IDClase , IDSubtipo, Documento ,
	 TipoCambioDocumento, Nacional , MontoOriginalLocal , MontoOriginalDolar , FechaCorte ,TipoCambioCorte, CreditoLocal,
	CreditoDolar, SaldoLocal , SaldoDolar )
	SELECT  L.IDDEBITO IDDocumento, L.FECHA, L.Vencimiento , L.IDMonedaDebito , L.Simbolo, L.MONTOORIGINAL , L.IDCliente, L.IDClase, L.IDSubTipo, L.Documento,
	 	L.TipoCambioDebito, L.NacionalDebito,CAST(L.MontoOriginalLocal AS DECIMAL(28,4)) MontoOriginalLocal, 
	 	CAST(L.MontoOriginalDolar AS DECIMAL(28,4)) MontoOriginalDolar,
	@Fecha FechaCorte,@TipoCambio TipoCambioCorte,
	SUM(CAST( ISNULL( R.CreditoLocal,0 ) AS DECIMAL(28,4))) CreditoLocal,SUM(CAST( isnull(R.CreditoDolar,0) AS DECIMAL(28,4))) CreditoDolar ,
	--CAST( L.MontoOriginalLocal-isnull(R.CreditoLocal,0) AS DECIMAL(28,4)) SaldoLocal, 
	
	case when L.NacionalDebito = 1 then 
	CAST( L.MontoOriginalLocal-SUM(isnull(R.CreditoLocal,0)) AS DECIMAL(28,4))
	else
	CAST( (L.MontoOriginalDolar -  SUM( isnull(R.CreditoDolar,0)) ) AS DECIMAL(28,4))* @TipoCambio 
	end

	 SaldoLocal,
	
	case when L.NacionalDebito = 0 then 
	CAST( (L.MontoOriginalDolar -  SUM(isnull(R.CreditoDolar,0) ) ) AS DECIMAL(28,4))
	else 
	CAST( L.MontoOriginalLocal-sum(isnull(R.CreditoLocal,0)) AS DECIMAL(28,4)) / @TipoCambio
	end  SaldoDolar
	
	FROM (
	SELECT D.IDDEBITO, D.FECHA, D.Vencimiento,  D.MONTOORIGINAL , IDCliente, IDClase, IDSubTipo, Documento, 
	TipoCambio TipoCambioDebito, 
	D.IDMoneda IDMonedaDebito, M.Nacional NacionalDebito, M.Simbolo, 
	case when M.Nacional = 1  then D.MONTOORIGINAL else  D.MONTOORIGINAL*D.TipoCambio   end  MontoOriginalLocal,
	case when M.Nacional = 0 then D.MONTOORIGINAL else D.MONTOORIGINAL/d.TipoCambio  end  MontoOriginalDolar
	FROM DBO.CCFDEBITOS (NOLOCK) D inner join dbo.globalMoneda (NOLOCK) M
	on D.IDMONEDA = M.IDMoneda
	WHERE (IDDEBITO = @IDDocumento or @IDDocumento = 0) and (@IDCliente =0 or IDCliente = @IDCliente) 
	and D.Fecha <= @Fecha and D.flgAprobado = 1 ) L 

	LEFT JOIN 
	(
	
	SELECT A.IDDEBITO,  MD.NACIONAL, 
	SUM(CASE WHEN MD.NACIONAL = 1 THEN A.MONTOCREDITO ELSE A.MONTOCREDITO * c.TipoCambio  END) CREDITOLOCAL,
	SUM(CASE WHEN MD.NACIONAL = 1 THEN A.MONTOCREDITO ELSE A.MONTOCREDITO * c.TipoCambio  END) / c.TipoCambio  AS CREDITODOLAR
	FROM DBO.CCFAPLICACIONES (NOLOCK) A INNER JOIN dbo.ccfCreditos (NOLOCK) C
	on A.IDCredito = C.IDCredito 	inner join dbo.globalMoneda (NOLOCK) MC
	on C.IDMoneda = MC.IDMoneda inner join dbo.ccfDebitos (NOLOCK) D
	ON A.IDDEBITO = D.IDDEBITO INNER JOIN DBO.globalMoneda MD
	ON D.IDMONEDA = MD.IDMoneda 
	WHERE (A.IDDEBITO = @IDDocumento or @IDDocumento = 0) and (@IDCliente =0 or D.IDCliente = @IDCliente)
	and A.FechaCredito <=@Fecha and C.flgAprobado = 1 and D.flgAprobado = 1 -- OJO COLEGIAR ESTA DECICION and A.flgFlotante = 0 and C.flgFlotante = 0
	GROUP BY A.IDDEBITO, MD.NACIONAL, C.TipoCambio 
	) R
	ON L.IDDEBITO = R.IDDebito 
	GROUP BY L.IDDEBITO , L.FECHA, L.Vencimiento , L.IDMonedaDebito , L.Simbolo, L.MONTOORIGINAL , L.IDCliente, L.IDClase, L.IDSubTipo, L.Documento,
	 	L.TipoCambioDebito, L.NacionalDebito,L.MontoOriginalLocal , 
	    L.MontoOriginalDolar 
	--@Fecha ,@TipoCambio 
END

if UPPER(@TipoDocumento) = 'C'
BEGIN
	insert @Resultado (IDDocumento, Fecha, Vencimiento, IDMoneda, Simbolo, MontoOriginal, IDCliente, IDClase , IDSubtipo, Documento ,
	 TipoCambioDocumento, Nacional , MontoOriginalLocal , MontoOriginalDolar , FechaCorte ,TipoCambioCorte, CreditoLocal,
	CreditoDolar, SaldoLocal , SaldoDolar )

	SELECT  L.IDCREDITO IDDocumento, L.FECHA,L.Vencimiento, L.IDMonedaCredito , L.Simbolo, CAST(L.MONTOORIGINAL AS DECIMAL(28,4)) MONTOORIGINAL , 
	L.IDCliente, L.IDClase, L.IDSubTipo, L.Documento,
	L.TipoCambioCredito, L.NacionalCredito,  CAST(L.MontoOriginalLocal AS DECIMAL(28,4)) MontoOriginalLocal, 
	CAST(L.MontoOriginalDolar AS DECIMAL(28,4)) MontoOriginalDolar,
	@Fecha FechaCorte,@TipoCambio TipoCambioCorte,
	SUM(CAST(ISNULL( R.CreditoLocal,0 ) AS DECIMAL(28,4))) CreditoLocal, SUM(CAST( isnull(R.CreditoDolar,0) AS DECIMAL(28,4))) CreditoDolar ,
	--CAST(L.MontoOriginalLocal-isnull(R.CreditoLocal,0) AS DECIMAL(28,4)) SaldoLocal, 
	
	case when L.NacionalCredito = 1 then
	CAST(L.MontoOriginalLocal-SUM(isnull(R.CreditoLocal,0)) AS DECIMAL(28,4)) else 
	 CAST((L.MontoOriginalDolar -  SUM(isnull(R.CreditoDolar,0) ) ) AS DECIMAL(28,4))* @TipoCambio
	 end SaldoLocal, 
	 
	 case when L.NacionalCredito = 0 then 
	CAST((L.MontoOriginalDolar -  SUM(isnull(R.CreditoDolar,0) ) ) AS DECIMAL(28,4)) 
	else
	CAST(L.MontoOriginalLocal- SUM(isnull(R.CreditoLocal,0)) AS DECIMAL(28,4))  / @TipoCambio
	end  SaldoDolar
	
	FROM
	(
	SELECT D.IDCREDITO, D.FECHA,'20501231' Vencimiento,  D.MONTOORIGINAL , IDCliente, IDClase, IDSubTipo, Documento, 
	TipoCambio TipoCambioCredito, 
	D.IDMoneda IDMonedaCredito, M.Nacional NacionalCredito, M.Simbolo, 
	case when M.Nacional = 1  then D.MONTOORIGINAL else  D.MONTOORIGINAL*D.TipoCambio   end  MontoOriginalLocal,
	case when M.Nacional = 0 then D.MONTOORIGINAL else D.MONTOORIGINAL/D.TipoCambio  end  MontoOriginalDolar
	FROM DBO.CCFCreditos D inner join dbo.globalMoneda (NOLOCK) M
	on D.IDMONEDA = M.IDMoneda
	WHERE (IDCredito = @IDDocumento or @IDDocumento = 0) and (@IDCliente=0 or IDCliente = @IDCliente)
	and D.Fecha <= @Fecha and D.flgAprobado = 1 --and D.flgFlotante = 0
	) L

	LEFT JOIN 
	(
	SELECT A.IDCredito, MC.NACIONAL, 
	SUM(CASE WHEN MD.NACIONAL = 1 THEN A.MONTOCREDITO ELSE A.MONTOCREDITO * C.TipoCambio  END) CREDITOLOCAL,
	SUM(CASE WHEN MD.NACIONAL = 1 THEN A.MONTOCREDITO ELSE A.MONTOCREDITO * C.TipoCambio  END) / C.TipoCambio  AS CREDITODOLAR
	FROM DBO.CCFAPLICACIONES A INNER JOIN dbo.ccfCreditos (NOLOCK) C
	on A.IDCredito = C.IDCredito 	inner join dbo.globalMoneda (NOLOCK) MC
	on C.IDMoneda = MC.IDMoneda inner join dbo.ccfDebitos (NOLOCK) D
	ON A.IDDEBITO = D.IDDEBITO INNER JOIN DBO.globalMoneda MD
	ON D.IDMONEDA = MD.IDMoneda 
	WHERE (A.IDCredito = @IDDocumento or @IDDocumento = 0) and (@IDCliente=0 or C.IDCliente = @IDCliente)
	and A.FechaCredito <=@Fecha and D.flgAprobado = 1 and C.flgAprobado = 1  --and A.flgFlotante = 0 and C.flgFlotante = 0
	GROUP BY A.IDCREDITO, MC.NACIONAL, C.TipoCambio 
	) R
	ON L.IDCREDITO = R.IDCREDITO
	GROUP BY L.IDCREDITO , L.FECHA,L.Vencimiento, L.IDMonedaCredito , L.Simbolo, CAST(L.MONTOORIGINAL AS DECIMAL(28,4))  , 
	L.IDCliente, L.IDClase, L.IDSubTipo, L.Documento,
	L.TipoCambioCredito, L.NacionalCredito,  L.MontoOriginalLocal  , 
	L.MontoOriginalDolar  
END
return 
END	
go	


CREATE PROCEDURE [dbo].[ccfUpdateAplicaciones]
-- 'I' insertar  'S' Actualizar Saldos de Debitos y Creditos en Aplicaciones
@Operation nvarchar(1), @IDDocDebito int, @IDDocCredito int, @MontoPago decimal(28,4),
@Usuario nvarchar(20), @TipoCambio decimal(28,4) , @flgFlotante bit,
@Efectivo decimal (28,4) = null,
@Descuento decimal (28,4) = null,
@RetencionMunicipal decimal (28,4) = null,
@RetencionRenta decimal (28,4) = null,
@IDChequePos int = null,
@MontoChequePos 	decimal (28,4) = null

as
set nocount on
Declare	@IDAplicacion int , @Fecha datetime, @Vencimiento datetime, @FechaCredito datetime, @MontoDebitoAnt decimal(28,4), 
	@MontoDebitoAct decimal(28,4), @MontoCreditoAnt decimal(28,4),  @MontoCreditoAct decimal(28,4),  
	@MontoCredito decimal(28,4) , @IDDocumentoCC int, @ValorInteres decimal(28,4),
	@IDCliente int  ,@IDBodega int  ,@TipoDocumento nvarchar(1) ,
	@IDSubTipo	int , @Documento nvarchar(20) , 
	@MontoOriginal decimal(28,4) ,@FechaUltCredito datetime , @FechaUltCreditoEnDebito datetime ,
	@SaldoActual  decimal(28,4) ,@Cancelado bit ,@PorcInteres decimal(8,2),@Anulado bit,
	@Hoy datetime, @DiasVencidos int, 
	@SaldoAnteriorDebito decimal(28,4) , @SaldoActualDebito decimal(28,4),
	@SaldoAnteriorCredito decimal(28,4), @SaldoActualCredito decimal(28,4), @SaldoAnterior decimal(28,4),
	@DocDebito nvarchar(20), @DocCredito NVARCHAR(20), @Plazo int

IF @Operation = 'I'
BEGIN

if not exists ( Select IDCredito From dbo.ccfCreditos Where IDCredito = @IDDocCredito )
begin
    RAISERROR ('EL ID DEL CREDITO NO EXISTE', -- Message text.
               16, --@ErrorSeverity, -- Severity.
               16--@ErrorState -- State.
               );
               RETURN
end

Select @Hoy = getdate(), @FechaCredito=Fecha,  @DocCredito = DOCUMENTO, 
	 @Fecha= Fecha, @SaldoActual = isnull(SaldoActual,0), @FechaUltCredito  = isnull(FechaUltCredito ,'19800101' ), @IDChequePos = IDChequePos
From dbo.ccfCreditos (NOLOCK)
where IDCredito = @IDDocCredito AND TIPODOCUMENTO = 'C' --) --(select getdate())
SELECT @DocDebito = Documento, @FechaUltCreditoEnDebito = FechaUltCredito
From dbo.ccfDebitos (NOLOCK)
where IDDebito  = @IDDocDebito AND TIPODOCUMENTO = 'D'

set @MontoCreditoAct = ( Select case when Nacional = 1 then SaldoLocal else SaldoDolar end From dbo.[ccfGetSaldoDocumento] ('C', @Hoy,@IDDocCredito , 0 ) )
set @MontoCredito = @MontoPago
set @SaldoActual = ( select case when Nacional = 1 then SaldoLocal else SaldoDolar end  From dbo.[ccfGetSaldoDocumento] ('D', @Hoy,@IDDocDebito, 0 ) )

if (@SaldoActual <= 0 or @MontoCreditoAct  <= 0 ) 
	return -- saldo actual del debito o el Credito es cero... debe salir y no hacer nada

--if (@MontoPago >= @SaldoActual and @SaldoActual <>0 ) -- se quiere pagar mas que el saldo de una factura
--	set @MontoPago = @SaldoActual
--if @MontoPago > @MontoCreditoAct
--	set @MontoPago = @MontoCreditoAct
	
set @SaldoAnteriorCredito = isnull(@MontoCreditoAct,0)
set @SaldoAnteriorDebito = @SaldoActual
set @SaldoActualDebito = @SaldoActual - @MontoPago
set @SaldoActualCredito = @SaldoAnteriorCredito - @MontoPago	

insert dbo.ccfAplicaciones ( IDDebito,  IDCredito,DocDebito, DocCredito,  Fecha,  FechaCredito , MontoCredito,
flgFlotante , Efectivo , Descuento ,RetencionMunicipal, RetencionRenta, IDChequePos ,MontoChequePos  )	
values (@IDDocDebito, @IDDocCredito,@DocDebito, @DocCredito, @Hoy,   @FechaCredito, @MontoPago, 
@flgFlotante , @Efectivo , @Descuento ,@RetencionMunicipal, @RetencionRenta ,@IDChequePos ,@MontoChequePos 	)	

Update dbo.ccfDebitos set SaldoActual = @SaldoActualDebito,FechaUltCredito = @FechaCredito ,
Cancelado = CASE WHEN @SaldoActualDebito = 0 THEN 1 ELSE 0 END  where IDDebito  = @IDDocDebito 
Update dbo.ccfCreditos  set SaldoActual = @SaldoActualCredito, FechaUltCredito = @FechaCredito ,
Cancelado = CASE WHEN @SaldoActualDebito = 0 THEN 1 ELSE 0 END 
 where IDCredito  = @IDDocCredito
	
END
return 

GO
/*
drop Type TypeAplicaRecibos
Create Type TypeAplicaRecibos as Table ( IDCredito int, IDDebito int, Pago decimal(28,4), Efectivo decimal(28,4), 
Descuento decimal(28,4), Retencion decimal(28,4),  MontoChequePos decimal(28,4), flgFlotante bit  )
go

declare @table as TypeAplicaRecibos
insert @table (IDCredito, IDDebito, Pago )
values (8,15,1.4729)
insert @table (IDCredito, IDDebito, Pago )
values (8,14,100)
exec dbo.ccfAplicaCredito  @table , 'SA', 33.4563
*/


--Create Procedure dbo.ccfAplicaCredito 
--@Pagos as TypeAplicaRecibos readonly , 
--@Usuario nvarchar(20), @TipoCambio decimal(28,4), @flgFlotante bit
--as
--set nocount on            

--declare @i int, @iRwCnt int, @Valor decimal(28,4), @TotalValor decimal(28,4),@IDCredito int, @IDDebito int, @Msg nvarchar(256)
--declare  @Efectivo decimal(28,4), @Descuento decimal(28,4), @Retencion decimal(28,4), @MontoChequePos decimal(28,4),  @IDChequePos int
--declare @tblPagos as table (ID int identity (1,1), IDCredito int, IDDebito int, Pago decimal(28,4), Efectivo decimal(28,4),
--Descuento decimal(28,4), Retencion decimal(28,4),  MontoChequePos decimal(28,4), flgFlotante bit)
--begin transaction 
--begin try

--	if (SELECT COUNT(*) FROM @Pagos ) <= 0
--	begin
--	set @Msg = 'La lista de elementos dÈbitos a cancelar est· vacÌa, por favor seleccione al menos uno.'
--	raiserror(  @Msg , 16,16 );
--	return	
--	end
	
--	if Exists (
--	Select IDDebito 
--	from @Pagos  
--	where IDDebito  in (
--	Select IDDebito
--	From dbo.ccfDebitos  D (NOLOCK)
--	Where  D.Anulado = 1 )
--	) 
--	begin
--	set @Msg = 'Existen dÈbitos seleccionados que no tienen saldos o est·n anulados'
--	raiserror(  @Msg , 16,16 );
--	return	
--	end

--	Insert @tblPagos (IDCredito , IDDebito, Pago, Efectivo, Descuento, Retencion, MontoChequePos, flgFlotante  )
--	Select IDCredito , IDDebito, Pago , Efectivo, Descuento, Retencion, MontoChequePos, flgFlotante 
--	From @Pagos
	
--	if @flgFlotante = 1 
--	begin
--	Select @IDChequePos = IDChequePos From dbo.ccfCreditos Where IDCredito = @IDCredito
--	end	

--	Select @iRwCnt = isnull(count(*),0), @TotalValor = isnull(sum(Pago),0) from @tblPagos 
	
--	set @i = 1
--	While @i <= @iRwCnt
--	begin
--	Select @IDCredito = IDCredito, @IDDebito = IDDebito, @Valor = Pago ,
--	 @Efectivo = Efectivo, @Descuento = Descuento, @Retencion = Retencion, @MontoChequePos = MontoChequePos, @flgFlotante= flgFlotante
--	From @tblPagos where ID = @i
--	exec dbo.ccfUpdateAplicaciones  'I', @IDDebito, @IDCredito, @Valor, @Usuario , @TipoCambio, @flgFlotante,
--	@Efectivo, @Descuento, @Retencion, @IDChequePos, @MontoChequePos
	 	
--	set @i = @i + 1
--	end
	
--commit
--end try
--begin catch
--    DECLARE @ErrorMessage NVARCHAR(4000);
--    DECLARE @ErrorSeverity INT;
--    DECLARE @ErrorState INT;
--	rollback
--SELECT 
--        @ErrorMessage = ERROR_MESSAGE(),
--        @ErrorSeverity = ERROR_SEVERITY(),
--        @ErrorState = ERROR_STATE();

--    RAISERROR (@ErrorMessage, -- Message text.
--               16, --@ErrorSeverity, -- Severity.
--               16--@ErrorState -- State.
--               );
--end catch               
--go

-- select * from dbo.ccfGetDocumentosxCobrar(1, getdate(), 0)
/*Esta funcion devuelve los docuemntos que el cliente debe y tiene que pagar*/
Create   FUNCTION dbo.ccfGetDocumentosxCobrar ( @IDCliente int, @FechaCorte datetime, @IDDebito int) 
RETURNS TABLE
RETURN
SELECT IDDOCUMENTO IDDEBITO, IDCLASE,IDSUBTIPO, IDMoneda, Simbolo, Nacional, Documento,  Fecha, Vencimiento, 
(select datediff(day, Vencimiento,@FechaCorte )) DiasVencidos,
MontoOriginalLocal TotalDebitoLocal, MontoOriginalDolar TotalDebitoDolar,  IDCliente, TipoCambioCorte , 
SaldoLocal , SaldoDolar
FROM  dbo.ccfGetSaldoDocumento('D', @FechaCorte, @IDDebito, @IDCliente ) D 
Where (D.IDCliente = @IDCliente or @IDCliente = 0) and SaldoLocal <> 0 and saldodolar <> 0
go
-- exec dbo.ccfrptAntiguedadSaldosPorCliente 0, 0, '20200117',  1
Create  Procedure dbo.ccfrptAntiguedadSaldosPorCliente @IDBodega  int, @IDCliente  Int, @FechaCorte DATETIME, 
 @EnDolar bit = null
as
declare @TipoCambio as decimal(18,4), @IDTipoCambioFactura nvarchar(20)
declare  @Resultados as table (  IDDebito int, IDClase nvarchar(10), IDSubtipo int, Fecha datetime, Vencimiento datetime,
DiasVencidos int, TotalDebito decimal(28,4), IDCredito int, IDCliente  nvarchar(20), Nombre nvarchar(255),
IDBodega int, Bodega nvarchar(255),  Saldo decimal(28,4) 
)

declare  @ResultadoDetallado as table ( IDBodega int, Bodega nvarchar(255),
IDCliente  nvarchar(20), Nombre nvarchar(255),
SaldoNovencido decimal(28,4) default 0,  
Saldoa30 decimal(28,4) default 0,
Saldo31a60 decimal(28,4) default 0,
Saldo61a90 decimal(28,4) default 0,
Saldo91a120 decimal(28,4) default 0,
Saldo121a180 decimal(28,4) default 0,
Saldo181a600 decimal(28,4) default 0,
Saldomas600 decimal(28,4) default 0, 
TotalCliente decimal(28,4) default 0 
)

set nocount on 
set @IDTipoCambioFactura = (Select top 1 IDTipoCambio  from dbo.globaltipocambio )
if @EnDolar is null
	set @EnDolar = 0

if @EnDolar = 1
	select @TipoCambio=( SELECT dbo.[globalGetLastTipoCambio] (@FechaCorte, @IDTipoCambioFactura))	
else
	set @TipoCambio = 0

	
Insert @Resultados (IDDebito , IDClase , IDSubtipo , Fecha , Vencimiento, DiasVencidos, 
TotalDebito, IDCliente, Nombre, IDBodega, Bodega, Saldo )
SELECT D.IDDebito , D.IDClase , D.IDSubtipo , D.Fecha , D.Vencimiento, D.DiasVencidos, 
case when @EnDolar = 1 then TotalDebitoLocal else TotalDebitoDolar end TotalDebito,
 D.IDCliente,C.Nombre, C.IDBodega, B.Descr Bodega, case when @EnDolar = 0 then  SaldoLocal    else SaldoDolar end Saldo
FROM  dbo.ccfGetDocumentosxCobrar(@IDCliente, @FechaCorte, 0) D INNER JOIN dbo.ccfclientes C
ON D.IDCLIENTE = C.IDCliente inner join dbo.invBodega B
on C.IDBodega = B.IDBodega

--if @EnDolar = 1
--	Update @Resultados set Saldo = case when @TipoCambio > 0 then  Saldo / @TipoCambio  else Saldo end

	insert @ResultadoDetallado ( IDBodega , Bodega, IDCliente ,NOMBRE,SaldoNovencido,
	Saldoa30,Saldo31a60,Saldo61a90,
	Saldo91a120,Saldo121a180,Saldo181a600,Saldomas600, TotalCliente)
	SELECT IDBodega , Bodega, IDCliente ,NOMBRE, SUM(ISNULL(SaldoNovencido,0)) SaldoNovencido,
	SUM(ISNULL(Saldoa30,0)) Saldoa30,
	SUM(ISNULL(Saldo31a60,0)) Saldo31a60,
	SUM(ISNULL(Saldo61a90,0)) Saldo61a90,  
	SUM(ISNULL(Saldo91a120,0)) Saldo91a120,  
	SUM(ISNULL(Saldo121a180,0)) Saldo121a180,
	SUM(ISNULL(Saldo181a600,0)) Saldo181a600,
	SUM(ISNULL(Saldomas600,0)) Saldomas600,
	SUM(ISNULL(SaldoNovencido,0)+ ISNULL(Saldoa30,0)+ ISNULL(Saldo31a60,0)+ ISNULL(Saldo61a90,0)+
	ISNULL(Saldo91a120,0)+ISNULL(Saldo121a180,0)+ISNULL(Saldo181a600,0)+ISNULL(Saldomas600,0)) TotalCliente
	FROM (
	SELECT IDBodega , Bodega, IDCliente ,NOMBRE, RANGO, case when rango = 'NO-VENC' then SUM(Saldo) ELSE 0 end SaldoNovencido,
	case when rango = '1-30' then SUM(Saldo) ELSE 0 end Saldoa30,
	case when rango = '31-60' then SUM(Saldo) ELSE 0 end Saldo31a60,
	case when rango = '61-90' then SUM(Saldo) ELSE 0 end Saldo61a90,
	case when rango = '91-120' then SUM(Saldo) ELSE 0 end Saldo91a120,
	case when rango = '121-180' then SUM(Saldo) ELSE 0 end Saldo121a180,
	case when rango = '181-600' then SUM(Saldo) ELSE 0 end Saldo181a600,
	case when rango = '+600' then SUM(Saldo) ELSE 0 end Saldomas600    
	FROM 
	(
	SELECT a.IDBodega , a.Bodega,  a.IDCliente , a.Nombre Nombre, a.DiasVencidos,  
	CASE WHEN a.DiasVencidos BETWEEN 1 AND 30 THEN '1-30' ELSE
	CASE WHEN a.DiasVencidos BETWEEN 31 AND 60 THEN '31-60' ELSE
	CASE WHEN a.DiasVencidos BETWEEN 61 AND 90 THEN '61-90' ELSE
	CASE WHEN a.DiasVencidos BETWEEN 91 AND 120 THEN '91-120' ELSE
	CASE WHEN a.DiasVencidos BETWEEN 121 AND 180 THEN '121-180' ELSE
	CASE WHEN a.DiasVencidos BETWEEN 181 AND 600 THEN '181-600' ELSE
	CASE WHEN a.DiasVencidos > 600 THEN '+600' ELSE
	CASE WHEN ( a.DiasVencidos <=0 ) THEN 'NO-VENC' ELSE 'ND' END
	END	
	END
	END
	END
	END	
	END
	END RANGO,
	
	a.Saldo   Saldo--, a.Intereses Interes, a.TotalaPagar Total 
	FROM @Resultados a 


	) T1
	GROUP BY IDBodega ,Bodega, IDCliente , NOMBRE, RANGO
	) T2
	GROUP BY IDBodega , Bodega, IDCliente , NOMBRE
	HAVING SUM(ISNULL(SaldoNovencido,0)+ ISNULL(Saldoa30,0)+ ISNULL(Saldo31a60,0)+ ISNULL(Saldo61a90,0)+
	ISNULL(Saldo91a120,0)+ISNULL(Saldo121a180,0)+ISNULL(Saldo181a600,0)+ISNULL(Saldomas600,0)) > 0
	

	Select IDBodega , Bodega, IDCliente ,NOMBRE, SaldoNovencido, Saldoa30, Saldo31a60, Saldo61a90, Saldo91a120, Saldo121a180, Saldo181a600,
	Saldomas600, TotalCliente
	From @ResultadoDetallado

go

Create Procedure dbo.ccfrptAntiguedadSaldosPorSucursal @IDBodega  int, @IDCliente  Int, @FechaCorte DATETIME, 
 @EnDolar bit = null
as
declare  @ResultadoDetallado as table ( IDBodega int, Bodega nvarchar(255),
IDCliente  nvarchar(20), Nombre nvarchar(255),
SaldoNovencido decimal(28,4) default 0,  
Saldoa30 decimal(28,4) default 0,
Saldo31a60 decimal(28,4) default 0,
Saldo61a90 decimal(28,4) default 0,
Saldo91a120 decimal(28,4) default 0,
Saldo121a180 decimal(28,4) default 0,
Saldo181a600 decimal(28,4) default 0,
Saldomas600 decimal(28,4) default 0, 
TotalCliente decimal(28,4) default 0 
)

Insert @ResultadoDetallado (IDBodega, Bodega, IDCliente, Nombre, SaldoNovencido, Saldoa30, Saldo31a60,
Saldo61a90, Saldo91a120, Saldo121a180, Saldo181a600, Saldomas600, TotalCliente)
exec dbo.ccfrptAntiguedadSaldosPorCliente @IDBodega, @IDCliente, @FechaCorte, @EnDolar

Select IDBodega , Bodega, sum( SaldoNovencido) SaldoNovencido, sum(Saldoa30) Saldoa30, sum(Saldo31a60) Saldo31a60, 
sum(Saldo61a90) Saldo61a90, sum(Saldo91a120) Saldo91a120, sum(Saldo121a180) Saldo121a180, sum(Saldo181a600) Saldo181a600 ,
sum(Saldomas600) Saldomas600, sum(TotalCliente) TotalCliente
From @ResultadoDetallado
Group by IDBodega, Bodega
go

CREATE VIEW DBO.vccfMovimientos
as 
SELECT IDDOCUMENTO, IDCLIENTE, IDBODEGA, IDVENDEDOR,TIPODOCUMENTO, IDCLASE,IDSubTipo, DOCUMENTO, FECHA, VENCIMIENTO, PLAZO, MONTOORIGINAL,
SALDOACTUAL, CANCELADO, PORCINTERES, ANULADO, CONCEPTOSISTEMA, CONCEPTOUSUARIO, TIPOCAMBIO, V.ORDEN, Asiento, flgAprobado , flgOrigenExterno, Contabilizado, IDMoneda,DescrMoneda, Nacional
FROM (
select IDDEBITO IDDOCUMENTO, IDCLIENTE, IDBODEGA, IDVENDEDOR, TIPODOCUMENTO, IDCLASE, IDSubTipo, DOCUMENTO, FECHA, VENCIMIENTO, PLAZO, MONTOORIGINAL,
SALDOACTUAL, CANCELADO, PORCINTERES, ANULADO, CONCEPTOSISTEMA, CONCEPTOUSUARIO, TIPOCAMBIO, Asiento, flgAprobado, flgOrigenExterno, Contabilizado, D.IDMoneda,
M.Moneda DescrMoneda, M.Nacional, 0 orden
from dbo.ccfdebitos (NoLock) D inner join dbo.globalMoneda (NoLock) M
on D.IDMoneda = M.IDMoneda 
UNION ALL
select IDCREDITO IDDOCUMENTO, IDCLIENTE, IDBODEGA, IDVENDEDOR, Cr.TIPODOCUMENTO, Cr.IDCLASE, IDSubTipo, DOCUMENTO, FECHA, '20700101' VENCIMIENTO, 0 PLAZO, MONTOORIGINAL,
SALDOACTUAL, CANCELADO,0 PORCINTERES, ANULADO, CONCEPTOSISTEMA, CONCEPTOUSUARIO, TIPOCAMBIO, Asiento, flgAprobado, flgOrigenExterno, Contabilizado, Cr.IDMoneda,
M.Moneda DescrMoneda, M.Nacional, C.Orden 
from dbo.ccfCreditos (NoLock)  Cr INNER JOIN DBO.CCFCLASEDOCUMENTO (NoLock) C
ON Cr.IDCLASE = C.IDCLASE  inner join dbo.globalMoneda (NoLock) M
on Cr.IDMoneda = M.IDMoneda 
) v
GO
--  select * from DBO.CCFCLASEDOCUMENTO
--exec dbo.ccfrptMovimientos 1,1, '20200101', '20200320' Select * from dbo.globalMoneda
Create Procedure dbo.ccfrptMovimientos @IDBodega  nvarchar(20), @IDCliente  Int, @FECHAINICIAL DATETIME, @FECHAFINAL DATETIME
as
set nocount on 
Declare @Resultado as table (IDClase nvarchar(10), Documento nvarchar(20), Fecha datetime, 
	Vencimiento datetime, TipoCambio decimal (28,4),Nacional bit, IDMoneda int, DescrMoneda nvarchar(20), MontoLocal Decimal(28,4), MontoDolar Decimal(28,4),
	Orden int, ConceptoSistema nvarchar(500), ConceptoUsuario nvarchar(500))
declare @SaldoInicialLocal decimal(28,4),@SaldoInicialDolar decimal(28,4), @TotalMovimientosLocal decimal(28,4), @TotalMovimientosDolar decimal(28,4)
declare @SaldoInicialDebitoLocal decimal(28,4), @SaldoInicialDebitoDolar decimal(28,4)
declare @SaldoInicialCreditoLocal decimal(28,4), @SaldoInicialCreditoDolar decimal(28,4)
declare @TipoCambio as decimal(18,4), @IDTipoCambioFactura nvarchar(20), @TipoCambioFinal as decimal(18,4),@Fecha DATETIME
set @IDTipoCambioFactura = (Select top 1 IDTipoCambio  from dbo.globaltipocambio )
select @TipoCambio=( SELECT dbo.[globalGetLastTipoCambio] (DATEadd(DAY ,-1, @FECHAINICIAL), @IDTipoCambioFactura))
set @TipoCambioFinal = ( SELECT dbo.[globalGetLastTipoCambio] ( @FECHAFINAL, @IDTipoCambioFactura))

set @Fecha = dateadd(day, -1, @FECHAINICIAL)
Select @SaldoInicialDebitoLocal = isnull(SUM(SALDOLOCAL),0), @SaldoInicialDebitoDolar =  isnull(SUM(SALDODOLAR),0)
FROM  dbo.[ccfGetSaldoDocumento]('D', @Fecha, 0, @IDCliente ) D
wHERE IDCLIENTE = @IDCliente
GROUP BY IDCLIENTE 

Select @SaldoInicialCreditoLocal = isnull(SUM(SALDOLOCAL),0) , @SaldoInicialCreditoDolar = ISNULL( SUM(SALDODOLAR) ,0)
FROM  dbo.[ccfGetSaldoDocumento]('C', @Fecha, 0, @IDCliente) D
wHERE IDCLIENTE = @IDCliente
GROUP BY IDCLIENTE 

Set @SaldoInicialLocal = isnull(@SaldoInicialDebitoLocal,0) - isnull(@SaldoInicialCreditoLocal,0)

Set @SaldoInicialDolar = isnull(@SaldoInicialDebitoDolar,0)  - isnull(@SaldoInicialCreditoDolar,0)

insert @Resultado(IDClase, Documento, Fecha, Vencimiento, Nacional,  TipoCambio, MontoLocal,MontoDolar , 
Orden, ConceptoSistema, ConceptoUsuario, DescrMoneda  )
select D.IDCLASE,  D.DOCUMENTO, D.FECHA, D.VENCIMIENTO, D.Nacional,D.TipoCambio, 
CASE WHEN Nacional = 1 THEN D.MONTOORIGINAL ELSE D.MONTOORIGINAL * D.TipoCambio END * (case when TipoDocumento= 'C' then -1 else 1 end) MONTOLOCAL,
(CASE WHEN Nacional = 1 THEN D.MONTOORIGINAL ELSE D.MONTOORIGINAL * D.TipoCambio END / D.TipoCambio ) * (case when TipoDocumento= 'C' then -1 else 1 end) MONTODOLAR,
 D.ORDEN , D.ConceptoSistema, D.ConceptoUsuario, D.DescrMoneda 
--into #Resultado select * from DBO.vccfMovimientos
from DBO.vccfMovimientos D 
WHERE D.ANULADO = 0 and IDCliente  = @IDCliente  AND D.FECHA BETWEEN @FECHAINICIAL AND @FECHAFINAL
ORDER BY D.FECHA,D.ORDEN

select @TotalMovimientosLocal = isnull(sum(Montolocal),0) , @TotalMovimientosDolar = isnull(sum(MontoDolar),0)
from @Resultado

Select IDClase, Documento, DescrClase, Fecha, Vencimiento, Monto,MontoDolar, ConceptoSistema , ConceptoUsuario, DescrMoneda Moneda, TipoCambio 
from 
(
Select 'SALDO' IDClase,'INICIAL' Documento, '' DescrClase,  dateadd(day, -1, @FECHAINICIAL ) Fecha,  '20500101' Vencimiento, ISNULL(@SaldoInicialLocal,0) Monto,  ISNULL(@SaldoInicialDolar,0) MONTODOLAR,
'SALDO ANTERIOR ' ConceptoSistema, '' ConceptoUsuario, -1 Orden, '' DescrMoneda, 0 TipoCambio
Union all 
	Select R.IDClase, R.Documento, C.Descr DescrClase, R.Fecha, R.Vencimiento, 
	R.MontoLocal,
	R.MontoDolar,
	--CASE WHEN Nacional = 1 THEN R.Monto ELSE R.Monto * R.TipoCambio END Monto, 
	--CASE WHEN Nacional = 1 THEN R.Monto ELSE R.Monto * R.TipoCambio END/R.TipoCambio MONTODOLAR, 
	isnull(R.ConceptoSistema,'') ConceptoSistema, isnull(R.ConceptoUsuario, '') ConceptoUsuario, r.Orden, R.DescrMoneda, R.TipoCambio
	from @Resultado R inner join dbo.ccfClaseDocumento C
	on R.IDClase = C.IDClase
Union all
Select 'SALDO' iDClase,'FINAL' Documento, '' DescrClase, dateadd(hour, 6, @FECHAFINAL) Fecha, '20500101'  Vencimiento, CAST ( ISNULL((@SaldoInicialLocal + @TotalMovimientosLocal ),0) as decimal(28,4)) Monto, @TotalMovimientosDolar  MONTODOLAR,
'SALDO FINAL al ' + CONVERT(NVARCHAR(30), @FECHAFINAL  , 103) ConceptoSistema, '' ConceptoUsuario, 1000 orden, '' DescrMoneda, 0 TipoCambio
) X
order by X.Fecha, x.Orden 

go

--exec dbo.ccfDocumentosxCobrar 0, '20200309', 0 select * FROM DBO.ccfGetDocumentosxCobrar( 1, '20200127', 1)
create Procedure dbo.ccfDocumentosxCobrar  @IDCliente  Int, @FECHACORTE DATETIME, @IDDebito int 
as
SET NOCOUNT ON 
declare @TipoCambio as decimal(18,4), @IDTipoCambioFactura nvarchar(20)
set @IDTipoCambioFactura = (Select top 1 IDTipoCambio  from dbo.globaltipocambio )
select @TipoCambio=( SELECT dbo.[globalGetLastTipoCambio] (@FechaCorte, @IDTipoCambioFactura))

Declare @Resultado as table (IDDebito int, IDClase nvarchar(10), IDSubTipo int, Simbolo nvarchar(10), Documento nvarchar(20),
Fecha datetime, Vencimiento datetime, DiasVencidos int, Saldo decimal (28, 4), 
SaldoDolar decimal (28, 4) )
Declare @SaldoVencidoLocal decimal (28, 4), @SaldoVencidoDolar decimal (28, 4),
@SaldoNoVencidoLocal decimal (28, 4), @SaldoNoVencidoDolar decimal (28, 4) 
Declare @SaldoCreditoLocal decimal (28, 4), @SaldoCreditoDolar decimal (28, 4)

select @SaldoCreditoLocal = SaldoLocal, @SaldoCreditoDolar = SaldoDolar
FROM dbo.ccfGetSaldoDocumento('C', @FECHACORTE, 0,@IDCliente ) D


insert @Resultado(IDDEBITO, IDCLASE, IDSUBTIPO, Simbolo, DOCUMENTO, Fecha, Vencimiento, DIASVENCIDOS, 
 SALDO, SaldoDolar)
SELECT IDDEBITO, IDCLASE, IDSUBTIPO, Simbolo,  DOCUMENTO, Fecha, Vencimiento, DIASVENCIDOS, 
SaldoLocal SALDO, SaldoDolar
FROM DBO.ccfGetDocumentosxCobrar( @IDCliente, @FECHACORTE, @IDDebito ) A
ORDER BY VENCIMIENTO ASC

SELECT @SaldoNoVencidoLocal = ISNULL(SUM(CASE WHEN DiasVencidos <= 0 THEN SALDO END ),0),
@SaldoNoVencidoDolar = ISNULL(SUM(CASE WHEN DiasVencidos <= 0 THEN SaldoDolar END ),0),
@SaldoVencidoDolar = ISNULL(SUM(CASE WHEN DiasVencidos >0 THEN SaldoDolar  END ),0),
@SaldoVencidoLOCAL = ISNULL(SUM(CASE WHEN DiasVencidos > 0 THEN SALDO END ),0)
FROM @Resultado

SELECT IDDEBITO, IDCLASE, IDSUBTIPO, DOCUMENTO, Simbolo, Fecha, Vencimiento, DIASVENCIDOS, 
SALDO, SaldoDolar, 
@SaldoNoVencidoLocal SaldoNoVencidoLocal, @SaldoNoVencidoDolar SaldoNoVencidoDolar,
@SaldoVencidoLOCAL SaldoVencidoLOCAL, @SaldoVencidoDOLAR SaldoVencidoDOLAR, @TipoCambio TipoCambioCorte,
isnull(@SaldoCreditoLocal,0) SaldoCreditoAFavorLocal, isnull(@SaldoCreditoDolar,0) SaldoCreditoAFavorDolar
FROM @Resultado 
ORDER BY VENCIMIENTO ASC
GO 

-- exec dbo.ccfPagarDocumentosxCobrar 0,'20200120', 0

Create PROCEDURE dbo.ccfPagarDocumentosxCobrar @IDCliente  Int, @FECHACORTE DATETIME, @IDDebito int 
as 

set nocount on
SELECT IDDebito, IDClase, IDSubTipo, Documento, Fecha, A.IDMoneda, M.Descr DescrMoneda,  Vencimiento, DiasVencidos,
case when A.Nacional = 1 then SaldoLocal else SaldoDolar end Saldo, 
 0.00 Abono
FROM DBO.ccfGetDocumentosxCobrar( @IDCliente, @FECHACORTE, @IDDebito ) A inner join
dbo.globalMoneda M on A.IDMoneda = M.IDMoneda 
order by Vencimiento 

go

-- exec dbo.ccfrptDesglosePagos 1, 1,1, '20200201', '20200228' 
create PROCEDURE dbo.ccfrptDesglosePagos @IDCliente  Int, @IDBodega  int, @IDVendedor  Int,  @FECHAINICIAL DATETIME, @FECHAFINAL DATETIME
as
set nocount on 

Declare @Resultado table (IDBodega int, IDCliente int, IDVendedor int, IDClaseCredito nvarchar(10),
IDCredito int,Fecha datetime, FechaCredito datetime,NacionalCredito bit, MonedaCredito nvarchar(20),
NacionalDebito bit, MonedaDebito nvarchar(20),IDDebito int, IDClase nvarchar(10),
IDSubTipo int, DocCredito nvarchar(20), DocDebito nvarchar(20), FechaDebito datetime, Vencimiento datetime,
DiasVencidos int, Aplicado decimal(28,4), AplicadoDolar decimal(28,4) )

INSERT  @Resultado (IDBodega , IDCliente , IDVendedor , IDClaseCredito , IDCredito, Fecha,
FechaCredito , NacionalCredito , MonedaCredito , NacionalDebito , MonedaDebito ,
IDDebito , IDClase , IDSubTipo , DocCredito , DocDebito , FechaDebito, Vencimiento ,
DiasVencidos , Aplicado , AplicadoDolar )
SELECT C.IDBodega,  C.IDCliente, C.IDVendedor , C.IDClase IDClaseCredito,  A.IDCredito, A.Fecha, A.FechaCredito,
MC.NACIONAL NACIONALCREDITO, MC.Moneda MonedaCredito,  MD.NACIONAL NACIONALDEBITO, MD.Moneda MonedaDebito,
  A.IDDebito, D.IDClase, D.IDSubTipo,  
DocCredito, DocDebito, D.Fecha FechaDebito, d.Vencimiento ,  DATEDIFF( day , d.Vencimiento , a.FechaCredito ) DiasVencidos, 
	CASE WHEN MD.NACIONAL = 1 THEN A.MONTOCREDITO ELSE A.MONTOCREDITO * C.TipoCambio END APLICADO,
	CASE WHEN MD.NACIONAL = 1 THEN A.MONTOCREDITO ELSE A.MONTOCREDITO * C.TipoCambio END / C.TipoCambio AS APLICADODOLAR
	FROM DBO.CCFAPLICACIONES A INNER JOIN dbo.ccfCreditos (NOLOCK) C
	on A.IDCredito = C.IDCredito 	inner join dbo.globalMoneda (NOLOCK) MC
	on C.IDMoneda = MC.IDMoneda inner join dbo.ccfDebitos (NOLOCK) D
	ON A.IDDEBITO = D.IDDEBITO INNER JOIN DBO.globalMoneda MD
	ON D.IDMONEDA = MD.IDMoneda 
WHERE (C.IDCliente =  @IDCliente OR @IDCliente = 0) AND (C.IDBodega = @IDBodega OR @IDBodega = 0) AND (C.IDVendedor  = @IDVendedor  OR @IDVendedor = 0) AND
A.FechaCredito BETWEEN @FECHAINICIAL AND @FECHAFINAL
order by D.Vencimiento desc

SELECT R.IDBODEGA, R.IDCLIENTE, R.IDVENDEDOR, IDClaseCredito, R.IDCredito, R.Fecha, FechaCredito,  TotalCredito,
NACIONALCREDITO, MonedaCredito , NACIONALDEBITO, MonedaDebito , IDDEBITO, IDClase, IDSUBTIPO, DOCCREDITO, DOCDEBITO, FechaDebito, VENCIMIENTO, DiasVencidos ,
APLICADO, APLICADODOLAR
FROM @Resultado R inner join 
	(Select IDCredito, SUM(case when NACIONALCREDITO = 1 then APLICADO else APLICADODOLAR end ) TotalCredito From @Resultado Group by IDCredito ) T
on R.IDCredito = T.IDCredito 
ORDER BY Fecha, Vencimiento

GO


-- exec dbo.ccfGetDocumento 'd', 1
Create procedure dbo.ccfGetDocumento @Tipo nvarchar(1), @IDDocumento int 
as
set nocount on 
if upper(@Tipo) = 'D'
begin
	Select IDDebito, D.IDCliente ,  C.Nombre, D.IDBodega , B.Descr DescrBodega,  D.IDVendedor , 
	V.Nombre NombreVendedor, D.TipoDocumento, D.IDClase , L.Descr  DescrClase,  D.IDSubTipo 
	,D.IDMoneda, M.Descr DescrMoneda,
	Documento, Fecha, Vencimiento, D.Plazo, MontoOriginal, SaldoActual, Cancelado, Anulado, ConceptoSistema, 
	ConceptoUsuario, Contabilizado, Asiento, flgAprobado, flgOrigenExterno, Usuario
	from dbo.ccfDebitos D inner join dbo.ccfClientes C
	on D.IDCliente = C.IDCliente 
	inner join dbo.fafVendedor V
	on D.IDVendedor = V.IDVendedor inner join dbo.invBodega B
	on D.IDBodega = B.IDBodega inner join dbo.ccfPlazo P
	on D.Plazo = P.Plazo inner join dbo.globalMoneda M
	on D.IDMoneda = M.IDMoneda inner join dbo.ccfClaseDocumento L
	on D.IDClase = L.IDClase 
	Where IDDebito =@IDDocumento 
end
if upper(@Tipo) = 'C'
begin
	Select IDCredito, D.IDCliente, C.Nombre , D.IDBodega, B.Descr DescrBodega, D.IDVendedor, 
	V.Nombre NombreVendedor, D.TipoDocumento, D.IDClase, L.Descr  DescrClase, IDSubTipo , 
	D.IDMoneda,  M.Descr DescrMoneda,
	Documento, Fecha, MontoOriginal, SaldoActual, Anulado, ConceptoSistema, ConceptoUsuario, RecibimosDe,
	Contabilizado, Asiento, Usuario, flgAprobado, flgOrigenExterno , Usuario, C.Plazo 
	From dbo.ccfCreditos D inner join dbo.ccfClientes C
	on D.IDCliente = C.IDCliente 
	inner join dbo.fafVendedor V
	on D.IDVendedor = V.IDVendedor inner join dbo.invBodega B
	on D.IDBodega = B.IDBodega inner join dbo.globalMoneda M
	on D.IDMoneda = M.IDMoneda inner join dbo.ccfClaseDocumento L
	on D.IDClase = L.IDClase 
	where IDCredito = @IDDocumento 
end
go
-- exec dbo.ccfgetSubTipo 1
Create procedure dbo.ccfgetSubTipo (@IDSubTipo int )
as
set nocount on 

SELECT IDSubTipo, TipoDocumento, Descr, IDClase, EsRecuperacion, SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito,
AplicaDocumentos, ContraCtaEnSubTipo, CodigoConsecMask, flgProtegidoSys
FROM DBO.ccfSubTipoDocumento 
Where IDSubTipo = @IDSubTipo
go


Create FUNCTION dbo.ccfGetSaldoDocumentos (  @Fecha datetime)
RETURNS table 
RETURN 
	-- saldo de un Credito
	SELECT IDCliente, IDClase, IDSubTipo, IDDocumento, IDMoneda, Documento, Nacional, FechaCorte, 
	TipoCambioCorte, MontoOriginalLocal,MontoOriginalDolar,  
	CreditoLocal, CreditoDolar, SaldoLocal, SaldoDolar
	FROM dbo.ccfGetSaldoDocumento('D', @Fecha, 0,0 ) D

	UNION ALL
	-- saldo de un Debito
	SELECT IDCliente, IDClase, IDSubTipo, IDDocumento, IDMoneda, Documento, Nacional, FechaCorte, 
	TipoCambioCorte, MontoOriginalLocal,MontoOriginalDolar,  
	CreditoLocal, CreditoDolar, SaldoLocal, SaldoDolar
	FROM dbo.ccfGetSaldoDocumento('C', @Fecha, 0,0 ) D

go


-- drop procedure dbo.ccfGetMovimientos  exec dbo.ccfGetMovimientos 0,0,'20201008','20201213','*','*',0,-1,-1,-1,-1
Create procedure dbo.ccfGetMovimientos  @IDCliente int, @IDVendedor int, @FechaInic datetime, @FechaFin datetime, @Documento nvarchar(20),
@IDClase nvarchar(10), @IDSubTipo int, @flgAprobado int,  @Anulado int, @flgSaldoMayorCero int = -1,  @Contabilizado int
as
set nocount on 
Select M.IDDOCUMENTO IDDocumento, M.TipoDocumento , M.IDCliente, C.Nombre, M.IDClase, M.IDSubTipo, S.Descr SubTipo, M.Documento, M.Fecha, m.Vencimiento, M.MontoOriginal,
case when m.TipoDocumento = 'D' then case when D.Nacional = 1 then  isnull(D.SaldoLocal,0) else isnull(D.SaldoDolar,0) end else 0 end  SaldoDebito, 
case when m.TipoDocumento = 'C' then  case when Cr.Nacional = 1 then  isnull(Cr.SaldoLocal,0) else isnull( Cr.SaldoDolar,0)  end else 0 end SaldoCredito, 
M.Anulado, M.ConceptoSistema, M.ConceptoUsuario, M.TipoCambio, M.Asiento, M.IDVendedor, M.flgAprobado Aprobado, 
M.flgOrigenExterno OrigenExterno, M.IDMoneda, N.Descr DescrMoneda
From DBO.vccfMovimientos M inner join dbo.ccfSubTipoDocumento S
on M.IDSubTipo = S.IDSubTipo and M.IDClase = S.IDClase 
inner join dbo.ccfClientes C 
on M.IDCliente = C.IDCliente inner join dbo.globalMoneda N
on M.IDMoneda = N.IDMoneda 
outer apply dbo.ccfGetSaldoDocumento ('D', GETDATE(), M.IDDOCUMENTO, M.IDCliente ) D
outer apply dbo.ccfGetSaldoDocumento ('C', GETDATE(), M.IDDOCUMENTO, M.IDCliente ) Cr
Where (M.IDCliente = @IDCliente or @IDCliente = 0 )  
and (M.IDVendedor  = @IDVendedor or @IDVendedor = 0 )
and M.Fecha between (case when @FechaInic IS NULL then '19800101' else @FechaInic end )
and (case when @FechaFin IS NULL then '20600101' else @FechaFin end )
and (M.IDClase=@IDClase or (@IDClase = '*' ))
and (M.Documento=@Documento or (@Documento = '*' ))
and (M.IDSubTipo =@IDSubTipo  or (@IDSubTipo = 0))
and (@flgAprobado = -1 or  M.flgAprobado = @flgAprobado )
and (@Anulado = -1 or M.Anulado = @Anulado )
and ((@flgSaldoMayorCero = 1 and M.SaldoActual >0 ) or (@flgSaldoMayorCero = 0 and M.SaldoActual <=0) or (@flgSaldoMayorCero = -1))
and (M.Contabilizado   = @Contabilizado  or @Contabilizado = -1)
Order by M.IDClase, m.DOCUMENTO
go

-- exec dbo.ccfgetAplicacion 36
Create Procedure dbo.ccfgetAplicacion @IDCredito int 
as
set nocount on 
Select A.IDAplicacion,  A.IDDebito IDDocumento, D.Vencimiento , D.IDClase ClaseDebito ,  'D' TipoDocumento, DocDebito, A.Fecha, 
A.IDCredito , C.IDClase ClaseCredito , M.IDMoneda, M.Descr DescrMoneda,  DocCredito, FechaCredito, MontoCredito, D.SaldoActual SaldoDebito  
From dbo.ccfAplicaciones A inner join dbo.ccfDebitos D
on A.IDDebito = D.IDDebito inner join dbo.ccfCreditos C
on A.IDCredito = C.IDCredito inner join
dbo.globalMoneda M on D.IDMoneda = M.IDMoneda 
where A.IDCredito = @IDCredito 
order by D.Vencimiento, D.Documento 
go
-- exec dbo.ccfDesAplicar 1, 0
-- Select * from dbo.ccfAplicaciones
Create Procedure dbo.ccfDesAplicar @IDCredito int, @IDAplicacion int
-- Desaplica un documento si el IDAplicacion es diferente de cero,
-- Toda la Aplicacion si @IDCredito es diferente de cero
as 
set nocount on 
begin transaction 
begin try
if @IDAplicacion <> 0 and @IDCredito = 0
begin
	Update D set SaldoActual = (D.SaldoActual + A.MontoCredito ), Cancelado =  CASE WHEN (D.SaldoActual + A.MontoCredito )= D.MontoOriginal THEN 1 ELSE 0 END,
	FechaUltCredito = null
	From dbo.ccfAplicaciones A inner join ccfDebitos D
	on A.IDDebito = D.IDDebito 
	Where IDAplicacion = @IDAplicacion 

	Update D set SaldoActual = (D.SaldoActual + A.MontoCredito )
	From dbo.ccfAplicaciones A inner join dbo.ccfCreditos D
	on A.IDCredito = D.IDCredito
	Where IDAplicacion = @IDAplicacion 
	
	DELETE FROM dbo.ccfAplicaciones WHERE IDAPLICACION = @IDAplicacion 
end

if @IDAplicacion = 0 and @IDCredito <> 0
begin
	Update D set SaldoActual = SaldoActual + A.MontoCredito ,
	Cancelado =  CASE WHEN (D.SaldoActual + A.MontoCredito )= D.MontoOriginal THEN 1 ELSE 0 END
	--select SaldoActual , SaldoActual + A.MontoCredito SaldoNuevo
	From dbo.ccfDebitos D
	inner join (
	Select A.IDDebito, SUM(A.MontoCredito ) MontoCredito
	From dbo.ccfAplicaciones A 
	Where A.IDCredito = @IDCredito 
	Group by A.IDDebito 
	) A on D.IDDebito = A.IDDebito 	

	Update C set SaldoActual = SaldoActual + A.MontoCredito 
--	select SaldoActual , SaldoActual + A.MontoCredito SaldoNuevo
	From dbo.ccfCreditos C
	inner join (
	Select A.IDCredito, SUM(A.MontoCredito ) MontoCredito
	From dbo.ccfAplicaciones A 
	Where A.IDCredito = @IDCredito 
	Group by A.IDCredito  
	) A on C.IDCredito  = A.IDCredito 

	DELETE FROM dbo.ccfAplicaciones WHERE IDCredito = @IDCredito 	
end

commit
end try
begin catch
    DECLARE @ErrorMessage NVARCHAR(4000);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;
	--rollback
SELECT 
        @ErrorMessage = ERROR_MESSAGE(),
        @ErrorSeverity = ERROR_SEVERITY(),
        @ErrorState = ERROR_STATE();

    RAISERROR (@ErrorMessage, -- Message text.
               16, --@ErrorSeverity, -- Severity.
               16--@ErrorState -- State.
               );
        IF @@TRANCOUNT > 0  
	ROLLBACK TRANSACTION; 
end catch 


GO

Create Procedure dbo.ccfAprobarDocumento @TipoDocumento as nvarchar(1), @IDDocumento int 
as
set nocount on 
begin transaction 
begin try
if upper(@TipoDocumento) = 'D' 
begin
	Update dbo.ccfDebitos set flgAprobado = 1
	Where IDDebito = @IDDocumento
	-- aqui se debe generar un Asiento contable del Documento
end
if upper(@TipoDocumento) = 'C' 
begin
	Update dbo.ccfCreditos set flgAprobado = 1
	Where IDCredito = @IDDocumento
	-- aqui se debe generar un Asiento contable del Documento
end
commit
end try
begin catch
    DECLARE @ErrorMessage NVARCHAR(4000);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;
	--rollback
SELECT 
        @ErrorMessage = ERROR_MESSAGE(),
        @ErrorSeverity = ERROR_SEVERITY(),
        @ErrorState = ERROR_STATE();

    RAISERROR (@ErrorMessage, -- Message text.
               16, --@ErrorSeverity, -- Severity.
               16--@ErrorState -- State.
               );
        IF @@TRANCOUNT > 0  
	ROLLBACK TRANSACTION; 
end catch 

go

--select * from dbo.ccfcreditos
--select dbo.ccfTieneAplicaciones ('D', 15)
Create Function dbo.ccfTieneAplicaciones (@TipoDocumento as nvarchar(1), @IDDocumento int )
returns bit 
begin
declare @Si bit 
set @Si = 0
if exists (
	Select IDAplicacion 
	From dbo.ccfAplicaciones 
	Where (upper(@TipoDocumento) = 'D' and ( IDDebito =  @IDDocumento) )
	or (upper(@TipoDocumento) = 'C' and ( IDCredito =  @IDDocumento) )
	)
Set @Si = 1
else
set @Si = 0
return @Si
end
go

Create Procedure dbo.ccfAnularDocumento @TipoDocumento as nvarchar(1), @IDDocumento int 
as
set nocount on

if  ( Select dbo.ccfTieneAplicaciones (@TipoDocumento, @IDDocumento) ) = 1
	return 
begin transaction 
begin try
if upper(@TipoDocumento) = 'D' 
begin
	Update dbo.ccfDebitos set Anulado  = 1, ConceptoSistema = '* ANULADO *'
	Where IDDebito = @IDDocumento
	-- aqui se debe generar un Asiento de Reversion contable del Documento
end
if upper(@TipoDocumento) = 'C' 
begin
	Update dbo.ccfCreditos set Anulado  = 1 , ConceptoSistema = '* ANULADO *'
	Where IDCredito = @IDDocumento
	
	if exists (Select * from dbo.ccfChequePosFechado Where IDCredito = @IDDocumento)
	begin
	Update dbo.ccfChequePosFechado Set Anulado = 0, Cobrado = 0, SinFondo = 0
	Where IDCredito = @IDDocumento 
	end
	
	-- aqui se debe generar un Asiento de Reversion contable del Documento
end
commit
end try
begin catch
    DECLARE @ErrorMessage NVARCHAR(4000);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;
	--rollback
SELECT 
        @ErrorMessage = ERROR_MESSAGE(),
        @ErrorSeverity = ERROR_SEVERITY(),
        @ErrorState = ERROR_STATE();

    RAISERROR (@ErrorMessage, -- Message text.
               16, --@ErrorSeverity, -- Severity.
               16--@ErrorState -- State.
               );
        IF @@TRANCOUNT > 0  
	ROLLBACK TRANSACTION; 
end catch 

go

CREATE FUNCTION [dbo].[ccfGetIDDocumentoCC] (@TipoDocumento as nvarchar(1), @IDBodega int, @Documento nvarchar(20), @IDClase nvarchar(10) )
-- this function returns the ID of any kind of Document CC
RETURNS int AS  
BEGIN 
declare @IDDocumentoCC int
if upper(@TipoDocumento) = 'D'
begin 
Set @IDDocumentoCC = (SELECT top 1 IDDebito 
	FROM dbo.ccfDebitos  
	where IDBodega = @IDBodega and Documento = @Documento and IDClase = @IDClase
	ORDER BY IDBodega, Documento desc
	)
end
if upper(@TipoDocumento) = 'C'
begin 
Set @IDDocumentoCC = (SELECT top 1 IDCredito 
	FROM dbo.ccfCreditos   
	where IDBodega = @IDBodega and Documento = @Documento and IDClase = @IDClase
	ORDER BY IDBodega, Documento desc
	)
end
if @IDDocumentoCC is null
	set @IDDocumentoCC = 0
return @IDDocumentoCC
end
go

-- exec  dbo.ccfgetRecibos 0,'20200922','20201126',0,0,-1,'*',-1
--0,'20200926','20201126',0,'*',-1,'*',-1
Create Procedure dbo.ccfgetRecibos @IDSucursal int, @FechaInicial date, @FechaFinal date, @IDCliente int, @IDVendedor int, @ConCheque int, @Documento nvarchar(20), @Anulado int
as 
set nocount on
if @FechaInicial is null
	set @FechaInicial = '20190101'
if @FechaFinal is null
	set @FechaFinal = '20500101' 
SELECT R.Documento Recibo, R.Fecha ,R.IDCliente, C.Nombre, R.IDVendedor, V.Nombre NombreVendedor,  R.MontoOriginal MontoRecibo, R.SaldoActual SaldoCredito, R.Efectivo, R.Descuento, R.RetencionMunicipal, R.RetencionRenta,
R.flgFlotante, isnull(R.IDChequePos,0) IDChequePos , R.MontoChequePos, R.Anulado, R.flgAprobado Aprobado, P.Cobrado, P.SinFondo, R.flgAprobado, R.IDBodega, R.Asiento, R.TipoCambio, R.IDCredito, R.IDMoneda, M.Descr DescrMoneda
  FROM [ceda].[dbo].[ccfCreditos] R left join dbo.ccfClientes C
  on R.IDCliente = C.IDCliente inner join dbo.fafVendedor V
  on R.IDVendedor = V.IDVendedor left join dbo.ccfChequePosFechado P
 on R.IDChequePos = P.IDChequePos left join dbo.globalMoneda M
 on R.IDMoneda = M.IDMoneda 
  Where IDClase = 'R/C' and R.Fecha between @FechaInicial and @FechaFinal and 
  (R.IDBodega = @IDSucursal or @IDSucursal = 0) and
  (R.IDCliente = @IDCliente or @IDCliente = 0) and 
  (R.IDVendedor = @IDVendedor or @IDVendedor = 0) and 
  (R.flgFlotante = @ConCheque or @ConCheque = -1) and 
  (R.Documento = @Documento or @Documento = '*') and
  (@Anulado = -1 or  R.Anulado = @Anulado )
 go
 
 -- exec dbo.ccfgetAplicacionesRC 85
 Create Procedure dbo.ccfgetAplicacionesRC @IDCredito int = 0, 
 @FechaInicio date = '20190101', @FechaFin date = '20500101', 
 @IDCliente int = 0
 as
 set nocount on 
if @FechaInicio is null
	set @FechaInicio = '20190101'
if @FechaFin is null
	set @FechaFin = '20500101'
	 
 Select R.IDCredito, R.IDClase, R.Documento Recibo,R.MontoOriginal TotalRecibo, R.Fecha, 
 R.IDCliente, C.Nombre, 
 R.IDVendedor, V.Nombre NombreVendedor, A.IDDebito, D.Documento Factura, 
 D.Fecha FechaFactura, D.MontoOriginal TotalFactura, A.Efectivo, A.Descuento,
 A.RetencionMunicipal, A.RetencionRenta , A.flgFlotante, A.IDChequePos, P.Numero, A.MontoChequePos, P.Cobrado, P.SinFondo, A.MontoCredito MontoAplicado, D.SaldoActual SaldoFactura
 From dbo.ccfCreditos R inner join dbo.ccfAplicaciones A
 on R.IDCredito = A.IDCredito inner join dbo.ccfClientes C
 on R.IDCliente = C.IDCliente inner join dbo.fafVendedor V
 on R.IDVendedor = V.IDVendedor inner join dbo.ccfDebitos D 
 on A.IDDebito = D.IDDebito left join dbo.ccfChequePosFechado P
 on R.IDChequePos = P.IDChequePos 
 Where R.IDClase = 'R/C' and (R.IDCredito = @IDCredito or @IDCredito = 0)
 and (R.Fecha between @FechaInicio and @FechaFin )
 and (R.IDCliente = @IDCliente or @IDCliente = 0)
 order by R.IDCredito 
 go
 
 -- exec dbo.ccfgetChequePos 38
Create Procedure dbo.ccfgetChequePos (@IDChequePos int )
 as
 Set Nocount On
 Select K.IDCredito, C.IDCliente, T.Nombre, C.IDClase + '-' + C.Documento Recibo,
  K.Numero NumeroCheque, K.Monto, K.IDBanco, B.Descr, K.Cobrado, K.SinFondo, K.FechaCobro
 From dbo.ccfChequePosFechado K left join dbo.cbBanco B
 on K.IDBanco = B.IDBanco inner join dbo.ccfCreditos C
 on K.IDCredito = C.IDCredito inner join dbo.ccfClientes T
 on C.IDCliente = T.IDCliente 
 where K.IDChequePos = @IDChequePos
 go

 
Create Procedure dbo.ccfUpdateChequePos (@IDChequePos int, @Cobrado bit, @SinFondo bit )
as
set nocount on
if @Cobrado = 1 
begin
	Update dbo.ccfChequePosFechado set Cobrado = @Cobrado
	Where IDChequePos = @IDChequePos
end
if @SinFondo = 1 
begin
declare @IDCredito int
	Select @IDCredito = IDCredito 
	From dbo.ccfChequePosFechado Where IDChequePos = @IDChequePos 
	
	Update dbo.ccfChequePosFechado set SinFondo = @SinFondo, Anulado = 1
	Where IDChequePos = @IDChequePos
	-- Se debe anular el R/C, esto est· pendiente 
	Update dbo.ccfCreditos set Anulado = 1
	Where IDCredito = @IDCredito
end
go

-- exec dbo.ccfgetChequesPos 0,'20201007','20201207','*',-1,2
Create Procedure dbo.ccfgetChequesPos @IDCliente int,  @FechaInicio date = '20190101', @FechaFin date = '20500101',
 @Numero nvarchar(20), @Cobrado int, @DiasProximoCobrar int = 0
as 
set nocount on 
if @FechaInicio is null
	set @FechaInicio = '20190101'
if @FechaFin is null
	set @FechaFin = '20500101'
 Select K.IDCredito, C.IDCliente, T.Nombre, C.IDClase + '-' + C.Documento Recibo, C.Fecha, C.MontoOriginal MontoRecibo,  
 K.IDChequePos, K.Numero NumeroCheque, K.Monto, K.IDBanco, B.Descr, K.Cobrado, K.SinFondo, K.FechaCobro, K.Anulado,
  DATEDIFF(day, getdate(), K.FechaCobro) DiasparaCobro
 From dbo.ccfChequePosFechado K inner join dbo.cbBanco B
 on K.IDBanco = B.IDBanco inner join dbo.ccfCreditos C
 on K.IDCredito = C.IDCredito inner join dbo.ccfClientes T
 on C.IDCliente = T.IDCliente 
 where (C.IDCliente = @IDCliente or @IDCliente = 0) and ( K.Numero = @Numero or @Numero = '*') and (K.cobrado = @Cobrado or @Cobrado = -1)
 and  ((DATEDIFF(day, getdate(), K.FechaCobro) <= @DiasProximoCobrar) or @DiasProximoCobrar = 0)
 and K.Anulado = 0 and  (C.Fecha between @FechaInicio and @FechaFin )
go 
-- drop table dbo.ccfAutorizacion alter table dbo.ccfAutorizacion add  SaldoLimite decimal (28,2)
Create Table dbo.ccfAutorizacion (IDAutorizacion int identity(1,1) not null, IDCliente int,  Fecha date, Usuario nvarchar(20), 
Limitado bit default 1, MontoLimite decimal (28,2) default 0, Used bit default 0, Anulada bit default 0, IDFactura bigint null,
Nota nvarchar(255),  SaldoLimite decimal (28,2) default 0)
go
alter table dbo.ccfAutorizacion add constraint pkccfAutorizacion primary key (IDAutorizacion)
go
alter table dbo.ccfAutorizacion add constraint fkccfAutorizacionFactura foreign key (IDFactura) references dbo.fafFactura (IDFactura)
go
alter table dbo.ccfAutorizacion add constraint fkccfAutorizacionCliente foreign key (IDCliente) references dbo.ccfClientes (IDCliente)
go
-- drop table dbo.ccfAutorizacionFactura
Create table dbo.ccfAutorizacionFactura (IDAutorizacion int not null, IDFactura bigint not null) 
go
alter table dbo.ccfAutorizacionFactura add constraint pkAutFact primary key (IDAutorizacion,IDFactura )
go
alter table dbo.ccfAutorizacionFactura add constraint fkautFactAut foreign key (IDAutorizacion) references dbo.ccfAutorizacion (IDAutorizacion)
go
alter table dbo.ccfAutorizacionFactura add constraint fkautFactFact foreign key (IDFactura) references dbo.fafFactura  (IDFactura)
go
-- select * from dbo.ccfAutorizacion exec dbo.ccfUpdateAutorizacion 'A', 10, 66,'20201203','azepeda',0,0.00,0,0,null,''
Create Procedure dbo.ccfUpdateAutorizacion @Operacion nvarchar(1), @IDAutorizacion int, @IDCliente int,  @Fecha date, @Usuario nvarchar(20), 
@Limitado bit , @MontoLimite decimal (28,2) , @Used bit , @Anulada bit, @IDFactura bigint = null, @Nota nvarchar(255), @MontoTotalFactura decimal(28,4) = null
as
Set nocount on
if @MontoTotalFactura is null 
	set @MontoTotalFactura = 0
if @Operacion = 'I'
begin
	Insert dbo.ccfAutorizacion (IDCliente , Fecha, Usuario, Limitado , MontoLimite , Used , Anulada, IDFactura, Nota, SaldoLimite )
	values  (@IDCliente , @Fecha, @Usuario, @Limitado , @MontoLimite , @Used , @Anulada, @IDFactura, @Nota, @MontoLimite )
end
if @Operacion = 'U'
begin
	Update dbo.ccfAutorizacion set Fecha = @Fecha, Limitado = @Limitado, MontoLimite = @MontoLimite, Anulada = @Anulada,
	Nota = @Nota, SaldoLimite = @MontoLimite
	Where IDAutorizacion = @IDAutorizacion
end 

if @Operacion = 'A'
begin
	Update dbo.ccfAutorizacion set Anulada = 1
	Where IDAutorizacion = @IDAutorizacion
end 
if @Operacion = 'F'
begin
	Update dbo.ccfAutorizacion set Used = 1, IDFactura = @IDFactura, 
	SaldoLimite = (MontoLimite - @MontoTotalFactura)
	Where IDAutorizacion = @IDAutorizacion
	insert dbo.ccfAutorizacionFactura(IDAutorizacion, IDFactura )
	values (@IDAutorizacion, @IDFactura)
end 
if @Operacion = 'D'
begin
	Delete dbo.ccfAutorizacion 
	Where IDAutorizacion = @IDAutorizacion
end 
go

--drop function exec  dbo.ccfgetAutorizacion 100,'20201204' 
Create Procedure dbo.ccfgetAutorizacion @IDCliente int,  @Fecha date
as
set nocount on 
Select top 1 isnull(IDAutorizacion, 0 ) IDAutorizacion , ISNULL( case when Limitado = 1 then SaldoLimite  else 9999999 end, 0) SaldoLimite
From  dbo.ccfAutorizacion 
where IDCliente = @IDCliente and fecha = cast(@Fecha as date)
and Anulada = 0 --and Used = 0 quieren que sea valida siempre en el dia
go

-- exec dbo.ccfgetAutorizaciones 0,null,null,-1,-1,-1
Create Procedure dbo.ccfgetAutorizaciones @IDCliente int,  @FechaInicio date = '20190101',  @FechaFin date = '20500101',@Limitado int = -1 , 
@Used int = -1, @Anulada int = -1
as
set nocount on
if @FechaInicio is null
	set @FechaInicio = '20190101'
if @FechaFin is null
	set @FechaFin = '20500101'	
Select A.IDAutorizacion, A.IDCliente, C.Nombre, A.Fecha, A.Limitado, A.MontoLimite, A.Used, A.IDFactura, A.Anulada, A.Nota, A.SaldoLimite  
From dbo.ccfAutorizacion A inner join dbo.ccfClientes C
on A.IDCliente = C.IDCliente 
where (A.IDCliente  = @IDCliente or @IDCliente = 0) and (A.Fecha between @FechaInicio and @FechaFin )
and ( A.Limitado = @Limitado or @Limitado = -1 ) and (A.Used = @Used or @Used = -1)
and (A.Anulada  = @Anulada or @Anulada = -1)
go 

Create Procedure dbo.ccfgetDatosAutorizacion @IDAutorizacion int
as
set nocount on

Select A.IDAutorizacion, A.IDCliente, C.Nombre, A.Fecha, A.Limitado, A.MontoLimite, A.Used, A.IDFactura, A.Anulada, A.Nota , A.Usuario  
From dbo.ccfAutorizacion A inner join dbo.ccfClientes C
on A.IDCliente = C.IDCliente 
where A.IDAutorizacion = @IDAutorizacion 
go


create Procedure dbo.ccfUpdateccfNotaCreditoDev @Operation nvarchar(1),  @IDCredito int , @IDDevolucion int, 
@IDCliente int  ,@IDBodega int  ,@TipoDocumento nvarchar(1) , @IDClase nvarchar(10), 
@IDSubTipo	int , @Documento nvarchar(20) , @Fecha datetime , @Plazo INT ,  @MontoOriginal decimal(28,4) ,
@ConceptoSistema nvarchar(500),@ConceptoUsuario nvarchar(500), @RecibimosDe nvarchar(250),
@Usuario nvarchar(20), @TipoCambio decimal(28,4), @IDVendedor int, 	@flgOrigenExterno bit ,
@flgAprobado bit,   @CodigoConsecutivoMask nvarchar(20) = null, @IDMoneda int = null, @Anulado bit = null, @flgFlotante bit = null,
@Efectivo decimal (28,4) = null,
@Descuento decimal (28,4) = null,
@RetencionMunicipal decimal (28,4) = null,
@RetencionRenta decimal (28,4) = null,
@MontoChequePos 	decimal (28,4) = null, @NumeroChkPos nvarchar(20) = null, @IDBancoChkPos int = null, @FechaCobroChkpos date = null
as
set nocount on 

exec dbo.ccfUpdateccfCreditos @Operation, @IDCredito output, @IDCliente, @IDBodega, @TipoDocumento,
 @IDClase, @IDSubTipo, @Documento, @Fecha, @Plazo, @MontoOriginal, @ConceptoSistema, @ConceptoUsuario, @RecibimosDe,
 @Usuario, @TipoCambio, @IDVendedor, @flgOrigenExterno, @flgAprobado, @CodigoConsecutivoMask, @IDMoneda
 
exec dbo.fafUpdateDevolucion   'F',@IDDevolucion, 0 , 
@Fecha , '' , '' ,@IDBodega  , @IDMoneda,  
@Usuario , @TipoCambio  , 0 , '' , @IDCredito

go 
 

--select dbo.ccfgetAutorizacion (1,GETDATE()) select dbo.ccfgetAutorizacion (1,'20201203') exec dbo.ccfgetDatoAutorizacion 1
--Select * from  dbo.ccfAutorizacion where fecha = cast(getdate() as date)  set sinfondo = 0



 
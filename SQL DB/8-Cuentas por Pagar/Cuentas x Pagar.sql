--drop table dbo.cppParametros alter table cppParametros add ProvExternoRetencion bit default 0 update cppParametros set ProvExternoRetencion = 0
Create table dbo.cppParametros (IDParametro int identity (1,1) not null, 
DocAprobadosDefault bit default 0, CambiarPlazo bit default 0, TipoAsientoDebito nvarchar(2), 
TipoAsientoCredito nvarchar(2), IntegracionContable bit default 0, ProvExternoRetencion bit default 0 )
go
alter table dbo.cppParametros add constraint pkcppParametros primary key (IDParametro)
go
alter table dbo.cppParametros add constraint fkcppparametroTipoAsientodeb foreign key (TipoAsientoDebito) references dbo.cntTipoAsiento (Tipo)
go
alter table dbo.cppParametros add constraint fkcppparametroTipoAsientocred foreign key (TipoAsientoCredito) references dbo.cntTipoAsiento (Tipo)
go

Create Procedure dbo.cppGetParametros (@IDParametro int)
as
set nocount on
Select IDParametro,  DocAprobadosDefault, CambiarPlazo, TipoAsientoDebito, 
TipoAsientoCredito, IntegracionContable   
from dbo.cppParametros 
where IDParametro = @IDParametro
go


Create Procedure dbo.cppUpdateParametros (@IDParametro int, 
@DocAprobadosDefault bit , @CambiarPlazo bit , @TipoAsientoDebito nvarchar(2)
, @TipoAsientoCredito nvarchar(2) , @IntegracionContable  bit )
as
set nocount on
if not exists (select * from dbo.cppParametros )
Begin
	Insert dbo.cppParametros (DocAprobadosDefault, CambiarPlazo, TipoAsientoDebito, 
	TipoAsientoCredito, IntegracionContable   )
	values (@DocAprobadosDefault, @CambiarPlazo , @TipoAsientoDebito ,
	 @TipoAsientoCredito,  @IntegracionContable   )
end
else
Begin
	Update dbo.cppParametros Set DocAprobadosDefault = @DocAprobadosDefault, 
	CambiarPlazo =@CambiarPlazo,  TipoAsientoDebito  = @TipoAsientoDebito ,  
	TipoAsientoCredito  = @TipoAsientoCredito, IntegracionContable = @IntegracionContable
	where IDParametro = @IDParametro
End
go

-- Select * from dbo.cppClaseDocumento alter table dbo.cppClaseDocumento add GeneraRetencion bit default 0 alter table dbo.cppClaseDocumento add UsaCuentaBancaria bit default 0 Update dbo.cppClaseDocumento set GeneraRetencion = 0
Create Table dbo.cppClaseDocumento ( TipoDocumento nvarchar(1) not null, IDClase nvarchar(10) not null, Descr nvarchar(250), 
Orden int default 0, Activo bit default 1,
DistribAutom bit default 0, EsInteres bit default 0, EsDeslizamiento bit default 0 ,  UsaCuentaBancaria bit default 0,
SysReadOnly bit default 0, UltimoNumero bit default 0, AprobacionRequerida bit default 0, GeneraRetencion bit default 0)
go

alter table dbo.cppClaseDocumento add constraint  pkcppClaseDocumento primary key ( TipoDocumento,IDClase  )
go

alter table dbo.cppClaseDocumento add constraint ckcppInteresDesliz
CHECK((cast(EsInteres as smallint) + cast( EsDeslizamiento as smallint ))<2)
go

alter table dbo.cppClaseDocumento add constraint ukcppClaseDocumento UNIQUE (orden)
go


insert dbo.cppClaseDocumento ( TipoDocumento,  IDClase , Descr, orden, activo, DistribAutom, EsInteres, EsDeslizamiento, GeneraRetencion )
values ('C', 'FAC', 'FACTURA', 1, 1, 0, 0, 0,1)
GO
insert dbo.cppClaseDocumento ( TipoDocumento, IDClase , Descr, orden, activo, DistribAutom, EsInteres, EsDeslizamiento  )
values ('C', 'N/D', 'NOTAS DE DEBITO', 2, 1, 0, 0,0)
GO

insert dbo.cppClaseDocumento ( TipoDocumento,  IDClase , Descr, orden, activo, DistribAutom, EsInteres, EsDeslizamiento )
values ('C', 'O/D', 'OTROS DEBITOS', 3, 1, 0, 0, 0)
GO

insert dbo.cppClaseDocumento ( TipoDocumento, IDClase , Descr, orden, activo, DistribAutom, EsInteres, EsDeslizamiento   )
values ('C', 'D/C', 'DIFERENCIAL CAMBIARIO / DESLIZAMIENTO', 4, 1, 0, 0, 1)
GO

insert dbo.cppClaseDocumento (TipoDocumento, IDClase , Descr, orden, activo, DistribAutom, EsInteres, EsDeslizamiento   )
values ('C', 'INT', 'INTERES MORATORIO', 5, 1, 0, 1, 0)
GO

insert dbo.cppClaseDocumento (TipoDocumento, IDClase , Descr, orden, activo, DistribAutom, EsInteres, EsDeslizamiento, UsaCuentaBancaria    )
values ('D', 'CHK', 'CHEQUE', 6, 1, 1, 0, 0, 1)
GO

insert dbo.cppClaseDocumento (TipoDocumento, IDClase , Descr, orden, activo, DistribAutom, EsInteres, EsDeslizamiento, UsaCuentaBancaria   )
values ('D','TFB', 'TRANSFERENCIA BANCARIA', 7, 1, 0, 0, 0, 1)
GO

insert dbo.cppClaseDocumento (TipoDocumento, IDClase , Descr, orden, activo, DistribAutom, EsInteres, EsDeslizamiento  )
values ('D','N/C', 'NOTA CREDITO', 8, 1, 1, 0, 0)
GO

insert dbo.cppClaseDocumento (TipoDocumento, IDClase , Descr, orden, activo, DistribAutom, EsInteres, EsDeslizamiento  )
values ('D','O/C', 'OTROS CREDITO', 9, 1, 1, 0, 0)
GO

insert dbo.cppClaseDocumento (TipoDocumento, IDClase , Descr, orden, activo, DistribAutom, EsInteres, EsDeslizamiento  )
values ('D','RET', 'RETENCION', -1, 1, 1, 0, 0)
GO

-- alter table dbo.cppSubTipoDocumento add SysReadOnly bit default 0 update dbo.cppSubTipoDocumento set SysReadOnly = 0
Create Table dbo.cppSubTipoDocumento (IDSubTipo int identity(1,1) not null, TipoDocumento nvarchar(1) not null, IDClase nvarchar(10) not null,
Descr nvarchar(200), Descripcion nvarchar(200), Consecutivo int default 0,   SubTipoGeneraAsiento bit default 0, NaturalezaCta nvarchar(1), CtaDebito varchar(25), CtaCredito varchar(25),
Especial bit default 0, ContraCtaEnSubTipo bit default 0, SysReadOnly bit default 0 )
-- ContraCtaEnSubTipo : 1 El Asiento tomara la cta contable de la contracuenta en el subTipoDocumento 0 : Toma la CxC de la sucursal
-- ESPECIAL QUIERE DECIR QUE EL SUBTIPO NO DISTRIBUYE AUTOMATICAMENTE NI MANUALMENTE, NO APLICA NINGUN DOCUMENTO, NO ES RECUPERACION
--, Orden int default 0, DistribAutom bit default 0, EsInteres bit default 0, EsDeslizamiento bit default 0 )
go
/* Explicacion de los Campos de la tabla dbo.[cppSubTipoDocumento]
Field	Descripci€n	Funci€n
IDSubTipo	Codigo del SubTipo	
TipoDocumento	Tipo de SubTipo de Documento	Indica si el Documento es D»bito o Cr»dito
IDClase	ID de la Clase a la que pertenece	Indica la Clase 
Descr	Descripci€n del SubTipo de Documento	
Descripcion	Descripci€n Alterna	
Consecutivo	Consecutivo No Usado, esto es si el usuario quiere	
DistribAutom	Distribuci€n Autom∑tica de los SubTipo Cr»ditos	Si es 1 Aplica o Cancela los d»bitos m∑s vencidos
EsRecuperacion	Indica si un Documento Aplica como Recuperaci€n	Es utilizado en la reporteria
SubTipoGeneraAsiento	Indica si un subtipo genera o no Asiento Contable	Si es 0 la generaci€n de Asiento se hace como un R/C autom∑tico
NaturalezaCta	Indica en donde va la cuenta que manda	La cuenta que manda puede estar en Deb o Cred
CtaDebito	Cuenta Contable del SubTipo en el Debito	
CtaCredito	Cuenta Contable del SubTipo en el Cr»dito	
Especial	Indica si el subtipo corresponde para un Cliente vario o especial	Si es especial, se toma los clientes que tengan categoria Especial o Varios
ContraCtaEnSubTipo	Indica si la ContraCuenta la toma del SubTipo o es la Cta CxC de la Sucursal	

*/

alter table dbo.cppSubTipoDocumento add constraint pkcppSubTipoDocumento primary key (IDSubTipo )
go

create  index  _indcppSubTipoDocumento  on dbo.cppSubTipoDocumento   (IDSubTipo )
go 

alter table dbo.cppSubTipoDocumento add constraint ukcppSubTipoDocumento UNIQUE (TipoDocumento, IDClase, IDSubTipo)
go

alter table dbo.cppSubTipoDocumento add constraint fkcppSubTipoDocumento foreign key (TipoDocumento, IDClase) references dbo.cppClaseDocumento (TipoDocumento, IDClase)
go

alter table dbo.cppSubTipoDocumento add constraint ckcppNaturaleza 
CHECK( ( not NaturalezaCta is null and ( NaturalezaCta ='D' or NaturalezaCta = 'C'))
)
go

Insert dbo.cppSubTipoDocumento ( TipoDocumento,  IDClase, Descr, Descripcion, Consecutivo,  SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, Especial  )	
Values ('C',	 'FAC',	'FACTURAS',	'FACTURA',	1,0,  'C', NULL,NULL, 0	)
GO
Insert dbo.cppSubTipoDocumento ( TipoDocumento,  IDClase, Descr, Descripcion, Consecutivo,  SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, Especial )	
Values ('C',	 'INT',	'INTERESES',	'INTERES POR MORA',	1,0	,  'C', NULL, NULL,0	)
GO
Insert dbo.cppSubTipoDocumento ( TipoDocumento, IDClase, Descr, Descripcion, Consecutivo,  SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, Especial )	
Values ('C',	 'D/C'	, 'DIFERENCIAL CAMBIARIO',	'DIFERENCIAL CAMBIARIO',	1,0, 'C', NULL,NULL,0	)
GO

Insert dbo.cppSubTipoDocumento ( TipoDocumento, IDClase, Descr, Descripcion, Consecutivo,  SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, Especial)	
Values ('D',	 'CHK',	'CHEQUE',	'CHEQUE',	1,1, 'D', NULL, NULL,0	)
GO
Insert dbo.cppSubTipoDocumento ( TipoDocumento, IDClase, Descr, Descripcion, Consecutivo,  SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, Especial)	
Values ('D',	 'N/C',	'NOTA DE CREDITO ',	'NOTA DE CREDITO ',	1, 0, 'D', NULL, NULL,0	)
GO

Insert dbo.cppSubTipoDocumento ( TipoDocumento, IDClase, Descr, Descripcion, Consecutivo,  SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, Especial)	
Values ('D',	 'O/C',	'OTRO CREDITO ',	'OTRO CREDITO ',	1,1, 'D', NULL, NULL,0	)
GO

Insert dbo.cppSubTipoDocumento ( TipoDocumento, IDClase, Descr, Descripcion, Consecutivo,  SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, Especial)	
Values ('D',	 'TFB',	'TRANSFERENCIA BANCARIA ',	'TRANSFERENCIA BANCARIA ',	1,1, 'D', NULL, NULL,0	)
GO

Insert dbo.cppSubTipoDocumento ( TipoDocumento, IDClase, Descr, Descripcion, Consecutivo,  SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito, Especial)	
Values ('D',	 'RET',	'RETENCION ',	'RETENCION ',	1,1, 'D', NULL, NULL,0	)
GO
-- drop table dbo.cppaplicaciones alter table dbo.cppDebitos add IDImpuesto int null
Create Table dbo.cppDebitos ( 
	IDDebito int  identity(1,1) not null ,
	IDProveedor int  not null,
	TipoDocumento nvarchar(1) not null,
	IDClase nvarchar(10) not null,
	IDSubTipo	int not null, 
	Documento nvarchar(20) not null,
	Fecha datetime not null,
	MontoOriginal decimal(28,4) default 0,
	SaldoActual  decimal(28,4) default 0,
	PorcInteres decimal(8,2) default 0,
	Anulado bit default 0,
	ConceptoSistema nvarchar(500) default '',
	ConceptoUsuario nvarchar(500) default '',
	Asiento nvarchar(20),
	AsientoReversion nvarchar(20),
	Usuario nvarchar(20), CreateDate datetime, 
	TipoCambio decimal(28,4) default 1,
	Contabilizado bit default 0,
	flgOrigenExterno bit default 0,
	flgAprobado bit default 0,
	IDMoneda int not null,
	IDCuentaBanco int null
	
) 
go

alter table dbo.cppDebitos add constraint pkcppDebitos primary key (IDDebito)
go
alter table dbo.cppDebitos add constraint fkcppDebitosProveedor foreign key (IDProveedor ) references dbo.cppProveedor (IDProveedor )
go

alter table dbo.cppDebitos add constraint fkcppDebitosDocument foreign key  ( IDSubTipo ) references dbo.cppSubTipoDocumento (  IDSubTipo)
go

alter table dbo.cppDebitos add constraint ukcppDebitosCC UNIQUE ( IDClase, Documento)
go

alter table dbo.cppDebitos add constraint fkcppDebitosMoneda foreign key (IDMoneda ) references dbo.globalMoneda   (IDMoneda )
go

alter table dbo.cppDebitos add constraint fkcppDebitosCtaBanco foreign key (IDCuentaBanco ) references dbo.cbCuentaBancaria   (IDCuentaBanco )
go

--alter table dbo.cppDebitos add constraint fkcppDebitosImpuesto foreign key (IDImpuesto ) references dbo.globalImpuesto   (IDImpuesto )
--go



Create nonclustered index indcppDebitosCC on dbo.cppDebitos ( IDProveedor , TipoDocumento, IDClase, Fecha, Documento )
go

CREATE NONCLUSTERED INDEX [i_cppDebitos] ON dbo.cppDebitos ([IDProveedor], [IDClase], [TipoDocumento])
go
-- drop table  dbo.cppCreditos
Create Table dbo.cppCreditos ( 
	IDCredito int  identity(1,1) not null ,
	IDProveedor int  not null,
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
	Anulado bit default 0,
	ConceptoSistema nvarchar(500) default '',
	ConceptoUsuario nvarchar(500) default '',
	Asiento nvarchar(20),
	AsientoReversion nvarchar(20),
	Usuario nvarchar(20), CreateDate datetime, 
	TipoCambio decimal(28,4) default 1,
	Contabilizado bit default 0,
	flgOrigenExterno bit default 0,
	flgAprobado bit default 0,
	IDMoneda int not null,
	SubTotal decimal (28,4) default 0,
	Descuento decimal (28,4) default 0,
	SubTotalSinDescuento decimal (28,4) default 0,
	ImpuestoIVA decimal (28,4) default 0,
	ImpuestoConsumo decimal (28,4) default 0,
	Flete decimal (28,4) default 0,
	Total decimal (28,4) default 0
) 
go


alter table dbo.cppCreditos add constraint pkcppCredito primary key (IDCredito)
go
alter table dbo.cppCreditos add constraint fkcppCreditosProveedor foreign key (IDProveedor ) references dbo.cppProveedor (IDProveedor )
go

alter table dbo.cppCreditos add constraint fkcppCreditosDocument foreign key  ( IDSubTipo ) references dbo.cppSubTipoDocumento (  IDSubTipo)
go

ALTER table dbo.cppCreditos add constraint ukcppCreditosCP UNIQUE ( IDProveedor,  IDClase, Documento)
go

alter table dbo.cppCreditos add constraint fkcppCreditosMoneda foreign key (IDMoneda ) references dbo.globalMoneda   (IDMoneda )
go
Create nonclustered index indcppCreditos on dbo.cppCreditos ( IDProveedor , TipoDocumento, IDClase, Fecha, Documento )
go

CREATE NONCLUSTERED INDEX [i_cppCreditos] ON dbo.cppCreditos ([IDProveedor], [IDClase], [TipoDocumento])
go

Create Table dbo.cppAplicaciones ( IDAplicacion int identity(1,1) not null,
IDDebito int not null,
IDCredito int not null, 
DocDebito nvarchar(20) not null,
DocCredito nvarchar(20) not null,
Fecha datetime not null,
FechaCredito datetime not null default '19800101',
MontoCredito decimal(28,4) default 0,
CreateDate	datetime null,
Asiento nvarchar(20),
fechaUltCreditoAnt datetime
)
go


alter table dbo.cppAplicaciones add constraint pkcppAplicaciones primary key (IDAplicacion)
go

alter table dbo.cppAplicaciones add constraint fkcppAplicacionesDebito foreign key (IDDebito) references dbo.cppDebitos (IDDebito)
go

alter table dbo.cppAplicaciones add constraint fkcppAplicacionesCredito foreign key (IDCredito) references dbo.cppCreditos (IDCredito)
go

alter table dbo.cppAplicaciones add constraint ukcppAplicaciones UNIQUE (IDDebito, DocCredito, DocDebito, Fecha, FechaCredito, IDCredito)
go

ALTER TABLE dbo.cppAplicaciones ADD  DEFAULT (getdate()) FOR CreateDate
GO

Create nonclustered index  indcppAplicacionesIDDebito on dbo.cppAplicaciones (IDDebito)
go

Create nonclustered index  indcppAplicacionesIDCredito on dbo.cppAplicaciones (IDCredito)
go

-- drop procedure dbo.cppUpdatecppCreditos select * from dbo.cppproveedor
-- Create Procedure dbo.cppCreaRetenciones @IDProveedor int, @IDCredito int, 
--@IDClase nvarchar(10), @Documento nvarchar(20) , 
--@Fecha datetime,  @Usuario nvarchar(20), @TipoCambio decimal(28,4),
--@IDMoneda int = null,@SubTotal decimal(28, 4)=0, @SubTotalDescuento decimal(28, 4)=0, 
--@Total decimal(28,4)=0, @strIDRetenciones nvarchar(500)=null

 create Procedure dbo.cppCreaRetenciones @IDCredito int, 
 @strIDRetenciones nvarchar(500)=null
-- la Transaccion debe ponerse fuera de este proceso
as
set nocount on
Declare @GeneraRetencion bit 
Declare @IDProveedor int,  
@IDClase nvarchar(10), @Documento nvarchar(20) , 
@Fecha datetime,  @Usuario nvarchar(20), @TipoCambio decimal(28,4),
@IDMoneda int = null,@SubTotal decimal(28, 4), @SubTotalDescuento decimal(28, 4), 
@Total decimal(28,4)

Select @IDProveedor = IDProveedor , @IDCredito = IDCredito , 
	@IDClase = IDClase, @Documento =Documento  , @Fecha = Fecha ,  
	@Usuario = Usuario , @TipoCambio = TipoCambio,
	@IDMoneda = IDMoneda,@SubTotal = SubTotal , 
	@SubTotalDescuento = SubTotalsinDescuento , @Total = Total
From dbo.cppCreditos 
Where IDCredito = @IDCredito 

Select @GeneraRetencion = GeneraRetencion
From dbo.cppClaseDocumento 
Where IDClase = @IDClase

if @GeneraRetencion = 1 and exists ( Select * from dbo.cppRetencion 
	Where IDRetencion in (Select value 
	From dbo.ConvertListToTable (@strIDRetenciones, ','))	
	)
begin
	Declare @Retenciones as table (
	[IDProveedor] [int] NOT NULL,
	[IDCredito] [int] NOT NULL,
	[IDRetencion] [int] NOT NULL,
	[Pagada] [bit] NULL,
	[FechaRetencion] [date] NULL,
	[Monto] [decimal](28, 4) NULL,
	[Base] [decimal](28, 4) NULL )	
	Insert @Retenciones ( IDProveedor, IDCredito, IDRetencion, Pagada, FechaRetencion, Monto, Base )
	Select @IDProveedor IDProvedor, @IDCredito IDCredito, R.IDRetencion, 1 Pagada, @Fecha FechaRetencion,
	(case when AplicaSubTotal = 1 
	then @SubTotal else
	case when AplicaSubTotalMenosDesc = 1 then
	@SubTotalDescuento
	else
	case when AplicaTotalFactura = 1 then
	@Total
	else
	0
	end 
	end
	end * Porcentaje/100 ) MontoRetencion, 
	case when AplicaSubTotal = 1 
	then @SubTotal else
	case when AplicaSubTotalMenosDesc = 1 then
	@SubTotalDescuento
	else
	case when AplicaTotalFactura = 1 then
	@Total
	else
	0
	end 
	end
	end Base 
	From dbo.cppRetencion R left join ( Select IDRetencion, IDProveedor, IDCredito 
	from dbo.cppRetenciones 
	Where IDProveedor = @IDProveedor and IDCredito = @IDCredito ) A
	on R.IDRetencion = A.IDRetencion  
	Where R.IDRetencion in (Select value From dbo.ConvertListToTable (@strIDRetenciones, ','))	
	AND A.IDCredito IS NULL AND A.IDProveedor IS NULL AND A.IDRetencion IS NULL
	IF ( Select count(*) from @Retenciones ) > 0
	BEGIN
	
	insert dbo.cppRetenciones (IDProveedor, IDCredito, IDRetencion, Pagada, FechaRetencion, Monto, Base)
	Select IDProveedor, IDCredito, IDRetencion, Pagada, FechaRetencion, Monto, Base
	From @Retenciones 
	-- insertamos los Debitos Retenciones 
	Declare @IDSubtipoRetencion int 
	Select top 1 @IDSubtipoRetencion = IDSubTipo 
	From dbo.cppSubTipoDocumento
	Where IDClase = 'RET' 
	
	Declare @TableinsertDebitos as table (IDnewDebito int, DocDebito nvarchar(20), 
	Fecha datetime, Monto decimal(28,4) default 0)
	Insert dbo.cppDebitos (IDProveedor, TipoDocumento, IDClase, IDSubTipo, Documento,
	Fecha, MontoOriginal, SaldoActual, PorcInteres, Anulado, 
	ConceptoSistema,
	ConceptoUsuario, Usuario , TipoCambio, Contabilizado, flgOrigenExterno, flgAprobado, 
	IDMoneda )
	OUTPUT inserted.IDDebito, inserted.Documento, inserted.Fecha, inserted.MontoOriginal    
	INTO @TableinsertDebitos
	Select R.IDProveedor, 'D', 'RET', @IDSubtipoRetencion, 'RET' + cast(R.IDRetenciones  as nvarchar(100) ),
	CAST(R.FechaRetencion AS DATE), R.Monto, 0 SaldoActual, 0 PorcInteres, 0 Anulado, 	
	@IDClase + '-' + @Documento ,	
	'RetenciÛn correspondiente al Documento ' + @IDClase + '-' + @Documento ,	
	@Usuario, @TipoCambio, 0 Contabilizado, 0 flgOrigenExterno, 1 flgAprobado,
	@IDMoneda  
	From dbo.cppRetenciones R inner join @Retenciones T
	on R.IDRetencion = T.IDRetencion and R.IDProveedor = T.IDProveedor 
	and R.IDCredito = T.IDCredito and R.FechaRetencion = T.FechaRetencion 

	
	Declare @TotalRetenciones decimal (28,4)
	
	Select @TotalRetenciones = SUM(Monto)
	From @TableinsertDebitos
	
	Insert dbo.cppAplicaciones (IDDebito, IDCredito, DocDebito, DocCredito, Fecha, FechaCredito, MontoCredito )
	Select IDnewDebito, @IDCredito, DocDebito, @Documento, Fecha, cast(GETDATE() as DATE) , Monto 
	From @TableinsertDebitos 
	
	Insert dbo.cppProveedorRetencion (IDProveedor, IDRetencion )
	Select E.IDProveedor, E.IDRetencion 
	from (
	Select Distinct IDProveedor, IDRetencion 
	from dbo.cppRetenciones 
	Where IDProveedor = @IDProveedor ) E left join dbo.cppProveedorRetencion A
	on E.IDProveedor = A.IDProveedor and E.IDRetencion = A.IDRetencion 
	where A.IDProveedor is null and A.IDRetencion is null 
	
	Update dbo.cppCreditos  set SaldoActual = SaldoActual - @TotalRetenciones
	WHERE IDCredito = @IDCredito 
	END
end
go

/*
exec dbo.cppUpdatecppCreditos 'I', 0, 1, 'C', 'FAC', 1, 'F01002','20210114', 0, 1000,
'ND', 'ND', 'azepeda', 34.4545, 0, 1, 1, 0, 1000, 0,0,0,0,0,1000, '1,2'
*/

Create Procedure dbo.cppUpdatecppCreditos @Operation nvarchar(1),  @IDCredito int Output, 
@IDProveedor int  ,@TipoDocumento nvarchar(1) , @IDClase nvarchar(10), 
@IDSubTipo	int , @Documento nvarchar(20) , @Fecha datetime ,  @Plazo INT ,  @MontoOriginal decimal(28,4) ,
@ConceptoSistema nvarchar(500),@ConceptoUsuario nvarchar(500), 
@Usuario nvarchar(20), @TipoCambio decimal(28,4),  	@flgOrigenExterno bit ,
@flgAprobado bit,    @IDMoneda int = null, @Anulado bit = null,
@SubTotal decimal (28,4) ,
@Descuento decimal (28,4) ,
@SubTotalDescuento decimal (28,4) ,
@ImpuestoIVA decimal (28,4) ,
@ImpuestoConsumo decimal (28,4) ,
@Flete decimal (28,4),
@Total decimal (28,4), @strIDRetenciones nvarchar(500) = null
-- @Operation = I Nuevo, D Eliminar, F Modifica Fecha Credito
as
set nocount on
declare @Ok bit, @Vencimiento datetime ,@VencimientoVar datetime ,@FechaUltCredito datetime, @SaldoActual  decimal(28,4) 
,  @Cancelado bit, @GeneraRetencion bit 
set @Ok = 0

Select @GeneraRetencion = GeneraRetencion,@flgAprobado = CASE WHEN AprobacionRequerida = 1 then  0 else 1 end 
From dbo.cppClaseDocumento 
Where IDClase = @IDClase 

if @strIDRetenciones is null
	set @strIDRetenciones = ''

if @Anulado is null 
	set @Anulado = 0
begin transaction 
begin try
if upper(@Operation) = 'I'
begin
	SET @Vencimiento = DATEADD(day, @Plazo, @Fecha )

	SET @SaldoActual = @MontoOriginal

	set @Cancelado = 0

	 
	insert dbo.cppCreditos ( IDProveedor ,  TipoDocumento, IDClase, IDSubTipo,Documento,Fecha, Vencimiento, Plazo,
	 MontoOriginal, FechaUltCredito, SaldoActual, 
	Cancelado, Anulado, ConceptoSistema, ConceptoUsuario, Usuario, TipoCambio,  flgOrigenExterno, flgAprobado, 
	IDMoneda, SubTotal,  Descuento ,SubTotalSinDescuento, ImpuestoIVA  ,ImpuestoConsumo ,Flete, Total  )

	values (
	@IDProveedor ,@TipoDocumento, @IDClase, @IDSubTipo,@Documento,@Fecha, @Vencimiento, @Plazo,
	@MontoOriginal,	@FechaUltCredito, @MontoOriginal, @Cancelado,  @Anulado, @ConceptoSistema, @ConceptoUsuario,
	 @Usuario, @TipoCambio, @flgOrigenExterno, @flgAprobado, 
	@IDMoneda, @SubTotal, @Descuento , @SubTotalDescuento, @ImpuestoIVA  ,@ImpuestoConsumo ,@Flete, @Total  
	)
	Set @IDCredito  = (SELECT SCOPE_IDENTITY())

	if @GeneraRetencion = 1 and @strIDRetenciones <>''
	begin
	---- Creamos las Retenciones 	
	exec dbo.cppCreaRetenciones @IDCredito, @strIDRetenciones
	-- falta generar contabliizacion 
	end -- Genera Retencion	
end

if upper(@Operation) = 'U'
begin
	Update dbo.cppCreditos set ConceptoUsuario = @ConceptoUsuario , Documento = @Documento,
	Fecha = @Fecha, MontoOriginal = @MontoOriginal,
	SubTotal = @SubTotal, 
	Descuento =@Descuento , SubTotalSinDescuento = @SubtotalDescuento, 
	ImpuestoIVA = @ImpuestoIVA  , ImpuestoConsumo =@ImpuestoConsumo ,Flete = @Flete,
	Total = @Total 
	where IDCredito  =  @IDCredito  and flgAprobado = 0 and flgOrigenExterno = 0 and Anulado = 0
end

if upper(@Operation) = 'D'
begin
set @Ok = 1
	if exists( Select IDAplicacion from dbo.cppAPLICACIONES (Nolock)  where IDCredito =  @IDCredito )
	begin
	RAISERROR ('Ud est· queriendo eliminar un documento que tiene Aplicaciones, primero elimÃnelas', 16, 10);
	set @Ok = 0
	end
	if  @Ok = 1
	Delete from dbo.cppCreditos where IDCredito  =  @IDCredito and flgAprobado = 0 and flgOrigenExterno = 0 and Anulado = 0
end

commit 
SELECT isnull(@IDCredito,0) IDCredito
Return isnull(@IDCredito,0)
end try
begin catch
    DECLARE @ErrorMessage NVARCHAR(4000);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;
	rollback
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
/*
 exec dbo.cppUpdatecppDebitos 'I', 0, 1, 'D', 'N/C', 5, 'NC0001', '20210105', 50, 0, 'PAGO', 'PAGO',
 'azepeda', 35.5555, 0, 0, 1, 0, 1, 1
 */
Create Procedure dbo.cppUpdatecppDebitos @Operation nvarchar(1),  @IDDebito int Output, 
@IDProveedor int    ,@TipoDocumento nvarchar(1) , @IDClase nvarchar(10), 
@IDSubTipo	int , @Documento nvarchar(20) , @Fecha datetime , @MontoOriginal decimal(28,4) ,
@PorcInteres decimal(8,2),@ConceptoSistema nvarchar(500),@ConceptoUsuario nvarchar(500),
@Usuario nvarchar(20), @TipoCambio decimal(28,4),  	@flgOrigenExterno bit ,
@flgAprobado bit,    @IDMoneda int = null, @Anulado bit = null, @IDCuentaBanco int = null
-- @Operation = I Nuevo, D Eliminar, F Modifica Fecha Credito
as
set nocount on
declare @Ok bit,  @SaldoActual  decimal(28,4) 

set @Ok = 0
begin transaction 
begin try

if @Anulado is null
	set @Anulado = 0
Select @flgAprobado = CASE WHEN AprobacionRequerida = 1 then  0 else 1 end 
From dbo.cppClaseDocumento 
Where IDClase = @IDClase

if upper(@Operation) = 'I'
begin

	SET @SaldoActual = @MontoOriginal
	
	insert dbo.cppDebitos ( IDProveedor ,  TipoDocumento, IDClase, IDSubTipo,Documento,Fecha,
	  MontoOriginal,  SaldoActual, 
	 PorcInteres, Anulado, ConceptoSistema, ConceptoUsuario, Usuario, TipoCambio,  flgOrigenExterno, flgAprobado, IDMoneda,
	 IDCuentaBanco 
	)
	values (
	@IDProveedor ,@TipoDocumento, @IDClase, @IDSubTipo,@Documento,@Fecha,
	@MontoOriginal,	 @SaldoActual,  @PorcInteres, @Anulado, @ConceptoSistema, @ConceptoUsuario,
	@Usuario, @TipoCambio , @flgOrigenExterno, @flgAprobado, @IDMoneda, @IDCuentaBanco
	)
	Set @IDDebito = (SELECT SCOPE_IDENTITY())
	
end
if upper(@Operation) = 'U'
begin
	Update dbo.cppDebitos  set ConceptoUsuario = @ConceptoUsuario , Documento = @Documento,
	Fecha = @Fecha, MontoOriginal = @MontoOriginal 
	where IDDebito   =  @IDDebito   and flgAprobado = 0 and flgOrigenExterno = 0 and Anulado = 0
end

if upper(@Operation) = 'D'
begin
set @Ok = 1
	if exists( Select IDAplicacion from dbo.cppAPLICACIONES (Nolock)  where IDDebito =  @IDDebito )
	begin
	RAISERROR ('Ud est∑ queriendo eliminar un documento que tiene Aplicaciones, primero elimÃnelas', 16, 10);
	set @Ok = 0
	end
	if  @Ok = 1
	Delete from dbo.cppDebitos where IDDebito  =  @IDDebito and flgAprobado = 0 and flgOrigenExterno = 0 and Anulado = 0
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


Create Table dbo.cppRetencion (IDRetencion int not null, Descr nvarchar (250), Porcentaje decimal (28,2) default 0, 
AplicaTotalFactura bit default 0, 
AplicaSubTotal bit default 0, 
AplicaSubTotalMenosDesc bit default 0,
IDCentroRet int, IDCuentaRet bigint, MontoMinimo decimal(28,2) default 0, Activo bit default 1  )
go

alter table dbo.cppRetencion add constraint pkRetencion primary key (IDRetencion)
go

alter table dbo.cppRetencion add constraint chkAplica check ((cast(AplicaTotalFactura as int) + cast(AplicaSubTotal as int) + cast(AplicaSubTotalMenosDesc as int ) = 1 ))
go

alter table dbo.cppRetencion add constraint fkRetCentro foreign key (IDCentroRet) references dbo.cntCentroCosto (IDCentro)
go
alter table dbo.cppRetencion add constraint fkRetCuenta foreign key (IDCuentaRet) references dbo.cntCuenta (IDCuenta)
go

Create table dbo.cppProveedorRetencion (IDProveedor int not null, IDRetencion int not null)
go

alter table dbo.cppProveedorRetencion add constraint pkProvRet primary key (IDProveedor, IDRetencion)
go
Create table dbo.cppRetenciones ( IDRetenciones int not null identity (1,1) ,
 IDProveedor int not null, IDCredito int not null,  IDRetencion int not null, 
Pagada bit default 0, FechaRetencion date, Monto decimal (28,4) default 0, 
Base decimal (28,4) default 0 )
go

alter table dbo.cppRetenciones add constraint ukRetenciones Unique (IDProveedor, IDCredito, IDRetencion, FechaRetencion )
go

alter table dbo.cppRetenciones add constraint fkRetProv foreign key (IDProveedor) references dbo.cppProveedor (IDProveedor)
go

alter table dbo.cppRetenciones add constraint fkRetCred foreign key (IDCredito) references dbo.cppCreditos (IDCredito)
go


--Select * from dbo.cppDebitos 
-- select * from  dbo.cppGetSaldoDocumento('C', '20210105', 1, 1)
Create FUNCTION dbo.cppGetSaldoDocumento ( @TipoDocumento nvarChar(1), @Fecha datetime, @IDDocumento int, @IDProveedor int  )
RETURNS @Resultado table (IDDocumento int, Fecha datetime, Vencimiento datetime,  IDMoneda int, Simbolo nvarchar(20), MontoOriginal decimal(28,4),
IDProveedor int, IDClase nvarchar(10), IDSubtipo int, Documento nvarchar(20), 
TipoCambioDocumento decimal(28,4), Nacional bit, MontoOriginalLocal decimal(28,4),
MontoOriginalDolar decimal(28,4), FechaCorte datetime,TipoCambioCorte decimal (28,4), CreditoLocal decimal(28,4), 
CreditoDolar decimal(28,4), SaldoLocal decimal(28,4),SaldoDolar decimal(28,4))
as
begin
Declare @TipoCambio decimal(28,4), @sTipoCambio nvarchar(20)
set @sTipoCambio = ( SELECT TOP 1 TipoCambioFact  FROM DBO.fafParametros  )
set @TipoCambio = (select  dbo.globalGetLastTipoCambio( @Fecha, @sTipoCambio ))
if @IDProveedor is null
	set @IDProveedor = 0
if UPPER(@TipoDocumento) = 'D'
BEGIN
	insert @Resultado (IDDocumento, Fecha,IDMoneda, Simbolo, MontoOriginal, IDProveedor, IDClase , IDSubtipo, Documento ,
	 TipoCambioDocumento, Nacional , MontoOriginalLocal , MontoOriginalDolar , FechaCorte ,TipoCambioCorte, CreditoLocal,
	CreditoDolar, SaldoLocal , SaldoDolar )
	SELECT  L.IDDEBITO IDDocumento, L.FECHA,  L.IDMonedaDebito , L.Simbolo, L.MONTOORIGINAL , L.IDProveedor, L.IDClase, L.IDSubTipo, L.Documento,
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
	SELECT D.IDDEBITO, D.FECHA,   D.MONTOORIGINAL , IDProveedor, IDClase, IDSubTipo, Documento, 
	TipoCambio TipoCambioDebito, 
	D.IDMoneda IDMonedaDebito, M.Nacional NacionalDebito, M.Simbolo, 
	case when M.Nacional = 1  then D.MONTOORIGINAL else  D.MONTOORIGINAL*D.TipoCambio   end  MontoOriginalLocal,
	case when M.Nacional = 0 then D.MONTOORIGINAL else D.MONTOORIGINAL/d.TipoCambio  end  MontoOriginalDolar
	FROM DBO.cppDEBITOS (NOLOCK) D inner join dbo.globalMoneda (NOLOCK) M
	on D.IDMONEDA = M.IDMoneda
	WHERE (IDDEBITO = @IDDocumento or @IDDocumento = 0) and (@IDProveedor =0 or IDProveedor = @IDProveedor) 
	and cast(D.Fecha as DATE) <= cast(@Fecha as DATE) and D.flgAprobado = 1 ) L 

	LEFT JOIN 
	(
	
	SELECT A.IDDEBITO,  MD.NACIONAL, 
	SUM(CASE WHEN MD.NACIONAL = 1 THEN A.MONTOCREDITO ELSE A.MONTOCREDITO * c.TipoCambio  END) CREDITOLOCAL,
	SUM(CASE WHEN MD.NACIONAL = 1 THEN A.MONTOCREDITO ELSE A.MONTOCREDITO * c.TipoCambio  END) / c.TipoCambio  AS CREDITODOLAR
	FROM DBO.cppAPLICACIONES (NOLOCK) A INNER JOIN dbo.cppCreditos (NOLOCK) C
	on A.IDCredito = C.IDCredito 	inner join dbo.globalMoneda (NOLOCK) MC
	on C.IDMoneda = MC.IDMoneda inner join dbo.cppDebitos (NOLOCK) D
	ON A.IDDEBITO = D.IDDEBITO INNER JOIN DBO.globalMoneda MD
	ON D.IDMONEDA = MD.IDMoneda 
	WHERE (A.IDDEBITO = @IDDocumento or @IDDocumento = 0) and (@IDProveedor =0 or D.IDProveedor = @IDProveedor)
	and cast(A.FechaCredito as DATE) <=cast(@Fecha as date) and C.flgAprobado = 1 and D.flgAprobado = 1 -- OJO COLEGIAR ESTA DECICION and A.flgFlotante = 0 and C.flgFlotante = 0
	GROUP BY A.IDDEBITO, MD.NACIONAL, C.TipoCambio 
	) R
	ON L.IDDEBITO = R.IDDebito 
	GROUP BY L.IDDEBITO , L.FECHA,  L.IDMonedaDebito , L.Simbolo, L.MONTOORIGINAL , L.IDProveedor, L.IDClase, L.IDSubTipo, L.Documento,
	 	L.TipoCambioDebito, L.NacionalDebito,L.MontoOriginalLocal , 
	    L.MontoOriginalDolar 
	--@Fecha ,@TipoCambio 
END

if UPPER(@TipoDocumento) = 'C'
BEGIN
	insert @Resultado (IDDocumento, Fecha, Vencimiento, IDMoneda, Simbolo, MontoOriginal, IDProveedor, IDClase , IDSubtipo, Documento ,
	 TipoCambioDocumento, Nacional , MontoOriginalLocal , MontoOriginalDolar , FechaCorte ,TipoCambioCorte, CreditoLocal,
	CreditoDolar, SaldoLocal , SaldoDolar )

	SELECT  L.IDCREDITO IDDocumento, L.FECHA,L.Vencimiento, L.IDMonedaCredito , L.Simbolo, CAST(L.MONTOORIGINAL AS DECIMAL(28,4)) MONTOORIGINAL , 
	L.IDProveedor, L.IDClase, L.IDSubTipo, L.Documento,
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
	SELECT D.IDCREDITO, D.FECHA, Vencimiento,  D.MONTOORIGINAL , IDProveedor, IDClase, IDSubTipo, Documento, 
	TipoCambio TipoCambioCredito, 
	D.IDMoneda IDMonedaCredito, M.Nacional NacionalCredito, M.Simbolo, 
	case when M.Nacional = 1  then D.MONTOORIGINAL else  D.MONTOORIGINAL*D.TipoCambio   end  MontoOriginalLocal,
	case when M.Nacional = 0 then D.MONTOORIGINAL else D.MONTOORIGINAL/D.TipoCambio  end  MontoOriginalDolar
	FROM DBO.cppCreditos D inner join dbo.globalMoneda (NOLOCK) M
	on D.IDMONEDA = M.IDMoneda
	WHERE (IDCredito = @IDDocumento or @IDDocumento = 0) and (@IDProveedor=0 or IDProveedor = @IDProveedor)
	and cast(D.Fecha as date) <= cast(@Fecha as date) and D.flgAprobado = 1 --and D.flgFlotante = 0
	) L

	LEFT JOIN 
	(
	SELECT A.IDCredito, MC.NACIONAL, 
	SUM(CASE WHEN MD.NACIONAL = 1 THEN A.MONTOCREDITO ELSE A.MONTOCREDITO * C.TipoCambio  END) CREDITOLOCAL,
	SUM(CASE WHEN MD.NACIONAL = 1 THEN A.MONTOCREDITO ELSE A.MONTOCREDITO * C.TipoCambio  END) / C.TipoCambio  AS CREDITODOLAR
	FROM DBO.cppAPLICACIONES A INNER JOIN dbo.cppCreditos (NOLOCK) C
	on A.IDCredito = C.IDCredito 	inner join dbo.globalMoneda (NOLOCK) MC
	on C.IDMoneda = MC.IDMoneda inner join dbo.cppDebitos (NOLOCK) D
	ON A.IDDEBITO = D.IDDEBITO INNER JOIN DBO.globalMoneda MD
	ON D.IDMONEDA = MD.IDMoneda 
	WHERE (A.IDCredito = @IDDocumento or @IDDocumento = 0) and (@IDProveedor=0 or C.IDProveedor = @IDProveedor)
	and cast(A.FechaCredito as DATE) <=cast(@Fecha as date) and D.flgAprobado = 1 and C.flgAprobado = 1  --and A.flgFlotante = 0 and C.flgFlotante = 0
	GROUP BY A.IDCREDITO, MC.NACIONAL, C.TipoCambio 
	) R
	ON L.IDCREDITO = R.IDCREDITO
	GROUP BY L.IDCREDITO , L.FECHA,L.Vencimiento, L.IDMonedaCredito , L.Simbolo, CAST(L.MONTOORIGINAL AS DECIMAL(28,4))  , 
	L.IDProveedor, L.IDClase, L.IDSubTipo, L.Documento,
	L.TipoCambioCredito, L.NacionalCredito,  L.MontoOriginalLocal  , 
	L.MontoOriginalDolar  
END
return 
END	
go	
-- exec [dbo].[cppUpdateAplicaciones] 'I', 2,2, 10, 'azepeda', 35.5555
CREATE PROCEDURE [dbo].[cppUpdateAplicaciones]
-- 'I' insertar  'S' Actualizar Saldos de Debitos y Creditos en Aplicaciones
@Operation nvarchar(1), @IDDocDebito int, @IDDocCredito int, @MontoPago decimal(28,4),
@Usuario nvarchar(20), @TipoCambio decimal(28,4) 

as
set nocount on
Declare	@IDAplicacion int , @Fecha datetime, @Vencimiento datetime, @FechaCredito datetime, @MontoDebitoAnt decimal(28,4), 
	@MontoDebitoAct decimal(28,4), @MontoCreditoAnt decimal(28,4),  @MontoCreditoAct decimal(28,4),  
	@MontoCredito decimal(28,4) , @IDDocumentoCC int, @ValorInteres decimal(28,4),
	@IDProveedor int  ,@IDBodega int  ,@TipoDocumento nvarchar(1) ,
	@IDSubTipo	int , @Documento nvarchar(20) , 
	@MontoOriginal decimal(28,4) ,@FechaUltCredito datetime , @FechaUltCreditoEnDebito datetime ,
	@SaldoActual  decimal(28,4) ,@Cancelado bit ,@PorcInteres decimal(8,2),@Anulado bit,
	@Hoy datetime, @DiasVencidos int, 
	@SaldoAnteriorDebito decimal(28,4) , @SaldoActualDebito decimal(28,4),
	@SaldoAnteriorCredito decimal(28,4), @SaldoActualCredito decimal(28,4), @SaldoAnterior decimal(28,4),
	@DocDebito nvarchar(20), @DocCredito NVARCHAR(20), @Plazo int

IF @Operation = 'I'
BEGIN

if not exists ( Select IDCredito From dbo.cppCreditos Where IDCredito = @IDDocCredito )
begin
    RAISERROR ('EL ID DEL CREDITO NO EXISTE', -- Message text.
               16, --@ErrorSeverity, -- Severity.
               16--@ErrorState -- State.
               );
               RETURN
end

Select @Hoy = getdate(), @FechaCredito=Fecha,  @DocCredito = DOCUMENTO, 
	 @Fecha= Fecha, @SaldoActual = isnull(SaldoActual,0), @FechaUltCredito  = isnull(FechaUltCredito ,'19800101' )
From dbo.cppCreditos (NOLOCK)
where IDCredito = @IDDocCredito AND TIPODOCUMENTO = 'C' --) --(select getdate())
SELECT @DocDebito = Documento
From dbo.cppDebitos (NOLOCK)
where IDDebito  = @IDDocDebito AND TIPODOCUMENTO = 'D'

set @MontoCreditoAct = ( Select case when Nacional = 1 then SaldoLocal else SaldoDolar end From dbo.[cppGetSaldoDocumento] ('D', @Hoy,@IDDocDebito , 0 ) )
set @MontoCredito = @MontoPago
set @SaldoActual = ( select case when Nacional = 1 then SaldoLocal else SaldoDolar end  From dbo.[cppGetSaldoDocumento] ('C', @Hoy,@IDDocCredito, 0 ) )

if (@SaldoActual <= 0 or @MontoCreditoAct  <= 0 ) 
	return -- saldo actual del debito o el Credito es cero... debe salir y no hacer nada
	
set @SaldoAnteriorCredito = isnull(@MontoCreditoAct,0)
set @SaldoAnteriorDebito = @SaldoActual
set @SaldoActualDebito = @SaldoActual - @MontoPago
set @SaldoActualCredito = @SaldoAnteriorCredito - @MontoPago	

insert dbo.cppAplicaciones ( IDDebito,  IDCredito,DocDebito, DocCredito,  Fecha,  FechaCredito , MontoCredito
 )	
values (@IDDocDebito, @IDDocCredito,@DocDebito, @DocCredito, @Hoy,   @FechaCredito, @MontoPago 
 	)	

Update dbo.cppCreditos set SaldoActual = @SaldoActualDebito,FechaUltCredito = @FechaCredito ,
Cancelado = CASE WHEN @SaldoActualDebito = 0 THEN 1 ELSE 0 END  where IDCredito  = @IDDocCredito 
Update dbo.cppDebitos  set SaldoActual = @SaldoActualCredito
 where IDDebito   = @IDDocDebito
	
END
return 

GO

-- select * from dbo.cppGetDocumentosxPagar (1, '20210101', 0)
CREATE   FUNCTION dbo.cppGetDocumentosxPagar ( @IDProveedor int, @FechaCorte datetime, @IDCredito int) 
RETURNS TABLE
RETURN
SELECT IDDOCUMENTO IDCREDITO, IDCLASE,IDSUBTIPO, IDMoneda, Simbolo, Nacional, Documento,  Fecha, Vencimiento, 
(select datediff(day, Vencimiento,@FechaCorte )) DiasVencidos,
MontoOriginalLocal TotalDebitoLocal, MontoOriginalDolar TotalDebitoDolar,  IDProveedor , TipoCambioCorte , 
SaldoLocal , SaldoDolar
FROM  dbo.cppGetSaldoDocumento('C', @FechaCorte, @IDCredito, @IDProveedor ) D 
Where (D.IDProveedor = @IDProveedor or @IDProveedor = 0) and SaldoLocal <> 0 and saldodolar <> 0
go

--select * from cppGetDocumentosxPagar(4, '20210115', 0) exec dbo.cpprptAntiguedadSaldosPorProveedor 0, '20210120', 1
Create Procedure dbo.cpprptAntiguedadSaldosPorProveedor @IDProveedor  Int, @FechaCorte DATETIME, 
 @EnDolar bit = null
as
declare @TipoCambio as decimal(18,4), @IDTipoCambioFactura nvarchar(20)
declare  @Resultados as table (  IDDebito int, IDClase nvarchar(10), IDSubtipo int, Fecha datetime, Vencimiento datetime,
DiasVencidos int, TotalDebito decimal(28,4), IDCredito int, IDProveedor  nvarchar(20), Nombre nvarchar(255),
Saldo decimal(28,4), Nacional bit 
)

declare  @ResultadoDetallado as table ( 
IDProveedor  nvarchar(20), Nombre nvarchar(255),
SaldoNovencido decimal(28,4) default 0,  
Saldoa30 decimal(28,4) default 0,
Saldo31a60 decimal(28,4) default 0,
Saldo61a90 decimal(28,4) default 0,
Saldo91a120 decimal(28,4) default 0,
Saldo121a180 decimal(28,4) default 0,
Saldo181a600 decimal(28,4) default 0,
Saldomas600 decimal(28,4) default 0, 
TotalProveedor decimal(28,4) default 0 
)

set nocount on 
set @IDTipoCambioFactura = (Select top 1 IDTipoCambio  from dbo.globaltipocambio )
if @EnDolar is null
	set @EnDolar = 0

	select @TipoCambio=( SELECT dbo.[globalGetLastTipoCambio] (@FechaCorte, @IDTipoCambioFactura))	


	
Insert @Resultados (IDCredito , IDClase , IDSubtipo , Fecha , Vencimiento, DiasVencidos, 
TotalDebito, IDProveedor, Nombre,  Saldo, Nacional )
SELECT D.IDCredito , D.IDClase , D.IDSubtipo , D.Fecha , D.Vencimiento, D.DiasVencidos, 
case when Nacional = 1 then TotalDebitoLocal else TotalDebitoDolar end TotalDebito,
 D.IDProveedor,C.Nombre,  
case when Nacional = 1 then  SaldoLocal    else SaldoDolar end Saldo, Nacional 
FROM  dbo.cppGetDocumentosxPagar(@IDProveedor, @FechaCorte, 0) D INNER JOIN dbo.cppProveedor  C
ON D.IDProveedor = C.IDProveedor 

if @EnDolar = 1
	Update @Resultados 
	set Saldo = case when @EnDolar = 1 and Nacional = 1  
	then  Saldo / @TipoCambio  
	else 
	case when @EnDolar = 1 and Nacional = 0
	then
	Saldo
	else
	case when @EnDolar = 0 and Nacional = 0
	then
	Saldo * @TipoCambio
	else
	case when @EnDolar = 0 and Nacional =1
	then
	Saldo
	end
	end
	end
	end

	insert @ResultadoDetallado (  IDProveedor ,NOMBRE,SaldoNovencido,
	Saldoa30,Saldo31a60,Saldo61a90,
	Saldo91a120,Saldo121a180,Saldo181a600,Saldomas600, TotalProveedor)
	SELECT  IDProveedor ,NOMBRE, SUM(ISNULL(SaldoNovencido,0)) SaldoNovencido,
	SUM(ISNULL(Saldoa30,0)) Saldoa30,
	SUM(ISNULL(Saldo31a60,0)) Saldo31a60,
	SUM(ISNULL(Saldo61a90,0)) Saldo61a90,  
	SUM(ISNULL(Saldo91a120,0)) Saldo91a120,  
	SUM(ISNULL(Saldo121a180,0)) Saldo121a180,
	SUM(ISNULL(Saldo181a600,0)) Saldo181a600,
	SUM(ISNULL(Saldomas600,0)) Saldomas600,
	SUM(ISNULL(SaldoNovencido,0)+ ISNULL(Saldoa30,0)+ ISNULL(Saldo31a60,0)+ ISNULL(Saldo61a90,0)+
	ISNULL(Saldo91a120,0)+ISNULL(Saldo121a180,0)+ISNULL(Saldo181a600,0)+ISNULL(Saldomas600,0)) TotalProveedor
	FROM (
	SELECT  IDProveedor ,NOMBRE, RANGO, case when rango = 'NO-VENC' then SUM(Saldo) ELSE 0 end SaldoNovencido,
	case when rango = '1-30' then SUM(Saldo) ELSE 0 end Saldoa30,
	case when rango = '31-60' then SUM(Saldo) ELSE 0 end Saldo31a60,
	case when rango = '61-90' then SUM(Saldo) ELSE 0 end Saldo61a90,
	case when rango = '91-120' then SUM(Saldo) ELSE 0 end Saldo91a120,
	case when rango = '121-180' then SUM(Saldo) ELSE 0 end Saldo121a180,
	case when rango = '181-600' then SUM(Saldo) ELSE 0 end Saldo181a600,
	case when rango = '+600' then SUM(Saldo) ELSE 0 end Saldomas600    
	FROM 
	(
	SELECT  a.IDProveedor , a.Nombre Nombre, a.DiasVencidos,  
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
	GROUP BY  IDProveedor , NOMBRE, RANGO
	) T2
	GROUP BY  IDProveedor , NOMBRE
	HAVING SUM(ISNULL(SaldoNovencido,0)+ ISNULL(Saldoa30,0)+ ISNULL(Saldo31a60,0)+ ISNULL(Saldo61a90,0)+
	ISNULL(Saldo91a120,0)+ISNULL(Saldo121a180,0)+ISNULL(Saldo181a600,0)+ISNULL(Saldomas600,0)) > 0
	

	Select IDProveedor ,NOMBRE, SaldoNovencido, Saldoa30, Saldo31a60, Saldo61a90, Saldo91a120, Saldo121a180, Saldo181a600,
	Saldomas600, TotalProveedor
	From @ResultadoDetallado

go
-- exec dbo.cpprptAntiguedadSaldosEmpresa  1, '20210101'
Create Procedure dbo.cpprptAntiguedadSaldosEmpresa  @IDProveedor  Int, @FechaCorte DATETIME, 
 @EnDolar bit = null
as
declare  @ResultadoDetallado as table ( 
IDProveedor  nvarchar(20), Nombre nvarchar(255),
SaldoNovencido decimal(28,4) default 0,  
Saldoa30 decimal(28,4) default 0,
Saldo31a60 decimal(28,4) default 0,
Saldo61a90 decimal(28,4) default 0,
Saldo91a120 decimal(28,4) default 0,
Saldo121a180 decimal(28,4) default 0,
Saldo181a600 decimal(28,4) default 0,
Saldomas600 decimal(28,4) default 0, 
TotalProveedor decimal(28,4) default 0 
)


Insert @ResultadoDetallado ( IDProveedor, Nombre, SaldoNovencido, Saldoa30, Saldo31a60,
Saldo61a90, Saldo91a120, Saldo121a180, Saldo181a600, Saldomas600, TotalProveedor )
exec dbo.cpprptAntiguedadSaldosPorProveedor @IDProveedor, @FechaCorte, @EnDolar

Select 'Total Empresa' SaldoEmpresa, sum( SaldoNovencido) SaldoNovencido, sum(Saldoa30) Saldoa30, sum(Saldo31a60) Saldo31a60, 
sum(Saldo61a90) Saldo61a90, sum(Saldo91a120) Saldo91a120, sum(Saldo121a180) Saldo121a180, sum(Saldo181a600) Saldo181a600 ,
sum(Saldomas600) Saldomas600, sum(TotalProveedor) TotalProveedor
From @ResultadoDetallado
go


Create VIEW DBO.vcppMovimientos
as 
SELECT IDDOCUMENTO, IDPROVEEDOR, TIPODOCUMENTO, IDCLASE,IDSubTipo, DOCUMENTO, FECHA, VENCIMIENTO, PLAZO, MONTOORIGINAL,
SALDOACTUAL, CANCELADO, PORCINTERES, ANULADO, CONCEPTOSISTEMA, CONCEPTOUSUARIO, TIPOCAMBIO, V.ORDEN, Asiento, flgAprobado , flgOrigenExterno, Contabilizado, IDMoneda,DescrMoneda, Nacional
FROM (
select IDDEBITO IDDOCUMENTO, IDPROVEEDOR,  D.TIPODOCUMENTO, D.IDCLASE, IDSubTipo, DOCUMENTO, FECHA, '20700101' VENCIMIENTO, 0 PLAZO, MONTOORIGINAL,
SALDOACTUAL, 0 CANCELADO, PORCINTERES, ANULADO, CONCEPTOSISTEMA, CONCEPTOUSUARIO, TIPOCAMBIO, Asiento, flgAprobado, flgOrigenExterno, Contabilizado, D.IDMoneda,
M.Moneda DescrMoneda, M.Nacional, C.Orden 
from dbo.cppdebitos (NoLock) D inner join dbo.globalMoneda (NoLock) M
on D.IDMoneda = M.IDMoneda INNER JOIN DBO.cppCLASEDOCUMENTO (NoLock) C
ON D.IDCLASE = C.IDCLASE 
UNION ALL
select IDCREDITO IDDOCUMENTO, IDPROVEEDOR, Cr.TIPODOCUMENTO, Cr.IDCLASE, IDSubTipo, DOCUMENTO, FECHA,  VENCIMIENTO, 0 PLAZO, MONTOORIGINAL,
SALDOACTUAL, CANCELADO,0 PORCINTERES, ANULADO, CONCEPTOSISTEMA, CONCEPTOUSUARIO, TIPOCAMBIO, Asiento, flgAprobado, flgOrigenExterno, Contabilizado, Cr.IDMoneda,
M.Moneda DescrMoneda, M.Nacional, 0 Orden 
from dbo.cppCreditos (NoLock)  Cr INNER JOIN DBO.cppCLASEDOCUMENTO (NoLock) C
ON Cr.IDCLASE = C.IDCLASE  inner join dbo.globalMoneda (NoLock) M
on Cr.IDMoneda = M.IDMoneda 
) v
GO

-- exec dbo.cpprptMovimientos 2, '20210101', '20210320'
CREATE Procedure dbo.cpprptMovimientos  @IDProveedor  Int, @FECHAINICIAL DATETIME, @FECHAFINAL DATETIME
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
FROM  dbo.[cppGetSaldoDocumento]('D', @Fecha, 0, @IDProveedor ) D
wHERE IDPROVEEDOR = @IDProveedor
GROUP BY IDPROVEEDOR 

Select @SaldoInicialCreditoLocal = isnull(SUM(SALDOLOCAL),0) , @SaldoInicialCreditoDolar = ISNULL( SUM(SALDODOLAR) ,0)
FROM  dbo.[cppGetSaldoDocumento]('C', @Fecha, 0, @IDProveedor ) D
wHERE IDProveedor = @IDProveedor
GROUP BY IDProveedor 

Set @SaldoInicialLocal = isnull(@SaldoInicialCreditoLocal,0) - isnull(@SaldoInicialDebitoLocal,0)

Set @SaldoInicialDolar = isnull(@SaldoInicialCreditoDolar,0)  - isnull(@SaldoInicialDebitoDolar,0)

insert @Resultado(IDClase, Documento, Fecha, Vencimiento, Nacional,  TipoCambio, MontoLocal,MontoDolar , 
Orden, ConceptoSistema, ConceptoUsuario, DescrMoneda  )
select D.IDCLASE,  D.DOCUMENTO, D.FECHA, D.VENCIMIENTO, D.Nacional,D.TipoCambio, 
CASE WHEN Nacional = 1 THEN D.MONTOORIGINAL ELSE D.MONTOORIGINAL * D.TipoCambio END * (case when TipoDocumento= 'C' then 1 else -1 end) MONTOLOCAL,
(CASE WHEN Nacional = 1 THEN D.MONTOORIGINAL ELSE D.MONTOORIGINAL * D.TipoCambio END / D.TipoCambio ) * (case when TipoDocumento= 'C' then 1 else -1 end) MONTODOLAR,
 D.ORDEN , D.ConceptoSistema, D.ConceptoUsuario, D.DescrMoneda 
--into #Resultado select * from DBO.vcppMovimientos
from DBO.vcppMovimientos D 
WHERE D.ANULADO = 0 and IDProveedor  = @IDProveedor  AND D.FECHA BETWEEN @FECHAINICIAL AND @FECHAFINAL
ORDER BY D.FECHA, D.IDCLASE,D.ORDEN

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
	from @Resultado R inner join dbo.cppClaseDocumento C
	on R.IDClase = C.IDClase
Union all
Select 'SALDO' iDClase,'FINAL' Documento, '' DescrClase, dateadd(hour, 6, @FECHAFINAL) Fecha, '20500101'  Vencimiento, CAST ( ISNULL((@SaldoInicialLocal + @TotalMovimientosLocal ),0) as decimal(28,4)) Monto, @TotalMovimientosDolar  MONTODOLAR,
'SALDO FINAL al ' + CONVERT(NVARCHAR(30), @FECHAFINAL  , 103) ConceptoSistema, '' ConceptoUsuario, 1000 orden, '' DescrMoneda, 0 TipoCambio
) X
order by  X.Fecha,X.IDClase, x.Orden 

go

-- exec dbo.cppDocumentosxPagar 1, '20210130', 0
create Procedure dbo.cppDocumentosxPagar  @IDProveedor  Int, @FECHACORTE DATETIME, @IDCredito int 
as
SET NOCOUNT ON 
declare @TipoCambio as decimal(18,4), @IDTipoCambioFactura nvarchar(20)
set @IDTipoCambioFactura = (Select top 1 IDTipoCambio  from dbo.globaltipocambio )
select @TipoCambio=( SELECT dbo.[globalGetLastTipoCambio] (@FechaCorte, @IDTipoCambioFactura))

Declare @Resultado as table (IDCredito int, IDClase nvarchar(10), IDSubTipo int, Simbolo nvarchar(10), Documento nvarchar(20),
Fecha datetime, Vencimiento datetime, DiasVencidos int, Saldo decimal (28, 4), 
SaldoDolar decimal (28, 4) )
Declare @SaldoVencidoLocal decimal (28, 4), @SaldoVencidoDolar decimal (28, 4),
@SaldoNoVencidoLocal decimal (28, 4), @SaldoNoVencidoDolar decimal (28, 4) 
Declare @SaldoCreditoLocal decimal (28, 4), @SaldoCreditoDolar decimal (28, 4)

select @SaldoCreditoLocal = SaldoLocal, @SaldoCreditoDolar = SaldoDolar
FROM dbo.cppGetSaldoDocumento('C', @FECHACORTE, 0,@IDProveedor ) D


insert @Resultado(IDCredito, IDCLASE, IDSUBTIPO, Simbolo, DOCUMENTO, Fecha, Vencimiento, DIASVENCIDOS, 
 SALDO, SaldoDolar)
SELECT IDCREDITO , IDCLASE, IDSUBTIPO, Simbolo,  DOCUMENTO, Fecha, Vencimiento, DIASVENCIDOS, 
SaldoLocal SALDO, SaldoDolar
FROM DBO.cppGetDocumentosxPagar( @IDProveedor, @FECHACORTE, @IDCredito ) A
ORDER BY VENCIMIENTO ASC

SELECT @SaldoNoVencidoLocal = ISNULL(SUM(CASE WHEN DiasVencidos <= 0 THEN SALDO END ),0),
@SaldoNoVencidoDolar = ISNULL(SUM(CASE WHEN DiasVencidos <= 0 THEN SaldoDolar END ),0),
@SaldoVencidoDolar = ISNULL(SUM(CASE WHEN DiasVencidos >0 THEN SaldoDolar  END ),0),
@SaldoVencidoLOCAL = ISNULL(SUM(CASE WHEN DiasVencidos > 0 THEN SALDO END ),0)
FROM @Resultado

SELECT IDCREDITO, IDCLASE, IDSUBTIPO, DOCUMENTO, Simbolo, Fecha, Vencimiento, DIASVENCIDOS, 
SALDO, SaldoDolar, 
@SaldoNoVencidoLocal SaldoNoVencidoLocal, @SaldoNoVencidoDolar SaldoNoVencidoDolar,
@SaldoVencidoLOCAL SaldoVencidoLOCAL, @SaldoVencidoDOLAR SaldoVencidoDOLAR, @TipoCambio TipoCambioCorte,
isnull(@SaldoCreditoLocal,0) SaldoCreditoAFavorLocal, isnull(@SaldoCreditoDolar,0) SaldoCreditoAFavorDolar
FROM @Resultado 
ORDER BY VENCIMIENTO ASC
GO 
-- exec dbo.cppPagarDocumentosxPagar 1, '20210101', 0	
Create  PROCEDURE dbo.cppPagarDocumentosxPagar @IDProveedor  Int, @FECHACORTE DATETIME, @IDCredito int 
as 

set nocount on
SELECT IDCredito, IDClase, IDSubTipo, Documento, Fecha, A.IDMoneda, M.Descr DescrMoneda,  Vencimiento, DiasVencidos,
case when A.Nacional = 1 then SaldoLocal else SaldoDolar end Saldo, 
 0.00 Abono
FROM DBO.cppGetDocumentosxPagar( @IDProveedor, @FECHACORTE, @IDCredito ) A inner join
dbo.globalMoneda M on A.IDMoneda = M.IDMoneda 
order by Vencimiento 

go

--exec dbo.cpprptDesglosePagos  2, '20210101', '20210108'
create PROCEDURE dbo.cpprptDesglosePagos @IDProveedor  Int,  @FECHAINICIAL DATETIME, @FECHAFINAL DATETIME
as
set nocount on 

Declare @Resultado table ( IDProveedor int, IDDebito int, IDClaseDebito nvarchar(10),
IDSubTipoDebito int,  DocDebito nvarchar(20), FechaDebito datetime, NacionalDebito bit, MonedaDebito nvarchar(20),
IDCredito int,IDClaseCredito nvarchar(10),IDSubTipoCredito int,FechaCredito datetime,  NacionalCredito bit, MonedaCredito nvarchar(20), 
DocCredito nvarchar(20), Vencimiento datetime, DiasVencidos int,
FechaPago datetime, Aplicado decimal(28,4), AplicadoDolar decimal(28,4) )

INSERT  @Resultado ( IDProveedor , IDDebito , IDClaseDebito,  IDSubTipoDebito, DocDebito, FechaDebito, NacionalDebito, MonedaDebito, 
IDCredito,  IDClaseCredito , IDSubTipoCredito, FechaCredito, NacionalCredito, MonedaCredito, 
DocCredito, Vencimiento, DiasVencidos, 
FechaPago, Aplicado, AplicadoDolar )
SELECT  D.IDProveedor, D.IDDebito, D.IDClase IDClaseDebito, D.IDSubTipo, A.DocDebito, D.Fecha, MD.Nacional, md.Moneda,
C.IDCredito, C.IDClase, C.IDSubTipo, C.Fecha, MC.Nacional, MC.Moneda, A.docCredito, C.Vencimiento, 
DATEDIFF( day , C.Vencimiento , a.FechaCredito )  DiasVencidos,
A.FechaCredito FechaPago,
	CASE WHEN MC.NACIONAL = 1 THEN A.MONTOCREDITO ELSE A.MONTOCREDITO * C.TipoCambio END APLICADO,
	CASE WHEN MC.NACIONAL = 1 THEN A.MONTOCREDITO ELSE A.MONTOCREDITO * C.TipoCambio END / C.TipoCambio AS APLICADODOLAR
	FROM DBO.cppAPLICACIONES A INNER JOIN dbo.cppCreditos (NOLOCK) C
	on A.IDCredito = C.IDCredito 	inner join dbo.globalMoneda (NOLOCK) MC
	on C.IDMoneda = MC.IDMoneda inner join dbo.cppDebitos (NOLOCK) D
	ON A.IDDEBITO = D.IDDEBITO INNER JOIN DBO.globalMoneda MD
	ON D.IDMONEDA = MD.IDMoneda 
WHERE (C.IDProveedor =  @IDProveedor OR @IDProveedor = 0) AND 
cast(A.FechaCredito as DATE )  BETWEEN @FECHAINICIAL AND @FECHAFINAL
order by c.Vencimiento desc

SELECT R.IDProveedor, IDClaseDebito,   R.IDDebito, R.FechaDebito, FechaCredito,  TotalDebito,
NACIONALCREDITO, MonedaCredito , NACIONALDEBITO, MonedaDebito , 
IDCredito, IDClaseCredito, IDSUBTIPOCredito, DOCCREDITO, DOCDEBITO, R.FechaPago, VENCIMIENTO, DiasVencidos ,
APLICADO, APLICADODOLAR
FROM @Resultado R inner join 
	(Select IDDebito, SUM(case when NacionalDebito  = 1 then APLICADO else APLICADODOLAR end ) TotalDebito From @Resultado Group by IDDebito ) T
on R.IDDebito = T.IDDebito 
ORDER BY R.FechaPago, Vencimiento

GO
--exec  dbo.cppGetDocumento  'C', 2
Create  Procedure dbo.cppGetDocumento @Tipo nvarchar(1), @IDDocumento int 
as
set nocount on 
if upper(@Tipo) = 'D'
begin
	Select IDDebito, D.IDProveedor ,  C.Nombre, 
	D.TipoDocumento, D.IDClase , L.Descr  DescrClase,  D.IDSubTipo 
	,D.IDMoneda, M.Descr DescrMoneda, 0 Plazo, cast('20500101' as DATE)  Vencimiento,
	Documento, Fecha, MontoOriginal, SaldoActual,  Anulado, ConceptoSistema, 
	ConceptoUsuario, Contabilizado, Asiento, flgAprobado, flgOrigenExterno, Usuario
	from dbo.cppDebitos D inner join dbo.cppProveedor  C
	on D.IDProveedor = C.IDProveedor 
	inner join dbo.globalMoneda M
	on D.IDMoneda = M.IDMoneda inner join dbo.cppClaseDocumento L
	on D.IDClase = L.IDClase 
	Where IDDebito =@IDDocumento 
end
if upper(@Tipo) = 'C'
begin
	Select IDCredito, D.IDProveedor, C.Nombre ,  
	 D.TipoDocumento, D.IDClase, L.Descr  DescrClase, IDSubTipo , 
	D.IDMoneda,  M.Descr DescrMoneda,
	Documento, Fecha, MontoOriginal, SaldoActual, Anulado, ConceptoSistema, ConceptoUsuario, 
	Contabilizado, Asiento, Usuario, flgAprobado, flgOrigenExterno , Usuario, z.IDCondicionPago Plazo  ,
	D.SubTotal,  D.Descuento, D.SubTotalSinDescuento, D.impuestoIVA, D.ImpuestoConsumo, D.Flete, D.Total 
	From dbo.cppCreditos D inner join dbo.cppProveedor  C
	on D.IDProveedor = C.IDProveedor 
	inner join dbo.globalMoneda M
	on D.IDMoneda = M.IDMoneda inner join dbo.cppClaseDocumento L
	on D.IDClase = L.IDClase left join dbo.cppCondicionPago Z
	on cast(D.Plazo as int )  = cast(Z.Dias   as int )
	where IDCredito = @IDDocumento 
end
go


--exec DBO.cppgetSubTipo 4
Create procedure dbo.cppgetSubTipo (@IDSubTipo int )
as
set nocount on 

SELECT IDSubTipo, TipoDocumento, Descr, IDClase, SubTipoGeneraAsiento, NaturalezaCta, CtaDebito, CtaCredito,
ContraCtaEnSubTipo,  SysReadOnly 
FROM DBO.cppSubTipoDocumento 
Where IDSubTipo = @IDSubTipo
go
-- Select * from dbo.cppGetSaldoDocumentos ('20210101')
Create  FUNCTION dbo.cppGetSaldoDocumentos (  @Fecha datetime)
RETURNS table 
RETURN 


	-- saldo de un Debito
	SELECT IDProveedor , IDClase, IDSubTipo, IDDocumento, IDMoneda, Documento, Nacional, FechaCorte, 
	TipoCambioCorte, MontoOriginalLocal,MontoOriginalDolar,  
	CreditoLocal, CreditoDolar, SaldoLocal, SaldoDolar
	FROM dbo.cppGetSaldoDocumento('C', @Fecha, 0,0 ) D
	UNION ALL
	-- saldo de un Credito
	SELECT IDProveedor , IDClase, IDSubTipo, IDDocumento, IDMoneda, Documento, Nacional, FechaCorte, 
	TipoCambioCorte, MontoOriginalLocal,MontoOriginalDolar,  
	CreditoLocal, CreditoDolar, SaldoLocal, SaldoDolar
	FROM dbo.cppGetSaldoDocumento('D', @Fecha, 0,0 ) D
go

--exec dbo.cppGetMovimientos 1, '20210101', '20210105', '*', '*', 0, -1, -1, -1, -1
Create procedure dbo.cppGetMovimientos  @IDProveedor int,  @FechaInic datetime, @FechaFin datetime, @Documento nvarchar(20),
@IDClase nvarchar(10), @IDSubTipo int, @flgAprobado int,  @Anulado int, @flgSaldoMayorCero int = -1,  @Contabilizado int
as
set nocount on 
Select M.IDDOCUMENTO IDDocumento, M.TipoDocumento , M.IDProveedor, C.Nombre, M.IDClase, M.IDSubTipo, S.Descr SubTipo, M.Documento, M.Fecha, m.Vencimiento, M.MontoOriginal,
case when m.TipoDocumento = 'D' then case when D.Nacional = 1 then  isnull(D.SaldoLocal,0) else isnull(D.SaldoDolar,0) end else 0 end  SaldoDebito, 
case when m.TipoDocumento = 'C' then  case when Cr.Nacional = 1 then  isnull(Cr.SaldoLocal,0) else isnull( Cr.SaldoDolar,0)  end else 0 end SaldoCredito, 
M.Anulado, M.ConceptoSistema, M.ConceptoUsuario, M.TipoCambio, M.Asiento,  M.flgAprobado Aprobado, 
M.flgOrigenExterno OrigenExterno, M.IDMoneda, N.Descr DescrMoneda
From DBO.vcppMovimientos M inner join dbo.cppSubTipoDocumento S
on M.IDSubTipo = S.IDSubTipo and M.IDClase = S.IDClase 
inner join dbo.cppProveedor  C 
on M.IDProveedor = C.IDProveedor inner join dbo.globalMoneda N
on M.IDMoneda = N.IDMoneda 
outer apply dbo.cppGetSaldoDocumento ('D', GETDATE(), M.IDDOCUMENTO, M.IDProveedor ) D
outer apply dbo.cppGetSaldoDocumento ('C', GETDATE(), M.IDDOCUMENTO, M.IDProveedor ) Cr
Where (M.IDProveedor = @IDProveedor or @IDProveedor = 0 )  
and M.Fecha between (case when @FechaInic IS NULL then '19800101' else @FechaInic end )
and (case when @FechaFin IS NULL then '20600101' else @FechaFin end )
and (M.IDClase=@IDClase or (@IDClase = '*' ))
and (M.Documento=@Documento or (@Documento = '*' ))
and (M.IDSubTipo =@IDSubTipo  or (@IDSubTipo = 0))
and (@flgAprobado = -1 or  M.flgAprobado = @flgAprobado )
and (@Anulado = -1 or M.Anulado = @Anulado )
and ((@flgSaldoMayorCero = 1 and M.SaldoActual >0 ) or (@flgSaldoMayorCero = 0 and M.SaldoActual <=0) or (@flgSaldoMayorCero = -1))
and (M.Contabilizado   = @Contabilizado  or @Contabilizado = -1)
Order by M.IDPROVEEDOR, M.FECHA, M.ORDEN --M.IDClase, m.DOCUMENTO
go

-- exec dbo.cppgetAplicacion 5
Create Procedure dbo.cppgetAplicacion @IDDebito int 
as
set nocount on 
Select A.IDAplicacion, A.IDCredito , C.IDClase ClaseCredito , M.IDMoneda, M.Descr DescrMoneda,  DocCredito, 
FechaCredito, C.Vencimiento ,C.SaldoActual SaldoCredito ,
A.IDDebito IDDocumento,  D.IDClase ClaseDebito ,  'D' TipoDocumento, DocDebito, A.Fecha, 
MontoCredito MontoPago
From dbo.cppAplicaciones A inner join dbo.cppDebitos D
on A.IDDebito = D.IDDebito inner join dbo.cppCreditos C
on A.IDCredito = C.IDCredito inner join
dbo.globalMoneda M on C.IDMoneda = M.IDMoneda 
where A.IDDebito = @IDDebito 
order by c.Vencimiento, c.Documento 
go


-- exec dbo.cppDesAplicar  0, 5 select * from dbo.cppAplicaciones
Create  Procedure dbo.cppDesAplicar @IDDebito int, @IDAplicacion int
-- Desaplica un documento si el IDAplicacion es diferente de cero,
-- Toda la Aplicacion si @IDDebito es diferente de cero
as 
set nocount on 
begin transaction 
begin try
if @IDAplicacion <> 0 and @IDDebito = 0
begin
	Update D set SaldoActual = (D.SaldoActual + A.MontoCredito ), Cancelado =  CASE WHEN ((D.SaldoActual + A.MontoCredito ) + A.MontoCredito )= D.MontoOriginal THEN 1 ELSE 0 END,
	FechaUltCredito = null
	From dbo.cppAplicaciones A inner join cppCreditos D
	on A.IDCredito = D.IDCredito 
	Where IDAplicacion = @IDAplicacion 

	Update D set SaldoActual = (D.SaldoActual + A.MontoCredito )
	From dbo.cppAplicaciones A inner join dbo.cppDebitos D
	on A.IDDebito = D.IDDebito
	Where IDAplicacion = @IDAplicacion 
	
	DELETE FROM dbo.cppAplicaciones WHERE IDAPLICACION = @IDAplicacion 
end

if @IDAplicacion = 0 and @IDDebito <> 0
begin
	Update D set SaldoActual = SaldoActual + A.MontoCredito ,
	Cancelado =  CASE WHEN (D.SaldoActual + A.MontoCredito )= D.MontoOriginal THEN 1 ELSE 0 END
	--select SaldoActual , SaldoActual + A.MontoCredito SaldoNuevo
	From dbo.cppCreditos D
	inner join (
	Select A.IDCredito, SUM(A.MontoCredito ) MontoCredito
	From dbo.cppAplicaciones A 
	Where A.IDDebito = @IDDebito 
	Group by A.IDCredito 
	) A on D.IDCredito = A.IDCredito 	

	Update C set SaldoActual = SaldoActual + A.MontoCredito 
--	select SaldoActual , SaldoActual + A.MontoCredito SaldoNuevo
	From dbo.cppDebitos C
	inner join (
	Select A.IDDebito, SUM(A.MontoCredito ) MontoCredito
	From dbo.cppAplicaciones A 
	Where A.IDDebito = @IDDebito 
	Group by A.IDDebito  
	) A on C.IDDebito  = A.IDDebito 

	DELETE FROM dbo.cppAplicaciones WHERE IDDebito = @IDDebito 	
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


Create Procedure dbo.cppAprobarDocumento @TipoDocumento as nvarchar(1), @IDDocumento int 
as
set nocount on 
begin transaction 
begin try
if upper(@TipoDocumento) = 'D' 
begin
	Update dbo.cppDebitos set flgAprobado = 1
	Where IDDebito = @IDDocumento
	-- aqui se debe generar un Asiento contable del Documento
end
if upper(@TipoDocumento) = 'C' 
begin
	Update dbo.cppCreditos set flgAprobado = 1
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
-- select dbo.cppTieneAplicaciones('D', 2)
Create Function dbo.cppTieneAplicaciones (@TipoDocumento as nvarchar(1), @IDDocumento int )
returns bit 
begin
declare @Si bit 
set @Si = 0
if exists (
	Select IDAplicacion 
	From dbo.cppAplicaciones 
	Where (upper(@TipoDocumento) = 'D' and ( IDDebito =  @IDDocumento) )
	or (upper(@TipoDocumento) = 'C' and ( IDCredito =  @IDDocumento) )
	)
Set @Si = 1
else
set @Si = 0
return @Si
end
go

Create Procedure dbo.cppAnularDocumento @TipoDocumento as nvarchar(1), @IDDocumento int 
as
set nocount on

if  ( Select dbo.cppTieneAplicaciones (@TipoDocumento, @IDDocumento) ) = 1
	return 
begin transaction 
begin try
if upper(@TipoDocumento) = 'D' 
begin
	Update dbo.cppDebitos set Anulado  = 1, ConceptoSistema = '* ANULADO *'
	Where IDDebito = @IDDocumento
	-- aqui se debe generar un Asiento de Reversion contable del Documento
end
if upper(@TipoDocumento) = 'C' 
begin
	Update dbo.cppCreditos set Anulado  = 1 , ConceptoSistema = '* ANULADO *'
	Where IDCredito = @IDDocumento
	
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
-- select * from dbo.cppDebitos select [dbo].[cppGetIDDocumentoCC]('D', 'NC0001', 'N/C')
CREATE FUNCTION [dbo].[cppGetIDDocumentoCC] (@TipoDocumento as nvarchar(1),  @Documento nvarchar(20), @IDClase nvarchar(10) )
-- this function returns the ID of any kind of Document CC
RETURNS int AS  
BEGIN 
declare @IDDocumentoCC int
if upper(@TipoDocumento) = 'D'
begin 
Set @IDDocumentoCC = (SELECT top 1 IDDebito 
	FROM dbo.cppDebitos  
	where  Documento = @Documento and IDClase = @IDClase
	ORDER BY Documento desc
	)
end
if upper(@TipoDocumento) = 'C'
begin 
Set @IDDocumentoCC = (SELECT top 1 IDCredito 
	FROM dbo.cppCreditos   
	where Documento = @Documento and IDClase = @IDClase
	ORDER BY Documento desc
	)
end
if @IDDocumentoCC is null
	set @IDDocumentoCC = 0
return @IDDocumentoCC
end
go

Create  Procedure dbo.cppgetAplicaciones @IDDebito int = 0, 
 @FechaInicio date = '20190101', @FechaFin date = '20500101', 
 @IDProveedor int = 0
 as
 set nocount on 
if @FechaInicio is null
	set @FechaInicio = '20190101'
if @FechaFin is null
	set @FechaFin = '20500101'
	 
 Select R.IDDebito, R.IDClase, R.Documento Recibo,R.MontoOriginal TotalRecibo, R.Fecha, 
 R.IDProveedor, C.Nombre, 
 A.IDDebito, D.Documento Factura, 
 D.Fecha FechaFactura, D.MontoOriginal TotalFactura, A.Efectivo, A.Descuento,
 A.RetencionMunicipal, A.RetencionRenta , A.flgFlotante, A.IDChequePos, P.Numero, A.MontoChequePos, P.Cobrado, P.SinFondo, A.MontoCredito MontoAplicado, D.SaldoActual SaldoFactura
 From dbo.ccfDebitos R inner join dbo.ccfAplicaciones A
 on R.IDDebito = A.IDDebito inner join dbo.ccpProveedor C
 on R.IDProveedor = C.IDProveedor  inner join dbo.ccfCreditos D 
 on A.IDCredito = D.IDCredito  
 Where (R.IDDebito = @IDDebito or @IDDebito = 0)
 and (R.Fecha between @FechaInicio and @FechaFin )
 and (R.IDProveedor = @IDProveedor or @IDProveedor = 0)
 order by R.IDDebito 
 go
 
 
 -- select dbo.cppGetUltimoNumero ('D', 'N/C' ) update dbo.cppClaseDocumento set ultimoNumero = 1 where IDClase = 'N/C'
 Create Function dbo.cppGetUltimoNumero ( @Tipo as nvarchar(1), @IDClase nvarchar(10))
 returns nvarchar(10)
 as
 begin
 declare @Ultimo nvarchar(20)
	if @Tipo = 'D'
	Select @Ultimo = MAX (Documento) from dbo.cppDebitos Where IDClase = @IDClase 
	else
	Select @Ultimo = MAX (Documento) from dbo.cppCreditos Where IDClase = @IDClase 
 return (isnull(@Ultimo,''))	
 end
 go
 -- select * from dbo.cppgetRetencionesProveedor (12, 26 )
 Create Function  dbo.cppgetRetencionesProveedor (  @IDProveedor int, @IDCredito int )
 Returns table 
 -- Retornas las Retenciones de un proveedor asignadas y no asignadas
 as
 Return
 Select L.IDProveedor, L.IDCredito,L.IDRetencion ,  L.Descr,L.Porcentaje, L.MontoMinimo, 
cast(L.AsignadaProveedor as bit ) AsignadaProveedor, CAST( case when R.IDRetencion is null then 0 else 1 end as bit ) Aplicada,
isnull(R.Base, 0) Base , isnull(R.Monto,0) MontoRetenido
From 
(
	Select @IDProveedor IDProveedor, @IDCredito IDCredito,
	 case when PR.IDRetencion IS null then 0 else 1 end AsignadaProveedor, 
	 R.IDRetencion, R.Descr, R.Porcentaje,  R.MontoMinimo
	 From dbo.cppRetencion R left join 
	 (Select IDProveedor, IDRetencion 
	  From dbo.cppProveedorRetencion 
	  Where IDProveedor = @IDProveedor 
	  ) PR
	 on PR.IDRetencion = R.IDRetencion
	 --Where R.Activo = 1
) L left join 
(
 Select IDRetenciones, IDRetencion, IDProveedor, IDCredito, T.Base, T.Monto   
	 From dbo.cppRetenciones T
	 Where IDProveedor = @IDProveedor and IDCredito = @IDCredito 
) R 
on L.IDCredito = R.IDCredito and L.IDProveedor = R.IDProveedor and
L.IDRetencion = R.IDRetencion 
go
 
 -- exec dbo.cppgetPopUpRetenciones 18, 30
 Create Procedure dbo.cppgetPopUpRetenciones @IDProveedor int, @IDCredito int  
 as 
 set nocount on
 Select IDRetencion, Descr, Porcentaje, MontoMinimo, AsignadaProveedor, Aplicada,  
 Base, MontoRetenido 
 From dbo.cppgetRetencionesProveedor ( @IDProveedor, @IDCredito  )
 order by Aplicada desc 
 go


-- select dbo.cppUsaRetencion ('FAC', 20)
Create Function dbo.cppUsaRetencion (@IDClase nvarchar(10), @IDProveedor int )
returns bit
as
begin
 Declare @UsaRetencion bit, @ProvExternoRetencion bit, 
 @isLocal bit, @GeneraRetencion bit 
 
set @ProvExternoRetencion = isnull((Select top 1  ProvExternoRetencion
	From dbo.cppParametros)
	,0) 

set @isLocal =	isnull((	Select  isLocal
	From dbo.cppProveedor 
	Where IDProveedor = @IDProveedor ), 0)

set @GeneraRetencion =isnull((Select  GeneraRetencion 
	From dbo.cppClaseDocumento 
	Where TipoDocumento = 'C' and IDClase = @IDClase 
	AND GeneraRetencion = 1 ),0)
	
 if @isLocal = 0 and @ProvExternoRetencion = 0
	set @UsaRetencion = 0

if @isLocal = 0 and @ProvExternoRetencion = 1
	set @UsaRetencion = 1
	
if @isLocal = 1 and @GeneraRetencion = 1 
	set @UsaRetencion = 1 
else
	set @UsaRetencion = 0
	
	Return (@UsaRetencion)
end
go
-- Declare @strIDRetenciones nvarchar(500) 
--select * from  dbo.ConvertListToTable('1,2', ',' )



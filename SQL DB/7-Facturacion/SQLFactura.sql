
Update dbo.globalMoneda set Nacional = 0 where MONEDA = 'DOLAR'
go
Update dbo.globalMoneda set Nacional = 1 where MONEDA = 'CORDOBAS'
go

Create Table dbo.fafTipoVendedor ( IDTipo int not null, Descr nvarchar(250), Activo bit default 1 )
go

Alter table  dbo.fafTipoVendedor add constraint pkTipo primary key (IDTipo)
go

Create table dbo.fafGrupoVendedor ( IDGrupo int not null, Descr nvarchar(255), Activo bit default 1 )
go
alter table dbo.fafGrupoVendedor add constraint pkGrupoVendedor primary key (IDGrupo)
go


-- alter table  fafvendedor add IDGrupo int set telefono = '4545', celular = '4545', cedula = '145', email = '444'
CREATE TABLE [fafVendedor] (
	[IDVendedor] [int] NOT NULL ,
	[Nombre] [nvarchar] (255)  NOT NULL ,
	[IDTipo] int not null ,
	IDGrupo int not null,
	[Activo] [bit]  default 1,
	Direccion nvarchar(255), 
	Telefono nvarchar(25),
	Celular nvarchar(25),
	Cedula nvarchar(25),
	email nvarchar(250),
	CONSTRAINT [pkfafVendedor] PRIMARY KEY  CLUSTERED 
	(
	[IDVendedor]
	)  ON [PRIMARY] 
) ON [PRIMARY]
GO

alter table dbo.fafVendedor add constraint fkTipoVend foreign key (IDTipo) references dbo.fafTipoVendedor (IDTipo)
go

alter table dbo.fafVendedor add constraint fkGrupo foreign key (IDGrupo) references dbo.fafGrupoVendedor (IDGrupo)
go


Create Table dbo.globalDepto (IDDepto int not null, Descr nvarchar(255), Activo bit default 1 )
go

alter table dbo.globalDepto  add constraint pkDepto primary key (IDDepto)
go

Create Table dbo.globalZona (IDZona int not null, Descr nvarchar(255), Activo bit default 1 )
go

alter table dbo.globalZona  add constraint pkZona primary key (IDZona)
go

Create Table dbo.globalSubZona (IDZona int not null, IDSubZona int not null,  Descr nvarchar(255), Activo bit default 1 )
go

alter table  dbo.globalSubZona  add constraint pkSubZona primary key (IDZona, IDSubZona)
go

alter table  dbo.globalSubZona  add constraint fkZonaSubZona foreign key (IDZona) references dbo.globalZona(IDZona)
go

Create Table dbo.globalMunicipio (IDDepto int not null, IDMunicipio int not null, Descr nvarchar(255), Activo bit default 1 )
go
alter table dbo.globalMunicipio  add constraint pkMuni primary key (IDDepto, IDMunicipio)
go

-- use ced drop table select * from dbo.ccfClasificacionCliente
Create table dbo.fafCategoriaCliente (IDCategoria int not null , 
Descr nvarchar(255), Activo bit default 1, 
IDCtrFondoxDepos int, 
IDCtaFondoxDepos bigint,
IDCtrCxC int, 
IDCtaCxC bigint,
IDCtrIVA int, 
IDCtaIVA bigint,
IDCtrAnticipo int, 
IDCtaAnticipo bigint,
IDCtrCierreDeb int, 
IDCtaCierreDeb bigint,
IDCtrCierreCred int, 
IDCtaCierreCred bigint
 )
 
go

Alter table  dbo.fafCategoriaCliente add constraint pkfafCategoriaCliente primary key (IDCategoria)
go

Alter table  dbo.fafCategoriaCliente add constraint fkfafCategoriaClienteCtrFondoxDepos foreign key (IDCtrFondoxDepos) references dbo.cntCentroCosto (IDCentro)
go

Alter table  dbo.fafCategoriaCliente add constraint fkfafCategoriaClienteCtaFondoxDepos foreign key (IDCtaFondoxDepos) references dbo.cntCuenta (IDCuenta)
go

Alter table  dbo.fafCategoriaCliente add constraint fkcfafCategoriaClienteCtrcxc foreign key (IDCtrCxC) references dbo.cntCentroCosto (IDCentro)
go

Alter table  dbo.fafCategoriaCliente add constraint fkfafCategoriaClienteCtacxc foreign key (IDCtaCxC) references dbo.cntCuenta (IDCuenta)
go

Alter table  dbo.fafCategoriaCliente add constraint fkfafCategoriaClienteCtrIVA foreign key (IDCtrIVA) references dbo.cntCentroCosto (IDCentro)
go

Alter table  dbo.fafCategoriaCliente add constraint fkfafCategoriaClienteCtaIVA foreign key (IDCtaIVA) references dbo.cntCuenta (IDCuenta)
go
 
Alter table  dbo.fafCategoriaCliente add constraint fkfafCategoriaClienteCtrAnticipo foreign key (IDCtrAnticipo) references dbo.cntCentroCosto (IDCentro)
go

Alter table  dbo.fafCategoriaCliente add constraint fkfafCategoriaClienteCtaAnticipo foreign key (IDCtaAnticipo) references dbo.cntCuenta (IDCuenta)
go 

Alter table  dbo.fafCategoriaCliente add constraint fkfafCategoriaClienteCtrCierreDeb foreign key (IDCtrCierreDeb) references dbo.cntCentroCosto (IDCentro)
go

Alter table  dbo.fafCategoriaCliente add constraint fkfafCategoriaClienteCtaCierreDeb foreign key (IDCtaCierreDeb) references dbo.cntCuenta (IDCuenta)
go  

Alter table  dbo.fafCategoriaCliente add constraint fkfafCategoriaClienteCtrCierreCred foreign key (IDCtrCierreCred) references dbo.cntCentroCosto (IDCentro)
go

Alter table  dbo.fafCategoriaCliente add constraint fkfafCategoriaClienteCtaCierreCred foreign key (IDCtaCierreCred) references dbo.cntCuenta (IDCuenta)
go
--insert dbo.fafCategoriaCliente (IDCategoria, Descr , Activo )
--values (1, 'Clientes Nacionales', 1)
--go


Create Table dbo.fafEvaluacionCliente ( IDEvaluacion int not null, Descr nvarchar(255), Activo bit default 1)
go
alter table dbo.fafEvaluacionCliente add constraint pkEvaluacionCliente primary key (IDEvaluacion)
go

--insert dbo.fafTipoCliente (IDTipo, Descr, Activo )
--values (1, 'ESPECIAL', 1)
--GO

--insert dbo.fafTipoCliente (IDTipo, Descr, Activo )
--values (2, 'NORMAL', 1)
--GO
--insert dbo.fafTipoCliente (IDTipo, Descr, Activo )
--values (3, 'EXCELENTE', 1)
--GO

--insert dbo.fafTipoCliente (IDTipo, Descr, Activo )
--values (4, 'OTRO', 1)
--GO

--insert dbo.fafTipoCliente (IDTipo, Descr, Activo )
--values (5, 'BUENO', 1)
--GO

--insert dbo.fafTipoCliente (IDTipo, Descr, Activo )
--values (6, 'REGULAR', 1)
--GO

--insert dbo.fafTipoCliente (IDTipo, Descr, Activo )
--values (7, 'MALO', 1)
--GO

--insert dbo.fafTipoCliente (IDTipo, Descr, Activo )
--values (8, 'INSTITUCIONES', 1)
--GO


--drop table dbo.dbo.ccfPlazo alter table dbo.ccfClientes add foto image
Create Table dbo.ccfPlazo ( Plazo int not null, Descr nvarchar(200),  Activo bit )
go
alter table dbo.ccfPlazo add constraint pkPlazo primary key (Plazo)
go
-- alter table  dbo.ccfClientes add Cedula nvarchar(20)

Create table dbo.fafNivelPrecio ( IDNivel int not null, Descr nvarchar(250), IDMoneda int not null, Activo bit default 1)
go

alter table dbo.fafNivelPrecio  add constraint pkfafNivelPrecio primary key (IDNivel)
go

alter table dbo.fafNivelPrecio add constraint fkfafNivelMoneda foreign key (IDMoneda) references dbo.globalMoneda (IDMoneda)
go


Create Table dbo.fafTipoCliente ( IDTipo int not null, Descr nvarchar(255), Activo bit default 1)
go
alter table dbo.fafTipoCliente add constraint pkTipoCliente primary key (IDTipo)
go


--drop table dbo.ccfClientes  alter table dbo.ccfClientes add IDEvaluacion int  decimal(28,4) default 0 update  dbo.ccfClientes set flgEspecial = 1
Create Table dbo.ccfClientes ( IDCliente int not null,   Nombre nvarchar(255), EsFarmacia bit default 0, IDTipo int not null,
Farmacia nvarchar(255), IDCategoria int not null,  IDVendedor int not null, IDDepto int not null, IDMunicipio int not null, 
IDZona int not null, IDSubZona int not null, RUC NVARCHAR(50),  LimiteCredito decimal(28,4) default 0,
IDBodega int not null, Direccion nvarchar(255),  Telefono nvarchar(25), Celular nvarchar(25),
Dueno nvarchar(255), FechaIngreso smalldatetime, 
dateInsert datetime,
userInsert nvarchar(20) ,
dateUpdate datetime,
userUpdate nvarchar(20),
PorcInteres decimal(8,2) default 0,
Plazo int not null,
email nvarchar(250),
pweb  nvarchar(250),
foto image null,
Activo bit default 1,
Cedula nvarchar(20),
IDNivel int not null,
IDMoneda int not null,
EditaNombre bit default 0,
Credito bit default 1,
flgEspecial bit default 0,
DisponibleCredito decimal(28,4) default 0,
IDEvaluacion int 
 )
go

alter table dbo.ccfClientes add constraint pkCliente primary key (IDCliente)
go

alter table dbo.ccfClientes add constraint fkClienteDepto foreign key (IDDepto) references dbo.globalDepto (IDDepto)
go

alter table dbo.ccfClientes add constraint fkClienteMunicipio foreign key (IDDepto, IDMunicipio) references dbo.globalMunicipio (IDDepto, IDMunicipio)
go
--alter table dbo.ccfClientes drop constraint fkClienteTipo
alter table dbo.ccfClientes add constraint fkClienteTipo foreign key (IDTipo) references dbo.fafTipoCliente (IDTipo)
go

alter table dbo.ccfClientes add constraint fkClienteNivel foreign key (IDNivel) references dbo.fafNivelPrecio (IDNivel)
go

alter table dbo.ccfClientes add constraint fkClienteVendedor foreign key (IDVendedor) references dbo.fafVendedor (IDVendedor)
go

alter table dbo.ccfClientes add constraint fkClienteCategoria foreign key (IDCategoria) references dbo.fafCategoriaCliente (IDCategoria)
go

alter table dbo.ccfClientes add constraint fkClienteZona foreign key (IDZona) references dbo.globalZona (IDZona)
go

alter table dbo.ccfClientes add constraint fkClienteBodega foreign key (IDBodega) references dbo.invBodega (IDBodega)
go

alter table dbo.ccfClientes add constraint fkClienteZonaSubZona foreign key (IDZona, IDSubZona) references dbo.globalSubZona (IDZona, IDSubZona)
go

alter table dbo.ccfClientes add constraint fkClientePlazo foreign key (Plazo) references dbo.ccfPlazo (Plazo)
go

alter table dbo.ccfClientes add constraint fkEvaluacion foreign key (IDEvaluacion) references dbo.fafEvaluacionCliente (IDEvaluacion)
go


CREATE TRIGGER trg_UpdateDatoCliente
ON dbo.ccfClientes
AFTER UPDATE
AS
    UPDATE dbo.ccfClientes
    SET dateUpdate = GETDATE()
    WHERE IDCliente IN (SELECT DISTINCT IDCliente FROM Inserted)

go

CREATE TRIGGER trg_InsertCliente
ON dbo.ccfClientes
FOR INSERT
AS
    UPDATE dbo.ccfClientes
    SET dateInsert = GETDATE()
    WHERE IDCliente IN (SELECT DISTINCT IDCliente FROM Inserted)

go

-- drop table dbo.fafTipoEntrega
Create Table dbo.fafTipoEntrega ( IDTipoEntrega int not null DEFAULT 0 , Descr nvarchar(250), Activo bit default 1 )
go

alter table dbo.fafTipoEntrega add constraint pkTipoEntrega primary key (IDTipoEntrega)
go

insert dbo.fafTipoEntrega (IDTipoEntrega, Descr )
values (1, 'CEDETSA')
GO

insert dbo.fafTipoEntrega (IDTipoEntrega, Descr )
values (2, 'CORREO')
GO

insert dbo.fafTipoEntrega (IDTipoEntrega, Descr )
values (3, 'MENSAJERO')
GO

insert dbo.fafTipoEntrega (IDTipoEntrega, Descr )
values (4, 'PERSONAL')
GO

Create Table dbo.fafTipoFactura ( IDTipo smallint not null, Descr nvarchar(100), Activo bit default 1)
go

alter table dbo.fafTipoFactura add constraint pkTipoFactura primary key (IDTipo)
go

insert dbo.fafTipoFactura ( IDTipo, Descr )
values (1, 'CONTADO')
GO

insert dbo.fafTipoFactura ( IDTipo, Descr )
values (2, 'CREDITO')
GO


Create Table dbo.fafEstadoPedido (Estado nvarchar(1) not null default 'C', Descr nvarchar(50), Activo bit default 1)
go
alter table dbo.fafEstadoPedido add constraint pkEstadoPedido primary key (Estado)
go

Insert dbo.fafEstadoPedido (Estado, Descr )
values ('A', 'APROBADO')
GO --SELECT * FROM  dbo.fafEstadoPedido SET DESCR = 'CREADO' WHERE ESTADO = 'C' 
Insert dbo.fafEstadoPedido (Estado, Descr )
values ('C', 'CREADO')
GO
Insert dbo.fafEstadoPedido (Estado, Descr )
values ('F', 'FACTURADO')
GO
Insert dbo.fafEstadoPedido (Estado, Descr )
values ('N', 'ANULADO')
GO
Insert dbo.fafEstadoPedido (Estado, Descr )
values ('D', 'DENEGADO')
GO

-- drop table dbo.fafpedido alter table dbo.[fafPedido] add IDPlazo int not null
CREATE TABLE dbo.[fafPedido] (	
	[IDPedido] [int] not NULL  Identity(1,1),
	[IDBodega] [int] NOT NULL ,
	Pedido int not null, 
	[IDCliente] [int] NOT NULL ,
	IDTipoEntrega int not null,
	[IDVendedor] [int] NOT NULL ,
	IDDepto int not null,
	IDMunicipio int not null,
	IDZona int not null,
	IDSubZona int not null, 
	Fecha date NOT NULL ,	
	FechaRequerida date,
	[Anulado] [bit] NULL  DEFAULT (0),
	[EsTeleventa] [bit] NULL  DEFAULT (0),
	Estado nvarchar(1) not null default 'C',
	IDFactura bigint null,
	IDNivel int not null,
	IDMoneda int not null,
	IDPlazo int not null,
	TipoCambio decimal (28,4) default 0,	
	dateInsert datetime,
	dateUpdate datetime,
	Nota nvarchar(255)
)
go

alter table dbo.fafPedido add constraint pkPedido primary key (IDPedido)
go

alter table dbo.fafPedido add constraint ukPedido unique (IDBodega, Pedido)
go

alter table dbo.fafPedido add CONSTRAINT [fkfafPedidoMoneda] FOREIGN KEY 
	(
	[IDMoneda]
	) REFERENCES dbo.[globalMoneda] (
	[IDMoneda]
	)
go

alter table dbo.[fafPedido] add CONSTRAINT [fkfafPedidoNivel] FOREIGN KEY 
	(
	[IDNivel]
	) REFERENCES dbo.[fafNivelPrecio] (
	[IDNivel]
	)
go

--alter table dbo.[fafPedido] add constraint fkfafPedidoPlazo foreign key (IDPlazo) references dbo.ccfPlazo (Plazo)
--go

alter table dbo.fafPedido add constraint fkPedidoest foreign key (Estado) references dbo.fafEstadoPedido (Estado)
go

alter table dbo.fafPedido add constraint fkPedidoPlazo foreign key (IDPlazo) references dbo.ccfPlazo (Plazo)
go

alter table dbo.fafPedido add constraint fkPedidoCliente foreign key (IDCliente) references dbo.ccfClientes (IDCliente)
go

alter table dbo.fafPedido add constraint fkPedidoEntrega foreign key (IDTipoEntrega) references dbo.fafTipoEntrega (IDTipoEntrega)
go


alter table dbo.fafPedido add constraint fkPedidoDepto foreign key (IDDepto) references dbo.globalDepto (IDDepto)
go

alter table dbo.fafPedido add constraint fkPedidoMunicipio foreign key (IDDepto, IDMunicipio) references dbo.globalMunicipio (IDDepto, IDMunicipio)
go


alter table dbo.fafPedido add constraint fkPedidoZona foreign key (IDZona) references dbo.globalZona (IDZona)
go
alter table dbo.fafPedido add constraint fkPedidoZonaSubZona foreign key (IDZona, IDSubZona) references dbo.globalSubZona (IDZona, IDSubZona)
go


CREATE TRIGGER trg_UpdatePedido
ON dbo.fafPedido
AFTER UPDATE
AS
    UPDATE dbo.fafPedido
    SET dateUpdate = GETDATE()
    WHERE IDPedido IN (SELECT DISTINCT IDPedido FROM Inserted)

go

CREATE TRIGGER trg_InsertPedido
ON dbo.fafPedido
FOR INSERT
AS
    UPDATE dbo.fafPedido
    SET dateInsert = GETDATE()
    WHERE IDPedido IN (SELECT DISTINCT IDPedido FROM Inserted)

go
	
-- alter table dbo.fafPedidoProd add PorcImpuesto  decimal (28,4) default 0,
Create Table dbo.fafPedidoProd ( 
	IDPedidoProd bigint identity(1,1) not null,
	IDPedido int not null,
	IDBodega int not null,
	IDProducto bigint not null,
	Cantidad decimal(28,4) default 0,
	PrecioLocal decimal(28,4) default 0,
	PrecioDolar decimal(28,4) default 0,	
	SubTotalLocal decimal(28,4) default 0,
	SubTotalDolar decimal(28,4) default 0,
	SubTotalFinalLocal decimal(28,4) default 0,SubTotalFinalDolar decimal(28,4) default 0,	
	ImpuestoLocal decimal(28,4) default 0,
	ImpuestoDolar decimal(28,4) default 0,	
	CantFacturada int not null default 0,
	Bonifica bit default 0 not null, BonifConProd bit default 0, CantBonificada  decimal (28,4) default 0, CantPrecio  decimal (28,4) default 0,
	DescuentoLocal decimal(28,4) default 0, DescuentoDolar decimal(28,4) default 0, PorcDescuentoEsp decimal(28,4) default 0,
	DescuentoEspecialLocal decimal(28,4) default 0, DescuentoEspecialDolar decimal(28,4) default 0,
	
	backOrder bit default 0,  PorcImpuesto  decimal (28,4) default 0,
	PrecioLista decimal(28,4) default 0,
	Ahorro decimal(28,4) default 0
	
	)
	go

alter table dbo.fafPedidoProd add constraint pkPedidoLinea primary key (IDPedidoProd)
go

alter table dbo.fafPedidoProd add constraint ukPedidoLinea UNIQUE (IDPedido, IDBodega, IDProducto)
go

alter table dbo.fafPedidoProd add constraint fkPedidoLineaPed foreign key (IDPedido) references dbo.fafPedido (IDPedido)
go

alter table dbo.fafPedidoProd add constraint fkPedidoLineaBod foreign key (IDBodega) references dbo.invBodega (IDBodega)
go

alter table dbo.fafPedidoProd add constraint fkPedidoLineaProd foreign key (IDProducto) references dbo.invProducto (IDProducto)
go

Create Table dbo.globalConsecMask ( Codigo nvarchar(20) not null, Descr nvarchar(250), Longitud int,
Mascara nvarchar(25) not null, Consecutivo nvarchar(25) not null,
Activo bit default 1, IDModulo int  not null)
go
alter table dbo.globalConsecMask add constraint pkConsecMask primary key (Codigo)
go

alter table dbo.globalConsecMask add constraint fkConsecMaskMod  foreign key (IDModulo) references dbo.secModulo
go


Create Function dbo.getMascaraFromConsecMask ( 
	 @Codigo nvarchar(25)
	) 
returns nvarchar(25)
as
begin
declare @Mascara as nvarchar(25)

Select @Mascara = Mascara
from dbo.globalConsecMask 
where Codigo  = @Codigo 
return @Mascara
end
go

--drop function dbo.getNextConsecMask 
Create Function dbo.getNextConsecMask ( 
	 @Codigo nvarchar(25)
	) 
returns nvarchar(25)
as
begin
declare @Mascara as nvarchar(25), @Valor nvarchar(25)
declare @i int, @inic int, @fin int, @index int,  @Caracter nvarchar(1)

Select @Mascara = Mascara, @Valor = Consecutivo 
from dbo.globalConsecMask 
where Codigo  = @Codigo and Activo = 1

Declare @table  table(ID int identity(1,1) not null,Tipo nvarchar(1), inic int, fin int, Long int,  valor nvarchar(25)
, PRIMARY KEY (ID))

set @i = 1
set @index = 1
While @index <= LEN(@Mascara)
begin
	set @i = @index 
	set @Caracter = substring(@Mascara, @i,1) 
	if @Caracter = 'N'
	begin
	set @inic = @i
	while @i <= LEN(@Mascara) and @Caracter = 'N'
	begin
	if substring(@Mascara, @i,1) = 'N'
	set @i = @i + 1
	
	set @fin = @i - 1
	
	set @Caracter = substring(@Mascara, @i,1) 
	end
	insert @table(Tipo, inic, fin, Long,  valor )
	values ('N', @inic, @fin , ((@fin-@inic)+1), SUBSTRING (@Valor , @inic, (@fin-@inic)+1) )
	end
	else -- es Alfanumeric
	begin
	set @inic = @i
	while @i <= LEN(@Mascara) and @Caracter = 'A'
	begin
	if substring(@Mascara, @i,1) = 'A'
	set @i = @i + 1
	
	set @fin = @i -1 
	set @Caracter = substring(@Mascara, @i,1) 
	end
	insert @table(Tipo, inic, fin, Long,  valor )
	values ('A', @inic, @fin , ((@fin-@inic)+1), SUBSTRING (@Valor , @inic, (@fin-@inic)+1) )	
	end
	set @index = @i
end
declare @Count int , @Result nvarchar(25), @ID int, @Tipo nvarchar(1), @Long int, @CantN int, @Ni int
set @CantN = (Select COUNT(*) from @table where Tipo = 'N' )
set @Count = ( Select COUNT(*) from @table )
if @Count >0 
begin
set @i = 1
set @Result = ''
set @Ni = 0

	while @i <= @Count 
	begin
	Select @Id = ID, @Tipo = Tipo, @inic = inic, @fin = fin, 
	@Long = Long, @Valor = Valor
	from @table 
	where ID = @i
	if @Tipo = 'A'
	set @Result = @Result + @Valor 
	if @Tipo = 'N' 
	begin
	set @Ni = @Ni + 1
	if @Ni = @CantN 
	set @Result = @Result + right( Replicate('0', @Long ) + cast(CAST(@Valor as int) + 1 as nvarchar(20)) , @Long )
	else
	set @Result = @Result + @Valor 
	end
	set @i = @i + 1
	end
end
Return @Result 
end
go

create Procedure dbo.globalgetConsecMask ( @Codigo nvarchar(20))
as
set nocount on
Select C.Codigo, C.Descr , C.Longitud , C.Mascara , C.Consecutivo , C.IDModulo , M.descr DescrModulo
from dbo.globalConsecMask C inner join dbo.secModulo M
on C.IDModulo = M.IDModulo 
where (Codigo = @Codigo or @Codigo = '*')
go


CREATE Procedure [dbo].[globalUpdateglobalConsecMask] @Operacion nvarchar(1),
@Codigo nvarchar(20) , @Descr nvarchar(250), @Longitud int,
@Mascara nvarchar(25) , @Consecutivo nvarchar(25) ,
@Activo bit , @IDModulo int  
as
set nocount on
if @Operacion = 'I'
	insert dbo.globalConsecMask (Codigo, Descr, Longitud, Mascara, Consecutivo, IDModulo)
	values (@Codigo, @Descr, @Longitud, @Mascara, @Consecutivo, @IDModulo)
if @Operacion = 'D'
	Delete From dbo.globalConsecMask Where Codigo = @Codigo 
if @Operacion = 'U'
	Update dbo.globalConsecMask set Descr = @Descr , Longitud = @Longitud , Mascara = @Mascara, Consecutivo = @Consecutivo , IDModulo = @IDModulo, Activo = @Activo  
	Where Codigo = @Codigo 

go

alter table dbo.invBodega add CodigoConsecMask  nvarchar(20)
go

alter table dbo.invBodega add constraint  fkCodigoConsecMask foreign key (CodigoConsecMask) references dbo.globalConsecMask (Codigo)
go

-- drop table dbo.[fafFACTURA]
CREATE TABLE dbo.[fafFactura] (	
	[IDFactura] bigint NOT NULL identity(1,1) ,
	[IDBodega] [int] NOT NULL ,
	[Factura] [nvarchar] (20) not null ,
	IDTipo smallint not null, 
	[IDCliente] [int] NOT NULL ,
	Nombre nvarchar(250), 
	[IDVendedor] [int] NOT NULL ,
	IDDepto int not null, 
	IDMunicipio int not null,
	IDZona int not null,
	IDSubZona int not null, 
	IDTipoEntrega int not null,
	[Fecha] [datetime] NOT NULL ,	
	[Anulada] [bit] NULL  DEFAULT (0),
	[EsTeleventa] [bit] NULL  DEFAULT (0),
	[IDPedido] [int]    DEFAULT (null),	
	IDNivel int not null,
	IDMoneda int not null,
	IDPlazo int not null,
	TipoCambio decimal(28,4) default 0,
	CodConsecutivo nvarchar(20) not null,
	Mensaje nvarchar(255),
	dateInsert datetime,	
	dateUpdate datetime
)
go

alter table dbo.[fafFACTURA] add CONSTRAINT [pkfafFACTURA] PRIMARY KEY  CLUSTERED 
	([IDFactura])  
go

alter table dbo.[fafFACTURA] add CONSTRAINT [ukfafFACTURA] UNIQUE    
	([IDBodega], Factura)  
go


alter table dbo.[fafFACTURA] add CONSTRAINT [fkfafFacturaBodega] FOREIGN KEY 
	(
	[IDBodega]
	) REFERENCES dbo.[invBODEGA] (
	[IDBodega]
	)
go

alter table dbo.[fafFACTURA] add CONSTRAINT [fkfafFacturaConsec] FOREIGN KEY 
	(
	CodConsecutivo
	) REFERENCES dbo.globalConsecMask (
	Codigo
	)
go

alter table dbo.[fafFACTURA] add CONSTRAINT [fkfafFacturaMoneda] FOREIGN KEY 
	(
	[IDMoneda]
	) REFERENCES dbo.[globalMoneda] (
	[IDMoneda]
	)
go

alter table dbo.[fafFACTURA] add CONSTRAINT [fkfafFacturaNivel] FOREIGN KEY 
	(
	[IDNivel]
	) REFERENCES dbo.[fafNivelPrecio] (
	[IDNivel]
	)
go
	
alter table dbo.[fafFACTURA] add CONSTRAINT	 [fkfafFacturaVendedor] FOREIGN KEY 
	(
	[IDVendedor]
	) REFERENCES [fafVendedor] (
	[IDVendedor]
	)

GO

alter table dbo.[fafFACTURA] add CONSTRAINT [fkfafFacturaTipoEntrega] FOREIGN KEY 
	(
	[IDTipoEntrega]
	) REFERENCES dbo.[fafTipoEntrega] (
	[IDTipoEntrega]
	)
go

alter table dbo.[fafFACTURA] add CONSTRAINT [fkfafFacturaTipo] FOREIGN KEY 
	(
	[IDTipo]
	) REFERENCES dbo.[fafTipoFactura] (
	[IDTipo]
	)
go


alter table dbo.[fafFACTURA] add constraint fkFacturaPedido foreign key (IDPedido) references dbo.fafPedido (IDPedido)
go

alter table dbo.[fafFACTURA] add constraint fkFacturaPlazo foreign key (IDPlazo) references dbo.ccfPlazo (Plazo)
go

alter table dbo.[fafFACTURA] add constraint fkFacturaCliente foreign key (IDCliente) references dbo.ccfClientes (IDCliente)
go

alter table dbo.fafFactura add constraint fkFacturaDepto foreign key (IDDepto) references dbo.globalDepto (IDDepto)
go

alter table dbo.fafFactura add constraint fkFacturaMunicipio foreign key (IDDepto, IDMunicipio) references dbo.globalMunicipio (IDDepto, IDMunicipio)
go


alter table dbo.fafFactura add constraint fkFacturaZona foreign key (IDZona) references dbo.globalZona (IDZona)
go
alter table dbo.fafFactura add constraint fkFacturaZonaSubZona foreign key (IDZona, IDSubZona) references dbo.globalSubZona (IDZona, IDSubZona)
go

alter table [dbo].[fafFACTURA] add PesoKG decimal (28,2) default 0, Remisionada bit default 0
go

CREATE TRIGGER trg_UpdateFactura
ON dbo.fafFactura
AFTER UPDATE
AS
    UPDATE dbo.fafFactura
    SET dateUpdate = GETDATE()
    WHERE IDFactura  IN (SELECT DISTINCT IDFactura FROM Inserted)
go

CREATE TRIGGER trg_InsertFactura
ON dbo.fafFactura
FOR INSERT
AS
    UPDATE dbo.fafFactura
    SET dateInsert = GETDATE()
    WHERE IDFactura IN (SELECT DISTINCT IDFactura FROM Inserted)

go

-- drop alter table dbo.fafFacturaProd add PorcImpuesto decimal(28,4) default 0,SubTotalFinalDolar decimal(28,4) default 0
-- alter table  dbo.fafFacturaProd  add PrecioListaLocal decimal(28,4) default 0,PrecioListaDolar decimal(28,4) default 0
CREATE TABLE dbo.fafFacturaProd ( 
IDFacturaProd bigint not null identity(1,1), 
IDFactura bigint not null,	IDBodega int not null, IDProducto bigint not null,  
Bonifica bit default 0 not null, Requerido decimal (28,4) default 0, Bono decimal (28,4) default 0,
BonifConProd bit default 0,CantBonificada  decimal (28,4) default 0 ,
CantFacturada decimal(28,4) default 0,  Cantidad as (CantFacturada + CantBonificada), 
CantPrecio decimal(28,4) default 0,
PrecioLocal decimal(28,4) default 0,PrecioDolar decimal(28,4) default 0, 
CostoLocal decimal(28,4) default 0,CostoDolar decimal(28,4) default 0,
DescuentoLocal decimal(28,4) default 0, DescuentoDolar decimal(28,4) default 0, PorcDescuentoEsp decimal(28,4) default 0,
DescuentoEspecialLocal decimal(28,4) default 0, DescuentoEspecialDolar decimal(28,4) default 0,
SubTotalLocal decimal(28,4) default 0,SubTotalDolar decimal(28,4) default 0,
SubTotalFinalLocal decimal(28,4) default 0,SubTotalFinalDolar decimal(28,4) default 0,
ImpuestoLocal decimal(28,4) default 0,  ImpuestoDolar decimal(28,4) default 0,
Factor int default 0, PorcImpuesto decimal(28,4) default 0,
PrecioLista decimal(28,4) default 0,
Ahorro decimal(28,4) default 0
 )
go
alter table  dbo.fafFacturaProd add constraint pkFacturaLinea primary key (IDFacturaProd)
go

alter table  dbo.fafFacturaProd add constraint ukFacturaLinea UNIQUE (IDFactura, IDBodega, IDProducto )
go

alter table  dbo.fafFacturaProd add constraint fkFacturaLinea foreign key (IDFactura) references dbo.fafFactura (IDFactura)
go

alter table  dbo.fafFacturaProd add constraint fkFacturaLineaBod foreign key (IDBodega) references dbo.invBodega (IDBodega)
go


--drop table dbo.fafFacturaProdLote

Create Table dbo.fafFacturaProdLote ( IDFactProdLote bigint not null identity(1,1), IDFacturaProd bigint not null,
IDLote int not null,   
CantBonificada  decimal (28,4) default 0 ,
CantFacturada decimal(28,4) default 0,  Cantidad as (CantFacturada + CantBonificada)   )
go

alter table  dbo.fafFacturaProdLote add constraint pkFacturaLineaLote primary key (IDFactProdLote)
go
alter table  dbo.fafFacturaProdLote add constraint ukFacturaLineaLote UNIQUE ( IDFacturaProd,IDLote)
go

alter table dbo.fafFacturaProdLote add constraint fkfafFacturaLineaLoteLin foreign key ( IDFacturaProd) references dbo.fafFacturaProd (IDFacturaProd )
go

--drop table  dbo.fafTablaBonificacion
Create Table dbo.fafTablaBonificacion ( IDTabla int  identity(1,1) not null , IDProveedor int not null, IDProducto bigint not null, 
 CantDesde int default 0, CantHasta int default 0,  Bono int default 0
 )
go
alter table dbo.fafTablaBonificacion add constraint pkTablaBonif primary key (IDTabla) 
go

alter table dbo.fafTablaBonificacion add constraint ukTablaBonif UNIQUE (IDProveedor, IDProducto, CantDesde, CantHasta, Bono)
go
alter table dbo.fafTablaBonificacion add constraint fkTablaBonifProv foreign key (IDProveedor) references dbo.cppProveedor (IDProveedor)
go
alter table dbo.fafTablaBonificacion add constraint fkTablaBonifProd foreign key (IDProducto) references dbo.invProducto (IDProducto)
go

Create Table dbo.fafTablaDescuento ( IDTabla int  identity(1,1) not null , IDProveedor int not null, IDProducto bigint not null, 
 FechaDesde date, FechaHasta date , CantDesde int default 0, CantHasta int default 0,  Descuento decimal(28,2) default 0
 )
go
alter table dbo.fafTablaDescuento add constraint pkTablaDescuento primary key (IDTabla) 
go

alter table dbo.fafTablaDescuento add constraint ukTablaDescuento UNIQUE (IDProveedor, IDProducto, FechaDesde, FechaHasta, CantDesde, CantHasta, Descuento)
go
alter table dbo.fafTablaDescuento add constraint fkTablaDescProv foreign key (IDProveedor) references dbo.cppProveedor (IDProveedor)
go
alter table dbo.fafTablaDescuento add constraint fkTablaDescProd foreign key (IDProducto) references dbo.invProducto (IDProducto)
go


-- drop table dbo.fafPromociones alter table fafpromociones add RequiereBonif bit default 0 update fafpromociones set RequiereBonif = 0
Create Table dbo.fafPromociones ( IDPromocion int  identity(1,1) not null , IDProveedor int not null, IDProducto bigint not null, 
PorcDesc decimal(28,2) default 0,PorcDescCliEsp decimal(28,2) default 0, Desde date, Hasta date, RequiereBonif bit default 0 )
go
alter table dbo.fafPromociones add constraint pkPromociones primary key (IDPromocion) 
go
alter table dbo.fafPromociones add constraint fkPromProv foreign key (IDProveedor) references dbo.cppProveedor (IDProveedor)
go
alter table dbo.fafPromociones add constraint fkPromProd foreign key (IDProducto) references dbo.invProducto (IDProducto)
go


--drop procedure fafGetMunipios
-- exec dbo.fafGetMasterMunicipios 6,1
Create procedure dbo.fafGetMasterMunicipios( @IDDepto int=-1, @SoloActivos smallint = 1 )
-- -1 indica que son todos los registros tanto para deptos como para municipios
as 
set nocount on 
Select D.IDDepto CodMaster, D.Descr DescrMaster, M.IDMunicipio Codigo, M.Descr , M.Activo 
From dbo.globalDepto D inner join  dbo.globalMunicipio M 
on D.IDDepto = M.IDDepto 
Where (M.IDDepto = @IDDepto or @IDDepto = -1) and (M.Activo = @SoloActivos or @SoloActivos=-1 )
go

--Create procedure dbo.fafGetMasterSubZonas( @IDZona int=-1, @SoloActivos smallint = 1 )
---- -1 indica que son todos los registros tanto para deptos como para municipios
--as 
--set nocount on 
--Select D.IDZona CodMaster, D.Descr DescrMaster, M.IDSubZona Codigo, M.Descr , M.Activo 
--From dbo.globalZona D inner join  dbo.globalSubZona M 
--on D.IDZona = M.IDZona 
--Where (M.IDZona = @IDZona or @IDZona = -1) and (M.Activo = @SoloActivos or @SoloActivos=-1 )
--go



-- drop procedure dbo.fafUpdateCliente  Exec dbo.fafUpdateCliente 'D',5,' '
--Create Procedure dbo.fafUpdateCliente @Operacion nvarchar(1),
--	@IDCliente int
--           ,@Nombre nvarchar(255)
--           ,@EsFarmacia bit = null
--           ,@IDTipo int = null
--           ,@Farmacia nvarchar(255) = null
--           ,@IDCategoria int = null
--           ,@IDVendedor int = null
--           ,@IDDepto int = null
--           ,@IDMunicipio int = null
--           ,@IDZona int = null
--           ,@IDSubZona int = null
--           ,@RUC nvarchar(50) = null
--           ,@LimiteCredito decimal(28,4) = null
--           ,@IDBodega int = null
--           ,@Direccion nvarchar(255) = null
--           ,@Telefono nvarchar(25) = null
--           ,@Celular nvarchar(25) = null
--           ,@Dueno nvarchar(255) = null
           
--           ,@PorcInteres decimal(8,2) = null
--           ,@Plazo int = null
--           ,@email nvarchar(250) = null
--           ,@pweb nvarchar(250) = null
--           ,@Activo bit = null
--           ,@Cedula nvarchar(20) = null
--           ,@IDNivel int  = null
--           ,@IDMoneda int  = null
--           ,@EditaNombre bit = null
--           ,@Credito bit = null  
--           ,@flgEspecial bit = null                    
--           ,@Foto image  = null

--as

--if @Operacion = 'I'
--begin
--INSERT INTO [dbo].[ccfClientes]
--           ([IDCliente]
--           ,[Nombre]
--           ,[EsFarmacia]
--           ,[IDTipo]
--           ,[Farmacia]
--           ,[IDCategoria]
--           ,[IDVendedor]
--           ,[IDDepto]
--           ,[IDMunicipio]
--           ,[IDZona]
--           ,[IDSubZona]
--           ,[RUC]
--           ,[LimiteCredito]
--           ,[IDBodega]
--           ,[Direccion]
--           ,[Telefono]
--           ,[Celular]
--           ,[Dueno]
--	   , FechaIngreso 

--           ,[PorcInteres]
--           ,[Plazo]
--           ,[email]
--           ,[pweb]
--           ,[Activo]
--           ,[Cedula]
--           ,IDNivel
--           ,IDMoneda
--           ,Foto
--           ,EditaNombre
--           ,Credito
--           ,flgEspecial )
--     VALUES
--           (@IDCliente 
--           ,@Nombre 
--           ,@EsFarmacia 
--           ,@IDTipo 
--           ,@Farmacia 
--           ,@IDCategoria 
--           ,@IDVendedor 
--           ,@IDDepto 
--           ,@IDMunicipio 
--           ,@IDZona 
--           ,@IDSubZona 
--           ,@RUC 
--           ,@LimiteCredito 
--           ,@IDBodega 
--           ,@Direccion 
--           ,@Telefono 
--           ,@Celular 
--           ,@Dueno 
--           ,GETDATE() 

--           ,@PorcInteres 
--           ,@Plazo 
--           ,@email 
--           ,@pweb 
--           ,@Activo 
--           ,@Cedula 
--           ,@IDNivel
--           ,@IDMoneda
--           , @Foto 
--           , @EditaNombre 
--           , @Credito 
--           , @flgEspecial
--          )
-- end
-- if @Operacion  = 'U'
-- begin
-- Update dbo.ccfClientes set Nombre =  @Nombre 
--           ,EsFarmacia = @EsFarmacia 
--           ,IDTipo = @IDTipo 
--           ,Farmacia = @Farmacia 
--           ,IDCategoria = @IDCategoria 
--           ,IDVendedor = @IDVendedor 
--           ,IDDepto = @IDDepto 
--           ,IDMunicipio = @IDMunicipio 
--           ,IDZona = @IDZona 
--           ,IDSubZona = @IDSubZona 
--           ,IDNivel = @IDNivel 
--           ,IDMoneda = @IDMoneda 
--           ,RUC = @RUC  
--           ,LimiteCredito = @LimiteCredito 
--           ,IDBodega = @IDBodega 
--           ,Direccion = @Direccion 
--           ,Telefono = @Telefono 
--           ,Celular = @Celular
--           ,Dueno = @Dueno 

--           ,PorcInteres = @PorcInteres 
--           ,Plazo = @Plazo 
--           ,email = @email 
--           ,pweb = @pweb 
--           ,Activo = @Activo 
--           ,Cedula = @Cedula 
--           ,Foto = @Foto 
--           ,EditaNombre = @EditaNombre 
--           ,Credito = @Credito
--           ,flgEspecial = @flgEspecial
--  Where IDCliente = @IDCliente 
--  end  
--If @Operacion = 'D'           
--	Delete from dbo.ccfClientes where IDCliente = @IDCliente 
--GO


-- drop procedure fafgetClientes exec fafgetClientes 0 select * from ccfclientes where foto is null
--Create  Procedure dbo.fafgetClientes(@IDCliente int, @IDSucursal int = null )
--as
--set nocount on 
--if @IDSucursal is null
--	set @IDSucursal = 0
--SELECT    C.IDCliente ,C.Nombre   ,C.EsFarmacia  ,C.IDTipo , T. Descr DescrTipo, C.Farmacia ,
--	C.FechaIngreso, C.IDCategoria , Cat.Descr DescrCategoria, C.IDVendedor , V.Nombre  NombreVendedor,
--	C.IDDepto ,D.Descr DescrDepto,  C.IDMunicipio , M.Descr DescrMunicipio,
--	C.IDZona ,Z.Descr DescrZona, C.IDSubZona, sz.Descr DescrSubZona,
--	C.IDNivel, P.Descr DescrNivel, C.IDMoneda , N.Descr DescrMoneda,
--	C.RUC ,C.LimiteCredito ,C.IDBodega IDSucursal , B.Descr DescrSucursal, C.Direccion ,C.Telefono,
--            C.Celular  ,C.Dueno , FechaIngreso ,C.foto  ,C.PorcInteres, 
--            C.Plazo ,C.email ,C.pweb ,C.Activo ,C.Cedula, C.EditaNombre, C.Credito, C.flgEspecial
--FROM dbo.ccfClientes C left join dbo.fafTipoCliente T on C.IDTipo = T.IDTipo 
--left join dbo.fafCategoriaCliente Cat on C.IDCategoria = Cat.IDCategoria 
--left join dbo.fafVendedor V on C.IDVendedor  = V.IDVendedor 
--left join dbo.globalDepto D on C.IDDepto   = D.IDDepto 
--left join dbo.globalMunicipio M on C.IDDepto   = M.IDDepto and C.IDMunicipio = M.IDMunicipio 
--left join dbo.globalZona Z on C.IDZona    = Z.IDZona 
--left join dbo.globalSubZona SZ on C.IDZona     = sz.IDZona  and C.IDSubZona  = sz.IDSubZona  
--left join dbo.invBodega B on C.IDBodega    = B.IDBodega  
--left join dbo.fafNivelPrecio P on C.IDNivel    = P.IDNivel 
--left join dbo.globalmoneda N on C.IDMoneda    = N.IDMoneda 
--WHERE (C.IDBodega  = @IDSucursal or @IDSucursal = 0) and (C.IDCliente = @IDCliente or @IDCliente = 0 )
--go

--drop procedure exec dbo.fafgetVendedores 1
Create Procedure dbo.fafgetVendedores ( @IDVendedor int )
as
set nocount on
Select V.IDVendedor, V.Nombre , V.Telefono,  V.Cedula, v.Celular, v.Direccion, v.IDTipo,G.IDGrupo, G.Descr DescrGrupo, T.Descr DescrTipo, V.email,  V.Activo 
from dbo.fafVendedor V inner join dbo.fafTipoVendedor T
on V.IDTipo = T.IDTipo inner join dbo.fafGrupoVendedor G
on V.IDGrupo = G.IDGrupo 
where IDVendedor = @IDVendedor
go


Create Procedure dbo.fafUpdateCategoriaCliente  @Operacion nvarchar(1),
@IDCategoria int, @Descr nvarchar(255), @Activo bit, @IDCtrFondoxDepos int, @IDCtaFondoxDepos int,
@IDCtrCxC int, @IDCtaCxC  int, @IDCtrIVA int, @IDCtaIVA  int, @IDCtrAnticipo int, @IDCtaAnticipo  int,
@IDCtrCierreDeb int, @IDCtaCierreDeb  int, @IDCtrCierreCred int, @IDCtaCierreCred  int
as
set nocount on
if @Operacion = 'I'
begin
INSERT INTO [dbo].[fafCategoriaCliente] (
IDCategoria, Descr, Activo, IDctrFondoxDepos, IDctaFondoxDepos , IDCtrCxC , IDCtaCxC, IDCtrIVA , IDCtaIVA, 
	IDCtrAnticipo , IDCtaAnticipo, IDCtrCierreDeb , IDCtaCierreDeb, IDCtrCierreCred , IDCtaCierreCred)
values (
@IDCategoria, @Descr, @Activo, @IDctrFondoxDepos, @IDctaFondoxDepos , @IDCtrCxC , @IDCtaCxC, @IDCtrIVA , @IDCtaIVA, 
	@IDCtrAnticipo , @IDCtaAnticipo, @IDCtrCierreDeb , @IDCtaCierreDeb, @IDCtrCierreCred , @IDCtaCierreCred)
end

 if @Operacion  = 'U'
 begin
 Update dbo.fafCategoriaCliente set Descr = @Descr, Activo = @Activo, IDctrFondoxDepos= @IDctrFondoxDepos,
 IDctaFondoxDepos= @IDctaFondoxDepos, IDCtrCxC = @IDCtrCxC, IDCtaCxC = @IDCtaCxC,
 IDCtrIVA = @IDCtrIVA , IDCtaIVA = @IDCtaIVA, IDCtrAnticipo = @IDCtrAnticipo , IDCtaAnticipo = @IDCtaAnticipo,
 IDCtrCierreDeb = @IDCtrCierreDeb,  IDCtaCierreDeb = @IDCtaCierreDeb, 
 IDCtrCierreCred = @IDCtrCierreCred,  IDCtaCierreCred = @IDCtaCierreCred
 end

if @Operacion  = 'D'
 begin
 Delete dbo.fafCategoriaCliente Where IDCategoria = @IDCategoria 
 end

go

-- exec dbo.fafgetCategoriaCliente 1
Create Procedure dbo.fafgetCategoriaCliente (@IDCategoria int)
as
set nocount on
Select IDCategoria, Descr, Activo, IDctrFondoxDepos, IDctaFondoxDepos , IDCtrCxC , IDCtaCxC, IDCtrIVA , IDCtaIVA, 
	IDCtrAnticipo , IDCtaAnticipo, IDCtrCierreDeb , IDCtaCierreDeb, IDCtrCierreCred , IDCtaCierreCred 
From dbo.fafCategoriaCliente
Where IDCategoria = @IDCategoria 
go

Create Procedure fafUpdateVendedor @Operacion nvarchar(1),
	@IDVendedor int ,
	@Nombre nvarchar(255) ,
	@IDTipo int = NULL,
	@IDGrupo int = NULL,
	@Direccion nvarchar(255) = NULL,
	@Telefono nvarchar(25) = NULL,
	@Celular nvarchar(25) =NULL,
	@Cedula nvarchar(25) =NULL,
	@email nvarchar(250) =NULL,
	@Activo bit = NULL
as 
set nocount on
if @Operacion = 'I'
begin
INSERT INTO [dbo].[fafVendedor] (
IDVendedor, Nombre, IDTipo, IDGrupo, Direccion , Telefono , Celular, Cedula , email, Activo )
values (	@IDVendedor, @Nombre, @IDTipo, @IDGrupo, @Direccion , @Telefono , @Celular, @Cedula , @email, @Activo)
end
 if @Operacion  = 'U'
 begin
 Update dbo.fafVendedor set Nombre =  @Nombre , IDTipo = @IDTipo, IDGrupo = @IDGrupo, Direccion= @Direccion, Telefono = @Telefono,
 Celular = @Celular , email = @email, Activo = @Activo 	
 where IDVendedor = @IDVendedor 
 end
 if @Operacion  = 'D'
 begin
	Delete From dbo.fafVendedor where IDVendedor = @IDVEndedor 
 end
 go


Create Function dbo.fafVendedorTeleVenta ( @IDVendedor int )
RETURNS int   
AS
begin
declare @Result as smallint  
if exists (
Select IDTipo 
from dbo.fafTipoVendedor  
where Descr like 'Tele%Venta%' 
and IDTipo in ( Select IDTipo  from dbo.fafVendedor where IDVendedor = @IDVendedor )
) 
	set @Result = 1
else
	set @Result = 0
Return @Result 
end
go
-- select dbo.fafGetNextPedido (1)
Create Function dbo.fafGetNextPedido ( @IDBodega int )
returns int
as
begin
Declare @Next int
	set @Next = isnull((select max(Pedido) from dbo.fafPedido Where IDBodega = @IDBodega ),0)
	set @Next = @Next + 1
	return @Next
end
go

-- delete from dbo.fafpedido
-- Exec dbo.fafUpdatePedido 'I',0,1,1,2,1,'07/04/18 23:10:54','07/04/18 23:10:54',0,0,'I',0,'dsd',1
--Exec dbo.fafUpdatePedido" & vbCrLf & "'I',0,1,1,7,1,'20181001','20181001',0,0,'C',0,'',1
Create Procedure dbo.fafUpdatePedido @Operacion nvarchar(1),@IDPedido int,@IDBodega int ,
	@Pedido int ,@IDCliente int ,@IDVendedor int ,	@Fecha datetime ,@FechaRequerida datetime ,
	@Anulado bit ,	@EsTeleventa bit ,	@Estado nvarchar(1) ,	@IDFactura bigint ,	@Nota nvarchar(255) ,
	@IDTipoEntrega int, @IDNivel int, @IDMoneda int, @TipoCambio decimal(28,4), @IDPlazo int
as
set nocount on 
--set @FechaRequerida = CONVERT(VARCHAR(23), @FechaRequerida, 110)
--set @Fecha = CONVERT(VARCHAR(23), @Fecha, 110)

if @Operacion = 'I'
begin 
declare 	@IDDepto int ,	@IDMunicipio int ,	@IDZona int ,	@IDSubZona int 

	Select @IDDepto = IDDepto , @IDMunicipio = IDMunicipio, @IDZona = IDZona , @IDSubZona = IDSubZona ,
	@IDNivel = IDNivel, @IDMoneda = IDMoneda, @IDPlazo = Plazo
	from dbo.ccfClientes 
	where IDCliente = @IDCliente 
	
	insert dbo.fafPedido ([IDBodega]  ,[Pedido]  ,[IDCliente]
	  ,[IDVendedor]  ,[IDDepto]  ,[IDMunicipio]  ,[IDZona]  ,[IDSubZona]  ,[Fecha]
	  ,[FechaRequerida]  ,[Anulado]  ,[EsTeleventa] ,[Estado]  ,[IDFactura] ,[Nota]
	  ,[IDTipoEntrega], IDNivel , IDMoneda, TipoCambio , IDPlazo
	)
	values (@IDBodega  ,@Pedido  ,@IDCliente
	  ,@IDVendedor  ,@IDDepto  ,@IDMunicipio  ,@IDZona  ,@IDSubZona  ,@Fecha
	  ,@FechaRequerida  ,@Anulado  ,@EsTeleventa ,@Estado  ,@IDFactura ,@Nota
	  ,@IDTipoEntrega, @IDNivel, @IDMoneda, @TipoCambio, @IDPlazo
	)
end
if @Operacion = 'U'
begin 
	update dbo.fafPedido set FechaRequerida = @FechaRequerida  ,
	Anulado = @Anulado  ,EsTeleventa= @EsTeleventa ,Estado = @Estado  ,
	IDFactura= @IDFactura ,Nota = @Nota	  ,IDTipoEntrega = @IDTipoEntrega,
	IDNivel = @IDNivel, IDMoneda = @IDMoneda, TipoCambio  = @TipoCambio , IDPlazo = @IDPlazo
	where Pedido = @Pedido and IDBodega = @IDBodega 
end

if @Operacion = 'D'
begin 
	if exists (select IDPedido FROM dbo.fafPedido 
	where Pedido = @Pedido and IDBodega = @IDBodega 
	and Estado = 'C')
	begin 
	Delete From dbo.fafPedidoProd  
	where IDPedido = @IDPedido and IDBodega = @IDBodega 
	
	DELETE FROM dbo.fafPedidoProd 
	where IDPedido = @IDPedido and IDBodega = @IDBodega 

	end
end
GO 
-- fafUpdatePedidoProd 1
--Create Procedure dbo.fafUpdatePedidoProd @Operacion nvarchar(1),
--	@IDPedido int, @IDBodega int,
--	@IDProducto bigint ,@Cantidad decimal(28, 4) ,
--	@PrecioLocal decimal(28, 4) , @PrecioDolar decimal(28, 4) ,
--	@ImpuestoLocal decimal(28, 4), @ImpuestoDolar decimal(28, 4),
--	@SubTotalLocal decimal(28, 4), @SubTotalDolar decimal(28, 4),
--	@SubTotalFinalLocal decimal(28, 4), @SubTotalFinalDolar decimal(28, 4),
--@Bonifica bit ,@BonifConProd bit , @CantBonificada  decimal (28,4), @CantPrecio  decimal (28,4), 
--@DescuentoLocal  decimal (28,4) , @DescuentoDolar  decimal (28,4) , 
--@PorcDescuentoEsp   decimal (28,4), @DescuentoEspecialLocal  decimal (28,4) , 
--@DescuentoEspecialDolar  decimal (28,4)
--as
--set nocount on 
--if @Operacion = 'I'
--begin
--	Insert dbo.fafPedidoProd (IDPedido, IDBodega , IDProducto, Cantidad, PrecioLocal, PrecioDolar,    ImpuestoLocal,   ImpuestoDolar, SubtotalLocal, SubTotalDolar, SubtotalFinalLocal, SubTotalFinalDolar,
--	Bonifica  ,BonifConProd  , CantBonificada  , CantPrecio  , DescuentoLocal   , DescuentoDolar,
--PorcDescuentoEsp   , DescuentoEspecialLocal, DescuentoEspecialDolar    )
--	values (@IDPedido, @IDBodega , @IDProducto, @Cantidad, @PrecioLocal, @PrecioDolar,  @ImpuestoLocal, @ImpuestoDolar, @SubtotalLocal, @SubTotalDolar,@SubtotalFinalLocal, @SubTotalFinalDolar,
--	@Bonifica  ,@BonifConProd  , @CantBonificada  , @CantPrecio  , @DescuentoLocal    ,@DescuentoDolar,
--	@PorcDescuentoEsp   , @DescuentoEspecialLocal, @DescuentoEspecialDolar    ) 
--end
--if @Operacion = 'U'
--begin
--	if exists(Select IDPedido From dbo.fafPedido where IDPedido = @IDPedido and IDBodega = @IDBodega
--	and Estado = 'C')
--	begin
--	Update dbo.fafPedidoProd  set Cantidad = @Cantidad, PrecioDolar = @PrecioDolar, PrecioLocal = @PrecioLocal ,
--	 ImpuestoLocal = @ImpuestoLocal , ImpuestoDolar = @ImpuestoDolar, SubTotalLocal = @SubTotalLocal , SubTotalDolar = @SubTotalDolar,
--	 Bonifica = @Bonifica  ,BonifConProd=@BonifConProd  , CantBonificada=@CantBonificada  , CantPrecio=@CantPrecio  ,DescuentoLocal=@DescuentoLocal   , 
--	 DescuentoDolar=@DescuentoDolar   ,PorcDescuentoEsp = @PorcDescuentoEsp  , DescuentoEspecialLocal = @DescuentoEspecialLocal 
--	 , DescuentoEspecialDolar = @DescuentoEspecialDolar 
--	where IDPedido = @IDPedido and IDBodega = @IDBodega and IDProducto = @IDProducto 
--	end
--end
--if @Operacion = 'D'
--begin
--	if exists(Select IDPedido From dbo.fafPedido where IDPedido = @IDPedido and IDBodega = @IDBodega
--	and Estado = 'C')
--	begin
--	Delete from dbo.fafPedidoProd 
--	where IDPedido = @IDPedido and IDBodega = @IDBodega and IDProducto = @IDProducto 
--	end
--end
--go

Create Function dbo.getAutoIDInt()
returns int
begin
	return @@Identity
end
go

Create Function dbo.getAutoIDBigInt()
returns bigint
begin
	return @@Identity
end
go

Create Function dbo.getPorcImpuestoFromProducto(@IDProducto bigint)
returns decimal(28,4)
begin
Declare @PorcImpuesto decimal(28,4)
	set @PorcImpuesto = (
	SELECT Porc
	FROM dbo.globalImpuesto 
	where IDImpuesto in (
	Select TipoImpuesto  
	From dbo.invProducto 
	Where IDProducto = @IDProducto 
	)
	)
	return isnull(@PorcImpuesto,0) 
end
go
-- drop view dbo.vCliente select * from dbo.vclientes 
Create View dbo.vClientes
as
Select C.IDCliente, C.Nombre , C.Telefono , C.Direccion, C.EsFarmacia, C.Farmacia, C.IDTipo, T.Descr DescrTipo,
C.IDCategoria, G.Descr DescrCategoria, C.Activo, C.flgEspecial, C.IDEvaluacion, E.Descr DescrEvaluacion 
From dbo.ccfClientes C inner join fafTipoCliente T on C.IDTipo = T.IDTipo 
inner join dbo.fafCategoriaCliente G on C.IDCategoria = G.IDCategoria inner join dbo.fafEvaluacionCliente E
on C.IDEvaluacion = E.IDEvaluacion 
go

-- drop procedure dbo.fafUpdateTablaBonificacion delete from dbo.fafTablaBonificacion where idtabla = 5
--exec dbo.fafUpdateTablaBonificacion 'I', 1, 1, 3, 18, 10, 1,1, '20180301', '20180430', 1
--select * from dbo.fafTablaBonificacion 
	--exec dbo.fafUpdateTablaBonificacion 'I',0,1,3,1,1,1,1, '#14/04/18#','#18/04/18#'

--exec dbo.fafUpdateTablaBonificacion 'I',0,1,4,14,2,1,1, '14/04/18','14/04/18'
--Create procedure dbo.fafUpdateTablaBonificacion @Operacion nvarchar(1), @IDTabla int, 
--@IDProveedor int , @IDProducto bigint , @Requerido decimal(28,2) , @Bono decimal(28,2) , 
--@CantBonifProv decimal(28,2) ,@CantBonifDist decimal(28,2) , @Desde date, @Hasta date,
--@TodosProdProveedor bit = null

--as
--set nocount on 
--if @TodosProdProveedor is null
--	set @TodosProdProveedor = 0
	
--if @Operacion = 'I' 
--	if @TodosProdProveedor = 1 
--	begin
--	Delete from dbo.fafTablaBonificacion where IDProveedor = @IDProveedor 
--	Insert dbo.fafTablaBonificacion ( IDProveedor , IDProducto, Requerido, Bono, CantBonifProv , CantBonifDist, Desde, Hasta)
--	Select IDProveedor, IDProducto , @Requerido, @Bono, @CantBonifProv , @CantBonifDist, @Desde, @Hasta 
--	from dbo.invProveedorProducto 
--	where IDProveedor = @IDProveedor 
--	end
--	else
--	begin
--	Insert dbo.fafTablaBonificacion ( IDProveedor , IDProducto, Requerido, Bono, CantBonifProv , CantBonifDist, Desde, Hasta )
--	values ( @IDProveedor , @IDProducto, @Requerido, @Bono, @CantBonifProv , @CantBonifDist, @Desde, @Hasta  )
--	end

--if @Operacion = 'U'
--begin
--	Update dbo.fafTablaBonificacion set Requerido = @Requerido , Bono = @Bono , CantBonifProv = @CantBonifProv ,
--	Desde = @Desde , Hasta = @Hasta 
--	where (@TodosProdProveedor = 0 and   IDTabla = @IDTabla ) or
--	(@TodosProdProveedor = 1 and  IDProveedor = @IDProveedor)
--end
--if @Operacion = 'D'
--begin
--	Delete from dbo.fafTablaBonificacion
--	where (@TodosProdProveedor = 0 and   IDTabla = @IDTabla ) or
--	(@TodosProdProveedor = 1 and  IDProveedor = @IDProveedor)
--end
--go

-- exec fafgetTablaBonificacion 0,4 select * from dbo.fafPromociones
--exec dbo.fafUpdatePromociones 'F',78 ,1,100,5.00,7.00, '20201101','20201130',1,0
create procedure dbo.fafUpdatePromociones @Operacion nvarchar(1), @IDPromocion int, 
@IDProveedor int , @IDProducto bigint ,@PorcDesc decimal(28,2) , @PorcDescCliEsp decimal(28,2) , @Desde date, @Hasta date,@RequiereBonif bit,
@TodosProdProveedor bit = null 

as
set nocount on 
if @TodosProdProveedor is null
	set @TodosProdProveedor = 0
	
if @Operacion = 'I' 
	if @TodosProdProveedor = 1 
	begin 
	Delete from dbo.fafPromociones  where IDProveedor = @IDProveedor 
	Insert dbo.fafPromociones ( IDProveedor , IDProducto,  PorcDesc, PorcDescCliEsp, Desde, Hasta, RequiereBonif )
	Select L.IDProveedor , L.IDProducto,  L.PorcDesc, L.PorcDescCliEsp, L.Desde, L.Hasta, L.RequiereBonif 
	From (
	Select IDProveedor, IDProducto , @PorcDesc PorcDesc , @PorcDescCliEsp PorcDescCliEsp, @Desde Desde, @Hasta Hasta, @RequiereBonif RequiereBonif
	from dbo.invProducto 
	where IDProveedor = @IDProveedor ) L left join fafPromociones R
	on L.IDProveedor = R.IDProveedor and L.IDProducto = R.IDProducto 
	Where R.IDProducto is null and R.IDProveedor is null 
	end
	else
	begin
	Delete from dbo.fafPromociones  where IDProveedor = @IDProveedor and IDProducto = @IDProducto
	Insert dbo.fafPromociones ( IDProveedor , IDProducto,  PorcDesc,  PorcDescCliEsp, Desde, Hasta, RequiereBonif )
	values ( @IDProveedor , @IDProducto, @PorcDesc , @PorcDescCliEsp ,@Desde, @Hasta, @RequiereBonif)
	end

if @Operacion = 'U'
begin
	Update dbo.fafPromociones set 
	PorcDesc = @PorcDesc  ,	PorcDescCliEsp = @PorcDescCliEsp  ,Desde = @Desde , Hasta = @Hasta, RequiereBonif = @RequiereBonif
	where (@TodosProdProveedor = 0 and   IDPromocion = @IDPromocion ) or
	(@TodosProdProveedor = 1 and  IDProveedor = @IDProveedor)
end
if @Operacion = 'D'
begin
	Delete from dbo.fafPromociones
	where (@TodosProdProveedor = 0 and   IDPromocion = @IDPromocion ) or
	(@TodosProdProveedor = 1 and  IDProveedor = @IDProveedor)
end
if @Operacion = 'F'
begin
	Update dbo.fafPromociones set Desde = @Desde , Hasta = @Hasta
	Where (@TodosProdProveedor = 1 and  IDProveedor = @IDProveedor)
end


go

--exec  dbo.fafgetPromociones 1,0
Create Procedure dbo.fafgetPromociones @IDProveedor int, @IDProducto bigint = null
as


if @IDProducto is null
	set @IDProducto = 0

set nocount on 
SELECT T.IDPromocion , T.IDProveedor, P.Nombre, T.IDProducto, A.Descr Descr, T.porcDesc, T.PorcDescCliEsp, T.Desde, T.Hasta, T.RequiereBonif 
FROM dbo.fafPromociones  T inner join dbo.cppProveedor P on T.IDProveedor = P.IDProveedor 
inner join dbo.invProducto A on T.IDProducto = A.IDProducto 
where (( @IDProveedor = 0  ) or ( @IDProveedor <> 0 and T.IDProveedor = @IDProveedor ) ) 
and
(@IDProducto = 0 or (@IDProducto <> 0 and T.IDProducto = @IDProducto))
order by T.IDProveedor 

go



--drop view select * from  dbo.vProductos 
Create view dbo.vProductos 
as 
SELECT P.IDProducto, P.Descr, U.Descr Presentacion, P.Alias, P.CostoUltLocal, P.CostoUltDolar, P.CostoPromLocal, P.CostoPromDolar,
isnull(P.Clasif1,'ND') IDClasif1, isnull(C1.Descr,'ND') Clasif1, 
isnull(P.Clasif2,'ND') IDClasif2, isnull(C2.Descr,'ND') Clasif2, 
isnull(P.Clasif3,'ND') IDClasif3, isnull(C3.Descr,'ND') Clasif3, 
isnull(P.Clasif4,'ND') IDClasif4, isnull(C4.Descr,'ND') Clasif4, 
isnull(P.Clasif5,'ND') IDClasif5, isnull(C5.Descr,'ND') Clasif5, 
isnull(P.Clasif6,'ND') IDClasif6, isnull(C6.Descr,'ND') Clasif6,
P.Activo, P.Bonifica 
FROM DBO.INVPRODUCTO P 
LEFT JOIN DBO.invClasificacion C1 ON P.CLASIF1 = C1.IDCLASIFICACION 
LEFT JOIN DBO.invClasificacion C2 ON P.CLASIF2 = C2.IDCLASIFICACION 
LEFT JOIN DBO.invClasificacion C3 ON P.CLASIF3 = C3.IDCLASIFICACION 
LEFT JOIN DBO.invClasificacion C4 ON P.CLASIF4 = C4.IDCLASIFICACION 
LEFT JOIN DBO.invClasificacion C5 ON P.CLASIF5 = C5.IDCLASIFICACION 
LEFT JOIN DBO.invClasificacion C6 ON P.CLASIF6 = C6.IDCLASIFICACION 
inner join dbo.invUnidadMedida U on P.IDUnidad = U.IDUnidad 
go

-- exec dbo.fafgetProductos 0 select * from dbo.vProductos
create Procedure dbo.fafgetProductos (@IDProducto bigint, @IncluyeInactivos bit = null )
as
set nocount on 
if @IncluyeInactivos is null
	set @IncluyeInactivos = 0
SELECT IDProducto, Descr, Alias, Presentacion,  Clasif1,Clasif2, Clasif3, Clasif4, Clasif5 , Clasif6, Activo, CostoPromDolar, CostoPromLocal, Bonifica 
FROM dbo.vProductos 
Where ( IDProducto = @IDProducto or @IDProducto = 0 ) and  (@IncluyeInactivos = 0 or (@IncluyeInactivos = 1 and Activo in (0,1)))
go

 --Exec dbo.fafgetPedido 0,0,'20180927','20201030', 'F',0  25,0,'20180927','20201030', 'F',0
-- exec dbo.fafgetPedido 24,1, NULL, NULL, '*',0  exec dbo.fafgetPedido 0,0,'20180101','20201002', 'A',0
Create Procedure dbo.fafgetPedido (@IDPedido int, @IDBodega int , @FechaInic date = null, @FechaFin date = null, @Estado nvarchar(1) = null, @Consolidado   bit = 0 )
AS
set nocount on 
if @IDPedido is null
	set @IDPedido = 0
if @FechaInic is null
	set @FechaInic = '20000101'
if @FechaFin is null 
	set @FechaFin = (select cast(GETDATE () as DATE))
if @Estado is null
	set @Estado = '*'	


SELECT P.IDPedido, P.Pedido, P.Fecha,  P.IDCliente , Cl.Nombre , L.IDProducto,
A.Descr,  Cantidad , 	L.PrecioLocal ,  L.PrecioDolar , 
	L.SubTotalLocal ,  L.SubTotalDolar , 
	L.ImpuestoLocal , L.ImpuestoDolar ,
	L.DescuentoLocal ,  L.DescuentoDolar   , 
	L.porcImpuesto PorcImp, 
	L.DescuentoEspecialLocal ,  L.DescuentoEspecialDolar, 
	L.SubtotalFinalLocal ,  L.SubtotalFinalDolar ,
	
P.FechaRequerida, P.Anulado , P.EsTeleventa, P.Estado, E.Descr DescrEstado, P.IDBodega,
P.IDVendedor, P.IDTipoEntrega, Cl.Farmacia, CAST(0 as bit) LoteAsignado,
P.IdNivel, P.IDMoneda,M.Nacional, P.idPlazo, 
L.Bonifica  ,BonifConProd  , CantBonificada  , CantPrecio  ,
PorcDescuentoEsp   , 
L.SubTotalFinalLocal+L.ImpuestoLocal  TotalFinalLocal,  L.SubTotalFinalDolar+L.ImpuestoDolar TotalFinalDolar,
L.PrecioLista, L.Ahorro, Cl.LimiteCredito, Cl.DisponibleCredito
into #Detalle
FROM DBO.fafPedido P inner join dbo.fafPedidoProd L
on P.IDPedido = L.IDPedido and P.IDBodega = L.IDBodega 
inner join dbo.invBodega B on L.IDBodega = B.IDBodega 
inner join dbo.invProducto A on A.IDProducto = L.IDProducto 
inner join dbo.ccfClientes Cl on P.IDCliente = Cl.IDCliente 
inner join dbo.fafEstadoPedido E on P.Estado = E.Estado 
left join dbo.globalImpuesto I on  A.TipoImpuesto = I.IDImpuesto 
inner join dbo.globalMoneda M  
on P.IDMoneda = M.IDMoneda
WHERE (@IDPedido = 0 or P.IDPedido = @IDPedido) and (P.IDBodega = @IDBodega or @IDBodega = 0 ) and 
(P.Fecha between @FechaInic and @FechaFin ) and
(@Estado = '*' or P.Estado = @Estado ) --and Anulado = 0
 if @Consolidado = 0
 begin
	Select IDPedido, Pedido, Fecha, IDCliente , Nombre , IDProducto,
	Descr,  Cantidad ,
	FechaRequerida, Anulado , EsTeleventa, Estado,  DescrEstado, IDBodega, IDVendedor, IDTipoEntrega, Farmacia, 
	LoteAsignado, IDPlazo, IDNivel, IDMoneda,Nacional,Bonifica  ,BonifConProd  , CantBonificada  , CantPrecio  ,
	 PrecioLocal, PrecioDolar,
	 SubTotalLocal, SubTotalDolar, PorcImp,
	 ImpuestoLocal,ImpuestoDolar,
	 DescuentoLocal , DescuentoDolar ,
	 PorcDescuentoEsp   , 
	 DescuentoEspecialLocal, DescuentoEspecialDolar,
	 SubTotalFinalLocal,SubTotalFinalDolar,
	 TotalFinalLocal, TotalFinalDolar, PrecioLista, Ahorro, LimiteCredito, DisponibleCredito
	From #Detalle
 end
 
 if @Consolidado = 1
 begin
	Select IDPedido, Pedido, Fecha, IDCliente , Nombre , LimiteCredito, DisponibleCredito, FechaRequerida, Anulado , EsTeleventa, Estado,  DescrEstado , IDBodega, IDNivel, IDMoneda,Nacional,IDPlazo,
	SUM( SubTotalLocal) SubTotalLocal, SUM( SubTotalDolar) SubTotalDolar,
	Sum(DescuentoLocal) DescuentoLocal,  Sum(DescuentoDolar) DescuentoDolar,
	Sum(DescuentoEspecialLocal) DescuentoEspecialLocal,   Sum(DescuentoEspecialDolar) DescuentoEspecialDolar,
	Sum(ImpuestoLocal) ImpuestoLocal,  Sum(ImpuestoDolar) ImpuestoDolar, 
	Sum(SubTotalFinalLocal) SubTotalFinalLocal,  Sum(SubTotalFinalDolar) SubTotalFinalDolar	,
	Sum(TotalFinalLocal) TotalFinalLocal, Sum(TotalFinalDolar) TotalFinalDolar
	From #Detalle
	Group by IDPedido, Pedido, Fecha, IDCliente , Nombre , LimiteCredito, DisponibleCredito, FechaRequerida, Anulado , EsTeleventa, Estado,  DescrEstado, IDBodega, IDNivel, IDMoneda,Nacional, IDPlazo
	Order by IDPedido, Pedido, Fecha, IDCliente , Nombre , FechaRequerida, Anulado , EsTeleventa, Estado,  DescrEstado, IDBodega, IDNivel, IDMoneda,Nacional, IDPlazo
 end 
 drop table #Detalle
go



Create Table dbo.fafPrecios ( IDPrecio int not null identity (1,1),
IDProducto bigint not null, IDNivel int not null, IDMoneda int not null, Precio decimal(28,2) default 0, Publico decimal(28,2) default 0 )
go

alter table dbo.fafPrecios add constraint pkfafPrecios primary key (IDPrecio)
go

alter table dbo.fafPrecios add constraint ukfafPrecios UNIQUE (IDProducto, IDNivel, IDMoneda)
go
alter table dbo.fafPrecios add constraint fkfafPreciosProd foreign key  (IDProducto) references dbo.invProducto (IDProducto )
go
alter table dbo.fafPrecios add constraint fkfafPreciosNivel foreign key  (IDNivel) references dbo.fafNivelPrecio (IDNivel )
go
alter table dbo.fafPrecios add constraint fkfafPreciosMoneda foreign key  (IDMoneda) references dbo.globalMoneda (IDMoneda )
go

create Procedure [dbo].[fafUpdatePrecios] @Operacion nvarchar(1),
	@IDProducto bigint ,
	@IDNivel int ,
	@IDMoneda int ,
	@Precio decimal(28, 2)
as
set nocount on
if @Operacion = 'I'
begin
	Insert dbo.fafPrecios (IDProducto,  IDNivel , IDMoneda , Precio )
	values (@IDProducto,  @IDNivel , @IDMoneda , @Precio)
end
if @Operacion = 'U'
begin
	Update dbo.fafPrecios set Precio = @Precio
	where IDProducto = @IDProducto and IDNivel = @IDNivel and IDMoneda = @IDMoneda 
end
if @Operacion = 'D'
begin
	Delete dbo.fafPrecios 
	where IDProducto = @IDProducto and IDNivel = @IDNivel and IDMoneda = @IDMoneda 
end

go
-- select * from dbo.invProveedorProducto Exec dbo.fafgetListaPrecio 0,0,0
--Create procedure dbo.fafgetListaPrecio ( @IDProducto bigint, @IDNivel int = null, @IDProveedor int = null )
--as
--set nocount on

--Select isnull(A.IDProveedor,0) IDProveedor , V.Nombre NomProveedor, P.IDProducto, A.Descr , P.IDNivel , N.Descr DescrNivel, P.IDMoneda, M.Descr DescrMoneda, P.Precio 
--From dbo.fafPrecios P inner join dbo.invProducto A on P.IDProducto = A.IDProducto 
--inner join dbo.fafNivelPrecio N on P.IDNivel = N.IDNivel 
--inner join dbo.globalMoneda M on P.IDMoneda = M.IDMoneda 
--inner join dbo.cppProveedor V
--on A.IDProveedor = V.IDProveedor 
--Where (P.IDProducto= @IDProducto or @IDProducto = 0) and
--(P.IDNivel = @IDNivel or @IDNivel = 0) 
--and (isnull(A.IDProveedor,0)= @IDProveedor or @IDProveedor = 0)

--go
-- drop table dbo.fafPrecioCliente
Create Table dbo.fafPrecioCliente (IDPrecioCliente bigint not null identity(1,1), IDCliente int null ,
IDNivel int not null , 
IDProducto bigint not null, IDMoneda int not null, 
 Precio decimal(28,2) default 0, Usuario nvarchar(20) )
go 

alter table dbo.fafPrecioCliente add constraint pkPrecioCliente primary key (IDPrecioCliente)
go

alter table dbo.fafPrecioCliente add constraint fkPrecioClienteCte foreign key (IDCliente) references dbo.ccfClientes(IDCliente)
go

alter table dbo.fafPrecioCliente add constraint fkPrecioClienteProd foreign key (IDProducto) references dbo.invProducto (IDProducto)
go

alter table dbo.fafPrecioCliente add constraint fkPrecioClienteMon foreign key (IDMoneda) references dbo.globalMoneda(IDMoneda)
go

alter table dbo.fafPrecioCliente add constraint fkPrecioClienteNiv foreign key (IDNivel) references dbo.fafNivelPrecio(IDNivel)
go

--drop table dbo.fafBitacoraPrecioCliente
Create table dbo.fafBitacoraPrecioCliente (IDCliente int not null,  IDProducto bigint not null, IDMoneda int not null, Fecha datetime not null, Precio decimal(28,2) default 0, Usuario nvarchar(20), IDFactura bigint null)
go
Alter table dbo.fafBitacoraPrecioCliente add constraint pkbitPrecCli primary key (IDCliente,  IDProducto, IDMoneda, Fecha)
go

alter table dbo.fafBitacoraPrecioCliente add constraint fkbitPrecioClienteCte foreign key (IDCliente) references dbo.ccfClientes(IDCliente)
go

alter table dbo.fafBitacoraPrecioCliente add constraint fkbitPrecioClienteProd foreign key (IDProducto) references dbo.invProducto (IDProducto)
go

alter table dbo.fafBitacoraPrecioCliente add constraint fkbitPrecioClienteMoneda foreign key (IDMoneda) references dbo.globalMoneda (IDMoneda)
go

alter table dbo.fafBitacoraPrecioCliente add constraint fkbitPrecioClientefact foreign key (IDFactura) references dbo.fafFactura (IDFactura)
go

--create Procedure [dbo].[fafUpdatePrecioCliente] @Operacion nvarchar(1),
--	@IDCliente int ,
--	@IDProducto bigint ,
--	@IDMoneda int ,
--	@Precio decimal(28, 2), @Usuario nvarchar(20), @IDFactura bigint = null
--as
--set nocount on
--Declare @IDNivel int
--SELECT @IDNivel = IDCliente from dbo.ccfClientes where IDCliente =@IDCliente 
--if @Operacion = 'I'
--begin
--	Insert dbo.fafPrecioCliente (IDCliente, IDNivel , IDProducto,   IDMoneda , Precio , Usuario )
--	values (@IDCliente, @IDNivel , @IDProducto  , @IDMoneda , @Precio, @Usuario )
--end
--if @Operacion = 'U'
--begin
--	Update dbo.fafPrecioCliente set Precio = @Precio, Usuario = @Usuario 
--	where IDCliente = @IDCliente and IDNivel = @IDNivel and IDProducto = @IDProducto  and IDMoneda = @IDMoneda 
--end
--if @Operacion = 'D'
--begin
--	Delete dbo.fafPrecioCliente 
--	where IDCliente = @IDCliente and IDNivel = @IDNivel and IDProducto = @IDProducto  and IDMoneda = @IDMoneda 
--end
---- si se Factura el precio autorizado para el cliente, al momento de facturar se debe eliminar e insertar en la bitacora
--if @Operacion = 'F'
--begin
--	Delete dbo.fafPrecioCliente 
--	where IDCliente = @IDCliente and IDNivel = @IDNivel and IDProducto = @IDProducto  and IDMoneda = @IDMoneda 
--	insert dbo.fafBitacoraPrecioCliente (IDCliente, IDProducto, Fecha,   IDMoneda , Precio , Usuario, IDFactura  )
--	values (@IDCliente, @IDProducto, GETDATE(), @IDMoneda , @Precio , @Usuario, @IDFactura )
--end
--go
--drop procedure dbo.fafgetPreciosCliente
--Create procedure dbo.fafgetPreciosCliente @IDCliente int 
--as
--set nocount on
--select D.IDCliente, C.Nombre , D.IDProducto , P.Descr , D.IDNivel , N.Descr DescrNivel, D.IDMoneda , M.Descr DescrMoneda, D.Precio 
--from dbo.fafPrecioCliente D inner join dbo.ccfClientes C on D.IDCliente = C.IDCliente 
--inner join dbo.invProducto P on D.IDProducto = P.IDProducto 
--inner join dbo.globalMoneda M on D.IDMoneda = M.IDMoneda
--inner join dbo.fafNivelPrecio N on D.IDnivel = N.IDNivel 
--where (D.IDCliente = @IDCliente or @IDCliente = 0)
--go
-- exec dbo.fafgetProductoLote  0,0

 --drop function   select dbo.fafGetPrecio(7,1,4,2) Precio select * from DBO.fafPrecioCliente select * from DBO.fafPrecios
Create Function dbo.fafGetPrecio (@IDCliente int , @IDNivel int,  @IDProducto int, @IDMoneda int)
returns decimal(28,2)
as
begin
Declare @Precio decimal(28,2)
 
SELECT TOP 1 @Precio = isnull(Precio , 0) 
FROM DBO.fafPrecioCliente 
WHERE IDCliente = @IDCliente AND IDNivel=@IDNivel and IDProducto = @IDProducto AND IDMoneda =@IDMoneda 

IF @Precio is null 
	SELECT  @Precio = Precio FROM DBO.fafPrecios 
	WHERE IDProducto =@IDProducto AND IDNivel = @IDNivel  AND IDMoneda = @IDMoneda 

return (isnull(@Precio,0))	
end
go

 --Drop function select  dbo.fafGetPorcDescuento (127, '20201101',1) select * from DBO.fafPromociones
Create Procedure dbo.fafGetPorcDescuento (@IDProducto int , @Fecha date, @IDCliente int)
as
Set nocount on
Declare @PorcDescuento decimal(28,2), @flgEspecial bit, @flgRequiereBonif bit
Select @flgEspecial = flgEspecial 
From dbo.ccfClientes 
where IDCliente = @IDCliente 
if @flgEspecial is null 
	set @flgEspecial = 0
 
SELECT TOP 1 @PorcDescuento = case when @flgEspecial=0 then isnull(PorcDesc , 0)
	else
	case when PorcDescCliEsp > 0 and PorcDescCliEsp > PorcDesc 
	then PorcDescCliEsp
	else PorcDesc
	end
	end,
	@flgRequiereBonif = RequiereBonif 	
FROM DBO.fafPromociones 
WHERE IDProducto = @IDProducto AND @Fecha between Desde  and Hasta 	
Select isnull(@PorcDescuento, 0) PorcDescuento, isnull(@flgRequiereBonif, 0 ) RequiereBonif
go
-- select * from fafpromociones 
-- select * from fafTablaDescuento order by idproducto
-- Select dbo.fafGetPorcDescuentoConEscala(100, '20201208', 11) select * from dbo.fafTablaDescuento where idproducto = 100
Create Function dbo.fafGetPorcDescuentoConEscala (@IDProducto int , @Fecha date,@CantFactura decimal(28,2))
returns decimal(28,2)
as
begin
Declare @PorcDescuento decimal(28,2)

Declare @Bono int, @MaxEscala int, @MaxDescuento int


	Select @MaxEscala = MAX( CantDesde ), @MaxDescuento = max(Descuento)
	From dbo.fafTablaDescuento 
	Where IDProducto = @IDProducto 


	Select @PorcDescuento = Descuento 
	From dbo.fafTablaDescuento 
	Where IDProducto = @IDProducto and @CantFactura between CantDesde and CantHasta 
	and @Fecha between FechaDesde and FechaHasta

	if @PorcDescuento = @MaxDescuento 	
	set @PorcDescuento = case when @MaxEscala is not null and @MaxEscala >0 
	then cast((@CantFactura / @MaxEscala) as int ) * isnull(@MaxDescuento,0) else 0 end
	
return (isnull(@PorcDescuento,0))	
end
go


--select * from dbo.fafTablaDescuento 

-- exec dbo.[fafgetProductoLote] 1, 1
Create Procedure [dbo].[fafgetProductoLote] @IDBodega int, @IDProducto bigint
as 
Set Nocount on 
Create Table #Resultado ( IDBodega int not null, IDProducto int not null, Descr nvarchar(255),
IDLote int not null, LoteInterno nvarchar(50), LoteProveedor nvarchar(50), FechaVencimiento date,
Existencia decimal(28,2) default 0, AsignadoFA decimal(28,4) default 0, AsignadoBO decimal(28,4) default 0, Atendido bit default 0, AsignadoPrecio decimal(28,4) default 0 )
alter table #Resultado add constraint pkresult primary key (IDBodega, IDPRoducto, IDLote)

insert #Resultado (IDBodega, IDProducto, Descr , IDLote, LoteInterno , LoteProveedor , FechaVencimiento, Existencia, AsignadoFA , AsignadoBO, AsignadoPrecio )
Select E.IDBodega,  E.IDProducto, P.Descr, E.IDLote, L.LoteInterno, L.LoteProveedor, L.FechaVencimiento, 
(E.Existencia + Transito - Reservada) Existencia, 0.00  AsignadoFA , 0.00 AsignadoBO, 0 AsignadoPrecio 
From dbo.invExistenciaBodega E inner join dbo.invLote L 
on E.IDLote = L.IDLote and E.IDProducto= L.IDProducto  join dbo.invProducto P
on E.IDProducto = P.IDProducto 
Where (E.IDBodega = @IDBodega or @IDBodega = 0) and 
(E.IDProducto = @IDProducto or @IDProducto = 0)
order by E.IDProducto, L.FechaVencimiento asc

SELECT IDBodega, IDProducto, Descr , IDLote, LoteInterno , LoteProveedor , FechaVencimiento, Existencia, AsignadoFA , AsignadoBO, Atendido, AsignadoPrecio   
FROM #Resultado 
drop table #Resultado
go


/*
insert dbo.globalConsecMask  (Codigo, Descr, Longitud, Mascara,consecutivo,  Activo, IDModulo)
values ('F','Facturas',12, 'AAANNNAANNNN','FAC001MN0000',1, 500  )
Set @Mascara = 'AAANNNAANNNN'
Set @Valor = 'REC001MN0000'
select @Mascara Mascara, @Valor Valor

*/
-- drop function select  dbo.getMascaraFromConsecMask ( 'F') select dbo.getConsecMask 
--drop table dbo.globalConsecMask
Create table dbo.invUsuarioBodega (Usuario nvarchar(20) not null, IDBodega int not null )
go

Alter Table dbo.invUsuarioBodega add constraint pkinvUsuarioBodega primary key (Usuario, IDBodega)
go
-- exec dbo.invgetBodegasFromUsuario 'azepeda',0
Create Procedure dbo.invgetBodegasFromUsuario @Usuario nvarchar(20), @SoloFacturacion bit = false 
as
if @SoloFacturacion is null 
	set @SoloFacturacion = 0
set nocount on
Select U.Usuario, S.Descr, U.IDBodega, B.Descr, B.CodigoConsecMask
From  dbo.invUsuarioBodega U inner join dbo.secUsuario S on U.Usuario = S.Usuario 
inner join dbo.invBodega B on U.IDBodega = B.IDBodega 
Where U.Usuario = @Usuario and ((@SoloFacturacion = 1 and  Puedefacturar = 1) or @SoloFacturacion = 0 )
go

-- select [dbo].[globalGetLastTipoCambio] ('20181101', 'TVEN')
CREATE FUNCTION [dbo].[globalGetLastTipoCambio] 
(
	@Fecha date, 
	@IDTipoCambio nvarchar(20)
)
RETURNS DECIMAL(28,4)
AS
BEGIN

	DECLARE @TipoCambio AS DECIMAL(28,4)
	SET @TipoCambio = (SELECT Monto  
	FROM dbo.globalTipoCambioDetalle 
	WHERE IDTipoCambio=@IDTipoCambio and  Fecha= (Select Max(Fecha) 
	from dbo.globalTipoCambioDetalle  
	Where Fecha <= @Fecha AND IDTipoCambio=@IDTipoCambio)
	)	
	RETURN isnull(@TipoCambio, 0)
END
go



alter table  dbo.globalTipoCambio add Activo bit default 1
go
update  dbo.globalTipoCambio set activo = 1
go

--drop table  alter table dbo.fafParametros add DigitosDecimales int default 0 update dbo.fafParametros set DigitosDecimales = 2

Create Table dbo.fafParametros ( [IDParametros] [int] IDENTITY(1,1) NOT NULL,
	[IDNivelPrecioPub] [int] NULL,
	[IDPlazoCont] [int] NULL,
	[TipoCambioFact] [nvarchar](20) NULL,
	[TipoCambioCont] [nvarchar](20) NULL,
	[NumeroLineasFact] [int] NULL,
	[IntegracionCont] [bit] NULL,
	[AutorizaPrecioPorFactura] [bit] NULL,
	[IDPaquete] [int] NULL,
	[CtrImpuesto] [int] NULL,
	[CtaImpuesto] [bigint] NULL,
	[paginaFacturaAltura] [decimal](28, 2) NULL,
	[paginaFacturaAncho] [decimal](28, 2) NULL,
	[FacturaPersonalizada] [bit] NULL,
	[DefaultTipoFact] [bit] NULL,
	[TipoFactDefault] [smallint] NULL,
	[DefaultTipoEntrega] [bit] NULL,
	[TipoEntregaDefault] [int] NULL,
	[EditaPrecioPedidoenFactura] [bit] NULL,
	[EditaCantidadPedidoenFactura] [bit] NULL,
	[DigitosDecimales] [int] NULL
) 
go

alter table dbo.fafParametros add constraint pkglobalesfa primary key (IDParametros)
go

alter table dbo.fafParametros add constraint fkglobalesfa foreign key (IDNivelPrecioPub) references dbo.fafNivelPrecio (IDNivel)
go

alter table dbo.fafParametros add constraint fkglobalesplaz foreign key (IDPlazoCont) references dbo.ccfPlazo (Plazo)
go

alter table dbo.fafParametros add constraint fkglobalestcfac foreign key (TipoCambioFact) references dbo.globalTipoCambio (IDTipoCambio)
go

alter table dbo.fafParametros add constraint fkglobalestcont foreign key (TipoCambioCont) references dbo.globalTipoCambio (IDTipoCambio)
go

--alter table dbo.fafParametros add constraint fkparamCtaflet foreign key (IDCuentaFlete) references dbo.cntCuenta (IDCuenta)
--go

--alter table dbo.fafParametros add constraint fkparamCtaImpConsum foreign key (IDCuentaConsumo) references dbo.cntCuenta (IDCuenta)
--go

 --Exec dbo.fafUpdateParametros 1,'1',0,'TVEN','TVEN',10,1, 2,0,5,1, 11.50, 21.50,1,1,2,1,1,1,1,2
--alter Procedure dbo.fafUpdateParametros @IDParametros int ,
--	@IDNivelPrecioPub int ,
--	@IDPlazoCont int ,
--	@TipoCambioFact nvarchar(20) ,
--	@TipoCambioCont nvarchar(20) ,
--	@NumeroLineasFact int ,
--	@IntegracionCont bit ,
--	@IDPaquete int ,
--	@CtrImpuesto int ,
--	@CtaImpuesto bigint ,
--	@AutorizaPrecioPorFactura bit ,
--	@paginaFacturaAltura decimal(28, 2) ,
--	@paginaFacturaAncho decimal(28, 2) ,
--	@FacturaPersonalizada bit ,	
--	@DefaultTipoFact bit ,	
--	@TipoFactDefault smallint ,	
--	@DefaultTipoEntrega bit ,
--	@TipoEntregaDefault int ,
--	@EditaPrecioPedidoenFactura bit ,
--	@EditaCantidadPedidoenFactura bit ,	
--	@DigitosDecimales int

--as
--set nocount on 
--if not exists (select IDParametros from  dbo.fafParametros ) 
--	insert dbo.fafParametros (
--	[IDNivelPrecioPub]
--      ,[IDPlazoCont]
--      ,[TipoCambioFact]
--      ,[TipoCambioCont]
--      ,[NumeroLineasFact]
--      ,[IntegracionCont]
--      ,[AutorizaPrecioPorFactura]
--      ,[IDPaquete]
--      ,[CtrImpuesto]
--      ,[CtaImpuesto]
--      ,[paginaFacturaAltura]
--      ,[paginaFacturaAncho]
--      ,[FacturaPersonalizada]
--      ,[DefaultTipoFact]
--      ,[TipoFactDefault]
--      ,[DefaultTipoEntrega]
--      ,[TipoEntregaDefault]
--      ,[EditaPrecioPedidoenFactura]
--      ,[EditaCantidadPedidoenFactura]
--      ,[DigitosDecimales] ) 
	
--	values (	@IDNivelPrecioPub  ,
--	@IDPlazoCont  ,
--	@TipoCambioFact ,
--	@TipoCambioCont  ,
--	@NumeroLineasFact  ,
--	@IntegracionCont  ,
--	@AutorizaPrecioPorFactura ,
--	@IDPaquete  ,
--	@CtrImpuesto  ,
--	@CtaImpuesto  ,
--	@paginaFacturaAltura  ,
--	@paginaFacturaAncho  ,
--	@FacturaPersonalizada  ,
--	@DefaultTipoFact ,
--	@TipoFactDefault  ,
--	@DefaultTipoEntrega  ,
--	@TipoEntregaDefault  ,
--	@EditaPrecioPedidoenFactura  ,
--	@EditaCantidadPedidoenFactura  ,
--	@DigitosDecimales )
--else
--	Update  dbo.fafParametros set 
--	IDNivelPrecioPub = @IDNivelPrecioPub  ,
--	IDPlazoCont =@IDPlazoCont  ,
--	TipoCambioFact = @TipoCambioFact ,
--	TipoCambioCont = @TipoCambioCont  ,
--	NumeroLineasFact = @NumeroLineasFact  ,
--	IntegracionCont  = @IntegracionCont  ,
--	AutorizaPrecioPorFactura  = @AutorizaPrecioPorFactura ,
--	IDPaquete = @IDPaquete  ,
--	CtrImpuesto = @CtrImpuesto  ,
--	CtaImpuesto = @CtaImpuesto  ,
--	paginaFacturaAltura = @paginaFacturaAltura  ,
--	paginaFacturaAncho = @paginaFacturaAncho  ,
--	FacturaPersonalizada = @FacturaPersonalizada  ,
--	DefaultTipoFact = @DefaultTipoFact ,
--	TipoFactDefault  = @TipoFactDefault  ,
--	DefaultTipoEntrega  = @DefaultTipoEntrega  ,
--	TipoEntregaDefault = @TipoEntregaDefault  ,
--	EditaPrecioPedidoenFactura = @EditaPrecioPedidoenFactura  ,
--	EditaCantidadPedidoenFactura = @EditaCantidadPedidoenFactura  ,
--	DigitosDecimales = @DigitosDecimales
--	Where IDParametros = @IDParametros
--go

--Create Procedure dbo.fafgetParametros @IDParametros int
--as
--set nocount on
--Select  [IDParametros]     ,[IDNivelPrecioPub]      ,[IDPlazoCont]      ,[TipoCambioFact]      ,[TipoCambioCont]
--      ,[NumeroLineasFact]      ,[IntegracionCont]           ,[AutorizaPrecioPorFactura]
--      ,[IDPaquete]      ,[CtrImpuesto]      ,[CtaImpuesto]      ,[paginaFacturaAltura]      ,[paginaFacturaAncho]
--      ,[FacturaPersonalizada]      ,[DefaultTipoFact]      ,[TipoFactDefault]      ,[DefaultTipoEntrega]
--      ,[TipoEntregaDefault]      ,[EditaPrecioPedidoenFactura]      ,[EditaCantidadPedidoenFactura]      ,[DigitosDecimales]
--from dbo.fafParametros 
--where IDParametros = @IDParametros
--go

--Exec dbo.fafUpdateFactura 'I',1,'FAC001MN00001',2, 7,'Julio Espinoza',1,2, '20181004',0,0,null,1,2,15,32.7000,'F',' '
create Procedure dbo.fafUpdateFactura @Operacion nvarchar(1),
	@IDBodega int ,	@Factura nvarchar(20) ,	@IDTipo smallint ,	@IDCliente int ,	@Nombre nvarchar(250) ,
	@IDVendedor int ,	@IDTipoEntrega int ,
	@Fecha datetime ,	@Anulada bit ,	@EsTeleventa bit ,	@IDPedido int ,	@IDNivel int ,	@IDMoneda int ,
	@IDPlazo int ,	@TipoCambio decimal(28, 4) ,	@CodConsecutivo nvarchar(20) ,	@Mensaje nvarchar(250) 
as
set nocount on 
if @Operacion = 'I'
begin

declare 	@IDDepto int ,	@IDMunicipio int ,	@IDZona int ,	@IDSubZona int 

	Select @IDDepto = IDDepto , @IDMunicipio = IDMunicipio, @IDZona = IDZona , @IDSubZona = IDSubZona 
	from dbo.ccfClientes 
	where IDCliente = @IDCliente 

INSERT INTO [dbo].[fafFACTURA]
           ([IDBodega]  ,[Factura]  ,[IDTipo] ,[IDCliente] ,[Nombre]
           ,[IDVendedor] ,[IDDepto]  ,[IDMunicipio]  ,[IDZona]  ,[IDSubZona]  ,[IDTipoEntrega]
           ,[Fecha]  ,[Anulada] ,[EsTeleventa]   ,[IDPedido]    ,[IDNivel]   ,[IDMoneda]
           ,[IDPlazo]  ,[TipoCambio]    ,[CodConsecutivo]   ,[Mensaje]  )
     VALUES  ( @IDBodega ,@Factura,   @IDTipo,  @IDCliente,@Nombre, @IDVendedor, 
            @IDDepto,  @IDMunicipio,@IDZona, @IDSubZona, @IDTipoEntrega  ,@Fecha, @Anulada
           ,@EsTeleventa  ,@IDPedido  ,@IDNivel ,@IDMoneda  ,@IDPlazo  ,@TipoCambio  ,@CodConsecutivo
           ,@Mensaje )           
           	
end

go

--Exec dbo.fafUpdateFacturaProd 'I',@@Identity,1,3,0,0,0,0,0,2,163.5000,50,0,0.0000,00.0000,0,327.0000,10,49.05000,1.5, 1" & vbCrLf & ""
-- select * from [dbo].[fafFacturaProd] where IDFactura = 31
Create Procedure dbo.fafUpdateFacturaProd @Operacion nvarchar(1),
	@IDFactura bigint, 	@IDBodega int ,	@IDProducto bigint ,	
	@Bonifica bit ,	@Requerido decimal (28,4), 	@Bono decimal (28,4), @BonifConProd bit ,
	@CantBonificada  decimal (28,4) , @CantFacturada  decimal (28,4) ,	@CantPrecio  decimal (28,4) ,
	@PrecioLocal  decimal (28,4) , @PrecioDolar  decimal (28,4) ,
	@CostoLocal  decimal (28,4) , @CostoDolar  decimal (28,4) ,
	@DescuentoLocal  decimal (28,4) , @DescuentoDolar  decimal (28,4) ,
	@DescuentoESpecialLocal  decimal (28,4) , @DescuentoEspecialDolar  decimal (28,4) ,
	@SubTotalLocal  decimal (28,4) , @SubTotalDolar  decimal (28,4) ,
	@SubTotalFinalLocal decimal(28,4) ,@SubTotalFinalDolar decimal(28,4), 
	@ImpuestoLocal  decimal (28,4) , @ImpuestoDolar  decimal (28,4) , 
	@Factor int, @PorcDescuentoEsp   decimal (28,4), @PorcImpuesto   decimal (28,4),
	@PrecioLista   decimal (28,4), @Ahorro   decimal (28,4)
as
set nocount on 
if @Operacion = 'I'
begin
INSERT INTO [dbo].[fafFacturaProd]
           ([IDFactura]     ,[IDBodega],[IDProducto]   ,[Bonifica]  ,[Requerido] ,[Bono] ,[BonifConProd]
           ,[CantBonificada]  ,[CantFacturada]  , [CantPrecio]  ,[PrecioLocal]  ,[PrecioDolar]   ,[CostoLocal]
           ,[CostoDolar]  ,[DescuentoLocal] ,[DescuentoDolar] ,[DescuentoEspecialLocal]  ,[DescuentoEspecialDolar]
           ,[SubTotalLocal]  ,[SubTotalDolar]  ,[SubTotalFinalLocal]  ,[SubTotalFinalDolar]  ,[ImpuestoLocal]  ,[ImpuestoDolar]  
           ,[Factor], PorcDescuentoEsp, PorcImpuesto, PrecioLista, Ahorro)
     VALUES  (@IDFactura     ,@IDBodega,@IDProducto   ,@Bonifica  ,@Requerido ,@Bono ,@BonifConProd
           ,@CantBonificada  ,@CantFacturada  , @CantPrecio  ,@PrecioLocal  ,@PrecioDolar   ,@CostoLocal
           ,@CostoDolar  ,@DescuentoLocal ,@DescuentoDolar ,@DescuentoEspecialLocal  ,@DescuentoEspecialDolar
           ,@SubTotalLocal  ,@SubTotalDolar  ,@SubTotalFinalLocal  ,@SubTotalFinalDolar  ,@ImpuestoLocal  ,@ImpuestoDolar  ,@Factor, 
           @PorcDescuentoEsp, @PorcImpuesto, @PrecioLista, @Ahorro)          
           	
end

go
-- select * from dbo.faffacturaprod where idfactura = 41  select * from dbo.faffacturaprodlote where idfacturaprod = 45
Create Procedure dbo.fafUpdateFacturaProdLote @Operacion nvarchar(1),
	 @IDFacturaProd bigint, 	@IDLote int ,	@CantBonificada decimal(28,4) ,	@CantFacturada decimal(28,4) 
as
set nocount on 
if @Operacion = 'I'
begin
	INSERT INTO [dbo].[fafFacturaProdLote] (IDFacturaProd, IDLote, CantBonificada, CantFacturada)
	values  (@IDFacturaProd, @IDLote, @CantBonificada, @CantFacturada)
	
	---- Actualizo la linea a nivel de producto sumarizando los lotes
	--Update P set CantBonificada = L.CantBonificada, CantFacturada = L.CantFacturada , DescuentoLocal =  L.CantBonificada*P.PrecioLocal,
	--DescuentoDolar =  L.CantBonificada*P.PrecioDolar
	--from [dbo].[fafFacturaProd] P inner join (
	--	Select IDFacturaProd , SUM(CantBonificada ) CantBonificada, SUM(CantFacturada ) CantFacturada
	--	from [dbo].[fafFacturaProdLote]
	--	where IDFacturaProd = @IDFacturaProd 
	--	group by IDFacturaProd 
	--	) L on P.IDFacturaProd = L.IDFacturaProd 
	--Where P.IDFacturaProd = @IDFacturaProd
end
go


CREATE View dbo.vfafDetalleProducto
as
SELECT F.IDFactura, F.IDBodega , B.Descr DescrBodega, f.Factura , f.Fecha ,F.IDTipo, T.descr DescrTipo, F.IDTipoEntrega, 
E.Descr DescrEntrega, F.IDVendedor , V.Nombre NombreVendedor , D.Descr DescrDepto, 
f.IDCliente, f.Nombre, C.Farmacia, C.Direccion,  f.Mensaje , f.Anulada , f.EsTeleventa , f.idplazo , Z.Descr DescrPlazo , F.IDNivel,
f.IDMoneda , M.Nacional, M.Descr DescrMoneda, M.Simbolo, P.IDProducto , A.Descr DescrProducto, A.IDUnidad, U.Descr DescrUnidad, P.Cantidad,
P.CantFacturada, P.Bonifica , P.CantBonificada, P.BonifConProd,  
 P.PrecioLocal , P.PrecioDolar ,
 P.CostoLocal , P.CostoDolar ,
 P.DescuentoLocal , P.DescuentoDolar  ,
 P.porcDescuentoEsp,P.DescuentoEspecialLocal , P.DescuentoEspecialDolar  ,
 P.SubTotalLocal , P.SubTotalDolar ,
 P.PorcImpuesto, P.ImpuestoLocal , P.ImpuestoDolar ,
 P.SubTotalFinalLocal , P.SubTotalFinalDolar  ,
 P.Factor, F.IDDepto, f.IDMunicipio , f.IDZona, f.IDSubZona , F.tipoCambio, F.codconsecutivo, P.IDFacturaProd,
 F.pesoKG,  F.Remisionada, F.dateInsert 
FROM DBO.fafFactura F inner join DBO.fafFacturaProd P
on F.IDFactura = P.IDFactura inner join dbo.fafTipoFactura T 
on F.IDTipo = T.IDTipo inner join dbo.fafTipoEntrega E 
on F.IDTipoEntrega= E.IDTipoEntrega inner join dbo.ccfPlazo Z 
on F.idplazo = Z.Plazo inner join dbo.globalMoneda M
on F.IDMoneda = M.IDMoneda inner join dbo.invProducto A
on P.IDProducto = A.IDProducto inner join dbo.fafVendedor V
on F.IDVendedor = V.IDVendedor inner join dbo.invBodega B
on F.IDBodega = B.IDBodega inner join dbo.invUnidadMedida U
on A.IDUnidad = U.IDUnidad inner join dbo.ccfClientes C
on F.IDCliente = C.IDCliente left join dbo.globalDepto D
on F.IDDepto = D.IDDepto
WHERE F.Anulada  = 0
go

--exec dbo.fafPrintFactura 60

--Exec dbo.fafPrintfactura 5
-- 
create Procedure dbo.fafPrintFactura @IDFactura bigint
as
set nocount on 

 SELECT D.IDFactura, D.Factura , D.Fecha, D.IDTipo , D.DescrTipo, D.TipoCambio,
 D.IDTipoEntrega, D.DescrEntrega, D.IDCliente, D.Nombre, D.Farmacia, D.Direccion, D.IDVendedor,  D.EsTeleVenta, D.Anulada, D.DescrPlazo  , 
 D.IDMoneda, D.DescrMoneda, D.Simbolo,  D.IDBodega, D.DescrBodega , D.DescrDepto , 
 D.IDProducto, D.DescrProducto, D.IDUnidad, D.DescrUnidad,   D.Cantidad, D.CantFacturada, D.CantBonificada, D.Bonifica, D.BonifConProd,
case when D.Nacional = 1 then D.PrecioLocal else D.PrecioDolar end Precio,
case when D.Nacional = 1 then D.CostoLocal else D.CostoDolar end Costo,
case when D.Nacional = 1 then D.DescuentoLocal else D.DescuentoDolar  end Descuento,
case when D.Nacional = 1 then D.DescuentoEspecialLocal else D.DescuentoEspecialDolar  end DescuentoEspecial,
case when D.Nacional = 1 then D.Cantidad * D.PrecioLocal  else D.Cantidad * D.PrecioDolar   end SubTotal,
case when D.Nacional = 1 then 
( ((D.Cantidad * D.PrecioLocal) - (D.DescuentoLocal + D.DescuentoEspecialLocal ))  * D.PorcImpuesto/100)  
else 
( ((D.Cantidad * D.PrecioDolar) - (D.DescuentoDolar + D.DescuentoEspecialDolar )) * D.PorcImpuesto/100)   
end Impuesto,
case when D.Nacional = 1 then 
	(D.Cantidad * D.PrecioLocal) - (D.DescuentoLocal + D.DescuentoEspecialLocal ) 
	else 
	(D.Cantidad * D.PrecioDolar) - (D.DescuentoDolar + D.DescuentoEspecialDolar ) 
	end SubTotalFinal,
case when D.Nacional = 1 then 
	(D.Cantidad * D.PrecioLocal) - (D.DescuentoLocal + D.DescuentoEspecialLocal ) 
	+ D.ImpuestoLocal
	else 
	(D.Cantidad * D.PrecioDolar) - (D.DescuentoDolar + D.DescuentoEspecialDolar ) 
	+ D.ImpuestoDolar
	end TotalFinal, D.dateinsert 

 FROM dbo.vfafDetalleProducto D
 WHERE D.IDFactura = @IDFactura
go
-- drop view dbo.vfafFacturaHeader
Create View dbo.vfafFacturaHeader
as
 SELECT D.IDFactura, D.Factura , D.Fecha, D.IDTipo , D.DescrTipo, D.TipoCambio,
 D.IDTipoEntrega, D.DescrEntrega, D.IDCliente, D.Nombre, D.Farmacia, D.IDVendedor,  D.EsTeleVenta, D.Anulada, D.DescrPlazo  , 
 D.IDMoneda, D.DescrMoneda, D.Simbolo,  D.IDBodega, D.DescrBodega , D.DescrDepto , D.Direccion, D.Dateinsert,
sum(case when D.Nacional = 1 then D.DescuentoLocal else D.DescuentoDolar  end) Descuento,
sum(case when D.Nacional = 1 then D.DescuentoEspecialLocal else D.DescuentoEspecialDolar  end) DescuentoEspecial,
sum(case when D.Nacional = 1 then D.Cantidad * D.PrecioLocal  else D.Cantidad * D.PrecioDolar   end) SubTotal,
sum(case when D.Nacional = 1 then 
( ((D.Cantidad * D.PrecioLocal) - (D.DescuentoLocal + D.DescuentoEspecialLocal ))  * D.PorcImpuesto/100)  
else 
( ((D.Cantidad * D.PrecioDolar) - (D.DescuentoDolar + D.DescuentoEspecialDolar )) * D.PorcImpuesto/100)   
end) Impuesto,
sum(case when D.Nacional = 1 then 
	(D.Cantidad * D.PrecioLocal) - (D.DescuentoLocal + D.DescuentoEspecialLocal ) 
	else 
	(D.Cantidad * D.PrecioDolar) - (D.DescuentoDolar + D.DescuentoEspecialDolar ) 
	end) SubTotalFinal,
sum(case when D.Nacional = 1 then 
	(D.Cantidad * D.PrecioLocal) - (D.DescuentoLocal + D.DescuentoEspecialLocal ) 
	+ D.ImpuestoLocal
	else 
	(D.Cantidad * D.PrecioDolar) - (D.DescuentoDolar + D.DescuentoEspecialDolar ) 
	+ D.ImpuestoDolar
	end) TotalFinal 

 FROM dbo.vfafDetalleProducto D
 GROUP BY D.IDFactura, D.Factura , D.Fecha, D.IDTipo , D.DescrTipo, D.TipoCambio,
 D.IDTipoEntrega, D.DescrEntrega, D.IDCliente, D.Nombre, D.Farmacia, D.IDVendedor,  D.EsTeleVenta, D.Anulada, D.DescrPlazo  , 
 D.IDMoneda, D.DescrMoneda, D.Simbolo,  D.IDBodega, D.DescrBodega , D.DescrDepto , D.Direccion, D.Dateinsert
go


-- exec  dbo.fafgetFacturaHeader 14 select * from dbo.vfac
--drop procedure  exec dbo.fafgetFacturaHeader 14
Create Procedure dbo.fafgetFacturaHeader @IDFactura bigint
as
set nocount on 

 SELECT D.IDFactura, D.Factura , D.Fecha, D.IDTipo , D.DescrTipo, D.TipoCambio,
 D.IDTipoEntrega, D.DescrEntrega, D.IDCliente, D.Nombre, D.Farmacia, D.IDVendedor,  D.EsTeleVenta, D.Anulada, D.DescrPlazo  , 
 D.IDMoneda, D.DescrMoneda, D.Simbolo,  D.IDBodega, D.DescrBodega , D.DescrDepto , D.Direccion, D.Dateinsert,
 D.Descuento,
 D.DescuentoEspecial,
 D.SubTotal,
 D.Impuesto,
 D.SubTotalFinal,
 D.TotalFinal 
 FROM dbo.vfafFacturaHeader D
 WHERE (D.IDFactura = @IDFactura)
 
go
-- exec dbo.fafgetFacturasHeader '20201022', '20201022', 0
Create Procedure dbo.fafgetFacturasHeader @FechaInicio date, @FechaFin date, @IDCliente int
as
set nocount on
 SELECT D.IDFactura, D.Factura , D.Fecha, D.IDTipo , D.DescrTipo, D.TipoCambio,
 D.IDTipoEntrega, D.DescrEntrega, D.IDCliente, D.Nombre, D.Farmacia, D.IDVendedor,  D.EsTeleVenta, D.Anulada, D.DescrPlazo  , 
 D.IDMoneda, D.DescrMoneda, D.Simbolo,  D.IDBodega, D.DescrBodega , D.DescrDepto , D.Direccion, D.Dateinsert,
 D.Descuento,
 D.DescuentoEspecial,
 D.SubTotal,
 D.Impuesto,
 D.SubTotalFinal,
 D.TotalFinal 
 FROM dbo.vfafFacturaHeader D
 WHERE (D.IDCliente  = @IDCliente or @IDCliente = 0) and D.Fecha between @FechaInicio and @FechaFin
go

Create Procedure dbo.fafAnulaFactura @IDFactura bigint 
as
set nocount on
Declare @IDCliente int , @MontoFactura decimal (28,4)

Select @IDCliente = IDCliente, @MontoFactura = TotalFinal
From dbo.vfafFacturaHeader
Where IDFactura = @IDFactura

Update dbo.fafFactura set Anulada = 1
where IDFactura = @IDFactura

Update dbo.ccfClientes  set DisponibleCredito = DisponibleCredito + @MontoFactura
where IDCliente = @IDCliente
-- ojo AQUI CREAR EL ASIENTO CONTABLE DE LA ANULACION (REVERSION)
go

create procedure dbo.fafGetMasterSubZonas( @IDZona int=-1, @SoloActivos smallint = 1 )
-- -1 indica que son todos los registros tanto para deptos como para municipios
as 
set nocount on 
Select D.IDZona CodMaster, D.Descr DescrMaster, M.IDSubZona Codigo, M.Descr , M.Activo 
From dbo.globalZona D inner join  dbo.globalSubZona M 
on D.IDZona = M.IDZona 
Where (M.IDZona = @IDZona or @IDZona = -1) and (M.Activo = @SoloActivos or @SoloActivos=-1 )
go



-- hasta aqui la primera version final 17/10/2018


/*
CREATE  TABLE [dbo].[invPaquete](
	[IDPaquete] [int] IDENTITY(1,1) NOT NULL,
	[PAQUETE] [nvarchar](20) NULL,
	[Descr] [nvarchar](250) NULL,
	[IDConsecutivo] [int] NOT  NULL,
	[Transaccion] [nvarchar](3) not NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PKINVPAQUETE] PRIMARY KEY CLUSTERED 
(
	[IDPaquete] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [uk_paquete] UNIQUE NONCLUSTERED 
(
	[PAQUETE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
drop table dbo.cntCuenta 
Create Table dbo.cntCuenta ( 
IDCuenta bigint not null identity (1,1), 
IDGrupo int not null, 
IDTipo int not null,
IDSubTipo int not null, 
Tipo nvarchar(1) not null,
SubTipo nvarchar(1) not null, 
Nivel1 nvarchar(50)  default '', 
Nivel2 nvarchar(50)  default '', 
Nivel3 nvarchar(50)  default '', 
Nivel4 nvarchar(50)  default '' , 
Nivel5 nvarchar(50)  default '',
Nivel6 nvarchar(50)  default '',
Cuenta nvarchar(50) not null default '', 
Descr nvarchar(255),
Complementaria bit default 0,
EsMayor bit default 0, 
AceptaDatos bit default 0,
Activa bit default 1, 
IDCuentaAnterior int not null,
IDCuentaMayor int not null,
UsaCentroCosto bit default 0
)
go

Alter Table dbo.cntCuenta add constraint pkcntCuenta primary key (IDCuenta)
go
*/

--ALTER TABLE dbo.fafParametros ADD IDPaquete INT 
--GO
ALTER TABLE dbo.fafParametros WITH CHECK ADD CONSTRAINT [fk_fafParametros_Paquete] FOREIGN KEY ([IDPaquete])
REFERENCES dbo.invPaquete(IDPaquete)
GO	
ALTER TABLE dbo.fafParametros CHECK CONSTRAINT [fk_fafParametros_Paquete]
GO
--ALTER TABLE dbo.fafParametros ADD CtrImpuesto INT 	
--GO
ALTER TABLE dbo.fafParametros WITH CHECK ADD CONSTRAINT [fk_fafParametros_Centro] FOREIGN KEY ([CtrImpuesto])
REFERENCES dbo.cntCentroCosto(IDCentro)
GO
--ALTER  TABLE dbo.fafParametros ADD CtaImpuesto BIGINT 	
--GO
ALTER TABLE dbo.fafParametros WITH CHECK ADD CONSTRAINT [fk_fafParametros_CuentaContable] FOREIGN KEY ([CtaImpuesto])
REFERENCES dbo.cntCuenta(IDCuenta)
GO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtrCxC INT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_CC_CxC] FOREIGN KEY (CtrCxC)
--REFERENCES dbo.cntCentroCosto(IDCentro)
--GO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtaCxC BIGINT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_Cta_CxC] FOREIGN KEY (CtaCxC)
--REFERENCES dbo.cntCuenta(IDCuenta)
--GO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtrLxC INT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_CC_LxC] FOREIGN KEY (CtrLxC)
--REFERENCES dbo.cntCentroCosto(IDCentro)
--GO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtaLxC BIGINT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_Cta_LxC] FOREIGN KEY (CtaLxC)
--REFERENCES dbo.cntCuenta(IDCuenta)
--GO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtrContado INT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_CC_Contado] FOREIGN KEY (CtrContado)
--REFERENCES dbo.cntCentroCosto(IDCentro)
--GO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtaContado BIGINT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_Cta_Contado] FOREIGN KEY (CtaContado)
--REFERENCES dbo.cntCuenta(IDCuenta)
--GO


--ALTER TABLE  dbo.fafCategoriaCliente ADD CtrRecibosCxC INT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_CC_Recibos] FOREIGN KEY (CtrRecibosCxC)
--REFERENCES dbo.cntCentroCosto(IDCentro)
--GO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtaRecibosCxC BIGINT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_Cta_RecibosCxC] FOREIGN KEY (CtaRecibosCxC)
--REFERENCES dbo.cntCuenta(IDCuenta)
--gO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtrDebitoCxC INT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_CC_DebitoCxC] FOREIGN KEY (CtrDebitoCxC)
--REFERENCES dbo.cntCentroCosto(IDCentro)
--GO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtaDebitoCxC BIGINT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_Cta_DebitoCxC] FOREIGN KEY (CtaDebitoCxC)
--REFERENCES dbo.cntCuenta(IDCuenta)


--gO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtrCreditoCxC INT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_CC_CreditoCxC] FOREIGN KEY (CtrCreditoCxC)
--REFERENCES dbo.cntCentroCosto(IDCentro)
--GO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtaCreditoCxC BIGINT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_Cta_CreditoCxC] FOREIGN KEY (CtaCreditoCxC)
--REFERENCES dbo.cntCuenta(IDCuenta)


--gO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtrImpuestoCxC INT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_CC_ImpuestoCxC] FOREIGN KEY (CtrImpuestoCxC)
--REFERENCES dbo.cntCentroCosto(IDCentro)
--GO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtaImpuestoCxC BIGINT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_Cta_ImpuestoCxC] FOREIGN KEY (CtaImpuestoCxC)
--REFERENCES dbo.cntCuenta(IDCuenta)


--GO

--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_CC_ProntoPagoCxC] FOREIGN KEY (CtrProntoPagoCxC)
--REFERENCES dbo.cntCentroCosto(IDCentro)
--GO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtaProntoPagoCxC BIGINT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_Cta_ProntoPagoCxC] FOREIGN KEY (CtaProntoPagoCxC)
--REFERENCES dbo.cntCuenta(IDCuenta)

--GO


--ALTER TABLE  dbo.fafCategoriaCliente ADD CtrInteresMoraCxC INT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_CC_InteresMoraCxC] FOREIGN KEY (CtrInteresMoraCxC)
--REFERENCES dbo.cntCentroCosto(IDCentro)
--GO
--ALTER TABLE  dbo.fafCategoriaCliente ADD CtaInteresMoraCxC BIGINT
--GO
--ALTER TABLE dbo.fafCategoriaCliente WITH CHECK ADD CONSTRAINT [fk_fafCategoriaCliente_Cta_InteresMoraCxC] FOREIGN KEY (CtaInteresMoraCxC)
--REFERENCES dbo.cntCuenta(IDCuenta)


--update dbo.fafParametros set AutorizaPrecioPorFactura = 1
--go

create View dbo.vfafPedidoDetalleProd
as
SELECT F.IDPedido, F.IDBodega , B.Descr DescrBodega, f.Pedido , f.Fecha ,  
 F.IDVendedor , V.Nombre NombreVendedor ,
f.IDCliente, C.Nombre,  f.Nota , f.Estado , f.EsTeleventa , f.idplazo , Z.Descr DescrPlazo ,
f.IDMoneda , M.Nacional, M.Descr DescrMoneda, M.Simbolo, P.IDProducto , A.Descr DescrProducto, P.Cantidad,
P.CantFacturada, P.Bonifica , P.CantBonificada, P.BonifConProd,  
 P.PrecioLocal , P.PrecioDolar ,
 P.DescuentoLocal , P.DescuentoDolar  ,
 P.porcDescuentoEsp,P.DescuentoEspecialLocal , P.DescuentoEspecialDolar  ,
 P.SubTotalLocal , P.SubTotalDolar ,
 P.ImpuestoLocal , P.ImpuestoDolar ,
 P.SubTotalFinalLocal , P.SubTotalFinalDolar  ,
 F.IDDepto, f.IDMunicipio , f.IDZona, f.IDSubZona , F.tipoCambio
FROM DBO.fafPedido F inner join DBO.fafPedidoProd P
on F.IDPedido  = P.IDPedido inner join dbo.ccfPlazo Z 
on F.idplazo = Z.Plazo inner join dbo.globalMoneda M
on F.IDMoneda = M.IDMoneda inner join dbo.invProducto A
on P.IDProducto = A.IDProducto inner join dbo.fafVendedor V
on F.IDVendedor = V.IDVendedor inner join dbo.invBodega B
on F.IDBodega = B.IDBodega inner join dbo.ccfClientes C
on F.IDCliente = C.IDCliente 

go

-- SELECT * FROM dbo.vfafPedidoDetalleProd exec  dbo.fafPrintPedido  17
Create Procedure dbo.fafPrintPedido @IDPedido bigint
as
set nocount on 

 SELECT D.IDPedido, D.Pedido , D.Fecha,  D.TipoCambio,
 D.IDCliente, D.Nombre, D.EsTeleVenta,  D.DescrPlazo  , 
 D.IDMoneda, D.DescrMoneda, D.Simbolo,  D.IDBodega, D.DescrBodega ,
 D.IDProducto, D.DescrProducto,  D.Cantidad, D.CantFacturada, D.CantBonificada, D.Bonifica, D.BonifConProd,
case when D.Nacional = 1 then D.PrecioLocal else D.PrecioDolar end Precio,
case when D.Nacional = 1 then D.DescuentoLocal else D.DescuentoDolar  end Descuento,
case when D.Nacional = 1 then D.DescuentoEspecialLocal else D.DescuentoEspecialDolar  end DescuentoEspecial,
case when D.Nacional = 1 then D.Cantidad * D.PrecioLocal  else D.Cantidad * D.PrecioDolar   end SubTotal,
case when D.Nacional = 1 then 
 D.ImpuestoLocal 
else 
D.ImpuestoDolar 
end Impuesto,
case when D.Nacional = 1 then 
	(D.Cantidad * D.PrecioLocal) - (D.DescuentoLocal + D.DescuentoEspecialLocal ) 
	else 
	(D.Cantidad * D.PrecioDolar) - (D.DescuentoDolar + D.DescuentoEspecialDolar ) 
	end SubTotalFinal,
case when D.Nacional = 1 then 
	(D.Cantidad * D.PrecioLocal) - (D.DescuentoLocal + D.DescuentoEspecialLocal ) 
	+ D.ImpuestoLocal
	else 
	(D.Cantidad * D.PrecioDolar) - (D.DescuentoDolar + D.DescuentoEspecialDolar ) 
	+ D.ImpuestoDolar
	end TotalFinal	

 FROM dbo.vfafPedidoDetalleProd D
 WHERE D.IDPedido = @IDPedido
go

alter table dbo.fafBitacoraPrecioCliente add IDNivel int 
go

-- select *  FROM dbo.fafPrecioCliente delete FROM dbo.fafPrecioCliente 
-- Exec dbo.fafUpdatePrecioCliente 'I',7,3 ,1,2,4.5,'azepeda'
--  Exec dbo.fafUpdatePrecioCliente
--'I',7,3 ,1,2,4.5,'azepeda',0
--ALTER Procedure [dbo].[fafUpdatePrecioCliente] @Operacion nvarchar(1),
--	@IDCliente int ,
--	@IDProducto bigint ,
--	@IDNivel int ,
--	@IDMoneda int ,
--	@Precio decimal(28, 2), @Usuario nvarchar(20)
--as
--set nocount on

--if @Operacion = 'I'
--begin
--	Insert dbo.fafPrecioCliente (IDCliente, IDNivel , IDProducto,   IDMoneda , Precio , Usuario )
--	values (@IDCliente, @IDNivel , @IDProducto  , @IDMoneda , @Precio, @Usuario )
--end
--if @Operacion = 'U'
--begin
--	Update dbo.fafPrecioCliente set Precio = @Precio, Usuario = @Usuario 
--	where IDCliente = @IDCliente and IDProducto = @IDProducto  and IDMoneda = @IDMoneda 
--	and IDNivel = @IDNivel 
--end
--if @Operacion = 'D'
--begin
--	Delete dbo.fafPrecioCliente 
--	where IDCliente = @IDCliente and IDProducto = @IDProducto  and IDMoneda = @IDMoneda 
--	and IDNivel = @IDNivel 
--end

--go


--exec dbo.fafgetPreciosCliente  7 select * from dbo.fafnivelPrecio
--Alter procedure dbo.fafgetPreciosCliente @IDCliente int 
--as
--set nocount on
--select D.IDCliente, C.Nombre , D.IDProducto , P.Descr , D.IDNivel , N.Descr DescrNivel, D.IDMoneda , M.Descr DescrMoneda, D.Precio 
--from dbo.fafPrecioCliente D inner join dbo.ccfClientes C on D.IDCliente = C.IDCliente 
--inner join dbo.invProducto P on D.IDProducto = P.IDProducto 
--inner join dbo.globalMoneda M on D.IDMoneda = M.IDMoneda
--inner join dbo.fafNivelPrecio N on D.IDnivel = N.IDNivel and N.IDMoneda = M.IDMoneda 
--where (D.IDCliente = @IDCliente or @IDCliente = 0)
--go

alter table dbo.fafBitacoraPrecioCliente add UsuarioUso nvarchar(20)
go

alter table dbo.fafPrecioCliente add constraint ukPrecioCliente Unique (IDCliente, IDProducto,IDNivel, IDMoneda)
go

CREATE PROCEDURE dbo.fafUpdateBitacoraPrecio @IDfactura bigint, @Usuario nvarchar(20) 
as
set nocount on
declare @AutorizaporFactura bit
select @AutorizaporFactura = AutorizaPrecioporFactura  from dbo.fafParametros
if @AutorizaporFactura is null 
	set @AutorizaporFactura = 1

INSERT  dbo.fafBitacoraPrecioCliente (IDCliente, IDProducto, Fecha, IDNivel,   IDMoneda , Precio , Usuario, IDFactura , UsuarioUso  )
SELECT  P.IDCliente , P.IDProducto , GETDATE() Fecha, P.IDNivel , P.IDMoneda , P.Precio, p.Usuario ,@IDfactura IDFactura , @Usuario UsuarioUso
FROM dbo.fafPrecioCliente P inner join dbo.fafFactura F
ON P.IDCliente = F.IDCliente and P.IDNivel = F.idnivel 
	and P.IDMoneda = F.idmoneda inner join dbo.fafFacturaProd L
ON F.IDFactura = L.IDFactura and L.IDProducto = P.IDProducto 
WHERE F.IDFactura = @IDfactura 

IF @AutorizaporFactura = 1
BEGIN

	Delete P
	From dbo.fafPrecioCliente P inner join dbo.fafFactura F
	on P.IDCliente = F.IDCliente and P.IDNivel = F.idnivel 
	and P.IDMoneda = F.idmoneda inner join dbo.fafFacturaProd L
	on F.IDFactura = L.IDFactura and L.IDProducto = P.IDProducto 
	Where F.IDFactura = @IDfactura 
END
GO

-- exec dbo.fafGetBitacoraPrecio '20181001', '20181019'
Create Procedure dbo.fafGetBitacoraPrecio @FechaInicio datetime, @FechaFinal datetime
as
set nocount on 
set @FechaInicio = CAST(SUBSTRING(CAST(@FechaInicio AS CHAR),1,11) + ' 00:00:00.000' AS DATETIME)
set @FechaFinal = CAST(SUBSTRING(CAST(@FechaFinal AS CHAR),1,11) + ' 23:59:59.998' AS DATETIME)

SELECT B.IDCliente, C.Nombre , B.IDProducto, P.Descr, B.IDMoneda, M.Descr DescrMoneda , F.IDBodega, F.Factura, B.Precio , 
B.Usuario UsuarioAprob, B.usuarioUso , B.Fecha 
FROM dbo.fafbitacorapreciocliente B inner join dbo.ccfClientes C
on B.IDCliente = C.IDCliente inner join dbo.invProducto P
on B.IDProducto = P.IDProducto inner join dbo.globalMoneda M
on B.IDMoneda = M.IDMoneda inner join dbo.fafFACTURA F
on B.IDFactura = F.IDFactura 
WHERE B.Fecha BETWEEN @FechaInicio AND @FechaFinal
GO
-- SELECT * FROM DBO.FAFPARAMETROS select * from dbo.cntCentroCosto
--Create Procedure dbo.fafUpdateParametros @IDParametros int,
--@IDNivelPrecioPub int , @IDPlazoCont int, @TipoCambioFact nvarchar(20),
--@TipoCambioCont nvarchar(20) , @NumeroLineasFact int ,
--@IntegracionCont bit,  @IDPaquete int, @CtrImpuesto int, @CtaImpuesto bigint, @AutorizaPrecioPorFactura bit 
--as
--set nocount on 
--if not exists (select IDParametros from  dbo.fafParametros ) 
--	insert dbo.fafParametros (IDNivelPrecioPub, IDPlazoCont , TipoCambioFact , TipoCambioCont , NumeroLineasFact , IntegracionCont,
--	IDpaquete, CtrImpuesto, CtaImpuesto, AutorizaPrecioPorFactura ) 
--	values (@IDNivelPrecioPub, @IDPlazoCont , @TipoCambioFact , @TipoCambioCont , @NumeroLineasFact , @IntegracionCont, @IDpaquete, @CtrImpuesto, @CtaImpuesto, @AutorizaPrecioPorFactura )
--else
--	Update  dbo.fafParametros set IDNivelPrecioPub= @IDNivelPrecioPub, 
--	IDPlazoCont  = @IDPlazoCont, TipoCambioFact = @TipoCambioFact , 
--	TipoCambioCont = @TipoCambioCont , NumeroLineasFact = @NumeroLineasFact, IntegracionCont =@IntegracionCont ,
--	IDPaquete = @IDPaquete , CtrImpuesto = @ctrImpuesto , CtaImpuesto = @CtaImpuesto , AutorizaPrecioPorFactura = @AutorizaPrecioPorFactura
--	Where IDParametros = @IDParametros
--go

--Create Procedure dbo.fafgetParametros @IDParametros int
--as
--set nocount on
--Select  IDNivelPrecioPub, IDPlazoCont , TipoCambioFact , TipoCambioCont , NumeroLineasFact , IntegracionCont ,
--IDPaquete, CtrImpuesto, CtaImpuesto, AutorizaPrecioPorFactura 
--from dbo.fafParametros 
--where IDParametros = @IDParametros
--go

--Alter View dbo.vfafDetalleProducto
--as
--SELECT F.IDFactura, F.IDBodega , B.Descr DescrBodega, f.Factura , f.Fecha ,F.IDTipo, T.descr DescrTipo, F.IDTipoEntrega, 
--E.Descr DescrEntrega, F.IDVendedor , V.Nombre NombreVendedor ,
--f.IDCliente, f.Nombre, f.Mensaje , f.Anulada , f.EsTeleventa , f.idplazo , Z.Descr DescrPlazo ,
--f.IDMoneda , M.Nacional, M.Descr DescrMoneda, M.Simbolo, P.IDProducto , A.Descr DescrProducto, P.Cantidad,
--P.CantFacturada, P.Bonifica , P.CantBonificada, P.BonifConProd,  
-- P.PrecioLocal , P.PrecioDolar ,
-- P.CostoLocal , P.CostoDolar ,
-- P.DescuentoLocal , P.DescuentoDolar  ,
-- P.porcDescuentoEsp,P.DescuentoEspecialLocal , P.DescuentoEspecialDolar  ,
-- P.SubTotalLocal , P.SubTotalDolar ,
-- P.PorcImpuesto, P.ImpuestoLocal , P.ImpuestoDolar ,
-- P.SubTotalFinalLocal , P.SubTotalFinalDolar  ,
-- P.Factor, F.IDDepto, f.IDMunicipio , f.IDZona, f.IDSubZona , F.tipoCambio, F.codconsecutivo, P.IDFacturaProd 
--FROM DBO.fafFactura F inner join DBO.fafFacturaProd P
--on F.IDFactura = P.IDFactura inner join dbo.fafTipoFactura T 
--on F.IDTipo = T.IDTipo inner join dbo.fafTipoEntrega E 
--on F.IDTipoEntrega= E.IDTipoEntrega inner join dbo.ccfPlazo Z 
--on F.idplazo = Z.Plazo inner join dbo.globalMoneda M
--on F.IDMoneda = M.IDMoneda inner join dbo.invProducto A
--on P.IDProducto = A.IDProducto inner join dbo.fafVendedor V
--on F.IDVendedor = V.IDVendedor inner join dbo.invBodega B
--on F.IDBodega = B.IDBodega 
--WHERE F.Anulada  = 0
--go

alter table fafFactura add IDVendedorCliente int 
go
alter table fafFactura add constraint fkfafFacturaendedorCliente  foreign key ( IDVendedorCliente ) 
references dbo.fafVendedor (IDVendedor) 
go
-- me quede aqui 
--Alter View dbo.vfafDetalleProducto
--as
--SELECT F.IDFactura, F.IDBodega , B.Descr DescrBodega, f.Factura , f.Fecha ,F.IDTipo, T.descr DescrTipo, F.IDTipoEntrega, 
--E.Descr DescrEntrega, F.IDVendedor , V.Nombre NombreVendedor , 
--f.IDCliente, f.Nombre, f.Mensaje , f.Anulada , f.EsTeleventa , f.idplazo , Z.Descr DescrPlazo , F.IDNivel,
--f.IDMoneda , M.Nacional, M.Descr DescrMoneda, M.Simbolo, P.IDProducto , A.Descr DescrProducto, P.Cantidad,
--P.CantFacturada, P.Bonifica , P.CantBonificada, P.BonifConProd,  
-- P.PrecioLocal , P.PrecioDolar ,
-- P.CostoLocal , P.CostoDolar ,
-- P.DescuentoLocal , P.DescuentoDolar  ,
-- P.porcDescuentoEsp,P.DescuentoEspecialLocal , P.DescuentoEspecialDolar  ,
-- P.SubTotalLocal , P.SubTotalDolar ,
-- P.PorcImpuesto, P.ImpuestoLocal , P.ImpuestoDolar ,
-- P.SubTotalFinalLocal , P.SubTotalFinalDolar  ,
-- P.Factor, F.IDDepto, f.IDMunicipio , f.IDZona, f.IDSubZona , F.tipoCambio, F.codconsecutivo, P.IDFacturaProd,
-- F.pesoKG,  F.Remisionada
--FROM DBO.fafFactura F inner join DBO.fafFacturaProd P
--on F.IDFactura = P.IDFactura inner join dbo.fafTipoFactura T 
--on F.IDTipo = T.IDTipo inner join dbo.fafTipoEntrega E 
--on F.IDTipoEntrega= E.IDTipoEntrega inner join dbo.ccfPlazo Z 
--on F.idplazo = Z.Plazo inner join dbo.globalMoneda M
--on F.IDMoneda = M.IDMoneda inner join dbo.invProducto A
--on P.IDProducto = A.IDProducto inner join dbo.fafVendedor V
--on F.IDVendedor = V.IDVendedor inner join dbo.invBodega B
--on F.IDBodega = B.IDBodega 
--WHERE F.Anulada  = 0
--go

-- select * from dbo.fafFacturaProdLote DROP PROCEDURE dbo.fafGetFacturaEntrega EXEC dbo.fafGetFacturaEntrega '20181020', '20181020'
Create Procedure dbo.fafGetFacturaEntrega @FechaInicio datetime, @FechaFinal datetime, @Remisionados int
as
set nocount on 
set @FechaInicio = CAST(SUBSTRING(CAST(@FechaInicio AS CHAR),1,11) + ' 00:00:00.000' AS DATETIME)
set @FechaFinal = CAST(SUBSTRING(CAST(@FechaFinal AS CHAR),1,11) + ' 23:59:59.998' AS DATETIME)
SELECT DISTINCT D.IDFactura , D.IDBodega , D.IDCliente , D.Nombre , D.Factura , D.FECHA , D.IDTipoEntrega,  D.DescrEntrega, D.PesoKG, D.Remisionada
FROM dbo.vfafDetalleProducto D INNER JOIN dbo.fafFacturaProdLote L
ON D.IDFacturaProd = l.IDFacturaProd INNER JOIN DBO.invLote T
ON L.IDLote = T.IDLote AND T.IDProducto = D.IDProducto  
WHERE Fecha BETWEEN  @FechaInicio AND @FechaFinal AND D.Anulada = 0 and (@Remisionados = -1 or D.remisionada = @Remisionados )

go

-- exec dbo.fafGetFacturaEntregaProducto 13
create Procedure dbo.fafGetFacturaEntregaProducto @IDFactura bigint 
as
set nocount on 

SELECT D.IDFactura , D.IDBodega , D.IDCliente , D.Nombre , D.Factura , D.IDProducto , D.DescrProducto , 
case when D.BonifConProd = 1 then 'SI' ELSE 'NO' END BonificaProducto,
CASE WHEN D.BonifConProd = 1 THEN L.Cantidad ELSE L.CantFacturada END Entregar ,
T.IDLote, T.LoteInterno , T.LoteProveedor , L.Cantidad, L.CantFacturada, L.CantBonificada,
D.Fecha, D.DescrEntrega
FROM dbo.vfafDetalleProducto D INNER JOIN dbo.fafFacturaProdLote L
ON D.IDFacturaProd = l.IDFacturaProd INNER JOIN DBO.invLote T
ON L.IDLote = T.IDLote AND T.IDProducto = D.IDProducto  
WHERE IDFactura = @IDFactura
go

alter Procedure dbo.fafUpdateFactura @Operacion nvarchar(1),
	@IDBodega int ,	@Factura nvarchar(20) ,	@IDTipo smallint ,	@IDCliente int ,	@Nombre nvarchar(250) ,
	@IDVendedor int ,	@IDTipoEntrega int ,
	@Fecha datetime ,	@Anulada bit ,	@EsTeleventa bit ,	@IDPedido int ,	@IDNivel int ,	@IDMoneda int ,
	@IDPlazo int ,	@TipoCambio decimal(28, 4) ,	@CodConsecutivo nvarchar(20) ,	@Mensaje nvarchar(250) 
as
set nocount on 
if @Operacion = 'I'
begin

declare 	@IDDepto int ,	@IDMunicipio int ,	@IDZona int ,	@IDSubZona int, @IDVendedorCliente int

	Select @IDDepto = IDDepto , @IDMunicipio = IDMunicipio, @IDZona = IDZona , @IDSubZona = IDSubZona ,
	@IDVendedorCliente = IDVendedor
	from dbo.ccfClientes 
	where IDCliente = @IDCliente 

INSERT INTO [dbo].[fafFACTURA]
           ([IDBodega]  ,[Factura]  ,[IDTipo] ,[IDCliente] ,[Nombre]
           ,[IDVendedor] ,[IDDepto]  ,[IDMunicipio]  ,[IDZona]  ,[IDSubZona]  ,[IDTipoEntrega]
           ,[Fecha]  ,[Anulada] ,[EsTeleventa]   ,[IDPedido]    ,[IDNivel]   ,[IDMoneda]
           ,[IDPlazo]  ,[TipoCambio]    ,[CodConsecutivo]   ,[Mensaje] , IDVendedorCliente )
     VALUES  ( @IDBodega ,@Factura,   @IDTipo,  @IDCliente,@Nombre, @IDVendedor, 
            @IDDepto,  @IDMunicipio,@IDZona, @IDSubZona, @IDTipoEntrega  ,@Fecha, @Anulada
           ,@EsTeleventa  ,@IDPedido  ,@IDNivel ,@IDMoneda  ,@IDPlazo  ,@TipoCambio  ,@CodConsecutivo
           ,@Mensaje, @IDVendedorCliente )           
           	
end

go



alter table dbo.fafTipoEntrega add ControlPesoKG bit default 0
go

update dbo.fafTipoEntrega set ControlPesoKG = 0
go

update dbo.fafTipoEntrega set ControlPesoKG = 1 where IDTipoEntrega = 2
go


Create Procedure dbo.fafUpdateFacturaRemision @IDFactura bigint, @PesoKG decimal(28,2)
as
set nocount on

Update dbo.fafFactura set PesoKG = @PesoKG, Remisionada = 1
Where IDFactura = @IDFactura
go




alter Procedure dbo.fafGetFacturaEntregaProducto @IDFactura bigint 
as
set nocount on 

SELECT D.IDFactura , D.IDBodega , D.IDCliente , D.Nombre , D.Factura , D.IDProducto , D.DescrProducto , 
case when D.BonifConProd = 1 then 'SI' ELSE 'NO' END BonificaProducto,
CASE WHEN D.BonifConProd = 1 THEN L.Cantidad ELSE L.CantFacturada END Entregar ,
T.IDLote, T.LoteInterno , T.LoteProveedor , L.Cantidad, L.CantFacturada, L.CantBonificada,
D.Fecha, D.DescrEntrega, D.PesoKG, D.Remisionada
FROM dbo.vfafDetalleProducto D INNER JOIN dbo.fafFacturaProdLote L
ON D.IDFacturaProd = l.IDFacturaProd INNER JOIN DBO.invLote T
ON L.IDLote = T.IDLote AND T.IDProducto = D.IDProducto  
WHERE IDFactura = @IDFactura
go

alter table dbo.ccfClientes add EsCorporacion bit default 0, 
MiembroCorp bit default 0, IDClienteCorp int 
go
alter table dbo.ccfClientes add constraint fkClicorp foreign key (IDClienteCorp)
references dbo.ccfClientes (IDCliente)
go

Create Procedure dbo.fafUpdateCliente @Operacion nvarchar(1),
	@IDCliente int
           ,@Nombre nvarchar(255)
           ,@EsFarmacia bit = null
           ,@IDTipo int = null
           ,@Farmacia nvarchar(255) = null
           ,@IDCategoria int = null
           ,@IDVendedor int = null
           ,@IDDepto int = null
           ,@IDMunicipio int = null
           ,@IDZona int = null
           ,@IDSubZona int = null
           ,@RUC nvarchar(50) = null
           ,@LimiteCredito decimal(28,4) = null
           ,@IDBodega int = null
           ,@Direccion nvarchar(255) = null
           ,@Telefono nvarchar(25) = null
           ,@Celular nvarchar(25) = null
           ,@Dueno nvarchar(255) = null
           
           ,@PorcInteres decimal(8,2) = null
           ,@Plazo int = null
           ,@email nvarchar(250) = null
           ,@pweb nvarchar(250) = null
           ,@Activo bit = null
           ,@Cedula nvarchar(20) = null
           ,@IDNivel int  = null
           ,@IDMoneda int  = null
           ,@EditaNombre bit = null
           ,@Credito bit = null    
           ,@flgEspecial bit = null            
           ,@EsCorporacion bit = null
           ,@MiembroCorp bit = null       
           ,@IDClienteCorp int  = null
           ,@DisponibleCredito decimal(28,4) = null
           ,@IDEvaluacion int = null
           ,@Foto image  = null

as

if @Operacion = 'I'
begin
INSERT INTO [dbo].[ccfClientes]
           ([IDCliente]
           ,[Nombre]
           ,[EsFarmacia]
           ,[IDTipo]
           ,[Farmacia]
           ,[IDCategoria]
           ,[IDVendedor]
           ,[IDDepto]
           ,[IDMunicipio]
           ,[IDZona]
           ,[IDSubZona]
           ,[RUC]
           ,[LimiteCredito]
           ,[IDBodega]
           ,[Direccion]
           ,[Telefono]
           ,[Celular]
           ,[Dueno]
	   , FechaIngreso 

           ,[PorcInteres]
           ,[Plazo]
           ,[email]
           ,[pweb]
           ,[Activo]
           ,[Cedula]
           ,IDNivel
           ,IDMoneda
           ,Foto
           ,EditaNombre
           ,Credito, flgEspecial,  EsCorporacion, MiembroCorp, IDClienteCorp, DisponibleCredito, IDEvaluacion )
     VALUES
           (@IDCliente 
           ,@Nombre 
           ,@EsFarmacia 
           ,@IDTipo 
           ,@Farmacia 
           ,@IDCategoria 
           ,@IDVendedor 
           ,@IDDepto 
           ,@IDMunicipio 
           ,@IDZona 
           ,@IDSubZona 
           ,@RUC 
           ,@LimiteCredito 
           ,@IDBodega 
           ,@Direccion 
           ,@Telefono 
           ,@Celular 
           ,@Dueno 
           ,GETDATE() 

           ,@PorcInteres 
           ,@Plazo 
           ,@email 
           ,@pweb 
           ,@Activo 
           ,@Cedula 
           ,@IDNivel
           ,@IDMoneda
           , @Foto 
           , @EditaNombre 
           , @Credito, @flgEspecial, @EsCorporacion, @MiembroCorp, @IDClienteCorp, @DisponibleCredito, @IDEvaluacion 
          )
 end
 if @Operacion  = 'U'
 begin
 Update dbo.ccfClientes set Nombre =  @Nombre 
           ,EsFarmacia = @EsFarmacia 
           ,IDTipo = @IDTipo 
           ,Farmacia = @Farmacia 
           ,IDCategoria = @IDCategoria 
           ,IDVendedor = @IDVendedor 
           ,IDDepto = @IDDepto 
           ,IDMunicipio = @IDMunicipio 
           ,IDZona = @IDZona 
           ,IDSubZona = @IDSubZona 
           ,IDNivel = @IDNivel 
           ,IDMoneda = @IDMoneda 
           ,RUC = @RUC  
           ,LimiteCredito = @LimiteCredito 
           ,DisponibleCredito = @DisponibleCredito 
           ,IDBodega = @IDBodega 
           ,Direccion = @Direccion 
           ,Telefono = @Telefono 
           ,Celular = @Celular
           ,Dueno = @Dueno 

           ,PorcInteres = @PorcInteres 
           ,Plazo = @Plazo 
           ,email = @email 
           ,pweb = @pweb 
           ,Activo = @Activo 
           ,Cedula = @Cedula 
           ,Foto = @Foto 
           ,EditaNombre = @EditaNombre 
           ,Credito = @Credito
           ,flgEspecial = @flgEspecial 
           ,EsCorporacion= @EsCorporacion 
           ,MiembroCorp =@MiembroCorp
           ,IDClienteCorp = @IDClienteCorp
           ,IDEvaluacion = @IDEvaluacion 
  Where IDCliente = @IDCliente 
  end  
If @Operacion = 'D'           
	Delete from dbo.ccfClientes where IDCliente = @IDCliente 
GO
-- exec dbo.fafgetClientes 0, 1
Create  Procedure dbo.fafgetClientes(@IDCliente int, @IDSucursal int = null )
as
set nocount on 
if @IDSucursal is null
	set @IDSucursal = 0
SELECT    C.IDCliente ,C.Nombre   ,C.EsFarmacia  ,C.IDTipo , T. Descr DescrTipo, C.Farmacia ,
	C.FechaIngreso, C.IDCategoria , Cat.Descr DescrCategoria, C.IDVendedor , V.Nombre  NombreVendedor,
	C.IDDepto ,D.Descr DescrDepto,  C.IDMunicipio , M.Descr DescrMunicipio,
	C.IDZona ,Z.Descr DescrZona, C.IDSubZona, sz.Descr DescrSubZona,
	C.IDNivel, P.Descr DescrNivel, C.IDMoneda , N.Descr DescrMoneda,
	C.RUC ,C.LimiteCredito ,C.IDBodega IDSucursal , B.Descr DescrSucursal, C.Direccion ,C.Telefono,
            C.Celular  ,C.Dueno , FechaIngreso ,C.foto  ,C.PorcInteres, 
            C.Plazo ,C.email ,C.pweb ,C.Activo ,C.Cedula, C.EditaNombre, C.Credito, C.EsCorporacion, C.MiembroCorp, 
            C.IDClienteCorp, C.flgEspecial, C.DisponibleCredito, C.IDEValuacion, E.Descr DescrEvaluacion 
FROM dbo.ccfClientes C left join dbo.fafTipoCliente T on C.IDTipo = T.IDTipo 
left join dbo.fafCategoriaCliente Cat on C.IDCategoria = Cat.IDCategoria 
left join dbo.fafVendedor V on C.IDVendedor  = V.IDVendedor 
left join dbo.globalDepto D on C.IDDepto   = D.IDDepto 
left join dbo.globalMunicipio M on C.IDDepto   = M.IDDepto and C.IDMunicipio = M.IDMunicipio 
left join dbo.globalZona Z on C.IDZona    = Z.IDZona 
left join dbo.globalSubZona SZ on C.IDZona     = sz.IDZona  and C.IDSubZona  = sz.IDSubZona  
left join dbo.invBodega B on C.IDBodega    = B.IDBodega  
left join dbo.fafNivelPrecio P on C.IDNivel    = P.IDNivel 
left join dbo.globalmoneda N on C.IDMoneda    = N.IDMoneda 
left join dbo.fafEvaluacionCliente E on C.IDEvaluacion = E.IDEvaluacion 
WHERE (C.IDBodega  = @IDSucursal or @IDSucursal = 0) and (C.IDCliente = @IDCliente or @IDCliente = 0 )
go

--exec dbo.fafgetListaPrecio 0,1 select * from dbo.fafPrecios
--Alter procedure dbo.fafgetListaPrecio ( @IDProducto bigint, @IDNivel int = null, @IDProveedor int= null )
--as
--set nocount on
--if @IDProveedor is null
-- set @IDProveedor = 0
-- if @IDNivel is null
--  set @IDNivel = 0
--Select isnull(R.IDProveedor,0) IDProveedor , V.Nombre NomProveedor, P.IDProducto, A.Descr , P.IDNivel , N.Descr DescrNivel, P.IDMoneda, M.Descr DescrMoneda, P.Precio 
--From dbo.fafPrecios P inner join dbo.invProducto A on P.IDProducto = A.IDProducto 
--inner join dbo.fafNivelPrecio N on P.IDNivel = N.IDNivel 
--inner join dbo.globalMoneda M on P.IDMoneda = M.IDMoneda 
--left join dbo.invProveedorProducto R 
--on P.IDProducto = R.IDProducto inner join dbo.cppProveedor V
--on R.IDProveedor = V.IDProveedor 
--Where (P.IDProducto= @IDProducto or @IDProducto = 0) and
--(P.IDNivel = @IDNivel or @IDNivel = 0) and (isnull(R.IDProveedor,0)= @IDProveedor or @IDProveedor = 0)
--go

-- Select * from dbo.fafPrecioCliente EXEC dbo.fafgetPreciosCliente -1,-1,-1,-1
-- exec fafgetPreciosCliente 0,0,0,0
Create procedure dbo.fafgetPreciosCliente @IDCliente int, @IDProducto bigint = null, @IDNivel int = null, @IDProveedor int= null 
as
set nocount on
if @IDProducto is null
	set @IDProducto = 0
if 	@IDNivel is null
	set @IDNivel = 0
if @IDProveedor is null 
	set @IDProveedor = 0

SELECT V.Nombre NomProveedor,  D.IDCliente, C.Nombre , D.IDProducto , P.Descr , D.IDNivel , N.Descr DescrNivel, D.IDMoneda , M.Descr DescrMoneda, D.Precio 
FROM dbo.fafPrecioCliente D inner join dbo.ccfClientes C on D.IDCliente = C.IDCliente 
inner join dbo.invProducto P on D.IDProducto = P.IDProducto 
inner join dbo.globalMoneda M on D.IDMoneda = M.IDMoneda
inner join dbo.fafNivelPrecio N on D.IDnivel = N.IDNivel and N.IDMoneda = M.IDMoneda 
inner join dbo.cppProveedor V
on P.IDProveedor = V.IDProveedor 

WHERE (D.IDCliente = @IDCliente or @IDCliente = 0) and (P.IDProducto= @IDProducto or @IDProducto = 0) and
(D.IDNivel = @IDNivel or @IDNivel = 0) and (isnull(P.IDProveedor,0)= @IDProveedor or @IDProveedor = 0)
go

Create Procedure [dbo].[fafUpdatePrecioCliente] @Operacion nvarchar(1),
	@IDCliente int ,
	@IDProducto bigint ,
	@IDNivel int, 
	@IDMoneda int ,
	@Precio decimal(28, 2), @Usuario nvarchar(20), @IDFactura bigint = null
as
set nocount on

if @Operacion = 'I'
begin
	Insert dbo.fafPrecioCliente (IDCliente, IDNivel , IDProducto,   IDMoneda , Precio , Usuario )
	values (@IDCliente, @IDNivel , @IDProducto  , @IDMoneda , @Precio, @Usuario )
end
if @Operacion = 'U'
begin
	Update dbo.fafPrecioCliente set Precio = @Precio, Usuario = @Usuario 
	where IDCliente = @IDCliente and IDNivel = @IDNivel and IDProducto = @IDProducto  and IDMoneda = @IDMoneda 
end
if @Operacion = 'D'
begin
	Delete dbo.fafPrecioCliente 
	where IDCliente = @IDCliente and IDNivel = @IDNivel and IDProducto = @IDProducto  and IDMoneda = @IDMoneda 
end
-- si se Factura el precio autorizado para el cliente, al momento de facturar se debe eliminar e insertar en la bitacora
if @Operacion = 'F'
begin
	Delete dbo.fafPrecioCliente 
	where IDCliente = @IDCliente and IDNivel = @IDNivel and IDProducto = @IDProducto  and IDMoneda = @IDMoneda 
	insert dbo.fafBitacoraPrecioCliente (IDCliente, IDProducto, Fecha,   IDMoneda , Precio , Usuario, IDFactura  )
	values (@IDCliente, @IDProducto, GETDATE(), @IDMoneda , @Precio , @Usuario, @IDFactura )
end
go

-- Select * from dbo.vfafDetalleProducto
-- Select * from  dbo.fafFacturaProdLote exec dbo.fafGetFacturaLotes 54, 0 -- select * from  DBO.invLote  
Create Procedure dbo.fafGetFacturaLotes @IDFactura bigint, @IDProducto int 
as
set nocount on 

SELECT DISTINCT D.IDFacturaProd , D.IDFactura , D.IDProducto,   T.LoteInterno, T.LoteProveedor , T.FechaVencimiento, L.Cantidad Total, L.CantFacturada Facturadas, L.CantBonificada Bonificadas
FROM dbo.vfafDetalleProducto D INNER JOIN dbo.fafFacturaProdLote L
ON D.IDFacturaProd = l.IDFacturaProd INNER JOIN DBO.invLote T
ON L.IDLote = T.IDLote AND T.IDProducto = D.IDProducto  
WHERE  D.IDFactura = @IDFactura and ( D.IDProducto = @IDProducto or @IDProducto = 0 )
order by D.IDFactura , D.IDProducto

go
-- EXEC dbo.fafgetFacturaHeader 12
-- exec dbo.fafPrintFacturaLote 12
-- select * from dbo.faffacturaprod where idfactura = 43
create  Procedure dbo.fafPrintFacturaLote @IDFactura bigint
as
set nocount on 

 SELECT D.IDFactura, D.Factura , D.Fecha, D.IDTipo , D.DescrTipo, D.TipoCambio,
 D.IDTipoEntrega, D.DescrEntrega, D.IDCliente, D.Nombre, D.EsTeleVenta, D.Anulada, D.IDPlazo, D.DescrPlazo  , D.IDNivel,
 D.IDMoneda, D.DescrMoneda, D.Simbolo,  D.IDBodega, D.DescrBodega , D.IDVendedor, D.NombreVendedor ,  
 D.IDProducto, D.DescrProducto, D.DescrUnidad,  D.Cantidad, D.CantFacturada, D.CantBonificada, D.Bonifica, D.BonifConProd,
case when D.Nacional = 1 then D.PrecioLocal else D.PrecioDolar end Precio,
case when D.Nacional = 1 then D.CostoLocal else D.CostoDolar end Costo,
case when D.Nacional = 1 then D.DescuentoLocal else D.DescuentoDolar  end Descuento,
case when D.Nacional = 1 then D.DescuentoEspecialLocal else D.DescuentoEspecialDolar  end DescuentoEspecial,
case when D.Nacional = 1 then D.Cantidad * D.PrecioLocal  else D.Cantidad * D.PrecioDolar   end SubTotal,
case when D.Nacional = 1 then 
( ((D.Cantidad * D.PrecioLocal) - (D.DescuentoLocal + D.DescuentoEspecialLocal ))  * D.PorcImpuesto/100)  
else 
( ((D.Cantidad * D.PrecioDolar) - (D.DescuentoDolar + D.DescuentoEspecialDolar )) * D.PorcImpuesto/100)   
end Impuesto,
case when D.Nacional = 1 then 
	(D.Cantidad * D.PrecioLocal) - (D.DescuentoLocal + D.DescuentoEspecialLocal ) 
	else 
	(D.Cantidad * D.PrecioDolar) - (D.DescuentoDolar + D.DescuentoEspecialDolar ) 
	end SubTotalFinal,
case when D.Nacional = 1 then 
	(D.Cantidad * D.PrecioLocal) - (D.DescuentoLocal + D.DescuentoEspecialLocal ) 
	+ D.ImpuestoLocal
	else 
	(D.Cantidad * D.PrecioDolar) - (D.DescuentoDolar + D.DescuentoEspecialDolar ) 
	+ D.ImpuestoDolar
	end TotalFinal,L.IDLote, T.LoteInterno, T.FechaVencimiento, T.LoteProveedor,L.Cantidad CantidadLote, 0 CantADev,
case when D.Bonifica = 1 then
	(D.DescuentoLocal / D.SubTotalLocal ) * 100
else
	0
end
PorcDescBonif, 	D.porcDescuentoEsp, D.PorcImpuesto, 0 MontoDev, 0 IVADev 

 FROM dbo.vfafDetalleProducto D INNER JOIN dbo.fafFacturaProdLote L
ON D.IDFacturaProd = l.IDFacturaProd INNER JOIN DBO.invLote T
ON L.IDLote = T.IDLote AND T.IDProducto = D.IDProducto
 WHERE D.IDFactura = @IDFactura
go
-- select * from dbo.invLote
--alter table  dbo.fafParametros add paginaFacturaAltura decimal(28,2) default 0, paginaFacturaAncho decimal(28,2) default 0, FacturaPersonalizada bit default 0
--go

--create Procedure dbo.fafgetParametros @IDParametros int
--as
--set nocount on
--Select  IDNivelPrecioPub, IDPlazoCont , TipoCambioFact , TipoCambioCont , NumeroLineasFact , IntegracionCont ,
--IDPaquete, CtrImpuesto, CtaImpuesto, AutorizaPrecioPorFactura, isnull(paginaFacturaAltura,0) paginaFacturaAltura,
-- isnull(paginaFacturaAncho,0) paginaFacturaAncho, isnull(FacturaPersonalizada, 0) FacturaPersonalizada
--from dbo.fafParametros 
--where IDParametros = @IDParametros
--go

--Alter Procedure dbo.fafUpdateParametros @IDParametros int,
--@IDNivelPrecioPub int , @IDPlazoCont int, @TipoCambioFact nvarchar(20),
--@TipoCambioCont nvarchar(20) , @NumeroLineasFact int ,
--@IntegracionCont bit,  @IDPaquete int, @CtrImpuesto int, @CtaImpuesto bigint, @AutorizaPrecioPorFactura bit, 
--@paginaFacturaAltura decimal(28,2), @paginaFacturaAncho decimal(28,2), @FacturaPersonalizada bit
--as
--set nocount on 
--if not exists (select IDParametros from  dbo.fafParametros ) 
--	insert dbo.fafParametros (IDNivelPrecioPub, IDPlazoCont , TipoCambioFact , TipoCambioCont , NumeroLineasFact , IntegracionCont,
--	IDpaquete, CtrImpuesto, CtaImpuesto, AutorizaPrecioPorFactura, paginaFacturaAltura, paginaFacturaAncho, FacturaPersonalizada ) 
--	values (@IDNivelPrecioPub, @IDPlazoCont , @TipoCambioFact , @TipoCambioCont , @NumeroLineasFact , @IntegracionCont, @IDpaquete, @CtrImpuesto, @CtaImpuesto, @AutorizaPrecioPorFactura,@paginaFacturaAltura, @paginaFacturaAncho, @FacturaPersonalizada  )
--else
--	Update  dbo.fafParametros set IDNivelPrecioPub= @IDNivelPrecioPub, 
--	IDPlazoCont  = @IDPlazoCont, TipoCambioFact = @TipoCambioFact , 
--	TipoCambioCont = @TipoCambioCont , NumeroLineasFact = @NumeroLineasFact, IntegracionCont =@IntegracionCont ,
--	IDPaquete = @IDPaquete , CtrImpuesto = @ctrImpuesto , CtaImpuesto = @CtaImpuesto , AutorizaPrecioPorFactura = @AutorizaPrecioPorFactura,
--	paginaFacturaAltura = @paginaFacturaAltura, paginaFacturaAncho = @paginaFacturaAncho,
--	FacturaPersonalizada = @FacturaPersonalizada
--	Where IDParametros = @IDParametros
--go

-- drop table dbo.fafDevolucion
-- drop table dbo.fafDevDetalle me quede aqui2 alter table dbo.fafDevolucion add IDBodega int
Create Table dbo.fafDevolucion (IDDevolucion bigint identity(1,1) not null, IDFactura bigint, 
Fecha date, Consecutivo nvarchar(20) not null, Devolucion nvarchar(20),IDBodega int, IDMoneda int,  
Usuario nvarchar(20), TipoCambio decimal(28,4) default 0, Anulada bit default 0, Asiento nvarchar(20) , 
NotaCredito bit default 0,  IDNotaCredito int null)
go
alter table dbo.fafDevolucion add constraint pkfafDevoluion primary key (IDDevolucion)
go
alter table dbo.fafDevolucion add constraint pkfafDevoluionFact foreign key (IDFactura) references dbo.fafFactura (IDFactura)
go
alter table dbo.fafDevolucion add constraint pkfafDevoluionconsec foreign key (Consecutivo) references dbo.globalConsecMask (Codigo)
go
alter table dbo.fafDevolucion add constraint pkfafDevoluionUsuario foreign key (Usuario) references dbo.secUsuario (Usuario)
go
alter table dbo.fafDevolucion add constraint pkfafDevoluionMoneda foreign key (IDMoneda) references dbo.globalMoneda (IDMoneda)
go
alter table dbo.fafDevolucion add constraint pkfafDevoluionsucursal foreign key (IDBodega) references dbo.invBodega (IDBodega)
go

--drop table dbo.fafDevDetalle drop ALTER table dbo.fafDevDetalle ADD IVA decimal (28,4) default 0
Create table dbo.fafDevDetalle (IDDevDetalle bigint identity (1,1) not null,
IDDevolucion bigint not null, IDProducto bigint not null, IDLote int not null, 
Cantidad decimal(28,4) default 0, Precio decimal(28,4) default 0, 
PorcDescBonif decimal(28,2) default 0, PorcDescEspecial decimal(28,2) default 0,
Monto decimal (28,4) default 0, IVA decimal (28,4) default 0  )
go

alter table dbo.fafDevDetalle add constraint pkfafDevDetalle primary key (IDDevDetalle)
go

alter table dbo.fafDevDetalle add constraint ukfafDevDetalle Unique (IDDevolucion, IDProducto, IDLote )
go

alter table dbo.fafDevDetalle add constraint ukfafDevDetalleDev foreign key (IDDevolucion) references dbo.fafDevolucion (IDDevolucion)
go

alter table dbo.fafDevDetalle add constraint ukfafDevDetalleProd foreign key (IDProducto) references dbo.invProducto (IDProducto)
go

alter table dbo.fafDevDetalle add constraint ukfafDevDetalleLote foreign key (IDLote, IDProducto) references dbo.invLote (IDLote, IDProducto)
go

alter table dbo.invBodega add ConsecMaskDevolucion nvarchar(20)
go

alter table dbo.invBodega add constraint fkBodegaConsecDev  foreign key (ConsecMaskDevolucion) references dbo.globalConsecMask (Codigo)
go

-- exec  dbo.invgetBodegasFromUsuario 'azepeda', 1
ALTER Procedure dbo.invgetBodegasFromUsuario @Usuario nvarchar(20), @SoloFacturacion bit = false 
as
if @SoloFacturacion is null 
	set @SoloFacturacion = 0
set nocount on
Select U.Usuario, S.Descr, U.IDBodega, B.Descr, B.CodigoConsecMask, B.consecMaskDevolucion 
From  dbo.invUsuarioBodega U inner join dbo.secUsuario S on U.Usuario = S.Usuario 
inner join dbo.invBodega B on U.IDBodega = B.IDBodega 
Where U.Usuario = @Usuario and ((@SoloFacturacion = 1 and  Puedefacturar = 1) or @SoloFacturacion = 0 )
go


Create Procedure dbo.fafUpdateDevolucion @Operacion nvarchar(1), @IDDevolucion bigint OUTPUT,
@IDFactura bigint, 
@Fecha date, @Consecutivo nvarchar(20), @Devolucion nvarchar(20),@IDBodega int, @IDMoneda int,  
@Usuario nvarchar(20), @TipoCambio decimal(28,4) , @Anulada bit, @NotaCredito bit, @IDNotaCredito int = null  
as
set nocount on 
if @Operacion = 'I'
begin
 Insert dbo.fafDevolucion (IDFactura, Fecha, Consecutivo, Devolucion, IDBodega, IDMoneda, Usuario, TipoCambio,  Anulada, NotaCredito, IDNotaCredito)
 values (@IDFactura,@Fecha,@Consecutivo, @Devolucion,@IDBodega, @IDMoneda, @Usuario, @TipoCambio, @Anulada, @NotaCredito, @IDNotaCredito)
 SET @IDDevolucion = @@IDENTITY 
 Update dbo.globalConsecMask set Consecutivo = @Devolucion where Codigo = @Consecutivo
 RETURN @IDDevolucion
end
if @Operacion = 'F'
begin
	Update dbo.fafDevolucion set IDNotaCredito = @IDNotaCredito
	Where IDDevolucion = @IDDevolucion
end
go

Create Procedure dbo.fafUpdateDevDetalle @Operacion nvarchar(1), 
@IDDevolucion bigint , @IDProducto bigint , @IDLote int , 
@Cantidad decimal(28,4), @Precio decimal(28,4) , 
@PorcDescBonif decimal(28,2) , @PorcDescEspecial decimal(28,2) ,
@Monto decimal (28,4), @IVA decimal (28,4)
as
set nocount on 
if @Operacion = 'I'
begin
	Insert dbo.fafDevDetalle ( IDDevolucion, IDProducto, IDLote, Cantidad, Precio,  PorcDescBonif, PorcDescEspecial, Monto, IVA )
	values ( @IDDevolucion, @IDProducto, @IDLote, @Cantidad,@Precio, @PorcDescBonif, @PorcDescEspecial, @Monto, @IVA  )
end
go

alter table dbo.fafFactura add Asiento nvarchar(20), AsientoReversion nvarchar(20)
go

-- Aqui eliminamos lso precios de la tabla porque estos deben ser dinamicos 
--Alter Table dbo.fafTablaBonificacion add Precio decimal(28,2), PrecioPublico decimal(28,2)
--go
-- tabla correcta
Create procedure dbo.fafUpdateTablaBonificacion @Operacion nvarchar(1), @IDTabla int, 
@IDProveedor int , @IDProducto bigint,  
@CantDesde int, @CantHasta int, @Bono int 

as
set nocount on 
	
if @Operacion = 'I' 
begin
	Insert dbo.fafTablaBonificacion ( IDProveedor , IDProducto,  CantDesde , CantHasta, Bono)
	values ( @IDProveedor , @IDProducto, @CantDesde, @CantHasta, @Bono )
end

if @Operacion = 'U'
begin
	Update dbo.fafTablaBonificacion set CantDesde = @CantDesde , CantHasta = @CantHasta , Bono = @Bono
	where  IDTabla = @IDTabla 
	
end
if @Operacion = 'D'
begin
	Delete from dbo.fafTablaBonificacion
	where  IDTabla = @IDTabla 
end
go

create procedure dbo.fafUpdateTablaDescuento @Operacion nvarchar(1), @IDTabla int, 
@IDProveedor int , @IDProducto bigint, @FechaDesde date, @FechaHasta date,
@CantDesde int, @CantHasta int, @Descuento decimal(28,2) 

as
set nocount on 
	
if @Operacion = 'I' 
begin
	Insert dbo.fafTablaDescuento ( IDProveedor , IDProducto, FechaDesde , FechaHasta,  CantDesde , CantHasta, Descuento)
	values ( @IDProveedor , @IDProducto,@FechaDesde, @FechaHasta, @CantDesde, @CantHasta, @Descuento )
end

if @Operacion = 'U'
begin
	Update dbo.fafTablaDescuento set FechaDesde = @FechaDesde, FechaHasta = @FechaHasta, CantDesde = @CantDesde , CantHasta = @CantHasta , Descuento = @Descuento
	where  IDTabla = @IDTabla 
	
end
if @Operacion = 'D'
begin
	Delete from dbo.fafTablaDescuento
	where  IDTabla = @IDTabla 
end

if @Operacion = 'F'
begin
	Update dbo.fafTablaDescuento set FechaDesde = @FechaDesde, FechaHasta = @FechaHasta
	where  IDProveedor  = @IDProveedor 
end

go


-- exec dbo.fafSetEscalaBonificacion 1, 1 delete from dbo.fafTablaBonificacion where idproducto = 2
-- select * from dbo.fafTablaBonificacion exec dbo.fafSetEscalaBonificacion 1,100
Create Procedure dbo.fafSetEscalaBonificacion @IDProveedor int, @IDProducto bigint = null
-- esta escala es en batch a todos los productos de un proveedor, la que tenga @IDProducto
as
set nocount on 
	Insert dbo.fafTablaBonificacion ( IDProveedor , IDProducto,  CantDesde , CantHasta, Bono)
	
	SELECT L.IDProveedor, L.IDProducto, L.CantDesde, L.CantHasta, L.Bono 
	FROM (
	Select T1.IDProveedor, P.IDProducto,  T1.CantDesde , T1.CantHasta, T1.Bono
	from 
	(
	Select @IDProveedor IDProveedor, B.CantDesde , B.CantHasta, B.Bono
	from dbo.fafTablaBonificacion B
	Where IDProveedor =  @IDProveedor and IDProducto = @IDProducto ) T1
	 Cross join  ( Select IDProducto From dbo.invProducto   
	where IDProveedor = @IDProveedor and IDProducto <> @IDProducto and Bonifica = 1) P 
	) L LEFT JOIN dbo.fafTablaBonificacion R 
	ON L.IDProveedor = R.IDProveedor AND L.IDProducto = R.IDProducto 
	where R.IDProducto is null and R.IDProveedor is null and R.CantDesde is null and R.CantHasta is null and R.Bono is null
go

-- select * from faftablaDescuento
Create Procedure dbo.fafSetDescuentoConEscala @IDProveedor int, @IDProducto bigint = null
-- esta escala es en batch a todos los productos de un proveedor, la que tenga @IDProducto
as
set nocount on 
	Insert dbo.fafTablaDescuento ( IDProveedor , IDProducto, FechaDesde,FechaHasta ,  CantDesde , CantHasta, Descuento)
	
	SELECT L.IDProveedor, L.IDProducto, L.FechaDesde, L.FechaHasta, L.CantDesde, L.CantHasta, L.Descuento 
	FROM (
	Select T1.IDProveedor, P.IDProducto, T1.FechaDesde, T1.FechaHasta,  T1.CantDesde , T1.CantHasta, T1.Descuento
	from 
	(
	Select @IDProveedor IDProveedor, B.FechaDesde, B.FechaHasta,  B.CantDesde , B.CantHasta, B.Descuento
	from dbo.fafTablaDescuento B
	Where IDProveedor =  @IDProveedor and IDProducto = @IDProducto ) T1
	 Cross join  ( Select IDProducto From dbo.invProducto   
	where IDProveedor = @IDProveedor and IDProducto <> @IDProducto and Bonifica = 1) P 
	) L LEFT JOIN dbo.fafTablaDescuento R 
	ON L.IDProveedor = R.IDProveedor AND L.IDProducto = R.IDProducto 
	where R.IDProducto is null and R.IDProveedor is null and R.FechaDesde is null and R.FechaHasta is null and R.CantDesde is null and R.CantHasta is null and R.Descuento is null
go


Create Procedure dbo.fafSetEscalaBonificacionIndividual @IDProveedor int, @IDProductoBase bigint = null, @IDProductoReceptor bigint = null
-- esta escala es a un producto Receptor que tenga las escalas del Producto Base
as
set nocount on 

	Delete  dbo.fafTablaBonificacion  Where IDProveedor =  @IDProveedor and IDProducto = @IDProductoReceptor
	Insert dbo.fafTablaBonificacion ( IDProveedor , IDProducto,  CantDesde , CantHasta, Bono)
	Select @IDProveedor IDProveedor, @IDProductoReceptor IDProducto, B.CantDesde , B.CantHasta, B.Bono
	from dbo.fafTablaBonificacion B
	Where IDProveedor =  @IDProveedor and IDProducto = @IDProductoBase
go

Create Procedure dbo.fafSetDescuentoIndividual @IDProveedor int, @IDProductoBase bigint = null, @IDProductoReceptor bigint = null
-- esta escala es a un producto Receptor que tenga las escalas del Producto Base
as
set nocount on 

	Delete  dbo.fafTablaDescuento   Where IDProveedor =  @IDProveedor and IDProducto = @IDProductoReceptor
	Insert dbo.fafTablaDescuento ( IDProveedor , IDProducto,FechaDesde, FechaHasta,  CantDesde , CantHasta, Descuento)
	Select @IDProveedor IDProveedor, @IDProductoReceptor IDProducto, B.FechaDesde, B.FechaHasta , B.CantDesde , B.CantHasta, B.Descuento
	from dbo.fafTablaDescuento B
	Where IDProveedor =  @IDProveedor and IDProducto = @IDProductoBase
go

-- exec dbo.fafgetTablaBonificacion 1, 0
create Procedure dbo.fafgetTablaBonificacion @IDProveedor int, @IDProducto bigint = null
as


if @IDProducto is null
	set @IDProducto = 0

set nocount on 
SELECT T.IDTabla, T.IDProveedor, P.Nombre, T.IDProducto, A.Descr Descr, 
 T.CantDesde, T.CantHasta, Bono  
FROM dbo.fafTablaBonificacion T inner join dbo.cppProveedor P on T.IDProveedor = P.IDProveedor 
inner join dbo.invProducto A on T.IDProducto = A.IDProducto 
where (( @IDProveedor = 0  ) or ( @IDProveedor <> 0 and T.IDProveedor = @IDProveedor ) ) 
and
(@IDProducto = 0 or (@IDProducto <> 0 and T.IDProducto = @IDProducto))
order by T.IDProveedor 

go

create Procedure dbo.fafgetTablaDescuento @IDProveedor int, @IDProducto bigint = null
as

if @IDProducto is null
	set @IDProducto = 0

set nocount on 
SELECT T.IDTabla, T.IDProveedor, P.Nombre, T.IDProducto, A.Descr Descr, 
T.FechaDesde, T.FechaHasta, T.CantDesde, T.CantHasta, Descuento   
FROM dbo.fafTablaDescuento  T inner join dbo.cppProveedor P on T.IDProveedor = P.IDProveedor 
inner join dbo.invProducto A on T.IDProducto = A.IDProducto 
where (( @IDProveedor = 0  ) or ( @IDProveedor <> 0 and T.IDProveedor = @IDProveedor ) ) 
and
(@IDProducto = 0 or (@IDProducto <> 0 and T.IDProducto = @IDProducto))
order by T.IDProveedor 

go



-- delete from dbo.fafTablaBonificacion
--exec fafprintTablaBonificacionPrecios 0,1,1 select * from fafPrecios alter table invProducto add Generico nvarchar(50)
create procedure fafprintTablaBonificacionPrecios @Proveedor int, @IDNivelPrecio int, @IDMoneda int
as
set nocount on
if @Proveedor is null 
	set @Proveedor = 0
Select Pr.IDProveedor, V.Nombre, Pr.IDProducto, Pr.Descr, U.Descr Presentacion, Pr.Generico,
Pr.CostoPromLocal, Pr.CostoPromDolar, isnull(pr.Precio,0) Precio,ISNULL(Pr.Publico,0) Publico,
isnull(MAX(escala1),'') Escala1,isnull(MAX(escala2),'') Escala2,
isnull(MAX(escala3),'') Escala3,isnull(MAX(escala4),'') Escala4
from 

( Select P.IDProducto, A.Descr, A.IDProveedor, A.IDUnidad, A.Generico, P.IDNivel, P.IDMoneda, P.Precio, P.Publico,
	A.CostoPromDolar, A.CostoPromLocal 
	From  dbo.fafPrecios P inner join dbo.invProducto A
	on P.IDProducto = A.IDProducto 
	Where IDNivel = @IDNivelPrecio and IDMoneda = @IDMoneda 	
) Pr left join 
(	
	Select IDProveedor, IDProducto, 
	 isnull(case when IDEscala = 1 then isnull(Escala,'') end,'') Escala1,
	 isnull(case when IDEscala = 2 then isnull(Escala,'') end,'') Escala2,
	 isnull(case when IDEscala = 3 then isnull(Escala,'') end,'') Escala3,
	 isnull(case when IDEscala = 4 then isnull(Escala,'') end,'') Escala4
	 From (
	 SELECT IDProveedor, IDProducto,  
	   ROW_NUMBER() OVER(PARTITION BY IDProveedor, IDProducto ORDER BY IDProducto ASC) IDEscala,
	 CAST(CantDesde AS NVARCHAR(3)) + ' - ' + CAST(CantHasta AS NVARCHAR(20)) + ' : ' + CAST(Bono AS NVARCHAR(3)) Escala
	 FROM dbo.fafTablaBonificacion 
	 Where (IDProveedor = @Proveedor or @Proveedor = 0)) A
	Group by IDProveedor, IDProducto , IDEscala, Escala 
 ) T on  Pr.IDProducto = T.IDProducto
left join dbo.cppProveedor V
	on Pr.IDProveedor = V.IDProveedor 
left join dbo.invUnidadMedida U
	on Pr.IDUnidad = U.IDUnidad 
Group by Pr.IDProveedor, V.Nombre, Pr.IDProducto, Pr.Descr, U.Descr , Pr.Generico,
Pr.CostoPromLocal, Pr.CostoPromDolar, pr.Precio, Precio,Pr.Publico
go

-- select dbo.fafgetBono( 100, 55) select * from faftablaBonificacion
Create Function dbo.fafgetBono( @IDProducto int, @CantFactura int )
returns int
as
begin

Declare @Bono int, @MaxEscala int, @MaxBono int

	Select @MaxEscala = MAX(CantDesde), @MaxBono = max (Bono)
	From dbo.fafTablaBonificacion 
	Where IDProducto = @IDProducto 

	Select @Bono = Bono 
	From dbo.fafTablaBonificacion 
	Where IDProducto = @IDProducto and @CantFactura between CantDesde and CantHasta 
	if @Bono = @MaxBono 	
	set @Bono = case when @MaxEscala is not null and @MaxEscala >0 
	then cast((@CantFactura / @MaxEscala) as int ) * isnull(@MaxBono,0) else 0 end
	
Return isnull(@Bono,0)
end
go
--Create Procedure dbo.fafgetTablaBonificacion @IDProveedor int, @IDProducto bigint = null
--as

--if @IDProducto is null
--	set @IDProducto = 0

--set nocount on 
--SELECT T.IDTabla, T.IDProveedor, P.Nombre, T.IDProducto, A.Descr Descr,
-- T.CantDesde, T.CantHasta, T.Bono, T.Precio, T.PrecioPublico 
--FROM dbo.fafTablaBonificacion T inner join dbo.cppProveedor P on T.IDProveedor = P.IDProveedor 
--inner join dbo.invProducto A on T.IDProducto = A.IDProducto 
--where (( @IDProveedor = 0  ) or ( @IDProveedor <> 0 and T.IDProveedor = @IDProveedor ) ) 
--and
--(@IDProducto = 0 or (@IDProducto <> 0 and T.IDProducto = @IDProducto))
--order by T.IDProveedor 

--go


--alter table dbo.fafParametros add DefaultTipoFact bit default 0, TipoFactDefault smallint, 
--DefaultTipoEntrega bit default 0, TipoEntregaDefault int
--go
-- nuevo 10-09-2019
--alter table dbo.fafParametros add EditaPrecioPedidoenFactura bit default 0
--go
--alter table dbo.fafParametros add EditaCantidadPedidoenFactura bit default 0
--go
-- update  dbo.fafParametros set EditaCantidadPedidoenFactura = 0, TipoFactDefault = 0, DefaultTipoEntrega = 0, TipoEntregaDefault = 0
-- exec dbo.fafgetParametros 2

Create Procedure dbo.fafUpdateParametros @IDParametros int ,
	@IDNivelPrecioPub int ,
	@IDPlazoCont int ,
	@TipoCambioFact nvarchar(20) ,
	@TipoCambioCont nvarchar(20) ,
	@NumeroLineasFact int ,
	@IntegracionCont bit ,
	@IDPaquete int ,
	@CtrImpuesto int ,
	@CtaImpuesto bigint ,
	@AutorizaPrecioPorFactura bit ,
	@paginaFacturaAltura decimal(28, 2) ,
	@paginaFacturaAncho decimal(28, 2) ,
	@FacturaPersonalizada bit ,	
	@DefaultTipoFact bit ,	
	@TipoFactDefault smallint ,	
	@DefaultTipoEntrega bit ,
	@TipoEntregaDefault int ,
	@EditaPrecioPedidoenFactura bit ,
	@EditaCantidadPedidoenFactura bit ,	
	@DigitosDecimales int

as
set nocount on 
if not exists (select IDParametros from  dbo.fafParametros ) 
	insert dbo.fafParametros (
	[IDNivelPrecioPub]
      ,[IDPlazoCont]
      ,[TipoCambioFact]
      ,[TipoCambioCont]
      ,[NumeroLineasFact]
      ,[IntegracionCont]
      ,[AutorizaPrecioPorFactura]
      ,[IDPaquete]
      ,[CtrImpuesto]
      ,[CtaImpuesto]
      ,[paginaFacturaAltura]
      ,[paginaFacturaAncho]
      ,[FacturaPersonalizada]
      ,[DefaultTipoFact]
      ,[TipoFactDefault]
      ,[DefaultTipoEntrega]
      ,[TipoEntregaDefault]
      ,[EditaPrecioPedidoenFactura]
      ,[EditaCantidadPedidoenFactura]
      ,[DigitosDecimales] ) 
	
	values (	@IDNivelPrecioPub  ,
	@IDPlazoCont  ,
	@TipoCambioFact ,
	@TipoCambioCont  ,
	@NumeroLineasFact  ,
	@IntegracionCont  ,
	@AutorizaPrecioPorFactura ,
	@IDPaquete  ,
	@CtrImpuesto  ,
	@CtaImpuesto  ,
	@paginaFacturaAltura  ,
	@paginaFacturaAncho  ,
	@FacturaPersonalizada  ,
	@DefaultTipoFact ,
	@TipoFactDefault  ,
	@DefaultTipoEntrega  ,
	@TipoEntregaDefault  ,
	@EditaPrecioPedidoenFactura  ,
	@EditaCantidadPedidoenFactura  ,
	@DigitosDecimales )
else
	Update  dbo.fafParametros set 
	IDNivelPrecioPub = @IDNivelPrecioPub  ,
	IDPlazoCont =@IDPlazoCont  ,
	TipoCambioFact = @TipoCambioFact ,
	TipoCambioCont = @TipoCambioCont  ,
	NumeroLineasFact = @NumeroLineasFact  ,
	IntegracionCont  = @IntegracionCont  ,
	AutorizaPrecioPorFactura  = @AutorizaPrecioPorFactura ,
	IDPaquete = @IDPaquete  ,
	CtrImpuesto = @CtrImpuesto  ,
	CtaImpuesto = @CtaImpuesto  ,
	paginaFacturaAltura = @paginaFacturaAltura  ,
	paginaFacturaAncho = @paginaFacturaAncho  ,
	FacturaPersonalizada = @FacturaPersonalizada  ,
	DefaultTipoFact = @DefaultTipoFact ,
	TipoFactDefault  = @TipoFactDefault  ,
	DefaultTipoEntrega  = @DefaultTipoEntrega  ,
	TipoEntregaDefault = @TipoEntregaDefault  ,
	EditaPrecioPedidoenFactura = @EditaPrecioPedidoenFactura  ,
	EditaCantidadPedidoenFactura = @EditaCantidadPedidoenFactura  ,
	DigitosDecimales = @DigitosDecimales
	Where IDParametros = @IDParametros
go

Create Procedure dbo.fafgetParametros @IDParametros int
as
set nocount on
Select  IDNivelPrecioPub, IDPlazoCont , TipoCambioFact , TipoCambioCont , NumeroLineasFact , IntegracionCont ,
IDPaquete, CtrImpuesto, CtaImpuesto, AutorizaPrecioPorFactura, isnull(paginaFacturaAltura,0) paginaFacturaAltura,
 isnull(paginaFacturaAncho,0) paginaFacturaAncho, isnull(FacturaPersonalizada, 0) FacturaPersonalizada,
 DefaultTipoFact, TipoFactDefault, DefaultTipoEntrega, TipoEntregaDefault, EditaPrecioPedidoenFactura
 , EditaCantidadPedidoenFactura, DigitosDecimales 
from dbo.fafParametros 
where IDParametros = @IDParametros
go


Create Procedure dbo.fafUpdatePedidoProd @Operacion nvarchar(1),
	@IDPedido int, @IDBodega int,
	@IDProducto bigint ,@Cantidad decimal(28, 4) ,
	@PrecioLocal decimal(28, 4) , @PrecioDolar decimal(28, 4) ,
	@ImpuestoLocal decimal(28, 4), @ImpuestoDolar decimal(28, 4),
	@SubTotalLocal decimal(28, 4), @SubTotalDolar decimal(28, 4),
	@SubTotalFinalLocal decimal(28, 4), @SubTotalFinalDolar decimal(28, 4),
@Bonifica bit ,@BonifConProd bit , @CantBonificada  decimal (28,4), @CantPrecio  decimal (28,4),
@DescuentoLocal  decimal (28,4) , @DescuentoDolar  decimal (28,4) , 
@PorcDescuentoEsp   decimal (28,4), @DescuentoEspecialLocal  decimal (28,4) , 
@DescuentoEspecialDolar  decimal (28,4), @PorcImpuesto decimal(28,2),
@PrecioLista  decimal (28,4), @Ahorro decimal (28,4)
as
set nocount on 
declare  @TipoCambio decimal (28,4)

set @TipoCambio = (Select TipoCambio from dbo.fafPedido where IDPedido = @IDPedido and IDBodega = @IDBodega )
if @Operacion = 'I'
begin
	Insert dbo.fafPedidoProd (IDPedido, IDBodega , IDProducto, Cantidad, PrecioLocal, PrecioDolar,    ImpuestoLocal,   ImpuestoDolar, SubtotalLocal, SubTotalDolar, SubtotalFinalLocal, SubTotalFinalDolar,
	Bonifica  ,BonifConProd  , CantBonificada  , CantPrecio, DescuentoLocal   , DescuentoDolar,
PorcDescuentoEsp   , DescuentoEspecialLocal, DescuentoEspecialDolar, PorcImpuesto, PrecioLista, Ahorro   )
	values (@IDPedido, @IDBodega , @IDProducto, @Cantidad, @PrecioLocal, @PrecioDolar,  @ImpuestoLocal, @ImpuestoDolar, @SubtotalLocal, @SubTotalDolar,@SubtotalFinalLocal, @SubTotalFinalDolar,
	@Bonifica  ,@BonifConProd  , @CantBonificada  , @CantPrecio, @DescuentoLocal    ,@DescuentoDolar,
	@PorcDescuentoEsp   , @DescuentoEspecialLocal, @DescuentoEspecialDolar, @PorcImpuesto, @PrecioLista, @Ahorro   ) 
end
if @Operacion = 'U'
begin
	if exists(Select IDPedido From dbo.fafPedido where IDPedido = @IDPedido and IDBodega = @IDBodega
	and Estado = 'C')
	begin
 
	--set @SubTotalLocal = ( @Cantidad * @PrecioLocal) 
	set @SubTotalDolar = (@SubTotalLocal / @TipoCambio)
	--set @DescuentoLocal = (@CantBonificada * @PrecioLocal) 
	set @DescuentoDolar = (@DescuentoLocal / @TipoCambio) 
	--set @DescuentoEspecialLocal = (@Cantidad * @PrecioLocal) * (@PorcDescuentoEsp /100)
	set @DescuentoEspecialDolar = (@DescuentoEspecialLocal / @TipoCambio)
	set @SubTotalFinalDolar = ( @SubTotalFinalLocal / @TipoCambio )
	set @ImpuestoDolar = ( @ImpuestoLocal / @TipoCambio )
-- Se supone que el precio que entra ya viene modificado en caso de que una bonificacion se haya aplicado al precio
	Update dbo.fafPedidoProd  set Cantidad = @Cantidad, PrecioDolar = @PrecioLocal/@TipoCambio, 
	 PrecioLocal = @PrecioLocal , 
	 Bonifica = @Bonifica  ,BonifConProd=@BonifConProd  , CantBonificada=@CantBonificada  , CantPrecio=@CantPrecio  , 
	 DescuentoLocal = @DescuentoLocal  , 
	 DescuentoDolar= @DescuentoDolar ,
	 DescuentoEspecialLocal = @DescuentoEspecialLocal,
	 DescuentoEspecialDolar = @DescuentoEspecialDolar, 
	 SubTotalLocal = @SubTotalLocal,
	 SubTotalDolar = @SubTotalDolar,
	 SubTotalFinalLocal = @SubTotalFinalLocal,	
	 SubTotalFinalDolar =@SubTotalFinalDolar,	 
	 ImpuestoLocal = @ImpuestoLocal ,
	 ImpuestoDolar = @ImpuestoDolar  ,
	 PorcDescuentoEsp = @PorcDescuentoEsp,
	 PorcImpuesto = @PorcImpuesto,
	 PrecioLista = @PrecioLista,
	 Ahorro= @Ahorro
	  	
	where IDPedido = @IDPedido and IDBodega = @IDBodega and IDProducto = @IDProducto 
	end
end
if @Operacion = 'D'
begin
	if exists(Select IDPedido From dbo.fafPedido where IDPedido = @IDPedido and IDBodega = @IDBodega
	and Estado = 'C')
	begin
	Delete from dbo.fafPedidoProd 
	where IDPedido = @IDPedido and IDBodega = @IDBodega and IDProducto = @IDProducto 
	end
end
go

--alter table dbo.fafprecios add Publico decimal (28, 2) default 0
--go
--update dbo.fafprecios set Publico = 0
--go exec dbo.fafgetListaPrecio 0,0,0

Create procedure dbo.fafgetListaPrecio ( @IDProducto bigint, @IDNivel int = null, @IDProveedor int= null )
as
set nocount on
if @IDProveedor is null
 set @IDProveedor = 0
 if @IDNivel is null
  set @IDNivel = 0
Select isnull(A.IDProveedor,0) IDProveedor , V.Nombre NomProveedor, P.IDProducto, A.Descr , P.IDNivel , 
N.Descr DescrNivel, P.IDMoneda, M.Descr DescrMoneda, P.Precio, P.Publico
From dbo.fafPrecios P inner join dbo.invProducto A on P.IDProducto = A.IDProducto 
inner join dbo.fafNivelPrecio N on P.IDNivel = N.IDNivel 
inner join dbo.globalMoneda M on P.IDMoneda = M.IDMoneda 
inner join dbo.cppProveedor V
on A.IDProveedor = V.IDProveedor 
Where (P.IDProducto= @IDProducto or @IDProducto = 0) and
(P.IDNivel = @IDNivel or @IDNivel = 0) and (isnull(A.IDProveedor,0)= @IDProveedor or @IDProveedor = 0)
go

alter Procedure [dbo].[fafUpdatePrecios] @Operacion nvarchar(1),
	@IDProducto bigint ,
	@IDNivel int ,
	@IDMoneda int ,
	@Precio decimal(28, 2), @Publico decimal(28, 2)
as
set nocount on
if @Operacion = 'I'
begin
	Insert dbo.fafPrecios (IDProducto,  IDNivel , IDMoneda , Precio, Publico )
	values (@IDProducto,  @IDNivel , @IDMoneda , @Precio, @Publico)
	Update dbo.invProducto set PrecioFarmaciaLocal = @Precio, PrecioPublicoLocal =  @Publico
	Where IDProducto = @IDProducto
end
if @Operacion = 'U'
begin
	Update dbo.fafPrecios set Precio = @Precio, Publico = @Publico
	where IDProducto = @IDProducto and IDNivel = @IDNivel and IDMoneda = @IDMoneda 
	Update dbo.invProducto set PrecioFarmaciaLocal = @Precio, PrecioPublicoLocal =  @Publico
	Where IDProducto = @IDProducto
	
end
if @Operacion = 'D'
begin
	Delete dbo.fafPrecios 
	where IDProducto = @IDProducto and IDNivel = @IDNivel and IDMoneda = @IDMoneda 
end

go

Create Table dbo.fafBitacoraPrecio (IDBitacora int not null identity (1,1), 
 IDProducto int not null, Fecha datetime not null, IDNivel int not null, IDMoneda int not null,
  Precio decimal (28,3) default 0, Publico decimal(28,2) default 0,
 Usuario nvarchar(20))
go
alter table dbo.fafBitacoraPrecio add constraint pkBitacora primary key (IDBitacora)
go
alter table dbo.fafBitacoraPrecio add constraint ukBitacora  unique (IDProducto, Fecha,IDNivel,IDMoneda)
go
-- drop Procedure dbo.fafAumentaListaPrecios
Create Procedure dbo.fafIncrementaListaPrecios (@PorFactorAumento decimal (8,2), @PorFactorAumentoPublico decimal (8,2), @Fecha datetime, 
@IDNivel int , @IDMoneda int , @Usuario nvarchar(20)) 
as
set nocount on
-- Hacer el backup de la lista de Precios 
Insert dbo.fafBitacoraPrecio(IDProducto,Fecha,IDNivel,IDMoneda,Precio, Publico, Usuario) 
Select IDProducto, @Fecha, @IDNivel,@IDMoneda,Precio, Publico,@Usuario
from fafPrecios
-- Se incrementa la lista de Precios
Update dbo.fafPrecios set Precio = Precio + (Precio * @PorFactorAumento/100 ),
Publico = Publico + (Publico * @PorFactorAumentoPublico/100 )
Where IDNivel =@IDNivel and IDMoneda = @IDMoneda

-- actualizo precios en el maestro de productos 

	Update A set  PrecioFarmaciaLocal =  P.Precio, PrecioPublicoLocal = P.Publico 
	From dbo.fafPrecios P inner join dbo.invProducto A
	on P.IDProducto = A.IDProducto 
	Where P.IDNivel =@IDNivel and P.IDMoneda = @IDMoneda	
	
go

Create Procedure dbo.fafAplicaInventario (@Modulo AS NVARCHAR(4),@IDDocumento AS INT,@Usuario AS NVARCHAR(50))
as
set nocount on
declare @IDTransaccion AS BIGINT 
exec dbo.[invCreaPaqueteInvFactura] @Modulo ,@IDDocumento,@Usuario,@IDTransaccion OUTPUT
exec [dbo].invAplicaTransaccion @IDTransaccion 

go

-- select dbo.fafEscalaSinMaximoEnDescuento() 
Create Function dbo.fafEscalaSinMaximoEnDescuento() 
returns bit
as
begin
declare @Resultado bit 
set @Resultado = 0
if exists (
	Select IDProveedor, IDProducto, MAX (cantHasta) MaximaEscala
	from dbo.fafTablaDescuento 
	group by IDProveedor, IDProducto
	having (MAX(cantHasta) < 9999)
)
	set @Resultado = 1 
else 
	set @Resultado = 0
Return isnull(@Resultado,0)
end
go
-- exec  dbo.fafgetProductosSinEscalaMaximaEnDescuento
Create Procedure dbo.fafgetProductosSinEscalaMaximaEnDescuento
as
set nocount on 

SELECT L.IDProveedor, P.Nombre, L.IDProducto, A.Descr 
FROM (
	Select IDProveedor, IDProducto, MAX (cantHasta) MaximaEscala
	from dbo.fafTablaDescuento 
	group by IDProveedor, IDProducto
	having (MAX(cantHasta) < 9999)
	) L INNER JOIN cppProveedor P on L.IDProveedor = P.IDProveedor
	INNER JOIN invProducto A on L.IDProducto = A.IDProducto 

go


Create Function dbo.fafEscalaSinMaximoEnBonificacion() 
returns bit
as
begin
declare @Resultado bit 
set @Resultado = 0
if exists (
	Select IDProveedor, IDProducto, MAX (cantHasta) MaximaEscala
	from dbo.fafTablaBonificacion  
	group by IDProveedor, IDProducto
	having (MAX(cantHasta) < 9999)
)
	set @Resultado = 1 
else 
	set @Resultado = 0
Return isnull(@Resultado,0)
end
go


Create Procedure dbo.fafgetProductosSinEscalaMaximaEnBonficacion
as
set nocount on 

SELECT L.IDProveedor, P.Nombre, L.IDProducto, A.Descr 
FROM (
	Select IDProveedor, IDProducto, MAX (cantHasta) MaximaEscala
	from dbo.fafTablaBonificacion  
	group by IDProveedor, IDProducto
	having (MAX(cantHasta) < 9999)
	) L INNER JOIN cppProveedor P on L.IDProveedor = P.IDProveedor
	INNER JOIN invProducto A on L.IDProducto = A.IDProducto 

go
-- select * from fafTablaDescuento SELECT dbo.fafgetDescuentoPorEscala(100, 48)
Create Function dbo.fafgetDescuentoPorEscala( @IDProducto int, @CantFactura int )
returns Decimal (28, 2)
as
begin

Declare @Descuento decimal (28,2), @MaxEscala int, @MaxDescuento decimal(28,2)

	Select @MaxEscala = MAX(CantDesde), @MaxDescuento = max (Descuento)
	From dbo.fafTablaDescuento 
	Where IDProducto = @IDProducto 

	Select @Descuento = Descuento 
	From dbo.fafTablaDescuento 
	Where IDProducto = @IDProducto and @CantFactura between CantDesde and CantHasta 
	if @Descuento = @MaxDescuento 	
	set @Descuento = case when @MaxEscala is not null and @MaxEscala >0 
	then cast((@CantFactura / @MaxEscala) as int ) * isnull(@MaxDescuento,0) else 0 end
	
Return isnull(@Descuento,0)
end
go

--exec fafprintTablaDescuentoEscalaPrecios 1, 1, 1
Create procedure fafprintTablaDescuentoEscalaPrecios @Proveedor int, @IDNivelPrecio int, @IDMoneda int
as
set nocount on
if @Proveedor is null 
	set @Proveedor = 0
Select Pr.IDProveedor, V.Nombre, Pr.IDProducto, Pr.Descr, FechaDesde, FechaHasta, U.Descr Presentacion, Pr.Generico,
Pr.CostoPromLocal, Pr.CostoPromDolar, isnull(pr.Precio,0) Precio,ISNULL(Pr.Publico,0) Publico,
isnull(MAX(escala1),'') Escala1,isnull(MAX(escala2),'') Escala2,
isnull(MAX(escala3),'') Escala3,isnull(MAX(escala4),'') Escala4
from 

( Select P.IDProducto, A.Descr, A.IDProveedor, A.IDUnidad, A.Generico, P.IDNivel, P.IDMoneda, P.Precio, P.Publico,
	A.CostoPromDolar, A.CostoPromLocal 
	From  dbo.fafPrecios P inner join dbo.invProducto A
	on P.IDProducto = A.IDProducto 
	Where IDNivel = @IDNivelPrecio and IDMoneda = @IDMoneda 	
) Pr left join 
(	
	Select IDProveedor, IDProducto, FechaDesde, FechaHasta,
	 isnull(case when IDEscala = 1 then isnull(Escala,'') end,'') Escala1,
	 isnull(case when IDEscala = 2 then isnull(Escala,'') end,'') Escala2,
	 isnull(case when IDEscala = 3 then isnull(Escala,'') end,'') Escala3,
	 isnull(case when IDEscala = 4 then isnull(Escala,'') end,'') Escala4
	 From (
	 SELECT IDProveedor, IDProducto, FechaDesde, FechaHasta, 
	   ROW_NUMBER() OVER(PARTITION BY IDProveedor, IDProducto ORDER BY IDProducto ASC) IDEscala,
	 CAST(CantDesde AS NVARCHAR(3)) + ' - ' + CAST(CantHasta AS NVARCHAR(20)) + ' : ' + CAST(Descuento AS NVARCHAR(10)) Escala
	 FROM dbo.fafTablaDescuento 
	 Where (IDProveedor = @Proveedor or @Proveedor = 0)) A
	Group by IDProveedor, IDProducto , FechaDesde, FechaHasta, IDEscala, Escala 
 ) T on  Pr.IDProducto = T.IDProducto
left join dbo.cppProveedor V
	on Pr.IDProveedor = V.IDProveedor 
left join dbo.invUnidadMedida U
	on Pr.IDUnidad = U.IDUnidad 
Group by Pr.IDProveedor, V.Nombre, Pr.IDProducto, Pr.Descr, FechaDesde, FechaHasta, U.Descr , Pr.Generico,
Pr.CostoPromLocal, Pr.CostoPromDolar, pr.Precio, Precio,Pr.Publico
go

-- exec dbo.fafprintPromocionPrecios 1, 1, 1
Create Procedure dbo.fafprintPromocionPrecios @Proveedor int, @IDNivelPrecio int, @IDMoneda int
as
set nocount on 
if @Proveedor is null 
	set @Proveedor = 0
Select Pr.IDProveedor, V.Nombre, Pr.IDProducto, Pr.Descr, P.Desde, P.Hasta, U.Descr Presentacion, Pr.Generico,
Pr.CostoPromLocal, Pr.CostoPromDolar, isnull(pr.Precio,0) Precio,ISNULL(Pr.Publico,0) Publico,
P.PorcDesc, P.PorcDescCliEsp, P.RequiereBonif 

from 

( Select P.IDProducto, A.Descr, A.IDProveedor, A.IDUnidad, A.Generico, P.IDNivel, P.IDMoneda, P.Precio, P.Publico,
	A.CostoPromDolar, A.CostoPromLocal 
	From  dbo.fafPrecios P inner join dbo.invProducto A
	on P.IDProducto = A.IDProducto 
	Where IDNivel = @IDNivelPrecio and IDMoneda = @IDMoneda 	
) Pr left join dbo.fafPromociones P
on Pr.IDProducto = P.IDProducto left join dbo.cppProveedor V
	on Pr.IDProveedor = V.IDProveedor 
left join dbo.invUnidadMedida U
	on Pr.IDUnidad = U.IDUnidad
Where (P.IDProveedor = @Proveedor or @Proveedor = 0 )
go

-- exec dbo.fafAplicaDevolucionInventario 12, 'azepeda'
Create Procedure dbo.fafAplicaDevolucionInventario @IDDocumento AS INT,@Usuario AS NVARCHAR(50)
as
set nocount on
declare @IDTransaccion bigint 
exec [dbo].[invCreaPaqueteInvDevFactura]  @IDDocumento, @Usuario, @IDTransaccion OUTPUT
exec [dbo].[invAplicaTransaccion] @IDTransaccion
go
-- select [dbo].[fafGetIDFactura] ( 1, '000037' )
CREATE FUNCTION [dbo].[fafGetIDFactura] ( @IDBodega int, @Factura nvarchar(20) )
-- this function returns the ID of any invoice
RETURNS bigint AS  
BEGIN 
declare @IDFactura bigint

Set @IDFactura = (SELECT top 1 IDFactura 
	FROM dbo.fafFactura   
	where IDBodega = @IDBodega and Factura = @Factura
	ORDER BY IDBodega, Factura desc)

return isnull(@IDFactura,0)
end
go
-- drop view dbo.vfafDevolucionProdLote 
Create view dbo.vfafDevolucionProdLote 
as  
Select F.IDCliente, F.Nombre, V.IDDevolucion, V.Devolucion, V.Fecha FechaDevolucion, V.IDFactura, F.Factura, F.Fecha FechaFactura, D.IDProducto, P.Descr,
D.IDLote, L.LoteProveedor,  PL.CantFacturada, PL.CantBonificada, PL.Cantidad CantidadEntregada,
D.Cantidad CantDevuelta, D.Monto MontoDevolucion, D.IVA IVADevolucion, ( D.Monto + D.IVA ) TotalDevolucion
From dbo.fafDevolucion V 
inner join dbo.fafDevDetalle D on V.IDDevolucion = D.IDDevolucion
inner join dbo.fafFactura F on V.IDFactura = F.IDFactura 
inner join dbo.invProducto P on D.IDProducto = P.IDProducto
inner join dbo.invLote L on D.IDLote = L.IDLote  
inner join dbo.fafFacturaProd FP on FP.IDFactura = V.IDFactura and FP.IDProducto = D.IDProducto 
inner join dbo.fafFacturaProdLote PL on FP.IDFacturaProd = PL.IDFacturaProd
go

Create procedure dbo.fafgetDevolucionHeader @IDCliente int, @Devolucion nvarchar(20), 
@FechaInicio date, @FechaFin date, @Factura nvarchar(20), @IDProducto int 
as
Select D.IDCliente, D.Nombre, D.IDDevolucion, D.Devolucion, D.FechaDevolucion, D.IDFactura, D.Factura, D.FechaFactura, 
SUM( D.MontoDevolucion ) MontoDevolucion, SUM(D.IVADevolucion) IVADevolucion, SUM(D.TotalDevolucion) TotalDevolucion
From dbo.vfafDevolucionProdLote D 
Where (IDCliente = @IDCliente or @IDCliente = 0) and 
(@Devolucion = '*' or (Devolucion like  '%' + @Devolucion + '%' )) and
(FechaDevolucion between @FechaInicio and @FechaFin) and 
(@Factura = '*' or (Devolucion like  '%' + @Factura + '%' )) and
(IDProducto = @IDProducto or @IDProducto = 0 )
GROUP BY D.IDCliente, D.Nombre, D.IDDevolucion, D.Devolucion, D.FechaDevolucion, D.IDFactura, D.Factura, D.FechaFactura 
ORDER BY D.IDDevolucion
go

--drop procedure dbo.fafgetDevolucionHeader
Create procedure dbo.fafgetDevolucionDetail @IDCliente int, @Devolucion nvarchar(20), 
@FechaInicio date, @FechaFin date, @Factura nvarchar(20), @IDProducto int 
as
Select D.IDCliente, D.Nombre, D.IDDevolucion, D.Devolucion, D.FechaDevolucion, D.IDFactura, D.Factura, D.FechaFactura, D.IDProducto, D.Descr,
D.IDLote, D.LoteProveedor,  D.CantFacturada, D.CantBonificada, D.CantidadEntregada,
D.CantDevuelta, D.MontoDevolucion, D.IVADevolucion, D.TotalDevolucion
From dbo.vfafDevolucionProdLote D 
Where (IDCliente = @IDCliente or @IDCliente = 0) and 
(@Devolucion = '*' or (Devolucion like  '%' + @Devolucion + '%' )) and
(FechaDevolucion between @FechaInicio and @FechaFin) and 
(@Factura = '*' or (Factura like  '%' + @Factura + '%' )) and
(IDProducto = @IDProducto or @IDProducto = 0 )
ORDER BY D.IDDevolucion
go

--exec dbo.fafgetDevolucionHeader 17, '*', '20200101', '20201231', '*',0
--exec dbo.fafgetDevolucionDetail 51,'000001','20201024','20201224','000038',0

--where Devolucion like ''''+  '%' + @Devolucion + '%' + ''''
--Create Procedure dbo.fafgetMontoEnLetras  @Monto decimal(28,4)
--as
--set nocount on 

--Select dbo.globalNumberToLetter (@Monto)
--go


--Exec dbo.fafgetMontoEnLetras 256.3458 -1,-1,-1

--select * from dbo.fafPrecios dbo.fafTipoFactura 
--select * from dbo.fafTipoEntrega  SELECT * FROM DBO.FAFPARAMETROS



-- Update dbo.invbodega set ConsecMaskDevolucion = 'D'



--Select * from dbo.fafDevolucion  Select * from dbo.fafDevDetalle Delete from dbo.fafDevolucion  Delete from dbo.fafDevDetalle
--Exec dbo.fafUpdateDevolucion 'I',41,'20181106','D','DV-002',1, 'azepeda',32.7000, 0,0

-- select *  from dbo.fafFActura DBO.invLote Where IDProducto=3 and IDmONEDA =1 and IDCliente =1 and IDNivel =1
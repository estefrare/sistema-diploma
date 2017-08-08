
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/08/2017 00:42:12
-- Generated from EDMX file: C:\Users\Esteban\Desktop\SistemaCampo\MODELO\CATALOGO.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SistemaCampo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MODULOSUBMODULO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SUBMODULOS] DROP CONSTRAINT [FK_MODULOSUBMODULO];
GO
IF OBJECT_ID(N'[dbo].[FK_SUBMODULOFORMULARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FORMULARIOS] DROP CONSTRAINT [FK_SUBMODULOFORMULARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_FORMULARIOACCION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ACCIONES] DROP CONSTRAINT [FK_FORMULARIOACCION];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOGRUPO_USUARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIOGRUPO] DROP CONSTRAINT [FK_USUARIOGRUPO_USUARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOGRUPO_GRUPO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIOGRUPO] DROP CONSTRAINT [FK_USUARIOGRUPO_GRUPO];
GO
IF OBJECT_ID(N'[dbo].[FK_GRUPOACCION_GRUPO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GRUPOACCION] DROP CONSTRAINT [FK_GRUPOACCION_GRUPO];
GO
IF OBJECT_ID(N'[dbo].[FK_GRUPOACCION_ACCION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GRUPOACCION] DROP CONSTRAINT [FK_GRUPOACCION_ACCION];
GO
IF OBJECT_ID(N'[dbo].[FK_PLANSERVICIO_PLAN]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PLANSERVICIO] DROP CONSTRAINT [FK_PLANSERVICIO_PLAN];
GO
IF OBJECT_ID(N'[dbo].[FK_PLANSERVICIO_SERVICIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PLANSERVICIO] DROP CONSTRAINT [FK_PLANSERVICIO_SERVICIO];
GO
IF OBJECT_ID(N'[dbo].[FK_PLANAFILIADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AFILIADOS] DROP CONSTRAINT [FK_PLANAFILIADO];
GO
IF OBJECT_ID(N'[dbo].[FK_MEDICODIA_NO_LABORABLE_MEDICO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DIAS_NO_LABORABLES_MEDICOS] DROP CONSTRAINT [FK_MEDICODIA_NO_LABORABLE_MEDICO];
GO
IF OBJECT_ID(N'[dbo].[FK_MEDICOHORARIO_MEDICO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HORARIOS_MEDICOS] DROP CONSTRAINT [FK_MEDICOHORARIO_MEDICO];
GO
IF OBJECT_ID(N'[dbo].[FK_DIAS_EMPRESADATOS_EMPRESA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DIAS_EMPRESAS] DROP CONSTRAINT [FK_DIAS_EMPRESADATOS_EMPRESA];
GO
IF OBJECT_ID(N'[dbo].[FK_DIAS_NO_LABORABLESDATOS_EMPRESA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DIAS_NO_LABORABLESS] DROP CONSTRAINT [FK_DIAS_NO_LABORABLESDATOS_EMPRESA];
GO
IF OBJECT_ID(N'[dbo].[FK_MEDICOTURNO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TURNOS] DROP CONSTRAINT [FK_MEDICOTURNO];
GO
IF OBJECT_ID(N'[dbo].[FK_AFILIADOTURNO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TURNOS] DROP CONSTRAINT [FK_AFILIADOTURNO];
GO
IF OBJECT_ID(N'[dbo].[FK_AFILIADODEUDAS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DEUDAS] DROP CONSTRAINT [FK_AFILIADODEUDAS];
GO
IF OBJECT_ID(N'[dbo].[FK_AFILIADOFACTURA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FACTURAS] DROP CONSTRAINT [FK_AFILIADOFACTURA];
GO
IF OBJECT_ID(N'[dbo].[FK_FACTURADETALLE_FACTURA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DETALLES_FACTURAS] DROP CONSTRAINT [FK_FACTURADETALLE_FACTURA];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODUCTODETALLE_FACTURA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DETALLES_FACTURAS] DROP CONSTRAINT [FK_PRODUCTODETALLE_FACTURA];
GO
IF OBJECT_ID(N'[dbo].[FK_AFILIADOTARJETA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TARJETAS] DROP CONSTRAINT [FK_AFILIADOTARJETA];
GO
IF OBJECT_ID(N'[dbo].[FK_DETALLE_RECIBODEUDA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DEUDAS] DROP CONSTRAINT [FK_DETALLE_RECIBODEUDA];
GO
IF OBJECT_ID(N'[dbo].[FK_RECIBODETALLE_RECIBO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DETALLES_RECIBOS] DROP CONSTRAINT [FK_RECIBODETALLE_RECIBO];
GO
IF OBJECT_ID(N'[dbo].[FK_AFILIADORECIBO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RECIBOS] DROP CONSTRAINT [FK_AFILIADORECIBO];
GO
IF OBJECT_ID(N'[dbo].[FK_RECIBO_COMPRADETALLE_RECIBO_COMPRA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DETALLE_RECIBO_COMPRA] DROP CONSTRAINT [FK_RECIBO_COMPRADETALLE_RECIBO_COMPRA];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODUCTODETALLE_RECIBO_COMPRA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DETALLE_RECIBO_COMPRA] DROP CONSTRAINT [FK_PRODUCTODETALLE_RECIBO_COMPRA];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[USUARIOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIOS];
GO
IF OBJECT_ID(N'[dbo].[GRUPOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GRUPOS];
GO
IF OBJECT_ID(N'[dbo].[FORMULARIOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FORMULARIOS];
GO
IF OBJECT_ID(N'[dbo].[ACCIONES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ACCIONES];
GO
IF OBJECT_ID(N'[dbo].[MODULOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MODULOS];
GO
IF OBJECT_ID(N'[dbo].[SUBMODULOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SUBMODULOS];
GO
IF OBJECT_ID(N'[dbo].[PARAMETROS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PARAMETROS];
GO
IF OBJECT_ID(N'[dbo].[PLANES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PLANES];
GO
IF OBJECT_ID(N'[dbo].[SERVICIOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SERVICIOS];
GO
IF OBJECT_ID(N'[dbo].[DIAS_NO_LABORABLES_MEDICOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DIAS_NO_LABORABLES_MEDICOS];
GO
IF OBJECT_ID(N'[dbo].[HORARIOS_MEDICOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HORARIOS_MEDICOS];
GO
IF OBJECT_ID(N'[dbo].[DIAS_EMPRESAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DIAS_EMPRESAS];
GO
IF OBJECT_ID(N'[dbo].[DIAS_NO_LABORABLESS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DIAS_NO_LABORABLESS];
GO
IF OBJECT_ID(N'[dbo].[MEDICOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MEDICOS];
GO
IF OBJECT_ID(N'[dbo].[AFILIADOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AFILIADOS];
GO
IF OBJECT_ID(N'[dbo].[TURNOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TURNOS];
GO
IF OBJECT_ID(N'[dbo].[DATOS_EMPRESAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DATOS_EMPRESAS];
GO
IF OBJECT_ID(N'[dbo].[AUDITORIAs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AUDITORIAs];
GO
IF OBJECT_ID(N'[dbo].[Auditoria_Turnos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Auditoria_Turnos];
GO
IF OBJECT_ID(N'[dbo].[DEUDAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DEUDAS];
GO
IF OBJECT_ID(N'[dbo].[FACTURAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FACTURAS];
GO
IF OBJECT_ID(N'[dbo].[DETALLES_FACTURAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DETALLES_FACTURAS];
GO
IF OBJECT_ID(N'[dbo].[PRODUCTOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PRODUCTOS];
GO
IF OBJECT_ID(N'[dbo].[TARJETAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TARJETAS];
GO
IF OBJECT_ID(N'[dbo].[RECIBOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RECIBOS];
GO
IF OBJECT_ID(N'[dbo].[DETALLES_RECIBOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DETALLES_RECIBOS];
GO
IF OBJECT_ID(N'[dbo].[RECIBO_COMPRA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RECIBO_COMPRA];
GO
IF OBJECT_ID(N'[dbo].[DETALLE_RECIBO_COMPRA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DETALLE_RECIBO_COMPRA];
GO
IF OBJECT_ID(N'[dbo].[USUARIOGRUPO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIOGRUPO];
GO
IF OBJECT_ID(N'[dbo].[GRUPOACCION]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GRUPOACCION];
GO
IF OBJECT_ID(N'[dbo].[PLANSERVICIO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PLANSERVICIO];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'USUARIOS'
CREATE TABLE [dbo].[USUARIOS] (
    [CODIGO] int IDENTITY(1,1) NOT NULL,
    [NOMBRE_USUARIO] nvarchar(max)  NOT NULL,
    [NOMBRE] nvarchar(max)  NOT NULL,
    [CLAVE] nvarchar(max)  NOT NULL,
    [EMAIL] nvarchar(max)  NOT NULL,
    [TELEFONO] nvarchar(max)  NOT NULL,
    [ACTIVO] bit  NOT NULL,
    [RESETEAR_CLAVE] bit  NOT NULL,
    [IMAGEN] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'GRUPOS'
CREATE TABLE [dbo].[GRUPOS] (
    [CODIGO] int IDENTITY(1,1) NOT NULL,
    [DESCRIPCION] nvarchar(max)  NOT NULL,
    [ACTIVO] bit  NOT NULL
);
GO

-- Creating table 'FORMULARIOS'
CREATE TABLE [dbo].[FORMULARIOS] (
    [CODIGO] int IDENTITY(1,1) NOT NULL,
    [DESCRIPCION] nvarchar(max)  NOT NULL,
    [CLASE] nvarchar(max)  NOT NULL,
    [ACTIVO] bit  NOT NULL,
    [MENU] bit  NOT NULL,
    [SUBMODULO_CODIGO] int  NOT NULL
);
GO

-- Creating table 'ACCIONES'
CREATE TABLE [dbo].[ACCIONES] (
    [CODIGO] int IDENTITY(1,1) NOT NULL,
    [DESCRIPCION] nvarchar(max)  NOT NULL,
    [CONTROL] nvarchar(max)  NOT NULL,
    [FORMULARIO_CODIGO] int  NOT NULL
);
GO

-- Creating table 'MODULOS'
CREATE TABLE [dbo].[MODULOS] (
    [CODIGO] int IDENTITY(1,1) NOT NULL,
    [DESCRIPCION] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SUBMODULOS'
CREATE TABLE [dbo].[SUBMODULOS] (
    [CODIGO] int IDENTITY(1,1) NOT NULL,
    [DESCRIPCION] nvarchar(max)  NOT NULL,
    [MODULO_CODIGO] int  NOT NULL
);
GO

-- Creating table 'PARAMETROS'
CREATE TABLE [dbo].[PARAMETROS] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [DIRECTORIO_IMAGENES] nvarchar(max)  NOT NULL,
    [ENVIO_MAILS] bit  NOT NULL,
    [MAIL_CUENTA] nvarchar(max)  NOT NULL,
    [MAIL_CLAVE] nvarchar(max)  NOT NULL,
    [MAIL_NOMBRE_REMITENTE] nvarchar(max)  NOT NULL,
    [NOMBRE_EQUIPO] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PLANES'
CREATE TABLE [dbo].[PLANES] (
    [Id_Plan] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Costo] decimal(18,0)  NOT NULL,
    [Estado] bit  NOT NULL
);
GO

-- Creating table 'SERVICIOS'
CREATE TABLE [dbo].[SERVICIOS] (
    [Id_Servicio] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Fecha_Creacion] datetime  NOT NULL,
    [Estado] bit  NOT NULL
);
GO

-- Creating table 'DIAS_NO_LABORABLES_MEDICOS'
CREATE TABLE [dbo].[DIAS_NO_LABORABLES_MEDICOS] (
    [Id_Dia] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Motivo] nvarchar(max)  NOT NULL,
    [MEDICO_Id_Medico] int  NOT NULL
);
GO

-- Creating table 'HORARIOS_MEDICOS'
CREATE TABLE [dbo].[HORARIOS_MEDICOS] (
    [Id_Horario] int IDENTITY(1,1) NOT NULL,
    [Hora_Inicio] nvarchar(max)  NOT NULL,
    [Hora_Fin] nvarchar(max)  NOT NULL,
    [Dia] nvarchar(max)  NOT NULL,
    [MEDICO_Id_Medico] int  NOT NULL
);
GO

-- Creating table 'DIAS_EMPRESAS'
CREATE TABLE [dbo].[DIAS_EMPRESAS] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Dia] nvarchar(max)  NOT NULL,
    [Hora_Inicio] nvarchar(max)  NOT NULL,
    [Hora_Fin] nvarchar(max)  NOT NULL,
    [DATOS_EMPRESA_Id_Empresa] int  NOT NULL
);
GO

-- Creating table 'DIAS_NO_LABORABLESS'
CREATE TABLE [dbo].[DIAS_NO_LABORABLESS] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Motivo] nvarchar(max)  NOT NULL,
    [DATOS_EMPRESA_Id_Empresa] int  NOT NULL
);
GO

-- Creating table 'MEDICOS'
CREATE TABLE [dbo].[MEDICOS] (
    [Id_Medico] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Telefono] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Matricula] int  NOT NULL,
    [DNI] int  NOT NULL,
    [Especialidad] nvarchar(max)  NOT NULL,
    [Estado] bit  NOT NULL,
    [Tiempo_Por_Paciente] int  NOT NULL
);
GO

-- Creating table 'AFILIADOS'
CREATE TABLE [dbo].[AFILIADOS] (
    [Id_Afiliado] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Telefono] int  NOT NULL,
    [DNI] int  NOT NULL,
    [Fecha_Nacimiento] datetime  NOT NULL,
    [Sexo] nvarchar(max)  NOT NULL,
    [Numero_Contrato] int  NOT NULL,
    [Forma_Pago] nvarchar(max)  NOT NULL,
    [Estado] bit  NOT NULL,
    [PLAN_Id_Plan] int  NOT NULL
);
GO

-- Creating table 'TURNOS'
CREATE TABLE [dbo].[TURNOS] (
    [Id_Turno] int IDENTITY(1,1) NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Motivo] nvarchar(max)  NOT NULL,
    [Concurrio] bit  NOT NULL,
    [MEDICO_Id_Medico] int  NOT NULL,
    [AFILIADO_Id_Afiliado] int  NOT NULL
);
GO

-- Creating table 'DATOS_EMPRESAS'
CREATE TABLE [dbo].[DATOS_EMPRESAS] (
    [Id_Empresa] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Dueño] nvarchar(max)  NOT NULL,
    [Localidad] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AUDITORIAs'
CREATE TABLE [dbo].[AUDITORIAs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_usuario] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Accion] nvarchar(max)  NOT NULL,
    [Id_turno] int  NOT NULL
);
GO

-- Creating table 'Auditoria_Turnos'
CREATE TABLE [dbo].[Auditoria_Turnos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_Medico] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Id_Afiliado] int  NOT NULL,
    [Id_Usuario] int  NOT NULL,
    [Id_Turno] int  NOT NULL
);
GO

-- Creating table 'DEUDAS'
CREATE TABLE [dbo].[DEUDAS] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Mes] nvarchar(max)  NOT NULL,
    [Año] int  NOT NULL,
    [Monto] decimal(18,0)  NOT NULL,
    [Pagada] bit  NOT NULL,
    [AFILIADO_Id_Afiliado] int  NOT NULL,
    [DETALLE_RECIBO_Id_Detalle_Recibo] int  NULL
);
GO

-- Creating table 'FACTURAS'
CREATE TABLE [dbo].[FACTURAS] (
    [Id_Factura] int IDENTITY(1,1) NOT NULL,
    [Tipo_Factura] nvarchar(max)  NOT NULL,
    [Importe] decimal(18,0)  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Nro_Factura] int  NOT NULL,
    [IdEstadoFactura] int  NOT NULL,
    [AFILIADO_Id_Afiliado] int  NOT NULL
);
GO

-- Creating table 'DETALLES_FACTURAS'
CREATE TABLE [dbo].[DETALLES_FACTURAS] (
    [Id_Detalle_Factura] int IDENTITY(1,1) NOT NULL,
    [Codigo_Producto] int  NOT NULL,
    [Cantidad] int  NOT NULL,
    [Precio] decimal(18,0)  NOT NULL,
    [FACTURA_Id_Factura] int  NOT NULL,
    [PRODUCTO_Codigo_Producto] int  NOT NULL
);
GO

-- Creating table 'PRODUCTOS'
CREATE TABLE [dbo].[PRODUCTOS] (
    [Codigo_Producto] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Precio] decimal(18,0)  NOT NULL,
    [Stock] int  NOT NULL,
    [Stock_Minimo] int  NOT NULL
);
GO

-- Creating table 'TARJETAS'
CREATE TABLE [dbo].[TARJETAS] (
    [Id_Tarjeta] int IDENTITY(1,1) NOT NULL,
    [Titular] nvarchar(max)  NOT NULL,
    [Numero] bigint  NOT NULL,
    [Vencimiento] nvarchar(max)  NOT NULL,
    [AFILIADO_Id_Afiliado] int  NOT NULL
);
GO

-- Creating table 'RECIBOS'
CREATE TABLE [dbo].[RECIBOS] (
    [Id_Recibo] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Importe] decimal(18,0)  NOT NULL,
    [Nro_Recibo] int  NOT NULL,
    [AFILIADO_Id_Afiliado] int  NULL
);
GO

-- Creating table 'DETALLES_RECIBOS'
CREATE TABLE [dbo].[DETALLES_RECIBOS] (
    [Id_Detalle_Recibo] int IDENTITY(1,1) NOT NULL,
    [Importe] decimal(18,0)  NOT NULL,
    [RECIBO_Id_Recibo] int  NOT NULL
);
GO

-- Creating table 'RECIBO_COMPRA'
CREATE TABLE [dbo].[RECIBO_COMPRA] (
    [Id_Recibo_Compra] int IDENTITY(1,1) NOT NULL,
    [Importe] decimal(18,0)  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Nro_Recibo_Compra] int  NOT NULL,
    [Proveedor] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DETALLE_RECIBO_COMPRA'
CREATE TABLE [dbo].[DETALLE_RECIBO_COMPRA] (
    [Id_Detalle_Recibo_Compra] int IDENTITY(1,1) NOT NULL,
    [Codigo_Producto] int  NOT NULL,
    [Cantidad] int  NOT NULL,
    [Precio] decimal(18,0)  NOT NULL,
    [RECIBO_COMPRA_Id_Recibo_Compra] int  NOT NULL,
    [PRODUCTO_Codigo_Producto] int  NOT NULL
);
GO

-- Creating table 'USUARIOGRUPO'
CREATE TABLE [dbo].[USUARIOGRUPO] (
    [USUARIO_CODIGO] int  NOT NULL,
    [GRUPO_CODIGO] int  NOT NULL
);
GO

-- Creating table 'GRUPOACCION'
CREATE TABLE [dbo].[GRUPOACCION] (
    [GRUPO_CODIGO] int  NOT NULL,
    [ACCION_CODIGO] int  NOT NULL
);
GO

-- Creating table 'PLANSERVICIO'
CREATE TABLE [dbo].[PLANSERVICIO] (
    [PLAN_Id_Plan] int  NOT NULL,
    [SERVICIO_Id_Servicio] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CODIGO] in table 'USUARIOS'
ALTER TABLE [dbo].[USUARIOS]
ADD CONSTRAINT [PK_USUARIOS]
    PRIMARY KEY CLUSTERED ([CODIGO] ASC);
GO

-- Creating primary key on [CODIGO] in table 'GRUPOS'
ALTER TABLE [dbo].[GRUPOS]
ADD CONSTRAINT [PK_GRUPOS]
    PRIMARY KEY CLUSTERED ([CODIGO] ASC);
GO

-- Creating primary key on [CODIGO] in table 'FORMULARIOS'
ALTER TABLE [dbo].[FORMULARIOS]
ADD CONSTRAINT [PK_FORMULARIOS]
    PRIMARY KEY CLUSTERED ([CODIGO] ASC);
GO

-- Creating primary key on [CODIGO] in table 'ACCIONES'
ALTER TABLE [dbo].[ACCIONES]
ADD CONSTRAINT [PK_ACCIONES]
    PRIMARY KEY CLUSTERED ([CODIGO] ASC);
GO

-- Creating primary key on [CODIGO] in table 'MODULOS'
ALTER TABLE [dbo].[MODULOS]
ADD CONSTRAINT [PK_MODULOS]
    PRIMARY KEY CLUSTERED ([CODIGO] ASC);
GO

-- Creating primary key on [CODIGO] in table 'SUBMODULOS'
ALTER TABLE [dbo].[SUBMODULOS]
ADD CONSTRAINT [PK_SUBMODULOS]
    PRIMARY KEY CLUSTERED ([CODIGO] ASC);
GO

-- Creating primary key on [ID] in table 'PARAMETROS'
ALTER TABLE [dbo].[PARAMETROS]
ADD CONSTRAINT [PK_PARAMETROS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Id_Plan] in table 'PLANES'
ALTER TABLE [dbo].[PLANES]
ADD CONSTRAINT [PK_PLANES]
    PRIMARY KEY CLUSTERED ([Id_Plan] ASC);
GO

-- Creating primary key on [Id_Servicio] in table 'SERVICIOS'
ALTER TABLE [dbo].[SERVICIOS]
ADD CONSTRAINT [PK_SERVICIOS]
    PRIMARY KEY CLUSTERED ([Id_Servicio] ASC);
GO

-- Creating primary key on [Id_Dia] in table 'DIAS_NO_LABORABLES_MEDICOS'
ALTER TABLE [dbo].[DIAS_NO_LABORABLES_MEDICOS]
ADD CONSTRAINT [PK_DIAS_NO_LABORABLES_MEDICOS]
    PRIMARY KEY CLUSTERED ([Id_Dia] ASC);
GO

-- Creating primary key on [Id_Horario] in table 'HORARIOS_MEDICOS'
ALTER TABLE [dbo].[HORARIOS_MEDICOS]
ADD CONSTRAINT [PK_HORARIOS_MEDICOS]
    PRIMARY KEY CLUSTERED ([Id_Horario] ASC);
GO

-- Creating primary key on [Id] in table 'DIAS_EMPRESAS'
ALTER TABLE [dbo].[DIAS_EMPRESAS]
ADD CONSTRAINT [PK_DIAS_EMPRESAS]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DIAS_NO_LABORABLESS'
ALTER TABLE [dbo].[DIAS_NO_LABORABLESS]
ADD CONSTRAINT [PK_DIAS_NO_LABORABLESS]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id_Medico] in table 'MEDICOS'
ALTER TABLE [dbo].[MEDICOS]
ADD CONSTRAINT [PK_MEDICOS]
    PRIMARY KEY CLUSTERED ([Id_Medico] ASC);
GO

-- Creating primary key on [Id_Afiliado] in table 'AFILIADOS'
ALTER TABLE [dbo].[AFILIADOS]
ADD CONSTRAINT [PK_AFILIADOS]
    PRIMARY KEY CLUSTERED ([Id_Afiliado] ASC);
GO

-- Creating primary key on [Id_Turno] in table 'TURNOS'
ALTER TABLE [dbo].[TURNOS]
ADD CONSTRAINT [PK_TURNOS]
    PRIMARY KEY CLUSTERED ([Id_Turno] ASC);
GO

-- Creating primary key on [Id_Empresa] in table 'DATOS_EMPRESAS'
ALTER TABLE [dbo].[DATOS_EMPRESAS]
ADD CONSTRAINT [PK_DATOS_EMPRESAS]
    PRIMARY KEY CLUSTERED ([Id_Empresa] ASC);
GO

-- Creating primary key on [Id] in table 'AUDITORIAs'
ALTER TABLE [dbo].[AUDITORIAs]
ADD CONSTRAINT [PK_AUDITORIAs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Auditoria_Turnos'
ALTER TABLE [dbo].[Auditoria_Turnos]
ADD CONSTRAINT [PK_Auditoria_Turnos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DEUDAS'
ALTER TABLE [dbo].[DEUDAS]
ADD CONSTRAINT [PK_DEUDAS]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id_Factura] in table 'FACTURAS'
ALTER TABLE [dbo].[FACTURAS]
ADD CONSTRAINT [PK_FACTURAS]
    PRIMARY KEY CLUSTERED ([Id_Factura] ASC);
GO

-- Creating primary key on [Id_Detalle_Factura] in table 'DETALLES_FACTURAS'
ALTER TABLE [dbo].[DETALLES_FACTURAS]
ADD CONSTRAINT [PK_DETALLES_FACTURAS]
    PRIMARY KEY CLUSTERED ([Id_Detalle_Factura] ASC);
GO

-- Creating primary key on [Codigo_Producto] in table 'PRODUCTOS'
ALTER TABLE [dbo].[PRODUCTOS]
ADD CONSTRAINT [PK_PRODUCTOS]
    PRIMARY KEY CLUSTERED ([Codigo_Producto] ASC);
GO

-- Creating primary key on [Id_Tarjeta] in table 'TARJETAS'
ALTER TABLE [dbo].[TARJETAS]
ADD CONSTRAINT [PK_TARJETAS]
    PRIMARY KEY CLUSTERED ([Id_Tarjeta] ASC);
GO

-- Creating primary key on [Id_Recibo] in table 'RECIBOS'
ALTER TABLE [dbo].[RECIBOS]
ADD CONSTRAINT [PK_RECIBOS]
    PRIMARY KEY CLUSTERED ([Id_Recibo] ASC);
GO

-- Creating primary key on [Id_Detalle_Recibo] in table 'DETALLES_RECIBOS'
ALTER TABLE [dbo].[DETALLES_RECIBOS]
ADD CONSTRAINT [PK_DETALLES_RECIBOS]
    PRIMARY KEY CLUSTERED ([Id_Detalle_Recibo] ASC);
GO

-- Creating primary key on [Id_Recibo_Compra] in table 'RECIBO_COMPRA'
ALTER TABLE [dbo].[RECIBO_COMPRA]
ADD CONSTRAINT [PK_RECIBO_COMPRA]
    PRIMARY KEY CLUSTERED ([Id_Recibo_Compra] ASC);
GO

-- Creating primary key on [Id_Detalle_Recibo_Compra] in table 'DETALLE_RECIBO_COMPRA'
ALTER TABLE [dbo].[DETALLE_RECIBO_COMPRA]
ADD CONSTRAINT [PK_DETALLE_RECIBO_COMPRA]
    PRIMARY KEY CLUSTERED ([Id_Detalle_Recibo_Compra] ASC);
GO

-- Creating primary key on [USUARIO_CODIGO], [GRUPO_CODIGO] in table 'USUARIOGRUPO'
ALTER TABLE [dbo].[USUARIOGRUPO]
ADD CONSTRAINT [PK_USUARIOGRUPO]
    PRIMARY KEY CLUSTERED ([USUARIO_CODIGO], [GRUPO_CODIGO] ASC);
GO

-- Creating primary key on [GRUPO_CODIGO], [ACCION_CODIGO] in table 'GRUPOACCION'
ALTER TABLE [dbo].[GRUPOACCION]
ADD CONSTRAINT [PK_GRUPOACCION]
    PRIMARY KEY CLUSTERED ([GRUPO_CODIGO], [ACCION_CODIGO] ASC);
GO

-- Creating primary key on [PLAN_Id_Plan], [SERVICIO_Id_Servicio] in table 'PLANSERVICIO'
ALTER TABLE [dbo].[PLANSERVICIO]
ADD CONSTRAINT [PK_PLANSERVICIO]
    PRIMARY KEY CLUSTERED ([PLAN_Id_Plan], [SERVICIO_Id_Servicio] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MODULO_CODIGO] in table 'SUBMODULOS'
ALTER TABLE [dbo].[SUBMODULOS]
ADD CONSTRAINT [FK_MODULOSUBMODULO]
    FOREIGN KEY ([MODULO_CODIGO])
    REFERENCES [dbo].[MODULOS]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MODULOSUBMODULO'
CREATE INDEX [IX_FK_MODULOSUBMODULO]
ON [dbo].[SUBMODULOS]
    ([MODULO_CODIGO]);
GO

-- Creating foreign key on [SUBMODULO_CODIGO] in table 'FORMULARIOS'
ALTER TABLE [dbo].[FORMULARIOS]
ADD CONSTRAINT [FK_SUBMODULOFORMULARIO]
    FOREIGN KEY ([SUBMODULO_CODIGO])
    REFERENCES [dbo].[SUBMODULOS]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SUBMODULOFORMULARIO'
CREATE INDEX [IX_FK_SUBMODULOFORMULARIO]
ON [dbo].[FORMULARIOS]
    ([SUBMODULO_CODIGO]);
GO

-- Creating foreign key on [FORMULARIO_CODIGO] in table 'ACCIONES'
ALTER TABLE [dbo].[ACCIONES]
ADD CONSTRAINT [FK_FORMULARIOACCION]
    FOREIGN KEY ([FORMULARIO_CODIGO])
    REFERENCES [dbo].[FORMULARIOS]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FORMULARIOACCION'
CREATE INDEX [IX_FK_FORMULARIOACCION]
ON [dbo].[ACCIONES]
    ([FORMULARIO_CODIGO]);
GO

-- Creating foreign key on [USUARIO_CODIGO] in table 'USUARIOGRUPO'
ALTER TABLE [dbo].[USUARIOGRUPO]
ADD CONSTRAINT [FK_USUARIOGRUPO_USUARIO]
    FOREIGN KEY ([USUARIO_CODIGO])
    REFERENCES [dbo].[USUARIOS]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [GRUPO_CODIGO] in table 'USUARIOGRUPO'
ALTER TABLE [dbo].[USUARIOGRUPO]
ADD CONSTRAINT [FK_USUARIOGRUPO_GRUPO]
    FOREIGN KEY ([GRUPO_CODIGO])
    REFERENCES [dbo].[GRUPOS]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USUARIOGRUPO_GRUPO'
CREATE INDEX [IX_FK_USUARIOGRUPO_GRUPO]
ON [dbo].[USUARIOGRUPO]
    ([GRUPO_CODIGO]);
GO

-- Creating foreign key on [GRUPO_CODIGO] in table 'GRUPOACCION'
ALTER TABLE [dbo].[GRUPOACCION]
ADD CONSTRAINT [FK_GRUPOACCION_GRUPO]
    FOREIGN KEY ([GRUPO_CODIGO])
    REFERENCES [dbo].[GRUPOS]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ACCION_CODIGO] in table 'GRUPOACCION'
ALTER TABLE [dbo].[GRUPOACCION]
ADD CONSTRAINT [FK_GRUPOACCION_ACCION]
    FOREIGN KEY ([ACCION_CODIGO])
    REFERENCES [dbo].[ACCIONES]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GRUPOACCION_ACCION'
CREATE INDEX [IX_FK_GRUPOACCION_ACCION]
ON [dbo].[GRUPOACCION]
    ([ACCION_CODIGO]);
GO

-- Creating foreign key on [PLAN_Id_Plan] in table 'PLANSERVICIO'
ALTER TABLE [dbo].[PLANSERVICIO]
ADD CONSTRAINT [FK_PLANSERVICIO_PLAN]
    FOREIGN KEY ([PLAN_Id_Plan])
    REFERENCES [dbo].[PLANES]
        ([Id_Plan])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SERVICIO_Id_Servicio] in table 'PLANSERVICIO'
ALTER TABLE [dbo].[PLANSERVICIO]
ADD CONSTRAINT [FK_PLANSERVICIO_SERVICIO]
    FOREIGN KEY ([SERVICIO_Id_Servicio])
    REFERENCES [dbo].[SERVICIOS]
        ([Id_Servicio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PLANSERVICIO_SERVICIO'
CREATE INDEX [IX_FK_PLANSERVICIO_SERVICIO]
ON [dbo].[PLANSERVICIO]
    ([SERVICIO_Id_Servicio]);
GO

-- Creating foreign key on [PLAN_Id_Plan] in table 'AFILIADOS'
ALTER TABLE [dbo].[AFILIADOS]
ADD CONSTRAINT [FK_PLANAFILIADO]
    FOREIGN KEY ([PLAN_Id_Plan])
    REFERENCES [dbo].[PLANES]
        ([Id_Plan])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PLANAFILIADO'
CREATE INDEX [IX_FK_PLANAFILIADO]
ON [dbo].[AFILIADOS]
    ([PLAN_Id_Plan]);
GO

-- Creating foreign key on [MEDICO_Id_Medico] in table 'DIAS_NO_LABORABLES_MEDICOS'
ALTER TABLE [dbo].[DIAS_NO_LABORABLES_MEDICOS]
ADD CONSTRAINT [FK_MEDICODIA_NO_LABORABLE_MEDICO]
    FOREIGN KEY ([MEDICO_Id_Medico])
    REFERENCES [dbo].[MEDICOS]
        ([Id_Medico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MEDICODIA_NO_LABORABLE_MEDICO'
CREATE INDEX [IX_FK_MEDICODIA_NO_LABORABLE_MEDICO]
ON [dbo].[DIAS_NO_LABORABLES_MEDICOS]
    ([MEDICO_Id_Medico]);
GO

-- Creating foreign key on [MEDICO_Id_Medico] in table 'HORARIOS_MEDICOS'
ALTER TABLE [dbo].[HORARIOS_MEDICOS]
ADD CONSTRAINT [FK_MEDICOHORARIO_MEDICO]
    FOREIGN KEY ([MEDICO_Id_Medico])
    REFERENCES [dbo].[MEDICOS]
        ([Id_Medico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MEDICOHORARIO_MEDICO'
CREATE INDEX [IX_FK_MEDICOHORARIO_MEDICO]
ON [dbo].[HORARIOS_MEDICOS]
    ([MEDICO_Id_Medico]);
GO

-- Creating foreign key on [DATOS_EMPRESA_Id_Empresa] in table 'DIAS_EMPRESAS'
ALTER TABLE [dbo].[DIAS_EMPRESAS]
ADD CONSTRAINT [FK_DIAS_EMPRESADATOS_EMPRESA]
    FOREIGN KEY ([DATOS_EMPRESA_Id_Empresa])
    REFERENCES [dbo].[DATOS_EMPRESAS]
        ([Id_Empresa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DIAS_EMPRESADATOS_EMPRESA'
CREATE INDEX [IX_FK_DIAS_EMPRESADATOS_EMPRESA]
ON [dbo].[DIAS_EMPRESAS]
    ([DATOS_EMPRESA_Id_Empresa]);
GO

-- Creating foreign key on [DATOS_EMPRESA_Id_Empresa] in table 'DIAS_NO_LABORABLESS'
ALTER TABLE [dbo].[DIAS_NO_LABORABLESS]
ADD CONSTRAINT [FK_DIAS_NO_LABORABLESDATOS_EMPRESA]
    FOREIGN KEY ([DATOS_EMPRESA_Id_Empresa])
    REFERENCES [dbo].[DATOS_EMPRESAS]
        ([Id_Empresa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DIAS_NO_LABORABLESDATOS_EMPRESA'
CREATE INDEX [IX_FK_DIAS_NO_LABORABLESDATOS_EMPRESA]
ON [dbo].[DIAS_NO_LABORABLESS]
    ([DATOS_EMPRESA_Id_Empresa]);
GO

-- Creating foreign key on [MEDICO_Id_Medico] in table 'TURNOS'
ALTER TABLE [dbo].[TURNOS]
ADD CONSTRAINT [FK_MEDICOTURNO]
    FOREIGN KEY ([MEDICO_Id_Medico])
    REFERENCES [dbo].[MEDICOS]
        ([Id_Medico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MEDICOTURNO'
CREATE INDEX [IX_FK_MEDICOTURNO]
ON [dbo].[TURNOS]
    ([MEDICO_Id_Medico]);
GO

-- Creating foreign key on [AFILIADO_Id_Afiliado] in table 'TURNOS'
ALTER TABLE [dbo].[TURNOS]
ADD CONSTRAINT [FK_AFILIADOTURNO]
    FOREIGN KEY ([AFILIADO_Id_Afiliado])
    REFERENCES [dbo].[AFILIADOS]
        ([Id_Afiliado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AFILIADOTURNO'
CREATE INDEX [IX_FK_AFILIADOTURNO]
ON [dbo].[TURNOS]
    ([AFILIADO_Id_Afiliado]);
GO

-- Creating foreign key on [AFILIADO_Id_Afiliado] in table 'DEUDAS'
ALTER TABLE [dbo].[DEUDAS]
ADD CONSTRAINT [FK_AFILIADODEUDAS]
    FOREIGN KEY ([AFILIADO_Id_Afiliado])
    REFERENCES [dbo].[AFILIADOS]
        ([Id_Afiliado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AFILIADODEUDAS'
CREATE INDEX [IX_FK_AFILIADODEUDAS]
ON [dbo].[DEUDAS]
    ([AFILIADO_Id_Afiliado]);
GO

-- Creating foreign key on [AFILIADO_Id_Afiliado] in table 'FACTURAS'
ALTER TABLE [dbo].[FACTURAS]
ADD CONSTRAINT [FK_AFILIADOFACTURA]
    FOREIGN KEY ([AFILIADO_Id_Afiliado])
    REFERENCES [dbo].[AFILIADOS]
        ([Id_Afiliado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AFILIADOFACTURA'
CREATE INDEX [IX_FK_AFILIADOFACTURA]
ON [dbo].[FACTURAS]
    ([AFILIADO_Id_Afiliado]);
GO

-- Creating foreign key on [FACTURA_Id_Factura] in table 'DETALLES_FACTURAS'
ALTER TABLE [dbo].[DETALLES_FACTURAS]
ADD CONSTRAINT [FK_FACTURADETALLE_FACTURA]
    FOREIGN KEY ([FACTURA_Id_Factura])
    REFERENCES [dbo].[FACTURAS]
        ([Id_Factura])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FACTURADETALLE_FACTURA'
CREATE INDEX [IX_FK_FACTURADETALLE_FACTURA]
ON [dbo].[DETALLES_FACTURAS]
    ([FACTURA_Id_Factura]);
GO

-- Creating foreign key on [PRODUCTO_Codigo_Producto] in table 'DETALLES_FACTURAS'
ALTER TABLE [dbo].[DETALLES_FACTURAS]
ADD CONSTRAINT [FK_PRODUCTODETALLE_FACTURA]
    FOREIGN KEY ([PRODUCTO_Codigo_Producto])
    REFERENCES [dbo].[PRODUCTOS]
        ([Codigo_Producto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRODUCTODETALLE_FACTURA'
CREATE INDEX [IX_FK_PRODUCTODETALLE_FACTURA]
ON [dbo].[DETALLES_FACTURAS]
    ([PRODUCTO_Codigo_Producto]);
GO

-- Creating foreign key on [AFILIADO_Id_Afiliado] in table 'TARJETAS'
ALTER TABLE [dbo].[TARJETAS]
ADD CONSTRAINT [FK_AFILIADOTARJETA]
    FOREIGN KEY ([AFILIADO_Id_Afiliado])
    REFERENCES [dbo].[AFILIADOS]
        ([Id_Afiliado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AFILIADOTARJETA'
CREATE INDEX [IX_FK_AFILIADOTARJETA]
ON [dbo].[TARJETAS]
    ([AFILIADO_Id_Afiliado]);
GO

-- Creating foreign key on [DETALLE_RECIBO_Id_Detalle_Recibo] in table 'DEUDAS'
ALTER TABLE [dbo].[DEUDAS]
ADD CONSTRAINT [FK_DETALLE_RECIBODEUDA]
    FOREIGN KEY ([DETALLE_RECIBO_Id_Detalle_Recibo])
    REFERENCES [dbo].[DETALLES_RECIBOS]
        ([Id_Detalle_Recibo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DETALLE_RECIBODEUDA'
CREATE INDEX [IX_FK_DETALLE_RECIBODEUDA]
ON [dbo].[DEUDAS]
    ([DETALLE_RECIBO_Id_Detalle_Recibo]);
GO

-- Creating foreign key on [RECIBO_Id_Recibo] in table 'DETALLES_RECIBOS'
ALTER TABLE [dbo].[DETALLES_RECIBOS]
ADD CONSTRAINT [FK_RECIBODETALLE_RECIBO]
    FOREIGN KEY ([RECIBO_Id_Recibo])
    REFERENCES [dbo].[RECIBOS]
        ([Id_Recibo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RECIBODETALLE_RECIBO'
CREATE INDEX [IX_FK_RECIBODETALLE_RECIBO]
ON [dbo].[DETALLES_RECIBOS]
    ([RECIBO_Id_Recibo]);
GO

-- Creating foreign key on [AFILIADO_Id_Afiliado] in table 'RECIBOS'
ALTER TABLE [dbo].[RECIBOS]
ADD CONSTRAINT [FK_AFILIADORECIBO]
    FOREIGN KEY ([AFILIADO_Id_Afiliado])
    REFERENCES [dbo].[AFILIADOS]
        ([Id_Afiliado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AFILIADORECIBO'
CREATE INDEX [IX_FK_AFILIADORECIBO]
ON [dbo].[RECIBOS]
    ([AFILIADO_Id_Afiliado]);
GO

-- Creating foreign key on [RECIBO_COMPRA_Id_Recibo_Compra] in table 'DETALLE_RECIBO_COMPRA'
ALTER TABLE [dbo].[DETALLE_RECIBO_COMPRA]
ADD CONSTRAINT [FK_RECIBO_COMPRADETALLE_RECIBO_COMPRA]
    FOREIGN KEY ([RECIBO_COMPRA_Id_Recibo_Compra])
    REFERENCES [dbo].[RECIBO_COMPRA]
        ([Id_Recibo_Compra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RECIBO_COMPRADETALLE_RECIBO_COMPRA'
CREATE INDEX [IX_FK_RECIBO_COMPRADETALLE_RECIBO_COMPRA]
ON [dbo].[DETALLE_RECIBO_COMPRA]
    ([RECIBO_COMPRA_Id_Recibo_Compra]);
GO

-- Creating foreign key on [PRODUCTO_Codigo_Producto] in table 'DETALLE_RECIBO_COMPRA'
ALTER TABLE [dbo].[DETALLE_RECIBO_COMPRA]
ADD CONSTRAINT [FK_PRODUCTODETALLE_RECIBO_COMPRA]
    FOREIGN KEY ([PRODUCTO_Codigo_Producto])
    REFERENCES [dbo].[PRODUCTOS]
        ([Codigo_Producto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRODUCTODETALLE_RECIBO_COMPRA'
CREATE INDEX [IX_FK_PRODUCTODETALLE_RECIBO_COMPRA]
ON [dbo].[DETALLE_RECIBO_COMPRA]
    ([PRODUCTO_Codigo_Producto]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
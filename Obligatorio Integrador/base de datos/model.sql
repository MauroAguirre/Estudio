CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId]    NVARCHAR (150)  NOT NULL,
    [ContextKey]     NVARCHAR (300)  NOT NULL,
    [Model]          VARBINARY (MAX) NOT NULL,
    [ProductVersion] NVARCHAR (32)   NOT NULL
);

GO
CREATE TABLE [dbo].[Articuloes] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [descripcion] NVARCHAR (MAX) NULL,
    [iva]         INT            NOT NULL,
    [miniStock]   INT            NOT NULL,
    [precioVenta] INT            NOT NULL,
    [activo]      BIT            NOT NULL
);

GO
CREATE TABLE [dbo].[ArticuloProveedors] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [costo]         INT            NOT NULL,
    [fecha]         DATETIME       NOT NULL,
    [articulo_id]   INT            NULL,
    [proveedor_rut] NVARCHAR (128) NULL
);

GO
CREATE TABLE [dbo].[Comunicacions] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [fecha]       DATETIME       NOT NULL,
    [comentario]  NVARCHAR (MAX) NULL,
    [tipo]        NVARCHAR (MAX) NULL,
    [contacto_id] INT            NULL
);

GO
CREATE TABLE [dbo].[Contactoes] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [nombre]        NVARCHAR (MAX) NULL,
    [telefono]      INT            NOT NULL,
    [proveedor_rut] NVARCHAR (128) NULL
);

GO
CREATE TABLE [dbo].[facturaCompras] (
    [id]            INT            NOT NULL,
    [proveedor_rut] NVARCHAR (128) NULL
);

GO
CREATE TABLE [dbo].[Facturas] (
    [id]    INT      IDENTITY (1, 1) NOT NULL,
    [fecha] DATETIME NOT NULL
);

GO
CREATE TABLE [dbo].[facturaVentas] (
    [id]          INT            NOT NULL,
    [descripcion] NVARCHAR (MAX) NULL
);

GO
CREATE TABLE [dbo].[LineaFacturas] (
    [id]          INT IDENTITY (1, 1) NOT NULL,
    [cantidad]    INT NOT NULL,
    [precio]      INT NOT NULL,
    [articulo_id] INT NULL,
    [factura_id]  INT NULL
);

GO
CREATE TABLE [dbo].[Proveedors] (
    [rut]         NVARCHAR (128) NOT NULL,
    [nombre]      NVARCHAR (MAX) NULL,
    [descripcion] NVARCHAR (MAX) NULL,
    [activo]      BIT            NOT NULL
);

GO
CREATE TABLE [dbo].[Registroes] (
    [id]          INT      IDENTITY (1, 1) NOT NULL,
    [fecha]       DATETIME NOT NULL,
    [cambio]      INT      NOT NULL,
    [articulo_id] INT      NULL
);

GO
CREATE TABLE [dbo].[Usuarios] (
    [mail]   NVARCHAR (128) NOT NULL,
    [contra] NVARCHAR (MAX) NULL
);

GO
ALTER TABLE [dbo].[ArticuloProveedors]
    ADD CONSTRAINT [FK_dbo.ArticuloProveedors_dbo.Articuloes_articulo_id] FOREIGN KEY ([articulo_id]) REFERENCES [dbo].[Articuloes] ([id]);

GO
ALTER TABLE [dbo].[ArticuloProveedors]
    ADD CONSTRAINT [FK_dbo.ArticuloProveedors_dbo.Proveedors_proveedor_rut] FOREIGN KEY ([proveedor_rut]) REFERENCES [dbo].[Proveedors] ([rut]);

GO
ALTER TABLE [dbo].[Comunicacions]
    ADD CONSTRAINT [FK_dbo.Comunicacions_dbo.Contactoes_contacto_id] FOREIGN KEY ([contacto_id]) REFERENCES [dbo].[Contactoes] ([id]);

GO
ALTER TABLE [dbo].[Contactoes]
    ADD CONSTRAINT [FK_dbo.Contactoes_dbo.Proveedors_proveedor_rut] FOREIGN KEY ([proveedor_rut]) REFERENCES [dbo].[Proveedors] ([rut]);

GO
ALTER TABLE [dbo].[facturaCompras]
    ADD CONSTRAINT [FK_dbo.facturaCompras_dbo.Facturas_id] FOREIGN KEY ([id]) REFERENCES [dbo].[Facturas] ([id]);

GO
ALTER TABLE [dbo].[facturaCompras]
    ADD CONSTRAINT [FK_dbo.facturaCompras_dbo.Proveedors_proveedor_rut] FOREIGN KEY ([proveedor_rut]) REFERENCES [dbo].[Proveedors] ([rut]);

GO
ALTER TABLE [dbo].[facturaVentas]
    ADD CONSTRAINT [FK_dbo.facturaVentas_dbo.Facturas_id] FOREIGN KEY ([id]) REFERENCES [dbo].[Facturas] ([id]);

GO
ALTER TABLE [dbo].[LineaFacturas]
    ADD CONSTRAINT [FK_dbo.LineaFacturas_dbo.Articuloes_articulo_id] FOREIGN KEY ([articulo_id]) REFERENCES [dbo].[Articuloes] ([id]);

GO
ALTER TABLE [dbo].[LineaFacturas]
    ADD CONSTRAINT [FK_dbo.LineaFacturas_dbo.Facturas_factura_id] FOREIGN KEY ([factura_id]) REFERENCES [dbo].[Facturas] ([id]);

GO
ALTER TABLE [dbo].[Registroes]
    ADD CONSTRAINT [FK_dbo.Registroes_dbo.Articuloes_articulo_id] FOREIGN KEY ([articulo_id]) REFERENCES [dbo].[Articuloes] ([id]);

GO
ALTER TABLE [dbo].[__MigrationHistory]
    ADD CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED ([MigrationId] ASC, [ContextKey] ASC);

GO
ALTER TABLE [dbo].[Articuloes]
    ADD CONSTRAINT [PK_dbo.Articuloes] PRIMARY KEY CLUSTERED ([id] ASC);

GO
ALTER TABLE [dbo].[ArticuloProveedors]
    ADD CONSTRAINT [PK_dbo.ArticuloProveedors] PRIMARY KEY CLUSTERED ([id] ASC);

GO
ALTER TABLE [dbo].[Comunicacions]
    ADD CONSTRAINT [PK_dbo.Comunicacions] PRIMARY KEY CLUSTERED ([id] ASC);

GO
ALTER TABLE [dbo].[Contactoes]
    ADD CONSTRAINT [PK_dbo.Contactoes] PRIMARY KEY CLUSTERED ([id] ASC);

GO
ALTER TABLE [dbo].[facturaCompras]
    ADD CONSTRAINT [PK_dbo.facturaCompras] PRIMARY KEY CLUSTERED ([id] ASC);

GO
ALTER TABLE [dbo].[Facturas]
    ADD CONSTRAINT [PK_dbo.Facturas] PRIMARY KEY CLUSTERED ([id] ASC);

GO
ALTER TABLE [dbo].[facturaVentas]
    ADD CONSTRAINT [PK_dbo.facturaVentas] PRIMARY KEY CLUSTERED ([id] ASC);

GO
ALTER TABLE [dbo].[LineaFacturas]
    ADD CONSTRAINT [PK_dbo.LineaFacturas] PRIMARY KEY CLUSTERED ([id] ASC);

GO
ALTER TABLE [dbo].[Proveedors]
    ADD CONSTRAINT [PK_dbo.Proveedors] PRIMARY KEY CLUSTERED ([rut] ASC);

GO
ALTER TABLE [dbo].[Registroes]
    ADD CONSTRAINT [PK_dbo.Registroes] PRIMARY KEY CLUSTERED ([id] ASC);

GO
ALTER TABLE [dbo].[Usuarios]
    ADD CONSTRAINT [PK_dbo.Usuarios] PRIMARY KEY CLUSTERED ([mail] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_articulo_id]
    ON [dbo].[ArticuloProveedors]([articulo_id] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_proveedor_rut]
    ON [dbo].[ArticuloProveedors]([proveedor_rut] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_contacto_id]
    ON [dbo].[Comunicacions]([contacto_id] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_proveedor_rut]
    ON [dbo].[Contactoes]([proveedor_rut] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_id]
    ON [dbo].[facturaCompras]([id] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_proveedor_rut]
    ON [dbo].[facturaCompras]([proveedor_rut] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_id]
    ON [dbo].[facturaVentas]([id] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_articulo_id]
    ON [dbo].[LineaFacturas]([articulo_id] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_factura_id]
    ON [dbo].[LineaFacturas]([factura_id] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_articulo_id]
    ON [dbo].[Registroes]([articulo_id] ASC);

GO

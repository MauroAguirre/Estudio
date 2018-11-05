namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticuloProveedors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        costo = c.Int(nullable: false),
                        fecha = c.DateTime(nullable: false),
                        articulo_id = c.Int(),
                        proveedor_rut = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Articuloes", t => t.articulo_id)
                .ForeignKey("dbo.Proveedors", t => t.proveedor_rut)
                .Index(t => t.articulo_id)
                .Index(t => t.proveedor_rut);
            
            CreateTable(
                "dbo.Articuloes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                        iva = c.Int(nullable: false),
                        miniStock = c.Int(nullable: false),
                        precioVenta = c.Int(nullable: false),
                        activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        rut = c.String(nullable: false, maxLength: 128),
                        nombre = c.String(),
                        descripcion = c.String(),
                        activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.rut);
            
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        nombre = c.String(nullable: false, maxLength: 128),
                        telefono = c.Int(nullable: false),
                        proveedor_rut = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.nombre)
                .ForeignKey("dbo.Proveedors", t => t.proveedor_rut)
                .Index(t => t.proveedor_rut);
            
            CreateTable(
                "dbo.Comunicacions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        comentario = c.String(),
                        contacto_nombre = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Contactoes", t => t.contacto_nombre)
                .Index(t => t.contacto_nombre);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.LineaFacturas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cantidad = c.Int(nullable: false),
                        articuloProveedor_id = c.Int(),
                        factura_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ArticuloProveedors", t => t.articuloProveedor_id)
                .ForeignKey("dbo.Facturas", t => t.factura_id)
                .Index(t => t.articuloProveedor_id)
                .Index(t => t.factura_id);
            
            CreateTable(
                "dbo.Registroes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        cambio = c.Int(nullable: false),
                        articulo_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Articuloes", t => t.articulo_id)
                .Index(t => t.articulo_id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        mail = c.String(nullable: false, maxLength: 128),
                        contra = c.String(),
                    })
                .PrimaryKey(t => t.mail);
            
            CreateTable(
                "dbo.facturaCompras",
                c => new
                    {
                        id = c.Int(nullable: false),
                        proveedor_rut = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Facturas", t => t.id)
                .ForeignKey("dbo.Proveedors", t => t.proveedor_rut)
                .Index(t => t.id)
                .Index(t => t.proveedor_rut);
            
            CreateTable(
                "dbo.facturaVentas",
                c => new
                    {
                        id = c.Int(nullable: false),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Facturas", t => t.id)
                .Index(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.facturaVentas", "id", "dbo.Facturas");
            DropForeignKey("dbo.facturaCompras", "proveedor_rut", "dbo.Proveedors");
            DropForeignKey("dbo.facturaCompras", "id", "dbo.Facturas");
            DropForeignKey("dbo.Registroes", "articulo_id", "dbo.Articuloes");
            DropForeignKey("dbo.LineaFacturas", "factura_id", "dbo.Facturas");
            DropForeignKey("dbo.LineaFacturas", "articuloProveedor_id", "dbo.ArticuloProveedors");
            DropForeignKey("dbo.Comunicacions", "contacto_nombre", "dbo.Contactoes");
            DropForeignKey("dbo.ArticuloProveedors", "proveedor_rut", "dbo.Proveedors");
            DropForeignKey("dbo.Contactoes", "proveedor_rut", "dbo.Proveedors");
            DropForeignKey("dbo.ArticuloProveedors", "articulo_id", "dbo.Articuloes");
            DropIndex("dbo.facturaVentas", new[] { "id" });
            DropIndex("dbo.facturaCompras", new[] { "proveedor_rut" });
            DropIndex("dbo.facturaCompras", new[] { "id" });
            DropIndex("dbo.Registroes", new[] { "articulo_id" });
            DropIndex("dbo.LineaFacturas", new[] { "factura_id" });
            DropIndex("dbo.LineaFacturas", new[] { "articuloProveedor_id" });
            DropIndex("dbo.Comunicacions", new[] { "contacto_nombre" });
            DropIndex("dbo.Contactoes", new[] { "proveedor_rut" });
            DropIndex("dbo.ArticuloProveedors", new[] { "proveedor_rut" });
            DropIndex("dbo.ArticuloProveedors", new[] { "articulo_id" });
            DropTable("dbo.facturaVentas");
            DropTable("dbo.facturaCompras");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Registroes");
            DropTable("dbo.LineaFacturas");
            DropTable("dbo.Facturas");
            DropTable("dbo.Comunicacions");
            DropTable("dbo.Contactoes");
            DropTable("dbo.Proveedors");
            DropTable("dbo.Articuloes");
            DropTable("dbo.ArticuloProveedors");
        }
    }
}

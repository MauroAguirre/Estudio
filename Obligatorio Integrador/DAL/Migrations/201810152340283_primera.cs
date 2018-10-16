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
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        rut = c.String(nullable: false, maxLength: 128),
                        nombre = c.String(),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.rut);
            
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        nombre = c.String(nullable: false, maxLength: 128),
                        telefono = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.nombre);
            
            CreateTable(
                "dbo.Comunicacions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        comentario = c.String(),
                        contacto_nombre = c.String(maxLength: 128),
                        proveedor_rut = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Contactoes", t => t.contacto_nombre)
                .ForeignKey("dbo.Proveedors", t => t.proveedor_rut)
                .Index(t => t.contacto_nombre)
                .Index(t => t.proveedor_rut);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.LineaFacturas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cantidad = c.Int(nullable: false),
                        articuloProveedor_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ArticuloProveedors", t => t.articuloProveedor_id)
                .Index(t => t.articuloProveedor_id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        mail = c.String(nullable: false, maxLength: 128),
                        contra = c.String(),
                    })
                .PrimaryKey(t => t.mail);
            
            CreateTable(
                "dbo.ContactoProveedors",
                c => new
                    {
                        Contacto_nombre = c.String(nullable: false, maxLength: 128),
                        Proveedor_rut = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Contacto_nombre, t.Proveedor_rut })
                .ForeignKey("dbo.Contactoes", t => t.Contacto_nombre, cascadeDelete: true)
                .ForeignKey("dbo.Proveedors", t => t.Proveedor_rut, cascadeDelete: true)
                .Index(t => t.Contacto_nombre)
                .Index(t => t.Proveedor_rut);
            
            CreateTable(
                "dbo.FacturaLineaFacturas",
                c => new
                    {
                        Factura_id = c.Int(nullable: false),
                        LineaFactura_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Factura_id, t.LineaFactura_id })
                .ForeignKey("dbo.Facturas", t => t.Factura_id, cascadeDelete: true)
                .ForeignKey("dbo.LineaFacturas", t => t.LineaFactura_id, cascadeDelete: true)
                .Index(t => t.Factura_id)
                .Index(t => t.LineaFactura_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FacturaLineaFacturas", "LineaFactura_id", "dbo.LineaFacturas");
            DropForeignKey("dbo.FacturaLineaFacturas", "Factura_id", "dbo.Facturas");
            DropForeignKey("dbo.LineaFacturas", "articuloProveedor_id", "dbo.ArticuloProveedors");
            DropForeignKey("dbo.Comunicacions", "proveedor_rut", "dbo.Proveedors");
            DropForeignKey("dbo.Comunicacions", "contacto_nombre", "dbo.Contactoes");
            DropForeignKey("dbo.ArticuloProveedors", "proveedor_rut", "dbo.Proveedors");
            DropForeignKey("dbo.ContactoProveedors", "Proveedor_rut", "dbo.Proveedors");
            DropForeignKey("dbo.ContactoProveedors", "Contacto_nombre", "dbo.Contactoes");
            DropForeignKey("dbo.ArticuloProveedors", "articulo_id", "dbo.Articuloes");
            DropIndex("dbo.FacturaLineaFacturas", new[] { "LineaFactura_id" });
            DropIndex("dbo.FacturaLineaFacturas", new[] { "Factura_id" });
            DropIndex("dbo.ContactoProveedors", new[] { "Proveedor_rut" });
            DropIndex("dbo.ContactoProveedors", new[] { "Contacto_nombre" });
            DropIndex("dbo.LineaFacturas", new[] { "articuloProveedor_id" });
            DropIndex("dbo.Comunicacions", new[] { "proveedor_rut" });
            DropIndex("dbo.Comunicacions", new[] { "contacto_nombre" });
            DropIndex("dbo.ArticuloProveedors", new[] { "proveedor_rut" });
            DropIndex("dbo.ArticuloProveedors", new[] { "articulo_id" });
            DropTable("dbo.FacturaLineaFacturas");
            DropTable("dbo.ContactoProveedors");
            DropTable("dbo.Usuarios");
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

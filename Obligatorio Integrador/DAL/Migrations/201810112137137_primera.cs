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
                        FacturaCompra_id = c.Int(),
                        FacturaVenta_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Articuloes", t => t.articulo_id)
                .ForeignKey("dbo.Proveedors", t => t.proveedor_rut)
                .ForeignKey("dbo.FacturaCompras", t => t.FacturaCompra_id)
                .ForeignKey("dbo.FacturaVentas", t => t.FacturaVenta_id)
                .Index(t => t.articulo_id)
                .Index(t => t.proveedor_rut)
                .Index(t => t.FacturaCompra_id)
                .Index(t => t.FacturaVenta_id);
            
            CreateTable(
                "dbo.Articuloes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                        iva = c.Boolean(nullable: false),
                        miniStock = c.Int(nullable: false),
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
                        Proveedor_rut = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.nombre)
                .ForeignKey("dbo.Proveedors", t => t.Proveedor_rut)
                .Index(t => t.Proveedor_rut);
            
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
                "dbo.FacturaCompras",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.FacturaVentas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        mail = c.String(nullable: false, maxLength: 128),
                        contra = c.String(),
                    })
                .PrimaryKey(t => t.mail);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArticuloProveedors", "FacturaVenta_id", "dbo.FacturaVentas");
            DropForeignKey("dbo.ArticuloProveedors", "FacturaCompra_id", "dbo.FacturaCompras");
            DropForeignKey("dbo.Comunicacions", "proveedor_rut", "dbo.Proveedors");
            DropForeignKey("dbo.Comunicacions", "contacto_nombre", "dbo.Contactoes");
            DropForeignKey("dbo.ArticuloProveedors", "proveedor_rut", "dbo.Proveedors");
            DropForeignKey("dbo.Contactoes", "Proveedor_rut", "dbo.Proveedors");
            DropForeignKey("dbo.ArticuloProveedors", "articulo_id", "dbo.Articuloes");
            DropIndex("dbo.Comunicacions", new[] { "proveedor_rut" });
            DropIndex("dbo.Comunicacions", new[] { "contacto_nombre" });
            DropIndex("dbo.Contactoes", new[] { "Proveedor_rut" });
            DropIndex("dbo.ArticuloProveedors", new[] { "FacturaVenta_id" });
            DropIndex("dbo.ArticuloProveedors", new[] { "FacturaCompra_id" });
            DropIndex("dbo.ArticuloProveedors", new[] { "proveedor_rut" });
            DropIndex("dbo.ArticuloProveedors", new[] { "articulo_id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.FacturaVentas");
            DropTable("dbo.FacturaCompras");
            DropTable("dbo.Comunicacions");
            DropTable("dbo.Contactoes");
            DropTable("dbo.Proveedors");
            DropTable("dbo.Articuloes");
            DropTable("dbo.ArticuloProveedors");
        }
    }
}

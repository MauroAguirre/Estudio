namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Canals",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        descripcion = c.String(),
                        EsInternacional = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellido = c.String(),
                        telefono = c.Int(nullable: false),
                        mail = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PaqueteCanals",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Canal_id = c.Int(),
                        paquete_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Canals", t => t.Canal_id)
                .ForeignKey("dbo.Paquetes", t => t.paquete_id)
                .Index(t => t.Canal_id)
                .Index(t => t.paquete_id);
            
            CreateTable(
                "dbo.Paquetes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        costo = c.Int(nullable: false),
                        cliente_id = c.Int(),
                        paquete_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.cliente_id)
                .ForeignKey("dbo.Paquetes", t => t.paquete_id)
                .Index(t => t.cliente_id)
                .Index(t => t.paquete_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "paquete_id", "dbo.Paquetes");
            DropForeignKey("dbo.Ventas", "cliente_id", "dbo.Clientes");
            DropForeignKey("dbo.PaqueteCanals", "paquete_id", "dbo.Paquetes");
            DropForeignKey("dbo.PaqueteCanals", "Canal_id", "dbo.Canals");
            DropIndex("dbo.Ventas", new[] { "paquete_id" });
            DropIndex("dbo.Ventas", new[] { "cliente_id" });
            DropIndex("dbo.PaqueteCanals", new[] { "paquete_id" });
            DropIndex("dbo.PaqueteCanals", new[] { "Canal_id" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Paquetes");
            DropTable("dbo.PaqueteCanals");
            DropTable("dbo.Clientes");
            DropTable("dbo.Canals");
        }
    }
}

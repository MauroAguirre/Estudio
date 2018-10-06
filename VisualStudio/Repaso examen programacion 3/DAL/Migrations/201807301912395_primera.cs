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
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        EsInternacional = c.Boolean(nullable: false),
                        Paquete_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Paquetes", t => t.Paquete_Id)
                .Index(t => t.Paquete_Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.Int(nullable: false),
                        Mail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Costo = c.Int(nullable: false),
                        Cliente_Id = c.Int(),
                        Paquete_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .ForeignKey("dbo.Paquetes", t => t.Paquete_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Paquete_Id);
            
            CreateTable(
                "dbo.Paquetes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "Paquete_Id", "dbo.Paquetes");
            DropForeignKey("dbo.Canals", "Paquete_Id", "dbo.Paquetes");
            DropForeignKey("dbo.Ventas", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.Ventas", new[] { "Paquete_Id" });
            DropIndex("dbo.Ventas", new[] { "Cliente_Id" });
            DropIndex("dbo.Canals", new[] { "Paquete_Id" });
            DropTable("dbo.Paquetes");
            DropTable("dbo.Ventas");
            DropTable("dbo.Clientes");
            DropTable("dbo.Canals");
        }
    }
}

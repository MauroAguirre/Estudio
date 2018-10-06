namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alquilers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Cliente_ID = c.Int(),
                        Funcionario_ID = c.Int(),
                        Servicio_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ID)
                .ForeignKey("dbo.Funcionarios", t => t.Funcionario_ID)
                .ForeignKey("dbo.Servicios", t => t.Servicio_ID)
                .Index(t => t.Cliente_ID)
                .Index(t => t.Funcionario_ID)
                .Index(t => t.Servicio_ID);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Documento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PrecioDia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LineaFacturas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Costo = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Factura_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Facturas", t => t.Factura_ID)
                .Index(t => t.Factura_ID);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Personas", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Personas", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Autos",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Puertas = c.Int(nullable: false),
                        Motor = c.String(),
                        NChasis = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Servicios", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Botes",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Servicios", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Casas",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        CantDormitorios = c.Int(nullable: false),
                        Banios = c.Int(nullable: false),
                        Cochera = c.Boolean(nullable: false),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Servicios", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Casas", "ID", "dbo.Servicios");
            DropForeignKey("dbo.Botes", "ID", "dbo.Servicios");
            DropForeignKey("dbo.Autos", "ID", "dbo.Servicios");
            DropForeignKey("dbo.Funcionarios", "ID", "dbo.Personas");
            DropForeignKey("dbo.Clientes", "ID", "dbo.Personas");
            DropForeignKey("dbo.LineaFacturas", "Factura_ID", "dbo.Facturas");
            DropForeignKey("dbo.Alquilers", "Servicio_ID", "dbo.Servicios");
            DropForeignKey("dbo.Alquilers", "Funcionario_ID", "dbo.Funcionarios");
            DropForeignKey("dbo.Alquilers", "Cliente_ID", "dbo.Clientes");
            DropIndex("dbo.Casas", new[] { "ID" });
            DropIndex("dbo.Botes", new[] { "ID" });
            DropIndex("dbo.Autos", new[] { "ID" });
            DropIndex("dbo.Funcionarios", new[] { "ID" });
            DropIndex("dbo.Clientes", new[] { "ID" });
            DropIndex("dbo.LineaFacturas", new[] { "Factura_ID" });
            DropIndex("dbo.Alquilers", new[] { "Servicio_ID" });
            DropIndex("dbo.Alquilers", new[] { "Funcionario_ID" });
            DropIndex("dbo.Alquilers", new[] { "Cliente_ID" });
            DropTable("dbo.Casas");
            DropTable("dbo.Botes");
            DropTable("dbo.Autos");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Clientes");
            DropTable("dbo.LineaFacturas");
            DropTable("dbo.Facturas");
            DropTable("dbo.Servicios");
            DropTable("dbo.Personas");
            DropTable("dbo.Alquilers");
        }
    }
}

namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
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
                        Servicio_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ID)
                .ForeignKey("dbo.Funcionartios", t => t.Funcionario_ID)
                .ForeignKey("dbo.Servicios", t => t.Servicio_Id)
                .Index(t => t.Cliente_ID)
                .Index(t => t.Funcionario_ID)
                .Index(t => t.Servicio_Id);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LineaFacturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Costo = c.Int(nullable: false),
                        cantidad = c.Int(nullable: false),
                        Funcionario_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Funcionartios", t => t.Funcionario_ID)
                .Index(t => t.Funcionario_ID);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrecioPorDia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Autos",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Puertas = c.Int(nullable: false),
                        NumMotor = c.Int(nullable: false),
                        NumChasis = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Servicios", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Casas",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Habitaciones = c.Int(nullable: false),
                        Baños = c.Int(nullable: false),
                        Cochera = c.Boolean(nullable: false),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Servicios", t => t.Id)
                .Index(t => t.Id);
            
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
                "dbo.Funcionartios",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Personas", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcionartios", "ID", "dbo.Personas");
            DropForeignKey("dbo.Clientes", "ID", "dbo.Personas");
            DropForeignKey("dbo.Casas", "Id", "dbo.Servicios");
            DropForeignKey("dbo.Autos", "Id", "dbo.Servicios");
            DropForeignKey("dbo.Alquilers", "Servicio_Id", "dbo.Servicios");
            DropForeignKey("dbo.Alquilers", "Funcionario_ID", "dbo.Funcionartios");
            DropForeignKey("dbo.LineaFacturas", "Funcionario_ID", "dbo.Funcionartios");
            DropForeignKey("dbo.Alquilers", "Cliente_ID", "dbo.Clientes");
            DropIndex("dbo.Funcionartios", new[] { "ID" });
            DropIndex("dbo.Clientes", new[] { "ID" });
            DropIndex("dbo.Casas", new[] { "Id" });
            DropIndex("dbo.Autos", new[] { "Id" });
            DropIndex("dbo.LineaFacturas", new[] { "Funcionario_ID" });
            DropIndex("dbo.Alquilers", new[] { "Servicio_Id" });
            DropIndex("dbo.Alquilers", new[] { "Funcionario_ID" });
            DropIndex("dbo.Alquilers", new[] { "Cliente_ID" });
            DropTable("dbo.Funcionartios");
            DropTable("dbo.Clientes");
            DropTable("dbo.Casas");
            DropTable("dbo.Autos");
            DropTable("dbo.Facturas");
            DropTable("dbo.Servicios");
            DropTable("dbo.LineaFacturas");
            DropTable("dbo.Personas");
            DropTable("dbo.Alquilers");
        }
    }
}

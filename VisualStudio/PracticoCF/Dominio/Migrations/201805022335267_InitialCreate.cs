namespace Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ci = c.String(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Direccions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Calle = c.String(nullable: false, maxLength: 50),
                        Numero = c.Int(nullable: false),
                        ElCliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ElCliente_Id)
                .Index(t => t.ElCliente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Direccions", "ElCliente_Id", "dbo.Clientes");
            DropIndex("dbo.Direccions", new[] { "ElCliente_Id" });
            DropTable("dbo.Direccions");
            DropTable("dbo.Clientes");
        }
    }
}

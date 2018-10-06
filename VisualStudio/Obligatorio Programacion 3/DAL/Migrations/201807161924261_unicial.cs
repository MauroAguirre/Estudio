namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrador",
                c => new
                    {
                        Mail = c.String(nullable: false, maxLength: 128),
                        ID = c.Int(nullable: false),
                        Nombre = c.String(),
                        Contra = c.String(),
                    })
                .PrimaryKey(t => t.Mail);
            
            CreateTable(
                "dbo.Direccions",
                c => new
                    {
                        Nombre = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Nombre);
            
            CreateTable(
                "dbo.Envios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FechaEnvio = c.DateTime(nullable: false),
                        FechaLlegada = c.DateTime(nullable: false),
                        DireccionUsuario = c.String(),
                        Estado = c.String(),
                        DireccionLugar = c.String(),
                        Usuario = c.String(),
                        Usuario_Mail = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuario", t => t.Usuario_Mail)
                .Index(t => t.Usuario_Mail);
            
            CreateTable(
                "dbo.Paquetes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Cantidad = c.Int(nullable: false),
                        Tamano = c.String(),
                        Usuario = c.String(),
                        IdEnvio = c.Int(nullable: false),
                        Envio_ID = c.Int(),
                        Usuario_Mail = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Envios", t => t.Envio_ID)
                .ForeignKey("dbo.Usuario", t => t.Usuario_Mail)
                .Index(t => t.Envio_ID)
                .Index(t => t.Usuario_Mail);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Mail = c.String(nullable: false, maxLength: 128),
                        ID = c.Int(nullable: false),
                        Nombre = c.String(),
                        Contra = c.String(),
                    })
                .PrimaryKey(t => t.Mail);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paquetes", "Usuario_Mail", "dbo.Usuario");
            DropForeignKey("dbo.Envios", "Usuario_Mail", "dbo.Usuario");
            DropForeignKey("dbo.Paquetes", "Envio_ID", "dbo.Envios");
            DropIndex("dbo.Paquetes", new[] { "Usuario_Mail" });
            DropIndex("dbo.Paquetes", new[] { "Envio_ID" });
            DropIndex("dbo.Envios", new[] { "Usuario_Mail" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Paquetes");
            DropTable("dbo.Envios");
            DropTable("dbo.Direccions");
            DropTable("dbo.Administrador");
        }
    }
}

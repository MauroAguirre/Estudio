namespace Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Mail", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Clientes", "Nombre", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Nombre", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Clientes", "Mail");
        }
    }
}

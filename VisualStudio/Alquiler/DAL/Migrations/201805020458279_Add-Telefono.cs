namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTelefono : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Casas", "Telefono", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Casas", "Telefono");
        }
    }
}

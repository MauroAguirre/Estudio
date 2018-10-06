namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTelefono : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Casas", "Telefono");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Casas", "Telefono", c => c.String());
        }
    }
}

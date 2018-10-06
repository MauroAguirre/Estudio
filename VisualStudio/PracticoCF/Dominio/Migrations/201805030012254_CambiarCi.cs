namespace Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiarCi : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Clientes", name: "Ci", newName: "Cedula");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Clientes", name: "Cedula", newName: "Ci");
        }
    }
}

namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.TodoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.TodoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.TodoItems.AddOrUpdate(new TodoItem() { Description = "TodoItem 1"});
            context.TodoItems.AddOrUpdate(new TodoItem() { Description = "TodoItem 2" });
            context.TodoItems.AddOrUpdate(new TodoItem() { Description = "TodoItem 3" });
        }
    }
}

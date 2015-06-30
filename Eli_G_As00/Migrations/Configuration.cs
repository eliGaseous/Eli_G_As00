namespace Eli_G_As00.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Eli_G_As00.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Eli_G_As00.Models.Eli_G_As00Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Eli_G_As00.Models.Eli_G_As00Context context)
        {
            context.Contacts.AddOrUpdate(p => p.Name,
            new Contact
       {
           Name = "Debra Garcia"
           
       },
        new Contact
        {
            Name = "Thorsten Weinrich"
        },
        new Contact
        {
            Name = "Yuhong Li"
        },
        new Contact
        {
            Name = "Jon Orton"
        },
        new Contact
        {
            Name = "Diliana Alexieva-Bosseva"
        }
        );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

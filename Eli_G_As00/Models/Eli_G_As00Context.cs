using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eli_G_As00.Models
{
    public class Eli_G_As00Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Eli_G_As00Context() : base("name=Eli_G_As00Context")
        {
        }

        public System.Data.Entity.DbSet<Eli_G_As00.Models.Contact> Contacts { get; set; }
    
    }
}

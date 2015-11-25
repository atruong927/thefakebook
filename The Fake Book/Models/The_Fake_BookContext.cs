using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace The_Fake_Book.Models
{
    public class The_Fake_BookContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public The_Fake_BookContext() : base("name=The_Fake_BookContext")
        {
        }

        public System.Data.Entity.DbSet<The_Fake_Book.Models.Member> Members { get; set; }

        public System.Data.Entity.DbSet<The_Fake_Book.Models.Message> Messages { get; set; }

        public System.Data.Entity.DbSet<The_Fake_Book.Models.Profile> Profiles { get; set; }
    }
}

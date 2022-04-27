using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookRoom.Data
{
    public class BookRoomContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BookRoomContext() : base("name=BookRoomContext")
        {
        }

        public System.Data.Entity.DbSet<BookRoom.Bookings> Bookings { get; set; }

        public System.Data.Entity.DbSet<BookRoom.Customers> Customers { get; set; }

        public System.Data.Entity.DbSet<BookRoom.Rooms> Rooms { get; set; }

        public System.Data.Entity.DbSet<BookRoom.Tasks> Tasks { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCodeFirstApproach.Models
{
    public class StudentDbContext : DbContext  
    {
        /* DbContext:
           1.this class set data of Student class to the database
           2.this class convert stuent class to table and set data init
           3.It is provided by System.Data.Entity namespace of the ASP.NET MVC Framework
           4.Uses the DbSet<T> type to define one or more properties where, T represents the type of an onject that needs to be stored in the database
           5.DbSet<T> it sets data to our database
         */
        public DbSet<Student> Students { get; set; }
    }
}
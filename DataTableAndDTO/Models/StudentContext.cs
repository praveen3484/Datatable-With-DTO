using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataTableAndDTO.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("MyJqGridAssignment")
        {

        }
        //public DbSet<Students1> Students1 { get; set; }
        //public DbSet<Students1Details> Student1Details { get; set; }
    }
}
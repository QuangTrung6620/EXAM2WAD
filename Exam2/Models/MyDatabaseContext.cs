using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exam2.Models
{
    public class MyDatabaseContext :DbContext
    {
        public MyDatabaseContext()

            : base("MyConncectionString")
        {
        }

        public System.Data.Entity.DbSet<Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<Exam2.Models.Category> Categories { get; set; }
    }
}
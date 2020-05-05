using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ExportExcelDemo.Models
{
    public class Context :  DbContext
    {
        public Context() : base("DefaultConnection")
        {

        }
        public DbSet<Employee> Employees { get; set; }

    }
}
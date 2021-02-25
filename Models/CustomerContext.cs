using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactUs.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("CustomerData") { }
        public DbSet<Customer> Customer { get; set; }
    }
}
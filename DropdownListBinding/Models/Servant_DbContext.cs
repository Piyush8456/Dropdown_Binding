using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DropdownListBinding.Models
{
    public class Servants_DbContext : DbContext
    {
        public Servants_DbContext() : base("testDB")
        {

        }
        public DbSet<Servants> servants { get; set; }

        public DbSet<Skills> skills { get; set; }

    }
}
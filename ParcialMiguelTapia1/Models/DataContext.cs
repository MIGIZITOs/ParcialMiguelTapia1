using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ParcialMiguelTapia1.Models
{
    public class DataContext: DbContext
    {
        public DataContext(): base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ParcialMiguelTapia1.Models.Country> Countries { get; set; }
    }
}
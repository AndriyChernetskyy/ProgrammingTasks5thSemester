using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.DAL.Entities;

namespace Task3.DAL.EF
{
    public class OfferContext:DbContext
    {
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public OfferContext(string connectionString)
            : base("DbConnection")
        {
        }

    } 
}

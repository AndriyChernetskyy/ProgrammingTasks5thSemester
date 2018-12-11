using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.DAL.EF;
using Task3.DAL.Entities;
using Task3.DAL.Interfaces;

namespace Task3.DAL.Repositories
{
    public class EFUnitOfWork:IUnitOfWork
    {
        private OfferContext db;
        private CarrierRepository carrierRepository;
        private OfferRepository offerRepository;
        private VehicleRepository vehicleRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new OfferContext(connectionString);
        }
        public IRepository<Carrier> Carriers
        {
            get
            {
                if (carrierRepository == null)
                    carrierRepository = new CarrierRepository(db);
                return carrierRepository;
            }
        }

        public IRepository<Offer> Offers
        {
            get
            {
                if (offerRepository == null)
                    offerRepository = new OfferRepository(db);
                return offerRepository;
            }
        }
        public IRepository<Vehicle> Vehicles
        {
            get
            {
                if (vehicleRepository == null)
                    vehicleRepository = new VehicleRepository(db);
                return vehicleRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

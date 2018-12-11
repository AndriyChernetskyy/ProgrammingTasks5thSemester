using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.DAL.EF;
using Task3.DAL.Entities;
using Task3.DAL.Interfaces;

namespace Task3.DAL.Repositories
{
    class VehicleRepository:IRepository<Vehicle>
    {
        private OfferContext db;

        public VehicleRepository(OfferContext context)
        {
            db = context;
        }
        public IEnumerable<Vehicle> GetAll()
        {
            return db.Vehicles;
        }

        public Vehicle Get(int id)
        {
            return db.Vehicles.Find(id);
        }

        public void Create(Vehicle vehicle)
        {
            db.Vehicles.Add(vehicle);
        }

        public void Update(Vehicle vehicle)
        {
            db.Entry(vehicle).State = EntityState.Modified;
        }

        public IEnumerable<Vehicle> Find(Func<Vehicle, Boolean> predicate)
        {
            return db.Vehicles.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle != null)
                db.Vehicles.Remove(vehicle);
        }
    }
}

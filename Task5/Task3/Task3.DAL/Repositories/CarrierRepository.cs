using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.DAL.EF;
using Task3.DAL.Interfaces;

namespace Task3.DAL.Repositories
{
    class CarrierRepository:IRepository<Carrier>
    {
        private OfferContext db;

        public CarrierRepository(OfferContext context)
        {
            db = context;
        }
        public IEnumerable<Carrier> GetAll()
        {
            return db.Carriers;
        }

        public Carrier Get(int id)
        {
            return db.Carriers.Find(id);
        }

        public void Create(Carrier carrier)
        {
            db.Carriers.Add(carrier);
        }

        public void Update(Carrier carrier)
        {
            db.Entry(carrier).State = EntityState.Modified;
        }

        public IEnumerable<Carrier> Find(Func<Carrier, Boolean> predicate)
        {
            return db.Carriers.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Carrier carrier = db.Carriers.Find(id);
            if (carrier != null)
                db.Carriers.Remove(carrier);
        }
    }
}

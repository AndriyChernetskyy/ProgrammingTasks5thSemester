using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.DAL.Entities;

namespace Task3.DAL.Interfaces
{
    interface IUnitOfWork:IDisposable
    {
        IRepository<Carrier> Carriers { get; }
        IRepository<Offer> Offers { get; }
        IRepository<Vehicle> Vehicles { get; }
        void Save();
    }
}

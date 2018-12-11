using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.DAL.Entities
{
    public class Offer
    {
        /// <summary>
        /// Gets or sets <see cref="Id"/> for <see cref="Offer"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets <see cref="DateOfPosting"/> for <see cref="Offer"/>.
        /// </summary>
        public DateTime DateOfPosting { get; set; }

        /// <summary>
        /// Gets or sets <see cref="From"/> for <see cref="Offer"/>.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Gets or sets <see cref="To"/> for <see cref="Offer"/>.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Gets or sets <see cref="DateOfLoading"/> for <see cref="Offer"/>.
        /// </summary>
        public DateTime DateOfLoading { get; set; }

        public int VehicleId { get; set;}
        /// <summary>
        /// Gets or sets <see cref="VehicleInfo"/> for <see cref="Offer"/>.
        /// </summary>
        public Vehicle Vehicle{ get; set; }

        public int CarrierId { get; set; }
        /// <summary>
        /// Gets or sets <see cref="CarrierInfo"/> for <see cref="Offer"/>.
        /// </summary>
        public Carrier Carrier { get; set; }
    }
}

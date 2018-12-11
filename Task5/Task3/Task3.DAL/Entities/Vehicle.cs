using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Models;

namespace Task3.DAL.Entities
{
    public class Vehicle
    {
        /// <summary>
        /// Vehicle carrying capacity
        /// </summary>
        private double weight;

        /// <summary>
        /// Gets or sets <see cref="Type"/> for <see cref="Vehicle"/>.
        /// </summary>
        public VehicleType Type { get; set; }

        /// <summary>
        /// Gets or sets <see cref="Weight"/> for <see cref="Vehicle"/>.
        /// </summary>
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
    }
}

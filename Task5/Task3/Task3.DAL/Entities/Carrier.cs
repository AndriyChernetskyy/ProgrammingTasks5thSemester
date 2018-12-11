using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.DAL.Entities;

namespace Task3.DAL
{
    public class Carrier
    {
        /// <summary>
        /// Gets or sets <see cref="Id"/> for <see cref="Carrier"/>.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets <see cref="Name"/> for <see cref="Carrier"/>.
        /// </summary>
        /// <value><see cref="Name"/> for <see cref="Carrier"/>.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets <see cref="PhoneNumber"/> for <see cref="Carrier"/>.
        /// </summary>
        /// <value><see cref="PhoneNumber"/> for <see cref="Carrier"/>.</value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets <see cref="Email"/> for <see cref="Carrier"/>.
        /// </summary>
        /// <value><see cref="Email"/> for <see cref="Carrier"/>.</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets <see cref="Vehicle"/> for <see cref="Carrier"/>.
        /// </summary>
        /// <value><see cref="Vehicle"/> for <see cref="Carrier"/>.</value>
        public Vehicle Vehicle { get; set; }
    }
}

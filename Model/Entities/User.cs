using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class User : IdentityUser<Guid>
    {
        /// <summary>
        /// The first name of user
        /// </summary>
        public string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// The last name of user
        /// </summary>
        public string LastName { get; set; } = string.Empty;
        public ICollection<Ticket> Tickets { get; set; }

    }
}

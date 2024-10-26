using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BaseEntity<T> where T : struct
    {
        public T Id { get; set; }

        /// <summary>
        /// The date time of data has updated in system
        /// </summary>
        public DateTime UpdatedDateTime { get; set; }
        /// <summary>
        /// the date time of data has created in system
        /// </summary>
        public DateTime CreatedDateTime { get; set; }
        /// <summary>
        /// The id of user where created data in system
        /// </summary>
        public Guid? CreatedUserId { get; set; }
        /// <summary>
        /// the id of user where updated data in system
        /// </summary>
        public Guid? UpdatedUserId { get; set; }
        /// <summary>
        /// the navigation property of user for data of created user field
        /// </summary>
        public User? CreatedUser { get; set; }
        /// <summary>
        /// the navigation property of user for data update user field
        /// </summary>
        public User? UpdatedUser { get; set; }
    }
}

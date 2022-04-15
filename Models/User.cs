using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models
{
    public partial class User
    {
        public User()
        {

        }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public bool IsLocked { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Name { get; set; }
        public bool EmailVerified { get; set; }
        public int? CountryId { get; set; }
    }
}

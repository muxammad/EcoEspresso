using EcoExpresso.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoExpresso.Domain.Entities
{
    public class User
    {
        [MinLength(3), MaxLength(50)]
        public string FirstName { get; set; }
        [MinLength(3), MaxLength(50)]
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; } = Role.User;


        public ICollection<Meal> CookedMeals { get; set; }
    }
}

using EcoExpresso.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoExpresso.Domain.Entities
{
    public class Meal : Auditable
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public long CookedBy { get; set; }
        public User User { get; set; }

    }
}

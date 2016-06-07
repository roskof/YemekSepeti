using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
   public  class Shop
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Meal> MealList { get; set; }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
   public class Cart
    {
        public string Id { get; set; }
        public int Quantity { get; set; }
        public string MealID { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
   public class Meal
    {

        public string Id { get; set; }
        public decimal UnitPrice { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShopId { get; set; }

        public Shop ShopItem { get; set; }


    }
}

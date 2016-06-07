using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Sale
{
    public class CartWithPrice
    {
        public Cart CartItem { get; set; }
        public decimal CartPrice { get; set; }
    }
}

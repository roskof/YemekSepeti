using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Sale
{
    public class SaleDetail
    {
        public string Id { get; set; }

        public int Quantity { get; set; }

        public string MealId { get; set; }

        public decimal Price { get; set; }

        public string SaleId { get; set; }

        public Sale SaleItem { get; set; }
    }
}

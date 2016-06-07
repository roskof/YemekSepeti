using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Sale
{
    public class Sale
    {
        public string Id { get; set; }
        public decimal TotalPrice { get; set; }

        public string Code { get; set; }

        public List<SaleDetail> SaleDetailList { get; set; }
    }
}

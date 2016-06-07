using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
  public class ShopUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public List<Shop> ShopList { get; set; }
    }
}

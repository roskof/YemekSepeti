using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public interface IShopRepository
    {
        List<Shop> GetShopList();


        List<Cart> GetCartListByIdList(List<string> cartIdList);

        void Save(Sale.ShopAggregate aggregate);
    }
}

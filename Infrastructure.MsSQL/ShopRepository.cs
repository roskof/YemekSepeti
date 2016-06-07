using Core.Domain;
using Core.Domain.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MsSQL
{
    public class ShopRepository : IShopRepository
    {
        public List<Shop> GetShopList()
        {
            using (var dbcontext = new YemekSepetiDbContext())
            {
                return dbcontext.ShopSet.ToList();
            }
        }


        public List<Cart> GetCartListByIdList(List<string> cartIdList)
        {
            throw new NotImplementedException();
        }

        public void Save(ShopAggregate aggregate)
        {
            var saleItem = aggregate.GetSale();

            using (var db=new YemekSepetiDbContext())
            {
                db.SaleSet.Add(saleItem);
                db.SaveChanges();
            }
        }
    }
}

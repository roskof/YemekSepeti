using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Sale
{
    public class ShopAggregate
    {

        public decimal totalPrice = 0;
        private List<CartWithPrice> _list;
        private Sale _saleItem;

        public bool IsShopListValid(List<Cart> cartList, List<Meal> mealList)
        {
            List<CartWithPrice> cartwithPriceList = GetCartWithPrice(cartList, mealList);

            foreach (var item in cartwithPriceList)
            {
                if (item.CartPrice <= 0)
                {
                    return false;
                }
            }

            return true;
        }

        private List<CartWithPrice> GetCartWithPrice(List<Cart> cartList, List<Meal> mealList)
        {
            throw new NotImplementedException();
        }

        public void Checkout(List<Cart> cartList, List<Meal> mealList)
        {
            if (!IsShopListValid(cartList, mealList))
                throw new Exception("Data uygun değil");

            _list = GetCartWithPrice(cartList, mealList);

            totalPrice = CalculateTotalPrice(_list);


        }

        private decimal CalculateTotalPrice(List<CartWithPrice> list)
        {
            return 0;
        }

        public decimal GetTotalPrice()
        {
            return totalPrice;
        }

        public void SetSale(string payCode, string userid)
        {

            var saleItem = new Sale { Code = payCode, TotalPrice = totalPrice };
            saleItem.SaleDetailList = new List<SaleDetail>();

            foreach (var item in _list)
            {
                saleItem.SaleDetailList.Add(new SaleDetail { MealId = item.CartItem.MealID });

            }

            _saleItem = saleItem;
        }

        public Sale GetSale()
        {
            return _saleItem;

        }
    }
}

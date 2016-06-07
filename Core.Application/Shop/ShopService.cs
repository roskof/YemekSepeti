using Core.Application.Shop.DTO;
using Core.Domain;
using Core.Domain.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Shop
{
    public class ShopService : IShopService
    {
        private IShopRepository _shopRepository;
        private IMealRepository _mealRepository;
        private ICheckoutService _checkoutService;

        public ShopService(IShopRepository shopRepository, IMealRepository mealRepository, ICheckoutService checkoutService)
        {
            _shopRepository = shopRepository;
            _mealRepository = mealRepository;
            _checkoutService = checkoutService;
        }

        public List<ShopDTO> GetHomeShopList()
        {
            List<ShopDTO> dtoList = new List<ShopDTO>();

            var shopList = _shopRepository.GetShopList();

            foreach (var item in shopList)
            {
                dtoList.Add(new ShopDTO { Id = item.Id, Name = item.Name });
            }

            return dtoList;
        }

        public void Checkout(string userid, List<string> cartIdList)
        {
            var aggregate = new ShopAggregate();

            List<Cart> cartList = _shopRepository.GetCartListByIdList(cartIdList);
            var mealIdList = cartList.Select(a => a.MealID).ToList();

            List<Meal> mealList = _mealRepository.GetMealListByIdList(mealIdList);

            aggregate.Checkout(cartList, mealList);

            string payCode = _checkoutService.PayCheckout(aggregate.GetTotalPrice());

            aggregate.SetSale(payCode, userid);

            _shopRepository.Save(aggregate);
        }

        private void ShopAggregate()
        {
            throw new NotImplementedException();
        }
    }
}

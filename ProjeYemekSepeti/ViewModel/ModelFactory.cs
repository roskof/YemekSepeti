using Core.Application.Shop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjeYemekSepeti.ViewModel
{
    public class ModelFactory
    {
        internal static List<ShopViewModel> Parse(List<ShopDTO> shopList)
        {
            List<ShopViewModel> modelList = new List<ShopViewModel>();

            foreach (var item in shopList)
            {
                modelList.Add(new ShopViewModel { Id = item.Id, Name = item.Name });
            }

            return modelList;
        }
    }
}
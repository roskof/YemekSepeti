﻿using Core.Application.Shop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application
{
    public interface IShopService
    {
        List<ShopDTO> GetHomeShopList();
    }
}

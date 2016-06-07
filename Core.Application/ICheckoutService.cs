using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Shop
{
    public interface ICheckoutService
    {
        string PayCheckout(decimal p);
    }
}

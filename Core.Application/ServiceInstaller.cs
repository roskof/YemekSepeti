using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Core.Application.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        { 

            container.Register(Component.For<IShopService>().ImplementedBy<ShopService>());
            container.Register(Component.For<ICheckoutService>().ImplementedBy<CheckoutService>());

        }
    }
    
}

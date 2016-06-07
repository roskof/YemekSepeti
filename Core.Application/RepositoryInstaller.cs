using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Core.Domain;
using Infrastructure.MsSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Component.For<IShopRepository>().ImplementedBy<ShopRepository>());
            container.Register(Component.For<IMealRepository>().ImplementedBy<MealRepository>());

        }
    }
}

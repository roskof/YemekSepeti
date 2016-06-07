using Castle.Windsor;
using Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeYemekSepeti
{
    public class BootstrapWindsor
    {
        public static IWindsorContainer container;
        public static void BootstrapContainer()
        {
            container = new WindsorContainer()
                .Install(new RepositoryInstaller(),new ServiceInstaller());

            container.Register(Castle.MicroKernel.Registration.Classes.FromThisAssembly().BasedOn<IController>().LifestyleTransient());

            var controllerFactory = new WindsorControllerFactory(container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}
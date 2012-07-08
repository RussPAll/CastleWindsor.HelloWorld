using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using CastleWindsor.HelloWorld.Services;

namespace CastleWindsor.HelloWorld.Web.AppCode.BootStrappers
{
    public class CastleWindsorBootstrapper
    {
        internal WindsorContainer GetContainer()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IHelloWorldRepository>().ImplementedBy<EnglishHelloWorldRepository>());
            container.Register(Component.For<DefaultPresenter>().ImplementedBy<DefaultPresenter>());

            return container;
        }
    }
}
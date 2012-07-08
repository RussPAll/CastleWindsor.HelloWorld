using System;
using CastleWindsor.HelloWorld.Web.AppCode.BootStrappers;

namespace CastleWindsor.HelloWorld.Web
{
    public class Global : System.Web.HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Application["WindsorContainer"] = new CastleWindsorBootstrapper().GetContainer();
        }
    }
}

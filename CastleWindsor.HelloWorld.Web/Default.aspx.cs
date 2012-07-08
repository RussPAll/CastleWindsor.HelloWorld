using System;
using CastleWindsor.HelloWorld.Web.AppCode;
using Castle.Windsor;

namespace CastleWindsor.HelloWorld.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var container = (WindsorContainer)Application["WindsorContainer"];
            var presenter = container.Resolve<DefaultPresenter>();
            Heading.InnerText = presenter.GetMessage();
        }
    }
}

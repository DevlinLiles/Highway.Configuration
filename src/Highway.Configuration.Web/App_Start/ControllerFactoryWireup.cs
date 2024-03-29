using System;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using Castle.Core.Logging;

[assembly: WebActivator.PostApplicationStartMethod(typeof(Highway.Configuration.Web.App_Start.ControllerFactoryWireup), "PostStartup")]
namespace Highway.Configuration.Web.App_Start
{
    public static class ControllerFactoryWireup
    {
        public static void PostStartup()
        {
#pragma warning disable 618
            IControllerFactory factory = IoC.Container.Resolve<IControllerFactory>();
#pragma warning restore 618
            ControllerBuilder.Current.SetControllerFactory(factory);
        }
    }
}

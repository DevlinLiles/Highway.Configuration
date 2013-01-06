using System;
using System.Linq;
using System.Collections.Generic;
using Castle.Core.Logging;
using System.Data.Entity;
using Highway.Configuration.Models;

[assembly: WebActivator.PostApplicationStartMethod(typeof(Highway.Configuration.App_Start.LogAnnouncements), "PostStartup")]
[assembly: WebActivator.ApplicationShutdownMethod(typeof(Highway.Configuration.App_Start.LogAnnouncements), "Shutdown")]
namespace Highway.Configuration.App_Start
{
    public static class LogAnnouncements
    {
        private static ILogger logger = NullLogger.Instance;
        public static void PostStartup()
        {
#pragma warning disable 618
            logger = IoC.Container.Resolve<ILogger>();
#pragma warning restore 618

            logger.Info("Application Startup Completed");
        }

        public static void Shutdown()
        {
            logger.Info("Application Shutdown");
        }
    }
}

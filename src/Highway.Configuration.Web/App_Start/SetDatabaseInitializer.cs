using System.Data.Entity;
using Highway.Data;

[assembly: WebActivator.PostApplicationStartMethod(typeof(Highway.Configuration.Web.App_Start.SetDatabaseInitializer), "PostStartup")]
namespace Highway.Configuration.Web.App_Start
{
    public static class SetDatabaseInitializer
    {
        public static void PostStartup()
        {
#pragma warning disable 618
            var initializer = IoC.Container.Resolve<IDatabaseInitializer<DataContext>>();
#pragma warning restore 618
            Database.SetInitializer(initializer);
        }
    }
}

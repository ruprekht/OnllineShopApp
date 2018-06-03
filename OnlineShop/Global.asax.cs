using Autofac;
using Autofac.Integration.Mvc;
using OnlineShop.Data;
using OnlineShop.Data.Interfaces;
using OnlineShop.Helpers;
using System.Configuration;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OnlineShop
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<DbContextProvider>().As<IDbContextProvider>().InstancePerRequest();
            builder.RegisterType<ShopRepository>().As<IShopRepository>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            Database.SetInitializer(new ShopDBInitializer());
            EntityDbContext context = new EntityDbContext();
            context.Database.Initialize(true);

            var grabber = new SourceGrabber();
            var updater = new DbUpdater();
            var parser = new XmlParser();
            updater.AddOrUpdateItems(context, grabber, parser, ConfigurationManager.AppSettings["SourceURL"]);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

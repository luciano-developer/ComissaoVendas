using ComissaoVenda.Repositories;
using ComissaoVenda.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ComissaoVenda
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IVendaService,VendaService>();
            container.RegisterType<IVendaRepository, VendaRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
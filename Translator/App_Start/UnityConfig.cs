using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace Translator
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<Translator.Controllers.TranslateController>();
            ContainerBootstrapper.RegisterTypes(container);
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
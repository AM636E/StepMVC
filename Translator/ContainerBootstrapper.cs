using Microsoft.Practices.Unity;
using Translator.Code.Service.Translator;
using Translator.Code.Service.Translator.YandexTranslator;
using Translator.Code.Service.Cache.Default;

namespace Translator
{
    public class ContainerBootstrapper
    {
        
        public static void RegisterTypes(IUnityContainer container)
        {
            string baseUrl = System.Configuration.ConfigurationManager.AppSettings["TranslatorBaseUrl"];
            string apiKey = System.Configuration.ConfigurationManager.AppSettings["TranslatorApiKey"];
            ITranslatorService yandexService = new YandexTranslatorService(baseUrl, apiKey);
            ITranslatorService service = new CacheableTranslatorService(yandexService, new DefaultCacheService());
            container.RegisterInstance<ITranslatorService>(service);
        }
    }
}
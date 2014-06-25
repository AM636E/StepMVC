using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using Translator.Code.Service.Cache;

namespace Translator.Code.Service.Translator
{
    public class CacheableTranslatorService : ITranslatorService
    {
        private ICacheService _cache;
        private ITranslatorService _translatorService;
        public CacheableTranslatorService(ITranslatorService service, ICacheService cache)
        {
            this._cache = cache;
            this._translatorService = service;
        }

        public Dictionary<string, string> GetLanguages()
        {
            if(_cache.IsSet("languages") == false)
            {
                _cache.Set("languages", _translatorService.GetLanguages(), 10000);
            }

            return (Dictionary<string, string>)_cache.Get("languages");
        }

        public string DetectLang(string[] text)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> GetAvailableLangs(string lang)
        {
            throw new NotImplementedException();
        }

        public List<Tuple<string, string>> GetTranslateDir()
        {
            throw new NotImplementedException();
        }

        public string Translate(string sourceLang, string sourceText, string targetLanguage)
        {
           return _translatorService.Translate(sourceLang, sourceText, targetLanguage);
        }
    }
}
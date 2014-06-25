using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.Code.Service.Translator
{
    public interface ITranslatorService
    {
         string DetectLang(string[] text);
         Dictionary<string, string> GetAvailableLangs(string lang);
         List<Tuple<string, string>> GetTranslateDir();
         string Translate(string sourceLang, string sourceText, string targetLanguage);

         Dictionary<string, string> GetLanguages();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Mvc5;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace Translator
{
    public class DIFactory
    {
        private static object _lock = new { };
        private static IUnityContainer _unityContainer = null;

        public static IUnityContainer Instance
        {
            get
            {
                if(_unityContainer != null)
                {
                    lock(_lock)
                    {
                        if (_unityContainer != null)
                        {
                            _unityContainer = new UnityContainer();
                        }

                        UnityConfigurationSection.CurrentSection.Configure(_unityContainer, "unity");
                    }
                }

                return _unityContainer;
            }
        }
    }
}
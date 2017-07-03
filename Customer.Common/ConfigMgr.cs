using System;
using System.Configuration;

namespace Customer.Common
{
    public class ConfigMgr : IConfigMgr
    {
        public T Get<T>(string key)
        {
            var result = ConfigurationManager.AppSettings[key];

            return (T) Convert.ChangeType(result, typeof(T));
        }
    }
}
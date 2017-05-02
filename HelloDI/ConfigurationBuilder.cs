using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace HelloDI
{
    public static class ConfigurationBuilder
    {
        public static IMessageWriter GetMessageWriter()
        {
            string sMwType = ConfigurationManager.AppSettings.Get("ManagerWriter");
            var type = Assembly.GetExecutingAssembly().GetType(sMwType, throwOnError: true);
            return (IMessageWriter)Activator.CreateInstance(type);
        }
    }
}

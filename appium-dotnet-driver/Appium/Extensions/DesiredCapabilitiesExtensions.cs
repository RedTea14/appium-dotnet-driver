using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;

namespace OpenQA.Selenium.Appium.Extensions
{
    public static class DesiredCapabilitiesExtensions
    {
        public static Dictionary<string, object> ToDictionary(this DesiredCapabilities desiredCapabilities)
        {
            Type type = typeof(DesiredCapabilities);
            Type hasCapabilities = type.GetInterface("IHasCapabilitiesDictionary");
            PropertyInfo property = hasCapabilities.GetProperty("CapabilitiesDictionary");
            MethodInfo method = property.GetGetMethod();
            Dictionary<string, object> dictionary = method.Invoke(desiredCapabilities, new object[0]) as Dictionary<string, object>;
            return dictionary;
        }
    }
}

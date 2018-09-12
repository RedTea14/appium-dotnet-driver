using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appium.Integration.Tests.Helpers;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Extensions;
using OpenQA.Selenium.Appium.Enums;

namespace Appium.Integration.Tests.Extensions
{
    [TestFixture]
    public class DesiredCapabilitiesExtensionsTest
    {
        [Test]
        public void ToDictionaryTest()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.PlatformName, MobilePlatform.Android);
            capabilities.SetCapability(AndroidMobileCapabilityType.AppActivity, ".SplashActivity");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "8.1");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "Nexus_6_API_27");
            capabilities.SetCapability(MobileCapabilityType.NewCommandTimeout, 600);
            capabilities.SetCapability(MobileCapabilityType.NoReset, false);
            capabilities.SetCapability(MobileCapabilityType.FullReset, true);
            capabilities.SetCapability(MobileCapabilityType.AutomationName, AutomationName.AndroidUIAutomator2);
            capabilities.SetCapability("autoGrantPermissions", true);
            Dictionary<string, object> dic = capabilities.ToDictionary();
            Assert.AreEqual(9, dic.Count);
            Assert.AreEqual(MobilePlatform.Android, dic[MobileCapabilityType.PlatformName]);
            Assert.AreEqual(".SplashActivity", dic[AndroidMobileCapabilityType.AppActivity]);
            Assert.AreEqual("8.1", dic[MobileCapabilityType.PlatformVersion]);
            Assert.AreEqual("Nexus_6_API_27", dic[MobileCapabilityType.DeviceName]);
            Assert.AreEqual(600, dic[MobileCapabilityType.NewCommandTimeout]);
            Assert.AreEqual(false, dic[MobileCapabilityType.NoReset]);
            Assert.AreEqual(true, dic[MobileCapabilityType.FullReset]);
            Assert.AreEqual(AutomationName.AndroidUIAutomator2, dic[MobileCapabilityType.AutomationName]);
            Assert.AreEqual(true, dic["autoGrantPermissions"]);
        }
    }
}

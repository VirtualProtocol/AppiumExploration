using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using TechTalk.SpecFlow;

namespace AppiumExploratoration
{
    [Binding]
    public class StartUp
    {
        public static AppiumDriver<AppiumWebElement> MobileDriver { get; set; }

        public static Uri AppiumLocalService { get; set; }

        [BeforeTestRun]
        public static void BeforeTest()
        {
            AppiumLocalService = new Uri("http://localhost:4723/wd/hub");

            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "374c323837553098");
            appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, "com.sec.android.app.popupcalculator");
            appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, "com.sec.android.app.popupcalculator.Calculator");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Samsung");

            MobileDriver = new AndroidDriver<AppiumWebElement>(AppiumLocalService, appiumOptions);
            MobileDriver?.LaunchApp();
        }

        [AfterTestRun]
        public static void AfterTest()
        {
            MobileDriver?.CloseApp();
            MobileDriver?.Quit();
        }
    }
}

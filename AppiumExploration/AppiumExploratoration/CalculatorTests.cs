using AppiumExploratoration.ScreenObjects;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace AppiumExploratoration
{
    public class CalculatorTests
    {
        private static AppiumDriver<AppiumWebElement> _mobileDriver;
        private static Uri _appiumLocalService;
        private CalculatorScreen _calcScreen;
        
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _appiumLocalService = new Uri("http://localhost:4723/wd/hub");

            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "374c323837553098");
            appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, "com.sec.android.app.popupcalculator");
            appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity,"com.sec.android.app.popupcalculator.Calculator");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Samsung");

            _mobileDriver = new AndroidDriver<AppiumWebElement>(_appiumLocalService, appiumOptions);

            _mobileDriver?.LaunchApp();
            _calcScreen = new CalculatorScreen(_mobileDriver);
        }

        [SetUp]
        public void Setup()
        {
            _calcScreen.ClearInputField();
        }

        [TestCase("1")]
        [TestCase("2")]
        [TestCase("3")]
        [TestCase("4")]
        [TestCase("5")]
        [TestCase("6")]
        [TestCase("7")]
        [TestCase("8")]
        [TestCase("9")]
        [TestCase("0")]
        public void WhenNumberTappedNumberEntered(string number)
        {            
            _calcScreen.EnterNumber(number);
            
            Assert.AreEqual(number, _calcScreen.PrintInputFieldText());
        }

        [TestCase("1", "2")]
        [TestCase("3", "4")]
        [TestCase("5", "6")]
        [TestCase("7", "8")]
        [TestCase("9", "0")]
        public void WhenTwoNumbersAddedResultIsCorrect(string firstNumber, string secondNumber)
        {
            _calcScreen.AddNumbers(firstNumber, secondNumber);

            var expected = Convert.ToString(Convert.ToInt32(firstNumber) + Convert.ToInt32(secondNumber));

            Assert.AreEqual(expected, _calcScreen.PrintInputFieldText());
        }

        [TestCase("1", "2")]
        [TestCase("3", "4")]
        [TestCase("5", "6")]
        [TestCase("7", "8")]
        [TestCase("9", "0")]
        public void WhenTwoNumbersSubtractedResultIsCorrect(string firstNumber, string secondNumber)
        {
            _calcScreen.SubtractNumbers(firstNumber, secondNumber);

            var expected = Convert.ToString(Convert.ToInt32(firstNumber) - Convert.ToInt32(secondNumber));

            Assert.AreEqual(expected, _calcScreen.PrintInputFieldText());
        }

        [TestCase("1", "2")]
        [TestCase("3", "4")]
        [TestCase("5", "6")]
        [TestCase("7", "8")]
        [TestCase("9", "0")]
        public void WhenTwoNumbersMultipliedResultIsCorrect(string firstNumber, string secondNumber)
        {
            _calcScreen.MultiplyNumbers(firstNumber, secondNumber);

            var expected = Convert.ToString(Convert.ToInt32(firstNumber) * Convert.ToInt32(secondNumber));

            Assert.AreEqual(expected, _calcScreen.PrintInputFieldText());
        }

        [TestCase("1", "2")]
        [TestCase("3", "4")]
        [TestCase("5", "6")]
        [TestCase("7", "8")]
        [TestCase("9", "0")]
        public void WhenTwoNumbersDividedResultIsCorrect(string firstNumber, string secondNumber)
        {
            _calcScreen.DivideNumbers(firstNumber, secondNumber);

            var expected = Convert.ToString(Convert.ToInt32(firstNumber) / Convert.ToInt32(secondNumber));

            Assert.AreEqual(expected, _calcScreen.PrintInputFieldText());
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            _mobileDriver?.CloseApp();
        }
    }
}
using AppiumExploratoration.ScreenObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AppiumExploratoration.StepDefinitions
{
    [Binding]
    public class NumbersSteps : StartUp
    {
        private static CalculatorScreen _calculatorScreen { get; set; }


        [Before]
        public void BeforeScenario()
        {
            _calculatorScreen = new CalculatorScreen(MobileDriver);
            _calculatorScreen.ClearInputField();
        }

        [When(@"I enter (.*) into the calculator")]
        public void WhenIEnterIntoTheCalculator(string number)
        {
            _calculatorScreen.EnterNumber(number);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string number)
        {
            Assert.AreEqual(number, _calculatorScreen.PrintInputFieldText());
        }
    }
}

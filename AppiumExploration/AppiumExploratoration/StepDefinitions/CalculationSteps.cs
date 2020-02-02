using AppiumExploratoration.ScreenObjects;
using TechTalk.SpecFlow;

namespace AppiumExploratoration.StepDefinitions
{
    [Binding]
    public class CalculationSteps : StartUp
    {
        private static CalculatorScreen _calculatorScreen { get; set; }


        [Before]
        public void BeforeScenario()
        {
            _calculatorScreen = new CalculatorScreen(MobileDriver);
            _calculatorScreen.ClearInputField();
        }

        [When(@"I press the add button")]
        public void WhenIPressTheAddButton()
        {
            _calculatorScreen.ClickAdd();
        }
        
        [When(@"I press the calculate button")]
        public void WhenIPressTheCalculateButton()
        {
            _calculatorScreen.Calculate();
        }

        [When(@"I press the subtract button")]
        public void WhenIPressTheSubtractButton()
        {
            _calculatorScreen.ClickSubtract();
        }
        [When(@"I press the multiply button")]
        public void WhenIPressTheMultiplyButton()
        {
            _calculatorScreen.ClickMultiply();
        }

        [When(@"I press the divide button")]
        public void WhenIPressTheDivideButton()
        {
            _calculatorScreen.ClickDivide();
        }
    }
}

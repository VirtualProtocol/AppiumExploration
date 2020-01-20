using OpenQA.Selenium.Appium;

namespace AppiumExploratoration.ScreenObjects
{
    public class CalculatorScreen
    {
        private static AppiumDriver<AppiumWebElement> MobileDriver;

        public CalculatorScreen(AppiumDriver<AppiumWebElement> mobileDriver)
        {
            MobileDriver = mobileDriver;
        }

        public AppiumWebElement InputField => MobileDriver.FindElementByAccessibilityId("Calculator input field");
        public AppiumWebElement BracketsButton => MobileDriver.FindElementByAccessibilityId("Brackets");
        public AppiumWebElement DecimalPointButton => MobileDriver.FindElementByAccessibilityId("Decimal point");
        public AppiumWebElement EqualButton => MobileDriver.FindElementByAccessibilityId("Equal");
        public AppiumWebElement AddButton => MobileDriver.FindElementByAccessibilityId("Plus");
        public AppiumWebElement SubtractButton => MobileDriver.FindElementByAccessibilityId("Minus");
        public AppiumWebElement MultiplyButton => MobileDriver.FindElementByAccessibilityId("Multiplication");
        public AppiumWebElement DivideButton => MobileDriver.FindElementByAccessibilityId("Division");
        public AppiumWebElement ClearButton => MobileDriver.FindElementByAccessibilityId("Clear");

        public string PrintInputFieldText()
        {
            return InputField.Text;
        }

        public void EnterNumber(string number)
        {
            var charArray = number.ToCharArray();

            foreach (var character in charArray)
            {
                if (character == '.')
                    EnterDecimal();
                else if (character == ')' || character == '(')
                    EnterBracket();
                else
                {
                    MobileDriver.FindElementByAccessibilityId(character.ToString()).Click();
                }
            }
        }

        private void EnterBracket()
        {
            BracketsButton.Click();
        }

        private void EnterDecimal()
        {
            DecimalPointButton.Click();
        }

        public void ClickAdd()
        {
            AddButton.Click();
        }

        public void ClickSubtract()
        {
            SubtractButton.Click();
        }

        public void ClickMultiply()
        {
            MultiplyButton.Click();
        }

        public void ClickDivide()
        {
            DivideButton.Click();
        }

        public void Calculate()
        {
            EqualButton.Click();
        }

        public void ClearInputField()
        {
            ClearButton.Click();
        }

        public void AddNumbers(string firstNumber, string secondNumber)
        {
            EnterNumber(firstNumber);
            ClickAdd();
            EnterNumber(secondNumber);
            Calculate();
        }

        public void SubtractNumbers(string firstNumber, string secondNumber)
        {
            EnterNumber(firstNumber);
            ClickSubtract();
            EnterNumber(secondNumber);
            Calculate();
        }

        public void MultiplyNumbers(string firstNumber, string secondNumber)
        {
            EnterNumber(firstNumber);
            ClickMultiply();
            EnterNumber(secondNumber);
            Calculate();
        }

        public void DivideNumbers(string firstNumber, string secondNumber)
        {
            EnterNumber(firstNumber);
            ClickDivide();
            EnterNumber(secondNumber);
            Calculate();
        }
    }
}

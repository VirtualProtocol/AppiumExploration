using AppiumExploratoration.ScreenObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AppiumExploratoration.Tests
{
    public class CalculatorTests : StartUp
    {        
        private static CalculatorScreen _calcScreen { get; set; }

        [SetUp]
        public void Setup()
        {
            _calcScreen = new CalculatorScreen(MobileDriver);
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
        [TestCase("4", "3")]
        [TestCase("6", "6")]
        [TestCase("8", "5")]
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

        [TestCase("20", "2")]
        [TestCase("32", "4")]
        [TestCase("48", "6")]
        [TestCase("96", "8")]
        [TestCase("90", "5")]
        public void WhenTwoNumbersDividedResultIsCorrect(string firstNumber, string secondNumber)
        {
            _calcScreen.DivideNumbers(firstNumber, secondNumber);

            var expected = Convert.ToString(Convert.ToInt32(firstNumber) / Convert.ToInt32(secondNumber));

            Assert.AreEqual(expected, _calcScreen.PrintInputFieldText());
        }
    }
}
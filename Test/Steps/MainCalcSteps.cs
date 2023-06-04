using BoDi;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Test.Constants;
using Test.Forms;

namespace Test.Steps
{
    [Binding]
    public class MainCalcSteps
    {
        private readonly MainCalcForm _mainCalcForm;

        public MainCalcSteps(IObjectContainer objectContainer)
        {
            _mainCalcForm = objectContainer.Resolve<MainCalcForm>();
        }

        [Given(@"Main form is open")]
        public void CheckThatMainFormIsPresent() 
        {
            bool isFormVisible = _mainCalcForm.IsFormVisible();
            Assert.IsTrue(isFormVisible, $"Form {_mainCalcForm.FormName} isn't visible");
        }

        [Then(@"I click on numbers (.*)")]
        [When(@"I click on numbers (.*)")]
        public void ClickOnNumber(string splitedNumbers)
        {
            string[] numbers = splitedNumbers.Split(new char[] {' '}, StringSplitOptions.None);
            foreach (string number in numbers)
            {
                _mainCalcForm.ClickOnNumber(number);
            }
           
        }

        [Then(@"the result of math should be (.*)")]
        public void CheckMathResult(string expectedResult)
        {
            var amount = _mainCalcForm.GetResultSum();
            Assert.AreEqual(amount, expectedResult, $"The total result isn't correct");
        }

        [When(@"I click on (.*) menu bar")]
        public void OpenMenuBar(string menuBarItemName)
        {
            _mainCalcForm.ClickOnMenuBar((MenuBarItem)Enum.Parse(typeof(MenuBarItem), menuBarItemName));
        }

        [Then(@"I select option (.*) from View menu bar")]
        public void SelectOptionFromMenuBar(string option)
        {
            _mainCalcForm.ChooseOptionFromMenuBar(option);
        }

        [Then(@"I add result to memory")]
        public void ClickOnMPlus()
        {
            _mainCalcForm.ClickOnMPlus();
        }

        [Then(@"I get saved result")]
        public void ClickOnMR()
        {
            _mainCalcForm.ClickOnMR();
        }

        [Then(@"I click on Plus")]
        public void ClickOnPlus()
        {
            _mainCalcForm.ClickOnPlus();
        }

        [When(@"I click on equals")]
        public void ClickOnEqual()
        {
            _mainCalcForm.ClickOnEquals();
        }
    }
}
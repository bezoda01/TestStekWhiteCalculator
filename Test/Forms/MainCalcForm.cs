using Framework.ApplicationWrapper;
using Framework.Elements;
using Framework.Form;
using Framework.WindowElement;
using Test.Constants;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowStripControls;

namespace Test.Forms
{
    internal class MainCalcForm : BaseForm
    {
        private WFTextView _resultSumTextView => new WFTextView(formWindow.GetElement(SearchCriteria.ByAutomationId("158")), "Result sum text view");
        private WFMenuBar _orientationMebuBar => new WFMenuBar(formWindow.GetMenuBar(SearchCriteria
            .ByAutomationId("MenuBar")
            .AndByText("Application")),
            "OrientationMenuBar");
        private WFButton NumberButton(string number) => new WFButton(formWindow.GetElement(SearchCriteria.ByAutomationId($"13{number}")), "Number Button");
        private WFButton ViewOptionButton(string option) => new WFButton(formWindow.GetElement(SearchCriteria.ByText(option)), $"{option} Button");

        public MainCalcForm() :
            base(new WFWindow(WFApplication.GetInstance().GetWindowByName(WindowConstants.CalculatorMainWindow)),
                "Calculator main form")
        {
        }

        public void ClickOnNumber(string number) 
        {
            NumberButton(number).Click();
        }

        public string GetResultSum() 
        {
            return _resultSumTextView.GetText();
        }

        public void ClickOnMenuBar(MenuBarItem menuBarItem)
        {
            _orientationMebuBar.ClickChildMenuItem(menuBarItem.ToString());
        }

        public void ChooseOptionFromMenuBar(string option) 
        {
            ViewOptionButton(option).Click();
        }

        public void ClickOnMPlus()
        {
            new WFButton(formWindow.GetElement(SearchCriteria.ByAutomationId("125")), "M+ Button").Click();
        }

        public void ClickOnMR()
        {
            new WFButton(formWindow.GetElement(SearchCriteria.ByAutomationId("123")), "MR Button").Click();
        }

        public void ClickOnPlus()
        {
            new WFButton(formWindow.GetElement(SearchCriteria.ByAutomationId("93")), "Plus Button").Click();
        }

        public void ClickOnEquals()
        {
            new WFButton(formWindow.GetElement(SearchCriteria.ByAutomationId("121")), "MR Button").Click();
        }
    }
}
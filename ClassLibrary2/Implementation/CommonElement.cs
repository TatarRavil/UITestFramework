using OpenQA.Selenium;

namespace CommonLibs.Implementation
{
    public class CommonElement
    {
        public void ClickElement(IWebElement element) => element.Click();

        public void ClearElement(IWebElement element) => element.Clear();

        public void SetText(IWebElement element, string text) => element.SendKeys(text);

        public bool elementIsDisplay(IWebElement element) => element.Displayed;

        public bool elementIsDisplayed(IWebElement element) => element.Displayed;

        public bool elementIsSelected(IWebElement element) => element.Selected;

        public bool elementIsEnabled(IWebElement element) => element.Enabled;
    }



}

using OpenQA.Selenium;

namespace AplicationLayer.Pages
{
    public class LoginPage : BasePage
    {
        private readonly IWebDriver driver;
        private IWebElement Username => driver.FindElement(By.Id("username"));
        private IWebElement Password => driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => driver.FindElement(By.Id("_submit"));

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Login(string username, string password)
        {
            CommonElement.SetText(Username, username);
            CommonElement.SetText(Password, password);
            CommonElement.ClickElement(LoginButton);
        }
    }
}
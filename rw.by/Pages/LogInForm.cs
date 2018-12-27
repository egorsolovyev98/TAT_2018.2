using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pages
{
    public class LogInForm
    {
        private IWebDriver _driver;
        private By _logInElement = By.XPath("//*[@id=\"login\"]");
        private By _passwordElement = By.XPath("//*[@id=\"password\"]");
        private By _submitButton = By.XPath("//*[@class=\"commandExButton\"]");

        public LogInForm(ChromeDriver driver)
        {
            _driver = driver;
        }

        public void LogIn(string login, string password)
        {
            _driver.FindElement(_logInElement).SendKeys(login);
            _driver.FindElement(_passwordElement).SendKeys(password);
            _driver.FindElement(_submitButton).Click();
        }

    }
}
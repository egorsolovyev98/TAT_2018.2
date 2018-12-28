using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class LogInForm
    {
        private IWebDriver _driver;
        private By _logInElement = By.XPath("//input[@id='login']");
        private By _passwordElement = By.XPath("//input[@id='password']");
        private By _submitButton = By.XPath("//input[@class='commandExButton']");

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
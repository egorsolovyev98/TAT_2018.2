using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pages
{
    public class MainPageForm
    {
        private IWebDriver _driver;

        private readonly By _login = By.XPath("//a[1]/b");

        public MainPageForm(ChromeDriver driver)
        {
            _driver = driver;
        }

        public void GoToLogIn()
        {
            _driver.FindElement(_login).Click();
        }
    }
}

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pages
{
    public class AsseptRulesForm
    {
        private IWebDriver _driver;
        private By _submitButton = By.XPath("//input[@type='checkbox']");

        public AsseptRulesForm(ChromeDriver driver)
        {
            _driver = driver;
        }

        public void ClickOnSubmitButton()
        {
            _driver.FindElement(_submitButton).Click();
        }
    }
}

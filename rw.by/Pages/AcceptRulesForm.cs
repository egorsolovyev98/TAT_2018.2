using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pages
{
    /// <summary>
    /// Accept rules form.
    /// </summary>
    public class AcceptRulesForm
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver _driver;


        /// <summary>
        /// The submit button.
        /// </summary>
        private By _submitButton = By.XPath("//input[@type='checkbox']");


        /// <summary>
        /// Initializes a new instance of the <see cref="T:Pages.AcceptRulesForm"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public AcceptRulesForm(ChromeDriver driver)
        {
            _driver = driver;
        }


        /// <summary>
        /// Clicks the on submit button.
        /// </summary>
        public void ClickOnSubmitButton()
        {
            _driver.FindElement(_submitButton).Click();
        }
    }
}
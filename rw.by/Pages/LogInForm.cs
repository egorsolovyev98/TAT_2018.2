using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pages
{
    /// <summary>
    /// Log in form.
    /// </summary>
    public class LogInForm
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver _driver;


        /// <summary>
        /// The log in element.
        /// </summary>
        private By _logInElement = By.XPath("//input[@id='login']");


        /// <summary>
        /// The password element.
        /// </summary>
        private By _passwordElement = By.XPath("//input[@id='password']");


        /// <summary>
        /// The submit button.
        /// </summary>
        private By _submitButton = By.XPath("//input[@class='commandExButton']");


        /// <summary>
        /// Initializes a new instance of the <see cref="T:Pages.LogInForm"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public LogInForm(ChromeDriver driver)
        {
            _driver = driver;
        }


        /// <summary>
        /// Log in.
        /// </summary>
        /// <param name="login">Login.</param>
        /// <param name="password">Password.</param>
        public void LogIn(string login, string password)
        {
            _driver.FindElement(_logInElement).SendKeys(login);
            _driver.FindElement(_passwordElement).SendKeys(password);
            _driver.FindElement(_submitButton).Click();
        }

    }
}
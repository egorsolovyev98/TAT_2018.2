using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace task_DEV9
{
    /// <summary>
    /// Log in form.
    /// </summary>
    public class LogInForm
    {
        /// <summary>
        /// The driver.
        /// </summary>
        IWebDriver _driver;

        /// <summary>
        /// The login.
        /// </summary>
        private string login = "login"; 


        /// <summary>
        /// The password.
        /// </summary>
        private string password = "password";


        /// <summary>
        /// The login element.
        /// </summary>
        private By _logInElement = By.XPath("//*[@id='index_email']");


        /// <summary>
        /// The password element.
        /// </summary>
        private By _passwordElement = By.XPath("//*[@id='index_pass']");


        /// <summary>
        /// The submit button.
        /// </summary>
        private By _submitButton = By.XPath("//*[@id='index_login_button']");


        /// <summary>
        /// Initializes a new instance of the <see cref="T:task_DEV9.LogInForm"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public LogInForm(ChromeDriver driver)
        {
            _driver = driver;
        }


        /// <summary>
        /// Logs in.
        /// </summary>
        public void LogIn()
        {
            _driver.FindElement(_logInElement).SendKeys(login);
            _driver.FindElement(_passwordElement).SendKeys(password);
            _driver.FindElement(_submitButton).Click();
        }
    }
}
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pages
{
    /// <summary>
    /// Main page form.
    /// </summary>
    public class MainPageForm
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver _driver;


        /// <summary>
        /// The login.
        /// </summary>
        private readonly By _login = By.XPath("//a[1]/b");


        /// <summary>
        /// Initializes a new instance of the <see cref="T:Pages.MainPageForm"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public MainPageForm(ChromeDriver driver)
        {
            _driver = driver;
        }


        /// <summary>
        /// Goes to log in.
        /// </summary>
        public void GoToLogIn()
        {
            _driver.FindElement(_login).Click();
        }
    }
}
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages;

namespace BusinessLogic
{
    /// <summary>
    /// Log in.
    /// </summary>
    public class LogIn
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private ChromeDriver _driver;


        /// <summary>
        /// Initializes a new instance of the <see cref="T:BusinessLogic.LogIn"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public LogIn (ChromeDriver driver)
        {
            _driver = driver;
        }


        /// <summary>
        /// Logs the in with parametors.
        /// </summary>
        /// <param name="login">Login.</param>
        /// <param name="password">Password.</param>
        public void LogInWithParametors(string login, string password)
        {
            MainPageForm mainPageForm = new MainPageForm(_driver);
            mainPageForm.GoToLogIn();

            LogInForm logInForm = new LogInForm(_driver);
            logInForm.LogIn(login, password);
        }


        /// <summary>
        /// Assepts the rules.
        /// </summary>
        public void AcceptRules()
        {
            new AcceptRulesForm(_driver).ClickOnSubmitButton();
        }


    }
}

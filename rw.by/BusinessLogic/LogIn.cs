using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages;

namespace BusinessLogic
{
    public class LogIn
    {
        private ChromeDriver _driver;

        public LogIn (ChromeDriver driver)
        {
            _driver = driver;
        }

        public void LogInWithParametors(string login, string password)
        {
            MainPageForm mainPageForm = new MainPageForm(_driver);
            mainPageForm.GoToLogIn();

            LogInForm logInForm = new LogInForm(_driver);
            logInForm.LogIn(login, password);
        }

        public void AsseptRules()
        {
            new AsseptRulesForm(_driver).ClickOnSubmitButton();
        }


    }
}

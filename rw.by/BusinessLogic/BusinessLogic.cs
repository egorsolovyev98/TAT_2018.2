using OpenQA.Selenium.Chrome;
using Pages;

namespace BusinessLogic
{
    public class BusinessLogic
    {
        private string login = "egorsolovyev98";
        private string password = "egorsolovyev98";

        public void LogIn()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Url = "poezd.rw.by";

            MainPageForm mainPageForm = new MainPageForm(driver);
            mainPageForm.GoToLogIn();

            LogInForm logInForm = new LogInForm(driver);
            logInForm.LogIn(login, password);
        }
    }
}

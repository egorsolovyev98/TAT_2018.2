using OpenQA.Selenium.Chrome;
using System;

namespace task_DEV9
{
    /// <summary>
    /// Entry point.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://vk.com/";

            LogInForm logInForm = new LogInForm(driver);
            logInForm.LogIn();

            MainPageForm mainPageForm = new MainPageForm(driver);
            mainPageForm.GoToMessages();

            MessagesForm messagesForm = new MessagesForm(driver);
            var messages = messagesForm.GetUnreadMessages();

            foreach (var i in messages)
            {
                Console.WriteLine(i);
            }
        }
    }
}
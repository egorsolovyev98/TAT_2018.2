using NUnit.Framework;
using BusinessLogic;
using OpenQA.Selenium.Chrome;
using System;

namespace task_DEV10
{
    [TestFixture]
    public class LoginTest
    {
        private ChromeDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            _driver.Url = "https://poezd.rw.by";
        }

        [TearDown]
        public void After()
        {
            _driver.Quit();
        }

        [Test]
        [TestCase("egorsolovyev98", "egorsolovyev98")]
        public void Login_PositiveTests(string login, string password)
        {
            LogIn logic = new LogIn(_driver);
            logic.LogInWithParametors(login, password);

            Assert.True(_driver.Url.Contains("/rp/buyTicket"));
        }

        [Test]
        [TestCase("asd", "asd")]
        [TestCase("", "df123")]
        [TestCase("kjhdf324", "")]
        public void Login_NegativeTests(string login, string password)
        {
            LogIn logic = new LogIn(_driver);
            logic.LogInWithParametors(login, password);

            Assert.IsFalse(_driver.Url.Contains("/rp/buyTicket"));
        }


    }
}
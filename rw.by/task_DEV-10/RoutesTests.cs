using System;
using BusinessLogic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace task_DEV10
{
    [TestFixture]
    public class RoutesTests
    {
        private ChromeDriver _driver;
        private string _login = "egorsolovyev98";
        private string _password = "egorsolovyev98";

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            _driver.Url = "https://poezd.rw.by";

            LogIn login = new LogIn(_driver);
            login.LogInWithParametors(_login, _password);
            login.AcceptRules();
        }

        [TearDown]
        public void After()
        {
            _driver.Quit();
        }

        [Test]
        [TestCase("МИНСК-ПАССАЖИРСКИЙ", "ГРОДНО", "29.12.2018")]
        public void Routes_PositiveTests(string departure, string destination, string date)
        {

            Routes routes = new Routes(_driver);
            routes.FindTicket(departure, destination, date);
            string actualResult = _driver.FindElement(By.XPath("//*[@id=\"viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:text1\"]")).Text;

            Assert.AreEqual("Маршрут следования пассажира:", actualResult);
        }

        [Test]
        [TestCase("", "ГРОДНО", "29.12.2018")]
        [TestCase("МИНСК-ПАССАЖИРСКИЙ", "", "31.12.2018")]
        [TestCase("МИНСК-ПАССАЖИРСКИЙ", "ГРОДНО", "20.12.2018")]
        public void Routes_NegativeTests(string departure, string destination, string date)
        {
            Routes routes = new Routes(_driver);
            routes.FindTicket(departure, destination, date);

            bool actualResult = _driver.FindElement(By.XPath("//span[@class='red warIcon']")).Enabled;
            Assert.True(actualResult);
        }
    }
}
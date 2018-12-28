using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pages
{
    public class RoutesForm
    {
        //*[@id="viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:form1:dob"]
        private IWebDriver _driver;
        private By _departureStation = By.Id("viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:form1:textDepStat");
        private By _destinationStation = By.Id("viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:form1:textArrStat");
        private By _date = By.Id("viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:form1:dob");
        private By _alltime = By.XPath("//span[contains(text(),'Выбрать всё ')]");
        private By _submitButton = By.XPath("//input[@class='commandExButton']");

        public RoutesForm(ChromeDriver driver)
        {
            _driver = driver;
        }

        public void SetDepartureStation(string station)
        {
            _driver.FindElement(_departureStation).SendKeys(station);
        }

        public void SetDestinationStation(string station)
        {
            _driver.FindElement(_destinationStation).SendKeys(station);
        }

        public void SetData(string date)
        {
            _driver.FindElement(_date).Clear();
            _driver.FindElement(_date).SendKeys(date);
        }

        public void ClickAllTimeButton()
        {
            _driver.FindElement(_alltime).Click();
        }

        public void ClickSubmitButton()
        {
            _driver.FindElement(_submitButton).Click();
        }
    }
}

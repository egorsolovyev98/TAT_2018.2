using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pages
{
    /// <summary>
    /// Routes form.
    /// </summary>
    public class RoutesForm
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver _driver;


        /// <summary>
        /// The departure station.
        /// </summary>
        private By _departureStation = By.Id("viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:form1:textDepStat");


        /// <summary>
        /// The destination station.
        /// </summary>
        private By _destinationStation = By.Id("viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:form1:textArrStat");


        /// <summary>
        /// The date.
        /// </summary>
        private By _date = By.Id("viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_:form1:dob");


        /// <summary>
        /// The alltime.
        /// </summary>
        private By _alltime = By.XPath("//span[contains(text(),'Выбрать всё ')]");


        /// <summary>
        /// The submit button.
        /// </summary>
        private By _submitButton = By.XPath("//input[@class='commandExButton']");

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Pages.RoutesForm"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public RoutesForm(ChromeDriver driver)
        {
            _driver = driver;
        }


        /// <summary>
        /// Sets the departure station.
        /// </summary>
        /// <param name="station">Station.</param>
        public void SetDepartureStation(string station)
        {
            _driver.FindElement(_departureStation).SendKeys(station);
        }


        /// <summary>
        /// Sets the destination station.
        /// </summary>
        /// <param name="station">Station.</param>
        public void SetDestinationStation(string station)
        {
            _driver.FindElement(_destinationStation).SendKeys(station);
        }


        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="date">Date.</param>
        public void SetData(string date)
        {
            _driver.FindElement(_date).Clear();
            _driver.FindElement(_date).SendKeys(date);
        }


        /// <summary>
        /// Clicks all time button.
        /// </summary>
        public void ClickAllTimeButton()
        {
            _driver.FindElement(_alltime).Click();
        }


        /// <summary>
        /// Clicks the submit button.
        /// </summary>
        public void ClickSubmitButton()
        {
            _driver.FindElement(_submitButton).Click();
        }
    }
}
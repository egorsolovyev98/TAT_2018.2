using System;
using OpenQA.Selenium.Chrome;
using Pages;

namespace BusinessLogic
{
    /// <summary>
    /// Routes.
    /// </summary>
    public class Routes
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private ChromeDriver _driver;


        /// <summary>
        /// Initializes a new instance of the <see cref="T:BusinessLogic.Routes"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public Routes(ChromeDriver driver)
        {
            _driver = driver;
        }


        /// <summary>
        /// Finds the ticket.
        /// </summary>
        /// <param name="departure">Departure.</param>
        /// <param name="destination">Destination.</param>
        /// <param name="date">Date.</param>
        public void FindTicket(string departure, string destination, string date)
        {
            RoutesForm routesForm = new RoutesForm(_driver);
            routesForm.SetDepartureStation(departure);
            routesForm.SetDestinationStation(destination);
            routesForm.SetData(date);
            routesForm.ClickAllTimeButton();
            routesForm.ClickSubmitButton();
        }
    }
}

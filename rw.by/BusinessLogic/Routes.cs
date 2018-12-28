using System;
using OpenQA.Selenium.Chrome;
using Pages;

namespace BusinessLogic
{
    public class Routes
    {
        private ChromeDriver _driver;

        public Routes(ChromeDriver driver)
        {
            _driver = driver;
        }

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

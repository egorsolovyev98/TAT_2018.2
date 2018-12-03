using System;

namespace task_DEV5
{
    /// <summary>
    /// Calls the counting all cars method.
    /// </summary>
    public class CountAllCommand : ICommand
    {
        /// <summary>
        /// The car catalog.
        /// </summary>
        private CarCatalog carCatalog;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="carCatalog">Car catalog.</param>
        public CountAllCommand(CarCatalog carCatalog)
        {
            this.carCatalog = carCatalog;
        }


        /// <summary>
        /// Execute this instance.
        /// </summary>
        public void Execute()
        {
            int amountOfCars = carCatalog.AmountOfAllCars();
            Console.WriteLine(amountOfCars);
        }
    }
}
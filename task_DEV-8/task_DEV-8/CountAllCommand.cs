using System;

namespace task_DEV8
{
    /// <summary>
    /// Calls the counting all cars method.
    /// </summary>
    public class CountAllCommand : ICommand
    {
        /// <summary>
        /// The car catalog.
        /// </summary>
        private VehicleCatalog carCatalog;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="carCatalog">Car catalog.</param>
        public CountAllCommand(VehicleCatalog carCatalog)
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
using System;

namespace task_DEV8
{
    /// <summary>
    /// Calls the counting average price method.
    /// </summary>
    public class AveragePriceCommand : ICommand
    {
        /// <summary>
        /// The car catalog.
        /// </summary>
        private VehicleCatalog carCatalog;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="carCatalog">Car catalog.</param>
        public AveragePriceCommand(VehicleCatalog carCatalog)
        {
            this.carCatalog = carCatalog;
        }


        /// <summary>
        /// Execute this instance.
        /// </summary>
        public void Execute()
        {
            double averagePrice = carCatalog.AveragePrice();
            Console.WriteLine(averagePrice);
        }
    }
}
using System;

namespace task_DEV8
{
    /// <summary>
    /// Calls the counting types method.
    /// </summary>
    public class CountTypesCommand : ICommand
    {
        /// <summary>
        /// The car catalog.
        /// </summary>
        private VehicleCatalog carCatalog;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="carCatalog">Car catalog.</param>
        public CountTypesCommand(VehicleCatalog carCatalog)
        {
            this.carCatalog = carCatalog;
        }


        /// <summary>
        /// Execute this instance.
        /// </summary>
        public void Execute()
        {
            int amountOfBrands = carCatalog.AmountOfBrands();
            Console.WriteLine(amountOfBrands);
        }
    }
}
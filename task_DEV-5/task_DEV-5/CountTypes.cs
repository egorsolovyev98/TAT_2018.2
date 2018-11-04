using System;

namespace task_DEV5
{
    /// <summary>
    /// Calls the counting types method.
    /// </summary>
    public class CountTypes : ICommand
    {
        /// <summary>
        /// The car catalog.
        /// </summary>
        private CarCatalog carCatalog;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="carCatalog">Car catalog.</param>
        public CountTypes(CarCatalog carCatalog)
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
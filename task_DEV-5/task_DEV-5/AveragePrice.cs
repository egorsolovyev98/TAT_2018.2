﻿using System;

namespace task_DEV5
{
    /// <summary>
    /// Calls the counting average price method.
    /// </summary>
    public class AveragePrice : ICommand
    {
        /// <summary>
        /// The car catalog.
        /// </summary>
        private CarCatalog carCatalog;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="carCatalog">Car catalog.</param>
        public AveragePrice(CarCatalog carCatalog)
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
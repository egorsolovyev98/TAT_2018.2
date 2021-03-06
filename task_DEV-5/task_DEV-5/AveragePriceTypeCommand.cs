﻿using System;

namespace task_DEV5
{
    public class AveragePriceTypeCommand : ICommand
    {
        /// <summary>
        /// The car catalog.
        /// </summary>
        private CarCatalog carCatalog;


        /// <summary>
        /// The brand.
        /// </summary>
        private string brand;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="carCatalog">Car catalog.</param>
        /// <param name="brand">Brand.</param>
        public AveragePriceTypeCommand(CarCatalog carCatalog, string brand)
        {
            this.carCatalog = carCatalog;
            this.brand = brand;
        }


        /// <summary>
        /// Execute this instance.
        /// </summary>
        public void Execute()
        {
            double averageBrandPrice = carCatalog.AverageBrandPrice(brand);
            Console.WriteLine(averageBrandPrice);
        }
    }
}
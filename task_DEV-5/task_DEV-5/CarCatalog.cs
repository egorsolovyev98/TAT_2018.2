using System;
using System.Collections.Generic;
using System.Linq;

namespace task_DEV5
{
    /// <summary>
    /// Car catalog.
    /// </summary>
    public class CarCatalog
    {
        /// <summary>
        /// The cars list.
        /// </summary>
        private List<Car> carsList;


        /// <summary>
        /// Constructor.
        /// </summary>
        public CarCatalog()
        {
            carsList = new List<Car>();
        }


        /// <summary>
        /// Adds to catalog.
        /// </summary>
        /// <param name="car">Car.</param>
        public void AddToCatalog(Car car)
        {
            bool isTheSameCar = carsList.Any(i => (i.Brand == car.Brand) && (i.Model == car.Model) && (i.Price == car.Price));
            bool wrongPrice = carsList.Any(i => (i.Brand == car.Brand) && (i.Model == car.Model) && (i.Price != car.Price));

            if (wrongPrice)
            {
                throw new Exception("Different prices for the same car.");
            }

            if (isTheSameCar)
            {
                Car carFromList = carsList.First(i => (i.Brand == car.Brand) && (i.Model == car.Model) && (i.Price == car.Price));
                carFromList.Amount += car.Amount;
            }
            else
            {
                carsList.Add(car);
            }
        }


        /// <summary>
        /// Calculate the amount of brands.
        /// </summary>
        /// <returns>The amount of different brands.</returns>
        public int AmountOfBrands()
        {
            int amountOfBrands = carsList.GroupBy(i => i.Brand).Count();

            return amountOfBrands;
        }


        /// <summary>
        /// Calculate the amount of all cars.
        /// </summary>
        /// <returns>The amount of all cars.</returns>
        public int AmountOfAllCars()
        {
            int amountOfAllCars = carsList.Select(i => i.Amount).Sum(x => x);

            return amountOfAllCars;
        }


        /// <summary>
        /// Calculate the average price.
        /// </summary>
        /// <returns>The average price.</returns>
        public double AveragePrice()
        {
            double averagePrice = carsList.Select(i => i.Price).Average(x => x);

            return averagePrice;
        }


        /// <summary>
        /// Calculate the average brand price.
        /// </summary>
        /// <returns>The average brand price.</returns>
        /// <param name="brand">Brand.</param>
        public double AverageBrandPrice(string brand)
        {
            bool listContainsBrand = carsList.Select(i => i.Brand).Contains(brand);

            if (!listContainsBrand)
            {
                throw new Exception($"Catalog doesn't contain {brand}");
            }

            double averageBrandPrice = carsList.Where(i => i.Brand == brand).Select(i => i.Price).Average(x => x);

            return averageBrandPrice;
        }
    }
}
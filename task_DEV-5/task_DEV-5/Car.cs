using System;

namespace task_DEV5
{
    /// <summary>
    /// Car.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// The minimum amount.
        /// </summary>
        private const int MinAmount = 1;


        /// <summary>
        /// The minimum price.
        /// </summary>
        private const int MinPrice = 0;


        /// <summary>
        /// Gets or sets the brand.
        /// </summary>
        /// <value>The brand.</value>
        public string Brand { get; set; }


        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        public string Model { get; set; }


        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public int Amount { get; set; }


        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public double Price { get; set; }


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="brand">Brand.</param>
        /// <param name="model">Model.</param>
        /// <param name="amount">Amount.</param>
        /// <param name="price">Price.</param>
        public Car(string brand, string model, int amount, double price)
        {
            if ((brand == string.Empty) || (model == string.Empty) || (amount < MinAmount) || (price <= MinPrice))
            {
                throw new ArgumentException("Wrong argument.");
            }

            Brand = brand;
            Model = model;
            Amount = amount;
            Price = price;
        }
    }
}
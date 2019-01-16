namespace task_DEV8
{
    /// <summary>
    /// Truck.
    /// </summary>
    public class Truck : Vehicle
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="brand">Brand.</param>
        /// <param name="model">Model.</param>
        /// <param name="amount">Amount.</param>
        /// <param name="price">Price.</param>
        public Truck(string brand, string model, int amount, double price) : base(brand, model, amount, price) { }
    }
}
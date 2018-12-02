namespace task_DEV8
{
    /// <summary>
    /// Car.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="brand">Brand.</param>
        /// <param name="model">Model.</param>
        /// <param name="amount">Amount.</param>
        /// <param name="price">Price.</param>
        public Car(string brand, string model, int amount, double price) : base (brand, model, amount, price) {}
    }
}
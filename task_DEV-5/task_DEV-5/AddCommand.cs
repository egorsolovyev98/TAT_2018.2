namespace task_DEV5
{
    /// <summary>
    /// Calls the adding car method.
    /// </summary>
    public class AddCommand : ICommand
    {
        /// <summary>
        /// The car catalog.
        /// </summary>
        private CarCatalog carCatalog;


        /// <summary>
        /// The car.
        /// </summary>
        private Car car;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="carCatalog">Car catalog.</param>
        /// <param name="car">Car.</param>
        public AddCommand(CarCatalog carCatalog, Car car)
        {
            this.carCatalog = carCatalog;
            this.car = car;
        }


        /// <summary>
        /// Execute this instance.
        /// </summary>
        public void Execute()
        {
            carCatalog.AddToCatalog(car);
        }
    }
}
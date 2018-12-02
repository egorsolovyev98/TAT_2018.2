namespace task_DEV8
{
    /// <summary>
    /// Calls the adding car method.
    /// </summary>
    public class AddCommand : ICommand
    {
        /// <summary>
        /// The car catalog.
        /// </summary>
        private VehicleCatalog vehicleCatalog;


        /// <summary>
        /// The car.
        /// </summary>
        private Vehicle vehicle;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="vehicleCatalog">Car catalog.</param>
        /// <param name="vehicle">Car.</param>
        public AddCommand(VehicleCatalog vehicleCatalog, Vehicle vehicle)
        {
            this.vehicleCatalog = vehicleCatalog;
            this.vehicle = vehicle;
        }


        /// <summary>
        /// Execute this instance.
        /// </summary>
        public void Execute()
        {
            vehicleCatalog.AddToCatalog(vehicle);
        }
    }
}
using System;

namespace task_DEV8
{
    /// <summary>
    /// Entry point.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.No arguments used.</param>
        public static void Main(string[] args)
        {
            try
            {
                var vehicleXMLParser = new VehicleXMLParser();
                var carCatalog = new VehicleCatalog(vehicleXMLParser.GetVehicles(args[0]));
                var truckCatalog = new VehicleCatalog(vehicleXMLParser.GetVehicles(args[1]));

                Menu menu = new Menu(carCatalog, truckCatalog);
                menu.Run();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error. " + e.Message);
            }
        }
    }
}
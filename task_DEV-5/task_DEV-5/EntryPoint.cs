using System;

namespace task_DEV5
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
                CarCatalog carCatalog = new CarCatalog();
                Menu menu = new Menu(carCatalog);
                menu.Show();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error. " + e.Message);
            }
        }
    }
}
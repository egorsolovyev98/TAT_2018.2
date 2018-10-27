using System;

namespace lab_Car
{
    /// <summary>
    /// Entry point.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                MyList list = new MyList();

                list.AddHead(new Car("BMW", "X5", "Black"));
                list.AddHead(new Car("BMW", "X6", "White"));
                list.AddHead(new Car("Mazda", "6", "Red"));
                list.AddHead(new Car("Pagani", "Huaira", "Yellow"));

                MyList searchList = list.Search(new Car("BMW", "5", "Green"));
            }
            catch(Exception e)
            {
                Console.Error.WriteLine("Error: " + e.Message);
            }
        }
    }
}
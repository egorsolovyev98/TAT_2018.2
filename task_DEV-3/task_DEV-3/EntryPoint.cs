using System;

namespace task_DEV3
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
                if (args.Length != 2)
                {
                    throw new Exception("wrong number of arguments.");
                }

                int inputValue = Convert.ToInt32(args[0]);
                int newRadix = Convert.ToInt32(args[1]);
                string inputValueInNewRadix = inputValue.ToNewRadix(newRadix);

                Console.WriteLine(inputValueInNewRadix);
            }
            catch(Exception e)
            {
                Console.Error.WriteLine("Error: " + e.Message);
            }
        }
    }
}
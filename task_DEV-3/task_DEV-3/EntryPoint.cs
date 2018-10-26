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
                InputChecker input = new InputChecker(args);
                string inputValueInNewRadix = input.inputValue.ToNewRadix(input.newRadix);

                Console.WriteLine($"Input value = {input.inputValue} ,radix = 10.");
                Console.WriteLine($"Input value = {inputValueInNewRadix} ,radix = {input.newRadix}.");
            }
            catch(Exception e)
            {
                Console.Error.WriteLine("Error: " + e.Message);
            }
        }
    }
}
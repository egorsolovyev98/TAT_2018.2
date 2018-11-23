using System;

namespace task_DEV3
{
    /// <summary>
    /// Entry point.
    /// </summary>
    public class EntryPoint
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">Integer value and integer radix.</param>
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    throw new Exception("Wrong number of arguments.");
                }

                int inputValue = Convert.ToInt32(args[0]);
                int newRadix = Convert.ToInt32(args[1]);

                const int MinRadixByCondition = 2;
                const int MaxRadixByCondition = 20;

                if (newRadix < MinRadixByCondition || newRadix > MaxRadixByCondition)
                {
                    throw new ArgumentException("Wrong radix.");
                }
                string inputValueInNewRadix = inputValue.ToNewRadix(newRadix);

                Console.WriteLine($"Input value = {inputValue} ,radix = 10.");
                Console.WriteLine($"Input value = {inputValueInNewRadix} ,radix = {newRadix}.");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error: " + e.Message);
            }
        }
    }
}
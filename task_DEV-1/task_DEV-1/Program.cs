using System;

namespace task_DEV1
{
    /// <summary>
    /// The MaxNumberOfDifferentCharacters class accepts a sequence of characters (a string) 
    /// as an argument from the command line, and which displays to the console 
    /// the maximum number of unique consecutive characters in a string
    /// </summary>
    class MaxNumberOfUniqueCharacters
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    throw new Exception("Wrong number of arguments");
                }
                
                string inputString = args.ArrayToString(); // Form string from arguments array
                int lengthOfSequence = inputString.GetLengthOfSequence();

                Console.WriteLine(lengthOfSequence);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
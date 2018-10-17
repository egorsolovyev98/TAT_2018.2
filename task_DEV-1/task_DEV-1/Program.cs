using System;

namespace task_DEV1
{
    class MaxNumberOfDifferentCharacters
    {
        /// <summary>
        /// The MaxNumberOfDifferentCharacters class accepts a sequence of characters (a string) 
        /// as an argument from the command line, and which displays to the console 
        /// the maximum number of different consecutive characters in a string
        /// </summary>
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

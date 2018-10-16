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
                if (args.Length != 1)
                {
                    throw new Exception("Wrong number of arguments");
                }

                int length = args[0].GetLengthOfSequence();
                Console.WriteLine(length);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}

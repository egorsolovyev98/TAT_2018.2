using System;

namespace EqualCharactersInString
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
                string inputString = Console.ReadLine();

                EqualCharactersFinder equalCharactersFinder = new EqualCharactersFinder();
                equalCharactersFinder.FindNumberOfEqualCharacters(inputString);
                equalCharactersFinder.PrintResult();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}
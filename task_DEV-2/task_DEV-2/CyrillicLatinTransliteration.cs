using System;

namespace task_DEV2
{
    /// <summary>
    /// Cyrillic-latin and latin-cyrillic transliteration.
    /// </summary>
    class CyrillicLatinTransliteration
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                {
                    throw new Exception("Wrong number of arguments");
                }

                string inputString = args[0].ToLower();
                string transliteratedString = inputString.Transliterate();

                Console.WriteLine(transliteratedString);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
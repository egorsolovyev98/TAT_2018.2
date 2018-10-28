using System;
using System.Collections.Generic;

namespace task_DEV4
{
    /// <summary>
    /// XML parsing program.
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
                if (args.Length != 1)
                {
                    throw new Exception("wrong numer of arguments.");
                }

                string path = args[0];
                XmlParser parser = new XmlParser(path);
                List<string> list = parser.xmlElements.SortXmlElements();

                foreach(string i in list)
                {
                    Console.WriteLine(i);
                }
            }
            catch(Exception e)
            {
                Console.Error.WriteLine("Error: " + e.Message);
            }
        }
    }
}
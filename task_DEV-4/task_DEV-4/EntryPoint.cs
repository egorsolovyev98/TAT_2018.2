using System;
using System.Collections.Generic;

namespace task_DEV4
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
                /*if (args.Length != 1)
                {
                    throw new Exception("wrong numer of arguments.");
                }*/

                string path = "/Users/egorsolovev/Projects/task_DEV-4/file3.xml";
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
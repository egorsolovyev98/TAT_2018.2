using System;
using System.IO;

namespace task_DEV6
{
    /// <summary>
    /// Entry point.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Converts XML/JSON filse to JSON/XML.
        /// </summary>
        /// <param name="args">File paths.</param>
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    throw new Exception("Wrong number of arguments.");
                }

                foreach(string filePath in args)
                {
                    if (Path.GetExtension(filePath).Equals(".xml"))
                    {
                        XmlToJsonParser xmlToJsonParser = new XmlToJsonParser(filePath);
                        xmlToJsonParser.ReadFile();

                        FileWritter fileWritter = new FileWritter(filePath, xmlToJsonParser.Parse());
                        fileWritter.ChangeFileExtension("json");
                        fileWritter.WriteFile();
                    }
                    else if (Path.GetExtension(filePath).Equals(".json"))
                    {
                        JsonToXmlParser jsonToXmlParser = new JsonToXmlParser(filePath);
                        jsonToXmlParser.ReadFile();

                        FileWritter fileWritter = new FileWritter(filePath, jsonToXmlParser.Parse());
                        fileWritter.ChangeFileExtension("xml");
                        fileWritter.WriteFile();
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error. " + e.Message);
            }
        }
    }
}
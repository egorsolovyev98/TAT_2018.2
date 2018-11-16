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
               
                Parser parser;
                string writeFilePath;
                string newExtensionOfFile;
                bool isXMLFile = false;
                bool isJSONFile = false;

                foreach (string filePath in args)
                {
                    isXMLFile = Path.GetExtension(filePath).Equals(".xml");
                    isJSONFile = Path.GetExtension(filePath).Equals(".json");

                    if (isXMLFile)
                    {
                        parser = new XmlToJsonParser();
                        newExtensionOfFile = "json";

                    }
                    else if (isJSONFile)
                    {
                        parser = new JsonToXmlParser();
                        newExtensionOfFile = "xml";
                    }
                    else
                    {
                        continue;
                    }

                    writeFilePath = Path.ChangeExtension(filePath, newExtensionOfFile);
                    parser.ReadFile(filePath);
                    parser.Parse();
                    parser.WriteParsedFile(writeFilePath);
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error. " + e.Message);
            }
        }
    }
}
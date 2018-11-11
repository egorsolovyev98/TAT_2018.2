using System;
using System.Collections.Generic;
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
                    string newExtension = string.Empty;
                    List<string> file = null;

                    if (Path.GetExtension(filePath).Equals(".xml"))
                    {
                        XmlToJsonParser xmlToJsonParser = new XmlToJsonParser(filePath);
                        xmlToJsonParser.ReadFile();
                        file = xmlToJsonParser.Parse();
                        newExtension = "json";
                    }
                    else if (Path.GetExtension(filePath).Equals(".json"))
                    {
                        JsonToXmlParser jsonToXmlParser = new JsonToXmlParser(filePath);
                        jsonToXmlParser.ReadFile();
                        file = jsonToXmlParser.Parse();
                        newExtension = "xml";
                    }

                    if ((newExtension != string.Empty) && (file != null))
                    {
                        FileWritter fileWritter = new FileWritter(filePath, file);
                        fileWritter.ChangeFileExtension(newExtension);
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
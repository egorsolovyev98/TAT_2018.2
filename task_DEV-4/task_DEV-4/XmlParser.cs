using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace task_DEV4
{
    /// <summary>
    /// Xml parser.
    /// </summary>
    public class XmlParser
    {
        private string filePath;
        private Queue<StringBuilder> xmlElements = new Queue<StringBuilder>();

        public XmlParser(string filePath)
        {
            this.filePath = filePath;
            fileReader();
        }

        private void fileReader()
        {
            using (StreamReader reader = new StreamReader(filePath, System.Text.Encoding.UTF8))
            {
                string[] separatorsForFile = new string[] { "\r\n", " ", "<", ">" };
                string[] fileData = reader.ReadToEnd().Split(separatorsForFile, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
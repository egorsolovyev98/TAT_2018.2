using System.Collections.Generic;
using System.IO;
using System.Text;
using System;

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
            string[] fileData = System.IO.File.ReadAllLines(filePath);
            StringBuilder root = new StringBuilder();
            //string lastTagPatter = "\\s*<\\w+>\\w+<\\\\w+>\\s*";

            for (int i = 1; i < fileData.Length; i++)
            {
                if (!fileData[i].Contains("</") && !fileData[i].Contains("="))
                {
                    root.Append(InfoFromSingleTag(fileData[i])).Append(" -> ");
                }
                else if (!fileData[i].Contains("</"))
                {
                    root.Append(InfoFromAttribute(fileData[i])).Append(" -> ");
                }
                else if (fileData[i].IndexOf("<") != fileData[i].LastIndexOf("<"))
                {
                    root.Append(InfoFromLastTag(fileData[i]));
                }
            }
        }

        private string InfoFromLastTag(string str)
        {
            StringBuilder formingStr = new StringBuilder();
            formingStr.Append(InfoFromSingleTag(str)).Append(" -> ");
            int quotesIndex = str.IndexOf(">") + 1;
            formingStr.Append(str.Substring(quotesIndex, str.LastIndexOf("<") - quotesIndex));

            return formingStr.ToString();
        }

        private string InfoFromAttribute(string str)
        {
            StringBuilder formingStr = new StringBuilder();
            string[] tmp = InfoFromSingleTag(str).Split(' ');
            formingStr.Append(tmp[0]).Append(" { ");

            for (int i = 1; i < tmp.Length; i++)
            {
                formingStr.Append(tmp[i]).Append("; ");
            }

            formingStr.Append("}");

            return formingStr.ToString();
        }

        private string InfoFromSingleTag(string str)
        {
            int quotesIndex = str.IndexOf("<") + 1;

            return str.Substring(quotesIndex, str.IndexOf(">") - quotesIndex);
        }
    }
}
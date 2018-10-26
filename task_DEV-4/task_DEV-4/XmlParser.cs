using System.Collections.Generic;
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
        public List<StringBuilder> xmlElements { get; private set; }
        private List<string> tagsStack = new List<string>();

        public XmlParser(string filePath)
        {
            this.filePath = filePath;
            this.xmlElements = new List<StringBuilder>();
            fileReader();
        }

        private void fileReader()
        {
            string[] fileData = System.IO.File.ReadAllLines(filePath);
            StringBuilder root = new StringBuilder();
            //string lastTagPatter = @"\s*[<]\w+[>]\w+[</]\w+[>]\s*";
            //string pattern = @"\s*</\w+>\s*";

            for (int i = 1; i < fileData.Length; i++)
            {
                if (IsOpeningTag(fileData[i]))
                {
                    String tag = InfoFromSingleTag(fileData[i], "<", ">");
                    tagsStack.Add(tag);
                    root.Append(tag).Append(" -> ");
                }
                else if (IsAttribute(fileData[i]))
                {
                    Attribute attribute = InfoFromAttribute(fileData[i]);
                    tagsStack.Add(attribute.tag);
                    root.Append(attribute.ToString()).Append(" -> ");
                }
                else if (IsInnerTag(fileData[i]))
                {
                    Attribute attribute = InfoFromLastTag(fileData[i]);
                    xmlElements.Add(new StringBuilder(root + attribute.tag + " -> " + attribute.value));
  
                }
                else if (IsClosingTag(fileData[i]))
                {
                    int numberOfElements = tagsStack.Count;
                    tagsStack.RemoveAt(numberOfElements - 1);
                    root = GenerateRoot();
                }
            }
        }

        private StringBuilder GenerateRoot()
        {
            StringBuilder root = new StringBuilder();

            foreach (string i in tagsStack)
            {
                root.Append(i).Append(" -> ");
            }

            return root;
        }

        private Attribute InfoFromLastTag(string str)
        {
            Attribute attribute = new Attribute();
            attribute.tag = InfoFromSingleTag(str, "<", ">");
            int quotesIndex = str.IndexOf(">") + 1;
            attribute.value = str.Substring(quotesIndex, str.LastIndexOf("<") - quotesIndex);

            return attribute;
        }

        private Attribute InfoFromAttribute(string str)
        {
            StringBuilder formingStr = new StringBuilder();
            string[] tmp = InfoFromSingleTag(str, "<", ">").Split(' ');

            for (int i = 1; i < tmp.Length; i++)
            {
                formingStr.Append(tmp[i]).Append(";");
            }

            return new Attribute (tmp[0], formingStr.ToString());
        }

        private string InfoFromSingleTag(string str, string fromSimble, string toSimble)
        {
            int quotesIndex = str.IndexOf(fromSimble) + 1;

            return str.Substring(quotesIndex, str.IndexOf(toSimble) - quotesIndex);
        }

        bool IsClosingTag(string str)
        {
            return str.Contains("</");
        }

        private bool IsInnerTag(string str)
        {
            return str.IndexOf("<") != str.LastIndexOf("<");
        }

        private bool IsAttribute(string str)
        {
            return !str.Contains("</");
        }

        private bool IsOpeningTag(string str)
        {
            return !str.Contains("</") && !str.Contains("=");
        }
    }
}
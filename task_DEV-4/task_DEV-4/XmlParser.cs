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
        /// <summary>
        /// List of xml elements.
        /// </summary>
        /// <value>The xml elements.</value>
        public List<string> xmlElements { get; private set; }


        /// <summary>
        /// The tags list.
        /// </summary>
        private List<string> tagsList = new List<string>();


        /// <summary>
        /// The file path.
        /// </summary>
        private string filePath;


        /// <summary>
        /// File in string array.
        /// </summary>
        private string[] fileData;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="filePath">File path.</param>
        public XmlParser(string filePath)
        {
            this.filePath = filePath;
            this.xmlElements = new List<string>();
            ReadFile();
            Parse();
        }


        /// <summary>
        /// Parses the xml file to string list.
        /// </summary>
        private void Parse()
        {
            StringBuilder root = new StringBuilder();

            for (int i = 0; i < fileData.Length; i++)
            {
                if (fileData[i].Contains("?xml") || fileData[i].Contains("!DOCTYPE"))
                {
                    continue;
                }
                else if (IsOpeningTag(fileData[i]))
                {
                    String tag = InfoFromSingleTag(fileData[i], "<", ">");
                    tagsList.Add(tag);
                    root.Append(tag).Append(" -> ");
                }
                else if (IsAttribute(fileData[i]))
                {
                    Attribute attribute = InfoFromAttribute(fileData[i]);
                    tagsList.Add(attribute.tag);
                    root.Append(attribute.ToString()).Append(" -> ");
                }
                else if (IsInnerTag(fileData[i]))
                {
                    Attribute attribute = InfoFromInnertTag(fileData[i]);
                    StringBuilder str = new StringBuilder(root + attribute.tag + " -> " + attribute.value);
                    xmlElements.Add(str.ToString());
                }
                else if (IsClosingTag(fileData[i]))
                {
                    DeleteLastElement();
                    root = GenerateRoot();
                }
                else if (IsNoTagsInLine(fileData[i]))
                {
                    string infoFromNoTagLine = fileData[i].Trim();
                    StringBuilder str = new StringBuilder(root + infoFromNoTagLine);
                    xmlElements.Add(str.ToString());
                    DeleteLastElement();
                    root = GenerateRoot();
                    i++;
                }
            }
        }


        /// <summary>
        /// Deletes the last element in list of tags.
        /// </summary>
        private void DeleteLastElement()
        {
            int numberOfElements = tagsList.Count;
            tagsList.RemoveAt(numberOfElements - 1);
        }

        /// <summary>
        /// Reads the file.
        /// </summary>
        private void ReadFile()
        {
            fileData = System.IO.File.ReadAllLines(filePath);
        }


        /// <summary>
        /// Generates the root.
        /// </summary>
        /// <returns>The root.</returns>
        private StringBuilder GenerateRoot()
        {
            StringBuilder root = new StringBuilder();

            foreach (string i in tagsList)
            {
                root.Append(i).Append(" -> ");
            }

            return root;
        }


        /// <summary>
        /// Gets name and value from inner tag.
        /// </summary>
        /// <returns>Attribute with tag and value.</returns>
        /// <param name="str">String.</param>
        private Attribute InfoFromInnertTag(string str)
        {
            Attribute attribute = new Attribute();
            attribute.tag = InfoFromSingleTag(str, "<", ">");
            int quotesIndex = str.IndexOf(">") + 1;
            attribute.value = str.Substring(quotesIndex, str.LastIndexOf("<") - quotesIndex);

            return attribute;
        }


        /// <summary>
        /// Gets name and value from attribute.
        /// </summary>
        /// <returns>Attribute with tag and value.</returns>
        /// <param name="str">String.</param>
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


        /// <summary>
        /// Allocates a substring between fromSimble and toSimble.
        /// </summary>
        /// <returns>The from single tag.</returns>
        /// <param name="str">String.</param>
        /// <param name="fromSimble">From simble.</param>
        /// <param name="toSimble">To simble.</param>
        private string InfoFromSingleTag(string str, string fromSimble, string toSimble)
        {
            int quotesIndex = str.IndexOf(fromSimble) + 1;

            return str.Substring(quotesIndex, str.IndexOf(toSimble) - quotesIndex);
        }


        /// <summary>
        /// Determines the closing tag.
        /// </summary>
        /// <returns><c>true</c>, if closing tag was ised, <c>false</c> otherwise.</returns>
        /// <param name="str">String.</param>
        private bool IsClosingTag(string str)
        {
            return str.Contains("</");
        }


        /// <summary>
        /// Determines the inner tag.
        /// </summary>
        /// <returns><c>true</c>, if inner tag was ised, <c>false</c> otherwise.</returns>
        /// <param name="str">String.</param>
        private bool IsInnerTag(string str)
        {
            return str.IndexOf("<") != str.LastIndexOf("<");
        }


        /// <summary>
        /// Determines the attribute.
        /// </summary>
        /// <returns><c>true</c>, if attribute was ised, <c>false</c> otherwise.</returns>
        /// <param name="str">String.</param>
        private bool IsAttribute(string str)
        {
            return !str.Contains("</") && str.Contains("<");
        }


        /// <summary>
        /// Determines the opening tag.
        /// </summary>
        /// <returns><c>true</c>, if opening tag was ised, <c>false</c> otherwise.</returns>
        /// <param name="str">String.</param>
        private bool IsOpeningTag(string str)
        {
            return !str.Contains("</") && !str.Contains("=") && str.Contains("<");
        }


        /// <summary>
        /// Determines the no tag line.
        /// </summary>
        /// <returns><c>true</c>, if no tags in line was ised, <c>false</c> otherwise.</returns>
        /// <param name="str">String.</param>
        private bool IsNoTagsInLine(string str)
        {
            return !str.Contains("<");
        }
    }
}
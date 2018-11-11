using System.Collections.Generic;
using System.Text;

namespace task_DEV6
{
    /// <summary>
    /// XML to JSON parser.
    /// </summary>
    public class XmlToJsonParser : Parser
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="filePath">File path.</param>
        public XmlToJsonParser(string filePath) : base(filePath) {}


        /// <summary>
        /// Parses the xml file to json.
        /// </summary>
        /// <returns>Parsed json file in list of strings.</returns>
        public override List<string> Parse()
        {
            FileInList.Add("{");

            for (int i = 0; i < fileData.Length; i++)
            {
                if (fileData[i].Contains("?xml") || fileData[i].Contains("!DOCTYPE") || fileData[i].Contains("<!--"))
                {
                    MissingExtraItems(ref i);
                }
                else if (IsOpeningTag(fileData[i])) // <...>
                {
                    string tag = InfoFromSingleTag(fileData[i], "<", ">");
                    TagsStack.Push(tag);
                    FileInList.Add($"\"{tag}\": {{");
                }
                else if (IsAttribute(fileData[i])) // <... ...="...">
                {
                    Attribute attribute = InfoFromAttribute(fileData[i]);
                    FileInList.Add($"\"{attribute.tag}\": {{");
                    FileInList.Add($"\"{attribute.value},");
                }
                else if (IsInnerTag(fileData[i])) // <...>...</...>
                {
                    Attribute attribute = InfoFromInnertTag(fileData[i]);
                    FileInList.Add($"\"{attribute.tag}\": \"{attribute.value}\",");
                }
                else if (IsClosingTag(fileData[i])) // </...>
                {
                    FileInList.Add("}");
                }
                else if (IsNoTagsInLine(fileData[i])) 
                {
                    string infoFromNoTagLine = fileData[i].Trim();
                    FileInList[FileInList.Count - 1] = $"\"{TagsStack.Pop()}\": \"{infoFromNoTagLine}\",";
                    i++;
                }
            }

            FileInList.Add("}");

            return FileInList;
        }


        /// <summary>
        /// Missings the extra items.
        /// </summary>
        /// <param name="i">The index of array.</param>
        private void MissingExtraItems(ref int i)
        {
            if (fileData[i].Contains("<!--"))
            {
                while (!fileData[i].Contains("-->"))
                {
                    i++;
                }
            }
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
                formingStr.Append(tmp[i]).Replace("=","\": ").Append("\n");
            }

            formingStr.Remove(formingStr.Length - 1, 1);

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
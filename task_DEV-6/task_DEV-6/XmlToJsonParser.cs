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
        /// Parses the xml file to json.
        /// </summary>
        /// <returns>Parsed json file in list of strings.</returns>
        public override List<string> Parse()
        {
            ParsedFile.Clear();
            ParsedFile.Add("{");

            for (int i = 0; i < InputFileData.Length; i++)
            {
                if (InputFileData[i].Contains("?xml") || InputFileData[i].Contains("!DOCTYPE") || InputFileData[i].Contains("<!--"))
                {
                    MissingExtraItems(ref i);
                }
                else if (IsOpeningTag(InputFileData[i])) // <...>
                {
                    string tag = InfoFromSingleTag(InputFileData[i], "<", ">");
                    TagsStack.Push(tag);
                    ParsedFile.Add($"\"{tag}\": {{");
                }
                else if (IsAttribute(InputFileData[i])) // <... ...="...">
                {
                    Attribute attribute = InfoFromAttribute(InputFileData[i]);
                    ParsedFile.Add($"\"{attribute.Tag}\": {{");
                    ParsedFile.Add($"\"{attribute.Value},");
                }
                else if (IsInnerTag(InputFileData[i])) // <...>...</...>
                {
                    Attribute attribute = InfoFromInnertTag(InputFileData[i]);
                    ParsedFile.Add($"\"{attribute.Tag}\": \"{attribute.Value}\",");
                }
                else if (IsClosingTag(InputFileData[i])) // </...>
                {
                    ParsedFile.Add("}");
                }
                else if (IsNoTagsInLine(InputFileData[i])) 
                {
                    string infoFromNoTagLine = InputFileData[i].Trim();
                    ParsedFile[ParsedFile.Count - 1] = $"\"{TagsStack.Pop()}\": \"{infoFromNoTagLine}\",";
                    i++;
                }
            }

            ParsedFile.Add("}");

            return ParsedFile;
        }


        /// <summary>
        /// Missings the extra items.
        /// </summary>
        /// <param name="i">The index of array.</param>
        private void MissingExtraItems(ref int i)
        {
            if (InputFileData[i].Contains("<!--"))
            {
                while (!InputFileData[i].Contains("-->"))
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
            attribute.Tag = InfoFromSingleTag(str, "<", ">");
            int quotesIndex = str.IndexOf(">") + 1;
            attribute.Value = str.Substring(quotesIndex, str.LastIndexOf("<") - quotesIndex);

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
            string[] attributeInfo = InfoFromSingleTag(str, "<", ">").Split(' ');

            for (int i = 1; i < attributeInfo.Length; i++)
            {
                formingStr.Append(attributeInfo[i]).Replace("=","\": ").Append("\n");
            }

            formingStr.Remove(formingStr.Length - 1, 1);

            return new Attribute (attributeInfo[0], formingStr.ToString());
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
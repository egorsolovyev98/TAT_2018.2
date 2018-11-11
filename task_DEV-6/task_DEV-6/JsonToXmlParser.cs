using System.Collections.Generic;

namespace task_DEV6
{
    /// <summary>
    /// JSON to XML parser.
    /// </summary>
    public class JsonToXmlParser : Parser
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="filePath">File path.</param>
        public JsonToXmlParser(string filePath) : base(filePath) { }


        /// <summary>
        /// Parses the json file to xml.
        /// </summary>
        /// <returns>Parsed xml file in list of strings.</returns>
        public override List<string> Parse()
        {
            for (int i = 0; i < fileData.Length; i++)
            {
                if (IsOpeningTag(fileData[i])) // "..." : {
                {
                    string tag = InfoFromQuotes(fileData[i]);
                    TagsStack.Push(tag);
                    FileInList.Add(MakeOpeningTag(tag));
                }
                else if(IsInnerTag(fileData[i])) // "..." : "..."
                {
                    FileInList.Add(InfoFromInnerTag(fileData[i]));
                }
                else if(IsClosingTag(fileData[i])) // }
                {
                    if (TagsStack.Count != 0)
                    {
                        FileInList.Add(MakeClosingTag(TagsStack.Pop()));
                    }
                }
            }

            return FileInList;
        }


        /// <summary>
        /// Info from quotes.
        /// </summary>
        /// <returns>The name of tag from quotes.</returns>
        /// <param name="str">String.</param>
        private string InfoFromQuotes(string str)
        {
            int quotesIndex = str.IndexOf("\"") + 1;

            return str.Substring(quotesIndex, str.IndexOf("\"", quotesIndex) - quotesIndex);
        }


        /// <summary>
        /// Gets name and value from inner tag.
        /// </summary>
        /// <returns>Attribute with tag and value.</returns>
        /// <param name="str">String.</param>
        private string InfoFromInnerTag(string str)
        {
            Attribute attribute = new Attribute();
            attribute.tag = InfoFromQuotes(str);
            int lastQuotesIndex = str.LastIndexOf("\"") - 1;
            int preLastQuotesIndex = str.LastIndexOf("\"", lastQuotesIndex);
            attribute.value =  str.Substring(preLastQuotesIndex + 1, lastQuotesIndex - preLastQuotesIndex);

            return $"{MakeOpeningTag(attribute.tag)}{attribute.value}{MakeClosingTag(attribute.tag)}";
        }


        /// <summary>
        /// Determines the closing tag.
        /// </summary>
        /// <returns><c>true</c>, if closing tag was ised, <c>false</c> otherwise.</returns>
        /// <param name="str">String.</param>
        private bool IsClosingTag(string str)
        {
            return str.Contains("}");
        }


        /// <summary>
        /// Determines the inner tag.
        /// </summary>
        /// <returns><c>true</c>, if inner tag was ised, <c>false</c> otherwise.</returns>
        /// <param name="str">String.</param>
        private bool IsInnerTag(string str)
        {
            return str.Contains(": \"");
        }


        /// <summary>
        /// Determines the opening tag.
        /// </summary>
        /// <returns><c>true</c>, if opening tag was ised, <c>false</c> otherwise.</returns>
        /// <param name="str">String.</param>
        private bool IsOpeningTag(string str)
        {
            return str.Contains(": {");
        }


        /// <summary>
        /// Makes the opening tag.
        /// </summary>
        /// <returns>The opening tag.</returns>
        /// <param name="tag">Tag.</param>
        private string MakeOpeningTag(string tag)
        {
            return $"<{tag}>";
        }


        /// <summary>
        /// Makes the closing tag.
        /// </summary>
        /// <returns>The closing tag.</returns>
        /// <param name="tag">Tag.</param>
        private string MakeClosingTag(string tag)
        {
            return $"</{tag}>";
        }
    }
}
using System.Collections.Generic;

namespace task_DEV6
{
    /// <summary>
    /// JSON to XML parser.
    /// </summary>
    public class JsonToXmlParser : Parser
    {
        /// <summary>
        /// Parses the json file to xml.
        /// </summary>
        /// <returns>Parsed xml file in list of strings.</returns>
        public override List<string> Parse()
        {
            ParsedFile.Clear();

            for (int i = 0; i < InputFileData.Length; i++)
            {
                if (IsOpeningTag(InputFileData[i])) // "..." : {
                {
                    string tag = InfoFromQuotes(InputFileData[i]);
                    TagsStack.Push(tag);
                    ParsedFile.Add(MakeOpeningTag(tag));
                }
                else if(IsInnerTag(InputFileData[i])) // "..." : "..."
                {
                    ParsedFile.Add(InfoFromInnerTag(InputFileData[i]));
                }
                else if(IsClosingTag(InputFileData[i])) // }
                {
                    if (TagsStack.Count != 0)
                    {
                        ParsedFile.Add(MakeClosingTag(TagsStack.Pop()));
                    }
                }
            }

            return ParsedFile;
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
            attribute.Tag = InfoFromQuotes(str);
            int lastQuotesIndex = str.LastIndexOf("\"") - 1;
            int preLastQuotesIndex = str.LastIndexOf("\"", lastQuotesIndex);
            attribute.Value =  str.Substring(preLastQuotesIndex + 1, lastQuotesIndex - preLastQuotesIndex);

            return $"{MakeOpeningTag(attribute.Tag)}{attribute.Value}{MakeClosingTag(attribute.Tag)}";
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
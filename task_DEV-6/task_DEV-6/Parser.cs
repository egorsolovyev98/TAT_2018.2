using System;
using System.Collections.Generic;
using System.IO;

namespace task_DEV6
{
    /// <summary>
    /// Parser.
    /// </summary>
    public abstract class Parser
    {
        /// <summary>
        /// Gets or sets the file in list.
        /// </summary>
        /// <value>The file in list.</value>
        protected List<string> ParsedFile { get; set; }


        /// <summary>
        /// Gets or sets the tags stack.
        /// </summary>
        /// <value>The tags stack.</value>
        protected Stack<string> TagsStack { get; set; }


        /// <summary>
        /// Gets the file data.
        /// </summary>
        /// <value>The file data.</value>
        protected string[] InputFileData { get; private set; }


        /// <summary>
        /// Constructor.
        /// </summary>
        public Parser()
        {
            ParsedFile = new List<string>();
            TagsStack = new Stack<string>();
        }


        /// <summary>
        /// Reads the file.
        /// </summary>
        public void ReadFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new Exception($"File: {filePath} doesn't exists.");
            }

            InputFileData = File.ReadAllLines(filePath);
        }


        /// <summary>
        /// Writes the parsed file.
        /// </summary>
        /// <param name="filePath">File path.</param>
        public void WriteParsedFile(string filePath)
        {
            if (filePath == string.Empty)
            {
                throw new Exception("File name is empty.");
            }

            using (StreamWriter streamWriter = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                foreach (string str in ParsedFile)
                {
                    streamWriter.WriteLine(str);
                }
            }
        }


        /// <summary>
        /// Parses the file.
        /// </summary>
        /// <returns>The parse.</returns>
        public abstract List<string> Parse();
    }
}
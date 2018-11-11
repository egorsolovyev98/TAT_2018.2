using System;
using System.Collections.Generic;

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
        protected List<string> FileInList { get; set; }


        /// <summary>
        /// Gets or sets the tags stack.
        /// </summary>
        /// <value>The tags stack.</value>
        protected Stack<string> TagsStack { get; set; }


        /// <summary>
        /// The file path.
        /// </summary>
        private string filePath;


        /// <summary>
        /// Gets the file data.
        /// </summary>
        /// <value>The file data.</value>
        protected string[] fileData { get; private set; }


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="filePath">File path.</param>
        public Parser(string filePath)
        {
            if (filePath == String.Empty)
            {
                throw new Exception("File name is empty.");
            }

            this.filePath = filePath;
            this.FileInList = new List<string>();
            this.TagsStack = new Stack<string>();
        }


        /// <summary>
        /// Reads the file.
        /// </summary>
        public void ReadFile()
        {
            if (!System.IO.File.Exists(filePath))
            {
                throw new Exception($"File: {filePath} doesn't exists.");
            }

            fileData = System.IO.File.ReadAllLines(filePath);
        }


        /// <summary>
        /// Parses the file.
        /// </summary>
        /// <returns>The parse.</returns>
        public abstract List<string> Parse();
    }
}
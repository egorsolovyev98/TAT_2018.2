using System.Collections.Generic;
using System.IO;

namespace task_DEV6
{
    /// <summary>
    /// File writter.
    /// </summary>
    public class FileWritter
    {
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>The file path.</value>
        public string FilePath { get; set; }


        /// <summary>
        /// The info to write.
        /// </summary>
        public List<string> infoToWrite;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <param name="information">Information.</param>
        public FileWritter(string filePath, List<string> information)
        {
            FilePath = filePath;
            this.infoToWrite = information;
        }


        /// <summary>
        /// Changes the file extension.
        /// </summary>
        /// <param name="newExtension">New extension.</param>
        public void ChangeFileExtension(string newExtension)
        {
            FilePath = Path.ChangeExtension(FilePath, newExtension);
        }


        /// <summary>
        /// Writes the file.
        /// </summary>
        public void WriteFile()
        {
            using (StreamWriter streamWriter = new StreamWriter(FilePath, false, System.Text.Encoding.Default))
            {
                foreach (string str in infoToWrite)
                {
                    streamWriter.WriteLine(str);
                }
            }
        }
    }
}
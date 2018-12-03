namespace task_DEV4
{
    /// <summary>
    /// Xml attribute.
    /// </summary>
    public class Attribute
    {
        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        /// <value>The tag.</value>
        public string tag { get; set; }


        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string value { get; set; }


        /// <summary>
        /// Constructor.
        /// </summary>
        public Attribute()
        {
            this.tag = string.Empty;
            this.value = string.Empty;
        }


        /// <summary>
        /// Constructor with arguments.
        /// </summary>
        /// <param name="tag">Tag.</param>
        /// <param name="value">Value.</param>
        public Attribute(string tag, string value)
        {
            this.tag = tag;
            this.value = value;
        }


        /// <summary>
        /// To string method.
        /// </summary>
        /// <returns>Attribute in string.</returns>
        public override string ToString()
        {
            return tag + " " + value;
        }
    }
}
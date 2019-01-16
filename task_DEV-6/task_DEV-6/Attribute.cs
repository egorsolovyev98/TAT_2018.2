namespace task_DEV6
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
        public string Tag { get; set; }


        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; set; }


        /// <summary>
        /// Constructor.
        /// </summary>
        public Attribute()
        {
            Tag = string.Empty;
            Value = string.Empty;
        }


        /// <summary>
        /// Constructor with arguments.
        /// </summary>
        /// <param name="tag">Tag.</param>
        /// <param name="value">Value.</param>
        public Attribute(string tag, string value)
        {
            Tag = tag;
            Value = value;
        }


        /// <summary>
        /// To string method.
        /// </summary>
        /// <returns>Attribute in string.</returns>
        public override string ToString()
        {
            return Tag + " " + Value;
        }
    }
}
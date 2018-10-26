namespace task_DEV4
{
    public class Attribute
    {
        public string tag { get; set; }
        public string value { get; set; }

        public Attribute()
        {
            this.tag = string.Empty;
            this.value = string.Empty;
        }

        public Attribute(string tag, string value)
        {
            this.tag = tag;
            this.value = value;
        }

        public override string ToString()
        {
            return tag + " " + value;
        }
    }
}
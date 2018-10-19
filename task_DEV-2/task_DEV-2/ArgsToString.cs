using System.Text;

namespace task_DEV2
{
    /// <summary>
    /// Arguments to string.
    /// </summary>
    static class ArgsToString
    {
        /// <summary>
        /// Forms a string from string array.
        /// </summary>
        /// <returns>String from string array.</returns>
        /// <param name="args">Array of string.</param>
        public static string ArrayToString(this string[] args)
        {
            if (args.Length == 1)
            {
                return args[0];
            }

            StringBuilder formingString = new StringBuilder();

            foreach (string i in args)
            {
                formingString.Append(i).Append(" ");
            }

            formingString.Remove(formingString.Length - 1, 1); // Delete last space bar

            return formingString.ToString();
        }
    }
}
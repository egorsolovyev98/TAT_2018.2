using System;
using System.Text;

namespace task_DEV1
{
    static class ArgsToString
    {
        /// <summary>
        /// The ArgsToString class forms a string of arguments
        /// </summary>
        public static string ArrayToString(this string[] args)
        {
            StringBuilder formingString = new StringBuilder();

            foreach (string i in args)
            {
                formingString.Append(i + " ");
            }

            formingString.Remove(formingString.Length - 1, 1); // Delete last space bar

            return formingString.ToString();
        }
    }
}

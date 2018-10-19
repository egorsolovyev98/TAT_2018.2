using System.Linq;

namespace task_DEV2
{
    /// <summary>
    /// Checks if string consists only of Cyrillic
    /// </summary>
    static class LatinCheck
    {
        /// <summary>
        /// Checks, if string consists only of Cyrillic.
        /// </summary>
        /// <returns><c>true</c>, if cyrilic was used, <c>false</c> otherwise.</returns>
        /// <param name="str">String.</param>
        public static bool IsLatin(this string str)
        {
            foreach (char i in str)
            {
                if (char.IsLetter(i) && (!Enumerable.Range(97, 122).Contains(i)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
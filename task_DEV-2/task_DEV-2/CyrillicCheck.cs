using System.Linq;

namespace task_DEV2
{
    /// <summary>
    /// Checks if string consists only of Cyrillic.
    /// </summary>
    static class CyrillicCheck
    {
        /// <summary>
        /// Checks, if string consists only of Cyrillic.
        /// </summary>
        /// <returns><c>true</c>, if cyrilic was used, <c>false</c> otherwise.</returns>
        /// <param name="str">String.</param>
        public static bool IsCyrillic(this string str)
        {
            foreach (char i in str)
            {
                if (char.IsLetter(i) && (!Enumerable.Range(1072, 1103).Contains(i)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
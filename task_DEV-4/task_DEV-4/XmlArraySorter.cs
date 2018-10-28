using System.Collections.Generic;
using System.Linq;

namespace task_DEV4
{
    /// <summary>
    /// Xml array sorter.
    /// </summary>
    static class XmlArraySorter
    {
        /// <summary>
        /// Sorts the xml elements.
        /// </summary>
        /// <returns>Sorted list.</returns>
        /// <param name="list">List.</param>
        public static List<string> SortXmlElements(this List<string> list)  
        {
            List<string> sortedList = list.OrderBy(i => i).Select(i => i).ToList();
            return sortedList;
        }
    }
}
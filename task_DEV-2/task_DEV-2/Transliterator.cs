using System.Collections.Generic;
using System.Text;
using System.Linq;
using System;

namespace task_DEV2
{
    /// <summary>
    /// Transliterator.
    /// </summary>
    static class Transliterator
    {
        /// <summary>
        /// Transliterate the specified inputtring.
        /// </summary>
        /// <returns>The transliterated string.</returns>
        /// <param name="inputString">Input string.</param>
        public static string Transliterate(this string inputString)
        {
            Dictionary<string, string> transliterationDictionary = new Dictionary<string, string>
            {
                ["щ"] = "sch",
                ["ш"] = "sh",
                ["ё"] = "yo",
                ["ю"] = "yu",
                ["я"] = "ya",
                ["х"] = "kh",
                ["ц"] = "ts",
                ["ч"] = "ch",
                ["ж"] = "zh",
                ["а"] = "a",
                ["б"] = "b",
                ["в"] = "v",
                ["г"] = "g",
                ["д"] = "d",
                ["е"] = "e",
                ["з"] = "z",
                ["и"] = "i",
                ["й"] = "y",
                ["к"] = "k",
                ["л"] = "l",
                ["м"] = "m",
                ["н"] = "n",
                ["о"] = "o",
                ["п"] = "p",
                ["р"] = "r",
                ["с"] = "s",
                ["т"] = "t",
                ["у"] = "u",
                ["ф"] = "f",
                ["ы"] = "y",
                ["э"] = "e",
                ["ъ"] = string.Empty,
                ["ь"] = string.Empty
            };

            StringBuilder transliteratedString = new StringBuilder(inputString.ToLower());

            if (inputString.IsCyrillic())
            {
                foreach (string i in transliterationDictionary.Keys)
                {
                    transliteratedString.Replace(i, transliterationDictionary[i]);
                }
            }
            else if (inputString.IsLatin())
            {
                foreach (string i in transliterationDictionary.Keys)
                {
                    if (transliterationDictionary[i] != string.Empty)
                    {
                        transliteratedString.Replace(transliterationDictionary[i], i);
                    }
                }
            }
            else
            {
                throw new Exception("cyrillic and latin letters found.");
            }

            return transliteratedString.ToString();
        }
    }
}
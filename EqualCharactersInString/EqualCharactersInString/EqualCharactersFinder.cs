using System;
using System.Collections.Generic;

namespace EqualCharactersInString
{
    /// <summary>
    /// Equal characters finder.
    /// </summary>
    public class EqualCharactersFinder
    {
        /// <summary>
        /// Gets or sets the dictionary.
        /// </summary>
        /// <value>The dictionary.</value>
        public Dictionary<char, int> Dictionary { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="T:EqualCharactersInString.EqualCharactersFinder"/> class.
        /// </summary>
        public EqualCharactersFinder()
        {
            Dictionary = new Dictionary<char, int>();
        }


        /// <summary>
        /// Finds the number of equal characters.
        /// </summary>
        /// <returns>The number of equal characters.</returns>
        /// <param name="str">String.</param>
        public Dictionary<char,int> FindNumberOfEqualCharacters(string str)
        {
            Dictionary.Clear();

            foreach(var i in str)
            {
                if(!Dictionary.ContainsKey(i))
                {
                    Dictionary.Add(i, 1);
                }
                else
                {
                    Dictionary[i]++;
                }
            }

            return Dictionary;
        }


        /// <summary>
        /// Prints the result.
        /// </summary>
        public void PrintResult()
        {
            foreach(var i in Dictionary)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");
            }
        }
    }
}
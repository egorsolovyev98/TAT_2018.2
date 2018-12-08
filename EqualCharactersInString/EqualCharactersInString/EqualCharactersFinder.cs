using System;
using System.Collections.Generic;

namespace EqualCharactersInString
{
    public class EqualCharactersFinder
    {
        public Dictionary<char, int> Dictionary { get; set; }

        public EqualCharactersFinder()
        {
            Dictionary = new Dictionary<char, int>();
        }

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

        public void PrintResult()
        {
            foreach(var i in Dictionary)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");
            }
        }
    }
}
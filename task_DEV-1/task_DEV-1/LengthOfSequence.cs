using System;
using System.Collections.Generic;

namespace task_DEV1
{
    static class LengthOfSequence
    {
        /// <summary>
        /// The LengthOfSequence class calculates 
        /// the maximum number of different consecutive characters in a string
        /// </summary>
        public static int GetLengthOfSequence(this string sequence)
        {
            if (sequence.Length == 1)
            {
                return 1;
            }

            HashSet<char> setOfCharacters = new HashSet<char>();
            int maxLength = 1;

            for (int i = 0; i < sequence.Length; i++)
            {
                setOfCharacters.Add(sequence[i]);

                for (int j = i + 1; (j < sequence.Length) && (!setOfCharacters.Contains(sequence[j])); j++)
                {
                    setOfCharacters.Add(sequence[j]);

                    if (setOfCharacters.Count > maxLength)
                    {
                        maxLength = setOfCharacters.Count;
                    }
                }

                setOfCharacters.Clear();
            }

            return maxLength;
        }
    }
}
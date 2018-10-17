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
            int maxLength = 0;
            int counter = 1;

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] != sequence[i])
                {
                    setOfCharacters.Add(sequence[i - 1]);
                    counter++;

                    if (setOfCharacters.Contains(sequence[i])) // Check the uniqueness of character 
                    {
                        counter--;
                    }

                    if (counter > maxLength)
                    {
                        maxLength = counter;
                    }

                }
                else
                {
                    counter = 1;
                    setOfCharacters.Clear();
                }
            }

            return maxLength;
        }
    }
}
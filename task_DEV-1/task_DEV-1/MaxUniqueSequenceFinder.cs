using System.Collections.Generic;

namespace task_DEV1
{
    static class MaxUniqueSequenceFinder
    {
        /// <summary>
        /// Calculates the maximum number of unique consecutive characters in a string.
        /// </summary>
        /// <returns>The length of sequence.</returns>
        /// <param name="sequence">The string in which the sequence is searched.</param>
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
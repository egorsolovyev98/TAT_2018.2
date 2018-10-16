using System;
using System.Collections.Generic;

namespace task_DEV1
{
    static class LengthOfSequence
    {
        public static int GetLengthOfSequence(this string sequence)
        {
            if (sequence.Length == 1)
            {
                return 1;
            }

            int maxLength = 0;
            int counter = 1;
            HashSet<char> set = new HashSet<char>();

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] != sequence[i])
                {
                    set.Add(sequence[i - 1]);
                    counter++;

                    if(set.Contains(sequence[i])) //check the unique of character 
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
                    set.Clear();
                }
            }

            return maxLength;
        }
    }
}
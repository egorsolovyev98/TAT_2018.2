using System;

namespace task_DEV1
{
    static class LengthOfSequence
    {
        public static int GetLengthOfSequence(this string sequence)
        {
            int maxLength = 0;
            int counter = 1;

            if (sequence.Length == 1)
            {
                return 1;
            }

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] != sequence[i])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > maxLength)
                {
                    maxLength = counter;
                }
            }

            return maxLength;
        }
    }
}

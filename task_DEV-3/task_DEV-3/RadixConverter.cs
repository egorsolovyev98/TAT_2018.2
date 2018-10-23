using System;

namespace task_DEV3
{
    /// <summary>
    /// Radix converter.
    /// </summary>
    public static class RadixConverter
    {
        /// <summary>
        /// Tos the new radix.
        /// </summary>
        /// <returns>The new radix.</returns>
        /// <param name="value">Value.</param>
        /// <param name="radix">New radix.</param>
        public static string ToNewRadix(this int value, int radix)
        {
            const int MinRadix = 2;
            const int MaxRadix = 36;

            if (radix < MinRadix || radix > MaxRadix)
            {
                throw new ArgumentException("wrong radix.");
            }
                
            if (radix == 10)
            {
                return value.ToString();
            }

            char[] digits = 
            {
                '0' , '1' , '2' , '3' , '4' , '5' ,
                '6' , '7' , '8' , '9' , 'a' , 'b' ,
                'c' , 'd' , 'e' , 'f' , 'g' , 'h' ,
                'i' , 'j' , 'k' , 'l' , 'm' , 'n' ,
                'o' , 'p' , 'q' , 'r' , 's' , 't' ,
                'u' , 'v' , 'w' , 'x' , 'y' , 'z'
            };

            char[] buf = new char[33];
            bool negative = (value < 0);
            int charPos = 32;

            if (!negative)
            {
                value = -value;
            }

            while (value <= -radix)
            {
                buf[charPos--] = digits[-(value % radix)];
                value = value / radix;
            }

            buf[charPos] = digits[-value];

            if (negative)
            {
                buf[--charPos] = '-';
            }

            return new String(buf, charPos, (33 - charPos));
        }
    }
}
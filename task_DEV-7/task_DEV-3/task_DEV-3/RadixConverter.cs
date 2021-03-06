﻿using System;

namespace task_DEV3
{
    /// <summary>
    /// Radix converter.
    /// </summary>
    public static class RadixConverter
    {
        /// <summary>
        /// Convert integer to new radix.
        /// </summary>
        /// <returns>String with value in the new radix .</returns>
        /// <param name="value">Value.</param>
        /// <param name="radix">New radix.</param>
        public static string ToNewRadix(this int value, int radix)
        {
            const int MinRadix = 2;
            const int MaxRadix = 36;

            if (radix < MinRadix || radix > MaxRadix)
            {
                throw new ArgumentException("Wrong radix.");
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

            int charPos = 31; // 31 - The maximum possible number of divisions with the remainder for type int
            char[] buf = new char[32]; // 31 + 1 for sign
            bool negative = (value < 0);

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
            return new String(buf, charPos, (32 - charPos));
        }
    }
}
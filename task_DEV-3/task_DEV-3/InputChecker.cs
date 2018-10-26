using System;

namespace task_DEV3
{
    /// <summary>
    /// Input checker.
    /// </summary>
    public class InputChecker
    {
        /// <summary>
        /// The minimum radix by condition.
        /// </summary>
        private const int MinRadixByCondition = 2;


        /// <summary>
        /// The max radix by condition.
        /// </summary>
        private const int MaxRadixByCondition = 20;


        /// <summary>
        /// Gets the input value.
        /// </summary>
        /// <value>The input value.</value>
        public int inputValue { get; }


        /// <summary>
        /// Gets the new radix.
        /// </summary>
        /// <value>The new radix.</value>
        public int newRadix { get; }


        /// <summary>
        /// Constructor with argument.
        /// </summary>
        /// <param name="args">Arguments.</param>
        public InputChecker(string[] args)
        {
            if (args.Length != 2)
            {
                throw new Exception("wrong number of arguments.");
            }

            inputValue = Convert.ToInt32(args[0]);
            newRadix = Convert.ToInt32(args[1]);

            if (newRadix < MinRadixByCondition || newRadix > MaxRadixByCondition)
            {
                throw new Exception("wrong radix.");
            }
        }
    }
}
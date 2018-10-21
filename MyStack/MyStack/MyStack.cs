using System;

namespace MyStack
{
    /// <summary>
    /// My stack.
    /// </summary>
    class MyStack
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                Stack<int> myStack = new Stack<int>(10);

                myStack.Push(10);
                myStack.Push(14);
                myStack.Push(15);

                myStack.Pop();
                myStack.Pop();

                Console.WriteLine(myStack.Pop());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error: " + e.Message);
            }
        }
    }
}
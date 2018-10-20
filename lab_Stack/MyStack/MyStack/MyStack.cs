using System;

namespace MyStack
{
    class MyStack
    {
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
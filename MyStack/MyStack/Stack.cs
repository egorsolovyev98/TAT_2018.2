using System;

namespace MyStack
{
    /// <summary>
    /// Stack.
    /// </summary>
    public class Stack<T>
    {
        /// <summary>
        /// The capacity.
        /// </summary>
        private int capacity;

        /// <summary>
        /// The actual size of stack.
        /// </summary>
        private int actualSize;


        /// <summary>
        /// The array of items.
        /// </summary>
        private T[] arrayOfItems;

        /// <summary>
        /// The default capacity.
        /// </summary>
        private const int DefaultCapacity = 10;


        /// <summary>
        /// Stack constructor class.
        /// </summary>
        public Stack()
        {
            capacity = DefaultCapacity;
            arrayOfItems = new T[capacity];
        }


        /// <summary>
        /// Stack constructor class.
        /// </summary>
        /// <param name="capacity">Capacity.</param>
        public Stack(int capacity)
        {
            if (capacity < 1)
            {
                throw new Exception("stack size must be bigger than 0.");
            }

            this.capacity = capacity;
            arrayOfItems = new T[capacity];
        }


        /// <summary>
        /// Size of stack.
        /// </summary>
        /// <returns>The size.</returns>
        public int Size()
        {
            return actualSize;
        }


        /// <summary>
        /// Check if stack is empty.
        /// </summary>
        /// <value><c>true</c> if is empty; otherwise, <c>false</c>.</value>
        public bool IsEmpty
        {
            get 
            { 
                return actualSize == 0; 
            }

        }


        /// <summary>
        /// Push item to stack.
        /// </summary>
        /// <param name="item">Item.</param>
        public void Push (T item)
        {
            if (actualSize == arrayOfItems.Length)
            {
                Resize();
            }

            arrayOfItems[actualSize++] = item;
        }


        /// <summary>
        /// Pop item from stack.
        /// </summary>
        /// <returns>Item from stack.</returns>
        public T Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("stack is empty.");
            }

            T item = arrayOfItems[--actualSize];
            arrayOfItems[actualSize] = default(T);

            return item;
        }


        /// <summary>
        /// Resize the arrayOfItems.
        /// </summary>
        private void Resize()
        {
            capacity *= 2;
            T[] newArray = new T[capacity];

            for (int i = 0; i < arrayOfItems.Length; i++)
            {
                newArray[i] = arrayOfItems[i];
            }

            arrayOfItems = newArray;
        }
    }
}
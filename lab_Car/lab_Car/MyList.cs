namespace lab_Car
{
    /// <summary>
    /// My list.
    /// </summary>
    public class MyList
    {
        /// <summary>
        /// Node.
        /// </summary>
        public class Node
        {
            /// <summary>
            /// Gets or sets the car.
            /// </summary>
            /// <value>The car.</value>
            public Car car { get; set; }


            /// <summary>
            /// Gets or sets the previous.
            /// </summary>
            /// <value>The previous.</value>
            public Node prev { get; set; }


            /// <summary>
            /// Gets or sets the next.
            /// </summary>
            /// <value>The next.</value>
            public Node next { get; set; }


            /// <summary>
            /// Initializes a new instance of the <see cref="T:lab_Car.MyList.Node"/> class.
            /// </summary>
            /// <param name="car">Car.</param>
            public Node(Car car)
            {
                this.car = car;
                prev = null;
                next = null;
            }
        }


        /// <summary>
        /// Gets or sets the head.
        /// </summary>
        /// <value>The head.</value>
        public Node head { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="T:lab_Car.MyList"/> class.
        /// </summary>
        public MyList()
        {
            head = null;
        }


        /// <summary>
        /// Adds element to the head.
        /// </summary>
        /// <param name="car">Car.</param>
        public void AddHead(Car car)
        {
            if (head == null)
            {
                head = new Node(car);
            }
            else
            {
                Node insertNode = new Node(car);
                head.prev = insertNode;
                insertNode.next = head;
                head = insertNode;
            }
        }


        /// <summary>
        /// Search the specified car.
        /// </summary>
        /// <returns>The MyList with cars.</returns>
        /// <param name="car">Car.</param>
        public MyList Search(Car car)
        {
            Node tmpHead = head;
            MyList list = new MyList();

            while(tmpHead != null)
            {
                if (car.Compare(tmpHead.car))
                {
                    list.AddHead(car);
                }

                tmpHead = tmpHead.next;
            }

            return list;
        }
    }
}
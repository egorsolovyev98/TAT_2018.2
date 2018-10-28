namespace lab_Car
{
    /// <summary>
    /// My list.
    /// </summary>
    public class MyList
    {   
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
                    list.AddHead(tmpHead.car);
                }

                tmpHead = tmpHead.next;
            }

            return list;
        }
    }
}
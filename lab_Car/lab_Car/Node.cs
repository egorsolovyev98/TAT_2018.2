namespace lab_Car
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
}
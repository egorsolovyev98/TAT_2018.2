using System;

namespace lab_Car
{
    public class MyList
    {
        public class Node
        {
            public Car car { get; set; }
            public Node prev { get; set; }
            public Node next { get; set; }

            public Node(Car car)
            {
                this.car = car;
                prev = null;
                next = null;
            }
        }

        public Node head { get; set; }

        public MyList()
        {
            head = null;
        }

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
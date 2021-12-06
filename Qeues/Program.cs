
using System;
using System.Collections.Generic;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// define queue
            Queue<int> queues = new Queue<int>();
            queues.Enqueue(1);
            Console.WriteLine("The top value is {0}", queues.Peek());
            queues.Enqueue(2);
            Console.WriteLine("The top value is {0}", queues.Peek());
            queues.Enqueue(3);
            Console.WriteLine("The top value is {0}", queues.Peek());

            while (queues.Count > 0) {
                Console.WriteLine("The queued item is {0}", queues.Dequeue());

                Console.WriteLine("Total is {0}", queues.Count);
            }*/

            Queue<Order> orderQueue = new Queue<Order>();

            foreach (Order o in ReceiveOrdersFromBranch1())
            {
                orderQueue.Enqueue(o);
            }

            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                orderQueue.Enqueue(o);
            }

            while (orderQueue.Count > 0)
            {
                Order currentQueue = orderQueue.Dequeue();

                currentQueue.ProcessOrder();
            }
        }

        static Order[] ReceiveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,6),
                new Order(6,10)
            };
            return orders;
        }


        static Order[] ReceiveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(4,50),
                new Order(21,24),
                new Order(62,1500)
            };
            return orders;
        }
    }

    class Order
    {
        public int OrderId;

        public int OrderQuanity;

        public Order (int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuanity = orderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            Console.WriteLine("Hello Stack using Linked List!");
            CreateStack createStatck = new CreateStack();
            createStatck.Push(70);
            createStatck.Push(30);
            createStatck.Push(56);
            createStatck.Display();

            //UC2
            Console.WriteLine("Hello Stack using Linked List!");
            PeakPop Stack = new PeakPop();
            Stack.Push(70);
            Stack.Push(30);
            Stack.Push(56);
            Stack.Display();
            Stack.Peek();
            Stack.Pop();
            Stack.IsEmpty();
            Stack.Display();
            Console.ReadKey();

            
            //UC3
            Console.WriteLine("Hello Queue using linked List!");
            CreateQueue Queue = new CreateQueue();
            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(70);
            Queue.Display();// this.top=this.top.next
            Console.ReadKey();

            //UC4
            Console.WriteLine("Hello Queue using Linked List!");
            Dequeue DQueue = new Dequeue();
            DQueue.Enqueue(56);
            DQueue.Enqueue(30);
            DQueue.Enqueue(70);
            DQueue.Dequeu();
            DQueue.Display();// this.top=this.top.next
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections;
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
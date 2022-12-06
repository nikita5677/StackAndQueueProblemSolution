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
            //UC3
            Console.WriteLine("Hello Queue using linked List!");
            CreateQueue Queue = new CreateQueue();
            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(70);
            Queue.Display();// this.top=this.top.next
            Console.ReadKey();
        }
    }
}
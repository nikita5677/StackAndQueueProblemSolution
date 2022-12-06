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
        }
    }
}
using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Program");

            LinkedList L = new LinkedList();

            Console.WriteLine("Adding elements into Linkedlist using AddLast Method:");
            L.Add(56);
            Console.WriteLine("Before Appending ");
            L.Display();
            Console.WriteLine("After Appending ");
            L.Append(30);
            L.Append(70);
            L.Display();


        }
    }
    }


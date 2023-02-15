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
            L.Add(30);
            L.Add(70);
            L.Display();

        }
    }
    }


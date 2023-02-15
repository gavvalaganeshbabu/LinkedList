using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Program");

            LinkedList L = new LinkedList();
            L.Add(56);
            L.Add(70);
            Console.WriteLine("Before Inserting ");
            L.Display();
            Console.WriteLine("After  Inserting ");
            L.InsertElement(2,30);
            L.Display();


        }
    }
    }


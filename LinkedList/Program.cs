using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Program");

            LinkedList L = new LinkedList();
            Node new_node;
            new_node = L.newNode(56);
            L.sortedList(new_node);
            new_node = L.newNode(30);
            L.sortedList(new_node);
            new_node = L.newNode(40);
            L.sortedList(new_node);
            new_node = L.newNode(70);
            L.sortedList(new_node);
            L.Display();
        }
    }
    }


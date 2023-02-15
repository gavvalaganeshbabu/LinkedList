using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList L=new LinkedList();
            L.Add(56);
            L.Add(30);   
            L.Add(70);
            L.Display();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node Node = new Node(data);
            if (this.head == null)
            {
                this.head = Node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = Node;
            }
            Console.WriteLine("{0} Element inserted into LinkedList", Node.data);
        }

        internal Node Search(int value)
        {
            int Count = 1;
            while (head != null)
            {
                if (head.data == value)
                {
                    Console.WriteLine($"\n The Value is {value} at {Count} position");
                    return head;
                }
                head = head.next;
                Count++;
            }
            return null;
        }
    }
}


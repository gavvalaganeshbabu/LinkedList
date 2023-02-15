using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class LinkedList
    {
        internal Node head;
        internal void AddLast(int data)
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
        internal void AddFirst(int data)
        {
            Node Node = new Node(data);
            Node.next = this.head;
            this.head = Node;
            Console.WriteLine("{0} Element inserted into LinkedList", Node.data);
        }
            internal void Display()
            {
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine(" Linked List is Empty ");
                }
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }


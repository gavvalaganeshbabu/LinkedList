using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class LinkedList
    {
        internal Node head;
        
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }

       internal void sortedList(Node new_node)
        {
            
            Node current;


            if (head == null || head.data >= new_node.data)
            {
                new_node.next = head;
                head = new_node;
            }
            else
            {
                current = head;

                while (current.next != null && current.next.data < new_node.data)
                    current = current.next;

                new_node.next = current.next;
                current.next = new_node;
            }
    
       }
        internal Node newNode(int data)
        {
            Node x = new Node(data);
            return x;
        }


    }
}


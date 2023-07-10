using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stack_Queue
{
    public class StackLinkedList
    {
        public Node top;
        public StackLinkedList()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;
        }
        public void Display()
        {
            Node temp = top;
            if(temp==null) 
            {
                Console.WriteLine("Stack is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            while (top != null)
            {
                Console.WriteLine("The Peek Element is "+top.data);
                Console.WriteLine("The Element Removed  is "+top.data);
                top = top.next;
            }
        }
       

    }
}

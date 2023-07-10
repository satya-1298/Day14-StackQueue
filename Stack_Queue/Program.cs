using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackLinkedList stackLinkedList = new StackLinkedList();
            QueueLinkedList queueLinkedList = new QueueLinkedList();
            while (true)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1-Inserting Elements in Stack");
                Console.WriteLine("2-Peek the Element");
                Console.WriteLine("3-Inserting elements in Queue");
                Console.WriteLine("4-Deleting Elements from Queue");
                Console.WriteLine("****************");
                int option =Convert.ToInt32(Console.ReadLine());
                switch(option) 
                {
                    case 1:
                        Console.WriteLine("Stack Insertion");
                        stackLinkedList.Push(70);
                        stackLinkedList.Push(30);
                        stackLinkedList.Push(56);
                        stackLinkedList.Display();
                        Console.WriteLine("****************");
                        break;
                    case 2:
                        stackLinkedList.Peek();
                        Console.WriteLine("****************");
                        stackLinkedList.Display();
                        Console.WriteLine("****************");
                        break;
                    case 3:
                        Console.WriteLine("Queue Insertion");
                        Console.WriteLine("****************");
                        queueLinkedList.Enqueue(56);
                        queueLinkedList.Enqueue(30);
                        queueLinkedList.Enqueue(70);
                        break;
                    case 4:
                        queueLinkedList.Dequeue();
                        Console.WriteLine("****************");
                        queueLinkedList.Display();
                        break;
                    default: Console.WriteLine("Enter Invalid Option");
                        break;
                }
            }
        } 
    }
}

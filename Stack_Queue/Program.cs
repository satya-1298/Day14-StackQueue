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
            while (true)
            {
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1-Inserting Elements in Stack");
                Console.WriteLine("2-Peek the Element");
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
                    default: Console.WriteLine("Enter Invalid Option");
                        break;
                }
            }
        } 
    }
}

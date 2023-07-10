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
            while (true)
            {
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1-Inserting Elements in Stack");
                int option =Convert.ToInt32(Console.ReadLine());
                switch(option) 
                {
                    case 1:
                        Console.WriteLine("Stack Insertion");
                        StackLinkedList stackLinkedList = new StackLinkedList();
                        stackLinkedList.Push(70);
                        stackLinkedList.Push(30);
                        stackLinkedList.Push(56);
                        stackLinkedList.Display();
                        break;
                    default: Console.WriteLine("Enter Invalid Option");
                        break;
                }
            }
        } 
    }
}

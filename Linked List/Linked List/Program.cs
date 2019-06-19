using System;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ConsoleLinkedList();
        }

        static void ConsoleLinkedList()
        {
            LinkList list = new LinkList(9);

            list.Insert(4);
            list.Insert(9);
            list.Insert(1);

            list.Print();
        }


    }
}

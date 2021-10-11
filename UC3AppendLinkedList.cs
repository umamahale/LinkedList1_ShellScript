using System;
using System.Collections.Generic;

namespace UC3LinkedList
{
    class UC3AppendLinkedList
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("56");
            list1.Add("30");
            Console.WriteLine("First list...");
            foreach (string value in list1)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Second list...");
            List<string> list2 = new List<string>();

            list2.Add("70");
          
            foreach (string value in list2)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("After Append...");
            list1.AddRange(list2);
            foreach (string value in list1)
            {
                Console.WriteLine(value);
            }
        }
    }
}

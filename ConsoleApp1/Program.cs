using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectLinkedList
{

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(2);
            list.Delete(2);

            foreach(var item in list)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadLine();
        }
    }
}

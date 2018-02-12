using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderUnorderList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            UnorderedArrayList u = new UnorderedArrayList();
            u.print();
            int var = 5;
            u.insert(ref var);
            var = 12;
            u.insert(ref var);
            var = 2;
            u.insert(ref var);
            var = 29;
            u.insert(ref var);
            u.print();
            var = 5;
            u.remove(ref var);
            u.print();

            Console.ReadKey();
        }
    }
}

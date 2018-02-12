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
            UnorderedArrayList u = new UnorderedArrayList();
            Console.WriteLine("INITIAL LIST. LIST SHOULD BE EMPTY");
            u.Print();

            int[] values = { 1, 3, 5, 7, 5, 9, 3, 2, 4, 6, 8, 11, 14, 13, 2, 15, 12, 14, 2, 3, 7, 9, 6, 12, 2 };
            u.InsertValues(ref values);

            Console.WriteLine("\nLIST LOADED. LIST SHOULD NOT BE EMPTY. LIST SHOULD HAVE 25 VALUES.");
            u.Print();
            u.PrintListInformation();

            Console.WriteLine("\nCALL REMOVE(3).  WILL REMOVE FIRST VALUE OF 3 FROM LIST(POSITION 2) BY REPLACING WITH END OF LIST VALUE (2) AND SHORTENING LIST. LENGTH SHOULD BE 24.  ");
            int value = 3;
            u.Remove(ref value);
            u.Print();
            u.PrintListInformation();

            Console.WriteLine("\nCALL REMOVEALL(3).  WILL REMOVE ALL VALUES OF 3 FROM LIST (POSITIONS 7 & POSITION 18). LENGTH SHOULD BE 22. ");
            u.RemoveAll(ref value);
            u.Print(); 
            u.PrintListInformation();
            Console.ReadKey();
        }

        

        public static void TestRemove()
        {

        }

        public static void TestInsertionSort()
        {

        }

        public static void TestRemoveAll()
        {

        }

        public static void TestMinMax()
        {

        }
    }
}

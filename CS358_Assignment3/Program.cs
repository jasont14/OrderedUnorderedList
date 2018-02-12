using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderUnorderList
{
    class Program
    {
        const string title = "ORDERED LIST UNORDERED LIST TEST";        

        static void Main(string[] args)
        {
            bool run = true;
            Console.WriteLine(title);

            Console.WriteLine("\nThis console application will test the following functions found in UnorderArrayList.cs\n");
            Console.WriteLine("\t+ Remove()");
            Console.WriteLine("\t+ RemoveAll()");
            Console.WriteLine("\t+ Min()");
            Console.WriteLine("\t+ Max()");
            Console.WriteLine("\t+ InsertionSort()");

            Console.Write("\nThe following list will be initialized for each test: ");
            UnorderedArrayList u = new UnorderedArrayList();
            u.InsertValues(initializeList());
                        
            u.Print(); //Prints List

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\n'c' to Continue, or 'q' to Quit: ");
            char result = Convert.ToChar(Console.ReadKey().KeyChar);
            
            if (result == 'q')
            {
                run = false;
            }            

            while (run)
            {
                if (TestRemove() == 'q')
                {
                    run = false;
                    break;
                }
                else if (TestRemoveAll() == 'q')
                {
                    run = false;
                    break;
                }
                else if (TestMax() == 'q')
                {
                    run = false;
                    break;
                }
                else if (TestMin() == 'q')
                {
                    run = false;
                    break;
                }
                else if (TestInsertionSort() == 'q')
                {
                    run = false;
                    break;
                }
                
                break;
            }            
        }

        private static int[] initializeList()
        {
            int[] result = { 1, 3, 5, 7, 5, 9, 3, 2, 4, 6, 8, 11, 14, 13, 2, 15, 12, 14, 2, 3, 7, 9, 6, 12, 2 };

            return result;

        }

        public static int GetRandomNumber()
        {
            int[] list = initializeList();
            Random rand = new Random();
            int num = rand.Next(0, list.Length - 1);

            return num;
        }

        public static char TestRemove()
        {
            char result = 'q';
            string strRemoved = "";
            string test = "Remove() Test";
            string testDescription = "This test randomly selects a number from the list and calls Remove(). The method will remove the first occurence of the selected number by replacing it with the last number and shortening the list.";

            UnorderedArrayList list = new UnorderedArrayList();
            list.InsertValues(initializeList());

            int num = GetRandomNumber();           
            int valueSelected = list.GetValueAtLocation(num);
            int locationOfSelected = list.GetFirstPositionOfValue(valueSelected);
            int[] allLocationsOfSelected = { locationOfSelected };
            int valueAtEnd = list.GetValueAtLocation(list.GetLength() - 1);
            strRemoved = locationOfSelected.ToString();

            list.Remove(valueSelected);

            ReportRemoveTestsToConsole(test, testDescription, valueSelected.ToString(),allLocationsOfSelected, list);

            Console.Write("\nPress 'r' to Repeat, 'c' to Continue, or 'q' to Quit: ");

            result = Convert.ToChar(Console.ReadKey().KeyChar);

            if (result == 'r')
            {
                TestRemove();
            }

            return result;
            
        }

        public static char TestRemoveAll()
        {
            char result = 'q';
            string test = "RemoveAll() Test";
            string testDescription = "This test randomly selects a number from the list and calls RemoveAll(). The method will remove all occurences of the selected number by replacing the number with the last number and shortening the list by 1 for each replacement.";
            
            UnorderedArrayList list = new UnorderedArrayList();
            list.InsertValues(initializeList());

            int num = GetRandomNumber();
            int valueSelected = list.GetValueAtLocation(num);
            int[] allLocationsOfSelected = list.GetAllPositionsOfValue(valueSelected);
            int valueAtEnd = list.GetValueAtLocation(list.GetLength() - 1);
            
            int[] actualRemoved = list.RemoveAll(valueSelected);


            ReportRemoveTestsToConsole(test, testDescription, valueSelected.ToString(), actualRemoved, list);

            Console.Write("\nPress 'r' to Repeat, 'c' to Continue, or 'q' to Quit: ");

            result = Convert.ToChar(Console.ReadKey().KeyChar);

            if (result == 'r')
            {
                TestRemoveAll();
            }

            return result;
        }

        private static void exit()
        {
            
        }

        public static char TestInsertionSort()
        {
            WriteTestReportHeader("Insertion Sort Test", "Since position 1 is trivally sorted, insertion sort begins at position 2 and compares the value of the item to all item values that preceed it in the list.  It will be moved to the left most location until it's value is found to be the greater, if at all. The algorithm will then move to position 3 repeat and continue for each item position until it reaches the end of the list.");

            int[] p = initializeList();
            UnorderedArrayList l = new UnorderedArrayList();
            l.InsertValues(p);
            l.Print();

            Console.WriteLine();
            Console.WriteLine("Begin Insertion Sort");
            Console.WriteLine();

            int nextItemToSort = 1;
            bool go = true;

            while (go)
            {
                Console.Write("Position {0}:\t",(nextItemToSort+1).ToString());
                l.InsertionSortDemo(nextItemToSort);
                l.Print();

                nextItemToSort++;

                if(nextItemToSort== l.GetLength())
                {
                    go = false;
                }
            }

            Console.Write("\nPress 'r' to Repeat or 'q' to Quit: ");

            char result = Convert.ToChar(Console.ReadKey().KeyChar);

            if (result == 'r')
            {
                TestInsertionSort();
            }

            return result;



        }
        
        public static char TestMax()
        {
            char result = 'q';
            string test = "Max() Test";
            string testDescription = "This test calls Max().  The method will return the list item with the greatest value.";

            UnorderedArrayList list = new UnorderedArrayList();
            list.InsertValues(initializeList());

            int num = GetRandomNumber();
            int max = list.Max();

            ReportMinMaxTestsToConsole(test, testDescription, max);

            Console.Write("\nPress 'r' to Repeat, 'c' to Continue, or 'q' to Quit: ");

            result = Convert.ToChar(Console.ReadKey().KeyChar);

            if (result == 'r')
            {
                TestMax();
            }

            return result;
        }

        public static char TestMin()
        {
            char result = 'q';
            string test = "Min() Test";
            string testDescription = "This test calls Min().  The method will return the list item with the least value.";

            UnorderedArrayList list = new UnorderedArrayList();
            list.InsertValues(initializeList());

            int num = GetRandomNumber();
            int min = list.Min();

            ReportMinMaxTestsToConsole(test, testDescription, min);

            Console.Write("\nPress 'r' to Repeat, 'c' to Continue, or 'q' to Quit: ");

            result = Convert.ToChar(Console.ReadKey().KeyChar);

            if (result == 'r')
            {
                TestMin();
            }

            return result;
        }

        public static void WriteTestReportHeader(string nameOfTest, string description)
        {
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine();

            for (int i = 0; i < nameOfTest.Length + 6; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("*  {0}  *", nameOfTest);

            for (int i = 0; i < nameOfTest.Length + 6; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.WriteLine(description);

            Console.Write("\nLIST: ");
        }

        public static void ReportMinMaxTestsToConsole(string nameOfTest, string description, int maxValueReported)
        {
            WriteTestReportHeader(nameOfTest, description);

            UnorderedArrayList l = new UnorderedArrayList();
            l.InsertValues(initializeList());
            l.Print();

            Console.WriteLine();
            Console.WriteLine("{0} Reported:  {1}",nameOfTest, maxValueReported.ToString());

            Console.Write("Sorted List: ");

            l.sort();
            l.Print();

            int v = 0;
            if(nameOfTest == "Max() Test")
            {
                v = l.GetValueAtLocation(l.GetLength() - 1);
            }
            else
            {
                v = l.GetValueAtLocation(v);
            }
            Console.WriteLine();
            Console.WriteLine("{0} Reported {1}. This matches {2} from the sorted list above.",nameOfTest, maxValueReported.ToString(), v.ToString());

        }

        public static void ReportRemoveTestsToConsole(string nameOfTest, string description, string valSelected, int[] locSelected, UnorderedArrayList resultList)
        {
            WriteTestReportHeader(nameOfTest, description);

            UnorderedArrayList list = new UnorderedArrayList();
            list.InsertValues(initializeList());
            list.Print();

            Console.WriteLine("\nThe value {0} was randomly selected.", valSelected);

            string strSelections = "";
            int strCounter = 0;
            foreach (int s in locSelected)
            {
                if (strCounter == locSelected.Length - 1)
                {
                    strSelections += (s + 1).ToString();
                    strCounter++;
                    break;
                }
                else
                {
                    strSelections += (s + 1).ToString() + ", ";
                    strCounter++;
                }
            }
            
            Console.WriteLine("The value {0} was found at position(s): {1} ", valSelected, strSelections);
            int countRemoval = 0;

            for (int i = 0; i<locSelected.Length; i++)
            {
                if (locSelected[i].Equals(list.GetLength()-1))
                {
                    Console.WriteLine("The value {0} is at the end of the list and cannot be moved", valSelected);                    
                }
                else
                {
                    Console.WriteLine("The method will replace the value {0} at the {1} position with {2} from the end.", valSelected,(locSelected[i]+1).ToString(),list.GetValueAtLocation(list.GetLength()-(i+1)).ToString());
                }
                countRemoval = i + 1;
            }

            Console.WriteLine();
            Console.WriteLine("The method peformed a total of {0} replacement(s).\n", countRemoval.ToString());

            Console.WriteLine();
            Console.Write("Original List:\t ");
            list.Print();
            Console.Write("Updated List:\t ");
            resultList.Print();
        }
    }
}

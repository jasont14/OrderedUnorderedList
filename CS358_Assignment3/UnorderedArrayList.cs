using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderUnorderList
{
    public class UnorderedArrayList
    {
        protected int[] list;
        protected int next;
        protected int length;

        public UnorderedArrayList()
        {
            list = new int[100];
            next = 0;
        }


        public void Insert(int item)
        {
            list[next] = item;
            next++;
        }

        public void InsertValues(int[] items)
        {
            for(int i=0; i<items.Length; i++)
            {
                list[i] = items[i];
                next++;
            }
        
        }
    
        public void Remove(int item)
        {
            if (next == 0)
            {
            }
            else
            {           
                for (int i = 0; i < next; i++)
                {
                    if (item.Equals(list[i])) //find value, if it exists
                    {                        
                        list[i] = list[next - 1]; //Replace item with last item
                        list[next - 1] = 0;    //Remove last item                    
                        next--;
                        break;
                    }
                }
            }
        
        }

        public int GetLength()
        {
            return next;
        }

        public int GetValueAtLocation(int item)
        {
            return list[item];
        }
               
        public int[] RemoveAll(int selectedItem)
        {
            bool cont = true;
            List<int> removeList = new List<int>();
            while (cont)
            {
                int item = GetFirstPositionOfValue(selectedItem);
                list[item] = list[next - 1]; //Replace item with last item
                list[next - 1] = 0;    //Remove last item                    
                removeList.Add(item);
                next--;             

                if(Array.IndexOf(list,selectedItem) == -1)
                {
                    cont = false;
                }
            }

            return removeList.ToArray();
        }

        public int GetFirstPositionOfValue(int item)
        {
            int result = Array.IndexOf(list, item);
            
            return result;

        }

        public void TrimList()
        {
            int[] trimmedList = new int[next];

            for (int i=0; i<next; i++)
            {
                trimmedList[i] = list[i];
            }

            list = trimmedList;
        }

        public void sort()
        {
            TrimList();

            for (int i = 0; i < list.Length; i++)
            {
                int j = i;
                int curMin = list[i];

                while (j > 0 && list[j - 1] > curMin)
                {
                    list[j] = list[j - 1];
                    j--;
                }

                list[j] = curMin;
            }

        }

        public void InsertionSortDemo(int sortPosition)
        {
            int[] myArray = list;

            int j = sortPosition;
            int curMin = myArray[sortPosition];

            while (j > 0 && myArray[j - 1] > curMin)
            {
                myArray[j] = myArray[j - 1];
                j--;
            }

            myArray[j] = curMin;           

        }

        public int[] GetAllPositionsOfValue(int item)
        {
            int[] v = list.Select((b, i) => b == item ? i : -1).Where(i => i != -1).ToArray();

            return v;
        }
               

        public int[] GetList()
        {
            return list;
        }

        public int Min()
        {
            int result = list[0];

            //loop through list and set lowest

            for(int i = 0; i<next; i++)
            {
                if (list[i] < result) //If lower than current assign as lowest
                {
                    result = list[i];
                }
            }

            return result;
        }

        public int Max()
        {
            int result = list[0];

            //loop through list and set lowest
            for (int i = 0; i < next; i++)
            {
                if (list[i] > result)//If greater than current assign as highest
                {
                    result = list[i];
                }
            }

            return result;
        }

        public void Print()  //Print Array List to screen
        {
            for (int i = 0; i < next; i++)
            {
                Console.Write(" " + list[i]);  //Modified to print accross screen
            }

            Console.WriteLine();
        }

        public void PrintListInformation()
        {
            Console.WriteLine("\nLIST LENGTH:{0} \n\rFIRST ENTRY VALUE: {1} \n\rLAST ENTRY VALUE: {2} \n\rMIN VALUE: {3} \n\rMAX VALUE: {4}", next.ToString(), list[0].ToString(), list[next - 1].ToString(), Min().ToString(), Max().ToString());
        }
    }

}
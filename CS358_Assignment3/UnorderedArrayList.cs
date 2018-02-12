using System;

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


        public void Insert(ref int item)
        {
            list[next] = item;
            next++;
        }

        public void InsertValues(ref int[] items)
        {
            for(int i=0; i<items.Length; i++)
            {
                list[i] = items[i];
                next++;
            }
        
        }
    
        public void Remove(ref int item)
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
               
        public void RemoveAll(ref int item)
        {
            for(int i=0; i<next; i++)
            {
                if (item.Equals(list[i]))
                {
                    list[i] = list[next - 1]; //Replace item with last item
                    list[next - 1] = 0;    //Remove last item                    
                    next--;
                }
            }

        }

        public int Min()
        {
            int result = list[0];

            //loop through list and set lowest

            for(int i = 0; i<next; i++)
            {
                if (list[i] < result)
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
                if (list[i] > result)
                {
                    result = list[i];
                }
            }

            return result;
        }

        public void Print()
        {
            Console.Write("LIST: ");

            for (int i = 0; i < next; i++)
            {
                Console.Write(" " + list[i]);
            }

            Console.WriteLine();
        }

        public void PrintListInformation()
        {
            Console.WriteLine("\nLIST LENGTH:{0} \n\rFIRST ENTRY VALUE: {1} \n\rLAST ENTRY VALUE: {2} \n\rMIN VALUE: {3} \n\rMAX VALUE: {4}", next.ToString(), list[0].ToString(), list[next - 1].ToString(), Min().ToString(), Max().ToString());
        }
    }

}
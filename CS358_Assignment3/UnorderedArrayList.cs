using System;

namespace OrderUnorderList
{
    public class UnorderedArrayList
    {
        protected int[] list;
        protected int next;

        public UnorderedArrayList()
        {
            list = new int[100];
            next = 0;
        }


        public void insert(ref int item)
        {
            list[next] = item;
            next++;
        }
    
        public void remove(ref int item)
        {
            if (next == 0)
            {
            }
            else
            {
            //find value, if it exists
                for (int i = 0; i < next; i++)
                {
                    if (item.Equals(list[i]))
                    {
                        for (int j = i; j < next; j++) list[j] = list[j + 1];
                        next--;
                        break;
                    }
                }
            }
        }

        public void print()
        {
            for (int i = 0; i < next; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine();
        }
    }

}
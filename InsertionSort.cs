using System;
using System.Collections.Generic;
using System.Text;

namespace SortSearch
{
    class InsertionSort
    {
        public static void insertionSortAscending(int[] data)
        {
            int counter = 0; //To count number of steps
            int n = data.Length;
            for (int i = 0; i < n; i++)
            {
                int item = data[i];
                int ins = 0;
                for (int j = i - 1; j >= 0 && ins != 1;)
                {
                    counter++; //Adds 1 to number of steps
                    
                    if (item < data[j])
                    {
                        //Moves number greater than the user inputted by the user ahead
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    else ins = 1;
                }
            }
            
            Program.PrintArray(data);
            Console.WriteLine($"\nInsertion Sort took {counter} steps to sort in ascending order\n");




        }


        public static void insertionSortDescending(int[] data)
        {
            int counter = 0;
            int n = data.Length;
            for (int i = 0; i < n; i++)
            {
                int item = data[i];
                int ins = 0;
                for (int j = i - 1; j >= 0 && ins != 1;)
                {
                    counter++;
                    if (item > data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    else ins = 1;
                }
            }

            Program.PrintArray(data);
            Console.WriteLine($"\nInsertion Sort took {counter} steps to sort in descending order");




        }
    }
}


    


using System;
using System.Collections.Generic;
using System.Text;

namespace SortSearch
{
    
    class QuickSort
    {
        class counter //so that variable can be accessed anywhere in the code
        {
            public static int descendingStepCounter = 0;
            public static int ascendingStepCounter = 0;
        }
        public static void QuickSortAscending(int[] data)
        {
            Quick_Sort_Ascending(data, 0, data.Length - 1);
            Program.PrintArray(data);
            Console.WriteLine($"\nQuick sort took {counter.ascendingStepCounter} steps to sort in ascending order");
        }

        public static void QuickSortDescending(int[] data)
        {
            Quick_Sort_Descending(data, 0, data.Length - 1);
            Program.PrintArray(data);
            Console.WriteLine($"\nQuick sort took {counter.descendingStepCounter} steps to sort in descending order ");
        }


        private static void Quick_Sort_Ascending(int[] data, int left, int right)
        {
            int i, j;
            int pivot, temp;

            i = left;
            j = right;
            pivot = data[(left + right) / 2];

            do
            {
                while ((data[i] < pivot) && (i < right)) i++;
                while ((pivot < data[j]) && (j > left)) j--;
                counter.ascendingStepCounter++;

                if (i <= j)
                {
                    //Swapping array i and j
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j) Quick_Sort_Ascending(data, left, j);
            if (i < right) Quick_Sort_Ascending(data, i, right);


        }

        private static void Quick_Sort_Descending(int[] data, int left, int right)
        {
            int i, j;
            int pivot, temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2];

            do
            {
                while ((data[i] > pivot) && (i < right)) i++;
                while ((pivot > data[j]) && (j > left)) j--;
                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                    counter.descendingStepCounter++;
                }
            } while (i <= j);
            if (left < j)
            { 
                Quick_Sort_Descending(data, left, j);
            }

            if (i < right)
            { 
                Quick_Sort_Descending(data, i, right);
            }
        }
    }


}


    


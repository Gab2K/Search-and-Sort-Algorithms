using System;
using System.Collections.Generic;
using System.Text;

namespace SortSearch
{
    class HeapSort
    {
        public static void heapSortAscending(int[] data)
        {
            int counter = 0; //Used to count number of steps
            int n = data.Length;
            int i;

            for (i = (n - 1) / 2; i >= 0; i--)
            {
                counter++; //Adds 1 to the number of steps
                Max_Heapify_Ascending(data, n, i);
            }

            //Extract elements from the heap individually
            for (i = n - 1; i > 0; i--)
            {
                //Moves root to the end
                int temp = data[i];
                data[i] = data[0];
                data[0] = temp;
                n--;
                Max_Heapify_Ascending(data, n, 0);
            }

            Program.PrintArray(data);
            Console.WriteLine($"\nHeap Sort took {counter} steps to sort in ascending order\n");
        }


        public static void heapSortDescending(int[] data)
        {
            int counter = 0;
            int n = data.Length;
            int i;

            for (i = (n - 1) / 2; i >= 0; i--)
            {
                counter++;
                Max_Heapify_Descending(data, n, i);
            }

            for (i = n - 1; i > 0; i--)
            {
                int temp = data[i];
                data[i] = data[0];
                data[0] = temp;
                n--;
                Max_Heapify_Descending(data, n, 0); //Call Max_Heapify
            }

            Program.PrintArray(data);
            Console.WriteLine($"\nHeap Sort took {counter} steps to sort in descending order\n");
        }





        private static void Max_Heapify_Ascending(int[] data, int n, int Index)
        {
            int Left = (Index + 1) * 2 - 1;
            int Right = (Index + 1) * 2;
            int largest = 0;

            //If left side is larger than the number
            if (Left < n && data[Left] > data[Index])
            {
                largest = Left;
            }
            else
            {
                largest = Index;
            }
            //If right side is larger than the number
            if (Right < n && data[Right] > data[largest])
            {
                largest = Right;
            }
            //If largest is not the number
            if (largest != Index)
            {
                //Swapping
                int temp = data[Index];
                data[Index] = data[largest];
                data[largest] = temp;
                Max_Heapify_Ascending(data, n, largest);
            }

        }

        private static void Max_Heapify_Descending(int[] data, int n, int Index)
        {
            int Left = (Index + 1) * 2 - 1;
            int Right = (Index + 1) * 2;
            int largest = 0;

            if (Left < n && data[Left] < data[Index])
            {
                largest = Left;
            }
            else
            {
                largest = Index;
            }

            if (Right < n && data[Right] < data[largest])
            {
                largest = Right;
            }

            if (largest != Index)
            {
                int temp = data[Index];
                data[Index] = data[largest];
                data[largest] = temp;
                Max_Heapify_Descending(data, n, largest);
            }

        }



    }
}

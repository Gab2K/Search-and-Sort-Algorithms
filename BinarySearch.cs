using System;
using System.Collections.Generic;
using System.Text;

namespace SortSearch
{
    class BinarySearch
    {
        public static int binarySearch(int[] data, int num)
        {
            int counter = 0; //To check how many steps it took to find the value
            int min = 0;
            int n = data.Length - 1;
            while (min <= n)
            {
                counter++;
                int mid = min + (n - min) / 2; // gets the mid number

                // Check if num is present at mid point
                if (data[mid] == num)
                {
                    Console.WriteLine($"The Binary Search took: {counter} steps\n");
                    return ++mid;
                }

                // If num is  greater then ignore left half 
                else if (data[mid] < num)
                    min = mid + 1;

                // If num is smaller then ignore right half 
                else
                    n = mid - 1;

            }
            // if we reach here, then the num was not present
            Console.WriteLine($"The Binary Search took: {counter} steps\n");
            return -1;
        }
    }
}

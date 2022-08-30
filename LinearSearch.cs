using System;
using System.Collections.Generic;
using System.Text;

namespace SortSearch
{
    class LinearSearch
    {
        public static bool linearSearch(int[] data, int num)
        {
            int counter = 0; // Used to count how many steps the program took 
            bool found = false;
            int n = data.Length;

            for (int i = 0; i < n; i++)
            {
                //Loops through the whole array and prints out an index if it finds user's number
                counter++; //Adds 1 to the number of steps
                if (data[i] == num)
                {
                    Console.WriteLine($"\n{num} found at index: {++i}\n");
                    found = true;
                }

            }
            Console.WriteLine($"\nLinear Search took {counter} steps\n");
            return found;



        }


    }
}

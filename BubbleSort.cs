using System;
using System.Collections.Generic;
using System.Text;

namespace SortSearch
{
    public class BubbleSort
    {
        public static void bubbleSortAscending(int[] data)
        {
            int counter = 0; //To count number of steps
            int n = data.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    counter++; //Adds 1 to the number of steps
                    if (data[j + 1] < data[j])
                    {
                        //Swaps temp and the array
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }



            }
            Program.PrintArray(data);
            Console.WriteLine($"\nBubble Sort took {counter} steps to sort in ascending order\n");
        }


        public static void bubbleSortDescending(int[] data)
        {
            int counter = 0;
            int n = data.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    counter++;
                    if (data[j + 1] > data[j])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }



            }
           Program.PrintArray(data);
            Console.WriteLine($"\nBubble Sort took {counter} steps to sort in descending order\n");

        }

        

       
    }

    
}





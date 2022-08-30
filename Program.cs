using System;
using System.IO;

namespace SortSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Loading text files into seperate arrays

            //Net_1_256
            string[] net_1_256_read = File.ReadAllLines("Net_1_256.txt");
            int[] net_1_256 = Array.ConvertAll(net_1_256_read, int.Parse);

            //Net_1_2048
            string[] net_1_2048_read = File.ReadAllLines("Net_1_2048.txt");
            int[] net_1_2048 = Array.ConvertAll(net_1_2048_read, int.Parse);

            //_Net_2_256
            string[] net_2_256_read = File.ReadAllLines("Net_2_256.txt");
            int[] net_2_256 = Array.ConvertAll(net_2_256_read, int.Parse);

            //_Net_2_2048
            string[] net_2_2048_read = File.ReadAllLines("Net_2_2048.txt");
            int[] net_2_2048 = Array.ConvertAll(net_2_2048_read, int.Parse);

            //Net_3_256
            string[] net_3_256_read = File.ReadAllLines("Net_3_256.txt");
            int[] net_3_256 = Array.ConvertAll(net_3_256_read, int.Parse);

            //Net_3_2048
            string[] net_3_2048_read = File.ReadAllLines("Net_3_2048.txt");
            int[] net_3_2048 = Array.ConvertAll(net_3_2048_read, int.Parse);



            bool correctInput = false;

            while (correctInput == false) //Loops until user doesn't enter a number between 1 and 6
            {
                Console.WriteLine($"1: Net_1_256 \n2: Net_1_2048 \n3: Net_2_256" +
                    $"\n4: Net_2_2048\n5: Net_3_256\n6: Net_3_2048\n");
                Console.Write("Choose an array to sort: ");
                string choice = Console.ReadLine();

                //Switch case to let user select which array they want to work with
                switch (choice)
                {
                    case "1":
                        correctInput = true;
                        SortingMenu(net_1_256);
                        SearchingMenu(net_1_256);
                        Console.WriteLine("\nPress enter to exit");
                        Console.ReadLine();
                        break;

                    case "2":
                        correctInput = true;
                        SortingMenu(net_1_2048);
                        SearchingMenu(net_1_2048);
                        Console.WriteLine("\nPress enter to exit");
                        Console.ReadLine();
                        break;

                    case "3":
                        correctInput = true;
                        SortingMenu(net_2_256);
                        SearchingMenu(net_2_256);
                        Console.WriteLine("\nPress enter to exit");
                        Console.ReadLine();
                        break;

                    case "4":
                        correctInput = true;
                        SortingMenu(net_2_2048);
                        SearchingMenu(net_2_2048);
                        Console.WriteLine("\nPress enter to exit");
                        Console.ReadLine();
                        break;

                    case "5":
                        correctInput = true;
                        SortingMenu(net_3_256);
                        SearchingMenu(net_3_256);
                        Console.WriteLine("\nPress enter to exit");
                        Console.ReadLine();
                        break;

                    case "6":
                        correctInput = true;
                        SortingMenu(net_3_2048);
                        SearchingMenu(net_3_2048);
                        Console.WriteLine("\nPress enter to exit");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine($"\nChoose a number between 1-6\n");
                        correctInput = false;
                        break;

                }
            }




        }


        //    ------    Functions ------






        //Function to display results from Sorting algorithms

        public static void PrintArray(int[] data)
        {
            int n = data.Length;
            // If array is 2048 long then display every 50th value
            if (n == 2048)
            {
                //Loop through the array and print out values
                for (int f = 0; f < n; f++)
                {
                    if (((f+1) % 50) == 0)
                    {
                        Console.WriteLine(data[f]);
                    }
                }
            }

            // If array is smaller than 2048 than display every 10th value
            else if (n < 2048)
            {
                //Loop through the array and print out values
                for (int f = 0; f < n; f++)
                {
                    if (((f+1)  % 10) == 0)
                    {
                        Console.WriteLine(data[f]);
                    }
                }
            }

        }


        //Gets the closest value for searching algorithms
        public static int closestValue(int[] data, int num)
        {
            int n = data.Length;
            for (int i = 0; i < n; i++) //Loops through the whole array
            {

                if (data[i] > num) //if index is bigger than number
                {
                    try
                    {
                        Console.WriteLine($"\nClosest value is {data[i - 1]} at index position {i}");
                        return 1; //Ends the function
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Console.WriteLine("\n----- Number not found -----");
                    }

                    break;
                }
                else
                {
                    if (data[i] >= num) //If index is bigger or equal to the number
                    {
                        Console.WriteLine($"\nClosest value is {data[i]} at index position {i}");
                        return 1; //Ends the function
                    }
                }
            }
            return -1;
        }



        //To let user choose how they want to sort the array

        private static void SortingMenu(int [] data)
        {
            bool correctInput = false;

            while (correctInput == false) //Loops until user doesn't enter a number between 1 and 4
            {
                Console.WriteLine("\n1. BubbleSort\n2. InsertionSort\n3. QuickSort\n4. HeapSort\n");
                Console.Write("How would you like to sort your array?: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        correctInput = true;
                        Console.WriteLine("\nDescending:\n");
                        BubbleSort.bubbleSortDescending(data);
                        Console.WriteLine("\nPress enter for Ascending\n");
                        Console.ReadLine();
                        BubbleSort.bubbleSortAscending(data);
                        break;

                    case "2":
                        correctInput = true;
                        Console.WriteLine("\nDescending:\n");
                        InsertionSort.insertionSortDescending(data);
                        Console.WriteLine("\nPress enter for Ascending\n");
                        Console.ReadLine();
                        InsertionSort.insertionSortAscending(data);
                        break;

                    case "3":
                        correctInput = true;
                        Console.WriteLine("\nDescending:\n");
                        QuickSort.QuickSortDescending(data);
                        Console.WriteLine("\nPress enter for Ascending:\n");
                        Console.ReadLine();
                        QuickSort.QuickSortAscending(data);
                        break;

                    case "4":
                        correctInput = true;
                        Console.WriteLine("\nDescending:\n");
                        HeapSort.heapSortDescending(data);
                        Console.WriteLine("\nPress enter for Ascending:\n");
                        Console.ReadLine();
                        HeapSort.heapSortAscending(data);
                        break;


                    default:
                        Console.Write($"\nChoose a number between 1-4\n");
                        correctInput = false;
                        break;
                }
            }

        }

        //To let user choose how they want to find a number in the sorted array

        private static void SearchingMenu (int [] data)
        {
            Console.WriteLine("\n\nPress enter");
            Console.ReadLine();

            bool correctInput = false;
            while (correctInput == false)
            {
                Console.WriteLine("\n1. Linear Search\n2. Binary Search (Only works if array is sorted in Ascending order)\n");
                Console.Write("Which searching method would you like to use?: ");
                string choice = Console.ReadLine();


                bool isInt = false; //To check if entered number is an int
                int number = 0;

                switch (choice)
                {
                    case "1":
                        correctInput = true;

                        while (isInt == false) //Loops until user enter an int
                        {
                            Console.Write("\nEnter a number that you want to find: ");
                            isInt = int.TryParse(Console.ReadLine(), out number);

                            if (isInt == false)
                            {
                                Console.WriteLine("\nEnter a whole number");
                                isInt = false;
                            }

                        }



                        bool linearResult = LinearSearch.linearSearch(data, number);
                        if (linearResult == false) //If function returns a false than the number has not been found
                        {
                            int closestValue = Program.closestValue(data, number);
                            if (closestValue == -1)
                            {
                                Console.WriteLine("----- Number not found -----");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "2":
                        correctInput = true;

                        while (isInt == false) //Loops until user enter an int
                        {
                            Console.Write("\nEnter a number that you want to find: ");
                            isInt = int.TryParse(Console.ReadLine(), out number);

                            if (isInt == false)
                            {
                                Console.WriteLine("\nEnter a whole number");
                                isInt = false;
                            }

                        }


                        int binaryResult = BinarySearch.binarySearch(data, number); 

                        if (binaryResult == -1) //If result is -1 then the number has not been found
                        {
                            int closestValue = Program.closestValue(data, number);
                            if (closestValue == -1)
                            {
                                Console.WriteLine("----- Number not found -----");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"\nNumber found at index: {binaryResult}");
                            Console.WriteLine();
                        }
                        break;


                    default:
                        Console.Write($"\nChoose a number between 1-2\n");
                        correctInput = false;
                        break;
                }


            }

        }
    }
}


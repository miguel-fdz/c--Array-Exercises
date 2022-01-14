using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose from the following list of Array exercises:\r\n" +
                "1. Print Array\r\n" +
                "2. Reverse Array\r\n" +
                "3. Sum Elements\r\n" +
                "4. Copy Elements\r\n" +
                "5. Count Duplicates\r\n");

            switch (FetchInt())
            {
                case 1:
                    PrintArray();
                    break;
            }


            Console.ReadLine();
        }

        #region Exercises
        /*
         *  Exercise 1: Write a program in C# Sharp to store elements in an array and print it.
         */
        private static void PrintArray()
        {
            Console.Write("Please enter a number of elements (between 1 and 10)" +
                        " that you would like your array to hold: ");

            int[] arr1 = new int[FetchInt()];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"Array element {i + 1}: ");
                arr1[i] = FetchInt();
            }

            foreach (int e in arr1)
                Console.Write($"{e} ");
        }


        /*
         * Exercise 2: Write a program in C# Sharp to read n number of values in an array and display it in reverse order. 
         */

        /*
         * Exercise 3: Write a program in C# Sharp to find the sum of all elements of the array.
         */

        /*
         * Exercise 4: Write a program in C# Sharp to copy the elements one array into another array.
         */

        /*
         * Exercise 5: Write a program in C# Sharp to count a total number of duplicate elements in an array.
         */

        #endregion

        #region USER-DEFINED-METHODS

        private static int FetchInt()
        {
            while (true)
                if (int.TryParse(Console.ReadLine(), out int num))
                    return num;
        }

        #endregion
    }
}
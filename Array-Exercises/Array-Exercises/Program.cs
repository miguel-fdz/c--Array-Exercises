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
                "3. Sum Array\r\n" +
                "4. Copy Elements\r\n" +
                "5. Count Duplicates\r\n");

            switch (FetchInt(1,5))
            {
                case 1:
                    PrintArray();
                    break;
                case 2:
                    ReverseArray();
                    break;
                case 3:
                    SumArray();
                    break;
                case 4:
                    CopyArray();
                    break;
                case 5:
                    CountDuplicates();
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
            int[] array = FetchArray();

            foreach (int e in array)
                Console.Write($"{e} ");
        }


        /*
         * Exercise 2: Write a program in C# Sharp to read n number of values in an array and display it in reverse order. 
         */
        private static void ReverseArray()
        {
            int[] array = FetchArray();

            for (int i = array.Length - 1; i >= 0; i--)
                Console.Write($"{array[i]} ");
        }

        /*
         * Exercise 3: Write a program in C# Sharp to find the sum of all elements of the array.
         */
        private static void SumArray()
        {
            int[] array = FetchArray();
            int total = 0;

            foreach (int e in array)
                total += e;

            Console.WriteLine(total);
        }

        /*
         * Exercise 4: Write a program in C# Sharp to copy the elements one array into another array.
         */
        private static void CopyArray()
        {
            int[] array = FetchArray();
            int[] array2 = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
                array2[i] = array2[i];

            foreach (int e in array)
                Console.Write($"{e} ");
        }

        /*
         * Exercise 5: Write a program in C# Sharp to count a total number of duplicate elements in an array.
         */
        private static void CountDuplicates()
        {
            int[] array = FetchArray();
            List<int> duplicateElements = new List<int>();
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];

                //count every duplicate of element after its first position of occurence if it hasn't been counted previously
                for (int x = i+1; x < array.Length; x++)
                    if (element == array[x] && !duplicateElements.Contains(element))
                        counter++;

                //if element hasn't already been checked for duplicates, add to list of elements that have been checked
                if (!duplicateElements.Contains(element))
                    duplicateElements.Add(element);
            }

            Console.WriteLine($"The amount of duplicates in the array is: {counter}");
        }

        #endregion

        #region USER-DEFINED-METHODS

        private static int FetchInt(int min, int max)
        {
            while (true)
                if (int.TryParse(Console.ReadLine(), out int num) && num >= min && num <= max)
                    return num;
        }

        private static int[] FetchArray()
        {
            Console.Clear();
            Console.Write("Please enter a number of elements (between 1 and 10)" +
                        " that you would like your array to hold: ");

            int[] array = new int[FetchInt(0,10)];

            Console.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Array element {i + 1}: ");
                array[i] = FetchInt(int.MinValue, int.MaxValue);
            }
            return array;
        }

        #endregion
    }
}
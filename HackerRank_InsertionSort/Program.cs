using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_InsertionSort
{
    class Program
    {
        static int RunningTime(int[] arr)
        {
            int numberOfSwaps = 0;

            var j = 0;
            for (var i = 1; i < arr.Length; i++)
            {
                var value = arr[i];
                j = i - 1;
                while (j >= 0 && value < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    numberOfSwaps++;
                }
                arr[j + 1] = value;
            }
            return numberOfSwaps;
        }

        public static void insertionSort1(int[] A)
        {
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }

            Console.WriteLine(string.Join(" ", A));
            Console.ReadLine();
        }

        private static void InsertionSort(int[] arr, int n)
        {
            for (int j = 1; j < n; j++)
            {
                int currentItem = arr[j];

                int i = j;

                bool isSorted = false;

                if (arr[j] > arr[j - 1])
                {
                    PrintArray(arr);
                    continue;
                }                    

                while (!isSorted)
                {
                    if (i - 1 >= 0 && arr[i - 1] > currentItem)
                        arr[i] = arr[i - 1];
                    else
                    {
                        arr[i] = currentItem;
                        isSorted = true;
                        PrintArray(arr);
                    }

                    i--;
                }
            }

        }

        private static void InsertToPosition(int[] arr, int n)
        {
            // get the last item of the array
            int lastItem = arr[n - 1];

            bool isSorted = false;

            int i = n - 1;

            // loop throgh the array to find the right position of the last item
            while (!isSorted)
            {
                if (i - 1 >= 0 && arr[i - 1] > lastItem)
                    arr[i] = arr[i - 1];
                else
                {
                    arr[i] = lastItem;
                    isSorted = true;
                }

                i--;

                PrintArray(arr);
            }

        }

        private static void PrintArray(int[] arr)
        {
            string result = string.Empty;
            foreach (var item in arr)
            {
                result += " " + item;
            }
            Console.WriteLine(result.Trim());
        }

        static void Main(string[] args)
        {
            // Raed input array length n
            int n = Convert.ToInt32(Console.ReadLine());

            // Read array as string space separated arr[n]
            int[] arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();

            // Insertion Sort - Part 1
            //InsertToPosition(arr, n);

            // Insertion Sort - Part 2
            //InsertionSort(arr, n);

            // Correctness and the Loop Invariant
            //insertionSort1(arr);

            //Running Time of Algorithms
            int numOfSwaps = RunningTime(arr);
            Console.WriteLine(numOfSwaps);

            Console.ReadLine();
        }
    }
}

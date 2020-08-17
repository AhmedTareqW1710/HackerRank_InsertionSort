using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_InsertionSort
{
    class Program
    {
        private static void InsertToPosition(int[] arr, int n)
        {
            // get the last item of the array
            int lastItem = arr[n - 1];

            bool isSorted = false;

            int i = n - 1;

            // loop throgh the array to find the right position of the last item
            while (!isSorted)
            {
                if (i-1 >= 0 && arr[i - 1] > lastItem)
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

            InsertToPosition(arr, n);
        }
    }
}

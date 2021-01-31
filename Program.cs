﻿using System;

namespace NDiffs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int k = 2;
            
            System.Console.WriteLine(DiffPairs(array, k));
        }

        private static int DiffPairs(int[] arr, int k)
        {
            int count = 0;
            int n = arr.Length;

            // Pick all elements one by one
            for (int i = 0; i < n; i++)
            {

                // See if there is a pair
                // of this picked element
                for (int j = i + 1; j < n; j++)
                    if (arr[i] - arr[j] == k ||
                          arr[j] - arr[i] == k)
                        count++;
            }

            return count;
        }
    }
}

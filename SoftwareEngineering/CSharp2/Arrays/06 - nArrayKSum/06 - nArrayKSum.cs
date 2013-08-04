using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class nArrayKSum
    {
        static void Main(string[] args)
        {
            //Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of elements:");
            int k = int.Parse(Console.ReadLine());


            int sum = 0;
            int[] array1 = new int[n];
           

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array1);

            for (int i = n-1; i >= n-k; i--)
            {
                sum += array1[i];
            }

            Console.WriteLine(sum);
        }
    }


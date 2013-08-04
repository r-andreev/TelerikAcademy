using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class SortSelection
    {
        static void Main(string[] args)
        {
            //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array1.Length; i++)
            {
                int smallest = array1[i];
                int position = i;
                for (int j = i+1; j < array1.Length; j++)
                {
                    if (smallest > array1[j])
                    {
                        smallest = array1[j];
                        position = j;
                    }
                }
                array1[position] = array1[i];
                array1[i] = smallest;
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
        }
    }


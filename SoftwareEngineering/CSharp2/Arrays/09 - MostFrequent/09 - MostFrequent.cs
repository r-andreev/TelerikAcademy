using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class MostFrequent
    {
        static void Main(string[] args)
        {
            //Write a program that finds the most frequent number in an array. 
            //Example:{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] array1 = new int[size];

            for (int i = 0; i < array1.Length; i++)
			{
			 array1[i] = int.Parse(Console.ReadLine());
			}
            
            int mostFreqTimes = 1;
            int mostFreqElement = 0;
            

            

            for (int i = 0; i < array1.Length - 1; i++)
			{
                int currMostFreqTimes = 1;
                for (int j = i + 1; j < array1.Length; j++)
                {
                    if (array1[i] == array1[j])
                    {
                        currMostFreqTimes++;
                    }
                }
                if (currMostFreqTimes > mostFreqTimes)
                {
                    mostFreqTimes = currMostFreqTimes;
                    mostFreqElement = array1[i];
                }
             
			}
            if (mostFreqTimes > 1)
            {
                Console.WriteLine("Times {0}", mostFreqTimes);
                Console.WriteLine("Element {0}", mostFreqElement);
            }
        }
    }


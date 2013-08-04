using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class GivenSum
    {
        static void Main(string[] args)
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present).
            //Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            

            int[] array1 = new int[size];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the wanted sum S:");
            int S = int.Parse(Console.ReadLine());
            string sumSequence = "";
            StringBuilder buildSequence = new StringBuilder();
            
            

            for (int i = 0; i < array1.Length - 1; i++)
            {
                int currentSum = 0;
                for (int j = i; j < array1.Length; j++)
                {
                    currentSum += array1[j];
                    buildSequence.AppendFormat("{0} ", array1[j]);
                    if (currentSum > S)
                    {
                        buildSequence.Clear();
                        currentSum = 0;
                        break;

                        
                    }
                    if (currentSum == S)
                    {
                        sumSequence = buildSequence.ToString();
                        Console.WriteLine("{0}",sumSequence);
                    }

                }
                
            }
            
        }
    }


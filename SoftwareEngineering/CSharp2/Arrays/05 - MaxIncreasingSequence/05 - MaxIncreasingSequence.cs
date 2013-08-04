using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class MaxIncreasingSequence
    {
        static void Main(string[] args)
        {
            //Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
            Console.WriteLine("Please enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            int currentLength = 1;
            int bestLength = 0;
            string maxIncreasingSeq = "";
            string currentSeq = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    currentLength++;
                    currentSeq += array[i] + " , ";
                }
                else
                {
                    if (bestLength < currentLength)
                    {
                        bestLength = currentLength;
                        currentSeq += array[i] + " , ";
                        maxIncreasingSeq = currentSeq;

                    }
                    currentSeq = "";
                    currentLength = 1;

                }
                    
                
            }
            if (bestLength < currentLength)
            {
                currentSeq += array[array.Length - 1];
                maxIncreasingSeq = currentSeq;
            }
            Console.WriteLine(maxIncreasingSeq);
        }
    }


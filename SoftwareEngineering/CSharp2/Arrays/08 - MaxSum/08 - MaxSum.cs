using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class MaxSum
    {
        static void Main(string[] args)
        {
            //Write a program that finds the sequence of maximal sum in given array. 
            //Example:{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	        //Can you do it with only one loop (with single scan through the elements of the array)?

            int[] array1 = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
            int currSum = 0;
            int bestSum = int.MinValue;
            StringBuilder currBestSequence = new StringBuilder();
            string bestSequence = "";

            for (int i = 0; i < array1.Length; i++)
            {
                currSum += array1[i];
                currBestSequence.AppendFormat("{0}, ", array1[i]);

                if (currSum > bestSum)
                {
                    bestSum = currSum;
                    bestSequence = currBestSequence.ToString();
                }
                if (currSum < 0)
                {
                    currSum = 0;
                    currBestSequence.Clear();
                }
            }

            
            Console.WriteLine(bestSequence);

        }
    }


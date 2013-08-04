using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class MaxSequence
    {
        //Write a program that finds the maximal sequence of equal elements in an array.
		//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] array1 = new int[size];
            
            int currentLength = 1;
            int bestLength = 0;
            int maxSeqEqualElement = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());

            }
            for (int j = 0; j < array1.Length - 1; j++)
            {
                if (array1[j] == array1[j + 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        maxSeqEqualElement = array1[j];
                    }
                    currentLength = 1;
                }
                
            }

            if(currentLength > bestLength)
            {
                bestLength = currentLength;
                maxSeqEqualElement = array1[array1.Length - 1];
            }
           
            Console.WriteLine("{0}  - {1} times",maxSeqEqualElement,bestLength);
        }
    }


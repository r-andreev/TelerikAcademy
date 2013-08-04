using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Combinations
    {
        //Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
        //Example:N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
        

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] combArray = new int[K];
            combMethod(combArray, 0, N, 1);

        }
        static void combMethod(int[] combArray, int index, int N, int K)
        {
            if (index == combArray.Length)
            {
                for (int i = 0; i < combArray.Length; i++)
                {
                    Console.Write(combArray[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = K; j <= N; j++)
                {
                    combArray[index] = j;
                    combMethod(combArray, index + 1, N, j + 1);
                }
            }
        }
    }


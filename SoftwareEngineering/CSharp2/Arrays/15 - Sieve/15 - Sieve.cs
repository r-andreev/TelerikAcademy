using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
            bool[] boolArray = new bool[10000000];
            for (int i = 0; i < boolArray.Length; i++)
            {
                boolArray[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(boolArray.Length); i++)
            {
                if (boolArray[i] == true)
                {
                    for (int j = i*i; j < boolArray.Length; j += i)
                    {
                        boolArray[j] = false;
                    }
                }
            }
            for (int i = 2; i < boolArray.Length; i++)
            {
                if (boolArray[i] == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    //Write a program that compares two char arrays lexicographically (letter by letter).

    class CharArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the first array:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the size of the second array:");
            int size2 = int.Parse(Console.ReadLine());

            bool areEqual = false;
            bool firstShorter = false;
            bool secondShorter = false;
            char[] charArray1 = new char[size];
            char[] charArray2 = new char[size2];

            if (charArray1.Length != charArray2.Length)
            {
                Console.WriteLine("The two arrays are not equal");

            }
            else
            {
                for (int i = 0; i < charArray1.Length; i++)
                {
                    charArray1[i] = char.Parse(Console.ReadLine());
                }

                for (int j = 0; j < charArray2.Length; j++)
                {
                    charArray2[j] = char.Parse(Console.ReadLine());
                }

                             
                for (int i = 0; i < charArray1.Length; i++)
                    {
                        if (charArray1[i] == charArray2[i])
                        {
                            areEqual = true;
                        }
                        else if (charArray1[i] < charArray2[i])
                        {
                            firstShorter = true;
                        }
                        else
                        {
                            secondShorter = true;
                        }

                    }
                if (areEqual)
                {
                Console.WriteLine("The two arrays are equal");
                }
                else if (firstShorter)
                {
                Console.WriteLine("The first array is shorter");
                }
                else 
                {
                Console.WriteLine("The second array is shorter");
                }
                }
            }
        }
    


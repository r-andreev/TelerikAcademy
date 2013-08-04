using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class DecimalToBinary
    {
        //Write a program to convert decimal numbers to their binary representation.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in decimal:");
            int num = int.Parse(Console.ReadLine());
            string answer = "";        
                                   
            while (num > 0)
            {
                int remainder = num % 2;
                answer += " " + remainder;
                num = num / 2;
            }
            char[] arrayFromString = answer.ToCharArray();
            Array.Reverse(arrayFromString);
            Console.WriteLine("The number's binary representation is:");
            for (int i = 0; i < arrayFromString.Length; i++)
			{
                Console.Write(arrayFromString[i] + "");
			}
            Console.WriteLine();
        }
    }


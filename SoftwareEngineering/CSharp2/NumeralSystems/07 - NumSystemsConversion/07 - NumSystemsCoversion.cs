using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class NumSystemsConversion
    {
        //Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base of the numeral system to be converted from s:");
            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the base of the numeral system to be converted to d:");
            int d = int.Parse(Console.ReadLine());

            if (s == 2 && d == 10)
            {
                Console.WriteLine("Binary to decimal:");
            }
            else if (s == 2 && d == 16)
            {
                Console.WriteLine("Binary to hexadecimal:");
            }
            else if (s == 10 && d == 2)
            {
                Console.WriteLine("Decimal to binary:");
            }
            else if (s == 10 && d == 16)
            {
            Console.WriteLine("Decimal to hexadecimal:");
            }
            else if (s == 16 && d == 2)
            {
                Console.WriteLine("Hexadecimal to binary:");
            }
            else if (s == 16 && d == 10)
            {
                Console.WriteLine("Hexadecimal to decimal:");
            }
            else
            {
                Console.WriteLine("Please enter a valid base for numeral system");
            }
        }
    }


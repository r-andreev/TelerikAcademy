using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



    class BinaryToDecimal
    {
        //Write a program to convert binary numbers to their decimal representation.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in binary format:");
            int number = int.Parse(Console.ReadLine());
            
            int power = 1;
            int numberInDecimal = 0;

            while (number > 0)
            {
                numberInDecimal += number % 10 * power;
                number /= 10;
                power = power * 2;
            }
            Console.WriteLine("The decimal represantation of the entered number is {0}",numberInDecimal);
        }
    }


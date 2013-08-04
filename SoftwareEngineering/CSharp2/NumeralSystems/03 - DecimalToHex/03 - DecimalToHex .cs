using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class DecimalToHexadecimal
    {
        //Write a program to convert decimal numbers to their hexadecimal representation.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in decimal format:");
            int number = int.Parse(Console.ReadLine());

            string answer = "";
            while (number > 0)
            {
                int remainder = number % 16;
                if (remainder >= 10)
                {
                    switch (remainder)
                    {
                        case 10:
                            answer += "A";
                            break;
                        case 11:
                            answer += "B";
                            break;
                        case 12:
                            answer += "C";
                            break;
                        case 13:
                            answer += "D";
                            break;
                        case 14:
                            answer += "E";
                            break;
                        case 15:
                            answer += "F";
                            break;
                    }
                }
                else
                {
                    answer += "" + remainder;
                }
                    number = number / 16;
            }
            char[] numberInArray = answer.ToCharArray();
            Array.Reverse(numberInArray);
            Console.WriteLine("The number in hexadecimal format is :");
            for (int i = 0; i < numberInArray.Length; i++)
            {
                Console.Write(numberInArray[i] + "");
            }
            Console.WriteLine();
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class BinaryToHex
    {
        //Write a program to convert binary numbers to hexadecimal numbers (directly).

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in binary format:");
            string numInBinary = Console.ReadLine();
            string numInHex = string.Empty;
            int divisibleByFour = numInBinary.Length % 4;

            if (divisibleByFour != 0)
            {
                numInBinary = new string('0', 4 - divisibleByFour) + numInBinary;
            }
            StringBuilder result = new StringBuilder();
            int length = numInBinary.Length;          
            for (int i = 0; i < length; i=i+4)
            {               
               
             switch(numInBinary.Substring(i, 4))
             {
                 case "0000":
                     result.Append("0");
                     break;
                 case "0001":
                     result.Append("1");
                     break;
                 case "0010":
                     result.Append("2");
                     break;
                 case "0011":
                     result.Append("3");
                     break;
                 case "0100":
                     result.Append("4");
                     break;
                 case "0101":
                     result.Append("5");
                     break;
                 case "0110":
                     result.Append("6");
                     break;
                 case "0111":
                     result.Append("7");
                     break;
                 case "1000":
                     result.Append("8");
                     break;
                 case "1001":
                     result.Append("9");
                     break;
                 case "1010":
                     result.Append("A");
                     break;
                 case "1011":
                     result.Append("B");
                     break;
                 case "1100":
                     result.Append("C");
                     break;
                 case "1101":
                     result.Append("D");
                     break;
                 case "1110":
                     result.Append("E");
                     break;
                 case "1111":
                     result.Append("F");
                     break;             
             }
            }
            numInHex = result.ToString();
            Console.WriteLine("The number in hexadecimal format is {0}",numInHex);
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class HexToDecimal
    {
        //Write a program to convert hexadecimal numbers to their decimal representation.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in hexadecimal format:");
            string numberInHex = Console.ReadLine();

            char[] numberInArray = numberInHex.ToCharArray();
            
            Array.Reverse(numberInArray);
            double numberInDec = 0;
            double parsedNum = 0;
           
            for (int i = 0; i < numberInArray.Length; i++)
            {
                if (numberInArray[i] == 'A')
                {
                    numberInDec += 10 * Math.Pow(16,i);
                    
                }
                else if (numberInArray[i] == 'B')
                {
                    numberInDec += 11 * Math.Pow(16,i);
                    
                }
                else if (numberInArray[i] == 'C')
                {
                    numberInDec += 12 * Math.Pow(16,i);
                    
                }
                else if (numberInArray[i] == 'D')
                {
                    numberInDec += 13 * Math.Pow(16,i);
                    
                }
                else if (numberInArray[i] == 'E')
                {
                    numberInDec += 14 * Math.Pow(16,i);
                    
                }
                else if (numberInArray[i] == 'F')
                {
                    numberInDec += 15 * Math.Pow(16,i);
                    
                }
                else  
                {
                    parsedNum = double.Parse(Convert.ToString(numberInArray[i]));
                    
                    numberInDec += parsedNum * Math.Pow(16,i);
                    
                    
                }
            }
            Console.WriteLine("The number in decimal format is {0}",numberInDec);
        }
    }


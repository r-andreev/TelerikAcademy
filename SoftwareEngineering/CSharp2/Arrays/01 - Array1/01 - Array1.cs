using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Array1
    {
        //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

        static void Main(string[] args)
        {
            int[] intArray = new int[20];
            for (int i = 0 ; i < intArray.Length; i++)
            {
                intArray[i] = i * 5;
            }
            for (int index = 0; index < intArray.Length; index++)
            {
                Console.WriteLine("element[{0}] = {1}",index,intArray[index]);
            }
        }
    }


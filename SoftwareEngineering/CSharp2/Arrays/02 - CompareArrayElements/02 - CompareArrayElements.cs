using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

     
class CompareArrayElements
{
    //Write a program that reads two arrays from the console and compares them element by element.

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the first array:");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the size of the second array:");
        int size2 = int.Parse(Console.ReadLine());


        bool areEqual = false;
        int[] array1 = new int[size];
        int[] array2 = new int[size2];

        if (array1.Length != array2.Length) 
        {
            Console.WriteLine("The two arrays are not equal");
            
        }

        else 
        {
            for (int i = 0; i < array1.Length; i++)
            {
            array1[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < array2.Length; j++)
            {
            array2[j] = int.Parse(Console.ReadLine());
            }
            for (int k = 0; k < array1.Length; k++)
			{
			  if (array1[k] == array2[k])
              {
                  areEqual = true;
              }
              else
              {
                  areEqual = false;
              }
			}
            if (areEqual)
            {
                Console.WriteLine("The two arrays are equal");
            }
            else
            {
                Console.WriteLine("The two arrays are not equal");
            }
        }

        
            
    }
}

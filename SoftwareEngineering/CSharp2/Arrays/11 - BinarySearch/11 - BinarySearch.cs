using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BinarySearch
{
    static void Main(string[] args)
    {
        //Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
        Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());
        int[] array1 = new int[size];
        
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
        int downLimit = 0;
        int upperLimit = array1.Length;      
        
        Console.WriteLine("Enter the value of the element:");
        int element = int.Parse(Console.ReadLine());

        int middlePoint = (downLimit + upperLimit) / 2;

        Array.Sort(array1);

        while (element > 0)
        { 
            while(element < array1[middlePoint])
            {
                upperLimit = middlePoint - 1;
                middlePoint = (downLimit + upperLimit) / 2;
                if (element == array1[middlePoint])
                {
                    Console.WriteLine("The index is {0}", middlePoint);
                    break;
                }
            }

            while (element > array1[middlePoint])
            {
                downLimit = middlePoint + 1 ;
                middlePoint = (downLimit + upperLimit) / 2;
                if (element == array1[middlePoint])
                {
                    Console.WriteLine("The index is {0}", middlePoint);
                    break;
                }
            }
            
        }
       

        
       
            
            
    }
}
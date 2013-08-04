using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Variations
{

    //Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
    //Example:N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


    static int N = int.Parse(Console.ReadLine());
    static int K = int.Parse(Console.ReadLine());

    static void varMethod(int[] mainArray, int index)
    {
        if (index == mainArray.Length)
        {
            for (int i = 0; i < mainArray.Length; i++)
            {
                Console.Write(mainArray[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                mainArray[index] = i;
                varMethod(mainArray, index + 1);
            }
        }
    }

    static void Main()
    {
        int[] varArray = new int[K];
        varMethod(varArray, 0);
    }
}
    


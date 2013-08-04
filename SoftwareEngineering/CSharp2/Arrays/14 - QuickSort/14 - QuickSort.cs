using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class QuickSortStrings
    {
        static void Main(string[] args)
        {
            //Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
            string[] stringArray = { "o", "a", "z", "i", "r" };

            QuickSortMethod(stringArray, 0 , stringArray.Length - 1);

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write(stringArray[i] + " ");

            }
            Console.WriteLine();
        }

        static void QuickSortMethod(string[] sortedArray, int smaller, int bigger)
        {
            int i = smaller;
            int j = bigger;

            string pivot = sortedArray[((smaller/2)+ (bigger/2))];

            while (i <= j)
            {
                while (sortedArray[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (sortedArray[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    string temporary = sortedArray[i];
                    sortedArray[i] = sortedArray[j];
                    sortedArray[j] = temporary;

                    i++;
                    j--;
                }
            }

            if (smaller < j)
            {
                QuickSortMethod(sortedArray, smaller, j);
            }
            if (i < bigger)
            {
                QuickSortMethod(sortedArray, i, bigger);
            }
        }

    }


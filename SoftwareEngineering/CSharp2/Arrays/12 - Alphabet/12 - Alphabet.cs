using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Alphabet
{
    static void Main(string[] args)
    {
        //Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

        char[] alphabetArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        
        Console.WriteLine("Enter a word in uppercase letters:");
        string word = Console.ReadLine();
        char[] wordArray = word.ToCharArray();

        for (int i = 0; i <alphabetArray.Length; i++)
        {
            for (int j = 0; j < wordArray.Length; j++)
            {
                if (alphabetArray[i] == wordArray[j])
                {
                    Console.WriteLine("{0} - {1}",alphabetArray[i],i);
                }
            }
        }
    }

}
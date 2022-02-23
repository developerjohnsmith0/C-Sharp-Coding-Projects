using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arrayOfString = { "Zues", "Kratos", "Thor", "Odin", "Ares" };

            int[] arrayNumber = { 0, 1, 2, 3, 4 };

            List<string> listOfNames = new List<string>() { "Sabrina", "Theo", "Nicoles", "Harvey", "Rosalind" };

            Console.WriteLine("For string array enter index number between 0 to 4 .");
            int indexOfString = Convert.ToInt32(Console.ReadLine());

            if (indexOfString >= 0 && indexOfString <= 4)
            {
                Console.WriteLine(arrayOfString[indexOfString]);
            }
            else
            {
                Console.WriteLine(indexOfString + " number index does not existed.");
            };

            Console.WriteLine("For array of numbers enter index number between 0 to 4 ");
            int indexOfNumber = Convert.ToInt32(Console.ReadLine());

            if (indexOfNumber >= 0 && indexOfNumber <= 4)
            {
                Console.WriteLine(arrayNumber[indexOfNumber]);
            }
            else
            {
                Console.WriteLine(indexOfNumber + " number index does not existed.");
            };

            Console.WriteLine("For list of names enter index number between 0 to 4 .");
            int indexOfList = Convert.ToInt32(Console.ReadLine());

            if (indexOfList >= 0 && indexOfList <= 4)
            {
                Console.WriteLine(listOfNames[indexOfList]);
            }
            else
            {
                Console.WriteLine(indexOfList + " number index does not existed.");
            };

        }
    }
}

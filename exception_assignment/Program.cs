using System;
using System.Collections.Generic;
using System.Linq;


namespace exception_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> listOfIntegers = new List<int>() { 5, 10, 15, 20, 25 };
                Console.WriteLine("Enter number to divide.");
                int enteredNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result:");

                foreach (int num in listOfIntegers)
                {
                    Console.WriteLine(num / enteredNumber);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

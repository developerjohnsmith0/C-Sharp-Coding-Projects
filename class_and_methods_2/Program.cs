using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace class_and_methods_2
{
    public class OptionalParameters
    {
        public void addNum(int number1, [Optional] int number2)
        {
            Console.WriteLine(number1 + 5);
            Console.WriteLine(number2 + 5);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OptionalParameters operations = new OptionalParameters();
            Console.WriteLine("Enter first number:");
            int inputnumber1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int inputnumber2 = Convert.ToInt32(Console.ReadLine());
            operations.addNum(inputnumber1, inputnumber2);
            Console.WriteLine("No need to add second paramenter tou can also run it by passing one parameter.");
        }
    }
}

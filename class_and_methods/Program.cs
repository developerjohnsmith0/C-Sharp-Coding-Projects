using System;

namespace class_and_method
{
    public class Operation
    {
        public void Divide(int num)
        {
            Console.WriteLine(num / 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operation division = new Operation();
            Console.WriteLine("enter number to divide it by 2:");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            division.Divide(enteredNumber);
        }
    }
}

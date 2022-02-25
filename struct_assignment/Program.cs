using System;

namespace struct_assignment
{
    public struct Number
    {
        public decimal Amount;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number amount = new Number();
            amount.Amount = 150;
            Console.WriteLine(amount.Amount);
        }
    }
}

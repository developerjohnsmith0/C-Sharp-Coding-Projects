using System;

namespace date_and_time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(enteredNumber + " " + DateTime.Now.ToLongTimeString());
        }
    }
}

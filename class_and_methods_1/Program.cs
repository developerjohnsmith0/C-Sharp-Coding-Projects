using System;

namespace class_and_methods_1
{
    public class operationOfInt
    {
        public void operation(int number)
        {
            Console.WriteLine(number + 5);
        }

        public void operation(double number)
        {
            Console.WriteLine(number + number);
        }

        public void operation(string number)
        {
            var newNum = Convert.ToInt32(number);
            Console.WriteLine(newNum * newNum);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            operationOfInt operate = new operationOfInt();
            operate.operation(5);
            operate.operation(5.5);
            operate.operation("5");
        }
    }
}

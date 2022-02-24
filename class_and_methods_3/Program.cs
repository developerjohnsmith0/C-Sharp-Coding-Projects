using System;

namespace class_and_methods_3
{
    public class OperationNumber
    {
        public void functionNumber(int num1, int num2)
        {
            var Num = num1 + 5;
            Console.WriteLine(num2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OperationNumber operationNumber = new OperationNumber();
            int int1 = 5;
            int int2 = 5;
            operationNumber.functionNumber(int1, int2);
        }
    }
}

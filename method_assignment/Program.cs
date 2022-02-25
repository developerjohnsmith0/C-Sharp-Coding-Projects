using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOperation methodOperation = new MethodOperation();

            Console.WriteLine("Enter number:");
            int enteredNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("On Adding we get");
            methodOperation.Addition(enteredNum);

            Console.WriteLine("On Subtracting we get");
            methodOperation.Substraction(enteredNum);

            Console.WriteLine("On Mutiplying we get");
            methodOperation.Division(enteredNum);
        }
    }
}

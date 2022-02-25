using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics
{
    public class Employee<T1>
    {
        public T1 things;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee<String> stringThing = new Employee<string>();
            stringThing.things = "Things";

            Employee<int> integerThing = new Employee<int>();
            integerThing.things = 1;
            foreach (var stringItem in stringThing)
            {
                Console.WriteLine(stringItem);
            }
            foreach (var intItem in integerThing)
            {
                Console.WriteLine(intItem);
            }

        }
    }
}

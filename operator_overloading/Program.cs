using System;

namespace operator_overloading
{
    public class Employee
    {
        public int id;
        public string firstName;
        public string lastName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employ1 = new Employee();
            employ1.id = 1;
            employ1.firstName = "Eddie  ";
            employ1.lastName = "Brok";
            Employee employ2 = new Employee();
            employ2.id = 2;
            employ2.firstName = "Cletus";
            employ2.lastName = "Kesady";
            if (employ1.id == employ2.id)
            {
                Console.WriteLine("Both objects are equal.");
            }
            else
            {
                Console.WriteLine("Both objects are not equal.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Classes
{
    public abstract class Person
    {
        public string firstName;
        public string lastName;

        public abstract void SayName();
    }

    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
        }
    }
}
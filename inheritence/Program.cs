using System;

namespace inheritence
{
    public class Person
    {
        public String FirstName;
        public String LastName;
        public void SayName()
        {
            Console.WriteLine("Name: " + "[ " + FirstName + " " + LastName + " ]");
        }
    }

    public class Employee : Person
    {
        int Id;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
        }
    }
}

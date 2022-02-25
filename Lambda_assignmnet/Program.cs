using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lamda
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
            List<Employee> employee = new List<Employee>()
            {
                new Employee{id=1,firstName="Joe", lastName="Snow"},
                new Employee{id=2,firstName="Joe", lastName="Nutella"},
                new Employee{id=3,firstName="Lucifer", lastName="Morringstar"},
                new Employee{id=4,firstName="Chloe", lastName="Deckar"},
                new Employee{id=5,firstName="Ella", lastName="Lopez"},
                new Employee{id=6,firstName="Trixie", lastName="Espenoza"},
                new Employee{id=7,firstName="Daniel", lastName="Espenoza"},
                new Employee{id=8,firstName="Linda", lastName="Martin"},
                new Employee{id=9,firstName="Mazikeen", lastName="Smith"},
                new Employee{id=10,firstName="Charllote", lastName="Richards"},
            };
            int count = employee.Count(e => e.firstName == "Joe");
            List<Employee> nameJoe = employee.Where(e => e.firstName == "Joe").ToList();
            Console.WriteLine("Employees having same firstName");
            foreach (Employee name in nameJoe)
            {
                Console.WriteLine(name.firstName + " " + name.lastName);
            }
            List<Employee> idFiltered = employee.Where(e => e.id > 5).ToList();
            Console.WriteLine("Employees with id greater then 5 are:");
            foreach (Employee name in idFiltered)
            {
                Console.WriteLine(name.firstName + " " + name.lastName);
            }
        }
    }
}

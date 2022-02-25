using System;

namespace interfaces_assingment
{
    interface IQuitable
    {
        void Quit();
    }
    class Employee : IQuitable
    {
        public void Quit()
        {
            Console.WriteLine("Lorem ipsum doler sit.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Quit();
        }
    }
}

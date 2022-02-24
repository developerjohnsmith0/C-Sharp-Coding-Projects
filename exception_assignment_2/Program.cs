using System;

namespace more_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age:");
                uint ageOfUser = Convert.ToUInt32(Console.ReadLine());
                uint presentYear = Convert.ToUInt32(System.DateTime.Now.Year);
                uint yearOfBirth = presentYear - ageOfUser;
                Console.WriteLine(yearOfBirth + " is the year you were born in.");
            }
            catch (Exception)
            {
                Console.WriteLine("The age entered is invalid.");
            }
        }
    }
}

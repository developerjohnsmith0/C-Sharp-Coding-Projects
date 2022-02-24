using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("enter current day od week");
                DaysInWeek DayEntered = (DaysInWeek)Enum.Parse(typeof(DaysInWeek), Console.ReadLine(), true);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
        public enum DaysInWeek
        {
            Monday,
            Tuesday,
            Webnesday,
            Thrusday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

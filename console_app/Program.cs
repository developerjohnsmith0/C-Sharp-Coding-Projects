using System;
using System.Collections.Generic;
using System.Linq;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> carList = new List<string>() { "Tesla", "Audi", "BMW", "Tesla", "Mercedez" };
            List<string> distinctedList = carList.Distinct().ToList();
            List<string> repeatedList = new List<string>();
            foreach (var i in distinctedList)
            {
                if (carList.Count(car => car == i) > 1)
                {
                    repeatedList.Add(i);
                }
            }
            foreach (var car in repeatedList)
            {
                Console.WriteLine(car + " " + "car is reapeating in the list.");
            }
        }
    }
}

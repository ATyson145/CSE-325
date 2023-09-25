using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Adam Tyson";
            string location = "Idaho";

            Console.WriteLine($"My name is {myName}");
            Console.WriteLine($"I am from {location}");
            DateTime currentDate = DateTime.Now;
            string date = currentDate.ToString("MM/dd/yyyy");
            Console.WriteLine($"The current date is {date}");
        }
    }
}

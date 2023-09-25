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

            DateTime christmas = new DateTime(currentDate.Year, 12, 25);
            TimeSpan timeUntilChristmas = christmas - currentDate;
            int daysUntilChristmas = (int)timeUntilChristmas.TotalDays;
            Console.WriteLine($"The number of days before Christmas is {daysUntilChristmas}");


            Console.Write("Enter the width (in feet): ");
            string width = Console.ReadLine();
            double actWidth = double.Parse(width);

            Console.Write("Enter the height (in feet): ");
            string height = Console.ReadLine();
            double actHeight = double.Parse(height);

            double woodLength = 2 * (actWidth + actHeight) * 3.25;
            double glassArea = 2 * (actWidth * actHeight);

            Console.WriteLine($"The length of the wood is {woodLength}");
            Console.WriteLine($"The area of the glass is {glassArea}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

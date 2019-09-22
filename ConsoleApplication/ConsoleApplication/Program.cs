using System;

namespace ConsoleApplication
{
    class C_Application
    {
        static void Main(string[] args)
        {
            var name = "Bryan Anderson";
            var location = "São Paulo, Brazil";
            DateTime now = DateTime.Now.Date;
            DateTime christmas = new DateTime(2019, 12, 25);
            int num_christmas = christmas.DayOfYear;
            int num_now = now.DayOfYear;

            int days_different = num_christmas - num_now;

            Console.WriteLine($"Hello, my name is {name}");
            Console.WriteLine($"I currently live in {location}");
            Console.WriteLine($"Today's date is {now:MMM dd, yyyy}.");
            Console.WriteLine($"There are only {days_different} days until Christmas!\n");
/*-----------------------------------------------------------------------------------------*/
        
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Let's do some window math!");
            Console.Write("Enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine($"The length of the wood is {woodLength} feet.");

            Console.WriteLine($"The area of the glass is {glassArea} square meters.");

            Console.WriteLine("\nPress 'Enter' to exit.");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFirstName = "Oscar";
            string myLocation = "Rexburg";
            DateTime currentDate = DateTime.Now;
            DateTime christmas = new DateTime(currentDate.Year, 12, 25);

            int daysUntilChristmas = (christmas - currentDate).Days;


            Console.WriteLine($"My first name is {myFirstName}");
            Console.WriteLine($"I am from {myLocation}");
            Console.WriteLine(currentDate.ToString("MM/dd/yyyy"));
            Console.WriteLine($"Number of days until Christmas: {daysUntilChristmas}");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Enter the width (in feet):");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter the height (in feet):");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            // Pause the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}

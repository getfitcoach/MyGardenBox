using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenBox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for length and width of garden box
            // Give them the area and perimeter
            // Tell them how many corn/beets/carrots they can plant
            // carrots = 16 per square
            // corn = 3 per square
            // beets = 9 per square

            int length;
            int width;
            int perimeter;
            int area;
            string plant;
            int planted;

            Console.WriteLine("Please tell me the length of your Garden Box");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please tell me the length of your Garden Box");
            width = Convert.ToInt32(Console.ReadLine());
            perimeter = (length + width) * 2;
            area = (length * width);

            Console.WriteLine($"LENGTH is {length}\nWIDTH is {width}\nPERIMETER is {perimeter}\nAREA is {area}");

            while (true)
            {
                Console.WriteLine($"What would you like to plant? \nA) Carrots\nB) Corn \nC) Beets\nQ) Quit");

                plant = Console.ReadLine();
                string choice = plant.ToUpper();

                if (choice == "A")
                {
                    planted = area / 16;
                    Console.WriteLine($"You can plant {planted} carrots.");
                }
                else if (choice == "B")
                {
                    planted = area / 3;
                    Console.WriteLine($"You can plant {planted} corn.");
                }
                else if (choice == "C")
                {
                    planted = area / 9;
                    Console.WriteLine($"You can plant {planted} beets.");
                }
                else if (choice == "Q")
                {
                    Console.WriteLine("Thank you for using my GARDEN BOX.");
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose only from choices listed");
                }
            }
        }
    }
}
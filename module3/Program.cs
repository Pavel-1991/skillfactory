using System;
using System.Xml.Linq;

namespace module3
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

                var color = Console.ReadLine();

                if (color == "red")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                }

                else if (color == "green")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                }
        }
    }
}
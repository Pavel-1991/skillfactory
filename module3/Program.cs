using System;
using System.Xml.Linq;

namespace module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameold = "Jane";
            byte ageold = 27;
            string favcolor = "black";

            Console.WriteLine("{0}\n {1}\n{2}", nameold, ageold, favcolor);

            int counter = 10;
            counter += 15;
            Console.WriteLine("Value: {0} Increment: {1}", counter, counter);

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.ReadKey();

            string str = Console.ReadLine();

        }

        enum Semaphhore : uint
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
    }
}
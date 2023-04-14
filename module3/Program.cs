using System;
using System.Xml.Linq;

namespace module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jane";
            byte age = 27;
            string favcolor = "black";

            Console.WriteLine("{0}\n {1}\n{2}", name, age, favcolor);

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
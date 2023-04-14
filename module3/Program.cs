using System;

namespace module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Jane";
            byte MyAge = 27;
            byte age = 32;
            bool HaveIApet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);
            Console.WriteLine("\tПривет,\n мир!");
            Console.WriteLine($"Мой возраст {age}");

            DaysOfWeek MyFavoriteDay;
            MyFavoriteDay = DaysOfWeek.Friday;
            Console.WriteLine(MyFavoriteDay);
            


        }

        enum DaysOfWeek : byte
        {
            Tuesday,
            Monday,
            Wednesday,
            Friday
        }
        enum Semaphhore : uint
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
    }
}
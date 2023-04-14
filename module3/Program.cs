namespace module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Jane";

            Console.WriteLine(MyName);

            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\u0040");
            Console.WriteLine("\u0023");
            Console.ReadKey();
        }
    }
}
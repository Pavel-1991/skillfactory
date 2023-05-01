using System.Diagnostics.Tracing;

namespace Module5
{
    internal class Program
    {
        class MainClass
        {
            //static string ShowColor()
            //{
            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            //    var color = Console.ReadLine();

            //    switch (color)
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;
            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;
            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Red;

            //            Console.WriteLine("Your color is yellow!");
            //            break;
            //    }
            //    return color;
            //}

            public static void Main(string[] args)
            {
                GetArrayFromConsole();
                
                //var favcolors = new string[3];
                //var (name, age) = ("Евгения", 27);

                //Console.WriteLine("Мое имя: {0}", name);
                //Console.WriteLine("Мой возраст: {0}", age);

                //Console.Write("Введите имя: ");
                //name = Console.ReadLine();
                //Console.Write("Введите возрас с цифрами:");
                //age = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Ваше имя: {0}", name);
                //Console.WriteLine("Ваш возраст: {0}", age);

                //for(var i =0; i < favcolors.Length; i++)
                //{
                //    favcolors[i] = ShowColor();
                //}

                //Console.WriteLine("Ваши цвета:");
                //foreach(var color in favcolors)
                //{
                //    Console.WriteLine(color);
                //}
            }
            static int[] GetArrayFromConsole()
            {
                var result = new int[5];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }
                int temp;
                
                for (int a = 0; a<result.Length;a++)
                {
                    for (int b = a + 1; b < result.Length;b++)
                    {
                        if (result[a] > result[b])
                        {
                            temp = result[a];
                            result[a] = result[b];
                            result[b] = temp;
                        }
                    }
                }

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

                return result;
            }
        }
    }
}
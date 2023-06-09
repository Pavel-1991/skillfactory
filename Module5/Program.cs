﻿using System;
using System.Diagnostics.Tracing;

namespace Module5
{
    internal class Program
    {
        class MainClass
        {
            //static string ShowColor(string username, int userage)
            //{
            //    Console.WriteLine($"{username} {userage} лет \nНапишите свой любимый цвет на английском с маленькой буквы");
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
            //static void ShowColors(string username = "Ivan", params string[] favcolors)
            //{
            //    Console.WriteLine($"{username} Ваши любимые цвета:");
            //    foreach (var color in favcolors)
            //    {
            //        Console.WriteLine(color);
            //    }
            //}

            public static void Main(string[] args)
            {
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

                //for (var i = 0; i < favcolors.Length; i++)
                //{
                //    favcolors[i] = ShowColor(name, age);
                //}

                //ShowColors();
                var array = GetArrayFromConsole(10);
                ShowArray(array, true);
            }
            static int[] GetArrayFromConsole(int num)
            {
                var result = new int[num];
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }
                return result;
            }
            static void ShowArray(int[] array, bool flag = false)
            {
                var result = array;
                if (flag) { result = SortArray(array); }

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            static int[] SortArray(in int[] array, bool flag = false)
            {
                var result = array;
                var sorteddesc = SortArrayDesc(array);
                var sortedasc = SortArrayAsc(array);
                if (flag) {result = sortedasc; } {result = sorteddesc; }
                return result;
            }

            static int[] SortArrayAsc(in int[] array)
            {
                int temp;
                var result = array;
                for (int a = 0; a < result.Length; a++)
                {
                    for (int b = a + 1; b < result.Length; b++)
                    {
                        if (result[a] > result[b])
                        {
                            temp = result[a];
                            result[a] = result[b];
                            result[b] = temp;
                        }
                    }
                }
                return result;
            }

            static int[] SortArrayDesc(in int[] array)
            {
                int temp;
                var result = array;
                for (int a = 0; a < result.Length; a++)
                {
                    for (int b = a + 1; b < result.Length; b++)
                    {
                        if (result[a] < result[b])
                        {
                            temp = result[a];
                            result[a] = result[b];
                            result[b] = temp;
                        }
                    }
                }
                return result;
            }
            
        }
    }
}
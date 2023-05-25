﻿using System.IO;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                string FolderdirName = @"C:\Users\Zver\Desktop\SkilF\";
                DirectoryInfo folder = new DirectoryInfo(FolderdirName);
                long WeightCatalog = GetWeightCatal(folder);        //Причёсанный метод для задания 2
                Console.WriteLine($"Размер каталога в байтах = {WeightCatalog}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            GetCatalClean();        //Задание 1
        }
        static void GetCatalClean()
        {
            try
            {
                string dirName = @"C:\Users\Zver\Desktop\SkilF\"; 
                if (Directory.Exists(dirName)) 
                {
                    Console.WriteLine("Папки:");
                    string[] dirs = Directory.GetDirectories(dirName);  
                    int i = 0;
                    DateTime dateTimeNow = DateTime.Now;
                    foreach (string d in dirs) 
                    {
                        Console.WriteLine(d);
                        DateTime dateTimeWrite = File.GetLastWriteTime(dirs[i]);
                        TimeSpan timeInterval = dateTimeNow.Subtract(dateTimeWrite);
                        var IntervalMin = timeInterval.TotalMinutes;
                        i++;
                        if (IntervalMin > 30)
                        {
                            DirectoryInfo dirInfo = new(d);
                            dirInfo.Delete(true);
                            Console.WriteLine($"Каталог {dirInfo} удален");
                        }
                    }
                    Console.WriteLine("Файлы:");
                    string[] files = Directory.GetFiles(dirName);
                    i = 0;
                    foreach (string s in files) 
                    {
                        Console.WriteLine(s);
                        DateTime dateTimeWrite = File.GetLastWriteTime(files[i]);
                        TimeSpan timeInterval = dateTimeNow.Subtract(dateTimeWrite);
                        var IntervalMin = timeInterval.TotalMinutes;
                        i++;
                        if (IntervalMin > 30)
                        {
                            FileInfo dirInfo = new(s);
                            dirInfo.Delete();
                            Console.WriteLine($"файл {dirInfo} удален");
                        }
                    }
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }

        static long GetWeightCatal(DirectoryInfo folder)
        {

            long totalSizeDir = 0;
            FileInfo[] allFiles = folder.GetFiles();
  
            foreach (FileInfo file in allFiles)
            {
                totalSizeDir += file.Length;
            }
            DirectoryInfo[] subFolders = folder.GetDirectories();

            foreach (DirectoryInfo dir in subFolders)
            {
                totalSizeDir += GetWeightCatal(dir);
            }

            return totalSizeDir;

        }
    }
}
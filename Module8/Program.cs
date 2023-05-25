using System.IO;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                string FolderdirName = @"C:\Users\Zver\Desktop\SkilF\";
                if (Directory.Exists(FolderdirName))
                {
                    DirectoryInfo folder = new DirectoryInfo(FolderdirName);
                    long WeightCatalog = GetWeightCatal(folder);        //Причёсанный метод для задания 2
                    Console.WriteLine($"Исходный размер каталога в байтах = {WeightCatalog}");
                    GetCatalClean(FolderdirName);        //Задание 1
                    DirectoryInfo folderNew = new DirectoryInfo(FolderdirName);
                    long WeightCatalogNew = GetWeightCatal(folderNew);        //Размер после очистки для задания 3
                    Console.WriteLine($"Освобождённый размер в байтах = {WeightCatalog - WeightCatalogNew}");
                    Console.WriteLine($"Итоговый размер в байтах = {WeightCatalogNew}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
        static void GetCatalClean(string dirName)
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
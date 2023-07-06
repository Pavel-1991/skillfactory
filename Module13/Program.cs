

using System.Diagnostics;

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Специально написаны отдельные короткие блоки,чтобы погрешность в результатах была меньше(рапускаем по очереди).
            //Сначала снимаем показания с одного блока, другой закомментирован. Потом наборот.
            //

            //1 блок

            try
            {
                StreamReader Readtxt = File.OpenText("C:\\Users\\Zver\\Desktop\\SkilF\\Text1.txt");
                var watch1 = Stopwatch.StartNew();
                List<string> Listtxt = new List<string>(0);
                int countLine = 0;
                string s;
                while ((s = Readtxt.ReadLine()) != null)
                {
                    Listtxt.Add(s);
                    countLine++;
                }
                Console.WriteLine($"Кол-во вставленных строк: {countLine}");
                Console.WriteLine($"Время вставки в словарь List: {watch1.Elapsed.TotalMilliseconds}  мс");
                Readtxt.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //

            //2 блок
            try
            {
                StreamReader Readtxt1 = File.OpenText("C:\\Users\\Zver\\Desktop\\SkilF\\Text1.txt");
                LinkedList<string> Listtxt1 = new LinkedList<string>();
                int countLine1 = 0;
                string s1;
                var watch2 = Stopwatch.StartNew();
                while ((s1 = Readtxt1.ReadLine()) != null)
                {
                    Listtxt1.AddLast(s1);
                    countLine1++;
                }
                Console.WriteLine($"Кол-во вставленных строк: {countLine1}");
                Console.WriteLine($"Время вставки в словарь LinkedList: {watch2.Elapsed.TotalMilliseconds}  мс");
                Readtxt1.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //
        }
    }
}
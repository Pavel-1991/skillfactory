

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[5];    ///для 1 задания
            exceptions[0] = new OverflowException("Приведение или операция преобразования приводят к переполнению");
            exceptions[1] = new RankException("В метод передается массив с неправильным числом измерений");
            exceptions[2] = new DivideByZeroException("Деление на 0 не допустимо");
            exceptions[3] = new FormatException("Введено некорректное значение");
            exceptions[4] = new AgeException(18);

            EnteringSort enteringSort = new EnteringSort();
            enteringSort.OnNumberSort += ShowSort;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите минимальный возраст сотрируемых)");
                    int AgeSort = Convert.ToInt32(Console.ReadLine());
                    TestException test = new TestException { TestAge = AgeSort };    ///для 1 задания
                    enteringSort.ReadNumberSort();      ///для 2 задания
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    if (ex is OverflowException) { Console.WriteLine("Ошибка: " + exceptions[0].Message); }
                    if (ex is RankException) { Console.WriteLine("Ошибка: " + exceptions[1].Message); }
                    if (ex is DivideByZeroException) { Console.WriteLine("Ошибка: " + exceptions[2].Message); }
                    if (ex is FormatException) { Console.WriteLine("Ошибка: " + exceptions[3].Message); }
                    if (ex is AgeException) { Console.WriteLine("Ошибка: " + exceptions[4].Message); }
                }
            }
        }
        static void ShowSort(int NumberSort)    ///для 2 задания
        {
            List<string> list = new List<string>();
            list.Add("Сидоров");
            list.Add("Петров");
            list.Add("Ямайцев");
            list.Add("Городовой");
            list.Add("Васин");
            switch (NumberSort)
            {
                case 1:
                    {
                        list.Sort();
                        Console.WriteLine("сортировка А-Я:");
                        foreach (string str in list)
                            Console.WriteLine(str);
                        break;
                    }
                case 2:
                    {
                        list.Sort();
                        list.Reverse();
                        Console.WriteLine("сортировка Я-А:");
                        foreach (string str in list)
                            Console.WriteLine(str);
                        break;
                    }
            }
        }
    }
    class AgeException : Exception   ///для 1 задания
    {
        public AgeException(int minAge) : base($"Люди младше {minAge} к сортировке не допускаются")
        {
        }
    }
    class TestException     ///для 1 задания
    {
        private int age;
        public int TestAge
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new AgeException(18);
                }
                {
                    age = value;
                }
            }
        }
    }
    public class EnteringSort     ///для 2 задания
    {
        public delegate void NumberSortDelegate(int NumberSort);
        public event NumberSortDelegate OnNumberSort;

        public void ReadNumberSort()
        {
            Console.WriteLine();
            Console.WriteLine("Для сортировок от А до Я введите 1, от Я до А введите 2");
            int NumberSort = Convert.ToInt32(Console.ReadLine());

            if(NumberSort != 1 && NumberSort !=2) throw new FormatException();
            NumberSortEntered(NumberSort);
        }
        protected virtual void NumberSortEntered(int NumberSort)
        {
            OnNumberSort?.Invoke(NumberSort);
        }
    }

}

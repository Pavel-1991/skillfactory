
namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[5];
            exceptions[0] = new OverflowException("Приведение или операция преобразования приводят к переполнению");
            exceptions[1] = new RankException("В метод передается массив с неправильным числом измерений");
            exceptions[2] = new DivideByZeroException("Деление на 0 не допустимо");
            exceptions[3] = new ArgumentNullException("Аргумент, передаваемый в метод — null");
            exceptions[4] = new AgeException(18);
            try
            {
                TestException test = new TestException { TestAge = 15 };
            }

            catch (Exception ex)
            {
                if (ex is OverflowException) { Console.WriteLine("Ошибка: " + exceptions[0].Message); }
                if (ex is RankException) { Console.WriteLine("Ошибка: " + exceptions[1].Message); }
                if (ex is DivideByZeroException) { Console.WriteLine("Ошибка: " + exceptions[2].Message); }
                if (ex is ArgumentNullException) { Console.WriteLine("Ошибка: " + exceptions[3].Message); }
                if (ex is AgeException) { Console.WriteLine("Ошибка: " + exceptions[4].Message); }
            }
        }
    }
    class AgeException : Exception
    {
        public AgeException(int minAge) : base($"Люди младше {minAge} к сортировке не допускаются")
        {
        }
    }
    class TestException
    {
        public int TestAge
        {
            get { return TestAge; }
            set
            {
                if (value < 18)
                {
                    throw new AgeException(18);
                }
                {
                    TestAge = value;
                }
            }
        }
    }
}

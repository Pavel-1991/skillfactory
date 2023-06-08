namespace Module10
{
    internal class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var Worker1 = new Worker1(Logger);
            while (true)
            {
                try
                {
                    Worker1.CalcSum();
                }
                catch (Exception ex)
                {
                    Logger.Error("Работа алгоритма приостановлена");
                    Logger.Error($"Произошло следующее исключение: {ex.Message}");
                    Logger.Error("Начинаем с начала");
                }
            }
        }
    }
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public interface IWorker
    {
        void CalcSum();
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Worker1 : IWorker
    {
        ILogger Logger { get; }
        public Worker1(ILogger logger)
        {
            Logger = logger;
        }

        public void CalcSum()
        {
            Console.WriteLine("Введите первое число");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Logger.Event($"Введено первое число = {number1}");
            Console.WriteLine("Введите второе число");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Logger.Event($"Введено второе число = {number2}");
            double sumnumbers = number1+ number2;
            Logger.Event($"Посчитана сумма двух чисел = {sumnumbers}");
            Logger.Event("Всё отработало успешно, попробуем ещё");

        }
    }
}

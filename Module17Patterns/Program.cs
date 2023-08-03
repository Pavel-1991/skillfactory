using System.Text;
using Module17Patterns.SetAccountType;

namespace Module17Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var account = new Account() { Type = "Зарплатный", Balance = 1000};

            switch(account.Type)
            {
                case "Обычный":
                    calculator.CalculateInterestAll(new AccountTypeBase(), account);
                    break;
                case "Зарплатный":
                    calculator.CalculateInterestAll(new AccountTypeSalary(), account);
                    break;
                default: 
                    Console.WriteLine("Некорректный тип учетной записи");
                    break;
            }

            Console.WriteLine(account.Interest);

        }
    }
}
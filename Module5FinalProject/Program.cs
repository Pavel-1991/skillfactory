namespace Module5FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static (string Name, string LastName, int Age, string[] Pets) WriteAmketa()
        {
            (string Name, string LastName, int Age, string[] Pets) User;

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            string age;
            int Corrage;
            do
            {
                Console.WriteLine("Ваш возраст(цифра)?");
                age = Console.ReadLine();
            } while (CheckNum(age, out Corrage));
            User.Age = Corrage;

            Console.WriteLine("Есть ли у вас домашние животные(да/нет)?");
            var FlagPets = Console.ReadLine();
            if (FlagPets == "да")
            {
                string CountPets;
                int CorrCountPets;
                do
                {
                    Console.WriteLine("Сколько у вас животных(вводим цифру)?");
                    CountPets = Console.ReadLine();
                } while (CheckNum(CountPets, out CorrCountPets));
                User.Pets = new string[CorrCountPets];
                for (int i = 0; i < CorrCountPets; i++)
                {
                    Console.WriteLine($"Введите кличку {i} питомца") ;
                    User.Pets[i] = Console.ReadLine();
                }
            }
            {
                if (FlagPets != "нет") { Console.WriteLine("необходимо вводить да или нет. Попробуйте ещё раз"); }
            }

            return User;
        }
        static bool CheckNum(string number, out int corrnamber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0) { corrnamber = intnum; return false; } 
            }
            {
                corrnamber = 0;
                return true;
            }
        }
    }
}
namespace Module5FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var UserInfo = WriteAmketa(); ;
            OutputInfo(UserInfo);          
        }
        static (string Name, string LastName, int Age, string[] Pets, string[] Colors ) WriteAmketa()
        {
            (string Name, string LastName, int Age, string[] Pets, string[] Colors) User;
            User.Pets = new string[] { };
            User.Colors = new string[] { };
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            string age;
            int Corrage;
            do
            {
                Console.WriteLine("Укажите Ваш возраст(вводите цифрой)?");
                age = Console.ReadLine();
            } while (CheckNum(age, out Corrage));
            User.Age = Corrage;

            User.Pets = ArrayPets();
            User.Colors = ArrayColors();
            return User;
        }
        static string[] ArrayPets()
        {
            var result = new string[0];
            string CountPets;
            int CorrCountPets;
            Console.WriteLine("Есть ли у вас домашние животные(да/нет)?");
            for (; ; )
            {
                string FlagPets = Console.ReadLine();
                switch (FlagPets)
                {
                    case "да":
                        do
                        {
                            Console.WriteLine("Сколько у вас животных(введите цифру)?");
                            CountPets = Console.ReadLine();
                        } while (CheckNum(CountPets, out CorrCountPets));
                        result = new string[CorrCountPets];
                        for (int i = 0; i < CorrCountPets; i++)
                        {
                            Console.WriteLine($"Введите кличку {i + 1} питомца");
                            result[i] = Console.ReadLine();
                        }
                        return result;
                    case "нет":
                        return result;
                    default:
                        Console.WriteLine("необходимо вводить да или нет с маленькой буквы. Попробуйте ещё раз");
                        break;
                }
            }       
        }

        static string[] ArrayColors()
        {
            var result = new string[0];
            string CountColors;
            int CorrCountColors;
            do
            {
                Console.WriteLine("Сколько у вас любимых цветов(введите цифру)?");
                CountColors = Console.ReadLine();
            } while (CheckNum(CountColors, out CorrCountColors));
            result = new string[CorrCountColors];
            for (int i = 0; i < CorrCountColors; i++)
            {
                Console.WriteLine($"Введите название {i + 1} цвета");
                result[i] = Console.ReadLine();
            }
            return result;
        }
        static void OutputInfo((string Name, string LastName, int Age, string[] Pets, string[] Colors) User)
        {
            Console.WriteLine("Сколько у вас любимых цветов(введите цифру)?");
            Console.WriteLine($"\nУказаны следующие данные:\nВас зовут(Ф.И.): {User.LastName} {User.Name}");
            Console.WriteLine($"Вам {User.Age} год(а)/лет");
            Console.WriteLine($"У Вас {User.Pets.Length} питомец(ца/цев):"); 
            int i = 1;
            foreach (var NamePet in User.Pets)
            {
                Console.WriteLine($"Имя {i} питомца: {NamePet}");
                i++;
            }
            Console.WriteLine($"У Вас {User.Colors.Length} любимый(ых) цвет(а/ов):");
            int j = 1;
            foreach (var NameColors in User.Colors)
            {
                Console.WriteLine($"Наименование {j} любимого цвета: {NameColors}");
                j++;
            }
        }
        static bool CheckNum(string number, out int corrnamber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0) { corrnamber = intnum; return false; } 
            }
            {
                Console.WriteLine("Данные введены некорректно. Попробуйте ещё раз");
                corrnamber = 0;
                return true;
            }
        }
    }
}
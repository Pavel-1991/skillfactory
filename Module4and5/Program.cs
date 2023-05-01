namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            for (int j = 0; j<3; j++) { 
                п
            Console.WriteLine("Введите имя");

            User.Name = Console.ReadLine();


            Console.WriteLine("Введите фамилию");

            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");

            User.Login = Console.ReadLine();

            User.LoginLength = User.Login.Length;

            Console.WriteLine($"длина логина={User.LoginLength}");

            Console.WriteLine("Есть ли у вас Животные?");

            var result = Console.ReadLine();
            if ( result =="Да")
            {
                User.HasPet = true;
            }
            else
            {
                User.HasPet = false;
            }
            Console.WriteLine("Ваш возраст?");
            User.Age = double.Parse(Console.ReadLine());

            User.favcolors = new string[3];
            Console.WriteLine("введите 3 любимых цвета");

            for (int i = 0; i < User.favcolors.Length; i++) { User.favcolors[i]=Console.ReadLine(); Console.WriteLine($"{ i+1 } цвет: { User.favcolors[i]}");}
            }
        }
    }
}
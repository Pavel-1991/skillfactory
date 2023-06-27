using static System.Reflection.Metadata.BlobBuilder;

namespace Module12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> ListUser = new List<User>();
            ListUser.Add(new User { Login = "adm", Name = "Павел", IsPremium = true });
            ListUser.Add(new User { Login = "user1", Name = "Иван", IsPremium = false });

            Console.WriteLine("Введите логин");
            var ReadLogin = Console.ReadLine();
                try
                {
                    User found = ListUser.Find(User => User.Login == ReadLogin);
                    if (found != null)
                    {
                        Console.WriteLine($"Здравствуйте, {found.Name}");
                        if (found.IsPremium == false) { ShowAds(); }
                    }  
                    else
                    {
                        Console.WriteLine("Пользователя не существует, попробуйте в следующий раз");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            static void ShowAds()
            {
                Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
                Thread.Sleep(1000);
                Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
                Thread.Sleep(2000);
                Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
                Thread.Sleep(3000);
            }
        }
    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EntityFramework
{
    public class UserRepository
    {
        public void SelectAllUsers()
        {
            using (AppContext app = new AppContext())
            {
                List<User> users = app.Users.ToList();
                foreach (var item in users)
                {

                    string e = item.Email != null ? item.Email : "не задано";
                    Console.WriteLine($"Id: {item.Id}\tИмя: {item.Name}\tEmail: {e}\tАдрес: {item.Address}\tКниги на руках: ");
                }
            }
        }

        public void AddUser()
        {
            User user = new User();
            Console.WriteLine("Введите Имя нового пользователя: ");
            user.Name = Console.ReadLine();

            Console.WriteLine("Введите Email нового пользователя: ");
            user.Email = Console.ReadLine();

            Console.WriteLine("Введите Адрес нового пользователя: ");
            user.Address = Console.ReadLine();

            using (AppContext app = new AppContext())
            {
                User newUser = app.Users.FirstOrDefault();
                app.Users.Add(user);
                app.SaveChanges();
            }
        }

        public void DeleteUserId(int id)
        {
            using (AppContext app = new AppContext())
            {
                User? user = app.Users.Where(x => x.Id == id).FirstOrDefault();
                app.Users.Remove(user);
                app.SaveChanges();
            }
        }
        public void UserNameChange(int Id)
        {
            using (AppContext app = new AppContext())
            {
                User userData = app.Users.Where(i => i.Id == Id).FirstOrDefault();
                Console.Write("Введите новое имя пользователя: ");
                userData.Name = Console.ReadLine();

                app.SaveChanges();
            }
        }
    }
}

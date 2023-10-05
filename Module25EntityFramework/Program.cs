namespace Module25EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();
            BookRepository bookRepository = new BookRepository();

            using (var app = new AppContext())
            {
               app.Database.EnsureDeleted();
                app.Database.EnsureCreated();

                var user1 = new User { Name = "Pavel", Email = "Email@Email.ru", Address = "Чкалова 888", Books = new List<Book>() };
                var user2 = new User { Name = "Роман", Email = "Email2@Email.ru", Address = "Чкалова 999", Books = new List<Book>() };
                var user3 = new User { Name = "Алексей", Email = "Email3@Email.ru", Address = "Чкалова 777", Books = new List<Book>() };

                app.Users.Add(user1);
                app.Users.Add(user2);
                app.Users.Add(user3);

                var book1 = new Book { Name = "War and Peace", Year = 1966, Genre = "Роман", AuthorSurname = "Лев толстой", User = user1 };
                var book2 = new Book { Name = "Преступление и наказание", Year = 1976, Genre = "Детектив", AuthorSurname = "Фёдор Достоевский", User = user1 };
                var book3 = new Book { Name = "Обломов", Year = 1986, Genre = "Роман", AuthorSurname = "Иван Гончаров", User = user3 };
                var book4 = new Book { Name = "Отцы и дети", Year = 1996, Genre = "Роман", AuthorSurname = "Иван Тургенев", User = user3 };
                var book5 = new Book { Name = "Евгений Онегин", Year = 1977, Genre = "Роман в стихах", AuthorSurname = "Александр Пушкин", User = user2 };

                app.Books.AddRange(book1, book2, book3, book4, book5);

                app.SaveChanges();
            }

            userRepository.SelectAllUsers();
           // userRepository.AddUser();
            //userRepository.DeleteUserId(1);
           // userRepository.UserNameChange(1);

            bookRepository.SelectAllBooks();
           // bookRepository.AddBook();
            //bookRepository.DeleteBookId(1);
           //bookRepository.BookChangeYearById(2);
           // bookRepository.SortBooksByName();
           // bookRepository.ShowBooksFromAuthor();
           // bookRepository.GetBooksFromGenre();
           // bookRepository.CountBooksFromGenre();
            bookRepository.IsOnHandsByUser();
        }
    }
}
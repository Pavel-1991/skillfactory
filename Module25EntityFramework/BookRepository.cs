using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EntityFramework
{
    public class BookRepository
    {
        public void SelectAllBooks()
        {
            using (AppContext app = new AppContext())
            {
                List<Book> books = app.Books.ToList();
                foreach (var item in books)
                {
                    string a = item.AuthorSurname != null ? item.AuthorSurname : "не задано";
                    Console.WriteLine($"Название книги: {item.Name}\tЖанр: {item.Genre}\tАвтор: {a}\tГод издания: {item.Year}\tId читателя: {item.UserId}");
                }
            }
        }

        public void AddBook()
        {
            Book book = new Book();
            Console.WriteLine("Введите Название новой книги: ");
            book.Name = Console.ReadLine();

            Console.WriteLine("Введите Жанр новой книги: ");
            book.Genre = Console.ReadLine();

            Console.WriteLine("Введите Фамилию автора новой книги: ");
            book.AuthorSurname = Console.ReadLine();

            Console.WriteLine("Введите Год издания книги: ");
            book.Year = Convert.ToInt32(Console.ReadLine());

            using (AppContext app = new AppContext())
            {
                Book newBook = app.Books.FirstOrDefault();
                app.Books.Add(book);
                app.SaveChanges();
            }
        }

        public void DeleteBookId(int id)
        {
            using (AppContext app = new AppContext())
            {
                Book? book = app.Books.Where(x => x.Id == id).FirstOrDefault();
                app.Books.Remove(book);
                app.SaveChanges();
            }
        }
        public void BookChangeYearById(int Id)
        {
            using (AppContext app = new AppContext())
            {

                Book bookData = app.Books.Where(i => i.Id == Id).FirstOrDefault();
                Console.Write("Введите новый год издания книги: ");
                bookData.Year = Convert.ToInt32(Console.ReadLine());
                app.Books.Update(bookData);

                app.SaveChanges();
            }
        }
        public void SortBooksByName()
        {
            using (AppContext app = new AppContext())
            {
                List<Book> books = app.Books.ToList();
                var sort =
                    from book in books
                    orderby book.Name.ToUpper()
                    select new { n = book.Name, a = book.AuthorSurname };
                foreach (var item in sort)
                {
                    Console.WriteLine($"Название: {item.n}\tАвтор: {item.a}");
                }
            }
        }

        public void ShowBooksFromAuthor()
        {
            Console.Write("Введите фамилию автора: ");
            string surname = Console.ReadLine();
            using (AppContext app = new AppContext())
            {
                List<Book> books = app.Books.Where(a => a.AuthorSurname.ToUpper() == surname).ToList();
                foreach (var item in books)
                {
                    Console.WriteLine(item.Name + " " + item.AuthorSurname);
                }
            }

        }

        public void GetBooksFromGenre()
        {
            Console.WriteLine("Введите интересующий жанр: ");
            string genre = Console.ReadLine();
            using (AppContext app = new AppContext())
            {
                List<Book> books = app.Books.Where(b => b.Genre.ToUpper() == genre).ToList();
                foreach (var item in books)
                {
                    Console.WriteLine(item.Genre + " " + item.Name + " " + item.AuthorSurname);
                }
            }
        }
        public void CountBooksFromGenre()
        {
            Console.WriteLine("Введите интересующий жанр для подсчёта количества книг: ");
            string genre = Console.ReadLine();
            uint count = default;
            using (AppContext app = new AppContext())
            {
                List<Book> books = app.Books.Where(g => g.Genre.ToUpper() == genre).ToList();
                Console.WriteLine($"Количество книг интересующего жанра \"{genre}\": {books.Count()}");
            }
        }

        public void IsOnHandsByUser()
        {
            Console.Write("Введите Id читателя: ");
            int userid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввведите Id книги: ");
            int bookid = Convert.ToInt32(Console.ReadLine());
            using (AppContext app = new AppContext())
            {
                var search = app.Users.Where(uid => uid.Id == userid && uid.Books.Contains(app.Books.Where(b => b.Id == bookid).First()));
                Console.WriteLine($"Флаг нахождения книги: {search.Any()} у Id пользователя: {userid}");
            }
        }
    }
}

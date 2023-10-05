

namespace Module25EntityFramework
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string AuthorSurname { get; set; }
        public int Year { get; set; }

        public int? UserId { get; set; } 
        public User? User { get; set; }
    }
}

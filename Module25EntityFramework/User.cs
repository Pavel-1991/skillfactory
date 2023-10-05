

namespace Module25EntityFramework
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        //навигационное свойство
        public List<Book>? Books { get; set; }
    }
}

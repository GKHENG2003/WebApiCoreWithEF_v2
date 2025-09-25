using LibraryManagementSystemEF.Entities.Contract;

namespace LibraryManagementSystemEF.Entities
{
    public class Book : ISoftDeletable
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public Genre Genre { get; set; } 

        public int? GenreId { get; set; } 

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public bool IsDeleted { get; set; }
    }
}

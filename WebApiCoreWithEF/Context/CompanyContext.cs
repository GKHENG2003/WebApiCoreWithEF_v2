
namespace WebApiCoreWithEF.Context
{
    using LibraryManagementSystemEF.Entities;
    using Microsoft.EntityFrameworkCore;

    public class CompanyContext
        : DbContext
    {
        public CompanyContext(DbContextOptions options)
            : base(options)
        {

        }


        public DbSet<LibraryBook> LibraryBooks { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
    }
}

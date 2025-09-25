using LibraryManagementSystemEF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystemEF.Data.Configuration
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder.Property(b => b.Title).IsRequired().HasColumnType("VARCHAR").HasMaxLength(100);

            builder.Property(b => b.Year).IsRequired();

            builder.HasOne(b => b.Author).WithMany(a => a.Books).HasForeignKey(b => b.AuthorId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(b => b.Genre).WithMany().HasForeignKey(b => b.GenreId).OnDelete(DeleteBehavior.SetNull);

            builder.HasData(LoadBooks());

        }

        private Book[] LoadBooks()
        {
            return new Book[]
            {
                new Book
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Year = 1925,
                    GenreId = 1,
                    AuthorId = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "To Kill a Mockingbird",
                    Year = 1960,
                    GenreId = 2,
                    AuthorId = 2
                },
                new Book
                {
                    Id = 3,
                    Title = "1984",
                    Year = 1949,
                    GenreId = 3,
                    AuthorId = 3
                },
                new Book
                {
                    Id = 4,
                    Title = "Pride and Prejudice",
                    Year = 1813,
                    GenreId = 4,
                    AuthorId = 4
                },
                new Book
                {
                    Id = 5,
                    Title = "The Catcher in the Rye",
                    Year = 1951,
                    GenreId = 5,
                    AuthorId = 5
                }
            };
        }
    }

}

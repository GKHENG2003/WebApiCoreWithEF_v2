using LibraryManagementSystemEF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystemEF.Data.Configuration
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(a => a.Biography).IsRequired().HasColumnType("VARCHAR").HasMaxLength(500);

            builder.HasMany(a => a.Books).WithOne(b => b.Author).HasForeignKey(b => b.AuthorId).OnDelete(DeleteBehavior.Cascade);

            builder.HasData(LoadAuthors());
        }

        private Author[] LoadAuthors()
        {
            return new Author[]
            {
                new Author
                {
                    Id = 1,
                    Biography = "Author One Biography",
                    Email = "AuthorOne@exmaple.com",
                    Password = "password",
                    Name = "Author One",
                },
                new Author
                {
                    Id = 2,
                    Biography = "Author Two Biography",
                    Email = "AuthorTwo@exmaple.com",
                    Password = "password",
                    Name = "Author Two",
                },
                new Author {
                    Id = 3,
                    Biography = "Author Three Biography",
                    Email = "AuthorThree@exmaple.com",
                    Password = "password",
                    Name = "Author Three",
                },
                new Author {
                    Id = 4,
                    Biography = "Author Four Biography",
                    Email = "AuthorFour@exmaple.com",
                    Password = "password",
                    Name = "Author Four",
                },
                new Author {
                    Id = 5,
                    Biography = "Author Five Biography",
                    Email = "AuthorFive@exmaple.com",
                    Password = "password",
                    Name = "Author Five",
                },

            };
        }
    }
}

using LibraryManagementSystemEF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystemEF.Data.Configuration
{
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Id).ValueGeneratedOnAdd();

            builder.Property(g => g.Name).IsRequired().HasColumnType("VARCHAR").HasMaxLength(50);

            builder.HasData(LoadGenres());
        }

        private Genre[] LoadGenres()
        {
            return new Genre[]
            {
                new Genre
                {
                    Id = 1,
                    Name = "Fiction"
                },
                new Genre
                {
                    Id = 2,
                    Name = "Science Fiction"
                },
                new Genre
                {
                    Id = 3,
                    Name = "Art"
                },
                new Genre
                {
                    Id = 4,
                    Name = "Gazetteers"
                },
                new Genre
                {
                    Id = 5,
                    Name = "Horror"
                }
            };
        }
    }



}

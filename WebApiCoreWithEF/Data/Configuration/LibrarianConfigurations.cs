using LibraryManagementSystemEF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LibraryManagementSystemEF.Data.Configuration
{
    internal class LibrarianConfigurations : IEntityTypeConfiguration<Librarian>
    {
        public void Configure(EntityTypeBuilder<Librarian> builder)
        {

            builder.Property(l => l.Salary).IsRequired();


            builder.HasData(
                new Librarian
                {
                    Id = 8,
                    Name = "Ahmed Smith",
                    Email = "ahmedSmith@exmaple.com",
                    Password = "ahmed123",
                    Salary = 5000,
                    DateOfEmployment = DateTime.Now
                });
        }

    }
}

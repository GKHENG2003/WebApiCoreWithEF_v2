using LibraryManagementSystemEF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystemEF.Data.Configuration
{
    internal class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.Name).IsRequired().HasColumnType("VARCHAR").HasMaxLength(100);

            builder.Property(u => u.Email).IsRequired();

            builder.Property(u => u.Password).IsRequired().HasColumnType("VARCHAR").HasMaxLength(30);

            builder.HasIndex(u => u.Email).IsUnique();

            builder.HasDiscriminator<string>("UserType")
                .HasValue<Member>("Member")
                .HasValue<Librarian>("Librarian")
                .HasValue<Author>("Author");
        }
    }
}

using LibraryManagementSystemEF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemEF.Data.Configuration
{
    internal class BorrowedBookConfigurations : IEntityTypeConfiguration<BorrowedBook>
    {
        public void Configure(EntityTypeBuilder<BorrowedBook> builder)
        {
            builder.HasKey(bb => bb.Id);

            builder.Property(bb => bb.Id).ValueGeneratedOnAdd();

            builder.HasOne(bb => bb.BookDetails)
                .WithMany()
                .HasForeignKey(bb => bb.BookDetailsId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(bb => bb.Member)
                .WithMany(m => m.BorrowedBooks)
                .HasForeignKey(bb => bb.MemberId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(bb => bb.TitleSnapshot).HasColumnType("VARCHAR").HasMaxLength(100).IsRequired();

            builder.Property(bb => bb.YearSnapshot).IsRequired();

            builder.Property(bb => bb.GenreSnapshot).HasColumnType("VARCHAR").HasMaxLength(50);

            builder.Property(bb => bb.BorrowDate).IsRequired().HasDefaultValue(DateTime.Now);

            builder.Property(bb => bb.ReturnDate).IsRequired();

            builder.Property(bb => bb.IsReturned).IsRequired().HasDefaultValue(false);
        }
    }
}

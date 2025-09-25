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
    internal class MemberConfigurations : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {           

            builder.Property(m => m.DateOfMembership).IsRequired().HasDefaultValue(DateTime.Now);

            builder.Property(m => m.MembershipDuration).IsRequired();

            builder.HasMany(m => m.BorrowedBooks)
                .WithOne(bb => bb.Member)
                .HasForeignKey(bb => bb.MemberId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Member
                {
                    Id = 6,
                    Name = "John Doe",
                    Email = "johnDoe@example.com",
                    Password = "john123",
                    MembershipDuration = 30

                },
                new Member
                {
                    Id = 7,
                    Name = "Jane Doe",
                    Email = "janDoe@example.com",
                    Password = "jane123",
                    MembershipDuration = 30
                });
        }
    }
}

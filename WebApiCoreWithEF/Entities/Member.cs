using System;
using System.Collections.Generic;

namespace LibraryManagementSystemEF.Entities
{
    public class Member : User
    {
        public DateTime DateOfMembership { get; set; } = DateTime.Now;

        public int MembershipDuration { get; set; }

        //public ICollection<BorrowedBook> BorrowedBooks { get; set; } = [];
        public ICollection<BorrowedBook> BorrowedBooks { get; set; }

        public override string ToString()
        {
            return string.Join(", ", new string[] { base.ToString(), $"Date of Membership: {DateOfMembership}", $"Membership Duration: {MembershipDuration}" });
        }

    }
}

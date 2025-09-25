using System;

namespace LibraryManagementSystemEF.Entities
{
    public class BorrowBook
    {
        //public int BookId { get; set; }
        public Book book { get; set; }
        public int MemberId { get; set; }

        public int MembershipDuration { get; set; }
    }
}

using System;

namespace LibraryManagementSystemEF.Entities
{
    public class BorrowedBook
    {
        public int Id { get; set; }

        public Book BookDetails { get; set; }

        public int? BookDetailsId { get; set; }

        public Member Member { get; set; }

        public int MemberId { get; set; }

        public string TitleSnapshot { get; set; }

        public int YearSnapshot { get; set; }

        public string GenreSnapshot { get; set; }

        public DateTime BorrowDate { get; set; } = DateTime.Now;

        public DateTime ReturnDate { get; set; }

        public bool IsReturned { get; set; }

        override public string ToString()
        {
            return $"Id: {Id}, Title: {TitleSnapshot}, Year: {YearSnapshot}, Genre: {GenreSnapshot}, Borrow Date: {BorrowDate}, Return Date: {ReturnDate}, Is Returned: {IsReturned}, Member {Member}";
        }
    }
}

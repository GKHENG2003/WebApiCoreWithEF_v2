using LibraryManagementSystemEF.Entities;

namespace WebApiCoreWithEF.Entities
{
    public class ReturnBook
    {
        public Book book { get; set; }
        public int MemberId { get; set; }
    }
}

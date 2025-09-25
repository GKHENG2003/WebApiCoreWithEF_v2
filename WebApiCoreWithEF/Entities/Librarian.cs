using System;

namespace LibraryManagementSystemEF.Entities
{
    public class Librarian : User
    {
        public int Salary { get; set; }

        public DateTime DateOfEmployment { get; set; } = DateTime.Now;

    }
}

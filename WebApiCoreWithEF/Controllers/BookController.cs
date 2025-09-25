using LibraryManagementSystemEF.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using WebApiCoreWithEF.Context;
using WebApiCoreWithEF.Entities;
using static System.Reflection.Metadata.BlobBuilder;

namespace WebApiCoreWithEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private CompanyContext _companyContext;

        public BookController(CompanyContext companyContext)
        {
            _companyContext = companyContext;
        }

        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _companyContext.Books;
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            _companyContext.Books.Add(value);
            _companyContext.SaveChanges();
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)
        {
            var books = _companyContext.Books.FirstOrDefault(s => s.Id == id);
            if (books != null)
            {
                _companyContext.Entry<Book>(books).CurrentValues.SetValues(value);
                _companyContext.SaveChanges();
            }
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var book = _companyContext.Books.FirstOrDefault(s => s.Id == id);
            if (book != null)
            {
                _companyContext.Books.Remove(book);
                _companyContext.SaveChanges();
            }
        }

        [HttpPost("addBorrowableBook")]
        public void addBorrowableBook([FromBody] LibraryBook libraryBook)
        {
            _companyContext.LibraryBooks.Add(libraryBook);
            _companyContext.SaveChanges();
        }

        [HttpPost("borrowBook")]
        public string borrowBook([FromBody] BorrowBook borrowBook)
        {
            var isAlreadyBorrowed = _companyContext.BorrowedBooks
                    .Any(bb => bb.BookDetailsId == borrowBook.book.Id && bb.MemberId == borrowBook.MemberId && bb.IsReturned == false);

            if (isAlreadyBorrowed)
            {
                return "You have already borrowed this book";
            }

            var bookId = borrowBook.book.Id;

            LibraryBook? bookToBorrow = _companyContext.LibraryBooks
            .FirstOrDefault(b => b.BookId == bookId);


            if (bookToBorrow == null)
            {
                return "Invalid book id";
            }

            if (bookToBorrow.Quantity == 0)
            {
                return "Book is out of stock";
            }



            BorrowedBook borrowedBook = new BorrowedBook
            {
                TitleSnapshot = borrowBook.book.Title,
                YearSnapshot = borrowBook.book.Year,
                GenreSnapshot = borrowBook.book.Genre.ToString(),
                ReturnDate = DateTime.Now.AddDays(borrowBook.MembershipDuration),
                MemberId = borrowBook.MemberId,
                BookDetailsId = bookToBorrow.BookId,
                IsReturned = false,
            };


            _companyContext.BorrowedBooks.Add(borrowedBook);

            //((Member)AppController.currentUser).BorrowedBooks.Add(borrowedBook);

            bookToBorrow.Quantity--;

            try
            {
                _companyContext.SaveChanges();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "Book borrowed successfully";
        }

        [HttpPost("returnBook")]
        public string returnBook([FromBody] ReturnBook returnBook)
        {
            var borrowedBook = _companyContext.BorrowedBooks
                    .Include(bb => bb.BookDetails)
                .FirstOrDefault(bb => bb.BookDetailsId == returnBook.book.Id
                && bb.MemberId == returnBook.MemberId
                && bb.IsReturned == false);


            if (borrowedBook == null)
            {
                return "Invalid book id";
            }



            var bookToReturn = _companyContext.LibraryBooks.FirstOrDefault(b => b.BookId == borrowedBook.BookDetails.Id);

            if (bookToReturn == null)
            {
                return "Invalid book id";
            }

            borrowedBook.IsReturned = true;

            bookToReturn.Quantity++;

            //((Member)AppController.currentUser).BorrowedBooks.Remove(borrowedBook);
            _companyContext.BorrowedBooks.Remove(borrowedBook);

            _companyContext.SaveChanges();

            return "Book returned successfully";
        }
    }
}

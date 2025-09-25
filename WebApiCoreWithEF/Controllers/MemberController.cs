using LibraryManagementSystemEF.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApiCoreWithEF.Context;

namespace WebApiCoreWithEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private CompanyContext _companyContext;

        public MemberController(CompanyContext companyContext)
        {
            _companyContext = companyContext;
        }

        // GET: api/<MemberController>
        [HttpGet]
        public IEnumerable<BorrowedBook> Get()
        {
            return _companyContext.BorrowedBooks;
        }

        // GET api/<MemberController>/5
        [HttpGet("{id}")]
        public IEnumerable<BorrowedBook> Get(int id)
        {
            int pageNumber = 1;
            int pageSize = 5;

            var borrowedBooks = _companyContext.BorrowedBooks
                        .Where(bb => bb.MemberId == id & bb.IsReturned == false)
                        .Skip((pageNumber - 1) * pageSize)
                        .Take(pageSize);

            return borrowedBooks;
        }
    }
}

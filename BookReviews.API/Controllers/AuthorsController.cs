using BookReviews.API.Data.Sample;
using BookReviews.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllAuthors()
        {
            //merr te dhena nga database (fake db)
            var result = FakeData.GetAllFakeAuthors();
            //kthimi
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthorById(int id)
        {
            //marr te dhenat nga database (fake db)
            var result = FakeData.GetAllFakeAuthors()
                .FirstOrDefault(x => x.Id == id);

            return Ok(result);
        }

        [HttpGet("new/{firstName}")]
        public IActionResult GetAuthorByFirstName(string firstName)
        {
            //marr te dhenat nga database (fake db)
            var result = FakeData.GetAllFakeAuthors()
                .FirstOrDefault(x => x.FirstName == firstName);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddAuthor()
        {
            //shtohen te dhenat

            return Ok();
        }
    }
}

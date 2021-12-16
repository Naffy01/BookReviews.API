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
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthorById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddAuthor()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAuthor()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteAuthor()
        {
            return Ok();
        }
    }
}

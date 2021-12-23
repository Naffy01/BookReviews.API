using BookReviews.API.Data;
using BookReviews.API.Data.DTOs;
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
        private AppDbContext _context;
        public AuthorsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllAuthors()
        {
            var result = _context.Authors.ToList();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthorById(int id)
        {
            var result = _context.Authors.FirstOrDefault(n => n.Id == id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddAuthor([FromBody]AuthorDTO author)
        {
            var _author = new Author()
            {
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateCreated = DateTime.Now
            };

            _context.Authors.Add(_author);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(int id, [FromBody]AuthorDTO author)
        {
            var dbAuthor = _context.Authors.FirstOrDefault(x => x.Id == id);
            if (dbAuthor == null)
            {
                return NotFound();
            } else
            {
                dbAuthor.FirstName = author.FirstName;
                dbAuthor.LastName = author.LastName;
                _context.SaveChanges();
                return Ok("Author updated");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            var dbAuthor = _context.Authors.FirstOrDefault(x => x.Id == id);
            if(dbAuthor == null)
            {
                return NotFound($"Author with id = {id} not found");
            } else
            {
                _context.Authors.Remove(dbAuthor);
                _context.SaveChanges();
                return Ok($"Autori me id = {id} u fshi nga databaza");
            }
        }
    }
}

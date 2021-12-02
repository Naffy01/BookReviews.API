using BookReviews.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviews.API.Data.Services
{
    public interface IAuthorsService
    {
        List<Author> GetAllAuthors();
        Author GetAuthorById(int id);
        Author UpdateAuthor(int id, Author newValue);
        Author AddAuthor(Author author);
        void DeleteAuthor(int id);
    }
}

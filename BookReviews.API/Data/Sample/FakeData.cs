using BookReviews.API.Models;
using System;
using System.Collections.Generic;

namespace BookReviews.API.Data.Sample
{
    public static class FakeData
    {
        public static List<Author> GetAllFakeAuthors()
        {
            List<Author> authors = new List<Author>()
            {
                new Author() {
                    Id = 1,
                    FirstName = "Ismail",
                    LastName = "Kadare",
                    DateCreated = DateTime.Now
                },
                new Author() {
                    Id = 2,
                    FirstName = "Franc",
                    LastName = "Kafka",
                    DateCreated = DateTime.Now
                },
                new Author() {
                    Id = 3,
                    FirstName = "Naim",
                    LastName = "Frasheri",
                    DateCreated = DateTime.Now
                }
            };

            return authors;
        }
    }
}

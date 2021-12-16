using BookReviews.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviews.API.Data
{
    public class AppDbContext:DbContext
    {
        //1. Config constructor
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        //2. Config tables
        public DbSet<Author> Authors { get; set; }
    }
}

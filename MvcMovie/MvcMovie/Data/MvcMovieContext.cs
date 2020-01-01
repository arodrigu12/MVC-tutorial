using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        //Entity set property corresponds to db table, 
        //while an entity corresponds to a row in the table
        public DbSet<Movie> Movie { get; set; }
    }
}

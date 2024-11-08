using Microsoft.EntityFrameworkCore;

namespace learningDotnet.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<learningDotnet.Models.Movie> Movie { get; set; } = default!;
    }
}

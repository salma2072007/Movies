using Microsoft.EntityFrameworkCore;
using Movies.models;

namespace Movies.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Nationalty> Nationalty { get; set; }

        public DbSet<Diractory> Diractories { get; set; }
    }

}

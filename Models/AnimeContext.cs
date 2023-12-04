using Microsoft.EntityFrameworkCore;

namespace Final_Project
{
    public class AnimeContext : DbContext
    {
        public AnimeContext (DbContextOptions<AnimeContext> options)
            : base(options)
        {
        }
        public DbSet<Anime> Anime {get; set;}
        public DbSet<Character> Character {get; set;}
    }
}
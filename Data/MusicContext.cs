using MusicAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicAPI.Data
{

    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }

        public DbSet<Music> Music { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .HasMany(a => a.Songs)   // Ett Album har många låtar
                .WithOne(s => s.Album)   // En låt tillhör ett Album
                .HasForeignKey(s => s.AlbumId) // AlbumId är FK i Song
                .OnDelete(DeleteBehavior.Cascade); // Om album raderas, radera låtarna också
        }


    }
}
using MusicAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicAPI.Data {

    public class MusicContext : DbContext {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }

        public DbSet <Music> Music { get; set; }
    }
}
namespace MusicArtists.Data
{
    using System.Data.Entity;

    using MusicArtists.Models;
    using MusicArtists.Data.Migrations;

    public class MusicArtistsContext : DbContext
    {
        public MusicArtistsContext()
            : base("MusicArtistsDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicArtistsContext, Configuration>());
        }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Album> Albums { get; set; }

    }
}

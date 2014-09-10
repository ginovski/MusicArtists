namespace MusicArtists.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using MusicArtists.Data;
    using MusicArtists.Models;

    public sealed class Configuration : DbMigrationsConfiguration<MusicArtistsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(MusicArtistsContext context)
        {
            context.Artists.Add(new Artist
            {
                Name = "Skrillex",
                Country = "USA",
                DateOfBirth = "15-01-1988",
            });
            context.Artists.Add(new Artist
            {
                Name = "2Pac",
                Country = "USA",
                DateOfBirth = "16-06-1971",
            });
            context.Artists.Add(new Artist
            {
                Name = "Ico Hazarta",
                Country = "BG",
                DateOfBirth = "15-05-1978",
            });

            base.Seed(context);
        }
    }
}

namespace MusicArtists.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using MusicArtists.Data;

    public sealed class Configuration : DbMigrationsConfiguration<MusicArtistsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(MusicArtistsContext context)
        {
        }
    }
}

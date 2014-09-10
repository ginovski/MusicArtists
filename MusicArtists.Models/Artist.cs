namespace MusicArtists.Models
{
    using System;
    using System.Collections.Generic;

    public class Artist
    {
        private IEnumerable<Album> albums;
        private IEnumerable<Song> songs;

        public Artist()
        {
            this.Albums = new HashSet<Album>();
            this.Songs = new HashSet<Song>();
        }

        public int ArtistId { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string DateOfBirth { get; set; }

        public IEnumerable<Album> Albums
        {
            get
            {
                return this.albums;
            }
            set
            {
                this.albums = value;
            }
        }

        public IEnumerable<Song> Songs
        {
            get
            {
                return this.songs;
            }
            set
            {
                this.songs = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} - {2}", this.ArtistId, this.Name, this.Country);
        }
    }
}

namespace MusicArtists.Models
{
    using System.Collections.Generic;

    public class Album
    {
        private IEnumerable<Artist> artists;
        private IEnumerable<Song> songs;

        public Album()
        {
            this.Artists = new HashSet<Artist>();
            this.Songs = new HashSet<Song>();
        }

        public int AlbumId { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Producer { get; set; }

        public virtual IEnumerable<Artist> Artists
        {
            get
            {
                return this.artists;
            }
            set
            {
                this.artists = value;
            }
        }

        public virtual IEnumerable<Song> Songs
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
    }
}

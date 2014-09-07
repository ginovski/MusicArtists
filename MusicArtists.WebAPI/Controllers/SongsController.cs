namespace MusicArtists.WebAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using MusicArtists.Data;
    using MusicArtists.Models;
    using MusicArtists.WebAPI.Models;

    public class SongsController : ApiController
    {
        private IRepository<Song> songs;

        public SongsController()
        {
            this.songs = new MusicArtistsRepository<Song>(new MusicArtistsContext());
        }

        public IEnumerable<Song> Get()
        {
            return this.songs.All();
        }

        public Song Get(int id)
        {
            return this.songs.Get(id);
        }

        public void Post([FromBody]Song song)
        {
            this.songs.Add(song);
        }

        public void Put(int id, [FromBody]Song song)
        {
            this.songs.Update(id, song);
        }

        public void Delete(int id)
        {
            this.songs.Delete(id);
        }
    }
}

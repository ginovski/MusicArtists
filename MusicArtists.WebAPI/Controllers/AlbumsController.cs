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

    public class AlbumsController : ApiController
    {
        private IRepository<Album> albums;

        public AlbumsController()
        {
            this.albums = new MusicArtistsRepository<Album>(new MusicArtistsContext());
        }

        public IEnumerable<Album> Get()
        {
            return this.albums.All();
        }

        public Album Get(int id)
        {
            return this.albums.Get(id);
        }

        public IEnumerable<Album> Get(string title)
        {
            return this.albums.All().Where(a => a.Title == title);
        }

        [HttpGet]
        public IEnumerable<Album> GetByProducer(string producer)
        {
            return this.albums.All().Where(a => a.Producer == producer);
        }

        [HttpGet]
        public IEnumerable<Album> GetByYear(int year)
        {
            return this.albums.All().Where(a => a.Year == year);
        }

        public void Post([FromBody]Album album)
        {
            this.albums.Add(album);
        }

        public void Put(int id, [FromBody]Album album)
        {
            this.albums.Update(id, album);
        }

        public void Delete(int id)
        {
            this.albums.Delete(id);
        }
    }
}

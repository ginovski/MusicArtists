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

    public class ArtistsController : ApiController
    {
        private IRepository<Artist> artists;

        public ArtistsController()
        {
            this.artists = new MusicArtistsRepository<Artist>(new MusicArtistsContext());
        }

        public IEnumerable<Artist> Get()
        {
            return this.artists.All();
        }

        
        public IEnumerable<Artist> Get(string country)
        {
            return this.artists.All().Where(a => a.Country == country);
        }

        public Artist Get(int id)
        {
            return this.artists.Get(id);
        }

        [HttpGet]
        public Artist GetByName(string name)
        {
            return this.artists.All().FirstOrDefault(a => a.Name == name);
        }

        [Route("api/artists/{artistId}/albums")]
        [HttpGet]
        public IEnumerable<Album> GetAlbumsById(int artistId)
        {
            return this.artists.Get(artistId).Albums;
        }

        public void Post([FromBody]Artist artist)
        {
            this.artists.Add(artist);
        }

        public void Put(int id, [FromBody]Artist artist)
        {
            this.artists.Update(id, artist);
        }

        public void Delete(int id)
        {
            this.artists.Delete(id);
        }
    }
}

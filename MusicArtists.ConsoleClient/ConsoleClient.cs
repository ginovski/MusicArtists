namespace MusicArtists.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    using MusicArtists.Models;

    public class ConsoleClient
    {
        public static void Main()
        {
            // Working with JSON
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51641/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var artistToPost = new Artist
            {
                Name = "Snoop Dogg",
                Country = "USA",
                DateOfBirth = "20-10-1971"
            };

            // Post artist Snoop Dogg. Run again to see that is added
            client.PostAsJsonAsync<Artist>("api/Artists", artistToPost);

            // Delete Artist with id: 1
            client.DeleteAsync("api/Artists/1");

            // Get artists
            var response = client.GetAsync("api/Artists").Result;
            var artistsFromJson = GetArtists(response);

            Console.WriteLine("From JSON");
            foreach (var artist in artistsFromJson)
            {
                Console.WriteLine(artist);
            }

            Console.WriteLine();

            //Get with XML
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

            // Post artist Snoop Dogg. Run again to see that is added
            client.PostAsXmlAsync<Artist>("api/Artists", artistToPost);

            // Delete Artist with id: 1
            client.DeleteAsync("api/Artists/1");

            var artistsFromXml = GetArtists(response);

            Console.WriteLine("From XML");

            foreach (var artist in artistsFromJson)
            {
                Console.WriteLine(artist);
            }
        }

        public static IEnumerable<Artist> GetArtists(HttpResponseMessage response)
        {
            return response.Content.ReadAsAsync<IEnumerable<Artist>>().Result;
        }
    }
}

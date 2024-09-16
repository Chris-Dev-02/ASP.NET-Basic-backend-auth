using BasicBackendAuthentication.Models;
using System.Text.Json;

namespace BasicBackendAuthentication.Services
{
    public class BeerService : IBeerService
    {
        string path = @"C:\Users\chris\Documents\Personal Projects\Programming practices\Web Programming practices\Basic backend auth\Basic backend auth\beers.json";
    
        public async Task<List<Beer>> Get()
        {
            string content = await File.ReadAllTextAsync(path);
            var beers = JsonSerializer.Deserialize<List<Beer>>(content);
            return beers;
        }
    }
}

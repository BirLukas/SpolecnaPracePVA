using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;

namespace SpolecnaPracePVACode
{
    internal class APIHandler
    {
        private RestClient _client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/");
        private RestRequest _requestRandom = new RestRequest("random.php", Method.Get);

        public async Task<Cocktail> GetRandomCocktail()
        {
            RestResponse response = await _client.ExecuteAsync(_requestRandom);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var cocktailResponse = System.Text.Json.JsonSerializer.Deserialize<DrinkResponse>(response.Content, options);
            return cocktailResponse?.drinks?.FirstOrDefault(); // vrátí první koktejl z odpovědi
        }
        public async Task<Cocktail> SearchCocktailByID(string id)
        {
            RestRequest _requestSearch = new RestRequest($"lookup.php?i={id}", Method.Get);

            RestResponse response = await _client.ExecuteAsync(_requestSearch);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var cocktailResponse = System.Text.Json.JsonSerializer.Deserialize<DrinkResponse>(response.Content, options);
            return cocktailResponse?.drinks?.FirstOrDefault();

        }
    }
}

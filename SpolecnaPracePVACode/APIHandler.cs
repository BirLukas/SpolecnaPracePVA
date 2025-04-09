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
        private RestRequest _request = new RestRequest("random.php", Method.Get);

        public async Task<Cocktail> GetRandomCocktail()
        {
            RestResponse response = await _client.ExecuteAsync(_request);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }; 

            var cocktailResponse = System.Text.Json.JsonSerializer.Deserialize<DrinkResponse>(response.Content, options);
            return cocktailResponse?.drinks?.FirstOrDefault(); // vrátí první koktejl z odpovědi
        }
    }
}

using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL
{
    public class SpaceRepository : ISpaceRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly JsonSerializerOptions _options;
        static List<ImportantLocation> ImportantLocationsList = new List<ImportantLocation>() { };

        public SpaceRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public void Dispose()
        {
        }

        public async Task<SpaceLocationResponse> GetLocation()
        {
            var httpClient = _httpClientFactory.CreateClient();
            SpaceLocation spaceLocation = new SpaceLocation();
            var response = httpClient.GetStringAsync("http://api.open-notify.org/iss-now.json").Result;
            var a=  JsonConvert.DeserializeObject<SpaceLocationResponse>(response);
            return a;
        }
        public List<ImportantLocation> SaveLocation(ImportantLocation importantLocation)
        {
            ImportantLocationsList.Add(importantLocation);
            return ImportantLocationsList;
        }
    }
}

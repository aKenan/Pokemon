using Adecco.Pokemon.Application.Models.ApiResults;
using Adecco.Pokemon.Application.Models.Configuration;
using Adecco.Pokemon.Application.Services.Contracts;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Adecco.Pokemon.BuildingBlocks.Infrastructure.Extensions;

namespace Adecco.Pokemon.Application.Services
{
    /// <summary>
    /// Pokemon API service.
    /// </summary>
    public class PokemonApiService : IPokemonApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ApiConfigurationModel _apiConfigurationModel;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpClient">Http client.</param>
        /// <param name="apiOptions">Api options.</param>
        public PokemonApiService(HttpClient httpClient, IOptions<ApiConfigurationModel> apiOptions)
        {
            _httpClient = httpClient;
            _apiConfigurationModel = apiOptions.Value;
        }

        /// <inheritdoc/>
        public async Task<GetPokemonsApiResultModel> GetPokemonsAsync(int pageNumber, int pageSize)
        {
            var paramsDictionary = new Dictionary<string, string>
            {
                { "limit", pageSize.ToString() },
                { "offset", ((pageNumber - 1) * pageSize).ToString() }
            };

            var query = paramsDictionary.GetQueryParameters();

            string route = Extensions.GetRequestUrl(_apiConfigurationModel.FullAddress, "pokemon", query);

            var result = await _httpClient.GetAsync(route);
            
            var readTask = await result.Content.ReadAsStringAsync();

            var apiResults = JsonConvert.DeserializeObject<GetPokemonsApiResultModel>(readTask);

            return apiResults;
        }
    }
}

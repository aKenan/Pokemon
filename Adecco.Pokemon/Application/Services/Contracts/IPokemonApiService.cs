using Adecco.Pokemon.Application.Models.ApiResults;
using System.Threading.Tasks;

namespace Adecco.Pokemon.Application.Services.Contracts
{
    /// <summary>
    /// Pokemon API service interface.
    /// </summary>
    public interface IPokemonApiService
    {
        /// <summary>
        /// Get all pokemons.
        /// </summary>
        /// <param name="pageNumber">Page number.</param>
        /// <param name="pageSize">Page size</param>
        /// <returns><see cref="GetPokemonsApiResultModel"/></returns>
        Task<GetPokemonsApiResultModel> GetPokemonsAsync(int pageNumber, int pageSize);
    }
}

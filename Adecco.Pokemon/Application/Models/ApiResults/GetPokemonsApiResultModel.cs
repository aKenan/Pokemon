using Adecco.Pokemon.Application.Models.ViewModels;
using System.Collections.Generic;

namespace Adecco.Pokemon.Application.Models.ApiResults
{
    /// <summary>
    /// Get all pokemons api result model.
    /// </summary>
    public class GetPokemonsApiResultModel
    {
        /// <summary>
        /// Total count.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Api Results.
        /// </summary>
        public IEnumerable<PokemonViewModel> Results { get; set; }
    }
}

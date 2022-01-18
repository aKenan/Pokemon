using Adecco.Pokemon.Application.Models.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Adecco.Pokemon.Application.Queries.Pokemon.GetByName
{
    /// <summary>
    /// Get pokemon by name query.
    /// </summary>
    public class GetPokemonByNameQuery : IRequest<PokemonDetailedViewModel>
    {
        /// <summary>
        /// Pokemon name.
        /// </summary>
        [FromRoute(Name = "name")]
        public string Name { get; set; }
    }
}

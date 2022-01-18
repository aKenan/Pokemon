using Adecco.Pokemon.Application.Models.ViewModels;
using Adecco.Pokemon.BuildingBlocks.Infrastructure.Pagination;
using MediatR;

namespace Adecco.Pokemon.Application.Queries.Pokemon.GetAll
{
    /// <summary>
    /// Get all pokemons query.
    /// </summary>
    public class GetPokemonsQuery : PagingParameters, IRequest<PaginatedItems<PokemonViewModel>>
    {
    }
}

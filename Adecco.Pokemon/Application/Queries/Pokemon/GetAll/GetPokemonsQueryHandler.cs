using Adecco.Pokemon.Application.Models.ViewModels;
using Adecco.Pokemon.Application.Services.Contracts;
using Adecco.Pokemon.BuildingBlocks.Infrastructure.Pagination;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adecco.Pokemon.Application.Queries.Pokemon.GetAll
{
    /// <summary>
    /// Handler for <see cref="GetPokemonsQuery"/>.
    /// </summary>
    public class GetPokemonsQueryHandler : IRequestHandler<GetPokemonsQuery, PaginatedItems<PokemonViewModel>>
    {
        private readonly IPokemonApiService _pokemonApiService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pokemonApiService">Pokemons API service.</param>
        public GetPokemonsQueryHandler(IPokemonApiService pokemonApiService)
        {
            _pokemonApiService = pokemonApiService ?? throw new ArgumentNullException(nameof(pokemonApiService));
        }

        /// <inheritdoc/>
        public async Task<PaginatedItems<PokemonViewModel>> Handle(GetPokemonsQuery request, CancellationToken cancellationToken)
        {
            var apiResult = await _pokemonApiService.GetPokemonsAsync(request.PageNumber, request.PageSize);

            return new PaginatedItems<PokemonViewModel>(request.PageNumber, request.PageSize, apiResult.Count, apiResult.Results);
        }
    }
}

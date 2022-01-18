using Adecco.Pokemon.Application.Models.ViewModels;
using Adecco.Pokemon.Application.Services.Contracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adecco.Pokemon.Application.Queries.Pokemon.GetByName
{
    /// <summary>
    /// Handler for <see cref="GetPokemonByNameQuery"/>.
    /// </summary>
    public class GetPokemonByNameQueryHandler : IRequestHandler<GetPokemonByNameQuery, PokemonDetailedViewModel>
    {
        private readonly IPokemonApiService _pokemonApiService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pokemonApiService">Pokemon API service.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public GetPokemonByNameQueryHandler(IPokemonApiService pokemonApiService)
        {
            _pokemonApiService = pokemonApiService ?? throw new ArgumentNullException(nameof(pokemonApiService));
        }

        /// <inheritdoc/>
        public async Task<PokemonDetailedViewModel> Handle(GetPokemonByNameQuery request, CancellationToken cancellationToken)
        {
            var pokemonDetails = await _pokemonApiService.GetPokemonByNameAsync(request.Name);

            return pokemonDetails;
        }
    }
}

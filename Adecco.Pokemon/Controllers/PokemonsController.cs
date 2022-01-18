using Adecco.Pokemon.Application.Models.ViewModels;
using Adecco.Pokemon.Application.Queries.Pokemon.GetAll;
using Adecco.Pokemon.Application.Queries.Pokemon.GetByName;
using Adecco.Pokemon.BuildingBlocks.Infrastructure.Pagination;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Adecco.Pokemon.Controllers
{
    /// <summary>
    /// Pokemons controller.
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class PokemonsController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediator">Mediator.</param>
        public PokemonsController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        /// <summary>
        /// Action to get pokemons.
        /// </summary>
        /// <param name="query">Pokemons query.</param>
        /// <returns>Paginated collection of pokemons.</returns>
        /// <response code="200">Returned if pokemons were returned.</response>
        /// <response code="400">Returned if request for the resource contains bad syntax or cannot be processed for some other reason.</response>
        /// <response code="500">Returned if some internal server error occurred.</response>
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(typeof(PaginatedItems<PokemonViewModel>), (int)HttpStatusCode.OK)]
        //[ProducesResponseType(typeof(ApiClientErrorResponse), (int)HttpStatusCode.BadRequest)]
        //[ProducesResponseType(typeof(ApiServerErrorResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPokemonsAsync(
            [FromQuery] GetPokemonsQuery query)
        {
            var pokemons = await _mediator.Send(query);

            return Ok(pokemons);
        }

        /// <summary>
        /// Action to get pokemon by name.
        /// </summary>
        /// <param name="query">Pokemon query.</param>
        /// <returns>Pokemon details.</returns>
        /// <response code="200">Returned if pokemon was returned.</response>
        /// <response code="400">Returned if request for the resource contains bad syntax or cannot be processed for some other reason.</response>
        /// <response code="500">Returned if some internal server error occurred.</response>
        [HttpGet("{name}")]        
        [MapToApiVersion("1.0")]
        [ProducesResponseType(typeof(PokemonDetailedViewModel), (int)HttpStatusCode.OK)]
        //[ProducesResponseType(typeof(ApiClientErrorResponse), (int)HttpStatusCode.BadRequest)]
        //[ProducesResponseType(typeof(ApiServerErrorResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPokemonByNameAsync(
            [FromQuery] GetPokemonByNameQuery query)
        {
            var pokemon = await _mediator.Send(query);

            return Ok(pokemon);
        }
    }
}

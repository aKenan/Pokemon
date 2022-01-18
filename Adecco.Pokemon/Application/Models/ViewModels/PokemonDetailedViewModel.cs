using Adecco.Pokemon.Application.Models.Base;
using Adecco.Pokemon.Application.Models.Pokemon;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Adecco.Pokemon.Application.Models.ViewModels
{
    /// <summary>
    /// Pokémon are the creatures that inhabit the world of the Pokémon games.
    /// They can be caught using Pokéballs and trained by battling with other Pokémon.
    /// Each Pokémon belongs to a specific species but may take on a variant which
    /// makes it differ from other Pokémon of the same species, such as base stats,
    /// available abilities and typings.
    /// </summary>
    public class PokemonDetailedViewModel : BaseNamedModel
    {
        /// <summary>
        /// The identifier for this resource
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The base experience gained for defeating this Pokémon.
        /// </summary>
        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }

        /// <summary>
        /// The height of this Pokémon in decimetres.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Set for exactly one Pokémon used as the default for each species.
        /// </summary>
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Order for sorting. Almost national order, except families
        /// are grouped together.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// The weight of this Pokémon in hectograms.
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// A list of abilities this Pokémon could potentially have.
        /// </summary>
        public List<PokemonAbility> Abilities { get; set; }

        /// <summary>
        /// A list of moves along with learn methods and level
        /// details pertaining to specific version groups.
        /// </summary>
        public List<PokemonMove> Moves { get; set; }

        /// <summary>
        /// A list of details showing types this Pokémon has.
        /// </summary>
        public List<PokemonType> Types { get; set; }

        ///// <summary>
        ///// A list of forms this Pokémon can take on.
        ///// </summary>
        //public List<NamedApiResource<PokemonForm>> Forms { get; set; }

        /// <summary>
        /// A list of game indices relevent to Pokémon item by generation.
        /// </summary>
        [JsonProperty("game_indices")]
        public List<VersionGameIndex> GameIndicies { get; set; }

        /// <summary>
        /// A list of items this Pokémon may be holding when encountered.
        /// </summary>
        [JsonProperty("held_items")]
        public List<PokemonHeldItem> HeldItems { get; set; }

        ///// <summary>
        ///// A link to a list of location areas, as well as encounter
        ///// details pertaining to specific versions.
        ///// </summary>
        //[JsonProperty("location_area_encounters")]
        //public string LocationAreaEncounters { get; set; }



        ///// <summary>
        ///// Type data in previous generations for this Pokemon.
        ///// </summary>
        //[JsonProperty("past_types")]
        //public List<PokemonPastTypes> PastTypes { get; set; }

        ///// <summary>
        ///// A set of sprites used to depict this Pokémon in the game.
        ///// </summary>
        //public PokemonSprites Sprites { get; set; }

        ///// <summary>
        ///// The species this Pokémon belongs to.
        ///// </summary>
        //public NamedApiResource<PokemonSpecies> Species { get; set; }

        ///// <summary>
        ///// A list of base stat values for this Pokémon.
        ///// </summary>
        //public List<PokemonStat> Stats { get; set; }


    }

}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Adecco.Pokemon.Application.Models.Pokemon
{
    /// <summary>
    /// Pokemon ability.
    /// </summary>
    public class PokemonAbility
    {
        /// <summary>
        /// Whether or not this is a hidden ability.
        /// </summary>
        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        /// <summary>
        /// The slot this ability occupies in this Pokémon species.
        /// </summary>
        public int Slot { get; set; }

        /// <summary>
        /// The ability the Pokémon may have.
        /// </summary>
        public Ability Ability { get; set; }
    }
}

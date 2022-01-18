using Newtonsoft.Json;

namespace Adecco.Pokemon.Application.Models.Pokemon
{
    /// <summary>
    /// Version game index.
    /// </summary>
    public class VersionGameIndex
    {
        /// <summary>
        /// Game index.
        /// </summary>
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        /// <summary>
        /// Version.
        /// </summary>
        public Version Version { get; set; }
    }
}

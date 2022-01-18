using Newtonsoft.Json;

namespace Adecco.Pokemon.Application.Models.Pokemon
{
    public class VersionGameIndex
    {
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        public Version Version { get; set; }
    }
}

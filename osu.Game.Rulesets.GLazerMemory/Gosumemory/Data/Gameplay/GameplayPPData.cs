using Newtonsoft.Json;

namespace osu.Game.Rulesets.GLazerMemory.Gosumemory.Data.Gameplay
{
    public struct GameplayPPData
    {
        [JsonProperty("current")]
        public int Current;

        [JsonProperty("fc")]
        public int PPIfFc;

        [JsonProperty("maxThisPlay")]
        public int MaxThisPlay;
    }
}

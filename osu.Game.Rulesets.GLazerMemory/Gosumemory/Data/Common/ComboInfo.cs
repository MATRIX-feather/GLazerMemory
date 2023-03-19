using Newtonsoft.Json;

namespace osu.Game.Rulesets.GLazerMemory.Gosumemory.Data.Common
{
    public struct ComboInfo
    {
        [JsonProperty("current")]
        public int CurrentCombo;

        [JsonProperty("max")]
        public int MaxCombo;
    }
}

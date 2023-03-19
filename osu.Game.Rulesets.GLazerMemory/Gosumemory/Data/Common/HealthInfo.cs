using Newtonsoft.Json;

namespace osu.Game.Rulesets.GLazerMemory.Gosumemory.Data.Common
{
    public struct HealthInfo
    {
        [JsonProperty("normal")]
        public float Normal;

        [JsonProperty("smooth")]
        public float Smooth;
    }
}

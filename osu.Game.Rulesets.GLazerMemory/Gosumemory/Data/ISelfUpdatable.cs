using osu.Framework.Graphics.Audio;
using osu.Game.Beatmaps;

namespace osu.Game.Rulesets.GLazerMemory.Gosumemory.Data
{
    public interface ISelfUpdatableFromBeatmap
    {
        public void UpdateBeatmap(WorkingBeatmap working);
    }

    public interface ISelfUpdatableFromAudio
    {
        public void UpdateTrack(DrawableTrack track);
    }
}

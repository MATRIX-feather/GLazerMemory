// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Beatmaps;
using osu.Game.Rulesets.GLazerMemory.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.GLazerMemory.Replays
{
    public class GLazerMemoryAutoGenerator : AutoGenerator<GLazerMemoryReplayFrame>
    {
        public new Beatmap<GLazerMemoryHitObject> Beatmap => (Beatmap<GLazerMemoryHitObject>)base.Beatmap;

        public GLazerMemoryAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
        }

        protected override void GenerateFrames()
        {
            Frames.Add(new GLazerMemoryReplayFrame());

            foreach (GLazerMemoryHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new GLazerMemoryReplayFrame
                {
                    Time = hitObject.StartTime,
                    Position = hitObject.Position,
                    // todo: add required inputs and extra frames.
                });
            }
        }
    }
}

// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.GLazerMemory.Objects;
using osu.Game.Rulesets.GLazerMemory.Objects.Drawables;
using osu.Game.Rulesets.GLazerMemory.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.GLazerMemory.UI
{
    [Cached]
    public partial class DrawableGLazerMemoryRuleset : DrawableRuleset<GLazerMemoryHitObject>
    {
        public DrawableGLazerMemoryRuleset(GLazerMemoryRuleset ruleset, IBeatmap beatmap, IReadOnlyList<Mod> mods = null)
            : base(ruleset, beatmap, mods)
        {
        }

        protected override Playfield CreatePlayfield() => new GLazerMemoryPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new GLazerMemoryFramedReplayInputHandler(replay);

        public override DrawableHitObject<GLazerMemoryHitObject> CreateDrawableRepresentation(GLazerMemoryHitObject h) => new DrawableGLazerMemoryHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new GLazerMemoryInputManager(Ruleset?.RulesetInfo);
    }
}

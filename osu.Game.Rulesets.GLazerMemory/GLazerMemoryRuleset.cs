// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Input.Bindings;
using osu.Game.Beatmaps;
using osu.Game.Graphics;
using osu.Game.Rulesets.Difficulty;
using osu.Game.Rulesets.GLazerMemory.Beatmaps;
using osu.Game.Rulesets.GLazerMemory.Mods;
using osu.Game.Rulesets.GLazerMemory.UI;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.UI;
using osu.Game.Screens.LLin.Plugins.Internal.Gosumemory;
using osuTK;
using osuTK.Graphics;
using GosuCompatInjector = osu.Game.Rulesets.GLazerMemory.Gosumemory.GosuCompatInjector;

namespace osu.Game.Rulesets.GLazerMemory
{
    public partial class GLazerMemoryRuleset : Ruleset
    {
        public override string Description => "Gosumemory, but runs on osu!lazer";

        public override DrawableRuleset CreateDrawableRulesetWith(IBeatmap beatmap, IReadOnlyList<Mod> mods = null) =>
            new DrawableGLazerMemoryRuleset(this, beatmap, mods);

        public override IBeatmapConverter CreateBeatmapConverter(IBeatmap beatmap) =>
            new GLazerMemoryBeatmapConverter(beatmap, this);

        public override DifficultyCalculator CreateDifficultyCalculator(IWorkingBeatmap beatmap) =>
            new GLazerMemoryDifficultyCalculator(RulesetInfo, beatmap);

        public override IEnumerable<Mod> GetModsFor(ModType type)
        {
            switch (type)
            {
                case ModType.Automation:
                    return new[] { new GLazerMemoryModAutoplay() };

                default:
                    return Array.Empty<Mod>();
            }
        }

        public override string ShortName => "glazermemoryruleset";

        public override IEnumerable<KeyBinding> GetDefaultKeyBindings(int variant = 0) => new KeyBinding[]
        {
        };

        public override Drawable CreateIcon() => new Icon(ShortName[0]);

        public partial class Icon : CompositeDrawable
        {
            public Icon(char c)
            {
                RelativeSizeAxes = Axes.Both;

                InternalChildren = new Drawable[]
                {
                    new Circle
                    {
                        Size = new Vector2(20),
                        Colour = Color4.White,
                        Anchor = Anchor.Centre,
                        Origin = Anchor.Centre,
                    },
                    new SpriteText
                    {
                        Anchor = Anchor.Centre,
                        Origin = Anchor.Centre,
                        Text = c.ToString().ToUpper(),
                        Colour = Color4.Black,
                        Font = OsuFont.Default.With(size: 18, weight: FontWeight.Bold)
                    },
                    new GosuCompatInjector()
                };
            }
        }

        // Leave this line intact. It will bake the correct version into the ruleset on each build/release.
        public override string RulesetAPIVersionSupported => CURRENT_RULESET_API_VERSION;
    }
}

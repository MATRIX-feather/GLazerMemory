using System.Collections.Generic;
using osu.Game.Rulesets.Scoring;
using osu.Game.Scoring;

namespace osu.Game.Rulesets.GLazerMemory.Gosumemory.Extensions
{
    public static class ScoreInfoExtension
    {
        public static int GetResultsPerfect(this ScoreInfo scoreInfo)
        {
            return scoreInfo.Statistics.GetValueOrDefault(HitResult.Perfect, 0) + scoreInfo.Statistics.GetValueOrDefault(HitResult.Great, 0);
        }

        public static int GetResultsGreat(this ScoreInfo scoreInfo)
        {
            return scoreInfo.Statistics.GetValueOrDefault(HitResult.Good, 0) + scoreInfo.Statistics.GetValueOrDefault(HitResult.Ok, 0);
        }
    }
}

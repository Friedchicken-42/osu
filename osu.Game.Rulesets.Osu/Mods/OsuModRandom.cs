using System;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Mods;

using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Osu.Objects;
using osu.Game.Rulesets.Osu.UI;
using osuTK;
using System.Linq;
using osu.Framework.Extensions.IEnumerableExtensions;

namespace osu.Game.Rulesets.Osu.Mods
{
    public class OsuModRandom : ModRandom, IApplicableToHitObject
    {
        public override string Description => @"funky mapping";

        private static Random rand = new Random();

        private Vector2 randomVector2()
        {
            return new Vector2((float)(rand.NextDouble() * OsuPlayfield.BASE_SIZE.X), (float)(rand.NextDouble() * OsuPlayfield.BASE_SIZE.Y));
        }

        public void ApplyToHitObject(HitObject hitObject)
        {
            var osuObject = (OsuHitObject)hitObject;
            osuObject.Position = randomVector2();

            // if (!(hitObject is Slider slider)) return;
        }
    }
}

using BannerKings.Managers;
using BannerKings.Managers.Education.Languages;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Languages
{
    //[HarmonyPatch(typeof(EducationManager), "InitHeroEducation")]
    internal class InitHeroEducationPatch
    {
        public static bool Prefix(ref EducationManager __instance, Hero hero, ref Dictionary<Language, float> startingLanguages)
        {
            Language native = __instance.GetNativeLanguage(hero.Culture);
            Dictionary<Language, float> newDict = new Dictionary<Language, float>
            {
                { native, 1f }
            };
            startingLanguages = newDict;
            return true;
        }
    }
}

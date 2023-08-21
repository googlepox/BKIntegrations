using BannerKings.Managers;
using BannerKings.Managers.Education;
using BannerKings.Managers.Education.Languages;
using HarmonyLib;
using System.Collections.Generic;
using System.Reflection;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Languages
{
    [HarmonyPatch(typeof(EducationManager), "CorrectPlayerEducation")]
    internal class CorrectPlayerEducationPatch
    {
        public static bool Prefix(ref EducationManager __instance)
        {
            PropertyInfo property = AccessTools.Property(typeof(EducationManager), "Educations");
            Dictionary<Hero, EducationData> educationDict = (Dictionary<Hero, EducationData>)property.GetValue(__instance);
            educationDict.Remove(Hero.MainHero);
            Dictionary<Language, float> languages = new Dictionary<Language, float>();
            Language key = __instance.GetNativeLanguage(Hero.MainHero.Culture);
            languages.Add(key, 1f);
            educationDict.Add(Hero.MainHero, new EducationData(Hero.MainHero, languages));
            AccessTools.Property(typeof(EducationManager), "Educations").SetValue(__instance, educationDict);
            return false;
        }
    }
}

using BannerKings.Managers.Education.Languages;
using HarmonyLib;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;

namespace BKCEKPatch.Patches.Languages
{
    [HarmonyPatch(typeof(Language), nameof(Language.Initialize))]
    internal class LanguagePatch
    {
        public static void Postfix(ref Language __instance, TextObject name,
          TextObject description,
          List<CultureObject> cultures,
          Dictionary<Language, float> inteligible)
        {
            List<CultureObject> newCultures;
            if (__instance.StringId == "language_battanian")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("battania"),

                };
            }
            else if (__instance.StringId == "language_vlandic")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("vlandia"),
                    BannerKings.Utils.Helpers.GetCulture("rhodok"),

                };
            }
            else if (__instance.StringId == "language_calradian")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("empire"),
                    BannerKings.Utils.Helpers.GetCulture("republic"),
                    BannerKings.Utils.Helpers.GetCulture("ariorum")
                };
            }
            else if (__instance.StringId == "language_sturgian")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("sturgia")
                };
            }
            else if (__instance.StringId == "language_aseran")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("aserai")
                };
            }
            else if (__instance.StringId == "language_khuzait")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("khuzait"),
                    BannerKings.Utils.Helpers.GetCulture("rebkhu")
                };
            }
            else if (__instance.StringId == "language_vakken")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("vakken")
                };
            }
            else if (__instance.StringId == "language_vagiric")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("vagir")
                };
            }
            else if (__instance.StringId == "language_lyrion")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("lyrion")
                };
            }
            else if (__instance.StringId == "language_nordic")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("nordling")
                };
            }
            else if (__instance.StringId == "language_apolssalian")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("apolssalian")
                };
            }
            else if (__instance.StringId == "language_palaic")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("paleician")
                };
            }
            else
            {
                newCultures = new List<CultureObject>() { };
            }
            AccessTools.Property(typeof(Language), "Cultures").SetValue(__instance, newCultures);
        }
    }
}

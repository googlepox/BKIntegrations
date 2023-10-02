using BannerKings;
using BannerKings.Managers;
using BannerKings.Managers.Education.Languages;
using BKMergedMapPatch.Languages;
using HarmonyLib;
using System;
using TaleWorlds.CampaignSystem;

namespace BKMergedMapPatch.Patches.Languages
{
    [HarmonyPatch(typeof(EducationManager), "GetNativeLanguage", new Type[] { typeof(CultureObject) })]
    internal class GetNativeLanguagePatch
    {
        public static void Postfix(ref Language __result, CultureObject culture)
        {
            if (culture.StringId == "empire" || culture.StringId == "republic" || culture.StringId == "ariorum")
            {
                __result = DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Calradian;
            }
            else if (culture.StringId == "khuzait" || culture.StringId == "rebkhu")
            {
                __result = DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Khuzait;
            }
            else if (culture.StringId == "aserai")
            {
                __result = DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Aseran;
            }
            else if (culture.StringId == "battania")
            {
                __result = DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Battanian;
            }
            else if (culture.StringId == "vlandia" || culture.StringId == "rhodok")
            {
                __result = DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Vlandic;
            }
            else if (culture.StringId == "vakken")
            {
                __result = DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Vakken;
            }
            else if (culture.StringId == "sturgia")
            {
                __result = DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Sturgian;
            }
            else if (culture.StringId == "vagir")
            {
                __result = BKCEKPatch.Languages.DefaultLanguageTypesAddOn.Instance.Vagiric;
            }
            else if (culture.StringId == "nordling")
            {
                __result = BKCEKPatch.Languages.DefaultLanguageTypesAddOn.Instance.Nordic;
            }
            else if (culture.StringId == "lyrion")
            {
                __result = BKCEKPatch.Languages.DefaultLanguageTypesAddOn.Instance.Lyrion;
            }
            else if (culture.StringId == "apolssalian" || culture.StringId == "pelasgia" || culture.StringId == "dendra" || culture.StringId == "sherden" || culture.StringId == "amazon")
            {
                __result = BKCEKPatch.Languages.DefaultLanguageTypesAddOn.Instance.Apolssalian;
            }
            else if (culture.StringId == "paleician")
            {
                __result = BKCEKPatch.Languages.DefaultLanguageTypesAddOn.Instance.Palaic;
            }
            else if (culture.StringId == "tetsojin")
            {
                __result = DefaultLanguagesMMAddon.Instance.Tetso;
            }
            else if (culture.StringId == "huaxia")
            {
                __result = DefaultLanguagesMMAddon.Instance.Huaxian;
            }
            else
            {
                __result = DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Calradian;
            }
        }
    }
}

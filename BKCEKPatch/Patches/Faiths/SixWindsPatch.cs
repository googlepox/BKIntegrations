using BannerKings.Managers.Institutions.Religions.Faiths.Eastern;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths
{
    [HarmonyPatch(typeof(SixWinds), "IsCultureNaturalFaith")]
    internal class SixWindsPatch
    {
        public static void Postfix(ref bool __result, CultureObject culture)
        {
            if (culture.StringId == "khuzait" || culture.StringId == "rebkhu" || culture.StringId == "tetsojin" || culture.StringId == "huaxia")
            {
                __result = true;
            }
            else
            {
                __result = false;
            }
        }
    }
}

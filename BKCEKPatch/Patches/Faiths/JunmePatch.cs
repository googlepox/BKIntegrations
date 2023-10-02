using BannerKings.CulturesExpanded.Religions;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths
{
    [HarmonyPatch(typeof(Junme), nameof(Junme.IsCultureNaturalFaith))]
    internal class JunmePatch
    {
        public static void Postfix(ref bool __result, CultureObject culture)
        {
            if (culture.StringId == "nordling" || culture.StringId == "sturgia" || culture.StringId == "vagir" || culture.StringId == "nord")
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

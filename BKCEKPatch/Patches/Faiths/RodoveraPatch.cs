using BannerKings.CulturesExpanded.Religions;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths
{
    [HarmonyPatch(typeof(Rodovera), nameof(Rodovera.IsCultureNaturalFaith))]
    internal class RodoveraPatch
    {
        public static void Postfix(ref bool __result, CultureObject culture)
        {
            if (culture.StringId == "sturgia" || culture.StringId == "vagir")
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

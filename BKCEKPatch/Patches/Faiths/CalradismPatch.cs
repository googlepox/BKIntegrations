using BannerKings.CulturesExpanded.Religions;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths
{
    [HarmonyPatch(typeof(Calradism), nameof(Calradism.IsCultureNaturalFaith))]
    internal class CalradismPatch
    {
        public static void Postfix(ref bool __result, CultureObject culture)
        {
            if (culture.StringId == "ariorum" || culture.StringId == "republic" || culture.StringId == "empire")
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

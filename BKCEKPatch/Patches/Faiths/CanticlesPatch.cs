using BannerKings.Managers.Institutions.Religions.Faiths.Vlandia;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths
{
    [HarmonyPatch(typeof(CanticlesFaith), "IsCultureNaturalFaith")]
    internal class CanticlesPatch
    {
        public static void Postfix(ref bool __result, CultureObject culture)
        {
            if (culture.StringId == "vlandia" || culture.StringId == "rhodok")
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

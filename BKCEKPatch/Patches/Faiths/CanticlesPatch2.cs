using BannerKings.Managers.Institutions.Religions.Faiths.Vlandia;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths
{
    [HarmonyPatch(typeof(CanticlesFaith), "IsCultureNaturalFaith")]
    internal class CanticlesPatch2
    {
        public static void Postfix(ref bool __result, CultureObject culture)
        {
            if (culture.StringId == "vlandia" || culture.StringId == "ariorum" || culture.StringId == "republic" || culture.StringId == "empire")
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

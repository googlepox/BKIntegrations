using BannerKings.Managers.Institutions.Religions.Faiths.Vlandia;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths
{
    [HarmonyPatch(typeof(CanticlesFaith), "IsHeroNaturalFaith")]
    internal class CanticlesPatch
    {
        public static void Postfix(ref bool __result, Hero hero)
        {
            if ((hero.Culture.StringId == "vlandia"))
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

using BannerKings.Managers.Institutions.Religions.Faiths.Vlandia;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;

namespace BKCEKPatch.Patches.Faiths
{
    [HarmonyPatch(typeof(CanticlesFaith), "IsHeroNaturalFaith")]
    internal class CanticlesPatch
    {
        public static void Postfix(ref bool __result, Hero hero)
        {
            if ((hero.Culture.StringId == "vlandia" && MBRandom.RandomFloat < 0.25f))
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

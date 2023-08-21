using BannerKings.Managers.Institutions.Religions.Faiths.Battania;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths
{
    [HarmonyPatch(typeof(AmraFaith), "IsCultureNaturalFaith")]
    internal class AmraPatch
    {
        public static void Postfix(ref bool __result, CultureObject culture)
        {
            if (culture.StringId == "battania" || culture.StringId == "vagir" || culture.StringId == "paleician")
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

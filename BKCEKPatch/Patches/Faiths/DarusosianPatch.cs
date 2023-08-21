using BannerKings.Managers.Institutions.Religions.Faiths.Empire;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths
{
    [HarmonyPatch(typeof(DarusosianFaith), "IsCultureNaturalFaith")]
    internal class DarusosianPatch
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

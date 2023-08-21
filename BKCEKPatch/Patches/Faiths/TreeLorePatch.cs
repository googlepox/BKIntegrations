using BannerKings.Managers.Institutions.Religions.Faiths.Northern;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths
{
    [HarmonyPatch(typeof(TreeloreFaith), "IsCultureNaturalFaith")]
    internal class TreeLorePatch
    {
        public static void Postfix(ref bool __result, CultureObject culture)
        {
            if (culture.StringId == "sturgia" || culture.StringId == "nordling" || culture.StringId == "paleician")
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

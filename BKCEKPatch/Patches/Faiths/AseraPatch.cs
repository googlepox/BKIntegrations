using BannerKings.Managers.Institutions.Religions.Faiths.Asera;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths
{
    [HarmonyPatch(typeof(AseraFaith), "IsCultureNaturalFaith")]
    internal class AseraPatch
    {
        public static void Postfix(ref bool __result, CultureObject culture)
        {
            if (culture.StringId == "aserai" || culture.StringId == "apolssalian" || culture.StringId == "lyrion" || culture.StringId == "pelasgia" || culture.StringId == "dendra" || culture.StringId == "sherden" || culture.StringId == "amazon")
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

using BannerKings.Managers.Titles.Governments;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Governments
{
    [HarmonyPatch(typeof(DefaultGovernments), "GetKingdomIdealSuccession")]
    internal class GetKingdomIdealSuccessionPatch1
    {
        public static void Postfix(Kingdom kingdom, ref Government __result)
        {
            string id = kingdom.StringId;
            if (id.Contains("huaxia"))
            {
                __result = DefaultGovernments.Instance.Imperial;
            }
            else if (id.Contains("lyrion") || id.Contains("paleician") || id.Contains("tetsojin") || id == "dendra_1" || id == "sherden_1")
            {
                __result = DefaultGovernments.Instance.Feudal;
            }
            else if (id.Contains("ariorum") || id.Contains("apolssaly") || id == "pelasgia_1")
            {
                __result = DefaultGovernments.Instance.Republic;
            }
        }
    }
}

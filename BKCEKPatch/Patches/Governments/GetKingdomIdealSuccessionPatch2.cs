using BannerKings.Managers.Titles.Governments;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Governments
{
    [HarmonyPatch(typeof(DefaultSuccessions), "GetKingdomIdealSuccession")]
    internal class GetKingdomIdealSuccessionPatch2
    {
        public static void Postfix(Kingdom kingdom, Government government, ref Succession __result)
        {
            string id = kingdom.StringId;

            if (government == DefaultGovernments.Instance.Feudal)
            {
                if (id == "royalist_vlandia" || id == "dendra_1")
                {
                    __result = DefaultSuccessions.Instance.Hereditary;
                }
                else if (id == "paleician" || id == "tetsojin" || id == "sherden_1")
                {
                    __result = DefaultSuccessions.Instance.TheocraticElective;
                }
            }
            else if (id == "vagir")
            {
                __result = DefaultSuccessions.Instance.BattanianElective;
            }
        }
    }
}

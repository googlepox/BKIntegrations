using HarmonyLib;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.Core;

namespace BKCEKPatch.Patches.Fixes
{
    [HarmonyPatch(typeof(TradeSkillCampaingBehavior), "ProcessSales")]
    internal class ProcessSalesFix
    {
        public static void Postfix(ref TradeSkillCampaingBehavior __instance, ref int __result, ItemRosterElement itemRosterElement, int totalPrice)
        {
            if (itemRosterElement.EquipmentElement.ItemModifier != null)
            {
                __result = (int)(AccessTools.Method(typeof(TradeSkillCampaingBehavior), "RecordSales").Invoke(__instance, new object[] { itemRosterElement, totalPrice }));
            }
        }
    }
}

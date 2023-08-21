using HarmonyLib;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.Core;

namespace BKCEKPatch.Patches.Fixes
{
    [HarmonyPatch(typeof(TradeSkillCampaingBehavior), "ProcessPurchases")]
    internal class ProcessPurchasesFix
    {
        public static void Postfix(ref TradeSkillCampaingBehavior __instance, ItemRosterElement itemRosterElement, int totalPrice)
        {
            if (itemRosterElement.EquipmentElement.ItemModifier != null)
            {
                AccessTools.Method(typeof(TradeSkillCampaingBehavior), "RecordPurchases").Invoke(__instance, new object[] { itemRosterElement, totalPrice });
            }
        }
    }
}

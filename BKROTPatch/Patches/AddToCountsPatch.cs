using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.Conversation;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.Core;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(ItemRosterElement), "set_Amount")]
    internal class AddToCountsPatch
    {
        public static void Prefix(ItemRosterElement __instance, ref int value)
        {
            if (value < 0)
            {
                value = 0;
            }
        }

        /*public static Exception Finalizer(Exception __exception, ItemRoster __instance, EquipmentElement rosterElement, int number)
        {
            if (__exception != null && __exception is MBUnderFlowException)
            {
                return null;
            }
            return __exception;
        } */
    }
}

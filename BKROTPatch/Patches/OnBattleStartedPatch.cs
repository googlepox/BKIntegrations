using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.Party;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(DefaultLogsCampaignBehavior), "OnBattleStarted")]
    internal class OnBattleStartedPatch
    {
        public static bool Prefix(DefaultLogsCampaignBehavior __instance, PartyBase attackerParty, PartyBase defenderParty, object subject, bool showNotification)
        {
            if (showNotification && (defenderParty == null || attackerParty == null))
            {
                return false;
            }
            return true;
        }
    }
}

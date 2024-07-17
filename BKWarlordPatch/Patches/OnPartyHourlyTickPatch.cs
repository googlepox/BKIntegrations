using HarmonyLib;
using Warlord.WarbandCampaignBehaviors;

namespace BKWarlordPatch.Patches
{
    [HarmonyPatch(typeof(ScrollCampaignBehavior), "OnPartyHourlyTick")]
    internal class OnPartyHourlyTickPatch
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}

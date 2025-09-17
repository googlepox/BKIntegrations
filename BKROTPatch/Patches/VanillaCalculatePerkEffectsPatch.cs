using BannerKings.Models.Vanilla;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;

namespace BKROTPatch.Patches
{
    //[HarmonyPatch(typeof(BKPartyConsumptionModel), "VanillaCalculatePerkEffects")]
    internal class VanillaCalculatePerkEffectsPatch
    {
        public static bool Prefix(BKPartyConsumptionModel __instance, MobileParty party, ref ExplainedNumber result)
        {
            if (party == null)
            {
                return false;
            }
            for (int i = 0; i < party.MemberRoster.Count; i++)
            {
                if (party.MemberRoster.GetCharacterAtIndex(i) == null || party.MemberRoster.GetCharacterAtIndex(i).Culture == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

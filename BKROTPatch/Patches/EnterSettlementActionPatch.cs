using BannerKings.Managers.Court;
using BannerKings.Managers.Populations;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Settlements;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(EnterSettlementAction), "ApplyForCharacterOnly")]
    internal class EnterSettlementActionPatch
    {
        public static Exception Finalizer(Exception __exception, CouncilData __instance, Hero hero, Settlement settlement)
        {
            if (__exception != null && __exception is NullReferenceException)
            {
                return null;
            }
            return __exception;
        }
    }
}

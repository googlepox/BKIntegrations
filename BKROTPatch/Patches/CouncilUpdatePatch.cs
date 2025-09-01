using BannerKings.Managers.Court;
using BannerKings.Managers.Populations;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.Roster;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(CouncilData), "Update")]
    internal class CouncilUpdatePatch
    {
        public static Exception Finalizer(Exception __exception, CouncilData __instance, PopulationData data)
        {
            if (__exception != null && __exception is NullReferenceException)
            {
                return null;
            }
            return __exception;
        }
    }
}

using BannerKings.Behaviours;
using BannerKings.Behaviours.Diplomacy.Wars;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(CasusBelli), "IsAdequate")]
    internal class IsAdequatePatch
    {
        public static bool Prefix(ref CasusBelli __instance, IFaction faction1, IFaction faction2, CasusBelli casusBelli)
        {
            if (casusBelli == null || casusBelli.Title == null || casusBelli.Fief == null || casusBelli.Claimant == null )
            {
                return false;
            }
            return true;
        }
    }
}

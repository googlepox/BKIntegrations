using BannerKings.Managers;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(TitleManager), "ShowContract")]
    internal class ShowContractPatch
    {
        public static bool Prefix(TitleManager __instance, Hero lord, string buttonString)
        { 
            if (lord == null || lord.Clan == null || lord.Clan.Kingdom == null)
            {
                return false;
            }
            return true;
        }
    }
}

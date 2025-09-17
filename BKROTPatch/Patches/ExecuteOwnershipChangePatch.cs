using BannerKings.Managers;
using BannerKings.Managers.Titles;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(TitleManager), "ExecuteOwnershipChange")]
    internal class ExecuteOwnershipChangePatch
    {
        public static bool Prefix(TitleManager __instance, Hero oldOwner, Hero newOwner, FeudalTitle title, bool deJure)
        {
            if (deJure)
            {
                Dictionary<Hero, List<FeudalTitle>> deJureCache = (Dictionary<Hero, List<FeudalTitle>>) AccessTools.Property(typeof(TitleManager), "DeJuresCache").GetValue(__instance);
                if (!deJureCache.ContainsKey(oldOwner))
                {
                    return false;
                }
                return true;
            }
            return true;
        }
    }
}

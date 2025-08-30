using BannerKings.Behaviours.Feasts;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using Warlord.WarbandCampaignBehaviors;

namespace BKWarlordPatch.Patches
{
    [HarmonyPatch(typeof(BKFeastBehavior), MethodType.Constructor)]
    internal class BKFeastBehaviorPatch
    {
        public static void Postfix(ref BKFeastBehavior __instance)
        {
            BKWarlordPatch.feastBehavior = __instance;
        }
    }
}

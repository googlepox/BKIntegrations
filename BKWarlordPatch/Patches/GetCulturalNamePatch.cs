using HarmonyLib;
using System;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Engine;
using Warlord.WarbandCampaignBehaviors;
using BannerKings.Managers.Court;
using TaleWorlds.Localization;

namespace BKWarlordPatch.Patches
{
    [HarmonyPatch(typeof(CouncilMember), "GetCulturalName")]
    internal class GetCulturalNamePatch
    {
        public static void Postfix(ref CouncilMember __instance, ref TextObject __result)
        {
            if (__result == null)
            {
                __result = new TextObject("NULL");
            }
        }
    }
}

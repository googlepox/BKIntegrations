using BannerKings.Behaviours.Feasts;
using BannerKings.Behaviours.Marriage;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Engine;
using Warlord.WarbandCampaignBehaviors;

namespace BKWarlordPatch.Patches
{
    [HarmonyPatch(typeof(BKFeastBehavior), "LaunchFeast")]
    internal class LaunchFeastPatch
    {
        public static void Postfix(ref BKFeastBehavior __instance, Town town, List<Clan> guests, MarriageContract marriage = null, BannerKings.Behaviours.Feasts.Feast.FeastType type = BannerKings.Behaviours.Feasts.Feast.FeastType.Normal)
        {
            MBDebug.ConsolePrint("launching Warlord feast after BK feast was started", TaleWorlds.Library.Debug.DebugColor.DarkRed);
            Warlord.WarbandCampaignBehaviors.Feast feast = new Warlord.WarbandCampaignBehaviors.Feast(town.OwnerClan.Leader, town.Settlement, 7);
            AccessTools.Method(typeof(FeastCampaignBehavior), "InviteHeroes").Invoke(__instance, new object[] { town.OwnerClan.Kingdom, feast });
        }
    }
}

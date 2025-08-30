using BannerKings.Behaviours.Feasts;
using BannerKings.Behaviours.Marriage;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Engine;
using TaleWorlds.MountAndBlade;
using Warlord.WarbandCampaignBehaviors;

namespace BKWarlordPatch.Patches
{
    [HarmonyPatch(typeof(FeastCampaignBehavior), "InviteHeroes")]
    internal class CheckAndStartFeastPatch
    {
        public static void Postfix(ref FeastCampaignBehavior __instance, Kingdom k, Warlord.WarbandCampaignBehaviors.Feast f)
        {
            if (f.HostSettlement.Town != null)
            {
                List<Clan> clans = new List<Clan>();
                foreach (Hero hero in f.AttendeeList)
                {
                    if (!clans.Contains(hero.Clan))
                    {
                        clans.Add(hero.Clan);
                    }
                }
                if (!BKWarlordPatch.feastBehavior.IsFeastTown(f.HostSettlement))
                {
                    MBDebug.ConsolePrint("launching BK feast after Warlord feast was started", TaleWorlds.Library.Debug.DebugColor.DarkRed);
                    BKWarlordPatch.feastBehavior.LaunchFeast(f.HostSettlement.Town, clans, null, BannerKings.Behaviours.Feasts.Feast.FeastType.Normal);
                }
            }
        }
    }
}

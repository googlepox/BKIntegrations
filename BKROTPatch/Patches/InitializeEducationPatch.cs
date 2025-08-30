using BannerKings.Behaviours;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(BKEducationBehavior), "InitializeEducation")]
    internal class InitializeEducationPatch
    {
        public static bool Prefix(ref BKEducationBehavior __instance, Hero hero, bool addExtraLanguages)
        {
            if (hero == null || hero.Clan == null || hero.Clan.Leader == null)
            {
                return false;
            }
            return true;
        }
    }
}

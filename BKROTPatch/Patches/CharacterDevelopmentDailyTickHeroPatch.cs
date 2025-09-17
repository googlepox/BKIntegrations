using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;

namespace BKROTPatch.Patches
{
    //[HarmonyPatch(typeof(CharacterDevelopmentCampaignBehavior), "DailyTickHero")]
    internal class CharacterDevelopmentDailyTickHeroPatch
    {
        public static bool Prefix(CharacterDevelopmentCampaignBehavior __instance, Hero hero)
        {
            if (hero == null)
            {
                return false;
            }
            return true;
        }
    }
}

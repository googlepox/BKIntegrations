using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(HeroCreator), "CreateSpecialHero")]
    internal class CreateSpecialHeroPatch
    {
        public static bool Prefix(CharacterObject template, Settlement bornSettlement, Clan faction, Clan supporterOfClan, int age)
        {
           if (template == null)
           {
                return false;
           }
            return true;
        }
    }
}

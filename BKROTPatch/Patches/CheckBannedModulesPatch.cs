using HarmonyLib;
using ROT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(ROT.SubModule), "CheckBannedModules")]
    internal class CheckBannedModulesPatch
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}

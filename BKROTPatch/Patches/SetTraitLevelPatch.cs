using BannerKings;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.CharacterDevelopment;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(Hero), "SetTraitLevel")]
    internal class SetTraitLevelPatch
    {
        public static bool Prefix(ref Hero __instance, TraitObject trait, int value)
        {
            if (trait == null)
            {
                return false;
            }
            return true;
        }
    }
}

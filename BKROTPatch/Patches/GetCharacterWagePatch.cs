using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;

namespace BKROTPatch.Patches
{
    internal class GetCharacterWagePatch
    {
        public static bool Prefix(object __instance, CharacterObject character)
        {
            if (character == null || character.Culture == null)
            {
                return false;
            }
            return true;
        }
    }
}

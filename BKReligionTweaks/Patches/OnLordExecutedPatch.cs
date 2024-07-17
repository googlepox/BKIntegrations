using HarmonyLib;
using TaleWorlds.CampaignSystem.CharacterDevelopment;

namespace BKReligionTweaks.Patches
{
    [HarmonyPatch(typeof(TraitLevelingHelper), "OnLordExecuted")]
    internal class OnLordExecutedPatch
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}

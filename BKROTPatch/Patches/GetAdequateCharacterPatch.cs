using BannerKings.Managers.Goals.Decisions;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(RecruitCompanionDecision), "GetAdequateCharacter")]
    internal class GetAdequateCharacterPatch
    {
        public static void Postfix(RecruitCompanionDecision __instance, ref List<CharacterObject> __result, object type)
        {
            List<CharacterObject> newList = __result;
            foreach (CharacterObject obj in __result)
            {
                if (obj.StringId.Contains("ROT_")) {
                    newList.Remove(obj);
                }
            }

            __result = newList;
        }
    }
}

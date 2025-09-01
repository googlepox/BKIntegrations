using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Conversation;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(ConversationSentence), "RunClickableCondition")]
    internal class RunClickableConditionPatch
    {
        public static Exception Finalizer(Exception __exception, ConversationSentence __instance)
        {
            if (__exception != null && __exception is ArgumentNullException)
            {
                return null;
            }
            return __exception;
        }
    }
}

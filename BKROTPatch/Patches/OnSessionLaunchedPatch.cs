using HarmonyLib;
using Helpers;
using ROT.CampaignBehaviors;
using SandBox.CampaignBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.Conversation;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace BKROTPatch.Patches
{
    internal class OnSessionLaunchedPatch
    {
        public static Exception Finalizer(Exception __exception, object __instance, CampaignGameStarter campaignGameStarter)
        {
            if (__exception != null && __exception is ArgumentNullException)
            {
                return null;
            }
            return __exception;
        }
    }
}

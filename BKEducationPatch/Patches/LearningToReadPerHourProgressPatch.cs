using BannerKings;
using BannerKings.Managers.Skills;
using HarmonyLib;
using LT_Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace BKEducationPatch.Patches
{
    [HarmonyPatch(typeof(LT_EducationBehaviour), "LearningToReadPerHourProgress")]
    internal class LearningToReadPerHourProgressPatch
    {
        public static void Postfix(LT_EducationBehaviour __instance, ref float __result)
        {
            Hero.MainHero.AddSkillXp(BKSkills.Instance.Scholarship, 20f);
            InformationManager.DisplayMessage(new InformationMessage(
                            new TextObject("{=ArMJ9nUV}You have improved your {SKILL} skill during your current action.")
                                .SetTextVariable("SKILL", BKSkills.Instance.Scholarship.Name)
                                .ToString()));
        }
    }
}

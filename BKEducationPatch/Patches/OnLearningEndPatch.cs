using BannerKings;
using BannerKings.Managers.Education;
using BannerKings.Managers.Skills;
using HarmonyLib;
using LT_Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;

namespace BKEducationPatch.Patches
{
    [HarmonyPatch(typeof(LT_EducationBehaviour), "OnLearningEnd")]
    internal class OnLearningEndPatch
    {
        public static void Postfix(LT_EducationBehaviour __instance)
        {
            EducationData educationData = BannerKingsConfig.Instance.EducationManager.GetHeroEducation(Hero.MainHero);
            educationData.AddPerk(BKPerks.Instance.ScholarshipLiterate);
        }
    }
}

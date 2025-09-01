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
    [HarmonyPatch(typeof(LT_EducationBehaviour), "HeroCanRead")]
    internal class HeroCanReadPatch
    {
        public static void Postfix(LT_EducationBehaviour __instance, float __result, Hero hero)
        {
            EducationData heroData = BannerKingsConfig.Instance.EducationManager.GetHeroEducation(hero);
            bool hasPerk = heroData.HasPerk(BKPerks.Instance.ScholarshipLiterate);
            if (hasPerk)
            {
                __result = 100f;
            }
        }
    }
}

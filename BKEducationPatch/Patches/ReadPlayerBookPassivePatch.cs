using BannerKings;
using BannerKings.Managers.Education;
using BannerKings.Managers.Education.Books;
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
    [HarmonyPatch(typeof(LT_EducationBehaviour), "ReadPlayerBookPassive")]
    internal class ReadPlayerBookPassivePatch
    {
        public static bool Prefix(LT_EducationBehaviour __instance)
        {
            EducationData heroData = BannerKingsConfig.Instance.EducationManager.GetHeroEducation(Hero.MainHero);
            bool isLiterate = heroData.HasPerk(BKPerks.Instance.ScholarshipLiterate);
            if (isLiterate)
            {
                BookType currentBook = heroData.CurrentBook;
                float currentBookProgress = heroData.CurrentBookProgress;
                bool isNotFinished = currentBookProgress < 1f;
                if (!isNotFinished)
                {
                    bool isPrisoner = Hero.MainHero.IsPrisoner;
                    if (!isPrisoner)
                    {
                        heroData.GainBookReading(currentBook, heroData.CurrentBookReadingRate.ResultNumber);
                    }
                }
            }
            return false;
        }
    }
}

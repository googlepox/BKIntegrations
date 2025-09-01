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
    [HarmonyPatch(typeof(LT_EducationBehaviour), "MainHeroFinishReading")]
    internal class MainHeroFinishReadingPatch
    {
        public static void Postfix(LT_EducationBehaviour __instance)
        {
            EducationData heroData = BannerKingsConfig.Instance.EducationManager.GetHeroEducation(Hero.MainHero);
            BookType book = heroData.CurrentBook;
            book.FinishBook(Hero.MainHero);
        }
    }
}

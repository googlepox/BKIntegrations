using BannerKings.Managers.Education;
using BannerKings.Managers.Education.Books;
using BannerKings.Models.BKModels;
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
    [HarmonyPatch(typeof(EducationData), "GainBookReading")]
    internal class GainBookReadingPatch
    {
        public static void Postfix(EducationData __instance, BookType book, float rate)
        {
            int bookInProgress = (int)AccessTools.Field(typeof(LT_EducationBehaviour), "_bookInProgress").GetValue(LT_EducationBehaviour.Instance);
            float[] bookProgress = (float[])AccessTools.Field(typeof(LT_EducationBehaviour), "_bookProgress").GetValue(LT_EducationBehaviour.Instance);
            bool flag2 = bookInProgress < 1 || bookInProgress > 36;
            if (!flag2)
            {
                bool isPrisoner = Hero.MainHero.IsPrisoner;
                if (!isPrisoner)
                {
                    bookProgress[bookInProgress] += rate * (1f / (CampaignTime.DaysInYear * 1.5f));
                    AccessTools.Field(typeof(LT_EducationBehaviour), "_bookProgress").SetValue(LT_EducationBehaviour.Instance, bookProgress);
                    bool flag3 = bookProgress[bookInProgress] >= 100f;
                    if (flag3)
                    {
                        AccessTools.Method(typeof(LT_EducationBehaviour), "MainHeroFinishReading").Invoke(LT_EducationBehaviour.Instance, new object[] { });
                    }
                }
            }
        }
    }
}

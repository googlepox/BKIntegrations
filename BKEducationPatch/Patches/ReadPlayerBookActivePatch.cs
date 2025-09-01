using BannerKings;
using BannerKings.Managers.Education;
using BannerKings.Managers.Skills;
using HarmonyLib;
using LT.Logger;
using LT_Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BKEducationPatch.Patches
{
    [HarmonyPatch(typeof(LT_EducationBehaviour), "ReadPlayerBookActive")]
    internal class ReadPlayerBookActivePatch
    {
        public static bool Prefix(LT_EducationBehaviour __instance)
        {
            EducationData heroData = BannerKingsConfig.Instance.EducationManager.GetHeroEducation(Hero.MainHero);
            bool isLiterate = heroData.HasPerk(BKPerks.Instance.ScholarshipLiterate);
            int bookInProgress = (int)AccessTools.Field(typeof(LT_EducationBehaviour), "_bookInProgress").GetValue(LT_EducationBehaviour.Instance);
            float[] bookProgress = (float[])AccessTools.Field(typeof(LT_EducationBehaviour), "_bookProgress").GetValue(LT_EducationBehaviour.Instance);
            bool readingInMenu = (bool)AccessTools.Field(typeof(LT_EducationBehaviour), "_readingInMenu").GetValue(LT_EducationBehaviour.Instance);
            bool inTraining = (bool)AccessTools.Field(typeof(LT_EducationBehaviour), "_inTraining").GetValue(LT_EducationBehaviour.Instance);
            if (isLiterate)
            {
                if (readingInMenu)
                {
                    if (!inTraining)
                    {
                        Hero hero = Hero.MainHero;
                        MobileParty party = hero.PartyBelongedTo;
                        bool flag3 = party == null;
                        if (!flag3)
                        {
                            bool computeIsWaiting = party.ComputeIsWaiting();
                            bool flag4 = readingInMenu && !computeIsWaiting && hero.CurrentSettlement != null && hero.CurrentSettlement.IsVillage;
                            if (flag4)
                            {
                                computeIsWaiting = true;
                            }
                            bool flag5 = bookInProgress > -1 && bookInProgress < 37 && bookProgress[bookInProgress] < 100f && !hero.IsPrisoner && computeIsWaiting && party.BesiegedSettlement == null && party.AttachedTo == null;
                            if (flag5)
                            {
                                bool flag6 = hero.CurrentSettlement == null;
                                if (flag6)
                                {
                                    bool flag7 = party.LastVisitedSettlement != null && party.LastVisitedSettlement.IsVillage;
                                    if (!flag7)
                                    {
                                        return false;
                                    }
                                    float distance = Campaign.Current.Models.MapDistanceModel.GetDistance(MobileParty.MainParty, party.LastVisitedSettlement);
                                    bool flag8 = distance < 1.05f;
                                    if (!flag8)
                                    {
                                        return false;
                                    }
                                }
                                bool flag9 = !LT_EducationBehaviour.Instance.HeroHasBook(Hero.MainHero, bookInProgress);
                                if (flag9)
                                {
                                    LT_EducationBehaviour.Instance.HeroStopReadingAndReturnBookToParty(Hero.MainHero);
                                    LTLogger.IMRed("{=LTE00524}You don't have a book you were reading before...");
                                }
                                else
                                {
                                    heroData.GainBookReading(heroData.CurrentBook, heroData.CurrentBookReadingRate.ResultNumber);
                                    float[] newBookProgress = (float[])AccessTools.Field(typeof(LT_EducationBehaviour), "_bookProgress").GetValue(LT_EducationBehaviour.Instance);
                                    float progress = newBookProgress[bookInProgress];
                                    bool flag13 = progress < 1f;
                                    if (flag13)
                                    {
                                        int hour = (int)CampaignTime.Now.CurrentHourInDay;
                                        bool flag14 = hour % 6 == 0;
                                        if (flag14)
                                        {
                                            MBTextManager.SetTextVariable("READING_DATA", heroData.CurrentBook.GetName() + " [" + progress.ToString("0") + "%]", false);
                                            LTLogger.IM("{=LTE00525}Reading {READING_DATA}", "#FFFFFFFF");
                                        }
                                    }
                                    else
                                    {
                                        AccessTools.Method(typeof(LT_EducationBehaviour), "MainHeroFinishReading").Invoke(LT_EducationBehaviour.Instance, new object[] { });
                                        GameMenu.SwitchToMenu("education_menu");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}

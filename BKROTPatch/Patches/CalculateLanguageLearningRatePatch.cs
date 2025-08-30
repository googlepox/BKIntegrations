using BannerKings;
using BannerKings.Managers.Education.Languages;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Models.BKModels;
using BKROTPatch.Divinities;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(BKEducationModel), "CalculateLanguageLearningRate")]
    internal class CalculateLanguageLearningRatePatch
    {
        public static void Postfix(ref BKEducationModel __instance, ExplainedNumber __result, Hero student, Hero instructor, Language language)
        {
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(student);
            if (rel != null)
            {
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(student, ROTDivinities.Instance.Gelenei, rel))
                {
                    __result.AddFactor(0.2f, ROTDivinities.Instance.Gelenei.Name);
                }
            }
        }
    }
}

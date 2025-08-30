using BannerKings;
using BannerKings.Managers.Education.Books;
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

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(BKEducationModel), "CalculateBookReadingRate")]
    internal class CalculateBookReadingRatePatch
    {
        public static void Postfix(ref BKEducationModel __instance, ExplainedNumber __result, BookType book, Hero reader)
        {
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(reader);
            if (rel != null)
            {
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(reader, ROTDivinities.Instance.Gelenei, rel))
                {
                    __result.AddFactor(0.2f, ROTDivinities.Instance.Gelenei.Name);
                }
            }
        }
    }
}

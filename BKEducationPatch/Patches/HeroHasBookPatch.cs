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
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Library;

namespace BKEducationPatch.Patches
{
    [HarmonyPatch(typeof(LT_EducationBehaviour), "HeroHasBook")]
    internal class HeroHasBookPatch
    {
        public static void Postfix(LT_EducationBehaviour __instance, bool __result, Hero hero)
        {
            if (!__result && hero != null && hero.PartyBelongedTo != null)
            {
                MobileParty party = hero.PartyBelongedTo;
                MBReadOnlyList<BookType> books = BannerKingsConfig.Instance.EducationManager.GetAvailableBooks(party);
                if (books.Count > 0)
                {
                    __result = true;
                }
                else
                {
                    __result = false;
                }
            }
        }
    }
}

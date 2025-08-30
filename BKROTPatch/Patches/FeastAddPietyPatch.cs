using BannerKings;
using BannerKings.Behaviours.Feasts;
using BannerKings.Managers.Education.Books;
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
    [HarmonyPatch(typeof(Feast), "AddPiety")]
    internal class FeastAddPietyPatch
    {
        public static void Postfix(ref Feast __instance, Hero hero, bool host)
        {
            var religion = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(hero);
            if (religion != null && host && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.Selloso, religion))
            {
                float piety = 20 * __instance.Guests.Count * (float)AccessTools.Property(typeof(Feast), "GeneralSatisfaction").GetValue(__instance); ;
                BannerKingsConfig.Instance.ReligionsManager.AddPiety(religion, hero, piety);
            }
            if (religion != null && host && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.DrunkenGod, religion))
            {
                float piety = 20 * __instance.Guests.Count * (float)AccessTools.Property(typeof(Feast), "GeneralSatisfaction").GetValue(__instance); ;
                BannerKingsConfig.Instance.ReligionsManager.AddPiety(religion, hero, piety);
            }
        }
    }
}

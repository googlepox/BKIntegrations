using BannerKings.Managers.Institutions.Religions.Doctrines;
using BannerKings.Managers.Institutions.Religions.Faiths;
using BannerKings.Managers.Institutions.Religions.Leaderships;
using HarmonyLib;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;

namespace BKCEKPatch.Patches.Religion
{
    [HarmonyPatch(typeof(BannerKings.Managers.Institutions.Religions.Religion), "Initialize")]
    internal class ReligionPatch
    {
        public static void Postfix(ref BannerKings.Managers.Institutions.Religions.Religion __instance, ref List<CultureObject> ___favoredCultures, Faith faith,
          ReligiousLeadership leadership,
          List<CultureObject> favoredCultures,
          List<Doctrine> doctrines,
          Settlement settlement)
        {
            List<CultureObject> newCultures;
            if (__instance.StringId == "asera")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("aserai"),
                    BannerKings.Utils.Helpers.GetCulture("khuzait"),
                    BannerKings.Utils.Helpers.GetCulture("rebkhu"),
                    BannerKings.Utils.Helpers.GetCulture("empire"),
                    BannerKings.Utils.Helpers.GetCulture("lyrion"),
                    BannerKings.Utils.Helpers.GetCulture("apolssalian"),
                    BannerKings.Utils.Helpers.GetCulture("republic"),
                    BannerKings.Utils.Helpers.GetCulture("ariorum")

                };
                ___favoredCultures = newCultures;
            }
            else if (__instance.StringId == "amra")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("battania"),
                    BannerKings.Utils.Helpers.GetCulture("paleician"),
                    BannerKings.Utils.Helpers.GetCulture("vagir")
                };
                ___favoredCultures = newCultures;
            }
            else if (__instance.StringId == "treelore")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("sturgia"),
                    BannerKings.Utils.Helpers.GetCulture("vakken"),
                    BannerKings.Utils.Helpers.GetCulture("vagir"),
                    BannerKings.Utils.Helpers.GetCulture("nordling")
                };
                ___favoredCultures = newCultures;
            }
            else if (__instance.StringId == "darusosian")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("empire"),
                    BannerKings.Utils.Helpers.GetCulture("republic"),
                    BannerKings.Utils.Helpers.GetCulture("ariorum")
                };
                ___favoredCultures = newCultures;
            }
            else if (__instance.StringId == "canticles")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("vlandia"),
                    BannerKings.Utils.Helpers.GetCulture("empire"),
                    BannerKings.Utils.Helpers.GetCulture("battania"),
                    BannerKings.Utils.Helpers.GetCulture("sturgia"),
                    BannerKings.Utils.Helpers.GetCulture("aserai"),
                    BannerKings.Utils.Helpers.GetCulture("khuzait"),
                    BannerKings.Utils.Helpers.GetCulture("republic"),
                    BannerKings.Utils.Helpers.GetCulture("ariorum"),
                    BannerKings.Utils.Helpers.GetCulture("vagir"),
                    BannerKings.Utils.Helpers.GetCulture("rhodok"),
                    BannerKings.Utils.Helpers.GetCulture("nordling"),
                    BannerKings.Utils.Helpers.GetCulture("paleician"),
                    BannerKings.Utils.Helpers.GetCulture("rebkhu"),
                    BannerKings.Utils.Helpers.GetCulture("lyrion"),
                    BannerKings.Utils.Helpers.GetCulture("apolssalian")
                };
                ___favoredCultures = newCultures;
            }
            else if (__instance.StringId == "osfeyd")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("vlandia"),
                    BannerKings.Utils.Helpers.GetCulture("vakken"),
                    BannerKings.Utils.Helpers.GetCulture("rhodok"),
                    BannerKings.Utils.Helpers.GetCulture("paleician"),
                };
                ___favoredCultures = newCultures;
            }
        }
    }
}

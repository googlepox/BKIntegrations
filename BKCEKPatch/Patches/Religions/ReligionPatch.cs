using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Institutions.Religions.Faiths;
using HarmonyLib;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Religions
{
    [HarmonyPatch(typeof(Religion), nameof(Religion.Initialize))]
    internal class ReligionPatch
    {
        public static void Postfix(ref Religion __instance, Faith faith,
          List<CultureObject> favoredCultures)
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
            }
            else if (__instance.StringId == "amra")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("battania"),
                    BannerKings.Utils.Helpers.GetCulture("paleician"),
                    BannerKings.Utils.Helpers.GetCulture("vagir")
                };
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
            }
            else if (__instance.StringId == "darusosian")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("empire"),
                    BannerKings.Utils.Helpers.GetCulture("republic"),
                    BannerKings.Utils.Helpers.GetCulture("ariorum")
                };
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
            }
            else if (__instance.StringId == "sixWinds")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("khuzait"),
                    BannerKings.Utils.Helpers.GetCulture("rebkhu"),
                };
            }
            else if (__instance.StringId == "calradian")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("republic"),
                    BannerKings.Utils.Helpers.GetCulture("ariorum"),
                    BannerKings.Utils.Helpers.GetCulture("empire"),
                };
            }
            else if (__instance.StringId == "immortalFlame")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("republic"),
                    BannerKings.Utils.Helpers.GetCulture("ariorum"),
                    BannerKings.Utils.Helpers.GetCulture("empire"),
                };
            }
            else if (__instance.StringId == "legionaries")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("republic"),
                    BannerKings.Utils.Helpers.GetCulture("ariorum"),
                    BannerKings.Utils.Helpers.GetCulture("empire"),
                };
            }
            else if (__instance.StringId == "junme")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("nordling"),
                    BannerKings.Utils.Helpers.GetCulture("sturgia"),
                    BannerKings.Utils.Helpers.GetCulture("vagir"),
                    BannerKings.Utils.Helpers.GetCulture("nord")
                };
            }
            else if (__instance.StringId == "rodovera")
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("sturgia"),
                    BannerKings.Utils.Helpers.GetCulture("vagir"),
                };
            }
            else
            {
                newCultures = new List<CultureObject>()
                {
                    BannerKings.Utils.Helpers.GetCulture("empire")
                };
            }
            AccessTools.Property(typeof(Religion), "FavoredCultures").SetValue(__instance, newCultures);
        }
    }
}

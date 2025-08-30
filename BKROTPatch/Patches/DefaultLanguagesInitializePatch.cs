using BannerKings;
using BannerKings.CampaignContent.Traits;
using BannerKings.Managers.Education.Books;
using BannerKings.Managers.Education.Languages;
using BannerKings.Managers.Innovations.Eras;
using BannerKings.Managers.Items;
using BannerKings.Managers.Skills;
using BKCEKPatch.Languages;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(DefaultLanguages), "Initialize")]
    internal class DefaultLanguagesInitializePatch
    {
        public static bool Prefix(DefaultLanguages __instance)
        {
            MBReadOnlyList<CultureObject> cultures = Game.Current.ObjectManager.GetObjectTypeList<CultureObject>();
            Language battanian = __instance.Battanian;
            TextObject textObject = new TextObject("{=tRp08jyH}Battanian", null);
            TextObject textObject2 = new TextObject("{=hNK8XTow}The language of the Battanian peoples has long since been a cultural divide between Battanians and other kingdoms in the continent. Given that Palaic, its sister language and culture, has mostly been erased by Imperials, the Battanian language is almost completely unintelligible to all other cultures present in Calradia. However, with the increased presence of Calradian as the lingua franca of trade, Battanians have slowly adopted some Imperial vocabulary. The language is still somewhat similar to Vakken, another natural culture of the continent, though recently the Vakken culture has mostly been replaced by Sturgians.", null);
            List<CultureObject> list = new List<CultureObject>();

            battanian.Initialize(textObject, textObject2, list, __instance.GetIntelligibles(__instance.Battanian));
            Language sturgian = __instance.Sturgian;
            TextObject textObject3 = new TextObject("{=VtNL32g2}Sturgian", null);
            TextObject textObject4 = new TextObject("{=QT3S6XkQ}Natural to the northern ends of Calradia, the Sturgians have an ancient linguistic tradition. Though __instance tradition has been recently shaken by the large mixing of nords, the Sturgian culture itself is native to the continent, as well as it's sister culture, Vakken, with which the Sturgian language still finds similarities.", null);
            List<CultureObject> list2 = new List<CultureObject>();

            sturgian.Initialize(textObject3, textObject4, list2, __instance.GetIntelligibles(__instance.Sturgian));
            Language khuzait = __instance.Khuzait;
            TextObject textObject5 = new TextObject("{=ZdFBNgoJ}Khuzait", null);
            TextObject textObject6 = new TextObject("{=rYVgj513}The langauge of the steppe is often described by foreigners as curt, but effective. Due to the near absence of scholarly research in the Khuzait culture, it often lacks terms for technical, or more abstract concepts, and as such it is certain those will be adopted from the Imperial language.", null);
            List<CultureObject> list3 = new List<CultureObject>();

            khuzait.Initialize(textObject5, textObject6, list3, __instance.GetIntelligibles(__instance.Khuzait));
            Language vlandic = __instance.Vlandic;
            TextObject textObject7 = new TextObject("{=6FGQ31TM}Vlandic", null);
            TextObject textObject8 = new TextObject("{=!}", null);
            List<CultureObject> list4 = new List<CultureObject>();

            vlandic.Initialize(textObject7, textObject8, list4, __instance.GetIntelligibles(__instance.Vlandic));
            Language calradian = __instance.Calradian;
            TextObject textObject9 = new TextObject("{=NWqkTdMt}Calradian", null);
            TextObject textObject10 = new TextObject("{=GmqBFSgN}The Imperial language of the Calradian empire. Though scholars have made efforts into keeping the language pure, centuries of contact with local cultures have made Calradian adopt small quantities of local vocabularies. Being a language of prestige, Calradian vocabulary are also often adopted by foreign languages, due to it's usefulness in the continent as a Lingua Franca, often used by traders, nobles during their education or peasants looking for a better life within the Empire.", null);
            List<CultureObject> list5 = new List<CultureObject>();
            
            calradian.Initialize(textObject9, textObject10, list5, __instance.GetIntelligibles(__instance.Calradian));
            Language aseran = __instance.Aseran;
            TextObject textObject11 = new TextObject("{=!}Nahasawi", null);
            TextObject textObject12 = new TextObject("{=gM4s1KQf}Although the Aserai peoples speak a multitude of dialects, scattered across the oases, springs and coasts of the Nahasa, a distinct tradition of literalism and poety has established a common variation that has been embraced by the higher Aserai classes.", null);
            List<CultureObject> list6 = new List<CultureObject>();
            
            aseran.Initialize(textObject11, textObject12, list6, __instance.GetIntelligibles(__instance.Aseran));
            Language vakken = __instance.Vakken;
            TextObject textObject13 = new TextObject("{=brxz2SmN}Vakken", null);
            TextObject textObject14 = new TextObject("{=bXUwFrCF}The Vakken, sometimes called 'children of the forest', are a group native to northern Calradia. Vakken and Sturgian cultures have ancient connections, as both have lived and traded for centuries before the Imperials arrived in the continent. However, with the prevailment of the Sturgia kingdom and culture, the Vakken tongue and tradition is being increasingly forgotten about in the north.", null);
            List<CultureObject> list7 = new List<CultureObject>();
            
            vakken.Initialize(textObject13, textObject14, list7, __instance.GetIntelligibles(__instance.Vakken));
            return false;
        }
    }
}

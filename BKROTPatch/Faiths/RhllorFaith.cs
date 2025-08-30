using BannerKings.Managers.Institutions.Religions.Faiths;
using BKROTPatch.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BKROTPatch.Faiths
{
    internal class RhllorFaith : MonotheisticFaith
    {
        public override Settlement FaithSeat {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_ES2"); // Volantis
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.116.19.1836.1836.768.788.1.0.-30.521.0.116.739.739.764.764.1.1.0.514.142.116.454.454.764.764.1.1.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to pray to R'hllor.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pray to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Confirm your devotion upon the name of R'hllor, the Lord of Light.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("Would you pray to R'hllor, the Lord of Light?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has sworn an oath to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("The Lord of Light commands us to walk in His fire and fight the shadow. To deny the flame, to worship false gods, or to turn away from His path is sin. To murder in the dark without purpose, to betray the living against His will, or to scorn His servants brings His wrath. The weak, the unprepared, and those who embrace darkness when they could bring light — these deeds are forbidden. Serve the flame, and you serve life itself; forsake it, and you feed the shadow.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Turn from the shadow, embrace the flame, and live. To do otherwise is sin.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("The fire sees you. May it guide your steps and keep the shadow from your door.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("The Lord of Light is with you. May His fire protect your path. The flame burns within you as it does in me. May we walk together against the darkness.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have embraced the flame. May R’hllor’s fire purge your doubts, illuminate your path, and give you strength to fight the shadow wherever it rises. From this moment, you are His servant, a torch against the darkness, and His fire shall guard you.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("The flame claims you. Walk in His light, and let the shadow fear your fire.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the fire, the light that burns away shadow. I preach the coming of the Long Night, the rise of darkness, and the promise that R’hllor’s flame can push it back. I teach that life must fight, that the flame guides the living, and that those who serve it can bring hope where all seems lost. This is the Faith — the flame against the shadow.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("I preach the flame against the darkness, and the hope it gives to all who follow it.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Faith in R’hllor is proven not by words but by deeds. Fight the darkness, protect the living, trust in the flame even when all seems lost. Offer your light to the world, be a weapon of fire against shadow and cold. He sees all, and those who act in His name prove their hearts are true.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Act against the darkness, trust the flame, and your faith is proven.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Cults", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("R'hllor is the Heart of Fire, the Lord of Light, the God of Flame and Shadow. It is he who fights the Great Other, and led Azor Ahai to save the world in the Long Night after the Blood Betrayal.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("R'hllor is the Heart of Fire, the Lord of Light, the God of Flame and Shadow. It is he who fights the Great Other, and led Azor Ahai to save the world in the Long Night after the Blood Betrayal. The worship of R'hllor, the Lord of Light and Heart of Fire, has spread across Essos, and its devotees can be found in every Free City. Worshipers gather around fires, hoping to be granted visions by their lord. The sect is led by the High Priest in Volantis.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("R'hllor", null);
        }

        public override string GetId()
        {
            return "rhllor";
        }

        public override int GetIdealRank(Settlement settlement)
        {
            if (settlement.StringId == "town_ES2")
            {
                return 2;
            }
            return 1;
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            bool possible = true;
            TextObject text = new TextObject("You will be converted", null);
            return new ValueTuple<bool, TextObject>(possible, text);
        }

        public override TextObject GetInductionExplanationText()
        {
            return new TextObject("All are welcome in the light of R'hllor.", null);
        }

        public override int GetMaxClergyRank()
        {
            return 2;
        }

        public override TextObject GetRankTitle(int rank)
        {
            bool flag = rank == 2;
            TextObject text;
            if (flag)
            {
                text = new TextObject("High Priest of R'hllor", null);
            }
            else
            {
                text = new TextObject("Red Priest", null);
            }
            return text;
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return CultureHelpers.IsCultureEssosi(culture);
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            if (hero.StringId == "ROTlord_505" || hero.StringId == "lord_1_12") // Stannis and Melisandre
            {
                return true;
            }
            return IsCultureNaturalFaith(hero.Culture) && MBRandom.RandomFloat < 0.2f;
        }
    }
}

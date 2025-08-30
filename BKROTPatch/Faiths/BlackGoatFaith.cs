using BannerKings.Managers.Institutions.Religions.Faiths;
using BKROTPatch.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BKROTPatch.Faiths
{
    internal class BlackGoatFaith : MonotheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_ES6"); // Qohor
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.116.131.1836.1836.768.788.1.0.0.132.142.116.588.588.764.901.1.0.0.321.142.116.329.329.764.580.1.0.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to make a sacrifice to the Black Goat.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("make a sacrifice to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? The Black Goat demands blood and flesh, and curses those who invoke Him in vain.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("Would you make a sacrifice to the Black Goat?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has made a sacrifice to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("The Black Goat commands obedience. To withhold sacrifice is blasphemy. To refuse the rites, to spare the guilty or the innocent, or to betray the trust of the faithful is forbidden. Greed, cowardice, and weakness anger the Goat, for it hungers for devotion as much as for blood.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("To neglect your duty invites ruin upon yourself, your house, and your city. Fail not in sacrifice, obedience, or devotion — the Black Goat sees all.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("May the Black Goat’s shadow pass lightly over you, stranger. Mind the offerings you owe.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("Blood and devotion guide us. May the Goat’s favor flow through your hand and protect you today.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have stepped willingly into the shadow of the Black Goat. You will learn the weight of devotion and the taste of sacrifice.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("Let the Goat’s hunger guide your heart, and you shall not falter.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the dominion of the Black Goat, who commands life and blood alike. I preach that sacrifice is not cruelty, but necessity, and that obedience and devotion bring safety to the faithful.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("The Goat hungers, and we are its instruments.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Prove your faith in offerings. Prove it in discipline. Prove it in ritual and in daily obedience.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Let blood sanctify your devotion, and let your hands show the loyalty of your heart. Only through sacrifice does the Black Goat smile.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Cults", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("A dark god worshiped in Qohor, seen as a demon by many other faiths, the Black Goat is known for the daily blood sacrifices required to appease said god.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("A dark god worshiped in Qohor, seen as a demon by many other faiths, the Black Goat is known for the daily blood sacrifices required to appease said god. The Black Goat is worshiped chiefly in Qohor, and is known for the bloody sacrifices it demands.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("Disciples of The Black Goat", null);
        }

        public override string GetId()
        {
            return "black_goat";
        }

        public override int GetIdealRank(Settlement settlement)
        {
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
            return new TextObject("The Cults of the Free Cities welcome all.", null);
        }

        public override int GetMaxClergyRank()
        {
            return 1;
        }

        public override TextObject GetRankTitle(int rank)
        {
            return new TextObject("Horned One", null);
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "qohorik";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture) || (CultureHelpers.IsCultureEssosi(hero.Culture) && MBRandom.RandomFloat < 0.1f);
        }
    }
}

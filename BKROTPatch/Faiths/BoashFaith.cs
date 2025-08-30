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
    internal class BoashFaith : MonotheisticFaith
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
            return new Banner("11.100.131.1836.1836.768.788.1.0.0.430.73.116.195.195.764.764.1.0.0.403.12.116.385.385.764.764.1.0.0.446.79.116.1141.1141.764.764.1.0.-91");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to swear an oath to the Blind God.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pledge an oath to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? Boash sees all, and does not easily forgive those who betray an oath.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("Would you pray to Boash, the Blind God?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has sworn an oath to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("We are forbidden from consuming flesh, for to feast upon the dead is to blind ourselves to truth. We are forbidden from drinking wine, for its false fire clouds the inner sight.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("We are forbidden to delight in excess or vanity, for these are shackles upon the soul. To cling to the false lights of the world is to close the Third Eye forever.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("Walk with care, for even in darkness, Boash watches. May your eyes learn to see what lies beyond sight.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("{?PLAYER.GENDER}Sister{?}Brother{\\?}, — dim the world, so the soul may shine brighter. May Boash’s shadow fall upon you, and may the Third Eye stir within.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have turned from the false lights of flesh and indulgence, and chosen the shadowed path of truth. Close your eyes to the world, and open them to Boash.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("In darkness, you shall see more clearly than ever before.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("We preach that the eyes of the flesh are deceivers, but the Eye of the soul does not lie. We speak of a world unseen, where higher truths dwell, waiting to be glimpsed by those who walk in abstinence and discipline.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("We teach that blindness is not loss, but liberation.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Prove your faith by casting away indulgence. Prove it by closing your eyes to temptation.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Prove it by seeking silence in shadow, fasting in humility, and walking in darkness until the Third Eye opens. For only then are you truly a child of Boash.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Cults", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("Boash, the Blind God, has been worshiped for thousands of years. His followers adhere to a strict code of consuming no flesh or wine and believe that higher truths can only be seen by their Third Eye, which can only be opened when the other two see only darkness.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("Boash, the Blind God, has been worshiped for thousands of years. His followers adhere to a strict code of consuming no flesh or wine and believe that higher truths can only be seen by their Third Eye, which can only be opened when the other two see only darkness. Boash is a strict god who seeks to have its followers see into the higher planes of existence.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("Disciples of Boash", null);
        }

        public override string GetId()
        {
            return "boash";
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
            return new TextObject("All-Seer", null);
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
            return IsCultureNaturalFaith(hero.Culture) && MBRandom.RandomFloat < 0.2f;
        }
    }
}

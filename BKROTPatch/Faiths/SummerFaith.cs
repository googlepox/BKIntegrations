using BannerKings.Managers.Institutions.Religions.Faiths;
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
    internal class SummerFaith : PolytheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "ROT_town25"); // Lotus Bay
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.147.116.1836.1836.768.788.1.0.0.220.55.116.669.669.764.764.1.0.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to pray to the Summer Gods.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pray to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? The Gods of Summer and Love embrace you.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("And which of the Gods of Summer and Love would you like to pray to?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has prayed to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("To deny the joy of life is forbidden. To bring harm through cruelty, oppression, or the enslavement of others is sin. Hatred, greed, and the twisting of love into malice anger the Gods of Summer.", null); ;
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("To scorn the sacred challenges of war, or to reject the bonds of passion and care, is to dishonor the islands and their divine guardians. Honor love, passion, and joy; harm none, and scorn injustice — that is the law of the Gods of Summer.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("May the sun warm your heart, traveler, and may love find its way to you wherever you walk.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("Peace and passion be with you, {?PLAYER.GENDER}sister{?}brother{\\?}. May the Gods of Summer guide your heart and deeds.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have opened your heart to the light of the Gods of Summer. May passion, love, and joy flow through you, and may your life honor the warmth and bounty of the islands.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("Walk now in the ways of the Gods of Summer and Love, and may they grant you joy.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the sacred fire of life, love, and passion. I teach that joy is divine, that love must be honored, and that violence, when it comes, is a sacred challenge to be met with courage. To live in harmony, to defend the weak, and to honor the heart in all things is to serve the Gods of Summer.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("Love the world, and no longer compare it with some kind of imaginary vision of perfection, but to leave it as it is, to love it and be glad to belong to it.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Prove your faith in kindness, in courage, and in love. Protect the innocent, honor your bonds, and embrace joy. Live fully, love truly, and meet challenges with respect for the sacred — this is the path the Gods of Summer demand.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("It is only important to love the world, not to despise it, not for us to hate each other, but to be able to regard the world and ourselves and all beings with love, admiration, and respect.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Cults", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("The faith of the Summer Islands is centered around a great pantheon of deities, often associated with summer, love, and passion. These deities watch over the people of the islands as a whole, giving dictates to ensure that wars are kept as sacred challenges, that slavers are driven away, and that love is extended to all.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("The faith of the Summer Islands is centered around a great pantheon of deities, often associated with summer, love, and passion. These deities watch over the people of the islands as a whole, giving dictates to ensure that wars are kept as sacred challenges, that slavers are driven away, and that love is extended to all. The Gods of Summer, Passion, and Love, they are venerated by the Summer Islanders.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("Temples of Summer and Love", null);
        }

        public override string GetId()
        {
            return "summer";
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
            return new TextObject("All are welcome in the Temples of Love.", null);
        }

        public override int GetMaxClergyRank()
        {
            return 1;
        }

        public override TextObject GetRankTitle(int rank)
        {
            return new TextObject("Heartbearer", null);
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "summer";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

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
    internal class GoldenGardensFaith : PolytheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_A8"); // Myr
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.134.19.1836.1836.768.788.1.0.-30.211.143.116.809.809.857.656.1.0.0.202.143.116.1051.1051.714.961.1.0.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to swear an oath to the Gods.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pledge an oath to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? The Gods do not easily forgive those who betray an oath.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("And which of the Gods would you like to swear an oath to?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has sworn an oath to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("The Golden Gardens are hidden, and Gelenei sees all who seek Her favor. To reveal the sacred beauty of oneself or others without cause, to act in vanity or cruelty, or to profane ritual and scripture is forbidden. To scorn the conclave, mock the mysteries, or disturb the sanctity of the Gardens draws Her displeasure.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Keep your secrets, honor the arcane rites, and walk humbly in the hidden light of Gelenei. Honor Gelenei, guard your beauty and secrets, and profane not the rites of the conclave.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("May Gelenei’s hidden light grace you, and may your path remain veiled in beauty and mystery.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("The Golden Gardens welcome you, fellow devotee. May your ritual be precise, your devotion unwavering, and your beauty hidden as the goddess wills.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have entered the fold of Gelenei and the Golden Gardens. May the conclave guide your hand in ritual, may the sacred scripture illuminate your mind, and may your hidden beauty flourish unseen.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("From this day forth, you walk in the secret light of the goddess and join Her mysteries. Gelenei claims you. Walk in shadowed beauty, and let Her mysteries guide your path.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the mysteries of Gelenei, the sacred Golden Gardens, and the hidden light that lies in beauty and devotion. I teach that knowledge is precious, ritual is sacred, and secrecy is a virtue. To follow this faith is to honor what is unseen, to act with care, and to cultivate hidden beauty in mind, body, and spirit.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("I preach Gelenei, the secret beauty of the Golden Gardens, and the sacred mysteries of devotion and discretion.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Faith is proven by secrecy, devotion, and care in ritual. Uphold the rites of the conclave, honor the hidden texts, and protect the sanctity of beauty. Those who act with discretion, reverence, and dedication prove themselves worthy of Gelenei’s favor.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Keep the secrets, honor the rites, and serve with discretion — that is proof of faith.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Gods", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("Those who believe in the sacred Golden Gardens keep their presumed beauty as a tightly held secret. Gelenei and her conclave are celebrated through arcane ritual and mysterious scripture.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("Those who believe in the sacred Golden Gardens keep their presumed beauty as a tightly held secret. Gelenei and her conclave are celebrated through arcane ritual and mysterious scripture. While all gods are welcomed in the Free Cities, those chiefly worshiped in Myr are Aquan the Red Bull, the Hooded Wayfarer, the Silent God, and Gelenei.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("The Golden Gardens", null);
        }

        public override string GetId()
        {
            return "golden_gardens";
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
            return new TextObject("Gardener", null);
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "myrish";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

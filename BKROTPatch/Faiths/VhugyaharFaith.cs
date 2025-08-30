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
    internal class VhugyaharFaith : PolytheisticFaith
    {
        public override Settlement FaithSeat {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_EN5"); // Braavos
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.13.19.1836.1836.768.788.1.0.-30.447.146.116.809.809.764.764.1.1.0");
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
            return new TextObject("The Vhugyahar watch us in all things. To ignore Their charge is sin. To break oaths, betray kin, or defile what is sacred to any god brings Their wrath. To steal from the marketplace, dishonor a guest, or spill blood without cause affronts them.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("To scorn one god for another, or to neglect the offerings owed, is to invite misfortune. Walk rightly, honor the domains of each deity, and you will live in their favor.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("The Vhugyahar guard you, traveler. May Their favor shine upon your steps and keep your path true.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("The Vhugyahar smile upon you, friend. May your work be fruitful, your hearth warm, and your heart steadfast.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have chosen to honor the Vhugyahar and join the faithful. May the Vhugyahar guide your steps, may They protect your home, and may all the Gods grant you wisdom, courage, and strength.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("From this day, you walk among those who keep the laws of the Vhugyahar and offer them reverence.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the guidance of the Vhugyahar. Each god holds sway over a part of life. To honor them is to live in harmony with their design.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("I preach the Gods’ guidance in all things, and the living of life with honor and respect.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Faith is shown through action. Uphold your oaths, honor your kin and neighbors, offer gifts and prayers to the Vhugyahar, and act in accordance with the Gods' domains. Defend the weak, labor with honest hands, and respect the sacred. Those who live by these deeds prove their hearts are true to the pantheon.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Live rightly, honor the Vhugyahar, and your faith is proven.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Gods", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("Followers believe in the full merits of the Vhugyahar, the 'Pantheon of Pantheons.' All gods and faiths of the world are welcomed and cherished, as long as they are worshiped in such a way that does not impede on the inherent freedom of men.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("Followers believe in the full merits of the Vhugyahar, the 'Pantheon of Pantheons.' All gods and faiths of the world are welcomed and cherished, as long as they are worshiped in such a way that does not impede on the inherent freedom of men. While all gods are welcomed in the Free Cities, those most celebrated on the Isle of the Gods are the Moon-Pale Maiden, the Lion of Night, the Father of Waters, and the Merling King.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("Vhugyahar", null);
        }

        public override string GetId()
        {
            return "vhugyahar";
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
            return new TextObject("Vhugyahari", null);
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "empire";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

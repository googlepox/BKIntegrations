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
    internal class HuesOfTriosFaith : PolytheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_A5"); // Tyrosh
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.4.19.1836.1836.768.788.1.0.-30.342.142.116.809.809.764.764.1.0.0");
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
            return new TextObject("The Dominar Trios watches all who claim allegiance to the gods. To sow discord among the faithful, to break oaths of war or trade, to betray your allies, or to exalt one god above Trios is forbidden. Greed without honor, violence without purpose, or neglect of duty affronts the balance He commands.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Serve Trios, uphold the banners of cooperation, and all deities shall know your loyalty; stray, and you defy their order. Keep your oaths, honor your allies, and serve Trios — all else is forbidden.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("May the Hues of Trios guide your hand and steady your heart. May your path be prosperous, your allies loyal, and your deeds just.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("The Dominar smiles upon you, friend. May your trade prosper, your shields hold firm, and your counsel be wise beneath His guidance.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have taken the vow to serve under Trios, the Dominar of the Deities. May your loyalty bind the gods and mortals in harmony, may your hands act with purpose, and may your heart follow the path of duty and cooperation.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("From this day forth, you are counted among those who honor both the divine and the disciplined. Trios claims you. Walk in His order and serve with loyalty.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the will of Trios, the Dominar of the Deities. I teach that the gods desire unity among their followers, that war and commerce are sacred tools of cooperation, and that loyalty, honor, and purpose must guide every act. To follow this faith is to serve the balance, the order, and the strength that binds all divine will.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("I preach loyalty, unity, and the guidance of Trios in all things.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Faith is shown in service and discipline. Uphold your oaths of war and commerce, act honorably toward allies, champion the will of the gods through unity, and let Trios’ banner guide your hand. Those who act with purpose, fairness, and coordination prove themselves true to the Dominar.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Serve with loyalty, honor your oaths, act with purpose — that is proof of faith.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Gods", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("Long ago, followers of a myriad of gods worked together under banners of war and banners of commerce. In this cooperation, they came to favor and champion Trios as the deserved dominar of their deities.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("Long ago, followers of a myriad of gods worked together under banners of war and banners of commerce. In this cooperation, they came to favor and champion Trios as the deserved dominar of their deities. While all gods are welcomed in the Free Cities, those chiefly celebrated in Tyrosh are Trios, the twins Semosh and Selloso, the Drunken God, and the Pattern.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("The Hues of Trios", null);
        }

        public override string GetId()
        {
            return "hues_of_trios";
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
            return new TextObject("Triune", null);
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "tyroshi";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

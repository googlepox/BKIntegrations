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
    internal class YiTiFaith : PolytheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "ROT_town26"); // Ifequeveron
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("34.140.12.1836.1836.768.788.1.0.0.320.131.116.184.184.764.769.1.0.0.401.131.116.556.556.764.783.1.0.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to pray to the Thousand Gods of Yi Ti.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pray to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? The Thousand Gods see all.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("And which of the Gods would you like to pray to?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has prayed to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("To deny Heaven’s Will is forbidden. To act against the God-on-Earth, to ignore the counsel of the Maiden-Made-of-Light, or to resist the judgment of the Lion of Night is blasphemy. Disobedience, greed, and disrespect toward the divine hierarchy or toward one’s earthly superiors bring ruin.", null); ;
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("One must honor the celestial bureaucracy as one honors the Empire, for both are ordered by Heaven. Obey Heaven, respect the divine hierarchy, and honor the God-on-Earth — all else is forbidden.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("May Heaven guide your steps, traveler, and may the God-on-Earth watch over your path.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("Peace be with you, child of Heaven. May your deeds reflect the order of the Court and the Will of the God-on-Earth.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have bowed to the order of Heaven and joined the service of the Celestial Court.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("Let your life reflect obedience, honor, and diligence, and may the God-on-Earth guide your every step.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the authority of Heaven, the rule of the God-on-Earth, and the wisdom of the divine advisors. I teach that all under Heaven must obey the celestial hierarchy, honor the laws of the Court, and act in accordance with the Will that orders both Empire and cosmos.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("The faithful serve Heaven, and Heaven ensures order and balance.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Prove faith through obedience: follow the decrees of the Court, respect the God-on-Earth and the celestial advisors, and act in accordance with Heaven’s Will.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Prove it through diligence, through service to the Empire, and through reverence for the hierarchy of gods and men alike. Only by reflecting order in life can one honor Heaven.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Gods", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("All under Heaven is born to Heaven's Will, and just as the emperors rule the Golden Empire, so too does a God-on-Earth rule the Celestial Court. Amongst the court are other divine beings, including the Maiden-Made-of-Light and the Lion of Night, who serve as the God-on-Earth's chief advisors. When needed, the Lion of Night serves as the executioner and enforcer.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("All under Heaven is born to Heaven's Will, and just as the emperors rule the Golden Empire, so too does a God-on-Earth rule the Celestial Court. Amongst the court are other divine beings, including the Maiden-Made-of-Light and the Lion of Night, who serve as the God-on-Earth's chief advisors. When needed, the Lion of Night serves as the executioner and enforcer. The Thousand Gods of Yi Ti arrange themselves like the middle kingdom below, a vast divine bureaucracy with at its head the God-on-Earth who ascended to be with his parents, the Maiden-Made-of-Light and the Lion of Night.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("The Thousand Gods of Yi Ti", null);
        }

        public override string GetId()
        {
            return "yiti";
        }

        public override int GetIdealRank(Settlement settlement)
        {
            if (settlement.StringId == "ROT_town26")
            {
                return 2;
            }
            return 1;
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            bool possible = true;
            TextObject text = new TextObject("You will be converted", null);
            bool flag = !this.IsCultureNaturalFaith(hero.Culture) && hero.Culture.StringId != "yiti";
            if (flag)
            {
                possible = false;
                text = this.GetInductionExplanationText();
            }
            return new ValueTuple<bool, TextObject>(possible, text);
        }

        public override TextObject GetInductionExplanationText()
        {
            return new TextObject("Only Yi Tish are accepted.", null);
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
                text = new TextObject("High Celestial", null);
            }
            else
            {
                text = new TextObject("Celestial", null);
            }
            return text;
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "yiti";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

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
    internal class PrincesMerciesFaith : PolytheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_EN4"); // Pentos
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.119.19.1836.1836.768.788.1.0.-30.423.143.116.1167.1167.764.764.1.0.0.344.140.116.809.809.764.764.1.0.0");
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
            return new TextObject("The Great Prince and His Mercies watch all who bear His favor. To waste the blessings granted by the vessel, to act in greed, to betray the community, or to scorn the Mercies is forbidden. To harm the chosen vessel, to shirk duty, or to neglect ritual offerings brings their wrath.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Remember that life flows through the vessel, and all who prosper under His hand must honor it, for the Mercies demand respect, obedience, and gratitude.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("The Great Prince watches over you. May His Mercies guide your steps and prosper your days.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("The vessel lives in you, and the Mercies see your devotion. May your work bear fruit, your hearth remain strong, and your heart stay faithful.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have chosen to honor the Great Prince and serve through the vessel. May the Mercies grant you guidance, may your life prosper under Their hand, and may your service bring harmony and abundance to your people.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("From this day forth, you are part of the faithful who walk in the Prince’s light. The Great Prince claims your service. Walk with gratitude, and prosper through the Mercies’ favor.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the guidance of the Great Prince and His Mercies, who govern prosperity, duty, and balance. I teach that blessings come through the chosen vessel, that service and gratitude are sacred, and that the Mercies may demand ultimate tribute when their work is done. To follow this faith is to live with devotion, honor, and acceptance of the cycle of gift and sacrifice.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("I preach devotion to the Great Prince and His Mercies, service through the vessel, and gratitude for the blessings we receive.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Faith is shown through obedience, gratitude, and service. Honor the vessel, uphold your duties to the community, respect the rituals of the Mercies, and use the blessings you are given wisely. Those who serve faithfully and do not squander the gifts of the Great Prince prove their hearts are true.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Serve the vessel, honor the Mercies, and act with gratitude — that is proof of faith.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Gods", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("For the good of his people, the Great Prince offers prosperity and guidance through a chosen vessel. The Mercies, the pantheon he presides over, may eventually demand the vessel's life as tribute once his blessings have been spent.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("For the good of his people, the Great Prince offers prosperity and guidance through a chosen vessel. The Mercies, the pantheon he presides over, may eventually demand the vessel's life as tribute once his blessings have been spent. While all gods are welcomed in the Free Cities, in Pentos, the Prince is seen as the intermediary, the one who is the voice of the gods, and the ultimate sacrifice to appease the gods as well.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("The Prince's Mercies", null);
        }

        public override string GetId()
        {
            return "princes_mercies";
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
            return new TextObject("The Merciful", null);
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "pentoshi";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

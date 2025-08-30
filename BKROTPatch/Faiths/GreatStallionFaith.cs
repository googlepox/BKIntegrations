using BannerKings.Managers.Institutions.Religions.Faiths;
using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BKROTPatch.Faiths
{
    internal class GreatStallionFaith : MonotheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_K3"); // Vaes Dothrak
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.126.116.1836.1836.768.788.1.0.0.125.155.116.669.669.764.764.1.0.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to swear an oath to the Great Stallion.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pledge an oath to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? The Great Stallion does not easily forgive those who betray an oath. It is known.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("Would you swear an oath to the Great Stallion?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has sworn an oath to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("To dishonor the Great Stallion, the Sun, the Moon, or the Earth is forbidden. To cower before the gods of other lands, or to fail in the taking of what is owed to your khal and your people, brings dishonor. Weakness, cowardice, and submission are sins against the gods and against the blood of your tribe.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("To allow foreign gods to rule your heart is blasphemy; they are to be broken and made witnesses to the strength of the Dothraki. Honor the Great Stallion. Show strength, reject foreign gods, and take what is owed — all else is forbidden.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("The Stallion sees your steps. Ride true or fall.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("May the Great Stallion guide your hooves, and may your shadow ride far and fast.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have joined the riders of the wind and the children of the Great Stallion. Ride with honor, strike with strength, and may your path be wide as the open plains.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("The Great Stallion rides with you now. It is known.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I speak of the Great Stallion, of Sun and Moon, and the Earth that bears us. I teach that the strength of our people is sacred, that our enemies’ gods are nothing but witnesses, and that the greatness of the Dothraki flows through every khal, rider, and foal.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("To follow this faith is to ride with courage and honor. It is known.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Prove your faith in action. Ride with strength, strike with courage, and honor your khal and the Great Stallion.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Show no fear, respect no false gods, and let your deeds be swift as the wind over the plains. Only in strength and devotion do we serve the gods truly.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Cults", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("The religion and beliefs of the Dothraki are largely derived from their ancient traditions and the teachings of the witch-queen Doshi, mother of the first great Khal. Most of the natural world is represented by many gods: the Sun and his wife, the Moon; the earth itself; and above all, the Great Stallion. While they acknowledge the gods of other lands and peoples, they are not to be worshiped. Instead, they are to be broken and dragged to Vaes Dothrak to become vanquished witnesses to the greatness of the Dothraki and their gods.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("The religion and beliefs of the Dothraki are largely derived from their ancient traditions and the teachings of the witch-queen Doshi, mother of the first great Khal. Most of the natural world is represented by many gods: the Sun and his wife, the Moon; the earth itself; and above all, the Great Stallion. While they acknowledge the gods of other lands and peoples, they are not to be worshiped. Instead, they are to be broken and dragged to Vaes Dothrak to become vanquished witnesses to the greatness of the Dothraki and their gods.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("Khalasar of the Great Stallion", null);
        }

        public override string GetId()
        {
            return "great_stallion";
        }

        public override int GetIdealRank(Settlement settlement)
        {
            if (settlement.StringId == "town_K3")
            {
                return 2;
            }
            return 1;
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            bool possible = true;
            TextObject text = new TextObject("You will be converted", null);
            bool flag = !this.IsCultureNaturalFaith(hero.Culture) && hero.Culture.StringId != "khuzait";
            if (flag)
            {
                possible = false;
                text = this.GetInductionExplanationText();
            }
            return new ValueTuple<bool, TextObject>(possible, text);
        }

        public override TextObject GetInductionExplanationText()
        {
            return new TextObject("Only Dothraki are accepted.", null);
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
                text = new TextObject("Ershe Yesi", null);
            }
            else
            {
                text = new TextObject("Yesi", null);
            }
            return text;
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "khuzait";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

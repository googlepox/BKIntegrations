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
    internal class MotherRhoyneFaith : MonotheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_A1"); // Sunspear
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.140.131.1836.1836.768.788.1.0.0.457.16.116.448.448.764.904.1.1.0.208.129.116.274.274.764.574.1.1.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to pray to the Mother Rhoyne.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pray to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? The Mother Rhoyne loves all, but anger her not, for her wrath is as swift as the Waters.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("Would you pray to Mother Rhoyne, the Source of All Life?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has prayed to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("To pollute the waters is to blaspheme the Mother. To harm the river, take more than is given, or scorn Her gifts is forbidden. Pride, waste, cruelty, and neglect are sins against Her bounty.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Those who dishonor the river dishonor all life, for from Her all springs, and all must return. Honor the river, take only what is given, and harm none — that is the law of Mother Rhoyne.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("May the waters of the Rhoyne nourish you, traveler, and may Her currents guide your steps.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("Peace be upon you, Child of the River. May Mother Rhoyne sustain your heart and flow through your deeds.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have joined the flow of the Mother. Let Her waters cleanse doubt, nourish your spirit, and guide you in all things.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("Walk now in harmony with Her currents, and your life shall flourish.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the supremacy of Mother Rhoyne, who births and sustains all. I teach that every river, every tributary, and every living soul owes its life to Her waters.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("To honor Her is to honor all existence, and to live with gratitude and care for the flow of life She provides.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Prove faith in stewardship: protect the waters, nurture life, and live in harmony with the currents of the world. Offer thanks in ritual and deed, take only what is needed, and act in ways that honor the Mother’s flow.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("The faithful live in balance, as the river flows without harm or excess.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Gods", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("The religion of the Rhoynar is one centered, just as the entirety of their civilization, upon the river Rhoyne. The river is chief goddess, the Mother of all other deities and peoples, and it is she whom the Rhoynar look to.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("The religion of the Rhoynar is one centered, just as the entirety of their civilization, upon the river Rhoyne. The river is chief goddess, the Mother of all other deities and peoples, and it is she whom the Rhoynar look to. Mother Rhoyne is the supreme Goddess. It is from her that all other gods and indeed people spring forth. It is she who nurtures and provides all that is needed.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("Children of the Mother Rhoyne", null);
        }

        public override string GetId()
        {
            return "mother_rhoyne";
        }

        public override int GetIdealRank(Settlement settlement)
        {
            if (settlement.StringId == "town_A1")
            {
                return 2;
            }
            return 1;
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            bool possible = true;
            TextObject text = new TextObject("You will be converted", null);
            bool flag = !this.IsCultureNaturalFaith(hero.Culture) && hero.Culture.StringId != "aserai";
            if (flag)
            {
                possible = false;
                text = this.GetInductionExplanationText();
            }
            return new ValueTuple<bool, TextObject>(possible, text);
        }

        public override TextObject GetInductionExplanationText()
        {
            return new TextObject("As descendants of the Rhoynar, only Dornish are accepted.", null);
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
                text = new TextObject("High Speaker", null);
            }
            else
            {
                text = new TextObject("Speaker", null);
            }
            return text;
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "aserai";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture) && MBRandom.RandomFloat < 0.3f;
        }
    }
}

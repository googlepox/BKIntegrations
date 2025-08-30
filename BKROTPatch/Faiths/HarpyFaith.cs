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
    internal class HarpyFaith : MonotheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_K1"); // Meereen
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.143.116.1836.1836.768.788.1.0.0.104.48.116.669.669.764.764.1.0.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to pray to the Harpy.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pray to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? The Harpy remembers all words.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("Confirm your devotion upon the name of the Harpy.", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has prayed to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("The Harpy watches still. To betray the Empire, to dishonor the legacy of Grazdan the Great, or to defile the teachings of the Octarchs is forbidden. To ignore the counsel of the elders, to act against the law, or to dishonor the Harpy’s sacred heights brings shame and the gaze of the Harpy upon you.", null); ;
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Pride, neglect, and treachery are sins against both the living and the ancestors who guide us. Honor the Harpy, uphold the Empire, obey the Octarchs — all else is forbidden.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("May the Harpy’s wings shield your path, stranger. Walk with respect for the old ways.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("Peace be upon you, child of Ghis. May the Harpy’s gaze guide your deeds and protect your house.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have returned to the watchful Harpy. Uphold the legacy of Grazdan, honor the Octarchs, and walk beneath the wings of the Protector.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("In loyalty, you shall find strength; in service, you shall find purpose.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the protection and guidance of the Harpy, who watches over the Ghiscari and their descendants. I teach the wisdom of the Octarchs, the laws of Grazdan the Great, and the sacred duty to honor the empire past and present.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("To serve the Harpy is to serve justice, order, and the enduring legacy of our people.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Prove your faith in service: uphold the laws, protect the people, honor the elders, and remember the heights from which the Octarchs once led.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Loyalty, diligence, and reverence for tradition are the marks of a true child of the Harpy.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Cults", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("Since the time of Grazdan the Great, it was the Harpy that watched over and protected the Empire and the Ghiscari. Even after the fall of the Empire and Ghis itself, the Harpy still stands over the people.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("Since the time of Grazdan the Great, it was the Harpy that watched over and protected the Empire and the Ghiscari. Even after the fall of the Empire and Ghis itself, the Harpy still stands over the people. The old Gods of Ghis were venerable before the Freehold was even a thought. Their Octarchs preached and led from the eight heights, guiding the old empire to greatness after Grazdan.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("Scions of the Harpy", null);
        }

        public override string GetId()
        {
            return "harpy";
        }

        public override int GetIdealRank(Settlement settlement)
        {
            if (settlement.StringId == "town_K1")
            {
                return 3;
            }
            else if (settlement.IsTown)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            bool possible = true;
            TextObject text = new TextObject("You will be converted", null);
            bool flag = !this.IsCultureNaturalFaith(hero.Culture) && hero.Culture.StringId != "ghiscari";
            if (flag)
            {
                possible = false;
                text = this.GetInductionExplanationText();
            }
            return new ValueTuple<bool, TextObject>(possible, text);
        }

        public override TextObject GetInductionExplanationText()
        {
            return new TextObject("Only Ghiscari are accepted.", null);
        }

        public override int GetMaxClergyRank()
        {
            return 3;
        }

        public override TextObject GetRankTitle(int rank)
        {
            bool flag = rank == 3;
            TextObject text;
            if (flag)
            {
                text = new TextObject("Gold Grace", null);
            }
            else if (rank == 2)
            {
                text = new TextObject("Octarch", null);
            }
            else
            {
                text = new TextObject("Scion", null);
            }
            return text;
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("Sons of the Harpy", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "ghiscari";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

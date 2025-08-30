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
    internal class PatternFaith : MonotheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_EN6"); // Lorath
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.10.131.1836.1836.768.788.1.0.0.415.155.116.847.847.764.764.1.0.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to swear an oath to the Patternmaker.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pledge an oath to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? The Patternmaker does not easily forgive those who betray an oath.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("Would you pray to the Patternmaker?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has sworn an oath to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("To claim you have mastered the labyrinth is forbidden — for none may know all its paths. Pride and certainty blind the eyes that might see truth.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("To scorn questions, to silence wonder, or to demand that another walk only as you do — these are sins against the Pattern. The Patternmaker forbids cruelty born of arrogance, for every step belongs to the walker, not the tyrant.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("Every path winds, stranger. May your feet find ground that does not betray you.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("The Pattern shifts, as ever. May you walk with patient eyes, my friend.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("Welcome, seeker. You have taken your first step into the labyrinth, though its turns began long before you knew them.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("Walk humbly, walk with wonder, and trust that each choice leads you nearer to the heart.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the turning of the path. I speak of the Patternmaker’s design, not carved in stone, but flowing through choice, chance, and change.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("Each question you dare, each contradiction you face, each sorrow and each joy — these are walls and corridors of the Labyrinth. Truth is not a destination, but the walk itself.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Prove it in patience. When the way bends, do not curse the turn. Prove it in humility: admit what you do not know, and listen when wisdom comes in strange tongues.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Prove it in courage: take the step that frightens you, and see where it leads. The Patternmaker asks for no temples of stone, only lives lived with open eyes and open hearts.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Cults", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("The Patternmaker's teachings hold that truth lies at the heart of a great labyrinth - one not always marked by walls or turns, but by choices, contradictions, and revelations. All may walk its winding ways, but only those with humility and patience might find wisdom in life's shifting paths.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("The Patternmaker's teachings hold that truth lies at the heart of a great labyrinth - one not always marked by walls or turns, but by choices, contradictions, and revelations. All may walk its winding ways, but only those with humility and patience might find wisdom in life's shifting paths. While all gods are welcomed in the Free Cities, those chiefly celebrated in Lorath are the Pattern, the Father of Waters, the Hooded Wayfarer, and Bakkalon.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("The Pattern", null);
        }

        public override string GetId()
        {
            return "pattern";
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
            return new TextObject("Pathseeker", null);
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
            return IsCultureNaturalFaith(hero.Culture) && MBRandom.RandomFloat < 0.3f;
        }
    }
}

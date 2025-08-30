using BannerKings.Managers.Institutions.Religions.Faiths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Engine;
using TaleWorlds.Localization;
using BKROTPatch.Helpers;

namespace BKROTPatch.Faiths
{
    internal class SevenFaith : PolytheisticFaith
    {
        public override Settlement FaithSeat {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_EW4"); // King's Landing
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.140.19.1836.1836.768.788.1.0.-30.504.143.143.100.300.763.615.1.1.0.504.143.143.100.300.656.668.1.1.44.504.143.143.100.300.871.670.1.1.-46.504.143.143.100.299.829.883.1.1.-150.504.143.143.100.299.692.879.1.1.-211.504.143.143.100.300.903.764.1.1.-90.504.143.143.100.300.624.764.1.1.-271.503.143.143.168.168.764.764.1.1.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to swear an oath to the Seven.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pledge an oath to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? The Seven do not easily forgive those who betray an oath.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("And which of the Seven would you like to swear an oath to?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has sworn an oath to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("Child, you ask what the Faith forbids, and rightly so. For the Seven Who Are One watch over us all, and in their sight we must live rightly. Hear now the laws of the Father’s justice, the Mother’s mercy, the Warrior’s strength, the Maiden’s innocence, the Smith’s toil, the Crone’s wisdom, and even the Stranger’s shadow.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("To raise hand against one’s own blood is a grave sin. The Father judges such souls harshly. Only in battle may one slay lawfully; murder in secret or without cause damns a soul. The Seven alone are true. False gods, foreign or forgotten, are not to be worshiped.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("Seven blessings upon you, good folk! The Father sees your labors, the Mother hears your prayers, the Warrior shields your hearth, the Maiden guards your children, the Smith strengthens your hands, the Crone lights your path, and even the Stranger walks beside you unseen. Come, step into the light of the Seven, for They are one, and They are with us always. Let no soul be forgotten, no burden borne alone, for in Their sight, we are all kin.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("Seven keep you, my child. May the Father grant you justice, the Mother grant you mercy, and the Warrior grant you strength. How fare you beneath Their watchful eyes today?", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("Rejoice, for a soul has come into the light of the Seven. The Father shall judge you with fairness, the Mother shall cradle you in mercy. The Warrior shall lend you strength, the Maiden guard your innocence, the Smith bless the work of your hands, and the Crone guide your steps with wisdom. Even the Stranger, dark and silent, shall walk beside you until your final day.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("From this moment forth, you are of the Faith, a child of the Seven Who Are One. Be welcome, and be blessed.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("What do I preach? Only the truth of the Seven Who Are One. I speak of the Father’s justice, that none may go astray. I speak of the Mother’s mercy, that all may be forgiven. I tell of the Warrior’s strength, to shield the weak, and of the Maiden’s purity, that we may walk uncorrupted.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("I honor the Smith, who blesses every honest labor, and the Crone, who lights the path with wisdom. Even the Stranger, whom we fear, must be remembered, for none may escape His hand. This is the Faith, child — the seven faces of the One, ever watching, ever guiding.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("How does one prove their faith, you ask? Not with fine words alone, nor with gold laid before the altar. Faith is proven in the living of each day. Show the Father your faith by dealing justly with neighbor and stranger alike. Show the Mother your faith by giving mercy where wrath would be easier. Show the Warrior your faith by standing strong in defense of the weak.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Show the Maiden your faith by keeping your honor unsullied. Show the Smith your faith by laboring with honest hands. Show the Crone your faith by seeking wisdom, not folly. And even the Stranger — show Him your faith by meeting death with courage, when your hour comes. Live thus, and the Seven Who Are One will know your heart is true.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("The Seven", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("The Seven-Who-Are-One is one deity represented by seven aspects: The Father, stern and just; The Mother, loving and protective; The Warrior, brave and strong; The Maiden, beautiful and pure; The Smith, steadfast and diligent; The Crone, wise and thoughtful; and The Stranger, dark and shadowy.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("The Seven-Who-Are-One is one deity represented by seven aspects: The Father, stern and just; The Mother, loving and protective; The Warrior, brave and strong; The Maiden, beautiful and pure; The Smith, steadfast and diligent; The Crone, wise and thoughtful; and The Stranger, dark and shadowy. The Faith of the Seven is the dominant religion of Westeros. The majority of the people and lands are counted among the Faithful, and all the Kings of the Andals, the Rhoynar, and the First Men, in addition to being members, have sought crowning by the High Septon. The Faith is built upon the revelations and truths as laid out in The Seven-Pointed Star and is led by the guidance of the Most Devout and the High Septon.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("The Faith of the Seven", null);
        }

        public override string GetId()
        {
            return "seven";
        }

        public override int GetIdealRank(Settlement settlement)
        {
            if (settlement.StringId == "town_EW4")
            {
                return 2;
            }
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
            return new TextObject("All are welcome in the light of the Seven.", null);
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
                text = new TextObject("High Septon", null);
            }
            else
            {
                text = new TextObject("Septon", null);
            }
            return text;
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("The Faith Militant", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return CultureHelpers.IsCultureWesterosi(culture);
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

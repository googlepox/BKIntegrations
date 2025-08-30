using BannerKings.Managers.Institutions.Religions.Faiths;
using BKROTPatch.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BKROTPatch.Faiths
{
    internal class OldGodsFaith : PolytheisticFaith
    {
        public override Settlement FaithSeat {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_B2"); // Winterfell
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.141.19.1836.1836.768.788.1.0.-30.213.126.2.600.470.764.514.1.1.0.413.126.2.600.470.764.904.1.1.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to swear an oath to the Old Gods.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pledge an oath to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you sure? The Old Gods see all.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("And which of the Old Gods would you like to swear an oath to? The Gods of Stream, Forest, or Stone?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has sworn an oath to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("Child, the Old Gods do not speak in books nor by the mouths of septons. They whisper in the rustle of leaves, in the creak of the heart tree, in the dreams of those who can hear. Yet there are ways we know anger them. To swear falsely before a weirwood is the greatest sin — for the trees remember, and their memory is long.", null); ;
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Kinslaying is loathed, for blood calls to blood, and the earth drinks deep of such crimes. To shed blood upon the sacred ground of the godswood is accursed, unless in war or sacrifice as the First Men once knew. To mock the weirwoods, to defile them, or to turn from guest right — these too stir Their wrath. The Old Gods bind us to the land and to each other. To break oaths, to betray blood, to scorn the laws of hearth and harvest — these are the things They forbid. All else, the wind and leaf shall judge.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("The Old Gods watch you through leaf and bough. May your oaths hold true, and may the weirwoods keep silent of your name.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("The weirwoods watch over you, friend. May your hearth stay warm and your oaths hold true.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("So your heart has returned to the Old Ways. Walk with the trees, and let the weirwoods watch over you. Keep your oaths true, honor your kin, and let the land guide your steps. The wind and leaf shall remember your deeds, as the Old Gods remember all who walk under Their boughs. Go now, and be part of the forest’s memory.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("The Old Gods see you now. Walk true, and the trees will keep your name.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("What do I preach? I speak only of the Old Ways, of the trees that see all and the wind that remembers. I speak of keeping oaths, honoring kin, and walking true beneath the watchful eyes of the weirwoods. I speak of the land, the seasons, and the memory of the First Men.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("The Old Gods do not judge with words, only with the patience of stone and leaf. To walk with them is to live rightly, and to remember that all things are connected — life, death, and the forest between.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("How do you prove your faith in the Old Gods? Not with coin, nor with fine words. You prove it by keeping your oaths, honoring your kin, and walking true under the watch of the weirwoods. Respect the land, do no harm to sacred groves, and uphold guest right as the First Men did. Live in harmony with the forest and the seasons, and the wind and leaf shall remember you. That is how the Old Gods know your heart is faithful.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Walk true, honor your kin, keep the land and the trees sacred — that is how the Old Gods know you.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("The Old Gods of Stone of Stream, Forest, and Stone", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("This faith worships the Old Gods of stream, forest, and stone, nameless deities of the land connected to the Weirwood Trees found throughout Westeros.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("This faith worships the Old Gods of stream, forest, and stone, nameless deities of the land connected to the Weirwood Trees found throughout Westeros. Adopted after the Pact, the worship of the Old Gods has persisted in the North more than in any other part of the Seven Kingdoms. The worship of the Old Gods is a simple one, much more personal than that of the Faith of the Seven - there are few commandments and no scriptures. How one honors the gods is a personal matter. The key tenets are the sacredness of the weirwoods, the sanctity of guest right, and the holiness of oaths sworn before the heart tree.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("The Old Gods", null);
        }

        public override string GetId()
        {
            return "old_gods";
        }

        public override int GetIdealRank(Settlement settlement)
        {
            return 1;
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            bool possible = true;
            TextObject text = new TextObject("You will be converted", null);
            bool flag = !this.IsCultureNaturalFaith(hero.Culture) && !CultureHelpers.IsCultureNorthmen(hero.Culture);
            if (flag)
            {
                possible = false;
                text = this.GetInductionExplanationText();
            }
            return new ValueTuple<bool, TextObject>(possible, text);
        }

        public override TextObject GetInductionExplanationText()
        {
            return new TextObject("Only Northmen are accepted.", null);
        }

        public override int GetMaxClergyRank()
        {
            return 2;
        }

        public override TextObject GetRankTitle(int rank)
        {
            return new TextObject("Greenseer", null);
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return CultureHelpers.IsCultureNorthmen(culture);
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

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
    internal class DrownedGodFaith : MonotheisticFaith
    {
        public override Settlement FaithSeat {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_S3"); // Pyke
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.100.19.1836.1836.768.788.1.0.-30.402.142.116.600.470.764.764.1.1.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to swear an oath to the Drowned God.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pledge an oath to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Confirm your devotion upon the name of the Drowned God.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("Would you pray to the Drowned God?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has sworn an oath to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("Forbidden, ye ask? The Drowned God watches, and His ways are simple. To turn your back on the sea is to sin. To shirk raiding, to cower before your foes, is shameful in His sight. To break your oaths to kin or crew brings the Drowned God’s wrath. To leave your hearth empty, to waste the gifts of the ocean, or to dishonor your name — these are acts the Drowned God will not forgive. And above all, to die soft and cowardly, without facing the tide, is the greatest sin of all. What is dead may never die, but rises harder and stronger — fail at that, and ye have failed Him.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Fear the tide, keep your oaths, and die standing — that is what the Drowned God forbids to forget.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("The tide is high, and the Drowned God sees all. Stand strong.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("May the tide carry you true, {?PLAYER.GENDER}sister{?}brother{\\?}. What is dead may never die.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("So you take the deep oath and pledge to the Drowned God. May the sea welcome you, may the tide wash your old fears away, and may you rise from the water harder and stronger than ever. From this day, you are one of the salt and spray, and the Drowned God keeps watch.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("You are baptized in the tide. Rise harder, stronger, and never soft. The Drowned God has claimed you.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("What do I preach? I preach the way of the sea. I preach that the tide tests all, that the Drowned God watches and all who walk the waves must stand strong. I preach that oaths must be kept, that kin and crew are sacred, and that cowardice and soft living are sins. I preach that what is dead may never die, and that those who rise from the deep rise harder and stronger than before. This is the Faith, and the way of the Ironborn.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("I preach the tide, the Drowned God, and the strength to rise harder from whatever the waves throw at you.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("How do you prove your faith in the Drowned God? By raiding, by keeping your oaths, by honoring your kin and your crew. By facing the tide, standing in the storm, and never dying soft. Let the sea test you, let the waves judge you, and when you rise from the deep, let them see you stronger than before. That is proof enough for the Drowned God.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Keep your oaths, raid true, face the tide, and never die soft — that is faith enough.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Cults", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("This faith worships the Drowned God, He Who Dwells Beneath the Waves, in his watery halls. Creator of the Seas and father of the faithful, the Drowned God is connected to the seas of the world.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("This faith worships the Drowned God, He Who Dwells Beneath the Waves, in his watery halls. Creator of the Seas and father of the faithful, the Drowned God is connected to the seas of the world. The Drowned God is the god of the Ironmen, having persisted through the Pact of the Old Gods and the Faith of the Andals. The religion reveres the dead god, with practitioners hoping to join him in his underwater halls, for what is dead may never die, but rises again, harder and stronger.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("The Way of the Drowned God", null);
        }

        public override string GetId()
        {
            return "drowned_god";
        }

        public override int GetIdealRank(Settlement settlement)
        {
            return 1;
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            bool possible = true;
            TextObject text = new TextObject("You will be converted", null);
            bool flag = !this.IsCultureNaturalFaith(hero.Culture) && hero.Culture.StringId != "sturgia";
            if (flag)
            {
                possible = false;
                text = this.GetInductionExplanationText();
            }
            return new ValueTuple<bool, TextObject>(possible, text);
        }

        public override TextObject GetInductionExplanationText()
        {
            return new TextObject("Only Ironborn are accepted.", null);
        }

        public override int GetMaxClergyRank()
        {
            return 1;
        }

        public override TextObject GetRankTitle(int rank)
        {
            return new TextObject("Drowned Apostle", null);
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "sturgia";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

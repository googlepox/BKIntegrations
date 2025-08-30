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
    internal class HeritoryFaith : PolytheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_ES2"); // Volantis
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.149.19.1836.1836.768.788.1.0.-30.301.143.116.1144.1144.764.764.1.0.0.340.143.116.809.809.764.764.1.0.0");
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
            return new TextObject("It is forbidden to deny the succession of divinity. The gods of Valyria burned with the Doom, and their seats did not vanish — they were claimed. To cling to dead powers, to dishonor the heirs, or to speak of creation as greater than inheritance is heresy. Cowardice, weakness, and stagnation betray the very principle of succession, for only the worthy endure.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Those unfit to claim, or who yield what is theirs, are cast out from the favor of the Heirs. To worship the dead, to deny the heirs, or to live without strength is forbidden. Only the worthy inherit.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("May the Heirs’ fire test your strength, and may you prove yourself worthy of what is to come.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("{?PLAYER.GENDER}Sister{?}Brother{\\?} — Heir among Heirs. May your claim grow strong, and your worth shine radiant.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You stand no longer among the lost, clinging to the ashes of the past. You have taken your rightful place among the Heirs. The gods who died with the Doom left their thrones unguarded, and now you stand in reverence to those who proved strong enough to seize them.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("Rise, Heir of fire and succession — the past is yours, and so too is the future. You are Heir now. Claim what is yours, as the gods have done.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach succession. I preach that the gods of Valyria are dead, but their thrones were not left empty. I preach that divinity is not fixed in the past, but claimed by the strong and radiant in the present. I preach that you, too, may inherit — if you prove yourself worthy. This is Heritory: not to revere creation, but to honor succession. Not to bow to ashes, but to rise from them.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("I preach succession, strength, and the Heirs of Fire. The gods died — their heirs endure.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("You prove faith by claiming what is set before you — not by prayer alone, but by action, by strength, by resolve. Take what you can hold, defend what you inherit, and honor the Heirs by living unyielding. The weak let thrones crumble; the faithful build upon them. To inherit is to prove worthy — in word, in deed, in fire.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Prove yourself in strength and claim what is yours. That is faith.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Gods", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("Heritory holds that the gods of Valyria died with the Doom, and their power and thrones passed on to those worthy enough to claim them. These gods and their followers - fierce, radiant, and unyielding - are seen not as creations of the past, but as its rightful heirs. Reverence is paid not to origin, but to succession.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("Heritory holds that the gods of Valyria died with the Doom, and their power and thrones passed on to those worthy enough to claim them. These gods and their followers - fierce, radiant, and unyielding - are seen not as creations of the past, but as its rightful heirs. Reverence is paid not to origin, but to succession. While all gods are welcomed in the Free Cities, those chiefly celebrated in Volantis are the Lion of Night, the twins Semosh and Selloso, Pantera, and Aquan the Red Bull.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("Heritory", null);
        }

        public override string GetId()
        {
            return "heritory";
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
            return new TextObject("Heritor", null);
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "volantine";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

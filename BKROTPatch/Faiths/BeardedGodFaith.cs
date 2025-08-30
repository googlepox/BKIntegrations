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
    internal class BeardedGodFaith : MonotheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_ES1"); // Norvos
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.123.19.1836.1836.768.788.1.0.-30.439.125.116.458.458.764.694.1.0.0.403.125.116.847.847.764.714.1.0.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to swear an oath to the Bearded God.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pledge an oath to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? The Bearded God does not easily forgive those who betray an oath.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("Would you swear an oath to the Bearded God?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has sworn an oath to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("All who walk in His sight must show the mark of obedience. Hair is not vanity but a sign of station: women must go shorn, that their humility may shine brighter; men must keep their scalps bare, that they may know discipline; and only the ordained may wear the sacred beard, a veil of wisdom that marks our bond with the hidden Name.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("To grow what is forbidden is to grasp at a place not granted, and such pride offends the Bearded God. Likewise, blasphemy, idleness, and speaking His true name without sanction are punishments unto the soul.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("May the shadow of His beard fall upon you, stranger. Walk in silence, and perhaps He will mark you.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("The God watches the smooth scalp, the shorn crown, and the sacred beard. May you keep the order He has set.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have cast aside vanity and clothed yourself in discipline. Know this: in the shaving of the head, the Bearded God has stripped you of falsehood, and in obedience, you will be clothed in His mystery.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("Rise, child of the One True God. Go forth and cleanse the unkepmt.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the order of hair and flesh, the chain of station, the discipline of silence. I preach the hidden God whose name is known only to His true servants, and who alone judges who may grow, and who must be shorn.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("I speak of the unseen hand that raises priest above man, man above woman, and all above the chaos of the unshorn.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Prove it in the razor’s bite. Shave your crown bare, keep it clean, and accept the humility He demands. Prove it in silence, for the Bearded God loves not idle chatter but obedience.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("And prove it in patience — for none may reach the beard before the God Himself grants the call. To wait is to serve; to endure is to worship.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Cults", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("Unlike many of the other Free Cities cults, the Disciples of the Bearded God only acknowledge and worship their own god. The name of this god is secret only to their highest priests, but since only their priests are allowed beards, it has generally been called the Bearded God by outsiders. Indeed, the allowance of hair seems to be of import: only men are permitted to have hair on their heads, and only priests are allowed beards, while women are required to shave their heads bald.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("Unlike many of the other Free Cities cults, the Disciples of the Bearded God only acknowledge and worship their own god. The name of this god is secret only to their highest priests, but since only their priests are allowed beards, it has generally been called the Bearded God by outsiders. Indeed, the allowance of hair seems to be of import: only men are permitted to have hair on their heads, and only priests are allowed beards, while women are required to shave their heads bald.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("Disciples of the Bearded God", null);
        }

        public override string GetId()
        {
            return "bearded_god";
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
            return new TextObject("Bearded Man", null);
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "lorathi";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture) || (CultureHelpers.IsCultureEssosi(hero.Culture) && MBRandom.RandomFloat < 0.1f);
        }
    }
}

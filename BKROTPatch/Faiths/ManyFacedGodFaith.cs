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
    internal class ManyFacedGodFaith : MonotheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_EN5"); // Braavos
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("1.116.140.1836.1836.768.788.1.0.0.411.140.116.847.847.764.764.1.0.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to swear an oath to the Many-Faced God.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pledge an oath to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? The Many-Faced God does not easily forgive those who betray an oath.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("Would you pray to the Many-Faced God?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has sworn an oath to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("To deny death is forbidden. To cling to life when the gift of release is due, that is blasphemy. To take life without purpose is also forbidden, for the God is merciful, not wanton.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Greed, cruelty, and vanity have no place before Him. And above all, it is forbidden to claim one face of the God greater than another — for He is all faces, all deaths, all endings.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("All men must die. May your end, when it comes, be gentle.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("Valar morghulis, my {?PLAYER.GENDER}sister{?}brother{\\?}. All men must serve, all men must die.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have set down your fear and taken up truth. In serving the Many-Faced God, you are free. Know this: when your suffering grows heavy, He will unburden you.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("When you are called, He will claim you, swift and merciful. Valar morghulis.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach release. I preach the gift that ends pain, the mercy that ends fear. I preach that all gods are but masks of the One, Him of Many Faces, who comes for kings and beggars alike. To Him we owe our final breath, and in Him all suffering ends.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("Valar dohaeris, valar morghulis. All men must serve, and all men must die.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Prove it in surrender. Accept that your life is not your own, but His. Prove it in mercy, offering release to those who suffer beyond bearing.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("And prove it in humility: see the Many Faces in all gods, all people, all deaths, and deny none. Service to the God is not shouted; it is lived, in silence and obedience.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Cults", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("The Many-Faced God is the God of All Death, and any other death gods worshiped in the world are actually his \"faces\" or incarnations. To live is to suffer, and Him of Many Faces offers a merciful end to that suffering.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("The Many-Faced God is the God of All Death, and any other death gods worshiped in the world are actually his \"faces\" or incarnations. To live is to suffer, and Him of Many Faces offers a merciful end to that suffering. All know the Many-Faced God, even if they are not aware of it; when one prays to the Father of the Andals, the Lion of Night, Yndros of the Twilight, the God-on-Earth, and so on, they pray to the Many-Faced God. Death is his reward, and death is his gift, and we all will be given it.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("Disciples of The Many-Faced God", null);
        }

        public override string GetId()
        {
            return "many_faced_god";
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
            return new TextObject("Faceless Man", null);
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

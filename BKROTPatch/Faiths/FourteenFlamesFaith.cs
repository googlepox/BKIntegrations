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
    internal class FourteenFlamesFaith : PolytheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "ROT_town20"); // Elyria
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.142.131.1836.1836.768.788.1.0.0.411.132.116.400.400.764.914.1.0.0.120.132.116.335.335.764.564.1.1.0");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to pray to the Fourteen Flames.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pray to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? The Fourteen Flames burn away all falsehoods.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("And which of the Flames would you like to pray to?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has prayed to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("The fire of the volcanoes speaks, and the gods see all. To deny the Flames, to disrespect the blood offered, or to scorn the dragons is forbidden. Neglect of ritual, betrayal of the kin or the state, and turning against the gods’ children draws wrath.", null); ;
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Yet arrogance before the other faiths is also forbidden, for the Valyrian gods welcomed many, and pride blinds the faithful to the balance of the world. Honor the Flames, respect the blood, and respect all gods — that is the law of the Old Valyrian Pantheon.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("May the Flames warm your path, traveler, and may the dragons guard your steps.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("{?PLAYER.GENDER}Sister{?}Brother{\\?}, may the gods of Fire and Blood watch over you, and may your deeds honor the Flames.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("You have stepped into the fires of the Old Valyrian gods. May the volcanoes guard you, the dragons guide you, and your blood honor the divine.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("Walk now in the ways of Fire and Blood, and may they grant you wisdom.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the reverence of the Old Valyrian Pantheon, gods born of Fire and Blood. I teach respect for the volcanoes, the dragons, and the sacred bloodlines of the world.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("Yet I also teach tolerance — for the Old Valyrians knew that the divine speaks in many forms, and the faithful may honor many gods while serving the Flames.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Prove faith in action: ritual offerings to the volcanoes, care for the dragons and sacred bloodlines, and respect for the teachings of fire and balance.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Let your deeds honor the pantheon, and let your heart burn with devotion as the volcanoes themselves burn.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Cults", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("The ancient religion of the Valyrian Freehold, this faith worships the personification of the fourteen volcanoes surrounding the Lands of the Long Summer. Despite the worship of these gods, the Valyrians were very welcoming to other faiths and gods.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("The ancient religion of the Valyrian Freehold, this faith worships the personification of the fourteen volcanoes surrounding the Lands of the Long Summer. Despite the worship of these gods, the Valyrians were very welcoming to other faiths and gods. This faith worships the Gods of the Old Valyrian Pantheon, gods of fire and blood, their icons both dragon and human.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("The Fourteen Flames", null);
        }

        public override string GetId()
        {
            return "fourteen_flames";
        }

        public override int GetIdealRank(Settlement settlement)
        {
            if (settlement.StringId == "ROT_town20")
            {
                return 2;
            }
            return 1;
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            bool possible = true;
            TextObject text = new TextObject("You will be converted", null);
            bool flag = !this.IsCultureNaturalFaith(hero.Culture) && hero.Culture.StringId != "valyrian";
            if (flag)
            {
                possible = false;
                text = this.GetInductionExplanationText();
            }
            return new ValueTuple<bool, TextObject>(possible, text);
        }

        public override TextObject GetInductionExplanationText()
        {
            return new TextObject("Only Valyrian are accepted.", null);
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
                text = new TextObject("High Pyromancer", null);
            }
            else
            {
                text = new TextObject("Flametender", null);
            }
            return text;
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "valyrian";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture);
        }
    }
}

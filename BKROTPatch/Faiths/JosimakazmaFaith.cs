using BannerKings.Managers.Institutions.Religions.Faiths;
using BKROTPatch.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BKROTPatch.Faiths
{
    internal class JosimakazmaFaith : MonotheisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                return Settlement.All.First((Settlement x) => x.StringId == "town_K6"); // Saath
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.140.131.1836.1836.768.788.1.0.0.401.143.116.847.847.764.764.1.0.0.406.143.116.356.356.764.764.1.0.29");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to swear an oath to Josimakazma.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pledge an oath to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain? Josimakazma does not easily forgive those who betray an oath.", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("Would you pray to the Josimakazma, the Great Sun?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has sworn an oath to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("To dwell in shadow is forbidden. To turn your back on Josimakazma, the Great Sun, is to deny the light from which all life springs.", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Filth of the spirit, deceit of the tongue, and indulgence in corruption are sins that darken the skies. Those who consort with false gods, or wallow in impurity, invite the eclipse. The Sun burns away deceit — and so must we.", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("Lift your eyes, traveler. The Sun sees you, even now.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("May Josimakazma’s rays warm your heart, {?PLAYER.GENDER}sister{?}brother{\\?}. We walk together in His light.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("Child of shadow no longer, you have stepped into the brilliance of Josimakazma. The Great Sun rises in you now — and as He rises, so shall you. Cast away your doubts, your stains, your darkness. You belong to the Light Eternal.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("Go forth, and fear no darkness. The Great Sun's brilliance outshines all.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach the glory of Josimakazma, the Divine Sun, who tore a star from His own body so we might worship in purity. I preach that life begins and ends in His fire, and that all who turn from Him will be swallowed in endless night.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("Yet to the faithful, His light is mercy, His fire is renewal. The Sun rises again and again — and so too may we.", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Rise with the dawn. Cast your sins into the light, where nothing may hide. Fast when the Sun is highest, so your body may remember the fire that sustains it.", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("Give no shelter to falsehood, for truth shines plain as day. Above all, prove your faith by standing unflinching before the blaze — endure what burns away the weak, and be made pure.", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Cults", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("Josimakazma, the Great One Who Rises Again and Again, directed their followers north of the polytheistic Freehold by flinging a star from their own body. There, among the star's fall in the hills of the Great Desolation, they could worship the Sun God in all their purity, removed from those whose sins would one day darken the skies.", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("Josimakazma, the Great One Who Rises Again and Again, directed their followers north of the polytheistic Freehold by flinging a star from their own body. There, among the star's fall in the hills of the Great Desolation, they could worship the Sun God in all their purity, removed from those whose sins would one day darken the skies. The Divine Sun, Josimakazma, is the source of all life and the progenitor of all. It is from it that we owe all.", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("Josimakazma", null);
        }

        public override string GetId()
        {
            return "josimakazma";
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
            return new TextObject("The Cults of the Sarnor welcome all.", null);
        }

        public override int GetMaxClergyRank()
        {
            return 1;
        }

        public override TextObject GetRankTitle(int rank)
        {
            return new TextObject("Luminarch", null);
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "sarnor";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return IsCultureNaturalFaith(hero.Culture) || (CultureHelpers.IsCultureEssosi(hero.Culture) && MBRandom.RandomFloat < 0.3f);
        }
    }
}

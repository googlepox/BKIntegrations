using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKROTPatch.Faiths
{
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
        internal class PearlDivinitiesFaith : PolytheisticFaith
        {
            public override Settlement FaithSeat
            {
                get
                {
                    return Settlement.All.First((Settlement x) => x.StringId == "town_A4"); // Lys
                }
            }

            public override Banner GetBanner()
            {
                return new Banner("11.140.19.1836.1836.768.788.1.0.-30.206.142.116.809.809.764.764.1.0.0");
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
                return new TextObject("The Pearl Divinities see all, and to dishonor Their gifts is a grave offense. To spread ugliness through cruelty, deceit, or oppression is forbidden. To betray trust, to harm the innocent, or to mar creation with violence affronts the Pearl Divinities.", null);
            }

            public override TextObject GetClergyForbiddenAnswerLast(int rank)
            {
                return new TextObject("Pride that blinds, selfishness that destroys, or contempt for beauty and life — these acts draw their disfavor. Walk with grace, honor others, and cherish creation, and you will walk in their light.", null);
            }

            public override TextObject GetClergyGreeting(int rank)
            {
                return new TextObject("May the Pearl Divinities’ light shine upon you, and may your days be filled with grace, joy, and the beauty of life.", null);
            }

            public override TextObject GetClergyGreetingInducted(int rank)
            {
                return new TextObject("The Pearl Divinities honor you, friend. May your work flourish, your heart remain gentle, and your deeds bring light and beauty to the world.", null);
            }

            public override TextObject GetClergyInduction(int rank)
            {
                return new TextObject("You have chosen to walk beneath the Goddesses’ light. May the Pearl Divinities grant you wisdom, compassion, and the strength to create and nurture beauty in all things. From this day forth, your heart joins theirs, and your life reflects their grace.", null);
            }

            public override TextObject GetClergyInductionLast(int rank)
            {
                return new TextObject("The Pearl Divinities embrace you. Walk in their light, and let your life bloom.", null);
            }

            public override TextObject GetClergyPreachingAnswer(int rank)
            {
                return new TextObject("I preach the light and wisdom of the Pearl Divinities, who guide us through love, art, and grace. I teach that life is sacred, that beauty should be honored, and that our deeds must reflect compassion, wisdom, and harmony. To follow them is to lift oneself and the world around you toward the divine feminine.", null);
            }

            public override TextObject GetClergyPreachingAnswerLast(int rank)
            {
                return new TextObject("I preach grace, beauty, and the Goddesses’ guidance in all things.”", null);
            }

            public override TextObject GetClergyProveFaith(int rank)
            {
                return new TextObject("Faith is shown in the honoring of life and beauty. Treat others with compassion, create works that uplift the spirit, protect those in need, and act with wisdom and grace. Those who cultivate kindness, art, and harmony prove themselves devoted to the Pearl Divinities.", null);
            }

            public override TextObject GetClergyProveFaithLast(int rank)
            {
                return new TextObject("Show love, create beauty, act with grace — and your faith is proven.", null);
            }

            public override TextObject GetCultsDescription()
            {
                return new TextObject("Goddesses", null);
            }

            public override TextObject GetDescriptionHint()
            {
                return new TextObject("Followers of the Pearl Divinities, a pantheon of goddesses and gods led by the Weeping Lady, Pantera, Yndros, Bakkalon, and Saagael, tend to cherish beauty and exalt more feminine constructs of power.", null);
            }

            public override TextObject GetFaithDescription()
            {
                return new TextObject("Followers of the Pearl Divinities, a pantheon of goddesses and gods led by the Weeping Lady, Pantera, Yndros, Bakkalon, and Saagael, tend to cherish beauty and exalt more feminine constructs of power. While all gods are welcomed in the Free Cities, those worshiped above others in Lys are the Weeping Lady, Pantera, Yndros of the Twilight, Bakkalon, and Saagael.", null);
            }

            public override TextObject GetFaithName()
            {
                return new TextObject("The Pearl Divinities", null);
            }

            public override string GetId()
            {
                return "pearl_divinities";
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
                return new TextObject("Pearl Priest", null);
            }

            public override TextObject GetZealotsGroupName()
            {
                return new TextObject("", null);
            }

            public override bool IsCultureNaturalFaith(CultureObject culture)
            {
                return culture.StringId == "lyseni";
            }

            public override bool IsHeroNaturalFaith(Hero hero)
            {
                return IsCultureNaturalFaith(hero.Culture);
            }
        }
    }

}

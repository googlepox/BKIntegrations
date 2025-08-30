using BannerKings.Managers.Institutions.Religions.Faiths.Rites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;

namespace BKROTPatch.Rites
{
    internal class JosimakazmaOfferingAnimals : CompositeOffering
    {
        public JosimakazmaOfferingAnimals()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("cow"),
                    1
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("hog"),
                    1
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("sheep"),
                    1
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The bounty of existence is given to the shrine. Josimakazma fortifies growth, fertility, and prosperity for the faithful.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Life’s Tribute", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires a hog, a sheep, and a cow", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("Will you sacrifice a cow, a sheep, and a hog in the name of Josimakazma?", null), false);
        }
    }
}

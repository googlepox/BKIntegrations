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
    internal class GreatStallionOfferingAnimals : CompositeOffering
    {
        public GreatStallionOfferingAnimals()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("sheep"),
                    1
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("cow"),
                    1
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("hog"),
                    1
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The finest of your herd is laid before the Great Stallion. His blessing grants speed, endurance, and the favor of the wind.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Offering of the Herd", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires a cow, a sheep, and a pig", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer a cow, a sheep, and a pig in the name of the Great Stallion?", null), false);
        }
    }
}

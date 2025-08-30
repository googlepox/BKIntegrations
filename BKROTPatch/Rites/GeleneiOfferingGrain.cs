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
    internal class GeleneiOfferingGrain : CompositeOffering
    {
        public GeleneiOfferingGrain()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("grain"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("apple"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("orange"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The bounty of the earth is laid before Gelenei. Her blessing ensures that the fields will never run empty.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Offering of the First Harvest", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 barrels of apples, 10 sacks of grain, and 10 barrels of oranges", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer grain, apples, and oranges in the name of Gelenei?", null), false);
        }
    }
}

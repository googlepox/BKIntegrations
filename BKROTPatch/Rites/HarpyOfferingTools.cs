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
    internal class HarpyOfferingTools : CompositeOffering
    {
        public HarpyOfferingTools()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("tools"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("marble"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("linen"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The faithful lay symbols of service at the Harpy’s feet. The Harpy grants protection and favor to those who uphold her order.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Offering of Allegiance", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 bundles of tools, 10 rolls of linen, and 10 bricks of marble", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer linen, marble, and tools in the name of the Harpy?", null), false);
        }
    }
}

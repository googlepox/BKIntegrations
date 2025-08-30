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
    internal class JosimakazmaOfferingOil : CompositeOffering
    {
        public JosimakazmaOfferingOil()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("tools"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("oil"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("linen"),
                    5
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The dawn spills into the shrine as your offering is laid down. Josimakazma smiles upon those who honor the cycle of life and renewal.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Offering of the Rising Sun", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 5 bundles of tools, 5 amphorae of oil, and 5 rolls of linen", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("Will you offer oil, linen, and tools in the name of Josimakazma?", null), false);
        }
    }
}

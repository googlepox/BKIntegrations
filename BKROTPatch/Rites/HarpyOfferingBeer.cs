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
    internal class HarpyOfferingBeer : CompositeOffering
    {
        public HarpyOfferingBeer()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("beer"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("meat"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("bread"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Tables are laden and the faithful gather. The Harpy blesses prosperity, unity, and strength among her people.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Feast of Old Ghis", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 barrels of bear, 10 loaves of bread, and 10 pieces of meat", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer beer, meat, and bread in the name of the Harpy?", null), false);
        }
    }
}

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
    internal class ManyFacedGodOfferingFood : CompositeOffering
    {
        public ManyFacedGodOfferingFood()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("wine"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("bread"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("meat"),
                    5
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Cups and sustenance are placed at the shrine. The Many-Faced God receives them, guiding souls and granting mercy to those who suffer.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("The Final Offering", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 5 amphorae of wine, 5 pieces of meat, and 5 loaves of bread", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer bread, meat, and wine in the name of the Many-Faced-God?", null), false);
        }
    }
}

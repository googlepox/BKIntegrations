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
    internal class PrincelyArbiterOfferingFood : CompositeOffering
    {
        public PrincelyArbiterOfferingFood()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("bread"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("wine"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Gifts are laid before the Prince, a promise of loyalty and devotion. The Mercies watch and prosperity flows to those who honor his will.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Tribute of Prosperity", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 loaves of bread and 10 amphorae of wine", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("Will you offer bread and wine in the name of the Great Prince?", null), false);
        }
    }
}

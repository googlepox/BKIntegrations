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
    internal class BoashOfferingGrain : CompositeOffering
    {
        public BoashOfferingGrain()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("bread"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("grain"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Plain sustenance is laid before the altar. The Blind God strengthens the body and mind of the disciplined faithful.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Feast of Abstinence", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 sacks of grain and 10 loaves of bread", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer bread and grain in the name of Boash?", null), false);
        }
    }
}

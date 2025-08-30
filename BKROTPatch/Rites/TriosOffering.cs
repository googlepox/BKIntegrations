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
    internal class TriosOffering : CompositeOffering
    {
        public TriosOffering()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("pouchofgems"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("spice"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("marble"),
                    5
                },
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Gifts are laid before Trios. The Dominar surveys your offering, favoring those who acknowledge his supreme authority.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Tribute of Loyalty", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 amphorae of wine, 10 sacks of spice, and 10 bricks of marble", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer wine, spice, and marble in the name of Trios?", null), false);
        }
    }
}

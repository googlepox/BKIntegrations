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
    internal class GodsFireOfferingWood : CompositeOffering
    {
        public GodsFireOfferingWood()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("oil"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("hardwood"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Flames leap and dance before the shrine. The Gods of Fire consume the offering and bless the faithful with strength and energy.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Sacred Flame", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 hardwood logs and 10 amphorae of oil", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer wood and oil in the name of the Gods of Fire?", null), false);
        }
    }
}

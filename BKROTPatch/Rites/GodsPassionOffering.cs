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
    internal class GodsPassionOffering : CompositeOffering
    {
        public GodsPassionOffering()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("hardwood"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("oil"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("spice"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("A blaze rises from your offering. The Gods of Passion kindle courage and determination", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Flame of Ambition", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 sacks of spice, 10 amphorae of oil, and 10 hardwood logs", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer date fruit, apples, and oranges in the name of the Gods of Summer?", null), false);
        }
    }
}

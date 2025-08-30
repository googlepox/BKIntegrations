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
    internal class GodsFireOfferingMetal : CompositeOffering
    {
        public GodsFireOfferingMetal()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("iron"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("silver"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The molten offerings glow with devotion. The Fire Gods imbue skill, craft, and martial prowess into their followers.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Molten Offering", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 sacks of iron ore and 10 sacks of silver ore", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer iron and silver in the name of the Gods of Fire?", null), false);
        }
    }
}

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
    internal class GodOnEarthOfferingMetal : CompositeOffering
    {
        public GodOnEarthOfferingMetal()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("iron"),
                    3
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("silver"),
                    3
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("gold_ore"),
                    3
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Gifts of loyalty are presented at the shrine. The God-on-Earth grants legitimacy, authority, and protection to the devoted.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Mandate of Heaven", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 3 sacks of gold ore, 3 sacks of silver ore, and 3 sacks of iron ore", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer gold, silver, and iron in the name of God-On-Earth?", null), false);
        }
    }
}

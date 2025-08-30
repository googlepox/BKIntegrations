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
    internal class OldGodsStoneOfferingMarble : Offering
    {
        public OldGodsStoneOfferingMarble()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "marble"), 20)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Stone upon stone, weight upon weight — the cairn grows, a mute monument to your devotion. The Stone remembers all.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Stone Cairn Rite", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 20 stacks of marble bricks", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you build a cairn in the name of the Old Gods of Stone?", null), false);
        }
    }
}

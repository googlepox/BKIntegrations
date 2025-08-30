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
    internal class MotherOffering : Offering
    {
        public MotherOffering()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "bread"), 20)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Upon the altar, the Mother’s table is set with your gift, and her mercy warms your hearth and heart alike.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Bread and Salt Offering", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 20 loaves of bread", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer bread to show the Mother's mercy?", null), false);
        }
    }
}

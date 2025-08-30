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
    internal class SmithOffering : Offering
    {
        public SmithOffering()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "tools"), 10)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Hammer meets anvil in sacred rhythm. The Smith blesses your labor, and your works rise stronger, swifter, truer.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Tools to the Forge", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 loads of jewelry", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer tools in the name of the Smith?", null), false);
        }
    }
}

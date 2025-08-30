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
    internal class HoodedWayfarerOffering : Offering
    {
        public HoodedWayfarerOffering()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "oil"), 10)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Light flickers at the shrine, casting shadows that dance. The Hooded Wayfarer illuminates the steps of those who follow him with care.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Lantern Rite", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 amphorae of oil", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer oil in the name of the Hooded Wayfarer?", null), false);
        }
    }
}

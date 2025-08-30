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
    internal class FatherOfWatersOffering : Offering
    {
        public FatherOfWatersOffering()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "jewelry"), 5)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The waves claim your wealth greedily, as if his scaly hand snatched it below. Fortune’s tides may turn in your favor… or not.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Casting of Coin", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 20 barrels of fish", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer jewelry to the sea in the name of the Father of Waters?", null), false);
        }
    }
}

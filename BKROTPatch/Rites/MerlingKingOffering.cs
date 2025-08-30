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
    internal class MerlingKingOffering : Offering
    {
        public MerlingKingOffering()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "fish"), 20)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("You spread the sea’s bounty as tribute. For a moment, the gulls scatter — as if unseen hands feast first.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Feast of Fishes", null);
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
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer fish in the name of the Merling King?", null), false);
        }
    }
}

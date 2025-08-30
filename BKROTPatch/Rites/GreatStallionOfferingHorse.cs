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
    internal class GreatStallionOfferingHorse : Offering
    {
        public GreatStallionOfferingHorse()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "t2_khuzait_horse"), 1)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The horse's hoof is placed at the shrine. The Great Stallion ensures mobility, speed, and grace for the devoted.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Hooves’ Tribute", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires a Dothraki Warhorse", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer a horse in the name of the Great Stallion?", null), false);
        }
    }
}

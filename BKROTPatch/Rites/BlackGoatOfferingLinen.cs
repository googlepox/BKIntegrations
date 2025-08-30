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
    internal class AquanOfferingMeat : Offering
    {
        public AquanOfferingMeat()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "meat"), 20)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Muscle and sinew laid before Aquan. The Red Bull’s blessing fortifies the body and will of those who honor him.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Offering of Strength", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 20 pieces of meat", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer meat in the name of Aquan, the Red Bull?", null), false);
        }
    }
}

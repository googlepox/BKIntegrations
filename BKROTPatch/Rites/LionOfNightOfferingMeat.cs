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
    internal class LionOfNightOfferingMeat : Offering
    {
        public LionOfNightOfferingMeat()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "meat"), 20)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("No voice speaks; only the rustle of leaves and the night wind. The Lion takes your gift and watches from the darkness.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("The Silent Hunt", null);
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
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer meat in the name of the Lion of Night?", null), false);
        }
    }
}

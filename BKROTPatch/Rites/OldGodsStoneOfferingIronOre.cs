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
    internal class OldGodsStoneOfferingIronOre : Offering
    {
        public OldGodsStoneOfferingIronOre()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "iron"), 20)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The soil closes over the gift of steel and stone. In the deep places, the Old Gods stir, patient and unyielding.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("The Deep Offering", null);
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
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you bury iron ore in the name of the Old Gods of Stone?", null), false);
        }
    }
}

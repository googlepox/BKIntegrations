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
    internal class OldGodsForestOfferingWood : Offering
    {
        public OldGodsForestOfferingWood()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "hardwood"), 20)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The blade bites into living wood, and sap runs like tears. The Forest bears your mark, and its silence seals your prayer.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("The Heart’s Carving", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 20 hardwood logs", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer hardwood in the name of the Old Gods of the Forest?", null), false);
        }
    }
}

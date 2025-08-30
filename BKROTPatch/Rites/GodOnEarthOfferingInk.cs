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
    internal class GodOnEarthOfferingInk : CompositeOffering
    {
        public GodOnEarthOfferingInk()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("Ink"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("Papyrus"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Documents rest upon the altar. The God-on-Earth blesses clarity, wisdom, and foresight in governance.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("The Bureaucrat's Offering", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 scrolls of papyrus and 10 bottles of ink", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer ink and papyrus in the name of God-On-Earth?", null), false);
        }
    }
}

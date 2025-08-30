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
    internal class BoashOfferingPapyrus : CompositeOffering
    {
        public BoashOfferingPapyrus()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("Ink"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("Papyrus"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("spice"),
                    5
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Fragrant smoke curls in darkness. The Blind God grants vision beyond sight, revealing the hidden threads of existence.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Third Eye Offering", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 5 bottles of ink, 5 scrolls of papyrus, and 5 sacks of spice", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer papyrus, ink, and spice in the name of Boash?", null), false);
        }
    }
}

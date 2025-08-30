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
    internal class DrunkenGodOffering : CompositeOffering
    {
        public DrunkenGodOffering()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("wine"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("mead"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("beer"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The liquid spills freely at the altar. The Drunken God laughs, and the faithful feel boldness and mirth in their veins.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("The Overflowing Cup", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 amphorae of wine, 10 barrels of beer, and 10 barrels of mead", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer wine, beer, and mead in the name of the Drunken God?", null), false);
        }
    }
}

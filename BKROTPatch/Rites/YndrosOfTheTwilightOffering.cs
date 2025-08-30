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
    internal class YndrosOfTheTwilightOffering : CompositeOffering
    {
        public YndrosOfTheTwilightOffering()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("wine"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("oil"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("As sun meets moon, your gift is claimed. Yndros’ dual nature stirs, blessing lovers and tricksters alike with shifting fortunes.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Dusk and Dawn Offering", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 amphorae of wine and 10 amphorae of oil", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer wine and oil in the name of Yndros of the Twilight?", null), false);
        }
    }
}

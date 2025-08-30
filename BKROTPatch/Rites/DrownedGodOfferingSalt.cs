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
    internal class DrownedGodOfferingSalt : CompositeOffering
    {
        public DrownedGodOfferingSalt()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("salt"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("fish"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The salt stings your lips as you pour the sea’s bounty before him. The Drowned God takes what is his, and leaves what is yours.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Salt & Sea Offering", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 sacks of salt and 10 barrels of fish", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer a cow and apples in the name of the Old Gods of the Forest?", null), false);
        }
    }
}

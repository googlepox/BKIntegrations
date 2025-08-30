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
    internal class GodsBloodOfferingFood : CompositeOffering
    {
        public GodsBloodOfferingFood()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("bread"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("meat"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("wine"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The table is stained with devotion. The Gods of Blood reward loyalty, courage, and the bonds of kinship.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Feast of Blood", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 loaves of bread, 10 pieces of meat, and 10 amphorae of wine", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer wine, meat, and bread in the name of the Gods of Blood?", null), false);
        }
    }
}

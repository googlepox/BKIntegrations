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
    internal class OldGodsForestOfferingFruit : CompositeOffering
    {
        public OldGodsForestOfferingFruit()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("cow"),
                    1
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("apple"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Laid before the roots, the gifts of flesh and earth lie still. The Forest takes them into its quiet embrace.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Offering of Fruit & Game", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires a cow and 5 baskets of apples", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer a cow and apples in the name of the Old Gods of the Forest?", null), false);
        }
    }
}

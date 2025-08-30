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
    internal class GodsSummerOffering : CompositeOffering
    {
        public GodsSummerOffering()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("apple"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("date_fruit"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("orange"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The bounty of the season rests upon the altar. The Gods of Summer bless growth, abundance, and vigor.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Sun Offering", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 baskets of apples, 10 baskets of oranges, and 10 sacks of date fruit", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer date fruit, apples, and oranges in the name of the Gods of Summer?", null), false);
        }
    }
}

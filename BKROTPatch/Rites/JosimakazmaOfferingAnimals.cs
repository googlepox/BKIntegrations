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
    internal class JosimakazmaOfferingFood : CompositeOffering
    {
        public JosimakazmaOfferingFood()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("hardwood"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("spice"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Smoke rises in swirling patterns. The Sun God blesses vitality, courage, and the energy to persevere.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Flame of Devotion", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 hardwood logs and 10 sacks of spice", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("Will you offer hardwood and spice in the name of Josimakazma?", null), false);
        }
    }
}

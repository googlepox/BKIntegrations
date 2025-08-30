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
    internal class PatternOfferingWine : CompositeOffering
    {
        public PatternOfferingWine()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("marble"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("linen"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("pouchofgems"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("grain"),
                    5
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Opposites are laid side by side. The Patternmaker smiles upon those who reconcile conflict and learn from tension.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Contradiction Offering", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 5 pouches of gems, 5 sacks of grain, 5 bricks of marble, and 5 rolls of linen", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("Will you offer grain, gems, marble, and linen in the name of the Patternmaker?", null), false);
        }
    }
}

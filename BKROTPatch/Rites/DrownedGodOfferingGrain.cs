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
    internal class DrownedGodOfferingGrain : CompositeOffering
    {
        public DrownedGodOfferingGrain()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("grain"),
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
            return new TextObject("Laid before the tide, the tokens of conquest vanish into the foam. The Drowned God smiles upon the raider’s hand.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Salt Wife’s Tears", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 amphorae of wine and 10 sacks of grain", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer wine and grain in the name of the Drowned God?", null), false);
        }
    }
}
